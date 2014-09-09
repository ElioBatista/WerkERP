using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class PAGANZA
    {
        public PAGANZA()
        {
            this.APLICACIONRECIBOPAGOes = new List<APLICACIONRECIBOPAGO>();
            this.CHEQUEEMITIDOes = new List<CHEQUEEMITIDO>();
            this.FACTURAPAGOAFECTADAs = new List<FACTURAPAGOAFECTADA>();
            this.MOVIASIENTOMOVIs = new List<MOVIASIENTOMOVI>();
            this.PAGONOTACREDITOes = new List<PAGONOTACREDITO>();
            this.PAGORETENCIONs = new List<PAGORETENCION>();
        }

        public decimal CODPAGANZAS { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public decimal CODTIPOPAGO { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public decimal MON_CODMONEDA { get; set; }
        public Nullable<decimal> CODCOMPROBANTE { get; set; }
        public Nullable<decimal> TOTALDESCUENTO { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public Nullable<System.DateTime> FECHAPAGO { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public string NUMCOMPROBANTE { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> VUELTOMR { get; set; }
        public Nullable<decimal> CODPROVEEDOR { get; set; }
        public Nullable<byte> TIPPAGO { get; set; }
        public Nullable<decimal> COTIZACION1MR { get; set; }
        public Nullable<decimal> COTIZACION2MR { get; set; }
        public Nullable<decimal> SALDO { get; set; }
        public Nullable<decimal> IMPORTERECIBO { get; set; }
        public Nullable<decimal> SALDORECIBO { get; set; }
        public virtual ICollection<APLICACIONRECIBOPAGO> APLICACIONRECIBOPAGOes { get; set; }
        public virtual ICollection<CHEQUEEMITIDO> CHEQUEEMITIDOes { get; set; }
        public virtual ICollection<FACTURAPAGOAFECTADA> FACTURAPAGOAFECTADAs { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual MONEDA MONEDA1 { get; set; }
        public virtual ICollection<MOVIASIENTOMOVI> MOVIASIENTOMOVIs { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual TIPOCOMPROBANTE TIPOCOMPROBANTE { get; set; }
        public virtual TIPOPAGO TIPOPAGO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<PAGONOTACREDITO> PAGONOTACREDITOes { get; set; }
        public virtual PROVEEDOR PROVEEDOR { get; set; }
        public virtual ICollection<PAGORETENCION> PAGORETENCIONs { get; set; }
    }
}
