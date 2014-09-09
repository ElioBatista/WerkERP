using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class PAGOTIPORETEN
    {
        public PAGOTIPORETEN()
        {
            this.PAGORETENFACTURAs = new List<PAGORETENFACTURA>();
        }

        public decimal CODRETEN { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public decimal CODTIPORETEN { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public Nullable<decimal> PORCENTAJE { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual PAGORETENCION PAGORETENCION { get; set; }
        public virtual ICollection<PAGORETENFACTURA> PAGORETENFACTURAs { get; set; }
        public virtual TIPORETENCION TIPORETENCION { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
