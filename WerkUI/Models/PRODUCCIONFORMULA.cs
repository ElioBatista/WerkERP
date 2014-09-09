using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class PRODUCCIONFORMULA
    {
        public PRODUCCIONFORMULA()
        {
            this.PRODUCCIONFORMULADETALLEs = new List<PRODUCCIONFORMULADETALLE>();
        }

        public decimal CODFORMULA { get; set; }
        public Nullable<decimal> CODPRODUCTOTERMINADO { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<PRODUCCIONFORMULADETALLE> PRODUCCIONFORMULADETALLEs { get; set; }
    }
}
