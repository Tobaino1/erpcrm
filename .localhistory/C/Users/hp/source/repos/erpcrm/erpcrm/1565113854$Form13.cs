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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }



        private void Form13_Load(object sender, EventArgs e)
        {
            label1.Text = Form1.SetValueForText1;
            label2.Text = Form1.SetValueForText2;
            label3.Text = Form1.SetValueForText3;
        }
    }
}
