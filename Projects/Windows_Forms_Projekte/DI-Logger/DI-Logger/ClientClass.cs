using System;

namespace Logger
{
    class ClientClass
    {
        private ILogger logger;
        public ILogger Logger { set { logger = value; } }

        public ClientClass() { }
        public ClientClass(ILogger logger)
        {
            Logger = logger;
        }

        public void ProcessInfo(string Info)
        {
            if(logger == null)
            {
                throw new NullReferenceException("No Logger connected!");
            }
            else
            {
                logger.LogInfo(Info);
            }
        }
    }
}


