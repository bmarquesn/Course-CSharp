using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Triangulo
    {
        public double LadoA;
        public double LadoB;
        public double LadoC;

        public double GetLadoA()
        {
            return LadoA;
        }
        public double GetLadoB()
        {
            return LadoB;
        }
        public double GetLadoC()
        {
            return LadoC;
        }

        public double AreaDoTriangulo()
        {
            double ladoA = GetLadoA();
            double ladoB = GetLadoB();
            double ladoC = GetLadoC();

            double p = (ladoA + ladoB + ladoC) / 2.0;
            double areaTriangulo = Math.Sqrt(p * (p = ladoA) * (p = ladoB) * (p = ladoC));//Math.Sqrt = Raiz Quadrada

            return areaTriangulo;
        }
    }
}
