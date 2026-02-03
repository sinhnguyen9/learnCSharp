public class LogEntry
{
    public LogEnum Type { get; set; }
    public DateTime CreatedAt { get; set; }
    public string Message { get; set; }

    public LogEntry(LogEnum type, DateTime createdAt, string message)
    {
        Type = type;
        CreatedAt = createdAt;
        Message = message;
    }
}

public enum LogEnum
{
    INFO,
    WARNING,
    ERROR
}

