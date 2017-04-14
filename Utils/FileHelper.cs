using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Utils
{
    public static class FileHelper
    {
        /// <summary>
        /// 创建文件
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="content">生成内容的字符串</param>
        public static void CreateFile(string path, string content)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, UTF8Encoding.UTF8);
            try
            {
                sw.Write(string.IsNullOrWhiteSpace(content) ? "当前文件无内容，请联系管理员！" : content);
                sw.Flush();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sw.Close();
                fs.Close();
            }
        }
    }
}
