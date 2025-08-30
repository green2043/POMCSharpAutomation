using System;
using System.Threading;

namespace POMCSharpAutomation.Utils
{
    /// <summary>
    /// Utility methods for handling time-based operations such as waits and timestamp formatting.
    /// </summary>
    public static class TimeUtil
    {
        /// <summary>
        /// Pauses the execution for the specified number of milliseconds.
        /// </summary>
        public static void Sleep(int milliseconds)
        {
            Thread.Sleep(milliseconds);
        }

        /// <summary>
        /// Gets a timestamp string suitable for unique identifiers in file names, logs, etc.
        /// </summary>
        public static string GetTimestamp()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmss");
        }
    }
}
