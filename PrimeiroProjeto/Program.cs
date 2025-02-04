using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Maria Green";
            object obj1 = "Alex Brown";
            object obj2 = 4.5F;

            int n7 = int.MinValue;
            int n8 = int.MaxValue;
            sbyte n9 = sbyte.MinValue;
            decimal n10 = decimal.MaxValue;

            double saldo = 10.358796;
            int idade = 32;

            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            int codigo = 5290;
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            int a = 5;
            int b = 2;
            double resultado1 = a / b;
            double resultado2 = (double)a / b;

            double aa = 1.0, bb = -3.0, cc = -4.0;
            double bAoQuadrado = Math.Pow(bb, 2.0); //(b*b) || b ao quadrado;
            double delta = bAoQuadrado - 4.0 * aa * cc;
            double equacaoSegundoGrau1 = (-bb + Math.Sqrt(delta)) / (2.0 * aa); //Math.Sqrt = Raiz Quadrada
            double equacaoSegundoGrau2 = (-bb - Math.Sqrt(delta)) / (2.0 * aa); //Math.Sqrt = Raiz Quadrada

            string frase = Console.ReadLine();

            int variavelX = int.Parse(Console.ReadLine());

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine("---------------");
            Console.WriteLine(n7);
            Console.WriteLine(n8);
            Console.WriteLine(n9);
            Console.WriteLine(n10);
            Console.WriteLine("---------------");
            Console.WriteLine(saldo);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("---------------");
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo); //placeholder
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais"); //interpolação
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais"); //concatenação
            Console.WriteLine("---------------");
            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1:F2}");
            string value = $"{produto2}, cujo preço é $ {preco2:F2}";
            Console.WriteLine(value);
            Console.WriteLine("---------------");
            Console.WriteLine("Resultado 1: " + resultado1);
            Console.WriteLine("Resultado 2: " + resultado2);
            Console.WriteLine("---------------");
            Console.WriteLine(delta);
            Console.WriteLine(equacaoSegundoGrau1);
            Console.WriteLine(equacaoSegundoGrau2);
            Console.WriteLine("---------------");
            Console.WriteLine($"Você digitou: {frase}");
            Console.WriteLine("---------------");
            Console.WriteLine($"Variavel X: {variavelX}");
        }
    }
}