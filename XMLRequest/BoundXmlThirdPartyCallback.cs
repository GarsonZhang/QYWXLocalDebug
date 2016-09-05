using System;
using System.Windows.Forms;

namespace QYWXLocalDebug.XMLRequest
{
    public class BoundXmlThirdPartyCallback : BoundXmlBase
    {

        public const string Content = "Content";
        public const string MsgId = "MsgId";

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
                case Content:
                    XML.Content = Value; break;
                case MsgId:
                    XML.MsgId = Value; break;
                case AgentID:
                    XML.AgentID = Value; break;
                default:
                {
                    throw new Exception("没有找到对应的字段：" + Attribte);
                }
            }
        }

    }
}