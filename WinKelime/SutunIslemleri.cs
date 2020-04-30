using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinKelime
{
   public class SutunIslemleri:SatirIslemleri 
    {
       public string sutunanlamli { get; set; }
       public string sutunanlamlimi { get; set; }
       public string kelimesutun { get; set; }

       public string[] dizisutun1;
       public string[] dizisutun2;
       public string[] dizisutun3;



       public string[,] matris;
       public string[,] matris2;
       public int sayac = 0;
       public void SutunOlustur(string kelimesatir, int a)
       {
           kelimesutun = "";/////
           matris = null;/////////
           matris2 = null;//////////
           matris = new string[a, a];
           matris2 = new string[a, a];

           

           for (int i = 0; i < a; i++)
           {
               for (int j = 0; j < a; j++)
               {
                   matris[i, j] = kelimesatir[sayac].ToString();
                   sayac++;
               }
           }
           sayac = 0;//////////

           for (int i = 0; i < a; i++)
           {
               for (int j = 0; j < a; j++)
               {
                   matris2[i, j] = matris[j, i];
               }
           }
           for (int i = 0; i < a; i++)
           {
               for (int j = 0; j < a; j++)
               {
                   kelimesutun += matris2[i, j];
               }
           }
       }
       
        public void ParcalaSutun(string klm)
        {
            dizisutun1=null;////////
            dizisutun2=null;////////
            dizisutun3=null;////////
            sutunanlamli="";////////
            sutunanlamlimi = "";///////////
             

            dizisutun1 = klm.Split('_');

            for (int i = 0; i < dizisutun1.Length; i++)
            {
                if (dizisutun1[i] != "")
                    sutunanlamlimi += dizisutun1[i] + ".";
            }

            sutunanlamlimi = sutunanlamlimi.Remove(sutunanlamlimi.Length - 1);
            dizisutun2 = sutunanlamlimi.Split('.');

            foreach (string item in dizisutun2)
            {
                if (item.Length != 1)
                    sutunanlamli += item + '.';
            }
            if (sutunanlamli == null)
                sutunanlamli = "";
            if (sutunanlamli.Length != 0)
                sutunanlamli = sutunanlamli.Remove(sutunanlamli.Length - 1, 1);
            dizisutun3 = sutunanlamli.Split('.');

        }

        
    }
}
