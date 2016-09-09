using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace QYWXLocalDebug.XMLRequest
{
    public class BoundXmlThirdPartyCallback : BoundXmlBase
    {

        public const string InfoType = "InfoType";
        public const string SuiteId = "SuiteId";
        public const string SuiteTicket = "SuiteTicket";
        public const string AuthCorpId = "AuthCorpId";
        public const string AuthCode = "AuthCode";
        public const string Seq = "Seq";

        public BoundXmlThirdPartyCallback()
        {
            xml = new RequestXmlThirdPartyCallback();
        }


        public RequestXmlThirdPartyCallback Xml
        {
            get
            {
                return xml as RequestXmlThirdPartyCallback;
            }
        }

        protected override void key_Validated(object sender, EventArgs e)
        {
            CurrentControl = (sender as Control);
            Debug.Assert(CurrentControl != null, "CurrentControl != null");
            var attribute = ConvertEx.ToString(CurrentControl.Tag);

            SetAttribute(attribute, CurrentControl.Text);


            base.key_Validated(sender, e);
        }

        protected override void SetAttribute(string attribte, string value)
        {
            switch (attribte)
            {
                case ToUserName:
                    Xml.ToUserName = value; break;
                case FromUserName:
                    Xml.FromUserName = value; break;
                case CreateTime:
                    Xml.CreateTime = value; break;
                case MsgType:
                    Xml.MsgType = value; break;
                case AgentID:
                    Xml.AgentID = value; break;
                case InfoType:
                    Xml.InfoType = value; break;
                case SuiteId:
                    Xml.SuiteId = value; break;
                case SuiteTicket:
                    Xml.SuiteTicket = value; break;
                case AuthCorpId:
                    Xml.AuthCorpId = value; break;
                case AuthCode:
                    Xml.AuthCode = value; break;
                case Seq:
                    Xml.Seq = value; break;
                default:
                    {
                        throw new Exception("没有找到对应的字段：" + attribte);
                    }
            }
        }

    }
}