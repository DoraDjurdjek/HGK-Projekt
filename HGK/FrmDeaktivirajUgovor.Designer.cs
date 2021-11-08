namespace HGK
{
    partial class FrmDeaktivirajUgovor
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
            this.dgvUgovori = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVrati = new System.Windows.Forms.Button();
            this.btnFilterSubjekt = new System.Windows.Forms.Button();
            this.btnFilterBrojUgovora = new System.Windows.Forms.Button();
            this.btnFilterAgent = new System.Windows.Forms.Button();
            this.cmbFilterSubjekt = new System.Windows.Forms.ComboBox();
            this.cmbFilterBrUgovor = new System.Windows.Forms.ComboBox();
            this.cmbFilterAgent = new System.Windows.Forms.ComboBox();
            this.dtpRaskidaUgovora = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeaktiviraj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUgovori)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUgovori
            // 
            this.dgvUgovori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUgovori.Location = new System.Drawing.Point(12, 45);
            this.dgvUgovori.Name = "dgvUgovori";
            this.dgvUgovori.RowTemplate.Height = 24;
            this.dgvUgovori.Size = new System.Drawing.Size(726, 150);
            this.dgvUgovori.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVrati);
            this.groupBox1.Controls.Add(this.btnFilterSubjekt);
            this.groupBox1.Controls.Add(this.btnFilterBrojUgovora);
            this.groupBox1.Controls.Add(this.btnFilterAgent);
            this.groupBox1.Controls.Add(this.cmbFilterSubjekt);
            this.groupBox1.Controls.Add(this.cmbFilterBrUgovor);
            this.groupBox1.Controls.Add(this.cmbFilterAgent);
            this.groupBox1.Location = new System.Drawing.Point(12, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 227);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtriranje";
            // 
            // btnVrati
            // 
            this.btnVrati.Location = new System.Drawing.Point(76, 190);
            this.btnVrati.Name = "btnVrati";
            this.btnVrati.Size = new System.Drawing.Size(187, 31);
            this.btnVrati.TabIndex = 14;
            this.btnVrati.Text = "Vrati početnu tablicu";
            this.btnVrati.UseVisualStyleBackColor = true;
            this.btnVrati.Click += new System.EventHandler(this.btnVrati_Click_1);
            // 
            // btnFilterSubjekt
            // 
            this.btnFilterSubjekt.Location = new System.Drawing.Point(192, 134);
            this.btnFilterSubjekt.Name = "btnFilterSubjekt";
            this.btnFilterSubjekt.Size = new System.Drawing.Size(135, 46);
            this.btnFilterSubjekt.TabIndex = 5;
            this.btnFilterSubjekt.Text = "Prema poslovnom subjektu";
            this.btnFilterSubjekt.UseVisualStyleBackColor = true;
            this.btnFilterSubjekt.Click += new System.EventHandler(this.btnFilterSubjekt_Click_1);
            // 
            // btnFilterBrojUgovora
            // 
            this.btnFilterBrojUgovora.Location = new System.Drawing.Point(192, 80);
            this.btnFilterBrojUgovora.Name = "btnFilterBrojUgovora";
            this.btnFilterBrojUgovora.Size = new System.Drawing.Size(135, 44);
            this.btnFilterBrojUgovora.TabIndex = 4;
            this.btnFilterBrojUgovora.Text = "Prema broju ugovora";
            this.btnFilterBrojUgovora.UseVisualStyleBackColor = true;
            this.btnFilterBrojUgovora.Click += new System.EventHandler(this.btnFilterBrojUgovora_Click);
            // 
            // btnFilterAgent
            // 
            this.btnFilterAgent.Location = new System.Drawing.Point(192, 26);
            this.btnFilterAgent.Name = "btnFilterAgent";
            this.btnFilterAgent.Size = new System.Drawing.Size(135, 44);
            this.btnFilterAgent.TabIndex = 3;
            this.btnFilterAgent.Text = "Prema agentu";
            this.btnFilterAgent.UseVisualStyleBackColor = true;
            this.btnFilterAgent.Click += new System.EventHandler(this.btnFilterAgent_Click_1);
            // 
            // cmbFilterSubjekt
            // 
            this.cmbFilterSubjekt.FormattingEnabled = true;
            this.cmbFilterSubjekt.Location = new System.Drawing.Point(6, 134);
            this.cmbFilterSubjekt.Name = "cmbFilterSubjekt";
            this.cmbFilterSubjekt.Size = new System.Drawing.Size(180, 24);
            this.cmbFilterSubjekt.TabIndex = 2;
            // 
            // cmbFilterBrUgovor
            // 
            this.cmbFilterBrUgovor.FormattingEnabled = true;
            this.cmbFilterBrUgovor.Location = new System.Drawing.Point(6, 80);
            this.cmbFilterBrUgovor.Name = "cmbFilterBrUgovor";
            this.cmbFilterBrUgovor.Size = new System.Drawing.Size(180, 24);
            this.cmbFilterBrUgovor.TabIndex = 1;
            // 
            // cmbFilterAgent
            // 
            this.cmbFilterAgent.FormattingEnabled = true;
            this.cmbFilterAgent.Location = new System.Drawing.Point(6, 26);
            this.cmbFilterAgent.Name = "cmbFilterAgent";
            this.cmbFilterAgent.Size = new System.Drawing.Size(180, 24);
            this.cmbFilterAgent.TabIndex = 0;
            // 
            // dtpRaskidaUgovora
            // 
            this.dtpRaskidaUgovora.Location = new System.Drawing.Point(538, 230);
            this.dtpRaskidaUgovora.Name = "dtpRaskidaUgovora";
            this.dtpRaskidaUgovora.Size = new System.Drawing.Size(200, 22);
            this.dtpRaskidaUgovora.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Datum raskida ugovora";
            // 
            // btnDeaktiviraj
            // 
            this.btnDeaktiviraj.Location = new System.Drawing.Point(538, 268);
            this.btnDeaktiviraj.Name = "btnDeaktiviraj";
            this.btnDeaktiviraj.Size = new System.Drawing.Size(101, 38);
            this.btnDeaktiviraj.TabIndex = 13;
            this.btnDeaktiviraj.Text = "Deaktiviraj";
            this.btnDeaktiviraj.UseVisualStyleBackColor = true;
            this.btnDeaktiviraj.Click += new System.EventHandler(this.btnDeaktiviraj_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Popis ugovora:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(641, 268);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(101, 38);
            this.btnOdustani.TabIndex = 15;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // FrmDeaktivirajUgovor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 450);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeaktiviraj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpRaskidaUgovora);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvUgovori);
            this.Name = "FrmDeaktivirajUgovor";
            this.Text = "Deaktivacija ugovora";
            this.Load += new System.EventHandler(this.FrmDeaktivirajUgovor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUgovori)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUgovori;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFilterSubjekt;
        private System.Windows.Forms.Button btnFilterBrojUgovora;
        private System.Windows.Forms.Button btnFilterAgent;
        private System.Windows.Forms.ComboBox cmbFilterSubjekt;
        private System.Windows.Forms.ComboBox cmbFilterBrUgovor;
        private System.Windows.Forms.ComboBox cmbFilterAgent;
        private System.Windows.Forms.DateTimePicker dtpRaskidaUgovora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeaktiviraj;
        private System.Windows.Forms.Button btnVrati;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOdustani;
    }
}