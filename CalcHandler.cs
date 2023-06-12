using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.mariuszgromada.math.mxparser;
namespace WinCalc
{
    
    internal class CalcHandler
    {
        private string StringOperation;

        public CalcHandler(string StringOperation) 
        {
            this.StringOperation = StringOperation;
        }
        public string execute()
        {
            Expression expression = new Expression(StringOperation);
            double result = expression.calculate();

            return result.ToString();
        }
    }
}
