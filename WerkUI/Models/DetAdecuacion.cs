using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class DetAdecuacion
    {
        public DetAdecuacion()
        {
            this.Det2Adecuacion = new List<Det2Adecuacion>();
        }

        public decimal Linea { get; set; }
        public decimal CodAdecuacion { get; set; }
        public byte ColAdecuacion { get; set; }
        public string Descripcion { get; set; }
        public string Simbolo { get; set; }
        public virtual Adecuacion Adecuacion { get; set; }
        public virtual ICollection<Det2Adecuacion> Det2Adecuacion { get; set; }
    }
}
