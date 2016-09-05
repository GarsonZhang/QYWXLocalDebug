﻿/*************************************************************************
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private WXBizMsgCryptAPI _generatedata;

        WXBizMsgCryptAPI GenerateData
        {
            get
            {
                //  构造成功标记
                //  解决第一次设置参数不生效问题,Load事件初始化WXBizMsgCryptAPI时CorpToken, EncodingAESKey, CorpID为空
                if (_generatedata == null || _generatedata.SuccessStruct == false)
                    _generatedata = new WXBizMsgCryptAPI(CorpToken, EncodingAESKey, CorpID);
                return _generatedata;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //模拟微信回调验证
            var BoundConfig = new BoundTextConfig();
            BoundConfig.Add(txt_CorpToken, ConfigData.FCorpToken);
            BoundConfig.Add(txt_CorpID, ConfigData.FCorpID);
            BoundConfig.Add(txt_EncodingAESKey, ConfigData.FEncodingAESKey);
            BoundConfig.Add(txt_URL, ConfigData.FURL);
            BoundConfig.Add(txt_msg_signature, ConfigData.FMsg_Signatrue);
            BoundConfig.Add(txt_timestamp, ConfigData.FTimestamp);
            BoundConfig.Add(txt_nonce, ConfigData.FNonce);
            BoundConfig.Add(txt_echostr, ConfigData.FEchostr);

            BoundConfig.IniNotice();

            xmlAttributeText1.XmlTextBox = txt_XMLText;
            xmlAttributeEventKey1.XmlTextBox = txt_XMLText;
            xmlAttributeThirdPartyCallback1.XmlTextBox = txt_XMLText;


        }


        //获取参数按钮事件
        private void btn_msg_signature_Click(object sender, EventArgs e)
        {
            //先随机生成一个字符串用于回调验证
            var msg = Guid.NewGuid().ToString().Replace("-", "");
            txt_Msg.Text = msg;


            var Msg_EncryptMsg = "";//加密后的数据
            GetEncryptXML(msg, ref Msg_EncryptMsg);

            var Encrypt = GenerateData.APIGetEncrypt(Msg_EncryptMsg);
            //获取到加密后XML的Encrypt节点，URL编码后以Get方式提交
            txt_echostr.Text = System.Web.HttpUtility.UrlEncode(Encrypt);
        }




        //微信首次回调验证按钮事件
        private void btn_CallBackValidate_Click(object sender, EventArgs e)
        {
            var URL = GenerateValidationURL();
            txt_ValidURL.Text = URL;

            if (string.IsNullOrEmpty(URL)) return;

            txt_ValidBackData.Text = CommonTools.GetWebData(URL);
        }

        //发送文本消息按钮事件
        private void btn_SendText_Click(object sender, EventArgs e)
        {
            txt_TextResult.Text = "";

            var data = "";//加密后的XML数据
            GetEncryptXML(txt_XMLText.Text, ref data);

            txt_EnyXMLText.Text = data;

            var url = GenerateURL();

            if (string.IsNullOrEmpty(url))
            {
                return;
            }
            if (string.IsNullOrEmpty(data))
            {
                MessageBox.Show("需要Post的数据为空！,请填写内容！");
                return;
            }

            bool success;
            var result = CommonTools.TryPost(url, data, out success);

            if (success)
            {
                txt_TextResult.Text = GenerateData.APIResultHandler(result);
            }
            else
            {
                txt_TextResult.Text = result;
            }
        }


        void GetEncryptXML(string msg, ref string sMsg_EncryptMsg)
        {
            var v = GenerateData.APIEncryptMsg(msg, ref sMsg_EncryptMsg);

            //记录生成的URL参数
            txt_msg_signature.Text = v.msg_signature;
            txt_timestamp.Text = v.timestamp;
            txt_nonce.Text = v.nonce;
        }




        #region 生成回调URL相关函数

        /// <summary>
        /// 生成验证回调的URL
        /// </summary>
        /// <returns></returns>
        private string GenerateValidationURL()
        {
            var URL = GenerateURL();
            if (string.IsNullOrEmpty(URL))
                return "";
            if (ValidateTextEmpty(txt_echostr, "请填写echostr(微信回调获取到的)") == true) return "";
            URL += string.Format("&echostr={0}", txt_echostr.Text);
            return URL;
        }

        /// <summary>
        /// 生成发消息用的回调函数
        /// </summary>
        /// <returns></returns>
        private string GenerateURL()
        {
            if (!ValidateBeforGenerateURL())
                return "";
            var urlFormat = "{0}?msg_signature={1}&timestamp={2}&nonce={3}";

            var URL = string.Format(urlFormat, txt_URL.Text, txt_msg_signature.Text, txt_timestamp.Text, txt_nonce.Text);

            return URL;
        }

        /// <summary>
        /// 生成回调带参数URL前验证
        /// </summary>
        /// <returns></returns>
        bool ValidateBeforGenerateURL()
        {
            if (ValidateTextEmpty(txt_URL, "请填写URL(不带参数)") == true) return false;
            if (ValidateTextEmpty(txt_msg_signature, "请填写msg_signature(微信回调获取到的)") == true) return false;
            if (ValidateTextEmpty(txt_timestamp, "请填写timestamp(微信回调获取到的)") == true) return false;
            if (ValidateTextEmpty(txt_nonce, "请填写nonce(微信回调获取到的)") == true) return false;

            return true;

        }

        /// <summary>
        /// 判断textbox是否为空，如果为空返回true，并弹出消息框
        /// </summary>
        /// <param name="txt"></param>
        /// <param name="EmptyMsg"></param>
        /// <returns></returns>
        private bool ValidateTextEmpty(TextBox txt, string EmptyMsg)
        {
            if (string.IsNullOrEmpty(txt.Text))
            {
                MessageBox.Show(EmptyMsg);
                txt_URL.Focus();
                return true;
            }
            return false;
        }

        #endregion



        #region 字段，统一获取WXBizMsgCrypt，text文本内容等，





        string CorpToken
        {
            get
            {
                return txt_CorpToken.Text;
            }
        }
        string EncodingAESKey
        {
            get
            {
                return txt_EncodingAESKey.Text;
            }
        }
        string CorpID
        {
            get
            {
                return txt_CorpID.Text;
            }
        }


        string timestamp
        {
            get
            {
                return txt_timestamp.Text;
            }
        }
        string Nonce
        {
            get
            {
                return txt_nonce.Text;
            }
        }
        string Msg_EncryptMsg
        {
            get
            {
                return txt_msg_signature.Text;
            }
        }

        string Echostr
        {
            get
            {
                return txt_echostr.Text;
            }
        }
        #endregion

        private void Form1_Shown(object sender, EventArgs e)
        {
            frmAbout.ShowForm();
        }



    }


}