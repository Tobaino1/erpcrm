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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
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

        private void button6_Click(object sender, EventArgs e)
        {
            new Form8().Show();
            this.Hide();
        }
    }
}
