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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //total cal
            int a, b, c, d, ee, f, g, h, i, j, k, l, m, n, o;
            if (Int32.TryParse(textBox3.Text, out a) && Int32.TryParse(textBox4.Text, out b))
                textBox5.Text = (a * b).ToString();

            if (Int32.TryParse(textBox15.Text, out c) && Int32.TryParse(textBox19.Text, out d))
                textBox23.Text = (c * d).ToString();

            if (Int32.TryParse(textBox16.Text, out ee) && Int32.TryParse(textBox20.Text, out f))
                textBox24.Text = (ee * f).ToString();

            if (Int32.TryParse(textBox17.Text, out g) && Int32.TryParse(textBox21.Text, out h))
                textBox25.Text = (g * h).ToString();

            if (Int32.TryParse(textBox18.Text, out i) && Int32.TryParse(textBox22.Text, out j))
                textBox26.Text = (i * j).ToString();


            //grand total cal
            if (Int32.TryParse(textBox5.Text, out k) && Int32.TryParse(textBox23.Text, out l) && (Int32.TryParse(textBox24.Text, out m) && Int32.TryParse(textBox25.Text, out n) && Int32.TryParse(textBox26.Text, out o)))
                textBox31.Text = (k + l + m + n + o).ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox21.Clear();
            textBox22.Clear();
            textBox21.Clear();
            textBox22.Clear();
            textBox23.Clear();
            textBox24.Clear();
            textBox25.Clear();
            textBox26.Clear();
            textBox27.Clear();
            textBox28.Clear();
            textBox29.Clear();
            textBox30.Clear();
            textBox31.Clear();
            textBox32.Clear();
            textBox33.Clear();
            textBox34.Clear();
            textBox35.Clear();
        }
    }
}
