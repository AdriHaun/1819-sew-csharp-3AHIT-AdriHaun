using System;
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
                lbx.Items.Add(o.ToString());
            }
        }

        public static Nahrung GetObjFromLbx(string s, ref List<Nahrung> burger, ref List<Nahrung> wrap, ref List<Nahrung> sidedishes, ref List<Nahrung> drinks, ref List<Nahrung> desserts)
        {
            for (int i = 0; burger.Count >= i + 1; i++)
            {
                if (s == burger[i].ToString()) return burger[i];
            }

            for (int i = 0; wrap.Count >= i + 1; i++)
            {
                if (s == wrap[i].ToString()) return wrap[i];
            }

            for (int i = 0; sidedishes.Count >= i + 1; i++)
            {
                if (s == sidedishes[i].ToString()) return sidedishes[i];
            }

            for (int i = 0; drinks.Count >= i + 1; i++)
            {
                if (s == drinks[i].ToString()) return drinks[i];
            }

            for (int i = 0; desserts.Count >= i + 1; i++)
            {
                if (s == desserts[i].ToString()) return desserts[i];
            }
            return null;
        }
    }
}
