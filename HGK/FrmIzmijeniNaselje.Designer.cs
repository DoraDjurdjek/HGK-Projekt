namespace HGK
{
    partial class FrmIzmijeniNaselje
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaticniBrojNaselja = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbZupanije = new System.Windows.Forms.ComboBox();
            this.txtNazivNaselja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIzmijeni = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Županija";
            // 
            // txtMaticniBrojNaselja
            // 
            this.txtMaticniBrojNaselja.Location = new System.Drawing.Point(144, 75);
            this.txtMaticniBrojNaselja.Name = "txtMaticniBrojNaselja";
            this.txtMaticniBrojNaselja.Size = new System.Drawing.Size(202, 22);
            this.txtMaticniBrojNaselja.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Matični broj naselja";
            // 
            // cmbZupanije
            // 
            this.cmbZupanije.FormattingEnabled = true;
            this.cmbZupanije.Location = new System.Drawing.Point(144, 112);
            this.cmbZupanije.Name = "cmbZupanije";
            this.cmbZupanije.Size = new System.Drawing.Size(202, 24);
            this.cmbZupanije.TabIndex = 9;
            // 
            // txtNazivNaselja
            // 
            this.txtNazivNaselja.Location = new System.Drawing.Point(144, 38);
            this.txtNazivNaselja.Name = "txtNazivNaselja";
            this.txtNazivNaselja.Size = new System.Drawing.Size(202, 22);
            this.txtNazivNaselja.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Naziv";
            // 
            // btnIzmijeni
            // 
            this.btnIzmijeni.Location = new System.Drawing.Point(38, 161);
            this.btnIzmijeni.Name = "btnIzmijeni";
            this.btnIzmijeni.Size = new System.Drawing.Size(100, 33);
            this.btnIzmijeni.TabIndex = 13;
            this.btnIzmijeni.Text = "Izmijeni";
            this.btnIzmijeni.UseVisualStyleBackColor = true;
            this.btnIzmijeni.Click += new System.EventHandler(this.btnIzmijeni_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(144, 161);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(100, 33);
            this.btnOdustani.TabIndex = 14;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // FrmIzmijeniNaselje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 225);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnIzmijeni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaticniBrojNaselja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbZupanije);
            this.Controls.Add(this.txtNazivNaselja);
            this.Controls.Add(this.label1);
            this.Name = "FrmIzmijeniNaselje";
            this.Text = "Izmjena naselja";
            this.Load += new System.EventHandler(this.FrmIzmijeniNaselje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaticniBrojNaselja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbZupanije;
        private System.Windows.Forms.TextBox txtNazivNaselja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIzmijeni;
        private System.Windows.Forms.Button btnOdustani;
    }
}