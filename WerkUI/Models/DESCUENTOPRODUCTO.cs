using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class DESCUENTOPRODUCTO
    {
        public DESCUENTOPRODUCTO()
        {
            this.DESCUENTOCLIENTEPRODUCTOes = new List<DESCUENTOCLIENTEPRODUCTO>();
            this.PRODUCTOS = new List<PRODUCTO>();
        }

        public decimal CODDESCUENTO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMDESCUENTO { get; set; }
        public Nullable<decimal> PORCENTAJEDESCUENTO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<DESCUENTOCLIENTEPRODUCTO> DESCUENTOCLIENTEPRODUCTOes { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<PRODUCTO> PRODUCTOS { get; set; }
    }
}
