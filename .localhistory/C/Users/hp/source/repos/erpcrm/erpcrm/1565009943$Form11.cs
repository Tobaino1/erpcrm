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
        
            InitializeComponent();

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
            MySqlCommand cmd = new MySqlCommand("INSERT INTO salesrep (`fname`, `phone`, `address`, `username`, `password`) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("record has been succesfully inserted in the database");
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Phone number field can't be empty, please enter the sales rep phone no & click delete button in the order to delete the record!");
                return;

            }

            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=erp_crm");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `salesrep` WHERE phone = '" + textBox2.Text + "'", con);

            cmd.ExecuteNonQuery();
            MessageBox.Show("record has been successfully deleted");
            con.Close();
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

            if (textBox5.Text == string.Empty)
            {
                MessageBox.Show("field can't be empty, please enter a value!");
                return;

            }


            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=erp_crm");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `salesrep` SET `fname`= '" + textBox1.Text + "',`phone`= '" + textBox2.Text + "',`address`= '" + textBox3.Text + "',`username`= '" + textBox4.Text + "',`password`= '" + textBox5.Text + "' WHERE phone = '" + textBox2.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("sales rep's record has been successfully updated");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox4.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Form11().Show();
            this.Hide();

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Applicaation.Exit();

        }
    }
}
