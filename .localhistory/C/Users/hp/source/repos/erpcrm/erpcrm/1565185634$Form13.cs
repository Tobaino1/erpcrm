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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("field can't be empty, please enter a value!");
                return;

            }

            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("field can't be empty, please enter a value!");
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
            MySqlCommand cmd = new MySqlCommand("UPDATE `customer` SET `cus_name`= '" + textBox1.Text + "',`phone_no`= '" + textBox2.Text + "',`address`= '" + textBox3.Text + "',`email`= '" + textBox4.Text + "' WHERE phone_no = '" + textBox2.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("record has been successfully updated");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Phone number field can't be empty, please enter the customer phone no & click delete button in the order to delete the record!");
                return;

            }

            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=erp_crm");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `customer` WHERE phone_no = '" + textBox2.Text + "'", con);

            cmd.ExecuteNonQuery();
            MessageBox.Show("record has been successfully deleted");
            con.Close();
        }
    }
}
