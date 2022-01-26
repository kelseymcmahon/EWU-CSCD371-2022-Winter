using System;

namespace Logger
{
    public static class BaseLoggerMixins
    {
        public static void Error(this BaseLogger? log, string message, params object[] args)
        {
            if (log == null)
                throw new ArgumentNullException(nameof(log));

            message = String.Format(message,args);

            log.Log(LogLevel.Error, message);
        }

        public static void Warning(this BaseLogger? log, string message, params object[] args)
        {
            if (log == null)
                throw new ArgumentNullException(nameof(log));

            message = String.Format(message, args);

            log.Log(LogLevel.Warning, message);
        }

        public static void Information(this BaseLogger? log, string message, params object[] args)
        {
            if (log == null)
                throw new ArgumentNullException(nameof(log));

            message = String.Format(message, args);

            log.Log(LogLevel.Information, message);
        }
        public static void Debug(this BaseLogger? log, string message, params object[] args)
        {
            if (log == null)
                throw new ArgumentNullException(nameof(log));

            message = String.Format(message, args);

            log.Log(LogLevel.Debug, message);
        }
    }
}
