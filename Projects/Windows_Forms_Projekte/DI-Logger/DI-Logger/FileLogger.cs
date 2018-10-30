using System;

namespace Logger
{
    class FileLogger : ILogger
    {
        private readonly string filePath;
        public FileLogger(string path)
        {
            if (string.IsNullOrEmpty(path)) throw new NullReferenceException("Error: No Path!");
            filePath = path;
        }

        void ILogger.LogInfo(string info)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filePath, true))
            {
                info = "Start Log at " + DateTime.Now + Environment.NewLine + info;
                file.WriteLine(info);
            }
        }
    }
}

