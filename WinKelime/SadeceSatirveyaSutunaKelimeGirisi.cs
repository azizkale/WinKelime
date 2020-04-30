using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WinKelime
{
    public class SadeceSatirveyaSutunaKelimeGirisi:TemasKontrol
    {
        Label[,] dizikutularsatir;
        Label[,] dizikutularsutun;
        Label[] dizikutularteksatir;
        Label[] dizikutularteksutun;
       public int sayacsatirakelimegirisi = 0;
       public int sayacsutunakelimegirisi = 0;

        public void satirveyasutun(int a,Label[,] dizikutular)
        {
            dizikutularsatir = new Label[a, a];
            dizikutularsutun = new Label[a, a];
            sayacsatirakelimegirisi = 0;
            sayacsutunakelimegirisi = 0;

            for (int i = 0; i < a; i++) // satıların dizisi
            {
                for (int j = 0; j < a; j++)
                {
                    dizikutularsatir[i, j] = dizikutular[i, j];
                }

            }

            dizikutularteksatir = new Label[a * a];
            int indexsatir = 0;
            foreach (Label item in dizikutularsatir)
            {
                if (indexsatir != a * a)
                {
                    dizikutularteksatir[indexsatir] = item;
                    indexsatir++;
                }
            }

            indexsatir = 0;
            for (int i = 0; i < a; i++) // sütunların dizisi
            {
                for (int j = 0; j < a; j++)
                {
                    dizikutularsutun[j, i] = dizikutularsatir[i, j];
                }
            }

            dizikutularteksutun = new Label[a * a];
            int indexsutun = 0;
            foreach (Label item in dizikutularsutun)
            {
                if (indexsutun != a * a)
                {
                    dizikutularteksutun[indexsutun] = item;
                    indexsutun++;
                }
            }
            indexsutun = 0;

            sayacsatirakelimegirisi = 0;/////////
            for (int i = 0; i < dizikutularteksatir.Length - 1; i++)
            {
                if (dizikutularteksatir[i].Text != "" && dizikutularteksatir[i].ForeColor == Color.Black && dizikutularteksatir[i + 1].Text != "" && dizikutularteksatir[i + 1].ForeColor == Color.Black)
                    sayacsatirakelimegirisi++;
            }
            sayacsutunakelimegirisi = 0;//////////////
            for (int i = 0; i < dizikutularteksutun.Length - 1; i++)
            {
                if (dizikutularteksutun[i].Text != "" && dizikutularteksutun[i].ForeColor == Color.Black && dizikutularteksutun[i + 1].Text != "" && dizikutularteksutun[i + 1].ForeColor == Color.Black)
                    sayacsutunakelimegirisi++;
            }

            if (sayacsatirakelimegirisi > 0 && sayacsutunakelimegirisi > 0)
                MessageBox.Show("sadece satır veya sütuna kelime girişi yapabilirsiniz ve harfleriniz bitişik olmalı.");




        }


        public int syc1 = 0;
        public int syc2 = 0;
        public void satirveyasutun2(FlowLayoutPanel pnl,int a)
        {
            int sayacc = 0;
            int inndex = 0;

            int[] dizisayaclarsatirlar = new int[a];
            int[] dizisayaclarsutunlar = new int[a];

            for (int i = 0; i < a; i++)
            {
                dizisayaclarsatirlar[i] = new int();
            }

            for (int i = 0; i < a; i++)
            {
                dizisayaclarsutunlar[i] = new int();
            }

            for (int i = 0; i < a; i++) // satirların tek tek tag lerini verir
            {
                sayacc = 0;
                while (sayacc != a)
                {
                    pnl.Controls[inndex].Tag = i;
                    if (inndex < a * a)
                        inndex++;
                    else
                    {
                        inndex = 0;
                        break;
                    }

                    sayacc++;
                }
            }
            inndex = 0;

            for (int i = 0; i < a; i++) // her satıra bakar ki birden fazla harf girişi var mı
            {
                for (int j = 0; j < a; j++)
                {
                    if (inndex < a * a)
                    {
                        if ((int)pnl.Controls[inndex].Tag == i && pnl.Controls[inndex].Text != "" && pnl.Controls[inndex].ForeColor == Color.Black)
                        {
                            dizisayaclarsatirlar[i]++;
                        }
                        inndex++;
                    }
                    else
                        break;
                }
            }

            inndex = 0;


            for (int i = 0; i < a; i++)// sutunların tek tek tag lerini verir
            {
                sayacc = 0;
                while (sayacc != a)
                {
                    dizikutularteksutun[inndex].Tag = i;
                    if (inndex < a * a)
                        inndex++;
                    else
                    {
                        inndex = 0;
                        break;
                    }

                    sayacc++;
                }

            }
            inndex = 0;




            for (int i = 0; i < a; i++) // her sutuna bakar ki birden fazla harf girişi var mı
            {
                for (int j = 0; j < a; j++)
                {
                    if (inndex < a * a)
                    {
                        if ((int)dizikutularteksutun[inndex].Tag == i && dizikutularteksutun[inndex].Text != "" && dizikutularteksutun[inndex].ForeColor == Color.Black)
                        {
                            dizisayaclarsutunlar[i]++;
                        }
                        inndex++;
                    }
                    else
                        break;
                }
            }

            inndex = 0;




            syc1 = 0; //////////
            syc2 = 0;//////////
            foreach (int item in dizisayaclarsatirlar) // birden fazla satıra harf girişi kontrolu yapar
            {
                if (item > 1)
                    syc1++;
            }

            foreach (var item in dizisayaclarsutunlar)//birden fazla satıra harf girişi kontrolu yapar
            {
                if (item > 1)
                    syc2++;
            }

            if (syc1 > 0 && syc2 > 0)
            {
                MessageBox.Show("birden fazla satıra veya sutuna harf girişi var bro");
                return;
            }


        }
    }
}
