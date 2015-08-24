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

        #region ���ɻص�����������XML

        /// <summary>
        /// ���ܻ�ȡ�Ľ��
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
        /// ΢�ŷ�����Ϣ����׼��,����timestamp,nonce,msg_singature
        /// </summary>
        /// <param name="msg">��Ҫ���͵���Ϣ</param>
        /// <param name="Data">���ܺ����Ϣ</param>
        public URLParam APIEncryptMsg(string msg, ref string Data)
        {

            //ˢ��һ�������
            CurrentURLParam.timestamp = CommonTools.GetCreateTime();
            CurrentURLParam.nonce = CommonTools.GetNonce();


            string sData = "";
            string msg_Signature = "";
            //������Ϣ�������µ�msg_signature
            APIEncryptMsg(msg, CurrentURLParam.timestamp, CurrentURLParam.nonce, ref sData, ref msg_Signature);//���ܲ����Sign

            //��¼�µ�msg_Signature
            CurrentURLParam.msg_signature = msg_Signature;

            Data = sData;

            return CurrentURLParam;
        }

        /// <summary>
        /// ������Ϣ�������µ�msg_signature
        /// </summary>
        /// <param name="msg">��Ҫ����(����)������,΢�Ź涨����������ǰ�Ƚ��м��ܴ���</param>
        /// <param name="Data">���ؼ��ܺ��XML</param>
        /// <param name="msg_Signature">�����µ�msg_Signature</param>
        /// <returns></returns>
        private int APIEncryptMsg(string msg, string timestamp, string Nonce, ref string Data, ref string msg_Signature)
        {
            int i = EncryptMsg(msg, timestamp, Nonce, ref Data);
            XmlDocument doc = new XmlDocument();
            XmlNode root;
            string sEncryptMsg;

            if (i == 0)//ˢ��signature
            {

                doc.LoadXml(Data);
                root = doc.FirstChild;
                sEncryptMsg = root["Encrypt"].InnerText;

                msg_Signature = CommonTools.GetSignature(m_sToken, timestamp, Nonce, sEncryptMsg);
            }
            return i;
        }

        /// <summary>
        /// ���Encrypt�ڵ�
        /// </summary>
        /// <param name="EncryXMLData">ͨ�����ܺ��XML��ʽ����</param>
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
