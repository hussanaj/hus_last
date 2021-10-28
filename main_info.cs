using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_testone
{
    public partial class main_info : Form
    {
        public main_info()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataUser form = new DataUser();
            form.Show();
        }

        private void main_info_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            datahei form = new datahei();
            form.Show();
        }
    }
}
