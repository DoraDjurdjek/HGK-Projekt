namespace HGK
{
    partial class FrmUnosStrucneSpreme
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
            this.txtNazivStrucneSpreme = new System.Windows.Forms.TextBox();
            this.txtOznakaStrucneSpreme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.dgvStrucneSpreme = new System.Windows.Forms.DataGridView();
            this.btnIzmijeni = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStrucneSpreme)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNazivStrucneSpreme
            // 
            this.txtNazivStrucneSpreme.Location = new System.Drawing.Point(207, 26);
            this.txtNazivStrucneSpreme.Name = "txtNazivStrucneSpreme";
            this.txtNazivStrucneSpreme.Size = new System.Drawing.Size(267, 22);
            this.txtNazivStrucneSpreme.TabIndex = 0;
            // 
            // txtOznakaStrucneSpreme
            // 
            this.txtOznakaStrucneSpreme.Location = new System.Drawing.Point(207, 59);
            this.txtOznakaStrucneSpreme.Name = "txtOznakaStrucneSpreme";
            this.txtOznakaStrucneSpreme.Size = new System.Drawing.Size(267, 22);
            this.txtOznakaStrucneSpreme.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naziv stručne spreme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Oznaka stručne spreme";
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(207, 87);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(77, 32);
            this.btnUnesi.TabIndex = 4;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // dgvStrucneSpreme
            // 
            this.dgvStrucneSpreme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStrucneSpreme.Location = new System.Drawing.Point(12, 184);
            this.dgvStrucneSpreme.Name = "dgvStrucneSpreme";
            this.dgvStrucneSpreme.RowTemplate.Height = 24;
            this.dgvStrucneSpreme.Size = new System.Drawing.Size(462, 154);
            this.dgvStrucneSpreme.TabIndex = 5;
            // 
            // btnIzmijeni
            // 
            this.btnIzmijeni.Location = new System.Drawing.Point(231, 344);
            this.btnIzmijeni.Name = "btnIzmijeni";
            this.btnIzmijeni.Size = new System.Drawing.Size(77, 32);
            this.btnIzmijeni.TabIndex = 6;
            this.btnIzmijeni.Text = "Izmijeni";
            this.btnIzmijeni.UseVisualStyleBackColor = true;
            this.btnIzmijeni.Click += new System.EventHandler(this.btnIzmijeni_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(314, 344);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(77, 32);
            this.btnIzbrisi.TabIndex = 7;
            this.btnIzbrisi.Text = "Izbriši";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(397, 344);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(77, 32);
            this.btnOdustani.TabIndex = 8;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Popis stručnih sprema:";
            // 
            // FrmUnosStrucneSpreme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 387);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnIzmijeni);
            this.Controls.Add(this.dgvStrucneSpreme);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOznakaStrucneSpreme);
            this.Controls.Add(this.txtNazivStrucneSpreme);
            this.Name = "FrmUnosStrucneSpreme";
            this.Text = "Unos stručne spreme";
            this.Load += new System.EventHandler(this.FrmUnosStrucneSpreme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStrucneSpreme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNazivStrucneSpreme;
        private System.Windows.Forms.TextBox txtOznakaStrucneSpreme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.DataGridView dgvStrucneSpreme;
        private System.Windows.Forms.Button btnIzmijeni;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label label3;
    }
}