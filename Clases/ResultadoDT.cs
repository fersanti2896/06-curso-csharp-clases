using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Clases {
    internal class ResultadoDT {
        internal int Valor { get; set; }
        public int Duplo { get; set; }
        public int Triplo { get; set; }

        public void Deconstructor(out int valor, out int duplo, out int triplo) {
            valor = Valor;
            duplo = Duplo;
            triplo = Triplo;
        }
    }
}
