using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class PRECIO
    {
        public decimal CODTIPOCLIENTE { get; set; }
        public decimal CODSUCURSAL { get; set; }
        public decimal CODPRIORIDAD { get; set; }
        public decimal CODPRODUCTO { get; set; }
        public decimal CODMONEDA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public decimal CODEMPRESA { get; set; }
        public Nullable<decimal> PRECIOVENTA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual PRECIOPRIORIDAD PRECIOPRIORIDAD { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual TIPOCLIENTE TIPOCLIENTE { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
