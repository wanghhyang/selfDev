using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDriver
{
    public class MathExercise
    {
       
        public void OnAddCalculationChanged(object sender, CalculatorArgs args)
        {
            Console.WriteLine("获得了一个大于100的结果");
            if (args.FirstNum < 0)
            {
                MessageSender messageSender = new MessageSender();
                messageSender.OutputMesasge("输入的第一个参数小于0", EMesasgeType.Error);
            }
        }
    }
}
