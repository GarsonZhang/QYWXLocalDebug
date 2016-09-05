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
            var xmlText = new BoundXmlThirdPartyCallback();
            xmlText.Add(txt_ToUserName, BoundXmlBase.ToUserName);
            xmlText.Add(txt_FromUserName, BoundXmlBase.FromUserName);
            xmlText.Add(txt_CreateTime, BoundXmlBase.CreateTime);
            xmlText.Add(txt_MsgType, BoundXmlBase.MsgType);
            xmlText.Add(txt_AgentID, BoundXmlBase.AgentID);
            xmlText.Add(cmbInfoType, BoundXmlThirdPartyCallback.InfoType);
            xmlText.Add(txtSuiteId, BoundXmlThirdPartyCallback.SuiteId);
            xmlText.Add(txtSuiteTicket, BoundXmlThirdPartyCallback.SuiteTicket);
            xmlText.Add(txtAuthCorpId, BoundXmlThirdPartyCallback.AuthCorpId);
            xmlText.Add(txtAuthCode, BoundXmlThirdPartyCallback.AuthCode);
            xmlText.Add(txtSeq, BoundXmlThirdPartyCallback.Seq);

            xmlText.IniNotice();

            xmlText.XmlChanged += XML_AttributeChanged;
        }
    }
}
