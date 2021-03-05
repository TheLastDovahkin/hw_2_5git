using System;
using System.Collections.Generic;
using System.IO;
using HW_2_4.Logs;

namespace HW_2_4
{
    public class Logger : WriteHelper
    {
        private static Logger _logger;

        private static List<string> _logs;

        private Logger()
        {
        }

        public static List<string> Logs
        {
            get
            {
                if (_logs == null)
                {
                    _logs = new List<string>();
                }

                return _logs;
            }

            set
            {
                _logs = value;
            }
        }

        public static Logger GetLogger()
        {
            if (_logger == null)
            {
                _logger = new Logger();
            }

            return _logger;
        }

        public void Info()
        {
            var text = DateTime.UtcNow + ": {Info} :" + "{Start method}";
            WriteInfo(text);
            Logs.Add(text);
        }

        public void Warning()
        {
            var text = DateTime.UtcNow + ": {Warning} :" + "{Skipped logic in method}";
            WriteWarning(text);
            Logs.Add(text);
        }

        public void Error()
        {
            var text = DateTime.UtcNow + ": {Error} :" + "{I broke a logic}";
            WriteError(text);
            Logs.Add(text);
        }
    }
}
