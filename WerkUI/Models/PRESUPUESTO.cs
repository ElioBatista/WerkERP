using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class PRESUPUESTO
    {
        public decimal CODPRESUPUESTO { get; set; }
        public decimal CODANHO { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> MES1 { get; set; }
        public Nullable<decimal> MES2 { get; set; }
        public Nullable<decimal> MES3 { get; set; }
        public Nullable<decimal> MES4 { get; set; }
        public Nullable<decimal> MES5 { get; set; }
        public Nullable<decimal> MES6 { get; set; }
        public Nullable<decimal> MES7 { get; set; }
        public Nullable<decimal> MES8 { get; set; }
        public Nullable<decimal> MES9 { get; set; }
        public Nullable<decimal> MES10 { get; set; }
        public Nullable<decimal> MES11 { get; set; }
        public Nullable<decimal> MES12 { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
