using System;
using System.Globalization;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {       
            Console.WriteLine("Entre com os dados do Produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no Estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);
            
            Produto p2 = new Produto(nome, preco);
            
            Produto p3 = new Produto(nome = "Teste", preco = 123.456);

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