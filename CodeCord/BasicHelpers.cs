using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeCord {
    class BasicHelpers {
        public static string RemoveLines(string str) {
            return Regex.Replace(str, "[\r\n(\r\n)]", "");
        }
        public static string RemoveSpaces(string str) {
            string output = str;
            while (output.Contains("  "))
                output = output.Replace("  ", " ");
            return output;
        }
        public static string RemoveTab(string str) {
            return str.Replace("\t", "");
        }
        public static string Normalise(string str) {
            return RemoveTab(
                   RemoveSpaces(
                   RemoveLines(str)));
        }
    }
}
