using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Struct {
    internal struct Punto {
        public Punto(int x, int y) {
            X = x;  
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }
}
