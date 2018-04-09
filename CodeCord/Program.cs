using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CodeCord {
    internal class Program {
        private static void Main(string[] args) {
            var manager = new VariableManager();
            manager.Variables.Add("v", 10);

            object v = manager.Variables["v"];
            Console.WriteLine(v);

            // Won't work.
            manager.Set("v", 100d);
            Console.WriteLine(manager.Variables["v"]);

            // Will work.
            manager.Set("v", 1000);
            Console.WriteLine(manager.Variables["v"]);

            Console.ReadKey();
        }
    }
}