using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisaría.Models
{
    internal class Guardia
    {
        public int HoraDesde { get { return HoraDesde; }  set { } }
        public int MinutosDesde { get { return MinutosDesde; }  set { } }
        public int HoraHasta { get 
            {
                int mins = HoraDesde * 60 + MinutosDesde + CantidadMinutos;

                return mins % 60;
            } private set { } }
        public int MinutosHasta { get 
            
            {
                int mins = HoraDesde * 60 + MinutosDesde + CantidadMinutos;
                return mins / 60; 
            } private set { } }

        public int CantidadMinutos { get { return CantidadMinutos; }  set { } }

        public Policia OficialAsignado { get { return OficialAsignado; } private set { } }

        public Guardia() { }

        public void AsignarPolicia(Policia p, int h1, int m1, int canMin)
        {
            OficialAsignado = p;
            HoraDesde = h1;
            MinutosDesde = m1;
            CantidadMinutos = canMin;
        }



    }
}
