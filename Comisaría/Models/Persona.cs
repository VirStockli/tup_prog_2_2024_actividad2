using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisaría.Models
{
    internal class Persona
    {
        public int DNI { get { return DNI; } private set { } }
        public string Nombre { get { return Nombre; } private set { } }

        public Persona(int dni, string nombre)
        {
            DNI = dni;
            Nombre = nombre;
        }

        public string VerDatos()
        {
            return "Nombre: " + Nombre + "- DNI: " + DNI; 
        }
    }
}
