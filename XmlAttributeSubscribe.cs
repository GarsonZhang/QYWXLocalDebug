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
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QYWXLocalDebug.XMLRequest;

namespace QYWXLocalDebug
{
    public partial class XmlAttributeSubscribe : XmlAttributeBase
    {
        public XmlAttributeSubscribe()
        {
            InitializeComponent();
        }

        private void XmlAttributeSubscribe_Load(object sender, EventArgs e)
        {
            if (CheckDesingModel.IsDesingMode) return;

            txt_MsgType.Text = "event";
            //模拟微信发送消息
            BoundXmlEventKey XML = new BoundXmlEventKey();
            XML.Add(txt_ToUserName, BoundXmlEventKey.ToUserName);
            XML.Add(txt_FromUserName, BoundXmlEventKey.FromUserName);
            XML.Add(txt_CreateTime, BoundXmlEventKey.CreateTime);
            XML.Add(txt_MsgType, BoundXmlEventKey.MsgType);
            XML.Add(txt_Event, BoundXmlEventKey.Event);
            //XML.Add(txt_EventKey, BoundXMLEvent_Key.EventKey);
            XML.Add(txt_AgentID, BoundXmlEventKey.AgentID);

            XML.IniNotice();

            XML.XmlChanged += XML_AttributeChanged;
        }

      

    }
}
