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

    //evevtshow-ser_textchang-cellclick
    public partial class DataUser : Form
    {
        newdata newd;
        public DataUser()
        {
            InitializeComponent();
            newd = new newdata(this);
        }
        public void Display()
        {
            Db.DisplayAndSearch("SELECT ID , Name, Reg, Class, Section FROM student_table", dataGridView);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DataUser_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            newd.Clear();
            newd.ShowDialog();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                ///edit
                newd.Clear();
                newd.id = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                newd.name = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                newd.reg = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                newd.@class = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                newd.section = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                newd.UpdateInfo();
                newd.ShowDialog();

                return;
            }
            if (e.ColumnIndex == 1)
            {
                //delect
                if (MessageBox.Show("Are you want to delect?", "information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Db.DeleteStudent(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }

            }
            return;
        }
    }
}
