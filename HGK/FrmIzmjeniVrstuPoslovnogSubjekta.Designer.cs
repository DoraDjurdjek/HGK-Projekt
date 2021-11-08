namespace HGK
{
    partial class FrmIzmjeniVrstuPoslovnogSubjekta
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtOznaka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNazivVrstePoslovnogSubjekta = new System.Windows.Forms.TextBox();
            this.btnIzmijeni = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Oznaka";
            // 
            // txtOznaka
            // 
            this.txtOznaka.Location = new System.Drawing.Point(223, 63);
            this.txtOznaka.Name = "txtOznaka";
            this.txtOznaka.Size = new System.Drawing.Size(181, 22);
            this.txtOznaka.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Unesi vrstu poslovnog subjekta";
            // 
            // txtNazivVrstePoslovnogSubjekta
            // 
            this.txtNazivVrstePoslovnogSubjekta.Location = new System.Drawing.Point(223, 31);
            this.txtNazivVrstePoslovnogSubjekta.Name = "txtNazivVrstePoslovnogSubjekta";
            this.txtNazivVrstePoslovnogSubjekta.Size = new System.Drawing.Size(181, 22);
            this.txtNazivVrstePoslovnogSubjekta.TabIndex = 8;
            // 
            // btnIzmijeni
            // 
            this.btnIzmijeni.Location = new System.Drawing.Point(129, 104);
            this.btnIzmijeni.Name = "btnIzmijeni";
            this.btnIzmijeni.Size = new System.Drawing.Size(88, 31);
            this.btnIzmijeni.TabIndex = 12;
            this.btnIzmijeni.Text = "Izmijeni";
            this.btnIzmijeni.UseVisualStyleBackColor = true;
            this.btnIzmijeni.Click += new System.EventHandler(this.btnIzmijeni_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 31);
            this.button1.TabIndex = 13;
            this.button1.Text = "Odustani";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmIzmjeniVrstuPoslovnogSubjekta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 155);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIzmijeni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOznaka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNazivVrstePoslovnogSubjekta);
            this.Name = "FrmIzmjeniVrstuPoslovnogSubjekta";
            this.Text = "Izmijeni vrstu poslovnog subjekta";
            this.Load += new System.EventHandler(this.FrmIzmjeniVrstuPoslovnogSubjekta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOznaka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNazivVrstePoslovnogSubjekta;
        private System.Windows.Forms.Button btnIzmijeni;
        private System.Windows.Forms.Button button1;
    }
}