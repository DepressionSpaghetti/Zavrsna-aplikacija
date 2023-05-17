namespace Zavrsna_aplikacija
{
    partial class NoviVez
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
            this.btnSlika = new System.Windows.Forms.Button();
            this.pnlBarka = new System.Windows.Forms.Panel();
            this.datGodReg = new System.Windows.Forms.DateTimePicker();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtSB = new System.Windows.Forms.TextBox();
            this.txtImeV = new System.Windows.Forms.TextBox();
            this.txtRegistracija = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlBarka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSlika
            // 
            this.btnSlika.Location = new System.Drawing.Point(167, 125);
            this.btnSlika.Name = "btnSlika";
            this.btnSlika.Size = new System.Drawing.Size(155, 71);
            this.btnSlika.TabIndex = 0;
            this.btnSlika.Text = "Dodaj sliku";
            this.btnSlika.UseVisualStyleBackColor = true;
            this.btnSlika.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlBarka
            // 
            this.pnlBarka.Controls.Add(this.groupBox1);
            this.pnlBarka.Controls.Add(this.btnSlika);
            this.pnlBarka.Controls.Add(this.pictureBox1);
            this.pnlBarka.Location = new System.Drawing.Point(12, 12);
            this.pnlBarka.Name = "pnlBarka";
            this.pnlBarka.Size = new System.Drawing.Size(1448, 992);
            this.pnlBarka.TabIndex = 1;
            // 
            // datGodReg
            // 
            this.datGodReg.CustomFormat = "yyyy";
            this.datGodReg.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datGodReg.Location = new System.Drawing.Point(328, 166);
            this.datGodReg.Name = "datGodReg";
            this.datGodReg.Size = new System.Drawing.Size(264, 31);
            this.datGodReg.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(328, 109);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(264, 31);
            this.textBox5.TabIndex = 6;
            this.textBox5.Text = "Tezina";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(328, 50);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(264, 31);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "Duzina";
            // 
            // txtSB
            // 
            this.txtSB.Location = new System.Drawing.Point(6, 166);
            this.txtSB.Name = "txtSB";
            this.txtSB.Size = new System.Drawing.Size(264, 31);
            this.txtSB.TabIndex = 4;
            this.txtSB.Text = "Serijski broj vozila";
            // 
            // txtImeV
            // 
            this.txtImeV.Location = new System.Drawing.Point(6, 109);
            this.txtImeV.Name = "txtImeV";
            this.txtImeV.Size = new System.Drawing.Size(264, 31);
            this.txtImeV.TabIndex = 3;
            this.txtImeV.Text = "Ime vozila";
            // 
            // txtRegistracija
            // 
            this.txtRegistracija.Location = new System.Drawing.Point(6, 50);
            this.txtRegistracija.Name = "txtRegistracija";
            this.txtRegistracija.Size = new System.Drawing.Size(264, 31);
            this.txtRegistracija.TabIndex = 2;
            this.txtRegistracija.Text = "Registracija";
            this.txtRegistracija.Click += new System.EventHandler(this.txtRegistracija_Clicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(22, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(464, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRegistracija);
            this.groupBox1.Controls.Add(this.datGodReg);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.txtImeV);
            this.groupBox1.Controls.Add(this.txtSB);
            this.groupBox1.Location = new System.Drawing.Point(581, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 234);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o vozilu";
            // 
            // NoviVez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 1016);
            this.Controls.Add(this.pnlBarka);
            this.Name = "NoviVez";
            this.Text = "Novi vez";
            this.pnlBarka.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSlika;
        private System.Windows.Forms.Panel pnlBarka;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtSB;
        private System.Windows.Forms.TextBox txtImeV;
        private System.Windows.Forms.TextBox txtRegistracija;
        private System.Windows.Forms.DateTimePicker datGodReg;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}