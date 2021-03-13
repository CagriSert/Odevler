using System;
using System.Linq;

namespace Metod
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            var result = Add2(5, 10);
            Console.WriteLine(result);

            Console.WriteLine(Multiply(2, 4, 8));
            Console.WriteLine(Multiply(2, 4, 5));
            Console.WriteLine(Add4(2, 5, 6, 8, 7, 4, 1, 2, 3, 5, 8, 5, 2));
        }
        static void Add()
        {
            Console.WriteLine("Added!!");
        }
        static int Add2(int number1, int number2)
        {
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
