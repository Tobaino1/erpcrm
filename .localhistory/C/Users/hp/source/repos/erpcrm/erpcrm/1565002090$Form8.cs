using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace erpcrm
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Invoice no field can't be empty, please enter a value!");
                return;

            }

            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=erp_crm");
            con.Open();

            MySqlDataAdapter sda = new MySqlDataAdapter("select * from salesreg WHERE invoice_no = '" + textBox1.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["name_prd"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["desc"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["unit_price"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["prd_id"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["grand_total"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["invoice_no"].ToString();
                dataGridView1.Rows[n].Cells[6].Value = item["name_cus"].ToString();
                dataGridView1.Rows[n].Cells[7].Value = item["sales_rep"].ToString();
                dataGridView1.Rows[n].Cells[8].Value = item["submit"].ToString();

            }
            MessageBox.Show("click on print button");
            con.Close();
        }
    }
}
