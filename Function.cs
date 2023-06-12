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
    public partial class Function : Form
    {
        private Calculator cs;
        //private bool randState = false;
        public Function(Calculator cs)
        {
            InitializeComponent();
            this.cs = cs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
                var random = new Random();
                double tmp = random.NextDouble();
                cs.addToTextBox(tmp.ToString());
                
            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cs.addToTextBox("floor(");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cs.addToTextBox("ceil(");
        }
    }
}
