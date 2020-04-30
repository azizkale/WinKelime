using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WinKelime
{
   public class SanalRakip
    {
       string Alfabe = "AAABCÇDEEEFGĞHIİJKLMMMNOÖPRSŞTUÜVYZ";
       Label[] SanalAltKutular=new Label[7];
       Random rnd = new Random();
       Puanlama pn;
       int sayac;
       public void SanalOyuncu(int a,FlowLayoutPanel pnl)
       {        

           for (int i = 0; i < 7; i++) // rakibin kutuları oluşur (7 tane)
           {
               Label l = new Label();
               SanalAltKutular[i] = l;
           }

           foreach (Label item in SanalAltKutular) // rakibin kutularına harfler, kutu tag lerine puanları verilir
           {
               item.Text = Alfabe[rnd.Next(Alfabe.Length)].ToString();
               pn = new Puanlama();
               pn.Harf = item.Text;
               int i = 0;

               switch (item.Text)
               {
                   case "A": pn.Sayi = 1; break;
                   case "B": pn.Sayi = 1; break;
                   case "C": pn.Sayi = 2; break;
                   case "Ç": pn.Sayi = 3; break;
                   case "D": pn.Sayi = 2; break;
                   case "E": pn.Sayi = 1; break;
                   case "F": pn.Sayi = 7; break;
                   case "G": pn.Sayi = 7; break;
                   case "Ğ": pn.Sayi = 9; break;
                   case "H": pn.Sayi = 5; break;
                   case "I": pn.Sayi = 2; break;
                   case "İ": pn.Sayi = 1; break;
                   case "J": pn.Sayi = 9; break;
                   case "K": pn.Sayi = 1; break;
                   case "L": pn.Sayi = 1; break;
                   case "M": pn.Sayi = 1; break;
                   case "N": pn.Sayi = 1; break;
                   case "O": pn.Sayi = 2; break;
                   case "Ö": pn.Sayi = 5; break;
                   case "P": pn.Sayi = 3; break;
                   case "R": pn.Sayi = 1; break;
                   case "S": pn.Sayi = 1; break;
                   case "Ş": pn.Sayi = 2; break;
                   case "T": pn.Sayi = 1; break;
                   case "U": pn.Sayi = 2; break;
                   case "Ü": pn.Sayi = 2; break;
                   case "V": pn.Sayi = 5; break;
                   case "Y": pn.Sayi = 1; break;
                   case "Z": pn.Sayi = 3; break;
               }
               item.Tag = pn.Sayi;
               
           }


            ///////// oyun tahtasını dizi yapar////////////////
          Label[,] dizikutular = new Label[a, a]; 
          
           for (int i = 0; i < a; i++)
           {
               for (int j = 0; j < a; j++)
               {
                   if (sayac != a * a)
                   {
                       dizikutular[i, j] = (Label)pnl.Controls[sayac];
                       sayac++;
                   }
               }
           }
           sayac = 0;
           ///////////////////////////////////////////////

           ////////////////Sanal Rakibi Harfleri Kutulara Yerleştirir ///////////////

        

         

           //////////////////////////////////////////////////

       }
    }

}
