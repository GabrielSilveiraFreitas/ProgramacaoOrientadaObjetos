using System;

namespace SuperMercado
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produtoRecemNascido = new Produto(13,"teclado");
            produtoRecemNascido.Valor = 250;
            produtoRecemNascido.QuantidadeEstoque = 15;

            Produto produto = new Produto(12,"Mouse",150,10);
            produto.Valor = 159;
            produto.QuantidadeEstoque = 8;

            Console.WriteLine($"O produto {produto.Nome} contén {produto.QuantidadeEstoque} em estoque");
        }
    }
}
