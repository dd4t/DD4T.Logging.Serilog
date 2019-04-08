using DD4T.ContentModel.Contracts.Logging;
using Serilog;
using ILogger = DD4T.ContentModel.Contracts.Logging.ILogger;

namespace DD4T.Logging.SerilogSeq
{
    public class DefaultLogger : ILogger
    {
        /// <summary>
        /// The default logging category
        /// </summary>
        public const LoggingCategory DefaultLoggingCategory = LoggingCategory.General;

        /// <summary>
        /// Serilog
        /// </summary>
        private readonly Serilog.ILogger _log = new LoggerConfiguration()
            .MinimumLevel.Verbose()
            .ReadFrom.AppSettings()
            .CreateLogger();

        /// <summary>
        /// DEBUG: Used for internal system events that are not necessarily observable from the outside, but useful when determining how something happened.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public void Debug(string message, params object[] parameters)
        {
            Debug(message, DefaultLoggingCategory, parameters);
        }

        /// <summary>
        /// DEBUG: Used for internal system events that are not necessarily observable from the outside, but useful when determining how something happened.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="category">The category.</param>
        /// <param name="parameters">The parameters.</param>
        public void Debug(string message, LoggingCategory category, params object[] parameters)
        {
            var messageWithCategory = string.Concat($"[Category: {category.ToString()}]", " ", message);
            _log.Debug(messageWithCategory, parameters);
        }

        /// <summary>
        /// INFORMATION: events describe things happening in the system that correspond to its responsibilities and functions. Generally these are the observable actions the system can perform.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public void Information(string message, params object[] parameters)
        {
            Information(message, DefaultLoggingCategory, parameters);
        }

        /// <summary>
        /// INFORMATION: events describe things happening in the system that correspond to its responsibilities and functions. Generally these are the observable actions the system can perform.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="category">The category.</param>
        /// <param name="parameters">The parameters.</param>
        public void Information(string message, LoggingCategory category, params object[] parameters)
        {
            var messageWithCategory = string.Concat($"[Category: {category.ToString()}]", " ", message);
            _log.Information(messageWithCategory, parameters);
        }

        /// <summary>
        /// WARNING: When service is degraded, endangered, or may be behaving outside of its expected parameters, Warning level events are used.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public void Warning(string message, params object[] parameters)
        {
            Warning(message, DefaultLoggingCategory, parameters);
        }

        /// <summary>
        /// WARNING: When service is degraded, endangered, or may be behaving outside of its expected parameters, Warning level events are used.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="category">The category.</param>
        /// <param name="parameters">The parameters.</param>
        public void Warning(string message, LoggingCategory category, params object[] parameters)
        {
            var messageWithCategory = string.Concat($"[Category: {category.ToString()}]", " ", message);
            _log.Warning(messageWithCategory, parameters);
        }

        /// <summary>
        /// ERROR: When functionality is unavailable or expectations broken, an Error event is used.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public void Error(string message, params object[] parameters)
        {
           Error(message, DefaultLoggingCategory, parameters);
        }

        /// <summary>
        /// ERROR: When functionality is unavailable or expectations broken, an Error event is used.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="category">The category.</param>
        /// <param name="parameters">The parameters.</param>
        public void Error(string message, LoggingCategory category, params object[] parameters)
        {
            var messageWithCategory = string.Concat($"[Category: {category.ToString()}]", " ", message);
            _log.Error(messageWithCategory, parameters);
        }

        /// <summary>
        /// CRITICAL: The most critical level, Fatal events demand immediate attention.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public void Critical(string message, params object[] parameters)
        {
            Critical(message, DefaultLoggingCategory, parameters);
        }

        /// <summary>
        /// CRITICAL: The most critical level, Fatal events demand immediate attention.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="category">The category.</param>
        /// <param name="parameters">The parameters.</param>
        public void Critical(string message, LoggingCategory category, params object[] parameters)
        {
            var messageWithCategory = string.Concat($"[Category: {category.ToString()}]", " ", message);
            _log.Fatal(messageWithCategory, parameters);
        }
    }
}
