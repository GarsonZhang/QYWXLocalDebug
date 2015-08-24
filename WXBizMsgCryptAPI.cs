/*************************************************************************
    ========================微信企业号开发本地调试========================
    作者：GarsonZhang
    QQ：382237285 
    小广告：【winform快速开发框架，请关注GZFramwork，关注作者GarsonZhang】
 
    感谢你使用本程序，将开源进行到底
    如果你有新需求，请联系我，增加对你的支持
 ************************************************************************/
using QYWXLocalDebug.XMLRequest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace QYWXLocalDebug
{
    public class WXBizMsgCryptAPI : WXBizMsgCrypt
    {



        URLParam CurrentURLParam;
        public WXBizMsgCryptAPI(string sCorpToken, string sEncodingAESKey, string sCorpID)
            : base(sCorpToken, sEncodingAESKey, sCorpID)
        {
            CurrentURLParam = new URLParam();
        }

        #region 生成回调各参数及其XML

        /// <summary>
        /// 解密获取的结果
        /// </summary>
        /// <param name="Result"></param>
        /// <returns></returns>
        public string APIResultHandler(string Result)
        {
            try
            {

                XmlDocument CBdoc = new XmlDocument();
                XmlNode CBroot;

                CBdoc.LoadXml(Result);
                CBroot = CBdoc.FirstChild;
                string CBsEncryptMsg = CBroot["Encrypt"].InnerText;
                string CBMsgSignature = CBroot["MsgSignature"].InnerText;
                string CBTimeStamp = CBroot["TimeStamp"].InnerText;
                string CBNonce = CBroot["Nonce"].InnerText;

                string DecResult = "";
                int i = DecryptMsg(CBMsgSignature, CBTimeStamp, CBNonce, Result, ref DecResult);
                if (i == 0)
                {
                    return DecResult;
                }
                else
                {
                    return i.ToString();
                }
            }
            catch
            {
                return "Result";
            }
        }

        /// <summary>
        /// 微信发送消息参数准备,返回timestamp,nonce,msg_singature
        /// </summary>
        /// <param name="msg">需要发送的消息</param>
        /// <param name="Data">加密后的消息</param>
        public URLParam APIEncryptMsg(string msg, ref string Data)
        {

            //刷新一组随机数
            CurrentURLParam.timestamp = CommonTools.GetCreateTime();
            CurrentURLParam.nonce = CommonTools.GetNonce();


            string sData = "";
            string msg_Signature = "";
            //加密消息并返回新的msg_signature
            APIEncryptMsg(msg, CurrentURLParam.timestamp, CurrentURLParam.nonce, ref sData, ref msg_Signature);//加密并获得Sign

            //记录新的msg_Signature
            CurrentURLParam.msg_signature = msg_Signature;

            Data = sData;

            return CurrentURLParam;
        }

        /// <summary>
        /// 加密消息并返回新的msg_signature
        /// </summary>
        /// <param name="msg">需要发送(加密)的数据,微信规定，发送数据前先进行加密处理</param>
        /// <param name="Data">返回加密后的XML</param>
        /// <param name="msg_Signature">返回新的msg_Signature</param>
        /// <returns></returns>
        private int APIEncryptMsg(string msg, string timestamp, string Nonce, ref string Data, ref string msg_Signature)
        {
            int i = EncryptMsg(msg, timestamp, Nonce, ref Data);
            XmlDocument doc = new XmlDocument();
            XmlNode root;
            string sEncryptMsg;

            if (i == 0)//刷新signature
            {

                doc.LoadXml(Data);
                root = doc.FirstChild;
                sEncryptMsg = root["Encrypt"].InnerText;

                msg_Signature = CommonTools.GetSignature(m_sToken, timestamp, Nonce, sEncryptMsg);
            }
            return i;
        }

        /// <summary>
        /// 获得Encrypt节点
        /// </summary>
        /// <param name="EncryXMLData">通过加密后的XML格式数据</param>
        /// <returns></returns>
        public string APIGetEncrypt(string EncryXMLData)
        {
            XmlDocument doc = new XmlDocument();
            XmlNode root;
            string sEncryptMsg;


            doc.LoadXml(EncryXMLData);
            root = doc.FirstChild;
            sEncryptMsg = root["Encrypt"].InnerText;
            return sEncryptMsg;
        }

        #endregion
    }
}
