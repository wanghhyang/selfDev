using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDriver
{
    public delegate void ChangeHandler(object sender, CalculatorArgs args);
    public class MathCalculator
    {
        public event ChangeHandler OnResultChanged;

        public decimal Add(decimal firstNum, decimal secondNum)
        {
            decimal result = 0;
            result = firstNum + secondNum;
            if (result > 100)
            {
                var eventArgs = new CalculatorArgs()
                {
                    FirstNum = firstNum,
                    SecondNum = secondNum,
                    Result = result
                };

                OnResultChanged(this, eventArgs);
            }
            return result;
        }
    }
}
