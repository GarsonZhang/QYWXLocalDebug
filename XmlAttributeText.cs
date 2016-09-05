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
            BoundXmlText XMLText = new BoundXmlText();
            XMLText.Add(txt_ToUserName, BoundXmlText.ToUserName);
            XMLText.Add(txt_FromUserName, BoundXmlText.FromUserName);
            XMLText.Add(txt_CreateTime, BoundXmlText.CreateTime);
            XMLText.Add(txt_MsgType, BoundXmlText.MsgType);
            XMLText.Add(txt_Content, BoundXmlText.Content);
            XMLText.Add(txt_MsgId, BoundXmlText.MsgId);
            XMLText.Add(txt_AgentID, BoundXmlText.AgentID);

            XMLText.IniNotice();

            XMLText.XmlChanged += XML_AttributeChanged;
        }

       

    }
}
