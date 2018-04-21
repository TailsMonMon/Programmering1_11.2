using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering1_11._2 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Vad heter du? ");
            string name = Console.ReadLine();
            Console.Write("Vad är ditt favoritdjur? ");
            string animal = Console.ReadLine();
            Console.WriteLine(MyMethod(name, animal));
            Console.ReadLine();
        }

        static string MyMethod(string name, string animal) {
            string answer = "Hejsan " + name + "! Oj, " + animal + " är mitt favoritdjur också!";
            return answer;
        }
    }
}
