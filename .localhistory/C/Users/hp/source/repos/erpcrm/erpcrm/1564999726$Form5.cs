using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace erpcrm
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=erp_crm");
            con.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("select * from inventory ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["name"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["desc"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["price"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["prd_id"].ToString();


            }

            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("field can't be empty, please enter a value!");
                return;

            }


            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("field can't be empty, please enter a value!");
                return;

            }

            if (textBox3.Text == string.Empty)
            {
                MessageBox.Show("field can't be empty, please enter a value!");
                return;

            }
            if (textBox4.Text == string.Empty)
            {
                MessageBox.Show("field can't be empty, please enter a value!");
                return;

            }

            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=erp_crm");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO inventory (`name`, `desc`, `price`, `prd_id`) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "', '" + textBox4.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("record has been succesfully inserted in the database");
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == string.Empty)
            {
                MessageBox.Show("Product Id field can't be empty, please enter a value!");
                return;

            }


            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=erp_crm");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `inventory` WHERE prd_id = '" + textBox4.Text + "'", con);

            cmd.ExecuteNonQuery();
            MessageBox.Show("record has been successfully deleted");
            con.Close();
        }
    }
    }
}
