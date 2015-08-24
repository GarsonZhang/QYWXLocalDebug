/*************************************************************************
    ========================微信企业号开发本地调试========================
    作者：GarsonZhang
    QQ：382237285
    感谢你使用本程序，将开源进行到底
    如果你有新需求，请联系我，增加对你的支持
 ************************************************************************/
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
