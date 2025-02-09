using System;
using System.Globalization;

namespace Struct
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;
        /*Auto Preperties (* variaveis "comuns", sem especificacoes ifs)
         * public double Preco {get; private set;}
         * public double Quantidade {get; private set;}
         */

        public Produto()
        {

        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double Preco
        {
            get { return _preco; }
            set
            {
                if (value > 0)
                {
                    _preco = value;
                }
            }
        }

        public int Quantidade
        {
            get { return _quantidade; }
            set
            {
                if (value > 0)
                {
                    _quantidade = value;
                }
            }
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
                + ", $"
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
