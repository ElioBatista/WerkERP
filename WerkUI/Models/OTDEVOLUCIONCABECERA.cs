using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class OTDEVOLUCIONCABECERA
    {
        public OTDEVOLUCIONCABECERA()
        {
            this.OTDEVOLUCIONDETALLEs = new List<OTDEVOLUCIONDETALLE>();
        }

        public decimal CODOTDEVOLUCION { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public Nullable<decimal> CODCOMPROBANTE { get; set; }
        public Nullable<decimal> CODOTPEDIDO { get; set; }
        public Nullable<decimal> NUMOTDEVOLUCION { get; set; }
        public Nullable<System.DateTime> FECHAMOVIMIENTO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual TIPOCOMPROBANTE TIPOCOMPROBANTE { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<OTDEVOLUCIONDETALLE> OTDEVOLUCIONDETALLEs { get; set; }
    }
}
