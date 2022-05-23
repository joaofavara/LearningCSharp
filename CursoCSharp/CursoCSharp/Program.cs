// See https://aka.ms/new-console-template for more information
using System;
using CursoCSharp.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Insert an name: ");
            CentralDeExercicios centralDeExercicios = new CentralDeExercicios();
            centralDeExercicios.RunProgram(new Dictionary<string, Action>() {
                {"1) Fundamentos - Primeiro Programa", PrimeiroPrograma.Exec}
            });
        }
    }
}


