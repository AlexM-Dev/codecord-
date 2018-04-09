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
    }
}
