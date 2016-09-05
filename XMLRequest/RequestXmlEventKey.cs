using System;

namespace QYWXLocalDebug.XMLRequest
{
    public class RequestXmlEventKey : RequestXmlBase
    {
        public string Event { get; set; }
        public string EventKey { get; set; }

        public override string GetXml()
        {


            string Result = "<xml>" + Environment.NewLine
                            + String.Format("<ToUserName><![CDATA[{0}]]></ToUserName>", ToUserName) + Environment.NewLine
                            + String.Format("<FromUserName><![CDATA[{0}]]></FromUserName>", FromUserName) + Environment.NewLine
                            + String.Format("<CreateTime>{0}</CreateTime>", CreateTime) + Environment.NewLine
                            + String.Format("<MsgType><![CDATA[{0}]]></MsgType>", MsgType) + Environment.NewLine
                            + String.Format("<Event><![CDATA[{0}]]></Event>", Event) + Environment.NewLine
                            + String.Format("<EventKey><![CDATA[{0}]]></EventKey>", EventKey) + Environment.NewLine
                            + String.Format("<AgentID>{0}</AgentID>", AgentID) + Environment.NewLine
                            + "</xml>";
            return Result;
        }
    }
}