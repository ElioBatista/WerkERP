using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public partial class Moneda
    {
        public Moneda()
        {
            this.Cheques = new List<Cheque>();
            this.OrdenPagoDetalles = new List<OrdenPagoDetalle>();
            this.SolicitudOrdenPagoDetalles = new List<SolicitudOrdenPagoDetalle>();
        }

        public int cod_moneda { get; set; }
        public string moneda1 { get; set; }
        public string simbolo { get; set; }
        public string formato { get; set; }
        public Nullable<int> cod_pais { get; set; }
        public virtual ICollection<Cheque> Cheques { get; set; }
        public virtual Pais Pais { get; set; }
        public virtual ICollection<OrdenPagoDetalle> OrdenPagoDetalles { get; set; }
        public virtual ICollection<SolicitudOrdenPagoDetalle> SolicitudOrdenPagoDetalles { get; set; }
    }
}
