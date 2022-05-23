// See https://aka.ms/new-console-template for more information
using System;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Insert an name: ");
            string? name = Console.ReadLine();
            CentralDeExercicios centralDeExercicios = new CentralDeExercicios();
            centralDeExercicios.RunProgram(new Dictionary<string, string>() {
                {"xuin", "batata"}
            });
        }
    }
}


