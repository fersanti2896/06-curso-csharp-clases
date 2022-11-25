using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Clases {
    public class Carro {
        private string _marca;

        /* Contructor */
        public Carro() {
            Console.WriteLine("Instanciando un carro");
            _marca = String.Empty;
            ConteoInstancia++;
        }

        /* Campo de lectura y escritura */
        internal string Marca {
            get { return _marca.ToUpper(); }
            set { _marca = value; } 
        }

        internal int Anio { get; set; } = 2000;

        /* Campo de solo lectura */
        internal int Kilometraje { get; private set; } = 20;
        private int KilometrajeMax => 120;
        internal string NombreComercial => $"Marca: { Marca } Anio: { Anio }";
        public static int ConteoInstancia { get; set; }

        internal void Acelear() {
            Acelear(100);
        }

        internal void Acelear(int incremento) {
            if (Kilometraje >= KilometrajeMax) {
                Console.WriteLine($"El kilometraje ha alcanzado su punto máximo.");
            } else if (Kilometraje + incremento > KilometrajeMax) {
                incremento = KilometrajeMax - Kilometraje;
            }

            Kilometraje++;
        }

        internal void Detener() => Kilometraje = 0;
    }
}
