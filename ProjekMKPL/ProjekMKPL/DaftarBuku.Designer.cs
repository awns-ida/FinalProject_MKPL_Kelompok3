namespace ProjekMKPL
{
    partial class DaftarBuku
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
            this.dgvBuku = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btTambahBuku = new System.Windows.Forms.Button();
            this.btEditBuku = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuku)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBuku
            // 
            this.dgvBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuku.Location = new System.Drawing.Point(12, 70);
            this.dgvBuku.Name = "dgvBuku";
            this.dgvBuku.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuku.Size = new System.Drawing.Size(516, 273);
            this.dgvBuku.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(567, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hapus Buku";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btTambahBuku
            // 
            this.btTambahBuku.Location = new System.Drawing.Point(567, 110);
            this.btTambahBuku.Name = "btTambahBuku";
            this.btTambahBuku.Size = new System.Drawing.Size(85, 23);
            this.btTambahBuku.TabIndex = 2;
            this.btTambahBuku.Text = "Tambah Buku";
            this.btTambahBuku.UseVisualStyleBackColor = true;
            this.btTambahBuku.Click += new System.EventHandler(this.btTambahBuku_Click);
            // 
            // btEditBuku
            // 
            this.btEditBuku.Location = new System.Drawing.Point(567, 168);
            this.btEditBuku.Name = "btEditBuku";
            this.btEditBuku.Size = new System.Drawing.Size(85, 23);
            this.btEditBuku.TabIndex = 3;
            this.btEditBuku.Text = "Edit Buku";
            this.btEditBuku.UseVisualStyleBackColor = true;
            this.btEditBuku.Click += new System.EventHandler(this.btEditBuku_Click);
            // 
            // DaftarBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 373);
            this.Controls.Add(this.btEditBuku);
            this.Controls.Add(this.btTambahBuku);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvBuku);
            this.Name = "DaftarBuku";
            this.Text = "Daftar Buku";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuku)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuku;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btTambahBuku;
        private System.Windows.Forms.Button btEditBuku;
    }
}