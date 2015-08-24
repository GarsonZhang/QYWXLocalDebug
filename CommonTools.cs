/*************************************************************************
    ========================微信企业号开发本地调试========================
    作者：GarsonZhang
    QQ：382237285
    感谢你使用本程序，将开源进行到底
    如果你有新需求，请联系我，增加对你的支持
 ************************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace QYWXLocalDebug
{

    public class CheckDesingModel
    {

        //测试提交

        public static bool IsDesingMode
        {
            get
            {
                bool ReturnFlag = false;
                if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                    ReturnFlag = true;
                else if (System.Diagnostics.Process.GetCurrentProcess().ProcessName == "devenv")
                    ReturnFlag = true;
                //if (ReturnFlag)
                //    Msg.Warning("设计模式");
                //else Msg.Warning("非设计模式！");
                return ReturnFlag;
            }
        }
    }

    public class CommonTools
    {
        public static string GetWebData(string URL)
        {
            String ReCode = string.Empty;
            try
            {
                HttpWebRequest wNetr = (HttpWebRequest)HttpWebRequest.Create(URL);
                HttpWebResponse wNetp = (HttpWebResponse)wNetr.GetResponse();
                wNetr.ContentType = "text/html";
                wNetr.Method = "Get";
                Stream Streams = wNetp.GetResponseStream();
                StreamReader Reads = new StreamReader(Streams, Encoding.UTF8);
                ReCode = Reads.ReadToEnd();

                //封闭临时不实用的资料 
                Reads.Dispose();
                Streams.Dispose();
                wNetp.Close();
            }
            catch (Exception ex) { return ex.Message; }

            return ReCode;

        }

        public static string Post(string url, string data)
        {
            string returnData = null;
            try
            {
                byte[] buffer = Encoding.UTF8.GetBytes(data);
                HttpWebRequest webReq = (HttpWebRequest)WebRequest.Create(url);
                webReq.Method = "POST";
                webReq.ContentType = "application/x-www-form-urlencoded";
                webReq.ContentLength = buffer.Length;
                Stream postData = webReq.GetRequestStream();
                webReq.Timeout = 99999999;
                //webReq.ReadWriteTimeout = 99999999;
                postData.Write(buffer, 0, buffer.Length);
                postData.Close();
                HttpWebResponse webResp = (HttpWebResponse)webReq.GetResponse();
                Stream answer = webResp.GetResponseStream();
                StreamReader answerData = new StreamReader(answer);
                returnData = answerData.ReadToEnd();
            }
            catch (Exception ex)
            {
                return "获取错误:"+ex.Message;
            }
            return returnData.Trim() + "\n";
        }



        /// <summary>
        /// 计算出msg_Signature
        /// </summary>
        /// <param name="sToken"></param>
        /// <param name="sTimeStamp"></param>
        /// <param name="sNonce"></param>
        /// <param name="sMsgEncrypt"></param>
        /// <returns></returns>
        public static string GetSignature(string sToken, string sTimeStamp, string sNonce, string sMsgEncrypt)
        {
            ArrayList AL = new ArrayList();
            AL.Add(sToken);
            AL.Add(sTimeStamp);
            AL.Add(sNonce);
            AL.Add(sMsgEncrypt);
            AL.Sort(new DictionarySort());
            string raw = "";
            for (int i = 0; i < AL.Count; ++i)
            {
                raw += AL[i];
            }

            SHA1 sha;
            ASCIIEncoding enc;
            string hash = "";

            sha = new SHA1CryptoServiceProvider();
            enc = new ASCIIEncoding();
            byte[] dataToHash = enc.GetBytes(raw);
            byte[] dataHashed = sha.ComputeHash(dataToHash);
            hash = BitConverter.ToString(dataHashed).Replace("-", "");
            hash = hash.ToLower();
            return hash;
        }

        public class DictionarySort : System.Collections.IComparer
        {
            public int Compare(object oLeft, object oRight)
            {
                string sLeft = oLeft as string;
                string sRight = oRight as string;
                int iLeftLength = sLeft.Length;
                int iRightLength = sRight.Length;
                int index = 0;
                while (index < iLeftLength && index < iRightLength)
                {
                    if (sLeft[index] < sRight[index])
                        return -1;
                    else if (sLeft[index] > sRight[index])
                        return 1;
                    else
                        index++;
                }
                return iLeftLength - iRightLength;

            }
        }


        /// <summary>
        /// 获得消息创建时间
        /// </summary>
        /// <returns></returns>
        public static string GetCreateTime()
        {
            int v =Convert.ToInt32( DateTime.Now.Subtract(new DateTime(1970, 1, 1, 8, 0, 0)).TotalSeconds);
            return v.ToString();
        }
        /// <summary>
        /// 获得随机数Nonce
        /// </summary>
        /// <returns></returns>
        public static string GetNonce()
        {
            Random rd = new Random(Guid.NewGuid().GetHashCode());

            int Length = rd.Next(5, 10);//随机长度

            string Nonce = String.Empty;
            
            //生成第一位随机数，第一位不能是0，
            Nonce += rd.Next(1, 9).ToString();

            for (int i = 1; i < Length; i++)
            {
                Nonce += rd.Next(0, 9).ToString();
            }

            return Nonce;
        }

    }


}
