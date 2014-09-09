using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class COMPRASFORMAPAGO
    {
        public COMPRASFORMAPAGO()
        {
            this.COMPRASCHEQUESEMITIDOS = new List<COMPRASCHEQUESEMITIDO>();
            this.COMPRASNOTACREDITOes = new List<COMPRASNOTACREDITO>();
            this.COMPRASTARJETAS = new List<COMPRASTARJETA>();
        }

        public decimal CODPAGO { get; set; }
        public decimal CODCOMPRA { get; set; }
        public decimal CODTIPOPAGO { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public virtual COMPRA COMPRA { get; set; }
        public virtual ICollection<COMPRASCHEQUESEMITIDO> COMPRASCHEQUESEMITIDOS { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual TIPOPAGO TIPOPAGO { get; set; }
        public virtual ICollection<COMPRASNOTACREDITO> COMPRASNOTACREDITOes { get; set; }
        public virtual ICollection<COMPRASTARJETA> COMPRASTARJETAS { get; set; }
    }
}
