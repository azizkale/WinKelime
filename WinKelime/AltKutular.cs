using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WinKelime
{
   public  class AltKutular
    {
        public Label Altkutularr { get; set; }
        public static Label KutuMemo { get; set; }
        public Label NumaraKutulari { get; set; }

       public static Label[] dizialtkutu;
        Label[] dizinumarakutu;



        public void AltKutulariOlustur(FlowLayoutPanel pnl, int y)
        {
            dizialtkutu = new Label[7];
            dizinumarakutu = new Label[7];
            for (int i = 0; i < 7; i++)
            {
                Altkutularr = new Label();

                Altkutularr.Margin = new Padding(1);
                Altkutularr.Size = new System.Drawing.Size(33, 30);
                Altkutularr.BorderStyle = BorderStyle.FixedSingle;
                Altkutularr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13);
                Altkutularr.BackColor = Color.LightSkyBlue;
                pnl.Controls.Add(Altkutularr);
                Altkutularr.Name = i.ToString();
                Altkutularr.Location = new Point(10, y);
                Altkutularr.TextAlign = ContentAlignment.TopRight;
                Altkutularr.Click += new EventHandler(altkutular_Click);
                Altkutularr.TextChanged += new EventHandler(altkutular_TextChanged);
                Altkutularr.MouseDown += new MouseEventHandler(altkutular_MouseDown);
                Altkutularr.MouseHover += new EventHandler(Altkutular_MouseHover);
                Altkutularr.MouseMove += new MouseEventHandler(Altkutularr_MouseMove);
                Altkutularr.MouseDoubleClick += new MouseEventHandler(Altkutularr_MouseDoubleClick);

                dizialtkutu[i] = Altkutularr;

                NumaraKutulari = new Label();
                NumaraKutulari.Location = new Point(Altkutularr.Top, y + 18);
                NumaraKutulari.Size = new Size(12, 12);
                Altkutularr.Controls.Add(NumaraKutulari);
                NumaraKutulari.BorderStyle = BorderStyle.None;
                NumaraKutulari.Top = Altkutularr.Top + 16;
                NumaraKutulari.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8);                
                NumaraKutulari.BackColor = Color.LightSkyBlue;
                NumaraKutulari.Tag = i;
                dizinumarakutu[i] = NumaraKutulari;
            }            
        }

        void Altkutularr_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Label secilen = (Label)sender;
            if (AltKutular.tf.lblTasiyici.Text != "" && secilen.Text == "")
            {
                secilen.Text = AltKutular.tf.lblTasiyici.Text;
                AltKutular.tf.Close();
                KutuMemo.Text = "";
            }
        }

        void Altkutularr_MouseMove(object sender, MouseEventArgs e)
        {
            tf.Left = Cursor.Position.X - 36;
            tf.Top = Cursor.Position.Y - 35;
        }
        
       

        void Altkutular_MouseHover(object sender, EventArgs e)
        {

            tf.Left = Cursor.Position.X - 36;
            tf.Top = Cursor.Position.Y - 35;
        }

      public static TasiyiciForm tf = new TasiyiciForm();

        void altkutular_MouseDown(object sender, MouseEventArgs e)
      {
          if (XMLOkuma.Sayacxml.InnerText == "1")
          {
              tf.Left = Cursor.Position.X - 36;
              tf.Top = Cursor.Position.Y - 35;
              if (tf.IsDisposed)
                  tf = new TasiyiciForm();
              tf.Show();
              KutuMemo.Visible = false;
              Label secilenaltkutu = (Label)sender;

              if (KutuMemo.Text == string.Empty)
              {
                  KutuMemo.Text = secilenaltkutu.Text;
                  tf.lblTasiyici.Text = secilenaltkutu.Text;
                  secilenaltkutu.Text = "";
              }
          }
          else
          {
              Label secilenaltkutu = (Label)sender;
              KutuMemo.Visible = true;
              if (KutuMemo.Text == string.Empty)
              {
                  KutuMemo.Text = secilenaltkutu.Text;
                  tf.lblTasiyici.Text = secilenaltkutu.Text;
                  secilenaltkutu.Text = "";
              }
          }
        }

        
        public void altkutular_Click(object sender, EventArgs e)
        {
            
           
        }

        int t;
        void altkutular_TextChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < 7; i++)
            {

                switch (dizialtkutu[i].Text)
                {
                    case "A": t = 1; break;
                    case "B": t = 1; break;
                    case "C": t = 2; break;
                    case "Ç": t = 3; break;
                    case "D": t = 2; break;
                    case "E": t = 1; break;
                    case "F": t = 7; break;
                    case "G": t = 7; break;
                    case "Ğ": t = 9; break;
                    case "H": t = 5; break;
                    case "I": t = 2; break;
                    case "İ": t = 1; break;
                    case "J": t = 9; break;
                    case "K": t = 1; break;
                    case "L": t = 1; break;
                    case "M": t = 1; break;
                    case "N": t = 1; break;
                    case "O": t = 2; break;
                    case "Ö": t = 5; break;
                    case "P": t = 1; break;
                    case "R": t = 1; break;
                    case "S": t = 1; break;
                    case "Ş": t = 2; break;
                    case "T": t = 1; break;
                    case "U": t = 2; break;
                    case "Ü": t = 2; break;
                    case "V": t = 5; break;
                    case "Y": t = 1; break;
                    case "Z": t = 3; break;
                    case "": break;

                }
                dizinumarakutu[i].Text = t.ToString();
                if (dizialtkutu[i].Text == "")
                    dizinumarakutu[i].Text = "";

            }

        }

        public  void MemoOlustur(FlowLayoutPanel flw, int y)
        {

            KutuMemo = new Label();
            KutuMemo.Size = new System.Drawing.Size(35, 30);
            KutuMemo.Location = new Point(300, y);
            KutuMemo.BorderStyle = BorderStyle.FixedSingle;
            KutuMemo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15);
            KutuMemo.BackColor = Color.LightSkyBlue;
            flw.Controls.Add(KutuMemo);
        }
    }
}
