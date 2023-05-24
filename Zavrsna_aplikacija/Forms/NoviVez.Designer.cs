using System.Windows.Forms;

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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrekid = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDrzReg = new System.Windows.Forms.TextBox();
            this.datGodReg = new System.Windows.Forms.DateTimePicker();
            this.txtRegistracija = new System.Windows.Forms.TextBox();
            this.txtSB = new System.Windows.Forms.TextBox();
            this.txtTezina = new System.Windows.Forms.TextBox();
            this.txtDuzina = new System.Windows.Forms.TextBox();
            this.txtImeP = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboBrevet = new System.Windows.Forms.ComboBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtMob = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSlika = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtVez = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPrekid);
            this.panel1.Controls.Add(this.btnSlika);
            this.panel1.Controls.Add(this.btnDodaj);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 385);
            this.panel1.TabIndex = 9;
            // 
            // btnPrekid
            // 
            this.btnPrekid.Location = new System.Drawing.Point(192, 322);
            this.btnPrekid.Name = "btnPrekid";
            this.btnPrekid.Size = new System.Drawing.Size(105, 49);
            this.btnPrekid.TabIndex = 12;
            this.btnPrekid.Text = "Ponisti";
            this.btnPrekid.UseVisualStyleBackColor = true;
            this.btnPrekid.Click += new System.EventHandler(this.btnPrekid_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(359, 322);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(105, 49);
            this.btnDodaj.TabIndex = 11;
            this.btnDodaj.Text = "Dodaj vez";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtVez);
            this.groupBox3.Controls.Add(this.txtDrzReg);
            this.groupBox3.Controls.Add(this.datGodReg);
            this.groupBox3.Controls.Add(this.txtRegistracija);
            this.groupBox3.Controls.Add(this.txtSB);
            this.groupBox3.Controls.Add(this.txtTezina);
            this.groupBox3.Controls.Add(this.txtDuzina);
            this.groupBox3.Controls.Add(this.txtImeP);
            this.groupBox3.Location = new System.Drawing.Point(321, 28);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(319, 140);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Podaci o plovilu";
            // 
            // txtDrzReg
            // 
            this.txtDrzReg.Location = new System.Drawing.Point(164, 73);
            this.txtDrzReg.Margin = new System.Windows.Forms.Padding(2);
            this.txtDrzReg.Name = "txtDrzReg";
            this.txtDrzReg.Size = new System.Drawing.Size(134, 20);
            this.txtDrzReg.TabIndex = 8;
            this.txtDrzReg.Text = "Drzava registracije";
            this.txtDrzReg.GotFocus += new System.EventHandler(this.txtDrzReg_Focused);
            this.txtDrzReg.LostFocus += new System.EventHandler(this.txtDrzReg_UnFocused);
            // 
            // datGodReg
            // 
            this.datGodReg.CustomFormat = "yyyy";
            this.datGodReg.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datGodReg.Location = new System.Drawing.Point(164, 99);
            this.datGodReg.Margin = new System.Windows.Forms.Padding(2);
            this.datGodReg.Name = "datGodReg";
            this.datGodReg.Size = new System.Drawing.Size(134, 20);
            this.datGodReg.TabIndex = 7;
            this.datGodReg.Value = new System.DateTime(2023, 5, 21, 20, 16, 41, 0);
            // 
            // txtRegistracija
            // 
            this.txtRegistracija.Location = new System.Drawing.Point(4, 17);
            this.txtRegistracija.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegistracija.Name = "txtRegistracija";
            this.txtRegistracija.Size = new System.Drawing.Size(134, 20);
            this.txtRegistracija.TabIndex = 2;
            this.txtRegistracija.Text = "Registracija";
            this.txtRegistracija.GotFocus += new System.EventHandler(this.txtRegistracija_Focused);
            this.txtRegistracija.LostFocus += new System.EventHandler(this.txtRegistracija_UnFocused);
            // 
            // txtSB
            // 
            this.txtSB.Location = new System.Drawing.Point(4, 73);
            this.txtSB.Margin = new System.Windows.Forms.Padding(2);
            this.txtSB.Name = "txtSB";
            this.txtSB.Size = new System.Drawing.Size(134, 20);
            this.txtSB.TabIndex = 4;
            this.txtSB.Text = "Serijski broj plovila";
            this.txtSB.GotFocus += new System.EventHandler(this.txtSB_Focused);
            this.txtSB.LostFocus += new System.EventHandler(this.txtSB_UnFocused);
            // 
            // txtTezina
            // 
            this.txtTezina.Location = new System.Drawing.Point(164, 45);
            this.txtTezina.Margin = new System.Windows.Forms.Padding(2);
            this.txtTezina.Name = "txtTezina";
            this.txtTezina.Size = new System.Drawing.Size(134, 20);
            this.txtTezina.TabIndex = 6;
            this.txtTezina.Text = "Tezina";
            this.txtTezina.GotFocus += new System.EventHandler(this.txtTezina_Focused);
            this.txtTezina.LostFocus += new System.EventHandler(this.txtTezina_UnFocused);
            // 
            // txtDuzina
            // 
            this.txtDuzina.Location = new System.Drawing.Point(164, 17);
            this.txtDuzina.Margin = new System.Windows.Forms.Padding(2);
            this.txtDuzina.Name = "txtDuzina";
            this.txtDuzina.Size = new System.Drawing.Size(134, 20);
            this.txtDuzina.TabIndex = 5;
            this.txtDuzina.Text = "Duzina";
            this.txtDuzina.GotFocus += new System.EventHandler(this.txtDuzina_Focused);
            this.txtDuzina.LostFocus += new System.EventHandler(this.txtDuzina_UnFocused);
            // 
            // txtImeP
            // 
            this.txtImeP.Location = new System.Drawing.Point(4, 45);
            this.txtImeP.Margin = new System.Windows.Forms.Padding(2);
            this.txtImeP.Name = "txtImeP";
            this.txtImeP.Size = new System.Drawing.Size(134, 20);
            this.txtImeP.TabIndex = 3;
            this.txtImeP.Text = "Ime plovila";
            this.txtImeP.GotFocus += new System.EventHandler(this.txtImeP_Focused);
            this.txtImeP.LostFocus += new System.EventHandler(this.txtImeP_UnFocused);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboBrevet);
            this.groupBox2.Controls.Add(this.txtPrezime);
            this.groupBox2.Controls.Add(this.txtMob);
            this.groupBox2.Controls.Add(this.txtIme);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Location = new System.Drawing.Point(321, 172);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(319, 107);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Podaci o vlasniku";
            // 
            // cboBrevet
            // 
            this.cboBrevet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBrevet.FormattingEnabled = true;
            this.cboBrevet.Items.AddRange(new object[] {
            "Odaberi brevet",
            "A",
            "B",
            "C",
            "Zapovjednik jahte A",
            "Zapovjednik jahte B"});
            this.cboBrevet.Location = new System.Drawing.Point(99, 73);
            this.cboBrevet.Name = "cboBrevet";
            this.cboBrevet.Size = new System.Drawing.Size(121, 21);
            this.cboBrevet.TabIndex = 13;
            this.cboBrevet.SelectedIndex = 0;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(169, 17);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(129, 20);
            this.txtPrezime.TabIndex = 6;
            this.txtPrezime.Text = "Prezime";
            this.txtPrezime.GotFocus += new System.EventHandler(this.txtPrezime_Focused);
            this.txtPrezime.LostFocus += new System.EventHandler(this.txtPrezime_UnFocused);
            // 
            // txtMob
            // 
            this.txtMob.Location = new System.Drawing.Point(4, 45);
            this.txtMob.Margin = new System.Windows.Forms.Padding(2);
            this.txtMob.Name = "txtMob";
            this.txtMob.Size = new System.Drawing.Size(134, 20);
            this.txtMob.TabIndex = 5;
            this.txtMob.Text = "Broj mobitela";
            this.txtMob.GotFocus += new System.EventHandler(this.txtMob_Focused);
            this.txtMob.LostFocus += new System.EventHandler(this.txtMob_UnFocused);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(4, 17);
            this.txtIme.Margin = new System.Windows.Forms.Padding(2);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(134, 20);
            this.txtIme.TabIndex = 2;
            this.txtIme.Text = "Ime";
            this.txtIme.GotFocus += new System.EventHandler(this.txtIme_Focused);
            this.txtIme.LostFocus += new System.EventHandler(this.txtIme_UnFocused);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(169, 45);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(129, 20);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Text = "Email";
            this.txtEmail.GotFocus += new System.EventHandler(this.txtEmail_Focused);
            this.txtEmail.LostFocus += new System.EventHandler(this.txtEmail_UnFocused);
            // 
            // btnSlika
            // 
            this.btnSlika.Location = new System.Drawing.Point(120, 131);
            this.btnSlika.Margin = new System.Windows.Forms.Padding(2);
            this.btnSlika.Name = "btnSlika";
            this.btnSlika.Size = new System.Drawing.Size(78, 37);
            this.btnSlika.TabIndex = 0;
            this.btnSlika.Text = "Dodaj sliku";
            this.btnSlika.UseVisualStyleBackColor = true;
            this.btnSlika.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(32, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtVez
            // 
            this.txtVez.Location = new System.Drawing.Point(4, 102);
            this.txtVez.Margin = new System.Windows.Forms.Padding(2);
            this.txtVez.Name = "txtVez";
            this.txtVez.Size = new System.Drawing.Size(134, 20);
            this.txtVez.TabIndex = 9;
            this.txtVez.Text = "Vez";
            this.txtVez.GotFocus += new System.EventHandler(this.txtVez_Focused);
            this.txtVez.LostFocus += new System.EventHandler(this.txtVez_UnFocused);
            // 
            // NoviVez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 409);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(711, 448);
            this.MinimumSize = new System.Drawing.Size(711, 448);
            this.Name = "NoviVez";
            this.Text = "Novi vez";
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMob;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker datGodReg;
        private System.Windows.Forms.TextBox txtRegistracija;
        private System.Windows.Forms.TextBox txtSB;
        private System.Windows.Forms.TextBox txtTezina;
        private System.Windows.Forms.TextBox txtDuzina;
        private System.Windows.Forms.TextBox txtImeP;
        private System.Windows.Forms.Button btnSlika;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Button btnPrekid;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cboBrevet;
        private TextBox txtDrzReg;
        private TextBox txtVez;
    }
}