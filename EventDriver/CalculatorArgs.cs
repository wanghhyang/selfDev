using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDriver
{
   public class CalculatorArgs:EventArgs
    {
        public CalculatorArgs()
        {

        }
        public CalculatorArgs(decimal firstNum,decimal secondNum,decimal result)
        {
            this.FirstNum = firstNum;
            this.SecondNum = firstNum;
            this.Result = result;
        }
        public decimal FirstNum { get; set; }
        public decimal SecondNum { get; set; }
        public decimal Result { get; set; }
    }
}
