namespace HGK
{
    partial class FrmUnosVrstePoslovnogSubjekta
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
            this.txtNazivVrstePoslovnogSubjekta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzmijeni = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.dgvVrstaPoslovnogSubjekta = new System.Windows.Forms.DataGridView();
            this.txtOznaka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVrstaPoslovnogSubjekta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNazivVrstePoslovnogSubjekta
            // 
            this.txtNazivVrstePoslovnogSubjekta.Location = new System.Drawing.Point(224, 31);
            this.txtNazivVrstePoslovnogSubjekta.Name = "txtNazivVrstePoslovnogSubjekta";
            this.txtNazivVrstePoslovnogSubjekta.Size = new System.Drawing.Size(272, 22);
            this.txtNazivVrstePoslovnogSubjekta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesi vrstu poslovnog subjekta";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(224, 92);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(80, 36);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzmijeni
            // 
            this.btnIzmijeni.Location = new System.Drawing.Point(243, 331);
            this.btnIzmijeni.Name = "btnIzmijeni";
            this.btnIzmijeni.Size = new System.Drawing.Size(81, 35);
            this.btnIzmijeni.TabIndex = 3;
            this.btnIzmijeni.Text = "Izmijeni";
            this.btnIzmijeni.UseVisualStyleBackColor = true;
            this.btnIzmijeni.Click += new System.EventHandler(this.btnIzmijeni_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(330, 331);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(80, 35);
            this.btnIzbrisi.TabIndex = 4;
            this.btnIzbrisi.Text = "Izbriši";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // dgvVrstaPoslovnogSubjekta
            // 
            this.dgvVrstaPoslovnogSubjekta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVrstaPoslovnogSubjekta.Location = new System.Drawing.Point(16, 175);
            this.dgvVrstaPoslovnogSubjekta.Name = "dgvVrstaPoslovnogSubjekta";
            this.dgvVrstaPoslovnogSubjekta.RowTemplate.Height = 24;
            this.dgvVrstaPoslovnogSubjekta.Size = new System.Drawing.Size(480, 150);
            this.dgvVrstaPoslovnogSubjekta.TabIndex = 5;
            // 
            // txtOznaka
            // 
            this.txtOznaka.Location = new System.Drawing.Point(224, 64);
            this.txtOznaka.Name = "txtOznaka";
            this.txtOznaka.Size = new System.Drawing.Size(272, 22);
            this.txtOznaka.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Oznaka";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Odustani";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Popis vrsta poslovnih subjekata:";
            // 
            // FrmUnosVrstePoslovnogSubjekta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 380);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOznaka);
            this.Controls.Add(this.dgvVrstaPoslovnogSubjekta);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnIzmijeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNazivVrstePoslovnogSubjekta);
            this.Name = "FrmUnosVrstePoslovnogSubjekta";
            this.Text = "Unos vrste poslovnog subjekta";
            this.Load += new System.EventHandler(this.FrmUnosVrstePoslovnogSubjekta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVrstaPoslovnogSubjekta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNazivVrstePoslovnogSubjekta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmijeni;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.DataGridView dgvVrstaPoslovnogSubjekta;
        private System.Windows.Forms.TextBox txtOznaka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}