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
        DaftarAnggota formParent;
        public tambahAnggota(DaftarAnggota parent)
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
        private void buttonSimpan_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home d = new Home();
            d.Show();
            this.Hide();
        }

        private void buttonSimpan_Click_1(object sender, EventArgs e)
        {
            if (this.textBoxNama.Text != "" && this.textBoxNim.Text != "" && this.textBoxEmail.Text != "" && this.textBoxNohp.Text != "" && this.textBoxJurusan.Text != "" && this.textBoxFakultas.Text != "" && this.textBoxAlamat.Text != "")
            {
                MySqlConnection conn = this.makeDatabaseConnection();

                try
                {
                    conn.Open();

                    String sql = "INSERT INTO anggota " +
                        "(NAMA, NIM, EMAIL, NOHP, JURUSAN, FAKULTAS, ALAMAT) VALUES " +
                        "(@nama, @nim, @email, @nohp, @jurusan, @fakultas, @alamat) ";

                    MySqlCommand command = new MySqlCommand(sql, conn);


                    command.Parameters.AddWithValue("@nama", this.textBoxNama.Text);
                    command.Parameters.AddWithValue("@nim", this.textBoxNim.Text);
                    command.Parameters.AddWithValue("@email", this.textBoxEmail.Text);
                    command.Parameters.AddWithValue("@nohp", this.textBoxNohp.Text);
                    command.Parameters.AddWithValue("@jurusan", this.textBoxJurusan.Text);
                    command.Parameters.AddWithValue("@fakultas", this.textBoxFakultas.Text);
                    command.Parameters.AddWithValue("@alamat", this.textBoxAlamat.Text);

                    int affectedRows = command.ExecuteNonQuery();//nonquery karena tidak mengambil data tapi mengirimkan data

                    conn.Close();

                    DialogResult d = MessageBox.Show("data berhasil disimpan", "", MessageBoxButtons.OK);
                    if (d == DialogResult.OK)
                    {
                        this.textBoxNama.Text = "";
                        this.textBoxNim.Text = "";
                        this.textBoxEmail.Text = "";
                        this.textBoxNohp.Text = "";
                        this.textBoxJurusan.Text = "";
                        this.textBoxFakultas.Text = "";
                        this.textBoxAlamat.Text = "";

                        this.Hide();
                        formParent.refresh_data_anggota();
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