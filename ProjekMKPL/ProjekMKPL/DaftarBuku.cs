using MySql.Data.MySqlClient;
using System;
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
    public partial class DaftarBuku : Form
    {

        tambahBuku formTambahBuku;
        EditBuku formEditBuku;

        public DaftarBuku()
        {
            InitializeComponent();
            this.refresh_data_buku();
         
        }

        public void refresh_data_buku()
        {
            MySqlConnection conn = this.makeDatabaseConnection();

            try
            {
                conn.Open();

                String sql =
                    "SELECT * " +
                    "FROM buku ";

                MySqlCommand command = new MySqlCommand(sql, conn);

                MySqlDataReader reader = command.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                this.dgvBuku.DataSource = dt;

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


        private void btTambahBuku_Click(object sender, EventArgs e)
        {
            formTambahBuku = new tambahBuku(this);
            formTambahBuku.Show();
            this.Hide();
        }

        private void btEditBuku_Click(object sender, EventArgs e)
        {
            if (dgvBuku.CurrentRow != null)
            {
                String id = this.dgvBuku.SelectedRows[0].Cells[0].Value.ToString();

                formEditBuku = new EditBuku(this, id);
                formEditBuku.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("pilih buku yang akan diupdate");
            }

        }

        private void btHapusBuku_Click(object sender, EventArgs e)
        {
            if (dgvBuku.CurrentRow != null)
            {
                String id = this.dgvBuku.SelectedRows[0].Cells[0].Value.ToString();
                DialogResult dr = MessageBox.Show("Hapus data buku dengan id " + id, "Info", MessageBoxButtons.YesNo);


                if (dr == DialogResult.Yes)
                {
                    MySqlConnection conn = this.makeDatabaseConnection();

                    try
                    {
                        conn.Open();

                        String sql = "DELETE FROM buku WHERE ID_BUKU = " + id;

                        MySqlCommand command = new MySqlCommand(sql, conn);

                        int affectedRows = command.ExecuteNonQuery();//nonquery karena tidak mengambil data tapi mengirimkan data

                        conn.Close();

                        this.refresh_data_buku();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }


            }
            else
            {
                MessageBox.Show("pilih buku yang akan dihapus");
            }

        }
    }
}
