using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLab.Server.Controller.Logging
{
    public class Log
    {
        public enum LogTypes
        {
            Command_result,
            Error,
            Server_Status,
            User_Activity,
            Warning,
        }
        
        public DateTime Time { get; set; }

        public string Message { get; set; }

        public LogTypes LogType { get; set; }

        public Log(DateTime time, string message, LogTypes logtype)
        {
            this.Time = time;
            this.Message = message;
            this.LogType = logtype;

        }

        public Log() { }
    }
}
