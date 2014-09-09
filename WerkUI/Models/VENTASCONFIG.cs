using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class VENTASCONFIG
    {
        public decimal CODCONFIG { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> VENCIMIENTOFACTURA { get; set; }
        public Nullable<decimal> PORCIENTODESCUENTO { get; set; }
        public Nullable<byte> CONTROLLIMITE { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<byte> MODIFICAPRECIO { get; set; }
        public Nullable<byte> STOCKNEGATIVO { get; set; }
        public Nullable<decimal> SIMCARD { get; set; }
        public Nullable<decimal> TARJETAS { get; set; }
        public Nullable<decimal> ESN { get; set; }
        public Nullable<decimal> CLIENTE { get; set; }
        public Nullable<decimal> CARGAEXPRES { get; set; }
        public Nullable<decimal> MANOOBRA { get; set; }
        public Nullable<decimal> RANGOCOMPROBANTE { get; set; }
        public Nullable<decimal> RANGOTICKET { get; set; }
        public Nullable<decimal> PRODUCTODESCUENTO { get; set; }
        public virtual CLIENTE CLIENTE1 { get; set; }
        public virtual LINEA LINEA { get; set; }
        public virtual LINEA LINEA1 { get; set; }
        public virtual LINEA LINEA2 { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
    }
}
