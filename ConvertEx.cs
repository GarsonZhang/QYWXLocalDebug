/*************************************************************************
    ========================΢����ҵ�ſ������ص���========================
    ���ߣ�GarsonZhang
    QQ��382237285
    ��л��ʹ�ñ����򣬽���Դ���е���
    �����������������ϵ�ң����Ӷ����֧��
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
        {//����ת��
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
