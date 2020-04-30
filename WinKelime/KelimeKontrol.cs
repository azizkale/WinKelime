using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;

namespace WinKelime
{
   public class KelimeKontrol:SutunIslemleri
    {
       public string kelimesatirsutun = "";
        public string[] tumkelimelerdizisi;
        public int sayackelimekontrol = 0;

       public void KelimeKontrolu(ListBox lbx,FlowLayoutPanel pnl,string[]dizisatir3,string[]dizisutun3,ArrayList dizitdk)
        {
            kelimesatirsutun = "";//////////////
            foreach (string item in dizisatir3)
            {
                if (item != "")
                    kelimesatirsutun += item + '.';
            }
            
            foreach (string item in dizisutun3)
            {
                if (item != "")
                    kelimesatirsutun += item + '.';
            }


            tumkelimelerdizisi = null;////////////
            kelimesatirsutun = kelimesatirsutun.Remove(kelimesatirsutun.Length - 1, 1);
            tumkelimelerdizisi = kelimesatirsutun.Split('.');

            sayackelimekontrol = 0;/////////////
            foreach (string item in tumkelimelerdizisi)
            {
                if (dizitdk.Contains(item))
                    sayackelimekontrol++;

            }


            if (tumkelimelerdizisi.Length == sayackelimekontrol)//dizideki tüm kelimeler anlamlı mı
            {

                for (int i = 0; i < sayackelimekontrol; i++)
                {
                    if (!lbx.Items.Contains(tumkelimelerdizisi[i])) //dizinin kelimeleri daha önce işaretlenmediyse listbox a ekle
                    {
                        lbx.Items.Insert(0, tumkelimelerdizisi[i]);

                        for (int j = 0; j < tumkelimelerdizisi[i].Length; j++)
                        {
                            foreach (Label item in pnl.Controls)
                            {

                                if (tumkelimelerdizisi[i][j].ToString() == item.Text)
                                {
                                    item.BackColor = Color.Blue;
                                    item.ForeColor = Color.White;
                                }
                            }
                        }

                    }

                    for (int j = 0; j < tumkelimelerdizisi[i].Length; j++)
                    {
                        foreach (Label item in pnl.Controls)
                        {

                            if (tumkelimelerdizisi[i][j].ToString() == item.Text)
                            {
                                item.BackColor = Color.Blue;
                                item.ForeColor = Color.White;
                            }
                        }
                    }

                }
            }
            else
           
                MessageBox.Show("anlamsız kelime");
            
               

        }
    }
}
