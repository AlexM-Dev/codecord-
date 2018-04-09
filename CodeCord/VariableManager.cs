using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCord {
    class VariableManager {
        public Dictionary<string, object> Variables { get; set; } =
            new Dictionary<string, object>();

        public void Set(string name, object value) {
            if (value.GetType() != Variables[name].GetType())
                return;
            Variables[name] = value;
        }
    }
}
