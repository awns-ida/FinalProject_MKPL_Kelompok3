﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekMKPL
{
    public partial class Daftar_Anggota : Form
    {
        public Daftar_Anggota()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tambahAnggota tang = new tambahAnggota();
            tang.Show();
            this.Hide();
        }
    }
}
