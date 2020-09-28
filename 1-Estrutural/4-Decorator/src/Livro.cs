using System;

namespace Decorator
{
    public class Livro : ItemBiblioteca
    {
        public string Autor { get; set; }
        public string Titulo { get; set; }

        public Livro(string autor, string titulo, int numeroCopias)
        {
            Autor = autor;
            Titulo = titulo;
            NumeroCopias = numeroCopias;
        }

        public override void Exibe()
        {
            Console.WriteLine("\nlivro ----");
            Console.Write($" autor: {Autor}");
            Console.Write($" titulo: {Titulo}");
            Console.Write($" # copias: {NumeroCopias}");
        }
    }
}