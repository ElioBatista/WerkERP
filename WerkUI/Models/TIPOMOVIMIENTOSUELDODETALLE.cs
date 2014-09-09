using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class TIPOMOVIMIENTOSUELDODETALLE
    {
        public TIPOMOVIMIENTOSUELDODETALLE()
        {
            this.CONCEPTOTIPOMOVIMIENTOS = new List<CONCEPTOTIPOMOVIMIENTO>();
        }

        public decimal CODTIPOMOVDET { get; set; }
        public decimal CODTIPOMOV { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public virtual ICollection<CONCEPTOTIPOMOVIMIENTO> CONCEPTOTIPOMOVIMIENTOS { get; set; }
        public virtual TIPOMOVIMIENTOSUELDO TIPOMOVIMIENTOSUELDO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
