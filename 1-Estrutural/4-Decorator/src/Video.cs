using System;

namespace Decorator
{
    public class Video : ItemBiblioteca
    {
        public string Diretor { get; set; }
        public string Titulo { get; set; }
        public int MinutosDuracao { get; set; }
        
        public Video(string diretor, string titulo, int minutos, int copias)
        {
            Diretor = diretor;
            Titulo = titulo;
            MinutosDuracao = minutos;
            NumeroCopias = copias;
        }

        public override void Exibe()
        {
            Console.WriteLine("\nVideo ------");
            Console.WriteLine($"diretor: {Diretor}");
            Console.WriteLine($"titulo: {Titulo}");
            Console.WriteLine($"duracao: {MinutosDuracao}");
            Console.WriteLine($"# copias: {NumeroCopias}");
        }
    }
}