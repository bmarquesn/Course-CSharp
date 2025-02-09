using System.Drawing;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p;
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);

            p = new Point();
            Console.WriteLine(p);

            //Nullable<double> x = null;
            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());   
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("x is null");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("y is null");
            }

            //Operador de coalescencia nula
            double a = x ?? 5;
            double b = y ?? 5;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
    }
}