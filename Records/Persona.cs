using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Records {
    internal record Persona {
        public string Nombre { get; set; } = "";
        public string Apellido { get; set; } = "";
    }
}
