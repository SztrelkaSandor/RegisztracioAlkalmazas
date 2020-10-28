namespace RegisztracioAlkalmazas
{
    partial class Form1
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
            this.lbl_nev = new System.Windows.Forms.Label();
            this.lbl_szuletesi_datum = new System.Windows.Forms.Label();
            this.lbl_hobbi = new System.Windows.Forms.Label();
            this.lbl_nem = new System.Windows.Forms.Label();
            this.lbl_uj_hobbi = new System.Windows.Forms.Label();
            this.btn_mentes = new System.Windows.Forms.Button();
            this.btn_betoltes = new System.Windows.Forms.Button();
            this.btn_hozzaad = new System.Windows.Forms.Button();
            this.rdb_ferfi = new System.Windows.Forms.RadioButton();
            this.rdb_no = new System.Windows.Forms.RadioButton();
            this.tb_nev = new System.Windows.Forms.TextBox();
            this.tb_uj_hobbi = new System.Windows.Forms.TextBox();
            this.lib_hobbi = new System.Windows.Forms.ListBox();
            this.dtp_szuletesi_datum = new System.Windows.Forms.DateTimePicker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lbl_nev
            // 
            this.lbl_nev.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_nev.Location = new System.Drawing.Point(12, 19);
            this.lbl_nev.Name = "lbl_nev";
            this.lbl_nev.Size = new System.Drawing.Size(178, 113);
            this.lbl_nev.TabIndex = 0;
            this.lbl_nev.Text = "Név:";
            // 
            // lbl_szuletesi_datum
            // 
            this.lbl_szuletesi_datum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_szuletesi_datum.Location = new System.Drawing.Point(12, 142);
            this.lbl_szuletesi_datum.Name = "lbl_szuletesi_datum";
            this.lbl_szuletesi_datum.Size = new System.Drawing.Size(448, 113);
            this.lbl_szuletesi_datum.TabIndex = 1;
            this.lbl_szuletesi_datum.Text = "Szül. Dátum:";
            // 
            // lbl_hobbi
            // 
            this.lbl_hobbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_hobbi.Location = new System.Drawing.Point(806, 19);
            this.lbl_hobbi.Name = "lbl_hobbi";
            this.lbl_hobbi.Size = new System.Drawing.Size(529, 113);
            this.lbl_hobbi.TabIndex = 2;
            this.lbl_hobbi.Text = "Kedvenc Hobbik:";
            // 
            // lbl_nem
            // 
            this.lbl_nem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_nem.Location = new System.Drawing.Point(12, 255);
            this.lbl_nem.Name = "lbl_nem";
            this.lbl_nem.Size = new System.Drawing.Size(325, 113);
            this.lbl_nem.TabIndex = 3;
            this.lbl_nem.Text = "Nem:";
            // 
            // lbl_uj_hobbi
            // 
            this.lbl_uj_hobbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_uj_hobbi.Location = new System.Drawing.Point(515, 438);
            this.lbl_uj_hobbi.Name = "lbl_uj_hobbi";
            this.lbl_uj_hobbi.Size = new System.Drawing.Size(334, 113);
            this.lbl_uj_hobbi.TabIndex = 4;
            this.lbl_uj_hobbi.Text = "Új Hobbi:";
            // 
            // btn_mentes
            // 
            this.btn_mentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_mentes.Location = new System.Drawing.Point(660, 643);
            this.btn_mentes.Name = "btn_mentes";
            this.btn_mentes.Size = new System.Drawing.Size(306, 95);
            this.btn_mentes.TabIndex = 5;
            this.btn_mentes.Text = "Mentés";
            this.btn_mentes.UseVisualStyleBackColor = true;
            this.btn_mentes.Click += new System.EventHandler(this.btn_mentes_Click);
            // 
            // btn_betoltes
            // 
            this.btn_betoltes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_betoltes.Location = new System.Drawing.Point(988, 643);
            this.btn_betoltes.Name = "btn_betoltes";
            this.btn_betoltes.Size = new System.Drawing.Size(306, 95);
            this.btn_betoltes.TabIndex = 6;
            this.btn_betoltes.Text = "Betöltés";
            this.btn_betoltes.UseVisualStyleBackColor = true;
            this.btn_betoltes.Click += new System.EventHandler(this.btn_betoltes_Click);
            // 
            // btn_hozzaad
            // 
            this.btn_hozzaad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_hozzaad.Location = new System.Drawing.Point(987, 524);
            this.btn_hozzaad.Name = "btn_hozzaad";
            this.btn_hozzaad.Size = new System.Drawing.Size(306, 95);
            this.btn_hozzaad.TabIndex = 7;
            this.btn_hozzaad.Text = "Hozzáad";
            this.btn_hozzaad.UseVisualStyleBackColor = true;
            this.btn_hozzaad.Click += new System.EventHandler(this.btn_hozzaad_Click);
            // 
            // rdb_ferfi
            // 
            this.rdb_ferfi.AutoSize = true;
            this.rdb_ferfi.Checked = true;
            this.rdb_ferfi.Location = new System.Drawing.Point(426, 283);
            this.rdb_ferfi.Name = "rdb_ferfi";
            this.rdb_ferfi.Size = new System.Drawing.Size(81, 41);
            this.rdb_ferfi.TabIndex = 8;
            this.rdb_ferfi.TabStop = true;
            this.rdb_ferfi.Text = "F";
            this.rdb_ferfi.UseVisualStyleBackColor = true;
            // 
            // rdb_no
            // 
            this.rdb_no.AutoSize = true;
            this.rdb_no.Location = new System.Drawing.Point(623, 283);
            this.rdb_no.Name = "rdb_no";
            this.rdb_no.Size = new System.Drawing.Size(85, 41);
            this.rdb_no.TabIndex = 9;
            this.rdb_no.Text = "N";
            this.rdb_no.UseVisualStyleBackColor = true;
            // 
            // tb_nev
            // 
            this.tb_nev.Location = new System.Drawing.Point(426, 37);
            this.tb_nev.Name = "tb_nev";
            this.tb_nev.Size = new System.Drawing.Size(282, 44);
            this.tb_nev.TabIndex = 10;
            // 
            // tb_uj_hobbi
            // 
            this.tb_uj_hobbi.Location = new System.Drawing.Point(886, 465);
            this.tb_uj_hobbi.Name = "tb_uj_hobbi";
            this.tb_uj_hobbi.Size = new System.Drawing.Size(408, 44);
            this.tb_uj_hobbi.TabIndex = 12;
            // 
            // lib_hobbi
            // 
            this.lib_hobbi.FormattingEnabled = true;
            this.lib_hobbi.ItemHeight = 37;
            this.lib_hobbi.Items.AddRange(new object[] {
            "Uszás",
            "Horgászat",
            "Futás"});
            this.lib_hobbi.Location = new System.Drawing.Point(886, 148);
            this.lib_hobbi.Name = "lib_hobbi";
            this.lib_hobbi.Size = new System.Drawing.Size(407, 263);
            this.lib_hobbi.TabIndex = 13;
            // 
            // dtp_szuletesi_datum
            // 
            this.dtp_szuletesi_datum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_szuletesi_datum.Location = new System.Drawing.Point(426, 166);
            this.dtp_szuletesi_datum.Name = "dtp_szuletesi_datum";
            this.dtp_szuletesi_datum.Size = new System.Drawing.Size(282, 44);
            this.dtp_szuletesi_datum.TabIndex = 14;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "text file|*.txt|All files|*.*";
            this.saveFileDialog1.OverwritePrompt = false;
            this.saveFileDialog1.SupportMultiDottedExtensions = true;
            this.saveFileDialog1.Tag = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "text file|*.txt|All files|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 762);
            this.Controls.Add(this.dtp_szuletesi_datum);
            this.Controls.Add(this.lib_hobbi);
            this.Controls.Add(this.tb_uj_hobbi);
            this.Controls.Add(this.tb_nev);
            this.Controls.Add(this.rdb_no);
            this.Controls.Add(this.rdb_ferfi);
            this.Controls.Add(this.btn_hozzaad);
            this.Controls.Add(this.btn_betoltes);
            this.Controls.Add(this.btn_mentes);
            this.Controls.Add(this.lbl_uj_hobbi);
            this.Controls.Add(this.lbl_hobbi);
            this.Controls.Add(this.lbl_szuletesi_datum);
            this.Controls.Add(this.lbl_nev);
            this.Controls.Add(this.lbl_nem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nev;
        private System.Windows.Forms.Label lbl_szuletesi_datum;
        private System.Windows.Forms.Label lbl_hobbi;
        private System.Windows.Forms.Label lbl_nem;
        private System.Windows.Forms.Label lbl_uj_hobbi;
        private System.Windows.Forms.Button btn_mentes;
        private System.Windows.Forms.Button btn_betoltes;
        private System.Windows.Forms.Button btn_hozzaad;
        private System.Windows.Forms.RadioButton rdb_ferfi;
        private System.Windows.Forms.RadioButton rdb_no;
        private System.Windows.Forms.TextBox tb_nev;
        private System.Windows.Forms.TextBox tb_uj_hobbi;
        private System.Windows.Forms.ListBox lib_hobbi;
        private System.Windows.Forms.DateTimePicker dtp_szuletesi_datum;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

