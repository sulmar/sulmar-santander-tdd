using LogAnalyzer.Model;

namespace LogAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = "ip_traffic_log.csv";

            CsvFileLogEntryService logEntryService = new CsvFileLogEntryService();
            List<LogEntry> logEntries = logEntryService.GetLogEntries(path);

        }
    }
}
