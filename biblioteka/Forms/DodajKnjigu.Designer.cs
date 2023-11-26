namespace biblioteka.Forms
{
    partial class DodajKnjigu
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
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblIzdavac = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtIzdavac = new System.Windows.Forms.TextBox();
            this.lblPrihvati = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Location = new System.Drawing.Point(68, 36);
            this.lblNaslov.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(43, 13);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "Naslov:";
            // 
            // lblIzdavac
            // 
            this.lblIzdavac.AutoSize = true;
            this.lblIzdavac.Location = new System.Drawing.Point(64, 111);
            this.lblIzdavac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIzdavac.Name = "lblIzdavac";
            this.lblIzdavac.Size = new System.Drawing.Size(48, 13);
            this.lblIzdavac.TabIndex = 1;
            this.lblIzdavac.Text = "Izdavac:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(76, 74);
            this.lblAutor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(35, 13);
            this.lblAutor.TabIndex = 2;
            this.lblAutor.Text = "Autor:";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(140, 35);
            this.txtNaslov.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(102, 20);
            this.txtNaslov.TabIndex = 3;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(140, 72);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(102, 20);
            this.txtAutor.TabIndex = 4;
            // 
            // txtIzdavac
            // 
            this.txtIzdavac.Location = new System.Drawing.Point(140, 110);
            this.txtIzdavac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIzdavac.Name = "txtIzdavac";
            this.txtIzdavac.Size = new System.Drawing.Size(102, 20);
            this.txtIzdavac.TabIndex = 5;
            // 
            // lblPrihvati
            // 
            this.lblPrihvati.Location = new System.Drawing.Point(172, 189);
            this.lblPrihvati.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblPrihvati.Name = "lblPrihvati";
            this.lblPrihvati.Size = new System.Drawing.Size(62, 64);
            this.lblPrihvati.TabIndex = 13;
            this.lblPrihvati.Text = "Prihvati";
            this.lblPrihvati.UseVisualStyleBackColor = true;
            this.lblPrihvati.Click += new System.EventHandler(this.lblPrihvati_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(58, 189);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(62, 64);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Ponisti";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // DodajKnjigu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 279);
            this.Controls.Add(this.lblPrihvati);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtIzdavac);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblIzdavac);
            this.Controls.Add(this.lblNaslov);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DodajKnjigu";
            this.Text = "Dodaj knjigu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblIzdavac;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtIzdavac;
        private System.Windows.Forms.Button lblPrihvati;
        private System.Windows.Forms.Button btnCancel;
    }
}