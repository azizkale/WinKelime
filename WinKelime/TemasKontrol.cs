using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace WinKelime
{
    public class TemasKontrol:Kutular
    {
        public Label[,] dizikutular;
       public int sayactemaskontrol = 0;        
        
       public void temaskontrol0(FlowLayoutPanel pnl,int a)
        {
            dizikutular = new Label[a, a];

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    if (sayactemaskontrol != a * a)
                    {
                        dizikutular[i, j] = (Label)pnl.Controls[sayactemaskontrol];
                        sayactemaskontrol++;
                    }
                }
            }
            sayactemaskontrol = 0;
        }

        public int sayactemaskontrol2 = 0;
      public  void temaskontrol1(int a)
        {
            sayactemaskontrol2 = 0;////////////

            if (dizikutular[0, 0].Text != "" && dizikutular[0, 0].ForeColor == Color.Black && (dizikutular[0, 1].ForeColor == Color.White || dizikutular[1, 0].ForeColor == Color.White))
                sayactemaskontrol2++;

            if (dizikutular[a - 1, 0].Text != "" && dizikutular[a - 1, 0].ForeColor == Color.Black && (dizikutular[a - 1, 1].ForeColor == Color.White || dizikutular[a - 2, 0].ForeColor == Color.White))
                sayactemaskontrol2++;

            if (dizikutular[0, a - 1].Text != "" && dizikutular[0, a - 1].ForeColor == Color.Black && (dizikutular[0, a - 2].ForeColor == Color.White || dizikutular[1, a - 1].ForeColor == Color.White))
                sayactemaskontrol2++;

            if (dizikutular[a - 1, a - 1].Text != "" && dizikutular[a - 1, a - 1].ForeColor == Color.Black && (dizikutular[a - 1, a - 2].ForeColor == Color.White || dizikutular[a - 2, a - 1].ForeColor == Color.White))
                sayactemaskontrol2++;

            for (int i = 1; i < a - 1; i++)
            {
                if (dizikutular[i, 0].Text != "" && dizikutular[i, 0].ForeColor == Color.Black && (dizikutular[i - 1, 0].ForeColor == Color.White || dizikutular[i + 1, 0].ForeColor == Color.White && dizikutular[i, 1].ForeColor == Color.White))
                    sayactemaskontrol2++;

                if (dizikutular[i, a - 1].Text != "" && dizikutular[i, a - 1].ForeColor == Color.Black && (dizikutular[i - 1, a - 1].ForeColor == Color.White || dizikutular[i + 1, a - 1].ForeColor == Color.White || dizikutular[i, a - 2].ForeColor == Color.White))
                    sayactemaskontrol2++;
            }

            for (int j = 1; j < a - 1; j++)
            {
                if (dizikutular[0, j].Text != "" && dizikutular[0, j].ForeColor == Color.Black && (dizikutular[0, j - 1].ForeColor == Color.White || dizikutular[0, j + 1].ForeColor == Color.White || dizikutular[1, j].ForeColor == Color.White))
                    sayactemaskontrol2++;

                if (dizikutular[a - 1, j].Text != "" && dizikutular[a - 1, j].ForeColor == Color.Black && (dizikutular[a - 1, j - 1].ForeColor == Color.White || dizikutular[a - 1, j + 1].ForeColor == Color.White || dizikutular[a - 2, j].ForeColor == Color.White))
                    sayactemaskontrol2++;
            }

            for (int k = 1; k < a - 1; k++)
            {
                for (int m = 1; m < a - 1; m++)
                {
                    if (dizikutular[k, m].Text != "" && dizikutular[k, m].ForeColor == Color.Black && (dizikutular[k + 1, m].ForeColor == Color.White || dizikutular[k - 1, m].ForeColor == Color.White || dizikutular[k, m + 1].ForeColor == Color.White || dizikutular[k, m - 1].ForeColor == Color.White))
                        sayactemaskontrol2++;
                }
            }
        }

        //void temaskontrol2(FlowLayoutPanel pnl)
        //{
        //    foreach (Label item in pnl.Controls)
        //    {
        //        if ((bool)item.Tag == false && item.Text != "")
        //            MessageBox.Show("temassız kelime");

        //    }
        //}
    }
}
