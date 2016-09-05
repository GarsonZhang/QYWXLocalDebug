using System;

namespace QYWXLocalDebug.XMLRequest
{
    public class RequestXmlText : RequestXmlBase
    {
        public string Content { get; set; }
        public string MsgId { get; set; }

        public override string GetXML()
        {
            string Result = "<xml>" + Environment.NewLine
                            + String.Format("<ToUserName><![CDATA[{0}]]></ToUserName>", ToUserName) + Environment.NewLine
                            + String.Format("<FromUserName><![CDATA[{0}]]></FromUserName>", FromUserName) + Environment.NewLine
                            + String.Format("<CreateTime>{0}</CreateTime>", CreateTime) + Environment.NewLine
                            + String.Format("<MsgType><![CDATA[{0}]]></MsgType>", MsgType) + Environment.NewLine
                            + String.Format("<Content><![CDATA[{0} ]]></Content>", Content) + Environment.NewLine
                            + String.Format("<MsgId>{0}</MsgId>", MsgId) + Environment.NewLine
                            + String.Format("<AgentID>{0}</AgentID>", AgentID) + Environment.NewLine
                            + "</xml>";
            return Result;
        }
    }
}