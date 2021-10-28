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


namespace WindowsFormsApp_testone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Db DB = new Db();
            String user = textBox1.Text;
            String pas = textBox2.Text;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM login_user WHERE user = @user and pas = @pas", Db.GetConnection());
            cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = user;
            cmd.Parameters.Add("@pas", MySqlDbType.VarChar).Value = pas;
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                //MessageBox.Show("yes");
                this.Hide();
                main_info form = new main_info();
                form.Show();
            }
            else
            {
                MessageBox.Show("no");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
