namespace SuperMercado
{
    public class Produto
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public decimal Valor { get; set; }
        public decimal QuantidadeEstoque { get; set; }

        public Produto(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }
        public Produto(int id, string nome, decimal valor, decimal quantidadeEstoque)
        {
            this.Id = id;
            this.Nome = nome;
            this.Valor = valor;
            this.QuantidadeEstoque = quantidadeEstoque;
        }
    }
}