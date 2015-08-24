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
    public partial class XmlAttributeText : XmlAttributeBase
    {
        public XmlAttributeText()
        {
            InitializeComponent();
        }

        private void TextAttribute_Load(object sender, EventArgs e)
        {
            if (CheckDesingModel.IsDesingMode) return;

            txt_MsgType.Text = "text";
            //模拟微信发送消息
            BoundXMLText XMLText = new BoundXMLText();
            XMLText.Add(txt_ToUserName, BoundXMLText.ToUserName);
            XMLText.Add(txt_FromUserName, BoundXMLText.FromUserName);
            XMLText.Add(txt_CreateTime, BoundXMLText.CreateTime);
            XMLText.Add(txt_MsgType, BoundXMLText.MsgType);
            XMLText.Add(txt_Content, BoundXMLText.Content);
            XMLText.Add(txt_MsgId, BoundXMLText.MsgId);
            XMLText.Add(txt_AgentID, BoundXMLText.AgentID);

            XMLText.IniNotice();

            XMLText.XMLChanged += XML_AttributeChanged;
        }

       

    }
}
