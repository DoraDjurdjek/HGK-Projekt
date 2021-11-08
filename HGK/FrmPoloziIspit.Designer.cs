namespace HGK
{
    partial class FrmPoloziIspit
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
            this.label14 = new System.Windows.Forms.Label();
            this.rtxtNapomena = new System.Windows.Forms.RichTextBox();
            this.dtpPolozenIspit = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.btnIzmijeni = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(87, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 17);
            this.label14.TabIndex = 38;
            this.label14.Text = "Napomena";
            // 
            // rtxtNapomena
            // 
            this.rtxtNapomena.Location = new System.Drawing.Point(170, 58);
            this.rtxtNapomena.Name = "rtxtNapomena";
            this.rtxtNapomena.Size = new System.Drawing.Size(214, 96);
            this.rtxtNapomena.TabIndex = 37;
            this.rtxtNapomena.Text = "";
            // 
            // dtpPolozenIspit
            // 
            this.dtpPolozenIspit.Location = new System.Drawing.Point(170, 27);
            this.dtpPolozenIspit.Name = "dtpPolozenIspit";
            this.dtpPolozenIspit.Size = new System.Drawing.Size(155, 22);
            this.dtpPolozenIspit.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 17);
            this.label13.TabIndex = 35;
            this.label13.Text = "Datum polaganja ispita";
            // 
            // btnIzmijeni
            // 
            this.btnIzmijeni.Location = new System.Drawing.Point(170, 160);
            this.btnIzmijeni.Name = "btnIzmijeni";
            this.btnIzmijeni.Size = new System.Drawing.Size(83, 37);
            this.btnIzmijeni.TabIndex = 39;
            this.btnIzmijeni.Text = "Položio";
            this.btnIzmijeni.UseVisualStyleBackColor = true;
            this.btnIzmijeni.Click += new System.EventHandler(this.btnIzmijeni_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(259, 160);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(83, 37);
            this.btnOdustani.TabIndex = 40;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // FrmPoloziIspit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 219);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnIzmijeni);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.rtxtNapomena);
            this.Controls.Add(this.dtpPolozenIspit);
            this.Controls.Add(this.label13);
            this.Name = "FrmPoloziIspit";
            this.Text = "Polaganje ispita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox rtxtNapomena;
        private System.Windows.Forms.DateTimePicker dtpPolozenIspit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnIzmijeni;
        private System.Windows.Forms.Button btnOdustani;
    }
}