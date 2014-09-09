using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class EQUIPOS
    {
        public decimal CODEQUIPO { get; set; }
        public Nullable<decimal> CODCOMPRA { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public Nullable<decimal> CODPRODUCTO { get; set; }
        public string ESN { get; set; }
        public Nullable<decimal> CANTIDAD { get; set; }
        public Nullable<byte> ESTADO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<System.DateTime> FECHACOMPRA { get; set; }
        public virtual COMPRA COMPRA { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
