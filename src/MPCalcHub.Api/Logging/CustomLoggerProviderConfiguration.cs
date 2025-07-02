using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MPCalcHub.Api.Logging
{
    public class CustomLoggerProviderConfiguration
    {
        public LogLevel LogLevel { get; set; } = LogLevel.Warning;
        public int EventId { get; set; } = 0;
    }
}