using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class CONCOMPRA
    {
        public CONCOMPRA()
        {
            this.ACTIVOFIJOes = new List<ACTIVOFIJO>();
            this.COMPRAS = new List<COMPRA>();
            this.CONCOMPRASDETALLEs = new List<CONCOMPRASDETALLE>();
            this.MagicIVAs = new List<MagicIVA>();
        }

        public decimal CODCONCOMPRA { get; set; }
        public Nullable<decimal> CODCOMPROBANTE { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public Nullable<decimal> CODIVA { get; set; }
        public Nullable<decimal> CODCENTRO { get; set; }
        public Nullable<decimal> CODASIENTO { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODPROVEEDOR { get; set; }
        public string NUMCOMPRA { get; set; }
        public Nullable<decimal> CUENTAH { get; set; }
        public Nullable<decimal> CUENTAD { get; set; }
        public Nullable<decimal> CUENTAI { get; set; }
        public string COMENTARIOD { get; set; }
        public string COMENTARIOH { get; set; }
        public string NUMCOMPROBANTE { get; set; }
        public Nullable<System.DateTime> FECCOMPROBANTE { get; set; }
        public Nullable<byte> TIPOIVA { get; set; }
        public Nullable<decimal> IMPORTEEXENTA { get; set; }
        public Nullable<decimal> PORCENTAJEIVA { get; set; }
        public Nullable<decimal> COHEFICIENTE { get; set; }
        public Nullable<decimal> IMPORTERETENCION { get; set; }
        public Nullable<decimal> IMPORTEGRABADA { get; set; }
        public Nullable<decimal> IMPORTEIVA { get; set; }
        public Nullable<decimal> IMPORTEBASEIMPO { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<byte> ACCION { get; set; }
        public Nullable<decimal> CODTIPOGASTO { get; set; }
        public Nullable<decimal> CODTIPOGASTODET { get; set; }
        public Nullable<byte> LIBRO { get; set; }
        public Nullable<decimal> CODCOMPRA { get; set; }
        public Nullable<decimal> IMPORTERETENCIONRENTA { get; set; }
        public virtual ICollection<ACTIVOFIJO> ACTIVOFIJOes { get; set; }
        public virtual ASIENTO ASIENTO { get; set; }
        public virtual CENTROCOSTO CENTROCOSTO { get; set; }
        public virtual ICollection<COMPRA> COMPRAS { get; set; }
        public virtual COMPRA COMPRA { get; set; }
        public virtual IVA IVA { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual PLANCUENTA PLANCUENTA { get; set; }
        public virtual PLANCUENTA PLANCUENTA1 { get; set; }
        public virtual PLANCUENTA PLANCUENTA2 { get; set; }
        public virtual PROVEEDOR PROVEEDOR { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual TIPOCOMPROBANTE TIPOCOMPROBANTE { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual TIPOGASTODET TIPOGASTODET { get; set; }
        public virtual ICollection<CONCOMPRASDETALLE> CONCOMPRASDETALLEs { get; set; }
        public virtual ICollection<MagicIVA> MagicIVAs { get; set; }
    }
}
