using System;

namespace Aula2Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Autor uncle = new Autor(23,"Gabriel","\n(55)11111111");

            Livro meuLivro = new Livro(1234,uncle, "Livro C#", 150);
            Console.WriteLine(meuLivro.nome);

            //Quem é o autor do livro
            Console.WriteLine(meuLivro.autor.nome + meuLivro.autor.fone);

        }
    }
}
