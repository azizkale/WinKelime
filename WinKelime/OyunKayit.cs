using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WinKelime
{
   public class OyunKayit
    {
      static int sayac3;
      //public static Label[] dizikayitkutular;
      //public static Label[] dizikayitaltkutular;
      public static string[] dizikayitharfler;
      public static string[] dizikayitaltkutuharfleri;

       public static void HarfleriKaydet(FlowLayoutPanel pnl1, int a,ListBox lbx,FlowLayoutPanel pnl2,NumericUpDown num1)
       { 
           /////////////////KUTUHARFLERİ KAYIT İŞLEMLERİ////////////777
           a = Convert.ToInt32(XMLOkuma.KutuSayisi.InnerText);
         //dizikayitkutular = new Label[a * a];

         //   for (int i = 0; i < a * a; i++)
         //   {
         //       if (sayac3 != a*a)
         //       {
         //           dizikayitkutular[i] = (Label)pnl1.Controls[sayac3];
         //           sayac3++;
         //       }
         //   }
         //   sayac3 = 0;
            XMLOkuma.KutuHarflerixml.InnerText = string.Empty;
            foreach (Label item in pnl1.Controls)
            {
                if (item.Text == "")
                    XMLOkuma.KutuHarflerixml.InnerText +="0";
                else
                    XMLOkuma.KutuHarflerixml.InnerText += item.Text;
            }
           

            //dizikayitharfler=new string[a*a];
            //int sayac = 0;
            //foreach (Label item in dizikayitkutular)
            //{
            //    if (item.Text != "" && item.ForeColor == Color.Black)
            //    {
            //        dizikayitharfler[sayac] = "";

            //        foreach (Label item2 in AltKutular.dizialtkutu)
            //        {
            //            if (item2.Text == "")
            //            {
            //                item2.Text = item.Text;
            //                break;
            //            }
            //        }
            //    }
            //    else
            //        dizikayitharfler[sayac] = item.Text;
            //    sayac++;

            //}
            
            /////////////////KUTUHARFLERİ KAYIT İŞLEMLERİ////////////777
           /***********************************************************/
            /////////////////ALTKUTUHARFLERİ KAYIT İŞLEMLERİ////////////777
            if (AltKutular.KutuMemo.Text != "") // oyun kapatılırken kutuMemo da harf kalırsa devreye girer
            {
                foreach (Label item in AltKutular.dizialtkutu)
                {
                    if (item.Text == "")
                    {
                        item.Text = AltKutular.KutuMemo.Text;
                        break;
                    }
                }

            }

            //dizikayitaltkutular = new Label[7];
            //for (int i = 0; i < 7; i++)
            //{
            //    dizikayitaltkutular[i] = (Label)pnl2.Controls[i];
            //}

            XMLOkuma.AltKutuHarflerixml.InnerText = "";
            foreach (Label item in pnl2.Controls)
            {
                if (item.Text == "")
                    XMLOkuma.AltKutuHarflerixml.InnerText += "0";
                else
                    XMLOkuma.AltKutuHarflerixml.InnerText += item.Text;
            }
            //int sayac4=0;
            //dizikayitaltkutuharfleri = new string[7];
            //foreach (Label item in dizikayitaltkutular)
            //{
            //    dizikayitaltkutuharfleri[sayac4] = item.Text;
            //    sayac4++;
            //}
            

            
            /////////////////ALTKUTUHARFLERİ KAYIT İŞLEMLERİ////////////777
           //////////////////////////LİSTBOX KAYIT İŞLEMLERİ//////////////////
            XMLOkuma.listboxxml.InnerText = "";
            foreach (string item in lbx.Items)
            {
                XMLOkuma.listboxxml.InnerText += item + "-";
            }
            //////////////////////////LİSTBOX KAYIT İŞLEMLERİ//////////////////

            ////////////////KUTU SAYİSİ KAYIT///////////////7
            XMLOkuma.KutuSayisi.InnerText = num1.Value.ToString();
            ////////////////KUTU SAYİSİ KAYIT///////////////7


            XMLOkuma.xml.Save(XMLOkuma.dosyaismi);

        }

       
 
       
    }
}
