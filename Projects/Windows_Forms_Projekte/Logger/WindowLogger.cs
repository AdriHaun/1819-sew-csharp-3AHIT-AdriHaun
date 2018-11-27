using System;
using System.Windows.Forms;

namespace Logger
{
    public class WindowLogger : ILogger
    {
        ListBox listBox;

        public WindowLogger(ListBox listBox)
        {
            this.listBox = listBox;
            if (listBox == null) { throw new NullReferenceException("No ListBox added!"); }
        }

        void ILogger.LogInfo(string info)
        {
            listBox.Items.Add("Started at " + DateTime.Now + ": " + info);
        }
    }
}
