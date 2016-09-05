using System;

namespace QYWXLocalDebug.XMLRequest
{
    public class RequestXmlThirdPartyCallback : RequestXmlBase
    {
        public string InfoType { get; set; }
        public string SuiteId { get; set; }
        public string SuiteTicket { get; set; }
        public string AuthCorpId { get; set; }
        public string AuthCode { get; set; }
        public string Seq { get; set; }

        public override string GetXml()
        {
            string result = "<xml>" + Environment.NewLine
                            + String.Format("<SuiteId><![CDATA[{0}]]></SuiteId>", SuiteId) + Environment.NewLine
                            + String.Format("<InfoType><![CDATA[{0}]]></InfoType>", InfoType) + Environment.NewLine
                            + String.Format("<TimeStamp>{0}</TimeStamp>", CreateTime) + Environment.NewLine
                            + String.Format("<SuiteTicket><![CDATA[{0}]]></SuiteTicket>", SuiteTicket) + Environment.NewLine
                            + String.Format("<AuthCorpId><![CDATA[{0}]]></AuthCorpId>", AuthCorpId) + Environment.NewLine
                            + String.Format("<AuthCode><![CDATA[{0}]]></AuthCode>", AuthCode) + Environment.NewLine
                            + String.Format("<Seq>{0}</Seq>", Seq) + Environment.NewLine
                            + "</xml>";
            return result;
        }
    }
}