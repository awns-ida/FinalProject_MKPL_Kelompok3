using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjekMKPL
{
    public partial class tambahAnggota : Form
    {
        public tambahAnggota()
        {
            InitializeComponent();
        }

        MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=perpus");

        private void buttonBatal_Click(object sender, EventArgs e)
        {

        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            conn.Open();
            String query = "insert into anggota(nama,nim,nohp,email,alamat,jurusan,fakultas) values('"+ this.textBoxNama.Text + "','" + this.textBoxNim.Text + "','" + this.textBoxNohp.Text + "','" + this.textBoxEmail.Text + "','" + this.textBoxAlamat.Text + "','" + this.textBoxJurusan.Text + "','" + this.textBoxFakultas.Text + "');";
            MySqlDataReader read;
            MySqlCommand cmd = new MySqlCommand(query, conn);
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                Home hm = new Home();
                hm.Show();
                this.Hide();
                MessageBox.Show("data tersimpan");
            }
            else
            {
                MessageBox.Show("data tidak tersimpan");
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSimpan_Click_1(object sender, EventArgs e)
        {

        }
    }
}
