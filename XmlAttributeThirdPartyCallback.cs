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
    public partial class XmlAttributeThirdPartyCallback : XmlAttributeBase
    {
        public XmlAttributeThirdPartyCallback()
        {
            InitializeComponent();
        }

        private void XmlAttributeThirdPartyCallback_Load(object sender, EventArgs e)
        {
            if (CheckDesingModel.IsDesingMode) return;

            txt_MsgType.Text = "text";
            //模拟微信发送消息
            BoundXmlThirdPartyCallback XMLText = new BoundXmlThirdPartyCallback();
            XMLText.Add(txt_ToUserName, BoundXmlText.ToUserName);
            XMLText.Add(txt_FromUserName, BoundXmlText.FromUserName);
            XMLText.Add(txt_CreateTime, BoundXmlText.CreateTime);
            XMLText.Add(txt_MsgType, BoundXmlText.MsgType);
            XMLText.Add(txt_Content, BoundXmlText.Content);
            XMLText.Add(txt_MsgId, BoundXmlText.MsgId);
            XMLText.Add(txt_AgentID, BoundXmlText.AgentID);

            XMLText.IniNotice();

            XMLText.XMLChanged += XML_AttributeChanged;
        }
    }
}
