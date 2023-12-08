using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAnalyzer.Model
{
    public class LogEntry
    {
        public string Source_IP;
        public string Protocol;
        public int Bytes_Transferred;

        public LogEntry(string source_IP, string protocol, int bytes_Transferred)
        {
            Source_IP = source_IP;
            Protocol = protocol;
            Bytes_Transferred = bytes_Transferred;
        }
    }
}
