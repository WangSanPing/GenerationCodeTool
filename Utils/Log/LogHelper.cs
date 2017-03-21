using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CIS.Utils.Log
{
    /// <summary>
    /// 使用LOG4NET记录日志的功能，在WEB.CONFIG里要配置相应的节点
    /// </summary>
    public class LogHelper
    {
        //log4net日志专用
        public static readonly log4net.ILog logger;

        static LogHelper()
        {
            try
            {
                logger = log4net.LogManager.GetLogger("logger");
                SetConfig();
            }
            catch { }
        }

        public static void SetConfig()
        {
            log4net.Config.XmlConfigurator.Configure();
        }

        public static void SetConfig(FileInfo configFile)
        {
            log4net.Config.XmlConfigurator.Configure(configFile);
        }
        /// <summary>
        /// 普通的文件记录日志
        /// </summary>
        /// <param name="info"></param>
        public static void WriteDebug(string info)
        {
            try
            {
                if (logger.IsDebugEnabled)
                {
                    logger.Debug(info);
                }
            }
            catch { }
        }
        /// <summary>
        /// 普通的文件记录日志
        /// </summary>
        /// <param name="info"></param>
        public static void WriteInfo(string info)
        {
            try
            {
                if (logger.IsInfoEnabled)
                {
                    logger.Info(info);
                }
            }
            catch { }
        }
        /// <summary>
        /// 错误日志
        /// </summary>
        /// <param name="info"></param>
        /// <param name="se"></param>
        public static void WriteError(string info, Exception ex)
        {
            try
            {
                if (logger.IsErrorEnabled)
                {
                    logger.Error(info, ex);
                }
            }
            catch { }
        }
        /// <summary>
        /// 错误日志
        /// </summary>
        /// <param name="info"></param>
        /// <param name="se"></param>
        public static void WriteError(Exception ex)
        {
            try
            {
                if (logger.IsErrorEnabled)
                {
                    logger.Error(ex);
                }
            }
            catch { }
        }
    }
}
