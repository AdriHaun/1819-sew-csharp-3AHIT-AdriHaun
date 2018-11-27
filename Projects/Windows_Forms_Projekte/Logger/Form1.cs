using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logger
{
    public partial class Form1 : Form
    {
        string path = @"D:\Logger\Log.txt";
        ClientClass Client;

        public Form1()
        {
            InitializeComponent();
            Client = new ClientClass();
        }

        private void rdoFileLog_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Client.Logger = new FileLogger(path);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdoWindowLog_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Client.Logger = new WindowLogger(this.lboWindowLog);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMailText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Client.ProcessInfo("Text changed: " + txtMailText.Text);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdSend_Click(object sender, EventArgs e)
        {
            try
            {
                Client.ProcessInfo("Text sent: " + txtMailText.Text);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
