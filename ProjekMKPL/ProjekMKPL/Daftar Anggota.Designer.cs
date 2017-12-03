namespace ProjekMKPL
{
    partial class Daftar_Anggota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Daftar_Anggota));
            this.dataGridViewAnggota = new System.Windows.Forms.DataGridView();
            this.buttonTambahAnggota = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnggota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAnggota
            // 
            this.dataGridViewAnggota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnggota.Location = new System.Drawing.Point(22, 76);
            this.dataGridViewAnggota.Name = "dataGridViewAnggota";
            this.dataGridViewAnggota.Size = new System.Drawing.Size(463, 240);
            this.dataGridViewAnggota.TabIndex = 0;
            this.dataGridViewAnggota.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAnggota_CellContentClick);
            // 
            // buttonTambahAnggota
            // 
            this.buttonTambahAnggota.Location = new System.Drawing.Point(513, 102);
            this.buttonTambahAnggota.Name = "buttonTambahAnggota";
            this.buttonTambahAnggota.Size = new System.Drawing.Size(105, 23);
            this.buttonTambahAnggota.TabIndex = 1;
            this.buttonTambahAnggota.Text = "Tambah Anggota ";
            this.buttonTambahAnggota.UseVisualStyleBackColor = true;
            this.buttonTambahAnggota.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(33, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 34);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Daftar_Anggota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(647, 345);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonTambahAnggota);
            this.Controls.Add(this.dataGridViewAnggota);
            this.Name = "Daftar_Anggota";
            this.Text = "Daftar Anggota";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnggota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAnggota;
        private System.Windows.Forms.Button buttonTambahAnggota;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}