using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class Adecuacion
    {
        public Adecuacion()
        {
            this.DetAdecuacions = new List<DetAdecuacion>();
        }

        public decimal CodAdecuacion { get; set; }
        public string DesAdecuacion { get; set; }
        public byte ColAdecuacion { get; set; }
        public string DesColumna { get; set; }
        public decimal CodUsuario { get; set; }
        public decimal CodEmpresa { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<DetAdecuacion> DetAdecuacions { get; set; }
    }
}
