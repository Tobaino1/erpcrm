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
    public partial class Form9 : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=erp_crm");
        int i;

        public Form9()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("field can't be empty, please enter a value");
                return;
            }
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("field can't be empty, please enter a value");
                return;
            }

            i = 0;
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from salesrep WHERE username = '" + textBox1.Text + "' AND password = '" + textBox2.Text + "'", con);
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0)

            {
                MessageBox.Show("wrong user login details, please try again!");
            }
            else
            {
                MessageBox.Show("Correct User Login details!");
                Form10 myform = new Form10();
                this.Hide();
                myform.Show();
            }
            con.Close();

        }
    }
}
