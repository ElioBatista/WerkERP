using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class COBRANZA
    {
        public COBRANZA()
        {
            this.APLICACIONRECIBOes = new List<APLICACIONRECIBO>();
            this.CAJAFACTURASCREDITOes = new List<CAJAFACTURASCREDITO>();
            this.CAJAINGRESOes = new List<CAJAINGRESO>();
            this.CHEQUERECIBIDOes = new List<CHEQUERECIBIDO>();
            this.COBRODIs = new List<COBRODI>();
            this.DEFINIDOS = new List<DEFINIDO>();
            this.FACTURAAFECTADA2 = new List<FACTURAAFECTADA2>();
            this.FACTURAAFECTADAs = new List<FACTURAAFECTADA>();
            this.MOVIASIENTOMOVIs = new List<MOVIASIENTOMOVI>();
            this.NOTACREDITOes = new List<NOTACREDITO>();
            this.TARJETAs = new List<TARJETA>();
            this.COBRORETENCIONs = new List<COBRORETENCION>();
        }

        public decimal CODCOBRANZA { get; set; }
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
        public Nullable<decimal> CODCREDITO { get; set; }
        public string OBSERVACION { get; set; }
        public virtual ICollection<APLICACIONRECIBO> APLICACIONRECIBOes { get; set; }
        public virtual ICollection<CAJAFACTURASCREDITO> CAJAFACTURASCREDITOes { get; set; }
        public virtual ICollection<CAJAINGRESO> CAJAINGRESOes { get; set; }
        public virtual ICollection<CHEQUERECIBIDO> CHEQUERECIBIDOes { get; set; }
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual COBRADOR COBRADOR { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual MONEDA MONEDA1 { get; set; }
        public virtual MONEDA MONEDA2 { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual TIPOCOMPROBANTE TIPOCOMPROBANTE { get; set; }
        public virtual TIPOFORMACOBRO TIPOFORMACOBRO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<COBRODI> COBRODIs { get; set; }
        public virtual CREDITO CREDITO { get; set; }
        public virtual ICollection<DEFINIDO> DEFINIDOS { get; set; }
        public virtual ICollection<FACTURAAFECTADA2> FACTURAAFECTADA2 { get; set; }
        public virtual ICollection<FACTURAAFECTADA> FACTURAAFECTADAs { get; set; }
        public virtual ICollection<MOVIASIENTOMOVI> MOVIASIENTOMOVIs { get; set; }
        public virtual ICollection<NOTACREDITO> NOTACREDITOes { get; set; }
        public virtual ICollection<TARJETA> TARJETAs { get; set; }
        public virtual ICollection<COBRORETENCION> COBRORETENCIONs { get; set; }
    }
}
