using System;

namespace Logger
{
    public class FileLogger : ILogger
    {
        private string path;

        public FileLogger(string path)
        {
            this.path = path;
            if (path == null) { throw new NullReferenceException("No Path!"); }
        }

        void ILogger.LogInfo(string info)
        {
            using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(path, true))
            {
                streamWriter.WriteLine("Start Log at " + DateTime.Now + ": " + info);
            }
        }
    }
}
