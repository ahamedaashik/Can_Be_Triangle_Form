using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Can_be_triange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textBox1.Text);
            int b = Int32.Parse(textBox2.Text);
            int c = Int32.Parse(textBox3.Text);

            if (a < b + c && b < a + c && c < a + b)
            {
                label1.Text = "Can be triangel";
            }
            else
                label1.Text = "Can't be triangle";
        }
    }
}
