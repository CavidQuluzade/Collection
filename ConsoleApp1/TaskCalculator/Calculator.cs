using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TaskCalculator
{
    internal class Calculator<T> where T : INumber<T>
    {
        private T Number1 { get; set; }
        private T Number2 { get; set; }
        public Calculator(T number1, T number2)
        {
            this.Number1 = number1;
            this.Number2 = number2;
        }
        public T AddNumbers(T number1, T number2)
        {
            
            return number1 + number2;
        }
        public T SubstractNumbers(T number1, T number2)
        {
           
            return number1 - number2;
        }
        public T MultiplyNumbers(T number1, T number2)
        {
            return number1 * number2;
        }
        public T DivideNumbers(T number1, T number2)
        {
            return number1 / number2;     
        }
    }
}
