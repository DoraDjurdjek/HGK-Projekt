namespace HGK
{
    partial class FrmDodjeliAgentaSubjektu
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
            this.dtpUnosa = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOsoba = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegistarskiBroj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPoslovniSubjekt = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvUgovori = new System.Windows.Forms.DataGridView();
            this.btnIzmijeniUgovor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUgovori)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpUnosa
            // 
            this.dtpUnosa.Location = new System.Drawing.Point(132, 20);
            this.dtpUnosa.Name = "dtpUnosa";
            this.dtpUnosa.Size = new System.Drawing.Size(200, 22);
            this.dtpUnosa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Datum unosa";
            // 
            // cmbOsoba
            // 
            this.cmbOsoba.FormattingEnabled = true;
            this.cmbOsoba.Location = new System.Drawing.Point(132, 48);
            this.cmbOsoba.Name = "cmbOsoba";
            this.cmbOsoba.Size = new System.Drawing.Size(200, 24);
            this.cmbOsoba.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Agent";
            // 
            // txtRegistarskiBroj
            // 
            this.txtRegistarskiBroj.Location = new System.Drawing.Point(132, 113);
            this.txtRegistarskiBroj.Name = "txtRegistarskiBroj";
            this.txtRegistarskiBroj.Size = new System.Drawing.Size(200, 22);
            this.txtRegistarskiBroj.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Broj ugovora";
            // 
            // cmbPoslovniSubjekt
            // 
            this.cmbPoslovniSubjekt.FormattingEnabled = true;
            this.cmbPoslovniSubjekt.Location = new System.Drawing.Point(132, 79);
            this.cmbPoslovniSubjekt.Name = "cmbPoslovniSubjekt";
            this.cmbPoslovniSubjekt.Size = new System.Drawing.Size(200, 24);
            this.cmbPoslovniSubjekt.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Poslovni subjekt";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(132, 141);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(95, 33);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvUgovori
            // 
            this.dgvUgovori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUgovori.Location = new System.Drawing.Point(12, 246);
            this.dgvUgovori.Name = "dgvUgovori";
            this.dgvUgovori.RowTemplate.Height = 24;
            this.dgvUgovori.Size = new System.Drawing.Size(764, 150);
            this.dgvUgovori.TabIndex = 8;
            // 
            // btnIzmijeniUgovor
            // 
            this.btnIzmijeniUgovor.Location = new System.Drawing.Point(472, 406);
            this.btnIzmijeniUgovor.Name = "btnIzmijeniUgovor";
            this.btnIzmijeniUgovor.Size = new System.Drawing.Size(149, 32);
            this.btnIzmijeniUgovor.TabIndex = 10;
            this.btnIzmijeniUgovor.Text = "Deaktiviraj ugovor";
            this.btnIzmijeniUgovor.UseVisualStyleBackColor = true;
            this.btnIzmijeniUgovor.Click += new System.EventHandler(this.btnDeaktiviraj_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Popis ugovora:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(627, 406);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(149, 32);
            this.btnOdustani.TabIndex = 13;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // FrmDodjeliAgentaSubjektu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnIzmijeniUgovor);
            this.Controls.Add(this.dgvUgovori);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtRegistarskiBroj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPoslovniSubjekt);
            this.Controls.Add(this.cmbOsoba);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpUnosa);
            this.Name = "FrmDodjeliAgentaSubjektu";
            this.Text = "Dodijeli agenta poslovnom subjektu";
            this.Load += new System.EventHandler(this.FrmDodjeliAgentaSubjektu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUgovori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpUnosa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOsoba;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegistarskiBroj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPoslovniSubjekt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvUgovori;
        private System.Windows.Forms.Button btnIzmijeniUgovor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOdustani;
    }
}