using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDriver
{
    class Program
    {

        static void Main(string[] args)
        {
            MathCalculator calc = new MathCalculator();

            MathExercise exercise = new MathExercise();
            MathExercise exercise1 = new MathExercise();

            calc.OnResultChanged += new ChangeHandler(exercise.OnAddCalculationChanged);//这是一种语法糖，意思是其他类定于了一个类的内部变化通知，MathCalculator类被MathExercise的一个实例订阅了，或者说监听了。
            calc.OnResultChanged += new ChangeHandler(exercise1.OnAddCalculationChanged);//这是一种语法糖，意思是其他类订阅了一个类的内部变化通知。
            calc.Add(-9, 150);


            Console.ReadKey();
        }
    }
}
