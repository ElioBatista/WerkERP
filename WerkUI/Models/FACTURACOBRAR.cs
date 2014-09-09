using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class FACTURACOBRAR
    {
        public FACTURACOBRAR()
        {
            this.FACTURAAFECTADAs = new List<FACTURAAFECTADA>();
            this.PAGAREFACTURAs = new List<PAGAREFACTURA>();
        }

        public decimal CODNUMEROCUOTA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public decimal CODVENTA { get; set; }
        public Nullable<System.DateTime> FECHAVCTO { get; set; }
        public Nullable<decimal> SALDOCUOTA { get; set; }
        public Nullable<decimal> IMPORTECUOTA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<FACTURAAFECTADA> FACTURAAFECTADAs { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual VENTA VENTA { get; set; }
        public virtual ICollection<PAGAREFACTURA> PAGAREFACTURAs { get; set; }
    }
}
