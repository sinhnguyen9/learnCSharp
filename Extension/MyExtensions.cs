using MyApp.Utility;

namespace MyApp.Extension
{
    public static class MyExtensions
    {
        public static string ToCurrency(this double salary)
        {
            return $"{salary:N0}$";
        }

        public static string ToUSD(this double number)
        {
            return $"{number:N2}$";
        }

        public static List<LogEntry>? RetrieveLogsWithTime(this List<string> rowLogs, DateTime startDate, DateTime endDate)
        {
            List<LogEntry> logEntries1 = new List<LogEntry>();
            if (startDate > endDate)
            {
                Console.WriteLine("Thoi gian bat dau khong the lon hon thoi gian ket thuc");
                return logEntries1;
            }
            else
            {
                foreach (LogEntry logEntry in CompanyConfig.ParseLogs(rowLogs))
                {
                    if (logEntry.Type == LogEnum.ERROR && logEntry.CreatedAt >= startDate && logEntry.CreatedAt <= endDate)
                    {
                        logEntries1.Add(logEntry);
                    }
                }
                if (logEntries1.Count > 0)
                {
                    return logEntries1;
                }
                else
                {
                    Console.WriteLine($"Khong co log Error nao tu: {startDate} den :{endDate}");
                    return logEntries1;
                }
            }
        }
    }
}