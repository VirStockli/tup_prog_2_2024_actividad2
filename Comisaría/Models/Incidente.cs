using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Comisaría.Models
{
    internal class Incidente
    {
        
        public string Motivo { get { return Motivo; }  set { } }

        public int Horas { get { return Horas; }   set { } }
        public int Minutos { get { return Minutos; } set { } }

        public Policia OficialACargo { get; private set; }

        public Persona Sujeto { get; private set; }

        public int TipoIncidente { get { return TipoIncidente; }  set { } }

        public Incidente(Policia oficial, Persona sujeto) 
        {
            OficialACargo = oficial;
            Sujeto = sujeto;
        }

        public string VerDescripcion()
        {
            string descripción = "";

            if (TipoIncidente == 0)
            {
                descripción = $@"Denuncia Plocial, Emitida a las {Horas}:{Minutos}
                Motivo: {Motivo}
                Agente policial interviniente: {OficialACargo.VerDatos()}
                Sujeto Denunciante: {Sujeto.VerDatos()}";
            } else if (TipoIncidente == 1)
            {
                descripción = $@"Orden de Arresto, Emitada a las {Horas}:{Minutos} 
                Motivo: {Motivo}
                Sujeto a arrestar:{Sujeto.VerDatos()}
                Orden: 
                Por la presente se ordena al arresto inmediato de {Sujeto.VerDatos()}. El Agente {OficialACargo.VerDatos()} está autorizado a proceder con el arresto conforme a las leyes y regulaciones aplicadas";
            }

            return descripción;
        }
    }
}
