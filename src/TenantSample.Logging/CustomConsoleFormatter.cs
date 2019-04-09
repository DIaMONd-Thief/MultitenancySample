using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Serilog.Events;
using Serilog.Formatting;

namespace TenantSample.Logging
{
    public class CustomConsoleFormatter : ITextFormatter
    {
        private const string NewLineSubstitution = "~~";

        public void Format(LogEvent logEvent, TextWriter output)
        {
            output.Write($"##[logger.{logEvent.Level}] {logEvent.Timestamp} ");
            output.Write(Flatten(logEvent.RenderMessage()));
            if (logEvent.Exception != null)
            {
                output.Write(NewLineSubstitution);
                output.Write(Flatten(logEvent.Exception.ToString()));
            }

            output.WriteLine();
        }

        private string Flatten(string source)
        {
            return source.Replace(Environment.NewLine, NewLineSubstitution);
        }
    }
}
