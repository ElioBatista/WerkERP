using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class REVALUO
    {
        public decimal CODREVALUO { get; set; }
        public Nullable<decimal> CODACTIVO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> CODASIENTO { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public Nullable<decimal> CODASIDEP { get; set; }
        public Nullable<decimal> RAVALUOANTERIOR { get; set; }
        public Nullable<decimal> DEPRECIAACUMULADA { get; set; }
        public Nullable<decimal> COHEFICIENTE { get; set; }
        public Nullable<decimal> VALORREVALUO { get; set; }
        public Nullable<decimal> MONTOEJERCICIO { get; set; }
        public Nullable<decimal> DIFERENCIA { get; set; }
        public Nullable<decimal> CUOTADEPRE { get; set; }
        public Nullable<decimal> DEPREACU { get; set; }
        public Nullable<decimal> NETO { get; set; }
        public Nullable<decimal> DEPREACUANTERIOR { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public string INICIO { get; set; }
        public string FIN { get; set; }
        public Nullable<byte> ACCION { get; set; }
        public virtual ACTIVOFIJO ACTIVOFIJO { get; set; }
        public virtual ASIENTO ASIENTO { get; set; }
        public virtual ASIENTO ASIENTO1 { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
