using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class INVENTARIODIFERENCIA
    {
        public decimal CODDIFERENCIA { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public Nullable<decimal> CODPRODUCTO { get; set; }
        public Nullable<System.DateTime> FECHACIERRE { get; set; }
        public Nullable<decimal> CANTIDADENCONTRADA { get; set; }
        public Nullable<decimal> STOCKACTUAL { get; set; }
        public Nullable<decimal> COSTOPPALCIERRE { get; set; }
        public Nullable<byte> TIPOINVENTARIO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
