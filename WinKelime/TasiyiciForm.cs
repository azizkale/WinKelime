using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinKelime
{
    public partial class TasiyiciForm : Form
    {
        public TasiyiciForm()
        {
            InitializeComponent();
        }

        private void TasiyiciForm_Load(object sender, EventArgs e)
        {
            this.Opacity = 1;
            this.Width = 35;
            this.Height = 35;
        }

        private void lblTasiyici_MouseMove(object sender, MouseEventArgs e)
        {
            AltKutular.tf.Left = Cursor.Position.X - 36;
            AltKutular.tf.Top = Cursor.Position.Y - 35;
        }
    }
}
