using Microsoft.Extensions.Logging;
using System;

namespace VpnHood.Logging
{
    public class FilterLogger : ILogger
    {
        private readonly ILogger _logger;
        private readonly Func<EventId, bool> _eventFilter;

        public FilterLogger(ILogger logger, Func<EventId, bool> eventFilter)
        {
            _logger = logger;
            _eventFilter = eventFilter;
        }

        public IDisposable BeginScope<TState>(TState state)=> _logger.BeginScope(state);
        public bool IsEnabled(LogLevel logLevel) => _logger.IsEnabled(logLevel);

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            if (_eventFilter(eventId))
                _logger.Log(logLevel, eventId, state, exception, formatter);
        }
    }

}
