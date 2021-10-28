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
    public partial class datahei : Form
    {
        public datahei()
        {
            InitializeComponent();
        }

        public void Display()
        {

            Db DB = new Db();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM login_user ", Db.GetConnection());
            
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            label1.Text = table.Rows[0]["user"].ToString();
            label2.Text = table.Rows[0]["pas"].ToString();


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void datahei_Shown(object sender, EventArgs e)
        {
            Display();
        }
    }
}
