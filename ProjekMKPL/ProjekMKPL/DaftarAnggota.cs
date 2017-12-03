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
    public partial class DaftarAnggota : Form
    {
        public DaftarAnggota()
        {
            InitializeComponent();
            this.refresh_data_anggota();

        }

        public void refresh_data_anggota()
        {
            MySqlConnection conn = this.makeDatabaseConnection();

            try
            {
                conn.Open();

                String sql =
                    "SELECT * " +
                    "FROM anggota ";

                MySqlCommand command = new MySqlCommand(sql, conn);

                MySqlDataReader reader = command.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                
                this.dataGridViewAnggota.DataSource = dt;
                conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void show_form()
        {
            this.Show();
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

        private void buttonTambahAnggota_Click_1(object sender, EventArgs e)
        {
            tambahAnggota formTambahAnggota = new tambahAnggota(this);
            formTambahAnggota.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home d = new Home();
            d.Show();
            this.Hide();
        }
    }
}
