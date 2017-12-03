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
    public partial class Daftar_Anggota : Form
    {
        public Daftar_Anggota()
        {
            InitializeComponent();

            MySqlConnection conn = this.makeDatabaseConnection();
        }

        public MySqlConnection makeDatabaseConnection()
        {
            MySqlConnection connection = new MySqlConnection();
            String connString =
                "Server=127.0.0.1;" +
                "uid=root;" +
                "pwd=;" +
                "database=perpus";

            connection.ConnectionString = connString;

            return connection;
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

        private void dataGridViewAnggota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
