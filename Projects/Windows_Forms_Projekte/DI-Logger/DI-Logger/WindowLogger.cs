using System;

namespace Logger
{
    class WindowLogger : ILogger
    {
        private System.Windows.Forms.ListBox logListbox;
        public WindowLogger(object control)
        {
            logListbox = control as System.Windows.Forms.ListBox;
            if (logListbox == null) throw new NullReferenceException("Control is no Listbox!");
        }

        void ILogger.LogInfo(string info)
        {
            if (logListbox == null) throw new NullReferenceException("Control is missing; no Listbox!");
            else
            {
                info = "Start Log at " + DateTime.Now + ":  " + info;
                logListbox.Items.Add(info);
            }
        }
    }
}

