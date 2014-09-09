using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class PAGOERETENNC
    {
        public decimal CODAFECTADA { get; set; }
        public Nullable<decimal> CODCOMPRA { get; set; }
        public Nullable<decimal> CODNCREDITO { get; set; }
        public Nullable<decimal> CODRETEN { get; set; }
        public virtual COMPRA COMPRA { get; set; }
        public virtual PAGONOTACREDITO PAGONOTACREDITO { get; set; }
        public virtual PAGORETENCION PAGORETENCION { get; set; }
    }
}
