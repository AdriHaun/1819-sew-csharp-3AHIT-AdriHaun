namespace Logger
{
    public class ClientClass
    {
        private ILogger logger;

        public ILogger Logger { set { logger = value; } }

        public ClientClass() { }
        public ClientClass(ILogger logger)
        {
            Logger = logger;
        }

        public void ProcessInfo(string info)
        {
            if (logger == null) { throw new System.NullReferenceException("No logger connected"); }
            else
            {
                logger.LogInfo(info);
            }
        }
    }
}
