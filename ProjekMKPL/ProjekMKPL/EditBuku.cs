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
    public partial class EditBuku : Form
    {

        public DaftarBuku formParent;
        private int id;
        public EditBuku()
        {
            InitializeComponent();
        }
    
        public EditBuku(DaftarBuku parent, String id)
        {
            InitializeComponent();
            this.formParent = parent;
            this.id = Convert.ToInt16(id);
            this.get_selected_data();
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

        public void get_selected_data()
        {
            MySqlConnection conn = this.makeDatabaseConnection();

            try
            {
                conn.Open();

                String sql = "SELECT * FROM buku WHERE ID_BUKU=@id";

                MySqlCommand command = new MySqlCommand(sql, conn);

                command.Parameters.AddWithValue("@id", id);

                MySqlDataReader reader = command.ExecuteReader();

                String judul = "", penerbit = "", pengarang = "", tahun_terbit = "", nomor_seri="", halaman="", deskripsi="";
                while (reader.Read())
                {
                    judul = reader[1].ToString();
                    penerbit = reader[2].ToString();
                    pengarang = reader[3].ToString();
                    tahun_terbit = reader[4].ToString();
                    nomor_seri = reader[5].ToString();
                    halaman = reader[6].ToString();
                    deskripsi = reader[7].ToString();
                }

                this.tbJudul.Text = judul;
                this.tbPenerbit.Text = penerbit;
                this.tbPengarang.Text = pengarang;
                this.tbTahunTerbit.Text = tahun_terbit;
                this.tbNomorSeri.Text = nomor_seri;
                this.tbHalaman.Text = halaman;
                this.rbDeskripsi.Text = deskripsi;
                
                conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btBatal_Click(object sender, EventArgs e)
        {
            this.Close();
            formParent.show_form();
        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Simpan perubahan?", "Info", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                MySqlConnection conn = this.makeDatabaseConnection();

                try
                {
                    conn.Open();

                    String sql = "UPDATE buku " +
                        "SET JUDUL = @judul, " +
                             "PENGARANG = @pengarang, " +
                             "PENERBIT = @penerbit, " +
                             "TAHUNTERBIT = @tahunterbit, " +
                             "NOMORSERI = @nomorseri, " +
                             "HALAMAN = @halaman, " +
                             "DESKRIPSI = @deskripsi, " +
                        "GAMBAR = @gambar " +
                        "WHERE ID_BUKU = @id";

                    MySqlCommand command = new MySqlCommand(sql, conn);

                    command.Parameters.AddWithValue("@judul", tbJudul.Text);
                    command.Parameters.AddWithValue("@pengarang", tbPengarang.Text);
                    command.Parameters.AddWithValue("@penerbit", tbPenerbit.Text);
                    command.Parameters.AddWithValue("@tahunterbit", tbTahunTerbit.Text);
                    command.Parameters.AddWithValue("@nomorseri", tbNomorSeri.Text);
                    command.Parameters.AddWithValue("@halaman", tbHalaman.Text);
                    command.Parameters.AddWithValue("@deskripsi", rbDeskripsi.Text);
                    command.Parameters.AddWithValue("@gambar", "buku.jpg");
                    command.Parameters.AddWithValue("@id", this.id);

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

        }
    }

}
