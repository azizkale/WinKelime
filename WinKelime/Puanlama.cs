using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinKelime
{
    public class Puanlama
    {
        public int Sayi { get; set; }
        public string Harf { get; set; }
        public int Puan { get; set; }
        
        public void Puanlamaa(ListBox listBox1,TextBox txtPuan)
        {
            string sonkelime = "";
            sonkelime = listBox1.Items[0].ToString();
            foreach (char item in sonkelime)
            {
                string itm=item.ToString();
                switch (itm)
                {
                    case "A": Sayi = 1; break;
                    case "B": Sayi = 1; break;
                    case "C": Sayi = 2; break;
                    case "Ç": Sayi = 3; break;
                    case "D": Sayi = 2; break;
                    case "E": Sayi = 1; break;
                    case "F": Sayi = 7; break;
                    case "G": Sayi = 7; break;
                    case "Ğ": Sayi = 9; break;
                    case "H": Sayi = 5; break;
                    case "I": Sayi = 2; break;
                    case "İ": Sayi = 1; break;
                    case "J": Sayi = 9; break;
                    case "K": Sayi = 1; break;
                    case "L": Sayi = 1; break;
                    case "M": Sayi = 1; break;
                    case "N": Sayi = 1; break;
                    case "O": Sayi = 2; break;
                    case "Ö": Sayi = 5; break;
                    case "P": Sayi = 1; break;
                    case "R": Sayi = 1; break;
                    case "S": Sayi = 1; break;
                    case "Ş": Sayi = 2; break;
                    case "T": Sayi = 1; break;
                    case "U": Sayi = 2; break;
                    case "Ü": Sayi = 2; break;
                    case "V": Sayi = 5; break;
                    case "Y": Sayi = 1; break;
                    case "Z": Sayi = 3; break;
                }
                Puan += Sayi;
                
            }
            int skor = Convert.ToInt32(XMLOkuma.Skorxml.InnerText);
            skor += Puan;
            XMLOkuma.Skorxml.InnerText = skor.ToString();
            txtPuan.Text = XMLOkuma.Skorxml.InnerText;
            XMLOkuma.xml.Save(XMLOkuma.dosyaismi);
        }
    }
}