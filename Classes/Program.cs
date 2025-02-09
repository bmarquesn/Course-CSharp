using Classes;
using System.Globalization;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do X: ");
            x.LadoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.LadoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.LadoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Área de Triangulo X: " + x.AreaDoTriangulo().ToString("F2"));

            Console.WriteLine("Entre com as medidas do Y: ");
            y.LadoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.LadoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.LadoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Área de Triangulo Y: " + y.AreaDoTriangulo().ToString("F2"));

            if(x.AreaDoTriangulo() > y.AreaDoTriangulo())
            {
                Console.WriteLine("O Triangulo X tem uma área maior");
            } else
            {
                Console.WriteLine("O Triangulo Y tem uma área maior");
            }
        }
    }
}