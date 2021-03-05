using System;
using System.IO;

namespace HW_2_4.Logs
{
    public abstract class WriteHelper
    {
        public void WriteInfo(string text)
        {
            File.AppendAllText("log.txt", text + "\n");
        }

        public void WriteWarning(string text)
        {
            File.AppendAllText("log.txt", text + "\n");
        }

        public void WriteError(string text)
        {
            File.AppendAllText("log.txt", text + "\n");
        }
    }
}
