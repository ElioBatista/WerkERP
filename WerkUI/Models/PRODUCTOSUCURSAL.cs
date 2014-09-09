using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class PRODUCTOSUCURSAL
    {
        public decimal CODPRODUCTO { get; set; }
        public decimal CODSUCURSAL { get; set; }
        public Nullable<decimal> CANTIDAD { get; set; }
        public Nullable<decimal> STOCKINICIAL { get; set; }
        public Nullable<System.DateTime> ULTIMOINVENTARIO { get; set; }
        public string UBICACION { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> COSTOPPALCIERRE { get; set; }
        public Nullable<decimal> CANTIDADLIMITE { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
    }
}
