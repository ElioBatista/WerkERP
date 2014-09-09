using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class ANEXOI
    {
        public ANEXOI()
        {
            this.HACIENDAs = new List<HACIENDA>();
        }

        public decimal CODANEXOI { get; set; }
        public Nullable<decimal> CODPLANCUENTA { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual PLANCUENTA PLANCUENTA { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<HACIENDA> HACIENDAs { get; set; }
    }
}
