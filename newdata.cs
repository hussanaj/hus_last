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
    public partial class newdata : Form
    {

        private readonly DataUser _parent;
        public string id, name, reg, @class, section;
        public newdata(DataUser parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {

            if (textname.Text.Trim().Length < 3)
            {
                MessageBox.Show("student name is Empty (> 3). ");
                return;
            }

            if (textage.Text.Trim().Length < 1)
            {
                MessageBox.Show("student reg is Empty (> 1). ");
                return;
            }

            if (textwi.Text.Trim().Length == 0)
            {
                MessageBox.Show("student class is Empty (> 1). ");
                return;
            }

            if (texthi.Text.Trim().Length == 0)
            {
                MessageBox.Show("student section is Empty (> 1). ");
                return;
            }


            if (buttonsave.Text == "บันทึก")
            {

                double bmi,h,w;
                h = double.Parse(texthi.Text);
                w = double.Parse(textwi.Text);
                bmi = w * (h * h);
                //label6.Text = bmi.ToString();
                Db DB = new Db();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO health VALUES (NULL ,@bmi)", Db.GetConnection());
                cmd.Parameters.Add("@bmi", MySqlDbType.Double).Value = bmi;
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete Success.", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Student not Delete" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }



                data std = new data(textname.Text.Trim(), textage.Text.Trim(), textwi.Text.Trim(), texthi.Text.Trim());
                Db.AddStudent(std);
               
                Clear();
            }

            if (buttonsave.Text == "Update")
            {
                data std = new data(textname.Text.Trim(), textage.Text.Trim(), textwi.Text.Trim(), texthi.Text.Trim());
                Db.UpdateStudent(std, id);
            }
            _parent.Display();
        }

        public void UpdateInfo()
        {
            label5.Text = "แก้ไขข้อมูล";
            buttonsave.Text = "Update";
            textname.Text = name;
            textage.Text = reg;
            textwi.Text = @class;
            texthi.Text = section;
        }
        public void Clear()
        {
            textname.Text = textage.Text = textwi.Text = texthi.Text = string.Empty;

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
