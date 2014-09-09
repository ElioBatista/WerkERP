using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class TRANSFERENCIASDETALLE
    {
        public TRANSFERENCIASDETALLE()
        {
            this.TRANSFERENCIASDETALLERANGOS = new List<TRANSFERENCIASDETALLERANGO>();
            this.TRANSFERENCIASUBDETALLEs = new List<TRANSFERENCIASUBDETALLE>();
        }

        public decimal CODTRANSFERENCIA { get; set; }
        public decimal CODPRODUCTO { get; set; }
        public Nullable<decimal> CANTIDADTRANFERENCIA { get; set; }
        public Nullable<decimal> COSTOPROMEDIO { get; set; }
        public Nullable<decimal> COSTOULTIMO { get; set; }
        public decimal LINEANUMERO { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
        public virtual TRANFERENCIA TRANFERENCIA { get; set; }
        public virtual ICollection<TRANSFERENCIASDETALLERANGO> TRANSFERENCIASDETALLERANGOS { get; set; }
        public virtual ICollection<TRANSFERENCIASUBDETALLE> TRANSFERENCIASUBDETALLEs { get; set; }
    }
}
