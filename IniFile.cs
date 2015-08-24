/*************************************************************************
    ========================微信企业号开发本地调试========================
    作者：GarsonZhang
    QQ：382237285
    感谢你使用本程序，将开源进行到底
    如果你有新需求，请联系我，增加对你的支持
 ************************************************************************/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace QYWXLocalDebug
{
    public class INI
    {

        //private static string _SaveDate = "SaveDate";

        private static string _Path;
        /// <summary>
        /// 路径
        /// </summary>
        private static string ConfigPath
        {
            get
            {
                if (string.IsNullOrEmpty(_Path))
                    _Path = Application.StartupPath + @"\Config\WXConfig.ini";
                return _Path;
            }
        }

        private static IniFile _ConfigFile;

        /// <summary>
        /// IniFile操作类
        /// </summary>
        public static IniFile ConfigFile
        {
            get
            {
                if (_ConfigFile == null)
                    _ConfigFile = new IniFile(ConfigPath);
                return _ConfigFile;
            }
        }


        public static string GetIP()
        {
            return ConfigFile.IniReadValue("WXQY", "IP", "");
        }
        public static string GetPort()
        {
            return ConfigFile.IniReadValue("WXQY", "Port", "");
        }

        public static string GetKeyValue(string Key, string DefultValue = "")
        {
            return ConfigFile.IniReadValue("WXQY", Key, DefultValue);
        }

       

        /// <summary>
        /// 保存配置
        /// </summary>
        /// <param name="Section"></param>
        /// <param name="Key"></param>
        /// <param name="Value"></param>
        public static void SetKeyValue(string key, string Value)
        {
            ConfigFile.IniWriteValue("WXQY", key, Value);
        }



      
    }


    /// <summary>
    /// 操作INI文件类 
    /// </summary>
    public class IniFile
    {
        private string _path; //INI档案名 
        public string IniPath { get { return _path; } set { _path = value; } }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct STRINGBUFFER
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string szText;
        }

        //读写INI文件的API函数 
        [DllImport("kernel32", CharSet = CharSet.Auto)]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32", CharSet = CharSet.Auto)]
        private static extern int GetPrivateProfileString(string section, string key, string def, out STRINGBUFFER retVal, int size, string filePath);

        //类的构造函数，传递INI档案名 
        public IniFile(string INIPath)
        {
            _path = INIPath;

            string path = IniPath.Substring(0, IniPath.LastIndexOf("\\"));
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);

            if (!File.Exists(_path)) CreateIniFile();
        }

        //写INI文件 
        public void IniWriteValue(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, this._path);
        }

        //读取INI文件指定项目的数据 
        public string IniReadValue(string Section, string Key)
        {
            int i;
            STRINGBUFFER RetVal;
            i = GetPrivateProfileString(Section, Key, null, out RetVal, 255, this._path);
            string temp = RetVal.szText;
            return temp.Trim();
        }

        //读取INI文件指定项目的数据 
        public string IniReadValue(string Section, string Key, string defaultValue)
        {
            int i;
            STRINGBUFFER RetVal;
            i = GetPrivateProfileString(Section, Key, null, out RetVal, 255, this._path);
            string temp = RetVal.szText;
            return temp.Trim() == "" ? defaultValue : temp.Trim();
        }

        /// <summary>
        /// 创建INI文件
        /// </summary>
        public void CreateIniFile()
        {
            StreamWriter w = File.CreateText(_path);
            w.Write("");
            w.Flush();
            w.Close();
        }
    }
}
