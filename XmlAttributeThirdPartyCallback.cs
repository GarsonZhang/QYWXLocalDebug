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

            //模拟微信发送消息
            BoundXmlThirdPartyCallback XMLText = new BoundXmlThirdPartyCallback();
            XMLText.Add(txt_ToUserName, BoundXmlBase.ToUserName);
            XMLText.Add(txt_FromUserName, BoundXmlBase.FromUserName);
            XMLText.Add(txt_CreateTime, BoundXmlBase.CreateTime);
            XMLText.Add(txt_MsgType, BoundXmlBase.MsgType);
            XMLText.Add(txt_AgentID, BoundXmlBase.AgentID);
            XMLText.Add(cmbInfoType, BoundXmlThirdPartyCallback.InfoType);
            XMLText.Add(txtSuiteId, BoundXmlThirdPartyCallback.SuiteId);
            XMLText.Add(txtSuiteTicket, BoundXmlThirdPartyCallback.SuiteTicket);
            XMLText.Add(txtAuthCorpId, BoundXmlThirdPartyCallback.AuthCorpId);
            XMLText.Add(txtAuthCode, BoundXmlThirdPartyCallback.AuthCode);
            XMLText.Add(txtSeq, BoundXmlThirdPartyCallback.Seq);

            XMLText.IniNotice();

            XMLText.XMLChanged += XML_AttributeChanged;
        }
    }
}
