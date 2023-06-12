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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
      
        private static List<string> operations = new List<string>();
        

        //Test exception
        

        // The name said it self lmao
        private bool CheckBracketBalance(string input)
        {
            Stack<char> bracketStack = new Stack<char>();

            foreach (char c in input)
            {
                if (c == '(')
                {
                    bracketStack.Push(c); // Push opening bracket to the stack
                }
                else if (c == ')')
                {
                    if (bracketStack.Count == 0 || bracketStack.Pop() != '(')
                    {
                        return false; // Unbalanced closing bracket found
                    }
                }
            }

            return bracketStack.Count == 0; // True if all brackets are balanced, false otherwise
        }

        private bool checkLastIsLeftBracket()
        {
            if (operations.Any())
            {
                //Check the percent first
                if (operations.Last().Contains("%"))
                    return true;
                if (operations.Last().Contains("("))
                {
                    return true;
                }
            }
            return false;
        }

        public void addToTextBox(string text)
        {
            richTextBox1.Text += text;
            operations.Add(text);
        }
        private void button_abs_Click(object sender, EventArgs e)
        {
            /*
            if (bracketFlag)
            {
                return;
            }
            */
            addToTextBox("abs(");
            
            //bracketFlag = true;
        }
        
        private void button_del_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0 || richTextBox1.Text.Length < operations.Last().Length || !operations.Any())
            {
                return;
            }
            /*
            if (operations.Last() == "abs(" || operations.Last() == "(")
            {
                bracketFlag = false;
            }
            */
            richTextBox1.ReadOnly = false;
            char[] mychar = operations.Last().ToCharArray();
            string text = richTextBox1.Text.Substring(0, richTextBox1.Text.Length - operations.Last().Length);
            richTextBox1.Text = text;
            richTextBox1.ReadOnly = true;
            operations.RemoveAt(operations.Count - 1);
            
        }
        public void getButtonDel(object sender, EventArgs e)
        {
            button_del_Click(sender, e);
        }

        private void button_rightBracket_Click(object sender, EventArgs e)
        {
            /*
            if (bracketFlag)
            {
                return;
            }
            */
            richTextBox1.Text += ")";
            operations.Add(")");
            //bracketFlag = true;
        }

        private void button_leftBracket_Click(object sender, EventArgs e)
        {
            //bracketFlag = false;
            richTextBox1.Text += "(";
            operations.Add("(");
        }

        private void button_percent_Click(object sender, EventArgs e)
        {
            if (!checkLastIsLeftBracket())
                addToTextBox("%");
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            addToTextBox("0");
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            addToTextBox(".");
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            addToTextBox("1");
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            addToTextBox("2");
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            addToTextBox("3");
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            addToTextBox("4");
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            addToTextBox("5");
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            addToTextBox("6");
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            addToTextBox("7");
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            addToTextBox("8");
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            addToTextBox("9");
        }

        private void button_c_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            addToTextBox(" + ");
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            addToTextBox(" - ");
        }

        private void button_times_Click(object sender, EventArgs e)
        {
            addToTextBox(" * ");
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            addToTextBox(" / ");
        }

        private void button_sqr_sqrt_Click(object sender, EventArgs e)
        {
            addToTextBox("^2 ");
        }

        private void button_1ofX_Click(object sender, EventArgs e)
        {
            addToTextBox("1/(");
        }

        private void button_pi_Click(object sender, EventArgs e)
        {
            addToTextBox("π");
        }

        private void button_e_Click(object sender, EventArgs e)
        {
            addToTextBox("e");
        }

        private void button_factorial_Click(object sender, EventArgs e)
        {
            addToTextBox("!");
        }

        private void button_cuberoot_Click(object sender, EventArgs e)
        {
            addToTextBox("∛(");
        }

        private void button_XpowY_Click(object sender, EventArgs e)
        {
            addToTextBox("^");
        }

        private void button_mod_Click(object sender, EventArgs e)
        {
            addToTextBox(" # ");
        }

        private void button_ln_Click(object sender, EventArgs e)
        {
            addToTextBox("ln(");
        }

        private void button_log_Click(object sender, EventArgs e)
        {
            addToTextBox("log(");
        }

        private void button_root_Click(object sender, EventArgs e)
        {
            addToTextBox("root(");
        }

        private void button_comma_Click(object sender, EventArgs e)
        {
            addToTextBox(",");
        }

        private void button_10powX_Click(object sender, EventArgs e)
        {
            addToTextBox("10 ^ ");
        }

        private void button_trigonometry_Click(object sender, EventArgs e)
        {
            Trigonometry trigonometry = new Trigonometry(this);
            trigonometry.Show();
        }

        private void button_function_Click(object sender, EventArgs e)
        {
            Function function = new Function(this);
            function.Show();
        }

        private void button_ePowX_Click(object sender, EventArgs e)
        {
            addToTextBox("e ^(");
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text.Any())
            {
                richTextBox2.Text = "";
            }
            CalcHandler calcHandler = new CalcHandler(richTextBox1.Text);
            richTextBox2.Text = calcHandler.execute();
            
        }
    }
}
