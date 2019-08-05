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

namespace erpcrm
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form7().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Month field can't be empty, please enter a value!");
                return;

            }


            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=erp_crm");
            con.Open();

            MySqlDataAdapter sda = new MySqlDataAdapter("select * from salesreg WHERE month = '" + textBox1.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["name_prd"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["desc"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["name_cus"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["sales_rep"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["unit_price"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["prd_id"].ToString();
                dataGridView1.Rows[n].Cells[6].Value = item["month"].ToString();
                dataGridView1.Rows[n].Cells[7].Value = item["submit"].ToString();

            }
            MessageBox.Show("Your request was succesfully processed, click on ok to see the report");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
