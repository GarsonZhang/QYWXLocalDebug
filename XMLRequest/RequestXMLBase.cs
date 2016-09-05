using System;

namespace QYWXLocalDebug.XMLRequest
{
    public class RequestXmlBase
    {
        public string ToUserName { get; set; }
        public string FromUserName { get; set; }
        public string CreateTime { get; set; }
        public string MsgType { get; set; }
        public string AgentID { get; set; }

        public virtual string GetXml()
        {
            throw new NotImplementedException();
        }
    }

    public delegate void XmlChanged(RequestXmlBase xml);
}