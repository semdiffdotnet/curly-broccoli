using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curly
{
    /// <summary>
    /// Extend the logger class to log all logs to console in addition to the list
    /// </summary>
    public class ConsoleLogger : Logger
    {
        public override void Log(Log log)
        {
            Console.WriteLine(log.Message);
            base.Log(log);
        }
    }
}
