using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversion_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string bintodec(int[] binary, int lenght)
        {
            int b = 0;
            int multi = 1;
            string res = "";
            for (int beg = 0; beg < lenght; beg++)
            {
                b += binary[beg] * multi;
                multi *= 2;
            }
            return res = b.ToString();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numconvetr = int.Parse(textBox1.Text);
            textBox2.Text = Convert.ToString(numconvetr, 2);
            textBox1.Text = numconvetr.ToString();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {


            int numconvetr = int.Parse(textBox2.Text);
            string s = numconvetr.ToString();
            char[] a = s.ToCharArray();
            int[] aint = Array.ConvertAll(a, c => (int)char.GetNumericValue(c));
            int[] arr = new int[s.Length];
            Array.Reverse(aint);
            textBox1.Text = bintodec(aint, s.Length);

            textBox2.Text = numconvetr.ToString();
            

        }


    }
}
