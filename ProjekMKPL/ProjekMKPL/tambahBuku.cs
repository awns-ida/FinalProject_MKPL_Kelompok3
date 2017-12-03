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
    public partial class tambahBuku : Form
    {

        DaftarBuku formParent;
        public tambahBuku(DaftarBuku parent)
        {
            InitializeComponent();
            this.formParent = parent;
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


        private void btSimpan_Click(object sender, EventArgs e)
        {
            if (tbJudul.Text != "" && tbPengarang.Text != "" && tbPenerbit.Text !="" && tbTahunTerbit.Text !="" && tbNomorSeri.Text !="" && rbDeskripsi.Text!="")
            {
                MySqlConnection conn = this.makeDatabaseConnection();

                try
                {
                    conn.Open();

                    String sql = "INSERT INTO buku " +
                        "(JUDUL, PENGARANG, PENERBIT, TAHUNTERBIT, NOMORSERI, HALAMAN, DESKRIPSI, GAMBAR) VALUES " +
                        "(@judul, @pengarang, @penerbit, @tahunterbit, @nomorseri, @halaman, @deskripsi, @gambar) ";

                    MySqlCommand command = new MySqlCommand(sql, conn);


                    command.Parameters.AddWithValue("@judul", tbJudul.Text);
                    command.Parameters.AddWithValue("@pengarang", tbPengarang.Text);
                    command.Parameters.AddWithValue("@penerbit", tbPenerbit.Text);
                    command.Parameters.AddWithValue("@tahunterbit", tbTahunTerbit.Text);
                    command.Parameters.AddWithValue("@nomorseri", tbNomorSeri.Text);
                    command.Parameters.AddWithValue("@halaman", tbHalaman.Text);
                    command.Parameters.AddWithValue("@deskripsi", rbDeskripsi.Text);
                    command.Parameters.AddWithValue("@gambar", "buku.jpg");

                    int affectedRows = command.ExecuteNonQuery();//nonquery karena tidak mengambil data tapi mengirimkan data

                    conn.Close();

                    DialogResult d = MessageBox.Show("data berhasil disimpan", "", MessageBoxButtons.OK);
                    if (d == DialogResult.OK)
                    {
                        tbJudul.Text = "";
                        tbPengarang.Text = "";
                        tbNomorSeri.Text = "";
                        tbPenerbit.Text = "";
                        tbHalaman.Text = "";
                        rbDeskripsi.Text = "";
                        tbTahunTerbit.Text = "";

                        this.Hide();
                        formParent.refresh_data_buku();
                        formParent.show_form();
                    }

                
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Semua field harus diisi");
            }
        }
    }

}