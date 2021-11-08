namespace HGK
{
    partial class FrmUnosNaselja
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
            this.txtNazivNaselja = new System.Windows.Forms.TextBox();
            this.cmbZupanije = new System.Windows.Forms.ComboBox();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.txtMaticniBrojNaselja = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvNaselja = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnIzmijeni = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaselja)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // txtNazivNaselja
            // 
            this.txtNazivNaselja.Location = new System.Drawing.Point(144, 24);
            this.txtNazivNaselja.Name = "txtNazivNaselja";
            this.txtNazivNaselja.Size = new System.Drawing.Size(310, 22);
            this.txtNazivNaselja.TabIndex = 1;
            // 
            // cmbZupanije
            // 
            this.cmbZupanije.FormattingEnabled = true;
            this.cmbZupanije.Location = new System.Drawing.Point(144, 92);
            this.cmbZupanije.Name = "cmbZupanije";
            this.cmbZupanije.Size = new System.Drawing.Size(310, 24);
            this.cmbZupanije.TabIndex = 2;
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(144, 124);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(87, 38);
            this.btnUnesi.TabIndex = 3;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // txtMaticniBrojNaselja
            // 
            this.txtMaticniBrojNaselja.Location = new System.Drawing.Point(144, 59);
            this.txtMaticniBrojNaselja.Name = "txtMaticniBrojNaselja";
            this.txtMaticniBrojNaselja.Size = new System.Drawing.Size(310, 22);
            this.txtMaticniBrojNaselja.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Matični broj naselja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Županija";
            // 
            // dgvNaselja
            // 
            this.dgvNaselja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNaselja.Location = new System.Drawing.Point(12, 211);
            this.dgvNaselja.Name = "dgvNaselja";
            this.dgvNaselja.RowTemplate.Height = 24;
            this.dgvNaselja.Size = new System.Drawing.Size(622, 150);
            this.dgvNaselja.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Obriši";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIzmijeni
            // 
            this.btnIzmijeni.Location = new System.Drawing.Point(361, 367);
            this.btnIzmijeni.Name = "btnIzmijeni";
            this.btnIzmijeni.Size = new System.Drawing.Size(87, 37);
            this.btnIzmijeni.TabIndex = 9;
            this.btnIzmijeni.Text = "Izmijeni";
            this.btnIzmijeni.UseVisualStyleBackColor = true;
            this.btnIzmijeni.Click += new System.EventHandler(this.btnIzmijeni_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(547, 367);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(87, 37);
            this.btnOdustani.TabIndex = 10;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Popis naselja:";
            // 
            // FrmUnosNaselja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 415);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnIzmijeni);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvNaselja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaticniBrojNaselja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.cmbZupanije);
            this.Controls.Add(this.txtNazivNaselja);
            this.Controls.Add(this.label1);
            this.Name = "FrmUnosNaselja";
            this.Text = "Unos naselja";
            this.Load += new System.EventHandler(this.FrmUnosNaselja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaselja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNazivNaselja;
        private System.Windows.Forms.ComboBox cmbZupanije;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.TextBox txtMaticniBrojNaselja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvNaselja;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnIzmijeni;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label label4;
    }
}