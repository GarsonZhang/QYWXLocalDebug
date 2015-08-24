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

namespace QYWXLocalDebug.XMLRequest
{
    public class RequestXMLBase
    {
        public string ToUserName { get; set; }
        public string FromUserName { get; set; }
        public string CreateTime { get; set; }
        public string MsgType { get; set; }
        public string AgentID { get; set; }

        public virtual string GetXML()
        {
            throw new NotImplementedException();
        }
    }
    public class RequestXMLText : RequestXMLBase
    {
        public string Content { get; set; }
        public string MsgId { get; set; }

        public override string GetXML()
        {
            string Result = "<xml>" + Environment.NewLine
                + String.Format("<ToUserName><![CDATA[{0}]]></ToUserName>", ToUserName) + Environment.NewLine
                + String.Format("<FromUserName><![CDATA[{0}]]></FromUserName>", FromUserName) + Environment.NewLine
                + String.Format("<CreateTime>{0}</CreateTime>", CreateTime) + Environment.NewLine
                + String.Format("<MsgType><![CDATA[{0}]]></MsgType>", MsgType) + Environment.NewLine
                + String.Format("<Content><![CDATA[{0} ]]></Content>", Content) + Environment.NewLine
                + String.Format("<MsgId>{0}</MsgId>", MsgId) + Environment.NewLine
               + String.Format("<AgentID>{0}</AgentID>", AgentID) + Environment.NewLine
            + "</xml>";
            return Result;
        }
    }
    public class RequestXMLEvent_Key : RequestXMLBase
    {
        public string Event { get; set; }
        public string EventKey { get; set; }

        public override string GetXML()
        {


            string Result = "<xml>" + Environment.NewLine
                + String.Format("<ToUserName><![CDATA[{0}]]></ToUserName>", ToUserName) + Environment.NewLine
                + String.Format("<FromUserName><![CDATA[{0}]]></FromUserName>", FromUserName) + Environment.NewLine
                + String.Format("<CreateTime>{0}</CreateTime>", CreateTime) + Environment.NewLine
                + String.Format("<MsgType><![CDATA[{0}]]></MsgType>", MsgType) + Environment.NewLine
                + String.Format("<Event><![CDATA[{0}]]></Event>", Event) + Environment.NewLine
                + String.Format("<EventKey><![CDATA[{0}]]></EventKey>", EventKey) + Environment.NewLine
               + String.Format("<AgentID>{0}</AgentID>", AgentID) + Environment.NewLine
            + "</xml>";
            return Result;
        }
    }


    public delegate void XMLChanged(RequestXMLBase xml);

    public class BoundXMLBase
    {
        
        public const string ToUserName = "ToUserName";
        public const string FromUserName = "FromUserName";
        public const string CreateTime = "CreateTime";
        public const string MsgType = "MsgType";
        public const string AgentID = "AgentID";

        public event XMLChanged XMLChanged;

        protected TextBox CurrentTextBox;

        protected Dictionary<TextBox, string> lstTextBox = new Dictionary<TextBox, string>();

        public virtual void Add(TextBox txt, string Attribute)
        {
            if (lstTextBox.ContainsKey(txt)) return;

            lstTextBox.Add(txt, Attribute);
        }

        public virtual void Remove(TextBox txt)
        {
            if (lstTextBox.ContainsKey(txt))
                lstTextBox.Remove(txt);
        }

        public virtual void IniNotice()
        {
            foreach (var key in lstTextBox.Keys)
            {
                key.Tag = lstTextBox[key];
                SetAttribute(lstTextBox[key], key.Text);
                key.Validated += key_Validated;
            }
        }

        protected RequestXMLBase xml;

        protected virtual void key_Validated(object sender, EventArgs e)
        {
            if (XMLChanged != null)
                XMLChanged(xml);
        }

        protected virtual void SetAttribute(string Attribte, string Value)
        {
            throw new NotImplementedException();
        }


    }

    public class BoundXMLText : BoundXMLBase
    {

        public const string Content = "Content";
        public const string MsgId = "MsgId";

        public BoundXMLText()
        {
            xml = new RequestXMLText();
        }


        public RequestXMLText XML
        {
            get
            {
                return xml as RequestXMLText;
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

    public class BoundXMLEvent_Key : BoundXMLBase
    {

        public const string Event = "Event";
        public const string EventKey = "EventKey";

        public BoundXMLEvent_Key()
        {
             xml = new RequestXMLEvent_Key();
        }


        public RequestXMLEvent_Key XML
        {
            get
            {
                return xml as RequestXMLEvent_Key;
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
