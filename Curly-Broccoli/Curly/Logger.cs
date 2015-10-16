using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curly
{
    /// <summary>
    /// Utility for logging to an internal list of Log entities
    /// </summary>
    public class Logger
    {
        private List<Log> _logs = new List<Log>();

        /// <summary>
        /// Adds a single message to the log list
        /// </summary>
        /// <param name="log"></param>
        public void Log(Log log)
        {
            _logs.Add(log);
        }

        /// <summary>
        /// Calls log method to add each item of supplied list
        /// </summary>
        /// <param name="logs"></param>
        public void LogAll(IEnumerable<Log> logs)
        {
            foreach(var l in logs)
            {
                Log(l);
            }
        }
    }
}
