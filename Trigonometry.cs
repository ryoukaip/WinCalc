using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCalc
{
    public partial class Trigonometry : Form
    {
        private Calculator cs;
        private bool hypState = false;
        private bool arcState = false;
        public Trigonometry(Calculator cs)
        {
            InitializeComponent();
            this.cs = cs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!arcState)
            {
                button2.Text += "ᐨ¹";
                button3.Text += "ᐨ¹";
                button4.Text += "ᐨ¹";
                button6.Text += "ᐨ¹";
                button7.Text += "ᐨ¹";
                button8.Text += "ᐨ¹";
                arcState = true;
            }
            else
            {
                string tmp;
                tmp = button2.Text.TrimEnd('ᐨ', '¹');
                button2.Text = tmp;
                tmp = button3.Text.TrimEnd('ᐨ', '¹');
                button3.Text = tmp;
                tmp = button4.Text.TrimEnd('ᐨ', '¹');
                button4.Text = tmp;
                tmp = button6.Text.TrimEnd('ᐨ', '¹');
                button6.Text = tmp;
                tmp = button7.Text.TrimEnd('ᐨ', '¹');
                button7.Text = tmp;
                tmp = button8.Text.TrimEnd('ᐨ', '¹');
                button8.Text = tmp;

                arcState = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(!hypState) 
            {
                button2.Text += "h";
                button3.Text += "h";
                button4.Text += "h";
                button6.Text += "h";
                button7.Text += "h";
                button8.Text += "h";
                hypState = true;
            }
            else
            {
                string tmp;
                tmp = button2.Text.TrimEnd('h');
                button2.Text = tmp;
                tmp = button3.Text.TrimEnd('h');
                button3.Text = tmp;
                tmp = button4.Text.TrimEnd('h');
                button4.Text = tmp;
                tmp = button6.Text.TrimEnd('h');
                button6.Text = tmp;
                tmp = button7.Text.TrimEnd('h');
                button7.Text = tmp;
                tmp = button8.Text.TrimEnd('h');
                button8.Text = tmp;


                hypState = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cs.addToTextBox(button2.Text + "(");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cs.addToTextBox(button3.Text + "(");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cs.addToTextBox(button4.Text + "(");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cs.addToTextBox(button6.Text + "(");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cs.addToTextBox(button7.Text + "(");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cs.addToTextBox(button8.Text + "(");
        }
    }
}
