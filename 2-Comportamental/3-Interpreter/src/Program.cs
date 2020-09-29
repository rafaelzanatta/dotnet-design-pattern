﻿using System;
using System.Collections.Generic;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string romano = "MVMXXVIII";

            Contexto contexto = new Contexto(romano);
            
            List<Expressao> lista = new List<Expressao>();
            lista.Add(new MilharesExpressao());
            lista.Add(new CentenasExpressao());
            lista.Add(new DezenasExpressao());
            lista.Add(new UnidadeExpressao());

            foreach(Expressao exp in lista)
            {
                exp.Interpretador(contexto);
            }

            Console.WriteLine($"{romano} = {contexto.Output}");
        }
    }
}
