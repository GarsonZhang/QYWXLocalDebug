using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QYWXLocalDebug.XMLRequest;

namespace QYWXLocalDebug
{
    public partial class XmlAttributeEventKey : XmlAttributeBase
    {
        public XmlAttributeEventKey()
        {
            InitializeComponent();
        }

        private void AttributeEventKey_Load(object sender, EventArgs e)
        {
            if (CheckDesingModel.IsDesingMode) return;

            txt_MsgType.Text = "event";
            //模拟微信发送消息
            BoundXMLEvent_Key XML = new BoundXMLEvent_Key();
            XML.Add(txt_ToUserName, BoundXMLEvent_Key.ToUserName);
            XML.Add(txt_FromUserName, BoundXMLEvent_Key.FromUserName);
            XML.Add(txt_CreateTime, BoundXMLEvent_Key.CreateTime);
            XML.Add(txt_MsgType, BoundXMLEvent_Key.MsgType);
            XML.Add(txt_Event, BoundXMLEvent_Key.Event);
            XML.Add(txt_EventKey, BoundXMLEvent_Key.EventKey);
            XML.Add(txt_AgentID, BoundXMLEvent_Key.AgentID);

            XML.IniNotice();

            XML.XMLChanged += XML_AttributeChanged;
        }

    }
}
