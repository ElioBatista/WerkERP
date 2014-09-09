using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class SUCURSAL
    {
        public SUCURSAL()
        {
            this.ACTIVOFIJOes = new List<ACTIVOFIJO>();
            this.AJUSTEs = new List<AJUSTE>();
            this.ANEXOIs = new List<ANEXOI>();
            this.ANEXOIIs = new List<ANEXOII>();
            this.ANEXOIIIs = new List<ANEXOIII>();
            this.ANEXOIVs = new List<ANEXOIV>();
            this.ASIENTOS = new List<ASIENTO>();
            this.ASIENTOSELIs = new List<ASIENTOSELI>();
            this.CAJAs = new List<CAJA>();
            this.CENTROCOSTOes = new List<CENTROCOSTO>();
            this.CHEQUEEMITIDOes = new List<CHEQUEEMITIDO>();
            this.CHEQUERECIBIDOes = new List<CHEQUERECIBIDO>();
            this.CIERRETICKETs = new List<CIERRETICKET>();
            this.CLIENTES = new List<CLIENTE>();
            this.COBRANZAS = new List<COBRANZA>();
            this.COBRORETENCIONs = new List<COBRORETENCION>();
            this.COBROSANULADOS = new List<COBROSANULADO>();
            this.COMPRAS = new List<COMPRA>();
            this.COMPRASRECEPCIONs = new List<COMPRASRECEPCION>();
            this.CONCOMPRAS = new List<CONCOMPRA>();
            this.CONPARAMETROes = new List<CONPARAMETRO>();
            this.CONVENTAS = new List<CONVENTA>();
            this.CUPONES = new List<CUPONE>();
            this.DETCAJAs = new List<DETCAJA>();
            this.DEVOLUCIONs = new List<DEVOLUCION>();
            this.EQUIPOS = new List<EQUIPOS>();
            this.EQUIPOSSTOCKs = new List<EQUIPOSSTOCK>();
            this.F800 = new List<F800>();
            this.F801 = new List<F801>();
            this.F805 = new List<F805>();
            this.FLUJOEFECTIVOes = new List<FLUJOEFECTIVO>();
            this.HACIENDAs = new List<HACIENDA>();
            this.INVENTARIOs = new List<INVENTARIO>();
            this.INVENTARIODIFERENCIAs = new List<INVENTARIODIFERENCIA>();
            this.MOVIASIENTOes = new List<MOVIASIENTO>();
            this.NCREDITOes = new List<NCREDITO>();
            this.NDEBITOes = new List<NDEBITO>();
            this.NUMERORECIBOes = new List<NUMERORECIBO>();
            this.ORDENCOMPRAs = new List<ORDENCOMPRA>();
            this.ORDENCOMPRAPROVEEDORs = new List<ORDENCOMPRAPROVEEDOR>();
            this.ORDENPAGOes = new List<ORDENPAGO>();
            this.ORDENPRODUCCIONCABECERAs = new List<ORDENPRODUCCIONCABECERA>();
            this.OTCABECERAs = new List<OTCABECERA>();
            this.OTDEVOLUCIONCABECERAs = new List<OTDEVOLUCIONCABECERA>();
            this.OTPEDIDOCABECERAs = new List<OTPEDIDOCABECERA>();
            this.PAGANZAS = new List<PAGANZA>();
            this.PAGAREs = new List<PAGARE>();
            this.PAGONOTACREDITOes = new List<PAGONOTACREDITO>();
            this.PAGORETENCIONs = new List<PAGORETENCION>();
            this.PCs = new List<PC>();
            this.PLANCUENTAS = new List<PLANCUENTA>();
            this.PRECIOs = new List<PRECIO>();
            this.PRESUPUESTOes = new List<PRESUPUESTO>();
            this.PRESUPUESTOVENTAS = new List<PRESUPUESTOVENTA>();
            this.PRODUCCIONINGRESOPRODUCTOes = new List<PRODUCCIONINGRESOPRODUCTO>();
            this.PRODUCTOSUCURSALs = new List<PRODUCTOSUCURSAL>();
            this.REVALUOs = new List<REVALUO>();
            this.SIMCARDs = new List<SIMCARD>();
            this.SIMCCARDSTOCKs = new List<SIMCCARDSTOCK>();
            this.SUCURSALLIMITEPRODs = new List<SUCURSALLIMITEPROD>();
            this.SUPERVISORVENTAs = new List<SUPERVISORVENTA>();
            this.TIPOASIENTOes = new List<TIPOASIENTO>();
            this.TPies = new List<TPY>();
            this.TPYSTOCKs = new List<TPYSTOCK>();
            this.TRANFERENCIAs = new List<TRANFERENCIA>();
            this.VARPATRIMONIOs = new List<VARPATRIMONIO>();
            this.VENDEDORs = new List<VENDEDOR>();
            this.VENDEDORs1 = new List<VENDEDOR>();
            this.VENTAS = new List<VENTA>();
            this.VENTASDETALLEs = new List<VENTASDETALLE>();
            this.VENTASENTREGAs = new List<VENTASENTREGA>();
            this.ZONAs = new List<ZONA>();
        }

        public decimal CODSUCURSAL { get; set; }
        public Nullable<decimal> CODZONA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMSUCURSAL { get; set; }
        public string DESSUCURSAL { get; set; }
        public string DIRECCION { get; set; }
        public string TELEFONO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<ACTIVOFIJO> ACTIVOFIJOes { get; set; }
        public virtual ICollection<AJUSTE> AJUSTEs { get; set; }
        public virtual ICollection<ANEXOI> ANEXOIs { get; set; }
        public virtual ICollection<ANEXOII> ANEXOIIs { get; set; }
        public virtual ICollection<ANEXOIII> ANEXOIIIs { get; set; }
        public virtual ICollection<ANEXOIV> ANEXOIVs { get; set; }
        public virtual ICollection<ASIENTO> ASIENTOS { get; set; }
        public virtual ICollection<ASIENTOSELI> ASIENTOSELIs { get; set; }
        public virtual ICollection<CAJA> CAJAs { get; set; }
        public virtual ICollection<CENTROCOSTO> CENTROCOSTOes { get; set; }
        public virtual ICollection<CHEQUEEMITIDO> CHEQUEEMITIDOes { get; set; }
        public virtual ICollection<CHEQUERECIBIDO> CHEQUERECIBIDOes { get; set; }
        public virtual ICollection<CIERRETICKET> CIERRETICKETs { get; set; }
        public virtual ICollection<CLIENTE> CLIENTES { get; set; }
        public virtual ICollection<COBRANZA> COBRANZAS { get; set; }
        public virtual ICollection<COBRORETENCION> COBRORETENCIONs { get; set; }
        public virtual ICollection<COBROSANULADO> COBROSANULADOS { get; set; }
        public virtual ICollection<COMPRA> COMPRAS { get; set; }
        public virtual ICollection<COMPRASRECEPCION> COMPRASRECEPCIONs { get; set; }
        public virtual ICollection<CONCOMPRA> CONCOMPRAS { get; set; }
        public virtual ICollection<CONPARAMETRO> CONPARAMETROes { get; set; }
        public virtual ICollection<CONVENTA> CONVENTAS { get; set; }
        public virtual ICollection<CUPONE> CUPONES { get; set; }
        public virtual ICollection<DETCAJA> DETCAJAs { get; set; }
        public virtual ICollection<DEVOLUCION> DEVOLUCIONs { get; set; }
        public virtual ICollection<EQUIPOS> EQUIPOS { get; set; }
        public virtual ICollection<EQUIPOSSTOCK> EQUIPOSSTOCKs { get; set; }
        public virtual ICollection<F800> F800 { get; set; }
        public virtual ICollection<F801> F801 { get; set; }
        public virtual ICollection<F805> F805 { get; set; }
        public virtual ICollection<FLUJOEFECTIVO> FLUJOEFECTIVOes { get; set; }
        public virtual ICollection<HACIENDA> HACIENDAs { get; set; }
        public virtual ICollection<INVENTARIO> INVENTARIOs { get; set; }
        public virtual ICollection<INVENTARIODIFERENCIA> INVENTARIODIFERENCIAs { get; set; }
        public virtual ICollection<MOVIASIENTO> MOVIASIENTOes { get; set; }
        public virtual ICollection<NCREDITO> NCREDITOes { get; set; }
        public virtual ICollection<NDEBITO> NDEBITOes { get; set; }
        public virtual ICollection<NUMERORECIBO> NUMERORECIBOes { get; set; }
        public virtual ICollection<ORDENCOMPRA> ORDENCOMPRAs { get; set; }
        public virtual ICollection<ORDENCOMPRAPROVEEDOR> ORDENCOMPRAPROVEEDORs { get; set; }
        public virtual ICollection<ORDENPAGO> ORDENPAGOes { get; set; }
        public virtual ICollection<ORDENPRODUCCIONCABECERA> ORDENPRODUCCIONCABECERAs { get; set; }
        public virtual ICollection<OTCABECERA> OTCABECERAs { get; set; }
        public virtual ICollection<OTDEVOLUCIONCABECERA> OTDEVOLUCIONCABECERAs { get; set; }
        public virtual ICollection<OTPEDIDOCABECERA> OTPEDIDOCABECERAs { get; set; }
        public virtual ICollection<PAGANZA> PAGANZAS { get; set; }
        public virtual ICollection<PAGARE> PAGAREs { get; set; }
        public virtual ICollection<PAGONOTACREDITO> PAGONOTACREDITOes { get; set; }
        public virtual ICollection<PAGORETENCION> PAGORETENCIONs { get; set; }
        public virtual ICollection<PC> PCs { get; set; }
        public virtual ICollection<PLANCUENTA> PLANCUENTAS { get; set; }
        public virtual ICollection<PRECIO> PRECIOs { get; set; }
        public virtual ICollection<PRESUPUESTO> PRESUPUESTOes { get; set; }
        public virtual ICollection<PRESUPUESTOVENTA> PRESUPUESTOVENTAS { get; set; }
        public virtual ICollection<PRODUCCIONINGRESOPRODUCTO> PRODUCCIONINGRESOPRODUCTOes { get; set; }
        public virtual ICollection<PRODUCTOSUCURSAL> PRODUCTOSUCURSALs { get; set; }
        public virtual ICollection<REVALUO> REVALUOs { get; set; }
        public virtual ICollection<SIMCARD> SIMCARDs { get; set; }
        public virtual ICollection<SIMCCARDSTOCK> SIMCCARDSTOCKs { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ZONA ZONA { get; set; }
        public virtual ICollection<SUCURSALLIMITEPROD> SUCURSALLIMITEPRODs { get; set; }
        public virtual ICollection<SUPERVISORVENTA> SUPERVISORVENTAs { get; set; }
        public virtual ICollection<TIPOASIENTO> TIPOASIENTOes { get; set; }
        public virtual ICollection<TPY> TPies { get; set; }
        public virtual ICollection<TPYSTOCK> TPYSTOCKs { get; set; }
        public virtual ICollection<TRANFERENCIA> TRANFERENCIAs { get; set; }
        public virtual ICollection<VARPATRIMONIO> VARPATRIMONIOs { get; set; }
        public virtual ICollection<VENDEDOR> VENDEDORs { get; set; }
        public virtual ICollection<VENDEDOR> VENDEDORs1 { get; set; }
        public virtual ICollection<VENTA> VENTAS { get; set; }
        public virtual ICollection<VENTASDETALLE> VENTASDETALLEs { get; set; }
        public virtual ICollection<VENTASENTREGA> VENTASENTREGAs { get; set; }
        public virtual ICollection<ZONA> ZONAs { get; set; }
    }
}
