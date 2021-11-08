namespace HGK
{
    partial class FrmStatistika
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
            this.btnAgentiPoZupanijama = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbStatiAgentipoZupanija = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbStrukeAgenata = new System.Windows.Forms.RichTextBox();
            this.btnAgentiPoStruci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgentiPoZupanijama
            // 
            this.btnAgentiPoZupanijama.Location = new System.Drawing.Point(318, 60);
            this.btnAgentiPoZupanijama.Name = "btnAgentiPoZupanijama";
            this.btnAgentiPoZupanijama.Size = new System.Drawing.Size(121, 34);
            this.btnAgentiPoZupanijama.TabIndex = 0;
            this.btnAgentiPoZupanijama.Text = "Izračunaj";
            this.btnAgentiPoZupanijama.UseVisualStyleBackColor = true;
            this.btnAgentiPoZupanijama.Click += new System.EventHandler(this.btnAgentiPoZupanijama_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agenti po županijama:";
            // 
            // rtbStatiAgentipoZupanija
            // 
            this.rtbStatiAgentipoZupanija.Location = new System.Drawing.Point(12, 97);
            this.rtbStatiAgentipoZupanija.Name = "rtbStatiAgentipoZupanija";
            this.rtbStatiAgentipoZupanija.Size = new System.Drawing.Size(427, 341);
            this.rtbStatiAgentipoZupanija.TabIndex = 2;
            this.rtbStatiAgentipoZupanija.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Agenti prema stručnoj spremi:";
            // 
            // rtbStrukeAgenata
            // 
            this.rtbStrukeAgenata.Location = new System.Drawing.Point(479, 97);
            this.rtbStrukeAgenata.Name = "rtbStrukeAgenata";
            this.rtbStrukeAgenata.Size = new System.Drawing.Size(450, 341);
            this.rtbStrukeAgenata.TabIndex = 2;
            this.rtbStrukeAgenata.Text = "";
            // 
            // btnAgentiPoStruci
            // 
            this.btnAgentiPoStruci.Location = new System.Drawing.Point(808, 60);
            this.btnAgentiPoStruci.Name = "btnAgentiPoStruci";
            this.btnAgentiPoStruci.Size = new System.Drawing.Size(121, 34);
            this.btnAgentiPoStruci.TabIndex = 3;
            this.btnAgentiPoStruci.Text = "Izračunaj";
            this.btnAgentiPoStruci.UseVisualStyleBackColor = true;
            this.btnAgentiPoStruci.Click += new System.EventHandler(this.btnAgentiPoStruci_Click);
            // 
            // FrmStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 450);
            this.Controls.Add(this.btnAgentiPoStruci);
            this.Controls.Add(this.rtbStrukeAgenata);
            this.Controls.Add(this.rtbStatiAgentipoZupanija);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgentiPoZupanijama);
            this.Name = "FrmStatistika";
            this.Text = "Statistika";
            this.Load += new System.EventHandler(this.FrmStatistika_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgentiPoZupanijama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbStatiAgentipoZupanija;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbStrukeAgenata;
        private System.Windows.Forms.Button btnAgentiPoStruci;
    }
}