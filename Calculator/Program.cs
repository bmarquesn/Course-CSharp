using System.Globalization;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Calculator.Sum(10, 20, 30, 40, 50);
            Console.WriteLine("Result = " + result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}