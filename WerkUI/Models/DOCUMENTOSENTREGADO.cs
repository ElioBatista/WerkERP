using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class DOCUMENTOSENTREGADO
    {
        public decimal CODCOMPROBANTE { get; set; }
        public decimal NUMEROPLANILLA { get; set; }
        public decimal CODVENTA { get; set; }
        public Nullable<decimal> CODCOBRADOR { get; set; }
        public Nullable<System.DateTime> FECHAPLANILLA { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public string RENDIDO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual COBRADOR COBRADOR { get; set; }
        public virtual TIPOCOMPROBANTE TIPOCOMPROBANTE { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual VENTA VENTA { get; set; }
    }
}
