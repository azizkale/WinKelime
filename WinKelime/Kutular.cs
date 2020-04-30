using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WinKelime
{
    public class Kutular:AltKutular
    {
       
        public int KutuSayisi { get; set; }
        public Label Kutularr { get; set; }
        public int a { get; set; }

       

        public void KutulariOlustur(FlowLayoutPanel pnl, int kutusayisi)
        {
            
            KutuSayisi = kutusayisi;
            for (int i = 0; i < kutusayisi; i++)
            {
                Kutularr = new Label();
                Kutularr.Margin = new Padding(1);
                Kutularr.Size = new System.Drawing.Size(25, 25);
                Kutularr.BorderStyle = BorderStyle.FixedSingle;
                Kutularr.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15);
                Kutularr.BackColor = Color.LightSkyBlue;
                Kutularr.ForeColor = Color.Black;


                if (i >= (kutusayisi - 1) / 2 - (a - 1) / 2 && i <= (kutusayisi - 1) / 2 + (a - 1) / 2)
                {
                    Kutularr.BackColor = Color.LightSkyBlue;
                    Kutularr.Tag = true; ;
                }
                if (i == (kutusayisi - 1) / 2)
                {
                    Kutularr.BackColor = Color.Blue;
                    Kutularr.ForeColor = Color.Black;
                    Kutularr.Tag = true;
                }


                pnl.Controls.Add(Kutularr);
                Kutularr.Name = i.ToString();
                Kutularr.Click += new EventHandler(Kutularr_Click);
                Kutularr.DoubleClick += new EventHandler(Kutularr_DoubleClick);
                Kutularr.MouseHover += new EventHandler(Kutularr_MouseHover);
                Kutularr.MouseMove += new MouseEventHandler(Kutularr_MouseMove);
                Kutularr.MouseUp += new MouseEventHandler(Kutularr_MouseUp);
                
            }

        }

        void Kutularr_MouseUp(object sender, MouseEventArgs e)
        {
            Label secilenkutu = (Label)sender;
            if (secilenkutu.Text == "" && KutuMemo.Text != "")
            {
                secilenkutu.Text = KutuMemo.Text;
                KutuMemo.Text = string.Empty;
            }
            AltKutular.tf.lblTasiyici.Text = "";
            AltKutular.tf.Close();
        }

        void Kutularr_MouseMove(object sender, MouseEventArgs e)
        {
            AltKutular.tf.Left = Cursor.Position.X - 36;
            AltKutular.tf.Top = Cursor.Position.Y - 35;
        }

        void Kutularr_MouseHover(object sender, EventArgs e)
        {
           AltKutular.tf.Left = Cursor.Position.X - 36;
           AltKutular.tf.Top = Cursor.Position.Y - 35;
        }
        public static TasiyiciForm tf = new TasiyiciForm();
       
        void Kutularr_DoubleClick(object sender, EventArgs e)
        {           
            Label secilenkutu = (Label)sender;            
            foreach (Label item in AltKutular.dizialtkutu)
            {
                if (secilenkutu.Text != "" && secilenkutu.ForeColor != Color.White && item.Text == "")
                {
                    item.Text = secilenkutu.Text;
                    secilenkutu.Text = "";
                }

               
            }
        }

        
        void Kutularr_Click(object sender, EventArgs e)
        {           
            Label secilenkutu = (Label)sender;
            if (secilenkutu.Text == "" && KutuMemo.Text != "")
            {
                secilenkutu.Text = KutuMemo.Text;                                
                KutuMemo.Text = string.Empty;
            }
            AltKutular.tf.lblTasiyici.Text = "";
            AltKutular.tf.Close();
        }      
    
    }

   
}
