using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro("rr martin", "jogo dos tronos", 10);
            livro.Exibe();

            Video video = new Video("taika", "thor", 120, 10);
            video.Exibe();

            Console.WriteLine("\nemprestando um video");
            Emprestado emprestado = new Emprestado(video);
            emprestado.EmprestarItem("carlos");
            emprestado.EmprestarItem("maria");
            
            emprestado.Exibe();

            emprestado.DevolverItem("carlos");

            emprestado.Exibe();

            Console.ReadKey();
        }
    }
}
