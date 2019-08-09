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
    public partial class Form12 : Form
    {
        
        public Form12()
        {
            
        InitializeComponent();
        }


        

        private void button1_Click(object sender, EventArgs e)
        {
            SetValueForText1 = textBox1.Text;
            SetValueForText2 = textBox2.Text;
            SetValueForText3 = textBox3.Text;

            new Form13().Show();
            this.Hide();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";


    }
}

