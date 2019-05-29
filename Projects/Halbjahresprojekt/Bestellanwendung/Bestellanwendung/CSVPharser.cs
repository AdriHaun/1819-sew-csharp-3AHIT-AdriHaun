using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Bestellanwendung
{
    public class CSVPharser{
        public List<Nahrung> CSVToList(string path)
        {
            List<Nahrung> burger = new List<Nahrung>();
            string line;
            StreamReader CSV = new StreamReader(path);
            for(int i = 0; i < 9; i++)
            {
                CSV.ReadLine();
            }

            while ((line = CSV.ReadLine()) != null)
            {
                string[] data;
                data = line.Split(';');
                try
                {
                    Nahrung A = new Nahrung(data[0], data[1], Convert.ToDouble(data[2]), Convert.ToBoolean(data[3]), data[4]);
                    burger.Add(A);
                }
                catch
                {
                    MessageBox.Show("Die zu Importierende Datei hat nicht das richtige Format. \nBitte wählen Sie eine andere Datei aus!");
                }
            }
            return burger;
        }
    }
}