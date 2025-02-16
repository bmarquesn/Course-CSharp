using System;
namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = 34.5;
            double desconto;
            
            /* com ifs */
            /*if(preco < 20.0)
            {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.05;
            }*/

            /* condicional ternaria */
            desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine("Preço Original: " + preco);
            Console.WriteLine("Desconto: " + desconto);
            Console.WriteLine("Preço - Desconto: " + (preco - desconto));
        }
    }
}