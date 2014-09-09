using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class ORDENCOMPRAPROVEEDORDETALLE
    {
        public decimal CODORDENCOMPRA { get; set; }
        public decimal CODLINEA { get; set; }
        public string DESCRIPCION { get; set; }
        public Nullable<decimal> COSTO { get; set; }
        public Nullable<decimal> CANTIDAD { get; set; }
        public string OBSERVACION { get; set; }
        public Nullable<decimal> CODIVA { get; set; }
        public Nullable<decimal> PORCENTAJEIVA { get; set; }
        public virtual IVA IVA { get; set; }
        public virtual ORDENCOMPRAPROVEEDOR ORDENCOMPRAPROVEEDOR { get; set; }
    }
}
