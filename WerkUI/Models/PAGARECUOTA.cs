using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class PAGARECUOTA
    {
        public PAGARECUOTA()
        {
            this.FACTURAAFECTADA2 = new List<FACTURAAFECTADA2>();
            this.PAGAREFACTURAs = new List<PAGAREFACTURA>();
        }

        public decimal CODPAGARE { get; set; }
        public decimal NUMEROCUOTA { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public Nullable<decimal> SALDO { get; set; }
        public Nullable<System.DateTime> FECVENCIMIENTO { get; set; }
        public virtual ICollection<FACTURAAFECTADA2> FACTURAAFECTADA2 { get; set; }
        public virtual PAGARE PAGARE { get; set; }
        public virtual ICollection<PAGAREFACTURA> PAGAREFACTURAs { get; set; }
    }
}
