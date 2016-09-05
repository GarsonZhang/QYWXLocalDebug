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

        public event XmlChanged XmlChanged;

        protected Control CurrentControl;

        protected Dictionary<Control, string> LstControls = new Dictionary<Control, string>();

        public virtual void Add(Control txt, string attribute)
        {
            if (LstControls.ContainsKey(txt)) return;

            LstControls.Add(txt, attribute);
        }

        public virtual void Remove(Control txt)
        {
            if (LstControls.ContainsKey(txt))
                LstControls.Remove(txt);
        }

        public virtual void IniNotice()
        {
            foreach (var key in LstControls.Keys)
            {
                key.Tag = LstControls[key];
                SetAttribute(LstControls[key], key.Text);
                key.Validated += key_Validated;
            }
        }

        protected RequestXmlBase xml;

        protected virtual void key_Validated(object sender, EventArgs e)
        {
            if (XmlChanged != null)
                XmlChanged(xml);
        }

        protected virtual void SetAttribute(string attribte, string value)
        {
            throw new NotImplementedException();
        }


    }
}