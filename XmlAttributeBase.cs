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
    public partial class XmlAttributeBase : UserControl
    {
        public TextBox XMLTextBox { get; set; }
        public XmlAttributeBase()
        {
            InitializeComponent();
        }

        //XMLText自定义的XMLChanged事件，用于刷新发送消息的xml格式，实时刷新
       protected  void XML_AttributeChanged(RequestXMLBase xml)
        {
            if (XMLTextBox != null)
                XMLTextBox.Text = xml.GetXML();
        }
    }
}
