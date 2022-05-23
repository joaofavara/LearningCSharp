using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp {
    public class CentralDeExercicios {
        public void RunProgram(Dictionary<string, Action>? program) {
            foreach (KeyValuePair<string, Action> pair in program) {
                Console.WriteLine("{0}", pair.Key);
            }

            int choosenProgram = Convert.ToInt32(Console.ReadLine()) - 1;
            program.Values.ElementAt(choosenProgram)();
        }
    }
}
