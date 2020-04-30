using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinKelime
{
    public class TemizlemeIslemleri : KelimeKontrol
    {
        SadeceSatirveyaSutunaKelimeGirisi sss = new SadeceSatirveyaSutunaKelimeGirisi();
        TemasKontrol tk = new TemasKontrol();

        public void Temizle(string[] dizisatir1, string[] dizisatir2, string[] dizisatir3, string[] dizisutun1, string[] dizisutun2, string[] dizisutun3, string[,] matris, string[,] matris2, string[] tumkelimedizisi, string satiranlamlimi, string satiranlamli, string sutunanlamlimi, string sutunanlamli, string kelimesatir, string kelimesutun, string kelimesatirsutun, int sayackelimekontrol, int sayac, int sayactemaskontrol, int sayacsatirakelimegirisi, int sayacsutunakelimegirisi,int syc1,int syc2)
        {
            dizisatir1 = null;
            dizisatir2 = null;
            dizisatir3 = null;
            dizisutun1 = null;
            dizisutun2 = null;
            dizisutun3 = null;
            matris = null;
            matris2 = null;
            tumkelimelerdizisi = null;
            satiranlamlimi = "";
            satiranlamli = "";
            sutunanlamlimi = "";
            sutunanlamli = "";
            kelimesatir = "";
            kelimesutun = "";
            kelimesatirsutun = "";
            sayackelimekontrol = 0;
            sayac = 0;
            tk.sayactemaskontrol2 = 0;
            sss.sayacsatirakelimegirisi = 0;
            sss.sayacsutunakelimegirisi = 0;
            sss.syc1 = 0;
            sss.syc2 = 0;


            
        }

        //ti.Temizle(sai.dizisatir1, sai.dizisatir2, sai.dizisatir3, sui.dizisutun1, sui.dizisutun2, sui.dizisutun3, sui.matris, sui.matris2, kk.tumkelimelerdizisi, sai.satiranlamlimi, sai.satiranlamli, sui.sutunanlamlimi, sui.sutunanlamli, sai.kelimesatir, sui.kelimesutun, kk.kelimesatirsutun, kk.sayackelimekontrol, kk.sayac, sss.sayactemaskontrol, sss.sayacsatirakelimegirisi, sss.sayacsutunakelimegirisi, sss.syc1, sss.syc2);
    }
}