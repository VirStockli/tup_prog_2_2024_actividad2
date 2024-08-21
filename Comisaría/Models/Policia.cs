using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisaría.Models
{
    internal class Policia
    {
        
        public int DNI { get { return DNI; } private set { } }
        public string Nombre { get { return Nombre; } private set { } }
        public int NumeroPlaca { get { return NumeroPlaca; } private set { } }
        public Policia (int dni, string nombre, int placa)
        {
            this.DNI = dni;
            this.Nombre = nombre;
            this.NumeroPlaca = placa;
        }

        public string VerDatos()
        {
            return DNI + "-" + Nombre + "-" + NumeroPlaca;
        }
    }

}
