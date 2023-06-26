using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JigsawPuzzle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = "";
            if (button2.Text == "")
            {
                a = button1.Text;
                button1.Text = "";
                button2.Text = a;
            }
            else if (button4.Text == "")
            {
                a = button1.Text;
                button1.Text = "";
                button4.Text = a;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = "";
            if (button1.Text == "")
            {
                a = button2.Text;
                button2.Text = "";
                button1.Text = a;
            }
            else if (button3.Text == "")
            {
                a = button2.Text;
                button2.Text = "";
                button3.Text = a;
            }
            else if (button5.Text == "")
            {
                a = button2.Text;
                button2.Text = "";
                button5.Text = a;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a = "";
            if (button2.Text == "")
            {
                a = button3.Text;
                button3.Text = "";
                button2.Text = a;
            }
            else if (button6.Text == "")
            {
                a = button3.Text;
                button3.Text = "";
                button6.Text = a;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string a = "";
            if (button1.Text == "")
            {
                a = button4.Text;
                button4.Text = "";
                button1.Text = a;
            }
            else if (button5.Text == "")
            {
                a = button4.Text;
                button4.Text = "";
                button5.Text = a;
            }
            else if (button7.Text == "")
            {
                a = button4.Text;
                button4.Text = "";
                button7.Text = a;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string a = "";
            if (button8.Text == "")
            {
                a = button5.Text;
                button5.Text = "";
                button8.Text = a;
            }
            else if (button2.Text == "")
            {
                a = button5.Text;
                button5.Text = "";
                button2.Text = a;
            }
            else if (button6.Text == "")
            {
                a = button5.Text;
                button5.Text = "";
                button6.Text = a;
            }
            else if (button4.Text == "")
            {
                a = button5.Text;
                button5.Text = "";
                button4.Text = a;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string a = "";
            if (button9.Text == "")
            {
                a = button6.Text;
                button6.Text = "";
                button9.Text = a;
            }
            else if (button5.Text == "")
            {
                a = button6.Text;
                button6.Text = "";
                button5.Text = a;
            }
            else if (button3.Text == "")
            {
                a = button6.Text;
                button6.Text = "";
                button3.Text = a;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string a = "";
            if (button8.Text == "")
            {
                a = button7.Text;
                button7.Text = "";
                button8.Text = a;
            }
            else if (button4.Text == "")
            {
                a = button7.Text;
                button7.Text = "";
                button4.Text = a;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string a = "";
            if (button9.Text == "")
            {
                a = button8.Text;
                button8.Text = "";
                button9.Text = a;
            }
            else if (button7.Text == "")
            {
                a = button8.Text;
                button8.Text = "";
                button7.Text = a;
            }
            else if (button5.Text == "")
            {
                a = button8.Text;
                button8.Text = "";
                button5.Text = a;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string a = "";
            if (button8.Text == "")
            {
                a = button9.Text;
                button9.Text = "";
                button8.Text = a;
            }
            else if (button6.Text == "")
            {
                a = button9.Text;
                button9.Text = "";
                button6.Text = a;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(button1.Text != "1")
                button1.Text = "1";
            if(button2.Text != "2")
                button2.Text = "2";
            if (button3.Text != "3")
                button3.Text = "3";
            if (button4.Text != "4")
                button4.Text = "4";
            if (button5.Text != "5")
                button5.Text = "5";
            if (button6.Text != "6")
                button6.Text = "6";
            if (button7.Text != "7")
                button7.Text = "7";
            if (button8.Text != "8")
                button8.Text = "8";
            if (button9.Text != "")
                button9.Text = "";
        }
    }
}
