using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate
{
    public partial class Form1 : Form
    {
        delegate string BenachrichtigungsHandler(string sender);
        BenachrichtigungsHandler GlueckwunschHandler;
        Person person;

        public Form1()
        {
            person = new Person();
            InitializeComponent();
        }
        
        private void cmdCall_Click(object sender, EventArgs e)
        {
            if (GlueckwunschHandler != null) {
                MessageBox.Show(GlueckwunschHandler("Birndo"), "Glückwunsch", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Die Methode \"ZumGeburtstag\" konnte leider nicht aufgerufen werden", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkConnect_CheckedChanged(object sender, EventArgs e)
        {
            if (chkConnect.Checked == true)
            {
                GlueckwunschHandler = new BenachrichtigungsHandler(person.ZumGeburtstag);
            }
            else
            {
                GlueckwunschHandler -= new BenachrichtigungsHandler(person.ZumGeburtstag);
            }
        }
    }
}
