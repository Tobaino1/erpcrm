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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you don't  have access to the REPORT FORM, contact the Admin or your software developer");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you don't  have access to the INVENTORY FORM, contact the Admin or your software developer");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form6().Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Googlechrome", "https://sparklegrid.tech/");

        }
    }
}
