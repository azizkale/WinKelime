using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Xml;


namespace WinKelime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
             

        TasiyiciForm tf = new TasiyiciForm();
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
          //kutu.a = (int)numericUpDown1.Value;
           TDKIslemleri.tdkyukleme(textBox1);
            
          KayitliProfil.KayitliProfiliGetir(kutu.a, flowLayoutPanel1, flowLayoutPanel2, flowLayoutPanel3, groupBox1, this, btnUygula, txtPuan, listBox1,numericUpDown1,btnCikis);
          
        }

       
        Kutular kutu = new Kutular();
        TemizlemeIslemleri ti = new TemizlemeIslemleri();
        KelimeKontrol kk = new KelimeKontrol();
        SatirIslemleri sai = new SatirIslemleri();
        SutunIslemleri sui = new SutunIslemleri();
        SadeceSatirveyaSutunaKelimeGirisi sss = new SadeceSatirveyaSutunaKelimeGirisi();
        TemasKontrol tk = new TemasKontrol();
        AltKutular altkutular = new AltKutular();
        SanalRakip sr = new SanalRakip();
        private void yeniOyunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kutu.a = (int)numericUpDown1.Value;
            txtPuan.Text = "00";
            kutu.KutuSayisi = kutu.a * kutu.a;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Size = new Size(kutu.a * 28, kutu.a * 28);
            kutu.KutulariOlustur(flowLayoutPanel1, kutu.KutuSayisi);

            flowLayoutPanel2.Controls.Clear();
            flowLayoutPanel2.Size = new Size(275, 40);
            flowLayoutPanel2.Top = 30 * kutu.a;

            kutu.AltKutulariOlustur(flowLayoutPanel2, 30 + 28 * kutu.a);

            flowLayoutPanel3.Controls.Clear();
            flowLayoutPanel3.Top = 30 * kutu.a;
            flowLayoutPanel3.Left = 270;
            kutu.MemoOlustur(flowLayoutPanel3, 28 * kutu.a);

            groupBox1.Location = new Point(28 * kutu.a, 25);
            this.Size = new Size(kutu.a * 28 + 270, 30 * kutu.a + 80);

            btnUygula.Enabled = true;            
            listBox1.Items.Clear();
        }
           


        Random rnd = new Random();
        Puanlama pn;
        private void btnHarfAl_Click(object sender, EventArgs e)
        {
            string Alfabe = "AAABCÇDEEEFGĞHIİJKLMMMNOÖPRSŞTUÜVYZ";

            foreach (Label item in flowLayoutPanel2.Controls)
            {
                item.Text = Alfabe[rnd.Next(Alfabe.Length)].ToString();
                pn = new Puanlama();
                pn.Harf = item.Text;

                foreach (Label item2 in item.Controls)
                {
                    switch (pn.Harf)
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
                        case "P": pn.Sayi = 1; break;
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
                    item2.Text = pn.Sayi.ToString();
                    item.Tag = pn.Sayi;
                }
            }
        }


        
        private void btnUygula_Click(object sender, EventArgs e)
        {
            if (XMLOkuma.Skorxml.InnerText == "1") // tasiyiciformu kapatmaya yönelik (ihtiyaten)
            {
                foreach (Label item in AltKutular.dizialtkutu)
                {
                    if (item.Text == "")
                        item.Text = AltKutular.tf.lblTasiyici.Text;
                    AltKutular.KutuMemo.Text = "";
                }

                AltKutular.tf.Close();
            }
           
            tk.sayactemaskontrol2 = 0;
            if (listBox1.Items.Count != 0)
            {
                tk.temaskontrol0(flowLayoutPanel1, (int)numericUpDown1.Value);
                tk.temaskontrol1((int)numericUpDown1.Value);
                sss.satirveyasutun((int)numericUpDown1.Value,tk.dizikutular);
                if (sss.sayacsatirakelimegirisi > 0 && sss.sayacsutunakelimegirisi > 0)
                    return;
                sss.satirveyasutun2(flowLayoutPanel1,(int)numericUpDown1.Value);
                if (sss.syc1 > 0 && sss.syc2 > 0)
                {                    
                    return;
                }
                if (tk.sayactemaskontrol2 > 0)
                {
                    try
                    {
                        sai.satirOlustur(flowLayoutPanel1);
                        sai.ParcalaSatir(sai.kelimesatir);
                        sui.SutunOlustur(sai.kelimesatir,(int)numericUpDown1.Value);
                        sui.ParcalaSutun(sui.kelimesutun);
                        kk.KelimeKontrolu(listBox1, flowLayoutPanel1, sai.dizisatir3, sui.dizisutun3,TDKIslemleri.dizitdk);

                        
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("kelime giriniz");
                    }

                    finally
                    {
                        
                    }
                }
                else
                    MessageBox.Show("temassız kelime");
            }

            tk.temaskontrol0(flowLayoutPanel1, (int)numericUpDown1.Value);
            if (listBox1.Items.Count == 0)
            {
                try
                {
                    sai.satirOlustur(flowLayoutPanel1);
                    sai.ParcalaSatir(sai.kelimesatir);
                    sui.SutunOlustur(sai.kelimesatir,(int)numericUpDown1.Value);
                    sui.ParcalaSutun(sui.kelimesutun);                    
                    for (int i = 0; i < kutu.a; i++) // mavi kutudan başlama şartı
                    {
                        for (int j = 0; j < kutu.a; j++)
                        {
                            if (i == (kutu.a - 1) / 2 && j == (kutu.a - 1) / 2 && tk.dizikutular[i, j].Text == "")
                            {
                                MessageBox.Show("başlangıcı mavi kutu ile yapmalısınız.");
                                return;
                            }
                        }
                    }
                    sss.satirveyasutun((int)numericUpDown1.Value,tk.dizikutular);
                    if (sss.sayacsatirakelimegirisi > 0 && sss.sayacsutunakelimegirisi > 0)
                        return;
                    kk.KelimeKontrolu(listBox1,flowLayoutPanel1,sai.dizisatir3,sui.dizisutun3,TDKIslemleri.dizitdk);
                   
                }
                catch (Exception)
                {
                    MessageBox.Show("kelime giriniz");
                }
                finally
                {
                    
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = numericUpDown1.Value.ToString(); 
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            if (XMLOkuma.Sayacxml.InnerText == "1" && AltKutular.KutuMemo.Text != "")
            {
                if (AltKutular.tf.lblTasiyici.Text != "" && (AltKutular.tf.Top > flowLayoutPanel1.Top || AltKutular.tf.Left < flowLayoutPanel1.Left || AltKutular.tf.Left < 0 || AltKutular.tf.Right > flowLayoutPanel1.Right))
                {
                    foreach (Label item in AltKutular.dizialtkutu)
                    {
                        if (item.Text == "")
                        {
                            item.Text = AltKutular.tf.lblTasiyici.Text;
                            AltKutular.KutuMemo.Text = "";
                            break;
                        }
                    }

                    AltKutular.tf.Close();
                }
            }
        }

        
        private void animasyonAçKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (XMLOkuma.Sayacxml.InnerText == "1")
            {
                XMLOkuma.Sayacxml.InnerText = "0";
            }

            else if (XMLOkuma.Sayacxml.InnerText == "0")
            {
                XMLOkuma.Sayacxml.InnerText = "1";
            }

            XMLOkuma.xml.Save(XMLOkuma.dosyaismi);
            
        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();                       
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            OyunKayit.HarfleriKaydet(flowLayoutPanel1, kutu.a, listBox1,flowLayoutPanel2,numericUpDown1);
            Application.Exit();
        }

        

        

        
    }
}
