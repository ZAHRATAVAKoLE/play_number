using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Random r;
        int computer_number;
        public Form1()
        {
            InitializeComponent();
            r = new Random();
            computer_number = r.Next(0, 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (true)
            {
                int user_number = Convert.ToInt32(textBox1.Text);
                if (user_number == computer_number)
                {

                    label1.Text=("you win");
                }
                else if (user_number < computer_number)
                {
                    label1.Text=("go up");
                }
                else if (user_number > computer_number)
                {
                    label1.Text=("go down");

                }
                textBox1.Text = " ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Run(new Form());
        }
    }
}