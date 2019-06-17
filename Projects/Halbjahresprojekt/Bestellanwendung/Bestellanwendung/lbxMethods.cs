using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bestellanwendung
{
    public static class lbxMethods
    {
        public static void WriteToListBox(List<Nahrung> list, ListBox lbx)
        {
            
            lbx.Items.Clear();
            foreach (var o in list)
            {
                if (o.Anzahl != 0)
                lbx.Items.Add(o);
            }
        }
        public static double GetPrice(List<Nahrung> list)
        {
            double price = 0;

            return price;
        }
    }
}
