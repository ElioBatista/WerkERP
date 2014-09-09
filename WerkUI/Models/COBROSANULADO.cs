using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class COBROSANULADO
    {
        public decimal CODCOBROSANULADOS { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public decimal MON_CODMONEDA { get; set; }
        public Nullable<decimal> MONEDARECIBO { get; set; }
        public Nullable<decimal> CODCOMPROBANTE { get; set; }
        public Nullable<decimal> CODCOBRADOR { get; set; }
        public Nullable<decimal> CODCLIENTE { get; set; }
        public decimal CODFORCOBRO { get; set; }
        public string NUMCOMPROBANTE { get; set; }
        public Nullable<byte> TIPCOBRO { get; set; }
        public Nullable<decimal> IMPORTECOBRO { get; set; }
        public Nullable<decimal> SALDOCOBRO { get; set; }
        public Nullable<System.DateTime> FECHACOBRO { get; set; }
        public Nullable<decimal> TOTALDESCUENTO { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<decimal> COTIZACION1MR { get; set; }
        public Nullable<decimal> COTIZACION2MR { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> VUELTOMR { get; set; }
        public Nullable<System.DateTime> FECHAPROCESO { get; set; }
        public Nullable<decimal> IMPORTERECIBO { get; set; }
        public Nullable<decimal> SALDORECIBO { get; set; }
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual COBRADOR COBRADOR { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual MONEDA MONEDA1 { get; set; }
        public virtual MONEDA MONEDA2 { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual TIPOCOMPROBANTE TIPOCOMPROBANTE { get; set; }
        public virtual TIPOFORMACOBRO TIPOFORMACOBRO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
