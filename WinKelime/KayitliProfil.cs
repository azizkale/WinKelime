using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using System.Drawing;

namespace WinKelime
{
    public static class KayitliProfil
    {
        //public static XmlDocument xml = new XmlDocument();
        //public static XmlNode Oyunbilgileri;
        //public static XmlElement Sayacxml, Skorxml, KutuHarflerixml, listboxxml;
       static Kutular kutu = new Kutular();
       
       
       

       public static void KayitliProfiliGetir(int a,FlowLayoutPanel pnl1,FlowLayoutPanel pnl2,FlowLayoutPanel pnl3,GroupBox grpbx,Form frm,Button btnuygula,TextBox txtPuan,ListBox lbox1,NumericUpDown num1,Button btnCikis)
        {
            

            a = Convert.ToInt32(XMLOkuma.KutuSayisi.InnerText);
         ////////////SKOR ve KUTU SAYISI XML DEN ÇEKİLİYOR///////////7
            txtPuan.Text = XMLOkuma.Skorxml.InnerText;
            num1.Value = Convert.ToDecimal(XMLOkuma.KutuSayisi.InnerText);
            kutu.KutuSayisi = a * a;

            pnl1.Controls.Clear();
            pnl1.Size = new Size(a * 28,a * 28);
            kutu.KutulariOlustur(pnl1, kutu.KutuSayisi);

            pnl2.Controls.Clear();
            pnl2.Size = new Size(275, 40);
            pnl2.Top = 30 *a;

            kutu.AltKutulariOlustur(pnl2, 30 + 28 *a);

            pnl3.Controls.Clear();
            pnl3.Top = 30 *a;
            pnl3.Left = 270;
            kutu.MemoOlustur(pnl3, 28 * a);

            grpbx.Location = new Point(28 * a, 25);
            frm.Size = new Size(a * 28 + 270, 30 * a + 80);

            btnuygula.Enabled = true;



            ////////HARFLER XML DEN ÇEKİLİYOR///////////
            int sayac = 0;
            foreach (char item in XMLOkuma.KutuHarflerixml.InnerText)
            {

                if (item == '0')
                    pnl1.Controls[sayac].Text = "";
                else
                    pnl1.Controls[sayac].Text = item.ToString();
                sayac++;
            }
            foreach (Label item in pnl1.Controls)
            {
                if (item.Text != "")
                {
                    item.BackColor = Color.Blue;
                    item.ForeColor = Color.White;
                }
            }
            sayac = 0;
            ///////////ALTKUTUHARFLERİ ÇEKİLİYOR////////////
            
            foreach (char item in XMLOkuma.AltKutuHarflerixml.InnerText)
            {
                if (item == '0')
                    pnl2.Controls[sayac].Text = "";
                else
               pnl2.Controls[sayac].Text= item.ToString();
                
                sayac++;
            }
            ///////////ALTKUTUHARFLERİ ÇEKİLİYOR////////////

            //////////LİSTBOX XML DEN ÇEKİLİYOR///////////7
            string[] dizilistbox = XMLOkuma.listboxxml.InnerText.Split('-');
            foreach (string item in dizilistbox)
            {
                lbox1.Items.Add(item);
            }

        }
    }
}
