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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRegistracija = new System.Windows.Forms.TextBox();
            this.datGodReg = new System.Windows.Forms.DateTimePicker();
            this.txtDuzina = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtImeV = new System.Windows.Forms.TextBox();
            this.txtSB = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlBarka.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRegistracija);
            this.groupBox1.Controls.Add(this.datGodReg);
            this.groupBox1.Controls.Add(this.txtDuzina);
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
            // txtRegistracija
            // 
            this.txtRegistracija.Location = new System.Drawing.Point(6, 50);
            this.txtRegistracija.Name = "txtRegistracija";
            this.txtRegistracija.Size = new System.Drawing.Size(264, 31);
            this.txtRegistracija.TabIndex = 2;
            this.txtRegistracija.Text = "Registracija";
            this.txtRegistracija.GotFocus += new System.EventHandler(this.txtRegistracija_Focused);
            this.txtRegistracija.LostFocus += new System.EventHandler(this.txtRegistracija_UnFocused);
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
            // txtDuzina
            // 
            this.txtDuzina.Location = new System.Drawing.Point(328, 50);
            this.txtDuzina.Name = "txtDuzina";
            this.txtDuzina.Size = new System.Drawing.Size(264, 31);
            this.txtDuzina.TabIndex = 5;
            this.txtDuzina.Text = "Duzina";
            this.txtDuzina.GotFocus += new System.EventHandler(this.txtDuzina_Focused);
            this.txtDuzina.LostFocus += new System.EventHandler(this.txtDuzina_UnFocused);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(328, 109);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(264, 31);
            this.textBox5.TabIndex = 6;
            this.textBox5.Text = "Tezina";
            // 
            // txtImeV
            // 
            this.txtImeV.Location = new System.Drawing.Point(6, 109);
            this.txtImeV.Name = "txtImeV";
            this.txtImeV.Size = new System.Drawing.Size(264, 31);
            this.txtImeV.TabIndex = 3;
            this.txtImeV.Text = "Ime vozila";
            // 
            // txtSB
            // 
            this.txtSB.Location = new System.Drawing.Point(6, 166);
            this.txtSB.Name = "txtSB";
            this.txtSB.Size = new System.Drawing.Size(264, 31);
            this.txtSB.TabIndex = 4;
            this.txtSB.Text = "Serijski broj vozila";
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
            // NoviVez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 1016);
            this.Controls.Add(this.pnlBarka);
            this.Name = "NoviVez";
            this.Text = "Novi vez";
            this.pnlBarka.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSlika;
        private System.Windows.Forms.Panel pnlBarka;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtDuzina;
        private System.Windows.Forms.TextBox txtSB;
        private System.Windows.Forms.TextBox txtImeV;
        private System.Windows.Forms.TextBox txtRegistracija;
        private System.Windows.Forms.DateTimePicker datGodReg;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}