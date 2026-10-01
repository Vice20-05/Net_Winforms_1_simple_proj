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
            start.Click += Start_Click;
            Stop.Click += Stop_Click;

        }

   

        private void button1_Click(object sender, EventArgs e)
        {
            //up
            textBox1.Text="up";
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
            textBox1.Text = "left";
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //right
            textBox1.Text = "right";
        }

        private void down_Click(object sender, EventArgs e)
        {
            //down
            textBox1.Text = "down";
        }

        private void Start_Click(object sender, EventArgs e)
        {
           timer1.Start();
        }

     
        

        private async void timer1_Tick_1(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Red)
            {
                this.BackColor = Color.Blue;
                await System.Threading.Tasks.Task.Delay(100);
            }
                else
            {
                this.BackColor = Color.Red;
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
