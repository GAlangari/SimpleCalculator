using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the first number or press enter to exit: ");
                var in1 = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(in1))
                {
                    break;
                }
                var num1 = Convert.ToInt32(in1);

                Console.WriteLine("Enter the second number: ");
                var num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the operation: ");
                var op = Console.ReadLine();

                int result = 0;

                switch (op)
                {
                    case "+":
                        result = Addition(num1, num2);
                        break;
                    case "-":
                        result = Subtraction(num1, num2);
                        break;
                    case "*":
                        result = Multiply(num1, num2);
                        break;
                    case "/":
                        result = Division(num1, num2);
                        break;
                }
                Console.WriteLine("The result of " + num1 + op + num2 + " = " + result);
            }
        }

        static int Addition (int num1, int num2)
        {
            var result = num1 + num2;
            return result;
        }
        static int Subtraction(int num1, int num2)
        {
            var result = num1 - num2;
            return result;
        }
        static int Multiply (int num1, int num2)
        {
            var result = num1 * num2;
            return result;
        }
        static int Division(int num1, int num2)
        {
            var result = num1 / num2;
            return result;
        }
    }
}
