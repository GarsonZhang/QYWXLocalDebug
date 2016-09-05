using System;
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


        public RequestXmlThirdPartyCallback XML
        {
            get
            {
                return xml as RequestXmlThirdPartyCallback;
            }
        }

        protected override void key_Validated(object sender, EventArgs e)
        {
            CurrentTextBox = (sender as TextBox);
            string attribute = ConvertEx.ToString(CurrentTextBox.Tag);

            SetAttribute(attribute, CurrentTextBox.Text);


            base.key_Validated(sender, e);
        }

        protected override void SetAttribute(string Attribte, string Value)
        {
            switch (Attribte)
            {
                case ToUserName:
                    XML.ToUserName = Value; break;
                case FromUserName:
                    XML.FromUserName = Value; break;
                case CreateTime:
                    XML.CreateTime = Value; break;
                case MsgType:
                    XML.MsgType = Value; break;
                case AgentID:
                    XML.AgentID = Value; break;
                case InfoType:
                    XML.InfoType = Value; break;
                case SuiteId:
                    XML.SuiteId = Value; break;
                case SuiteTicket:
                    XML.SuiteTicket = Value; break;
                case AuthCorpId:
                    XML.AuthCorpId = Value; break;
                case AuthCode:
                    XML.AuthCode = Value; break;
                case Seq:
                    XML.Seq = Value; break;
                default:
                    {
                        throw new Exception("没有找到对应的字段：" + Attribte);
                    }
            }
        }

    }
}