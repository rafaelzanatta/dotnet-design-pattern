using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var func = new Funcionario();
            func.Nome = "Cavani";
            func.Idade = 33;
            func.Tipo = "Permanente";

            var funcClone = (Funcionario)func.Clone();
            funcClone.Nome = "Diego Souza";
            funcClone.Idade = 35;
            
            Console.WriteLine($"func permanente nome|idade|tipo: {func.Nome}|{func.Idade}|{func.Tipo}");
            Console.WriteLine($"func permanente clone nome|idade|tipo: {funcClone.Nome}|{funcClone.Idade}|{funcClone.Tipo}");
        }
    }
}
