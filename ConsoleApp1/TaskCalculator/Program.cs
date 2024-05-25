namespace TaskCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1            Add numbers");
                Console.WriteLine("2            Substract numbers");
                Console.WriteLine("3            Multiply numbers");
                Console.WriteLine("4            Devide numbers");
                Console.WriteLine("5            Exit");
                Console.Write("Make your choice by choosing one of this number: ");
                int choice = Convert.ToInt16(Console.ReadLine());
                if (choice == 5)
                {
                    break;
                }
                Console.Write("Enter number 1: ");
                double number1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter number 2: ");
                double number2 = Convert.ToDouble(Console.ReadLine());
                Calculator<double> calculator = new Calculator<double>(number1, number2);
                switch (choice)
                {
                    case 1: Console.WriteLine("Result of Adding: " + calculator.AddNumbers(number1, number2)); break;
                    case 2: Console.WriteLine("Result of Substracting: " + calculator.SubstractNumbers(number1, number2)); break;
                    case 3: Console.WriteLine("Result of Multiplexing: " + calculator.MultiplyNumbers(number1, number2)); break;
                    case 4: 
                        try
                        {
                            Console.WriteLine("REsult of deviding: " + calculator.DivideNumbers(number1, number2));
                            
                        }
                        catch (DivideByZeroException e)
                        {
                            throw new DivideByZeroException(e.Message);
                        }
                        catch (Exception)
                        {
                            throw new Exception("ERROR");
                        }
                        break;
                    default:
                        Console.WriteLine("Enter number from 1 to 5"); break;
                }
            }
        }
    }
}
