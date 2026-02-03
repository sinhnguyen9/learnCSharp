namespace MyApp.Utility
{
    public static class CompanyConfig
    {
        public static string CompanyName = "Vin Group";

        public static void PrintHeader()
        {
            Console.WriteLine($"Hệ thống quản lý ---{CompanyName}---");
        }

        public static List<LogEntry> ParseLogs(List<string> rawLogs)
        {
            List<LogEntry> logEntries = new List<LogEntry>();
            foreach (string log in rawLogs)
            {
                string[] splitString = log.Split("|");
                logEntries.Add(new LogEntry(Enum.Parse<LogEnum>(splitString[0]), DateTime.Parse(splitString[1]), splitString[2]));
            }
            return logEntries;
        }
    }
}