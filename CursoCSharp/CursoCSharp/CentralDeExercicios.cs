using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp {
    public class CentralDeExercicios {
        private string test;

        public CentralDeExercicios(string name) {
            test = name;            
        }

        public void RunProgram() {
            Console.WriteLine($"Hello, {test}! ");
        }
    }
}
