namespace HGK
{
    partial class FrmIzmijeniStrucnuSpremu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtOznakaStrucneSpreme = new System.Windows.Forms.TextBox();
            this.txtNazivStrucneSpreme = new System.Windows.Forms.TextBox();
            this.dgvStrucneSpreme = new System.Windows.Forms.DataGridView();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStrucneSpreme)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Oznaka stručne spreme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Naziv stručne spreme";
            // 
            // txtOznakaStrucneSpreme
            // 
            this.txtOznakaStrucneSpreme.Location = new System.Drawing.Point(181, 287);
            this.txtOznakaStrucneSpreme.Name = "txtOznakaStrucneSpreme";
            this.txtOznakaStrucneSpreme.Size = new System.Drawing.Size(294, 22);
            this.txtOznakaStrucneSpreme.TabIndex = 5;
            // 
            // txtNazivStrucneSpreme
            // 
            this.txtNazivStrucneSpreme.Location = new System.Drawing.Point(181, 255);
            this.txtNazivStrucneSpreme.Name = "txtNazivStrucneSpreme";
            this.txtNazivStrucneSpreme.Size = new System.Drawing.Size(294, 22);
            this.txtNazivStrucneSpreme.TabIndex = 4;
            // 
            // dgvStrucneSpreme
            // 
            this.dgvStrucneSpreme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStrucneSpreme.Location = new System.Drawing.Point(12, 55);
            this.dgvStrucneSpreme.Name = "dgvStrucneSpreme";
            this.dgvStrucneSpreme.RowTemplate.Height = 24;
            this.dgvStrucneSpreme.Size = new System.Drawing.Size(463, 180);
            this.dgvStrucneSpreme.TabIndex = 8;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(92, 323);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(83, 32);
            this.btnSpremi.TabIndex = 9;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(181, 323);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(83, 32);
            this.btnOdustani.TabIndex = 10;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Popis stručnih sprema:";
            // 
            // FrmIzmijeniStrucnuSpremu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 384);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.dgvStrucneSpreme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOznakaStrucneSpreme);
            this.Controls.Add(this.txtNazivStrucneSpreme);
            this.Name = "FrmIzmijeniStrucnuSpremu";
            this.Text = "Izmjena stručne spreme";
            this.Load += new System.EventHandler(this.FrmIzmijeniStrucnuSpremu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStrucneSpreme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOznakaStrucneSpreme;
        private System.Windows.Forms.TextBox txtNazivStrucneSpreme;
        private System.Windows.Forms.DataGridView dgvStrucneSpreme;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label label3;
    }
}