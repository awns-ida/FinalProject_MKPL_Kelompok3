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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=perpus");

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            String query = "SELECT * FROM admin WHERE USERNAME='"+tbUsername.Text+"' AND PASSWORD='"+textBox2.Text+"';";
            MySqlDataReader read;
            MySqlCommand cmd = new MySqlCommand(query, conn);
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                Home hm = new Home();
                hm.Show();
                this.Hide();
               
            }
            else
            {
                MessageBox.Show("login gagal");
            }
            conn.Close();


        }
    }
}
