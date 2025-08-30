using System;

namespace POMCSharpAutomation.Utils
{
    /// <summary>
    /// Custom exception class used within the automation framework to signal specific errors.
    /// </summary>
    public class FrameworkException : Exception
    {
        public FrameworkException() { }
        public FrameworkException(string message) : base(message) { }
        public FrameworkException(string message, Exception innerException) : base(message, innerException) { }
    }
}
