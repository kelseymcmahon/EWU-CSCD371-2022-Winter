namespace Logger
{

    public static class LogFactory
    {
        private static string? filePath = null;

        public static BaseLogger? CreateLogger(string className)
        {
            if (filePath is null)
            {
                return null;
            }

            BaseLogger logger = new FileLogger(filePath) { Name = className };
            return logger;
        }

        public static void ConfigureFileLogger(string fp)
        {
            if (fp is not null)
                filePath = fp;
        }

        public static void ResetConfiguration()
        {
            filePath = null;
        }


    }
}
