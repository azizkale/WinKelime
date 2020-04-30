using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinKelime
{
    public class SatirIslemleri:Kutular
    {
        public string kelimesatir { get; set; }
        public string satiranlamlimi { get; set; }
        public string satiranlamli { get; set; }

       public void satirOlustur(FlowLayoutPanel pnl)
        {
            kelimesatir = "";//////////
            foreach (Label item in pnl.Controls)
            {
                if (item.Text == "")
                    kelimesatir += "_";
                else
                    kelimesatir += item.Text;
            }
        }


        public string[] dizisatir1;
        public string[] dizisatir2;
        public  string[] dizisatir3;
        
        public void ParcalaSatir(string kelimesatir)
        {
            dizisatir1 = null;/////////
            dizisatir2 = null;/////////
            dizisatir3 = null;/////////
            satiranlamlimi = "";/////////
            satiranlamli = "";/////////////

            dizisatir1 = kelimesatir.Split('_');

            for (int i = 0; i < dizisatir1.Length; i++)
            {
                if (dizisatir1[i] != "")
                    satiranlamlimi += dizisatir1[i] + ".";
            }

            satiranlamlimi = satiranlamlimi.Remove(satiranlamlimi.Length - 1);
            dizisatir2 = satiranlamlimi.Split('.');

            foreach (string item in dizisatir2)
            {
                if (item.Length != 1)
                    satiranlamli += item + '.';
            }
            if (satiranlamli == null)
                satiranlamli = "";
            if (satiranlamli.Length != 0)
                satiranlamli = satiranlamli.Remove(satiranlamli.Length - 1, 1);
            dizisatir3 = satiranlamli.Split('.');

        }
    }
}
