using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp {
    public class CentralDeExercicios {
        private string test;

        public CentralDeExercicios(string? name) {
            test = String.IsNullOrEmpty(name) ?  "World" : name;            
        }

        public void RunProgram() {
            Console.WriteLine($"Hello, {test}! ");
        }
    }
}
