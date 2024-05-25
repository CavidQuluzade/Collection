using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskCalculator
{
    internal class Calculator<T> 
    {
        private T Number1 { get; set; }
        private T Number2 { get; set; }
        public Calculator(T number1, T number2)
        {
            this.Number1 = number1;
            this.Number2 = number2;
        }
        public double AddNumbers(T number1, T number2)
        {
            double num1 = Convert.ToDouble(number1);
            double num2 = Convert.ToDouble(number2);
            return num1 + num2;
        }
        public double SubstractNumbers(T number1, T number2)
        {
            double num1 = Convert.ToDouble(number1);
            double num2 = Convert.ToDouble(number2);
            return num1 - num2;
        }
        public double MultiplyNumbers(T number1, T number2)
        {
            double num1 = Convert.ToDouble(number1); 
            double num2 = Convert.ToDouble(number2); 
            return num1 * num2;
        }
        public double DivideNumbers(T number1, T number2)
        {
            double num1 = Convert.ToDouble(number1); 
            double num2 = Convert.ToDouble(number2);
            if (num2 == 0)
            {
                throw new DivideByZeroException("DEVIDE BY ZERO");
            }
            return num1 / num2;     
        }
    }
}
