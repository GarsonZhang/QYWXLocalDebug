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
                case Event:
                    XML.Event = value; break;
                case EventKey:
                    XML.EventKey = value; break;
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
