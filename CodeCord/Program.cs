using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCord
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string lines = "Hello\r\n    Noob!";
            Console.WriteLine(lines);
            Console.WriteLine(BasicHelpers.RemoveLines(lines));
            Console.WriteLine(BasicHelpers.RemoveSpaces(lines));
            Console.ReadKey();
        }
    }
}