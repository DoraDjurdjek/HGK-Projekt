namespace HGK
{
    partial class FrmUnosZupanija
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtZupanije = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnOdaberi = new System.Windows.Forms.Button();
            this.dgvZuapnije = new System.Windows.Forms.DataGridView();
            this.txtZupanijeIzmjena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnizmjeni = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZuapnije)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv županije";
            // 
            // txtZupanije
            // 
            this.txtZupanije.Location = new System.Drawing.Point(118, 26);
            this.txtZupanije.Name = "txtZupanije";
            this.txtZupanije.Size = new System.Drawing.Size(154, 22);
            this.txtZupanije.TabIndex = 1;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(278, 19);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(88, 36);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(184, 262);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(88, 44);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Izbriši županiju";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.Location = new System.Drawing.Point(90, 262);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(88, 44);
            this.btnOdaberi.TabIndex = 2;
            this.btnOdaberi.Text = "Odaberi za izmjenu";
            this.btnOdaberi.UseVisualStyleBackColor = true;
            this.btnOdaberi.Click += new System.EventHandler(this.btnOdaberi_Click);
            // 
            // dgvZuapnije
            // 
            this.dgvZuapnije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZuapnije.Location = new System.Drawing.Point(15, 106);
            this.dgvZuapnije.Name = "dgvZuapnije";
            this.dgvZuapnije.RowTemplate.Height = 24;
            this.dgvZuapnije.Size = new System.Drawing.Size(351, 150);
            this.dgvZuapnije.TabIndex = 3;
            // 
            // txtZupanijeIzmjena
            // 
            this.txtZupanijeIzmjena.Location = new System.Drawing.Point(148, 339);
            this.txtZupanijeIzmjena.Name = "txtZupanijeIzmjena";
            this.txtZupanijeIzmjena.Size = new System.Drawing.Size(124, 22);
            this.txtZupanijeIzmjena.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Novi naziv županije";
            // 
            // btnizmjeni
            // 
            this.btnizmjeni.Location = new System.Drawing.Point(278, 332);
            this.btnizmjeni.Name = "btnizmjeni";
            this.btnizmjeni.Size = new System.Drawing.Size(88, 36);
            this.btnizmjeni.TabIndex = 6;
            this.btnizmjeni.Text = "Izmijeni";
            this.btnizmjeni.UseVisualStyleBackColor = true;
            this.btnizmjeni.Click += new System.EventHandler(this.btnizmjeni_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(278, 262);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(88, 44);
            this.btnOdustani.TabIndex = 7;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Popis županija:";
            // 
            // FrmUnosZupanija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 386);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnizmjeni);
            this.Controls.Add(this.txtZupanijeIzmjena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvZuapnije);
            this.Controls.Add(this.btnOdaberi);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtZupanije);
            this.Controls.Add(this.label1);
            this.Name = "FrmUnosZupanija";
            this.Text = "Unos županija";
            this.Load += new System.EventHandler(this.FrmUnosZupanija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZuapnije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtZupanije;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnOdaberi;
        private System.Windows.Forms.DataGridView dgvZuapnije;
        private System.Windows.Forms.TextBox txtZupanijeIzmjena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnizmjeni;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label label3;
    }
}