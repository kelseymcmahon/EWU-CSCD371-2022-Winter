namespace Logger
{
    public abstract class BaseLogger
    {
        //Auto-Implemented property for name
        public string? Name { get; set; }

        public abstract void Log(LogLevel logLevel, string message);

    }
}
