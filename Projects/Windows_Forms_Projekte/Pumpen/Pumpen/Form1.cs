using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pumpen
{
    public partial class Form1 : Form
    {
        public delegate bool StartPumpHandeler();
        public StartPumpHandeler StartPump;

        private List<Pump> pumps = new List<Pump>();
        PumpA pa = new PumpA();
        PumpB pb = new PumpB();
        PumpC pc = new PumpC();

        public Form1()
        {
            InitializeComponent();
        }

        class PumpA : Pump
        {
            public override bool SwitchOn()
            {
                MessageBox.Show("PumpeA wird eingeschaltet!"); return this.Success;
            }
            public bool SwitchOnA()
            {
                MessageBox.Show("PumpeA wird eingeschaltet!"); return this.Success;
            }
        }

        class PumpB : Pump
        {
            public override bool SwitchOn()
            {
                MessageBox.Show("PumpeB wird eingeschaltet!"); return this.Success;
            }
            public bool SwitchOnB()
            {
                MessageBox.Show("PumpeB wird eingeschaltet!"); return this.Success;
            }
        }

        class PumpC : Pump
        {
            public override bool SwitchOn()
            {
                MessageBox.Show("PumpeC wird eingeschaltet!"); return this.Success;
            }
            public bool SwitchOnC()
            {
                MessageBox.Show("PumpeC wird eingeschaltet!"); return this.Success;
            }
        }


        public void StartAllPumps()
        {
            foreach (Pump p in pumps) p.SwitchOn();
        }

        public void StartAllPumpsMulti()
        {
            if (this.StartPump != null) this.StartPump();
        }
        private void cmdStart_Click(object sender, EventArgs e)
        {
            pumps.Clear();
            /*
            if(chckPump1.Checked == true) pumps.Add(new PumpA());
            if(chckPump2.Checked == true) pumps.Add(new PumpB());
            if(chckPump3.Checked == true) pumps.Add(new PumpC());
            StartAllPumps();
            */

            if (chckPump1.Checked == true)
            {
                pumps.Add(pa);
                StartPump += new StartPumpHandeler(pa.SwitchOn);
            }
            else { StartPump -= new StartPumpHandeler(pa.SwitchOn); }

            if (chckPump2.Checked == true)
            {
                pumps.Add(pb);
                StartPump += new StartPumpHandeler(pb.SwitchOn);
            }
            else { StartPump -= new StartPumpHandeler(pb.SwitchOn); }
            if (chckPump3.Checked == true)
            {
                pumps.Add(pc);
                StartPump += new StartPumpHandeler(pc.SwitchOn);
            }
            else { StartPump -= new StartPumpHandeler(pc.SwitchOn); }

            StartAllPumpsMulti();
            chckPump1.Checked = false;
            chckPump2.Checked = false;
            chckPump3.Checked = false;
        }

        private void chckPump1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void chckPump2_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        private void chckPump3_CheckedChanged(object sender, EventArgs e)
        {
 
        }
    }
}
