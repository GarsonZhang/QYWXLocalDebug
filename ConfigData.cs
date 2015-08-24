/*************************************************************************
    ========================微信企业号开发本地调试========================
    作者：GarsonZhang
    QQ：382237285 
    小广告：【winform快速开发框架，请关注GZFramwork，关注作者GarsonZhang】
 
    感谢你使用本程序，将开源进行到底
    如果你有新需求，请联系我，增加对你的支持
 ************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QYWXLocalDebug
{


    public class BoundTextConfig
    {
        Dictionary<TextBox, string> lstTxt = new Dictionary<TextBox, string>();

        public void Add(TextBox txt, string Attribute)
        {
            if (lstTxt.ContainsKey(txt)) return;
            lstTxt.Add(txt, Attribute);
        }
        public void Remove(TextBox txt)
        {
            if (!lstTxt.ContainsKey(txt)) return;
            lstTxt.Remove(txt);
        }

        public void IniNotice()
        {
            foreach (var key in lstTxt.Keys)
            {
                key.Tag = lstTxt[key];
                key.Text = ConfigData.GetAttribute(lstTxt[key]);
                key.Validated += key_Validated;
            }
        }

        TextBox CurrentTextBox;
        void key_Validated(object sender, EventArgs e)
        {
            CurrentTextBox = (sender as TextBox);
            string attribute = ConvertEx.ToString(CurrentTextBox.Tag);

            ConfigData.SetAttribute(attribute, CurrentTextBox.Text);
        }
    }





    public class ConfigData
    {

        public const string FCorpToken = "CorpToken";
        public const string FCorpID = "CorpID";
        public const string FEncodingAESKey = "EncodingAESKey";
        public const string FURL = "URL";
        public const string FMsg_Signatrue = "msg_signature";
        public const string FTimestamp = "timestamp";
        public const string FNonce = "nonce";

        public const string FEchostr = "echostr";


        public static string GetAttribute(string Attribte)
        {
            string value = string.Empty;
            switch (Attribte)
            {
                case FCorpToken: 
                    value = CorpToken; break;
                case FCorpID:
                    value = CorpID; break;
                case FEncodingAESKey:
                    value = EncodingAESKey; break;
                case FURL:
                    value = URL; break;
                case FMsg_Signatrue:
                    value = Msg_Signatrue; break;
                case FTimestamp:
                    value = Timestamp; break;
                case FNonce:
                    value = Nonce; break;
                case FEchostr:
                    value = Echostr; break;
                default:
                    {
                        throw new Exception("没有找到对应的字段：" + Attribte);
                    }
            }
            return value;
        }

        public static void SetAttribute(string Attribte,string Value)
        {
            switch (Attribte)
            {
                case FCorpToken:
                    CorpToken=Value; break;
                case FCorpID:
                    CorpID=Value; break;
                case FEncodingAESKey:
                    EncodingAESKey=Value; break;
                case FURL:
                    URL=Value; break;
                case FMsg_Signatrue:
                    Msg_Signatrue=Value; break;
                case FTimestamp:
                    Timestamp=Value; break;
                case FNonce:
                    Nonce=Value; break;
                case FEchostr:
                    Echostr=Value; break;
                default:
                    {
                        throw new Exception("没有找到对应的字段：" + Attribte);
                    }
            }
        }


        public static string CorpToken
        {
            get
            {

                return INI.GetKeyValue(FCorpToken);
            }
            set
            {
                INI.SetKeyValue(FCorpToken, value);
            }
        }

        public static string CorpID
        {
            get
            {
                return INI.GetKeyValue(FCorpID);
            }
            set
            {
                INI.SetKeyValue(FCorpID, value);
            }
        }

        public static string EncodingAESKey
        {
            get
            {
                return INI.GetKeyValue(FEncodingAESKey);
            }
            set
            {
                INI.SetKeyValue(FEncodingAESKey, value);
            }
        }


        public static string URL
        {
            get
            {
                return INI.GetKeyValue(FURL);
            }
            set
            {
                INI.SetKeyValue(FURL, value);
            }
        }

        public static string Msg_Signatrue
        {
            get
            {
                return INI.GetKeyValue(FMsg_Signatrue);
            }
            set
            {
                INI.SetKeyValue(FMsg_Signatrue, value);
            }
        }

        public static string Timestamp
        {
            get
            {
                return INI.GetKeyValue(FTimestamp);
            }
            set
            {
                INI.SetKeyValue(FTimestamp, value);
            }
        }


        public static string Nonce
        {
            get
            {
                return INI.GetKeyValue(FNonce);
            }
            set
            {
                INI.SetKeyValue(FNonce, value);
            }
        }


        public static string Echostr
        {
            get
            {
                return INI.GetKeyValue(FEchostr);
            }
            set
            {
                INI.SetKeyValue(FEchostr, value);
            }
        }


      
    }
}
