namespace Logger
{
    public abstract class BaseLogger
    {
        //Auto-Implemented property for name
        private string Name { get; set; }

        public BaseLogger(string name)
        {
            Name = name;
        }
        public abstract void Log(LogLevel logLevel, string message);

    }
}
