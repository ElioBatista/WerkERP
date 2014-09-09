using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class CAJAFORMACOBRO
    {
        public CAJAFORMACOBRO()
        {
            this.CAJACHEQUESRECIBIDOS = new List<CAJACHEQUESRECIBIDO>();
            this.CAJANOTACREDITOes = new List<CAJANOTACREDITO>();
            this.CAJATARJETAS = new List<CAJATARJETA>();
        }

        public decimal CODFORMACOBRO { get; set; }
        public decimal CODINGRESO { get; set; }
        public decimal CODFORCOBRO { get; set; }
        public decimal CODMONEDA { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public virtual ICollection<CAJACHEQUESRECIBIDO> CAJACHEQUESRECIBIDOS { get; set; }
        public virtual CAJAINGRESO1 CAJAINGRESO { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual TIPOFORMACOBRO TIPOFORMACOBRO { get; set; }
        public virtual ICollection<CAJANOTACREDITO> CAJANOTACREDITOes { get; set; }
        public virtual ICollection<CAJATARJETA> CAJATARJETAS { get; set; }
    }
}
