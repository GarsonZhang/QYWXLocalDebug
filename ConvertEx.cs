/*************************************************************************
    ========================微信企业号开发本地调试========================
    作者：GarsonZhang
    QQ：382237285 
    小广告：【winform快速开发框架，请关注GZFramwork，关注作者GarsonZhang】
 
    感谢你使用本程序，将开源进行到底
    如果你有新需求，请联系我，增加对你的支持
 ************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QYWXLocalDebug
{
    public class ConvertEx
    {
        public static string ToString(object obj)
        {//类型转换
            string tmp = string.Empty;
            try
            {
                tmp = obj.ToString();
            }
            catch
            {
                tmp = string.Empty;
            }
            return tmp;
        }

        public static int ToInt(object obj)
        {
            int tmp = 0;
            try
            {
                tmp = Convert.ToInt32(obj);
            }
            catch
            {
                tmp = 0;
            }
            return tmp;
        }

        public static int ToInt(object obj, int ErrorValue)
        {
            int tmp = ErrorValue;
            try
            {
                tmp = Convert.ToInt32(obj);
            }
            catch
            {
                tmp = ErrorValue;
            }
            return tmp;
        }
    }
}
