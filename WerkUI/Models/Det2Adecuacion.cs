using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class Det2Adecuacion
    {
        public decimal SubLinea { get; set; }
        public decimal Linea { get; set; }
        public decimal CodAdecuacion { get; set; }
        public byte ColAdecuacion { get; set; }
        public string Cuenta { get; set; }
        public string Accion { get; set; }
        public string Descripcion { get; set; }
        public string Simbolo { get; set; }
        public virtual DetAdecuacion DetAdecuacion { get; set; }
    }
}
