using System;
using System.Windows.Forms;

namespace QYWXLocalDebug.XMLRequest
{
    public class BoundXmlText : BoundXmlBase
    {

        public const string Content = "Content";
        public const string MsgId = "MsgId";

        public BoundXmlText()
        {
            xml = new RequestXmlText();
        }


        public RequestXmlText XML
        {
            get
            {
                return xml as RequestXmlText;
            }
        }

        protected override void key_Validated(object sender, EventArgs e)
        {
            CurrentControl = (sender as TextBox);
            string attribute = ConvertEx.ToString(CurrentControl.Tag);

            SetAttribute(attribute, CurrentControl.Text);


            base.key_Validated(sender, e);
        }

        protected override void SetAttribute(string attribte, string value)
        {
            switch (attribte)
            {
                case ToUserName:
                    XML.ToUserName = value; break;
                case FromUserName:
                    XML.FromUserName = value; break;
                case CreateTime:
                    XML.CreateTime = value; break;
                case MsgType:
                    XML.MsgType = value; break;
                case Content:
                    XML.Content = value; break;
                case MsgId:
                    XML.MsgId = value; break;
                case AgentID:
                    XML.AgentID = value; break;
                default:
                {
                    throw new Exception("没有找到对应的字段：" + attribte);
                }
            }
        }

    }
}