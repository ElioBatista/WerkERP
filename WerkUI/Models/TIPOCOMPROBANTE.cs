using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class TIPOCOMPROBANTE
    {
        public TIPOCOMPROBANTE()
        {
            this.ACTIVOFIJOes = new List<ACTIVOFIJO>();
            this.AJUSTEs = new List<AJUSTE>();
            this.CAJANOTACREDITOes = new List<CAJANOTACREDITO>();
            this.CHEQUERAs = new List<CHEQUERA>();
            this.COBRANZAS = new List<COBRANZA>();
            this.COBROSANULADOS = new List<COBROSANULADO>();
            this.COMPRAS1 = new List<COMPRA>();
            this.COMPRASNOTACREDITOes = new List<COMPRASNOTACREDITO>();
            this.COMPRASRECEPCIONs = new List<COMPRASRECEPCION>();
            this.CONCOMPRAS1 = new List<CONCOMPRA>();
            this.CONVENTAS1 = new List<CONVENTA>();
            this.DETPCs = new List<DETPC>();
            this.DEVOLUCIONs = new List<DEVOLUCION>();
            this.DOCUMENTOSDEVUELTOS = new List<DOCUMENTOSDEVUELTO>();
            this.DOCUMENTOSDEVUELTOS1 = new List<DOCUMENTOSDEVUELTO>();
            this.DOCUMENTOSENTREGADOS = new List<DOCUMENTOSENTREGADO>();
            this.INVENTARIOs = new List<INVENTARIO>();
            this.NCREDITOes = new List<NCREDITO>();
            this.NDEBITOes = new List<NDEBITO>();
            this.NOTACREDITOes = new List<NOTACREDITO>();
            this.NUMERORECIBOes = new List<NUMERORECIBO>();
            this.ORDENCOMPRAs = new List<ORDENCOMPRA>();
            this.ORDENCOMPRAPROVEEDORs = new List<ORDENCOMPRAPROVEEDOR>();
            this.ORDENPAGOCLIENTEs = new List<ORDENPAGOCLIENTE>();
            this.ORDENPRODUCCIONCABECERAs = new List<ORDENPRODUCCIONCABECERA>();
            this.OTCABECERAs = new List<OTCABECERA>();
            this.OTDEVOLUCIONCABECERAs = new List<OTDEVOLUCIONCABECERA>();
            this.OTPEDIDOCABECERAs = new List<OTPEDIDOCABECERA>();
            this.PAGANZAS = new List<PAGANZA>();
            this.PAGAREs = new List<PAGARE>();
            this.PAGONOTACREDITOes = new List<PAGONOTACREDITO>();
            this.PRESUPUESTOVENTAS = new List<PRESUPUESTOVENTA>();
            this.PRODUCCIONINGRESOPRODUCTOes = new List<PRODUCCIONINGRESOPRODUCTO>();
            this.TRANFERENCIAs = new List<TRANFERENCIA>();
            this.VENTAS1 = new List<VENTA>();
        }

        public decimal CODCOMPROBANTE { get; set; }
        public Nullable<decimal> CODPLANCUENTA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMTIPOCOMPRO { get; set; }
        public string DESCOMPROBANTE { get; set; }
        public Nullable<byte> COMPRAS { get; set; }
        public Nullable<byte> VENTAS { get; set; }
        public Nullable<byte> COBROS { get; set; }
        public Nullable<byte> PAGOS { get; set; }
        public Nullable<byte> INVENTARIO { get; set; }
        public Nullable<byte> CONVENTAS { get; set; }
        public Nullable<byte> CONCOMPRAS { get; set; }
        public Nullable<byte> NCREDITO { get; set; }
        public Nullable<byte> NDEBITO { get; set; }
        public Nullable<byte> OTROS { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<ACTIVOFIJO> ACTIVOFIJOes { get; set; }
        public virtual ICollection<AJUSTE> AJUSTEs { get; set; }
        public virtual ICollection<CAJANOTACREDITO> CAJANOTACREDITOes { get; set; }
        public virtual ICollection<CHEQUERA> CHEQUERAs { get; set; }
        public virtual ICollection<COBRANZA> COBRANZAS { get; set; }
        public virtual ICollection<COBROSANULADO> COBROSANULADOS { get; set; }
        public virtual ICollection<COMPRA> COMPRAS1 { get; set; }
        public virtual ICollection<COMPRASNOTACREDITO> COMPRASNOTACREDITOes { get; set; }
        public virtual ICollection<COMPRASRECEPCION> COMPRASRECEPCIONs { get; set; }
        public virtual ICollection<CONCOMPRA> CONCOMPRAS1 { get; set; }
        public virtual ICollection<CONVENTA> CONVENTAS1 { get; set; }
        public virtual ICollection<DETPC> DETPCs { get; set; }
        public virtual ICollection<DEVOLUCION> DEVOLUCIONs { get; set; }
        public virtual ICollection<DOCUMENTOSDEVUELTO> DOCUMENTOSDEVUELTOS { get; set; }
        public virtual ICollection<DOCUMENTOSDEVUELTO> DOCUMENTOSDEVUELTOS1 { get; set; }
        public virtual ICollection<DOCUMENTOSENTREGADO> DOCUMENTOSENTREGADOS { get; set; }
        public virtual ICollection<INVENTARIO> INVENTARIOs { get; set; }
        public virtual ICollection<NCREDITO> NCREDITOes { get; set; }
        public virtual ICollection<NDEBITO> NDEBITOes { get; set; }
        public virtual ICollection<NOTACREDITO> NOTACREDITOes { get; set; }
        public virtual ICollection<NUMERORECIBO> NUMERORECIBOes { get; set; }
        public virtual ICollection<ORDENCOMPRA> ORDENCOMPRAs { get; set; }
        public virtual ICollection<ORDENCOMPRAPROVEEDOR> ORDENCOMPRAPROVEEDORs { get; set; }
        public virtual ICollection<ORDENPAGOCLIENTE> ORDENPAGOCLIENTEs { get; set; }
        public virtual ICollection<ORDENPRODUCCIONCABECERA> ORDENPRODUCCIONCABECERAs { get; set; }
        public virtual ICollection<OTCABECERA> OTCABECERAs { get; set; }
        public virtual ICollection<OTDEVOLUCIONCABECERA> OTDEVOLUCIONCABECERAs { get; set; }
        public virtual ICollection<OTPEDIDOCABECERA> OTPEDIDOCABECERAs { get; set; }
        public virtual ICollection<PAGANZA> PAGANZAS { get; set; }
        public virtual ICollection<PAGARE> PAGAREs { get; set; }
        public virtual ICollection<PAGONOTACREDITO> PAGONOTACREDITOes { get; set; }
        public virtual PLANCUENTA PLANCUENTA { get; set; }
        public virtual ICollection<PRESUPUESTOVENTA> PRESUPUESTOVENTAS { get; set; }
        public virtual ICollection<PRODUCCIONINGRESOPRODUCTO> PRODUCCIONINGRESOPRODUCTOes { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<TRANFERENCIA> TRANFERENCIAs { get; set; }
        public virtual ICollection<VENTA> VENTAS1 { get; set; }
    }
}
