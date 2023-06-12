/*using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCalc
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
            string expression = "7729.86+423.75/356.5";

            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(string), expression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            double result = double.Parse((string)row["expression"]);

            Console.WriteLine("Result: " + result);
            
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Calculator());
            }
            catch (Exception ex)
            {

            }

        }
    }
}

*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCalc
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                RunCalculator();
                
            }
            catch (Exception ex)
            {
                HandleException(ex);
                RunCalculator();
            }
        }

        static void RunCalculator()
        {
            Calculator calculator = new Calculator();
            
            {
                Application.Run(calculator);
            }
        }

        static void HandleException(Exception ex)
        {
            // Exception handling code
            MessageBox.Show("An exception occurred: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // Additional handling logic as needed
        }

        
    }
}
