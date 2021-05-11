using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia
{
    public class Reserva
    {
        private int ID { get; set; }
        private DateTime fDesde { get; set; }
        private DateTime dHasta { get; set; }
        private float precio { get; set; }
        
        public Alojamiento propiedad;
        public Usuario persona;

         Reserva(int iD, DateTime fDesde, DateTime dHasta, float precio, Alojamiento propiedad, Usuario persona)
        {
            ID = iD;
            this.fDesde = fDesde;
            this.dHasta = dHasta;
            this.precio = precio;
            this.propiedad = propiedad;
            this.persona = persona;
        }
    }
}
