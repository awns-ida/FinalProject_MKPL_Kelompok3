namespace ProjekMKPL
{
    partial class tambahBuku
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
            this.btBatal = new System.Windows.Forms.Button();
            this.btSimpan = new System.Windows.Forms.Button();
            this.tbNomorSeri = new System.Windows.Forms.TextBox();
            this.tbTahunTerbit = new System.Windows.Forms.TextBox();
            this.tbPengarang = new System.Windows.Forms.TextBox();
            this.tbPenerbit = new System.Windows.Forms.TextBox();
            this.tbJudul = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbDeskripsi = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btBatal
            // 
            this.btBatal.Location = new System.Drawing.Point(163, 277);
            this.btBatal.Name = "btBatal";
            this.btBatal.Size = new System.Drawing.Size(75, 23);
            this.btBatal.TabIndex = 31;
            this.btBatal.Text = "Batal";
            this.btBatal.UseVisualStyleBackColor = true;
            this.btBatal.Click += new System.EventHandler(this.button2_Click);
            // 
            // btSimpan
            // 
            this.btSimpan.Location = new System.Drawing.Point(333, 277);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(75, 23);
            this.btSimpan.TabIndex = 30;
            this.btSimpan.Text = "Simpan";
            this.btSimpan.UseVisualStyleBackColor = true;
            // 
            // tbNomorSeri
            // 
            this.tbNomorSeri.Location = new System.Drawing.Point(163, 155);
            this.tbNomorSeri.Name = "tbNomorSeri";
            this.tbNomorSeri.Size = new System.Drawing.Size(245, 20);
            this.tbNomorSeri.TabIndex = 27;
            // 
            // tbTahunTerbit
            // 
            this.tbTahunTerbit.Location = new System.Drawing.Point(163, 126);
            this.tbTahunTerbit.Name = "tbTahunTerbit";
            this.tbTahunTerbit.Size = new System.Drawing.Size(245, 20);
            this.tbTahunTerbit.TabIndex = 26;
            // 
            // tbPengarang
            // 
            this.tbPengarang.Location = new System.Drawing.Point(163, 97);
            this.tbPengarang.Name = "tbPengarang";
            this.tbPengarang.Size = new System.Drawing.Size(245, 20);
            this.tbPengarang.TabIndex = 25;
            // 
            // tbPenerbit
            // 
            this.tbPenerbit.Location = new System.Drawing.Point(163, 66);
            this.tbPenerbit.Name = "tbPenerbit";
            this.tbPenerbit.Size = new System.Drawing.Size(245, 20);
            this.tbPenerbit.TabIndex = 24;
            // 
            // tbJudul
            // 
            this.tbJudul.Location = new System.Drawing.Point(163, 36);
            this.tbJudul.Name = "tbJudul";
            this.tbJudul.Size = new System.Drawing.Size(245, 20);
            this.tbJudul.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Deskripsi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nomor Seri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tahun Terbit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Pengarang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Penerbit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Judul";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rbDeskripsi
            // 
            this.rbDeskripsi.Location = new System.Drawing.Point(163, 190);
            this.rbDeskripsi.Name = "rbDeskripsi";
            this.rbDeskripsi.Size = new System.Drawing.Size(245, 73);
            this.rbDeskripsi.TabIndex = 32;
            this.rbDeskripsi.Text = "";
            // 
            // tambahBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 345);
            this.Controls.Add(this.rbDeskripsi);
            this.Controls.Add(this.btBatal);
            this.Controls.Add(this.btSimpan);
            this.Controls.Add(this.tbNomorSeri);
            this.Controls.Add(this.tbTahunTerbit);
            this.Controls.Add(this.tbPengarang);
            this.Controls.Add(this.tbPenerbit);
            this.Controls.Add(this.tbJudul);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "tambahBuku";
            this.Text = "tambahBuku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBatal;
        private System.Windows.Forms.Button btSimpan;
        private System.Windows.Forms.TextBox tbNomorSeri;
        private System.Windows.Forms.TextBox tbTahunTerbit;
        private System.Windows.Forms.TextBox tbPengarang;
        private System.Windows.Forms.TextBox tbPenerbit;
        private System.Windows.Forms.TextBox tbJudul;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rbDeskripsi;
    }
}