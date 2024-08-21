using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Comisaría.Models
{
    internal class Comisaria
    {
        int cantidad;
        
        ArrayList Agentes = new ArrayList();
        ArrayList Incidentes = new ArrayList();
        Guardia[] guardias = new Guardia[2];

        public int CantidadIncidentes { get { return Incidentes.Count; } }

        public Comisaria()
        {
            for(int n=0; n< guardias.Length; n++)
                guardias[n] = new Guardia();
        }
        public bool AsignarPolicia (Policia p)
        {
            if(Agentes.Count < 2)
            {
                Agentes.Add(p);
                return true;
            }
            return false;
        }

        public Policia VerAgente(int numPlaca)
        {
            Policia buscado = null;
            for (int n = 0; n < Agentes.Count; n++)
            {
                Policia agente = Agentes[n] as Policia;
                if (agente != null && agente.NumeroPlaca == numPlaca)
                {
                    buscado = agente;
                }
            }
            return buscado;
        }
        
        public void RegistrarIncidente (Policia agente, Persona sujeto, string motivo, int hora, int minuto, int tipoIncidente)
        {
            Incidente nuevoIncidente = new Incidente(agente, sujeto);
            Incidentes.Add(nuevoIncidente);

            nuevoIncidente.Horas= hora;
            nuevoIncidente.Minutos= minuto;
            nuevoIncidente.TipoIncidente= tipoIncidente;


        }

        public void AsignarGuardia(int numeroGuardia, int h1, int m1, int tiempoMinutos, Policia p)//chequear para que va el agente
        { 
            if (numeroGuardia <2)
            {
                Guardia seleccionado = guardias[numeroGuardia];
                seleccionado.HoraDesde = h1;
                seleccionado.MinutosDesde = m1;
                seleccionado.CantidadMinutos = tiempoMinutos;

                

            }
        
        }

        public Incidente VerIncidente  (int idx)
        {
            if(idx >= 0 && idx < CantidadIncidentes)
            {
                return Incidentes[idx] as Incidente;
            }
            else { return null; }
        }

    }

   
}
