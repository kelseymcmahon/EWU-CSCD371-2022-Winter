namespace Logger
{

    public class LogFactory
    {
        //CreateLogger should probably have static functionality. Need to research.
        public BaseLogger? CreateLogger(string className)
        {
            if (filepath is null)
            {
                return null;
            }

            //Possibly need to rewrite FileLogger to delegate construction to BaseLogger.
            //This would allow BaseLogger to take a className and FileLogger to take a filepath

            return new BaseLogger(className);
        }

        public void ConfigureFileLogger(string fp)
        {
            if (fp is not null)
            filepath = fp;
        }

        private string? filepath = null;
    }
}
