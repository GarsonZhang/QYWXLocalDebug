using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QYWXLocalDebug.XMLRequest
{
    public class BoundXmlBase
    {
        
        public const string ToUserName = "ToUserName";
        public const string FromUserName = "FromUserName";
        public const string CreateTime = "CreateTime";
        public const string MsgType = "MsgType";
        public const string AgentID = "AgentID";

        public event XmlChanged XMLChanged;

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

        protected RequestXmlBase xml;

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
}