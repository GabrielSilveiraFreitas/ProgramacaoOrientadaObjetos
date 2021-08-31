namespace Aula2Code
{
    public class Livro
    {
        public int id { get; set; }
        public string nome{ get; private set; }
        public string descricao { get; set; }
        public decimal valor { get; set; }
        public string isbn { get; set; }

        public Autor autor { get; set; }

        //CONSTRUTOR LIVRO
        public Livro(int id, Autor autor, string nome, decimal valor)
        {
            this.id = id;
            this.nome = nome;
            this.valor = valor;
            this.autor = autor;
        }
        //...

        





    }
}