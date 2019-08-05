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

        }
    }
}
