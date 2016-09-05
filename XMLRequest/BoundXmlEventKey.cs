/*************************************************************************
    ========================微信企业号开发本地调试========================
    作者：GarsonZhang
    QQ：382237285 
    小广告：【winform快速开发框架，请关注GZFramwork，关注作者GarsonZhang】
 
    感谢你使用本程序，将开源进行到底
    如果你有新需求，请联系我，增加对你的支持
 ************************************************************************/
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QYWXLocalDebug.XMLRequest
{
    public class BoundXmlEventKey : BoundXmlBase
    {

        public const string Event = "Event";
        public const string EventKey = "EventKey";

        public BoundXmlEventKey()
        {
             xml = new RequestXmlEventKey();
        }


        public RequestXmlEventKey XML
        {
            get
            {
                return xml as RequestXmlEventKey;
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
                case Event:
                    XML.Event = Value; break;
                case EventKey:
                    XML.EventKey = Value; break;
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
