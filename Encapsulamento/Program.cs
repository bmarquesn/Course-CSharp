using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do Produto:");
            Console.Write("Nome: ");
            p.SetNome(Console.ReadLine());
            Console.Write("Preço: ");
            p.SetPreco(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.Write("Quantidade no Estoque: ");
            p.SetQuantidade(int.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + p);

            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos a ser adicionada ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos a ser removida ao estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);
        }
    }
}