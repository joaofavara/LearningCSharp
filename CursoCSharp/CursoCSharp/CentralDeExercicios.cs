using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp {
    public class CentralDeExercicios {
        // private string test;

        /*public CentralDeExercicios(string? name) {
            test = String.IsNullOrEmpty(name) ?  "World" : name;            
        }*/

        public void RunProgram(Dictionary<string, string>? program) {

            foreach (KeyValuePair<string, string> pair in program) {
                Console.WriteLine("Key: {0} Values: {1}", pair.Key, pair.Value);
            }
        }
    }
}
