﻿using System;
using System.Globalization;

namespace Struct
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        /*construtor padrão*/
        public Produto()
        {

        }
        
        /*Construtor (mesmo nome da classe)*/
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        /*Sobrecarga*/
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 0;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
