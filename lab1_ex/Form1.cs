using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            up.Click += button1_Click;
            down.Click += down_Click;
            left.Click += button3_Click;
            right.Click += button4_Click;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //up
            MessageBox.Show("up");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //left
            MessageBox.Show("left");
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //right
            MessageBox.Show("right");
        }

        private void down_Click(object sender, EventArgs e)
        {
            //down
            MessageBox.Show("down");
        }
    }
}
