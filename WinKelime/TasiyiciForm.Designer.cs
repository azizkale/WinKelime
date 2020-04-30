namespace WinKelime
{
    partial class TasiyiciForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTasiyici = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTasiyici
            // 
            this.lblTasiyici.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblTasiyici.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTasiyici.Location = new System.Drawing.Point(0, 0);
            this.lblTasiyici.Name = "lblTasiyici";
            this.lblTasiyici.Size = new System.Drawing.Size(35, 35);
            this.lblTasiyici.TabIndex = 0;
            this.lblTasiyici.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTasiyici_MouseMove);
            // 
            // TasiyiciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(35, 35);
            this.ControlBox = false;
            this.Controls.Add(this.lblTasiyici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(35, 35);
            this.MinimizeBox = false;
            this.Name = "TasiyiciForm";
            this.Opacity = 0.01D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TasiyiciForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblTasiyici;

    }
}