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
    public partial class Form11 : Form
    {
        public Form11()
        {
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=erp_crm");
            con.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("select * from salesrep ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["fname"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["phone"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["address"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["username"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["password"].ToString();

            }

            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }
}
