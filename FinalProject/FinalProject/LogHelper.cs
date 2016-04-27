using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{ 
    public class LogHelper
    {
        private static readonly ILog Logger;

        private static ILog GetLogger(string logName)
        {
            ILog log = LogManager.GetLogger(logName);
            return log;

        }
        static LogHelper()
        {
            Logger = GetLogger("MyLog");
        }
        public static void WriteLog(string message)
        {
            Logger.WarnFormat(message);
        }
    }
}
