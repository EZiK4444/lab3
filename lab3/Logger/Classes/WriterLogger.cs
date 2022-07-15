using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public abstract class WriterLogger : ILogger
    {
        protected TextWriter writer;

        public virtual void Log(params string[] messages)
        {
            string sendedMessage = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz") + ": ";
            foreach (var message in messages) sendedMessage += message + " ";

            writer.WriteLine(sendedMessage);
            writer.Flush();
        }

        public abstract void Dispose();

    }
}
