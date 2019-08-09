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
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=erp_crm");
        int i;

        public static string SetValueForText2 { get; internal set; }

        public Form1()
        {
            InitializeComponent();
        }

      

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void Button4_Click(object sender, EventArgs e)
        {
            Form2 myform = new Form2();
            this.Hide();
            myform.Show();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
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
            MySqlCommand cmd = new MySqlCommand("select * from user WHERE username = '" + textBox1.Text + "' AND password = '" + textBox2.Text + "'", con);
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
                Form2 myform = new Form2();
                this.Hide();
                myform.Show();
            }
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            new Form9().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", "http://www.sparklegrid.tech");

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
