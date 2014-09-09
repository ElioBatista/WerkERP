using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class PRODUCTO
    {
        public PRODUCTO()
        {
            this.AJUSTEDETALLEs = new List<AJUSTEDETALLE>();
            this.COMPRASDETALLEs = new List<COMPRASDETALLE>();
            this.COMPRASORDENCOMPRAs = new List<COMPRASORDENCOMPRA>();
            this.COMPRASRECEPCIONDETALLEs = new List<COMPRASRECEPCIONDETALLE>();
            this.DESCUENTOCLIENTEPRODUCTOes = new List<DESCUENTOCLIENTEPRODUCTO>();
            this.DEVOLUCIONDETALLEs = new List<DEVOLUCIONDETALLE>();
            this.EQUIPOS = new List<EQUIPOS>();
            this.EQUIPOSSTOCKs = new List<EQUIPOSSTOCK>();
            this.INVENTARIODETALLEs = new List<INVENTARIODETALLE>();
            this.INVENTARIODIFERENCIAs = new List<INVENTARIODIFERENCIA>();
            this.KITS = new List<KIT>();
            this.ORDENCOMPRADETALLEs = new List<ORDENCOMPRADETALLE>();
            this.ORDENPRODUCCIONDETALLEs = new List<ORDENPRODUCCIONDETALLE>();
            this.ORDENPRODUCCIONDETMPRIMAs = new List<ORDENPRODUCCIONDETMPRIMA>();
            this.OTDEVOLUCIONDETALLEs = new List<OTDEVOLUCIONDETALLE>();
            this.OTPEDIDODETALLEs = new List<OTPEDIDODETALLE>();
            this.PRECIOs = new List<PRECIO>();
            this.PRESUPUESTOVENTASDETALLEs = new List<PRESUPUESTOVENTASDETALLE>();
            this.PRODUCCIONFORMULAs = new List<PRODUCCIONFORMULA>();
            this.PRODUCCIONFORMULADETALLEs = new List<PRODUCCIONFORMULADETALLE>();
            this.PRODUCCIONINGRESOPRODUCTODETs = new List<PRODUCCIONINGRESOPRODUCTODET>();
            this.PRODUCTOSUCURSALs = new List<PRODUCTOSUCURSAL>();
            this.SIMCARDs = new List<SIMCARD>();
            this.SIMCCARDSTOCKs = new List<SIMCCARDSTOCK>();
            this.SUCURSALLIMITEPRODs = new List<SUCURSALLIMITEPROD>();
            this.TPies = new List<TPY>();
            this.TPYSTOCKs = new List<TPYSTOCK>();
            this.TRANSFERENCIASDETALLEs = new List<TRANSFERENCIASDETALLE>();
            this.VENTASCONFIGs = new List<VENTASCONFIG>();
            this.VENTASDETALLEs = new List<VENTASDETALLE>();
        }

        public decimal CODPRODUCTO { get; set; }
        public Nullable<decimal> CODRUBRO { get; set; }
        public Nullable<decimal> CODFAMILIA { get; set; }
        public Nullable<decimal> CODLINEA { get; set; }
        public string NUMCOLOR { get; set; }
        public Nullable<decimal> COL_CODEMPRESA { get; set; }
        public string NUMTALLE { get; set; }
        public Nullable<decimal> TAL_CODEMPRESA { get; set; }
        public Nullable<decimal> CODIVA { get; set; }
        public Nullable<decimal> CODMEDIDA { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> CODESTADOPRODUCTO { get; set; }
        public Nullable<decimal> CUENTAMERCADERIA { get; set; }
        public Nullable<decimal> CUENTAVENTA { get; set; }
        public Nullable<decimal> CUENTACOSTO { get; set; }
        public Nullable<decimal> CODDESCUENTO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODPROVEEDOR { get; set; }
        public string DESPRODUCTO { get; set; }
        public string CODIGOBARRA { get; set; }
        public Nullable<decimal> COSTOANTERIOR { get; set; }
        public Nullable<decimal> STOCKMINIMO { get; set; }
        public Nullable<decimal> STOCKMAXIMO { get; set; }
        public Nullable<System.DateTime> FECHAINGRESO { get; set; }
        public string CODIGOORIGINAL { get; set; }
        public Nullable<byte> PRODUCTOACTIVO { get; set; }
        public Nullable<decimal> ULTIMOCOSTO { get; set; }
        public Nullable<decimal> PORCENCOMI { get; set; }
        public byte[] IMAGEN { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> COSTOPP { get; set; }
        public Nullable<System.DateTime> FECHAPP { get; set; }
        public Nullable<decimal> USUPP { get; set; }
        public Nullable<decimal> ORDPRE { get; set; }
        public Nullable<decimal> EMPREUSUPP { get; set; }
        public virtual ICollection<AJUSTEDETALLE> AJUSTEDETALLEs { get; set; }
        public virtual COLOR COLOR { get; set; }
        public virtual ICollection<COMPRASDETALLE> COMPRASDETALLEs { get; set; }
        public virtual ICollection<COMPRASORDENCOMPRA> COMPRASORDENCOMPRAs { get; set; }
        public virtual ICollection<COMPRASRECEPCIONDETALLE> COMPRASRECEPCIONDETALLEs { get; set; }
        public virtual ICollection<DESCUENTOCLIENTEPRODUCTO> DESCUENTOCLIENTEPRODUCTOes { get; set; }
        public virtual DESCUENTOPRODUCTO DESCUENTOPRODUCTO { get; set; }
        public virtual ICollection<DEVOLUCIONDETALLE> DEVOLUCIONDETALLEs { get; set; }
        public virtual ICollection<EQUIPOS> EQUIPOS { get; set; }
        public virtual ICollection<EQUIPOSSTOCK> EQUIPOSSTOCKs { get; set; }
        public virtual ESTADOPRODUCTO ESTADOPRODUCTO { get; set; }
        public virtual FAMILIA FAMILIA { get; set; }
        public virtual ICollection<INVENTARIODETALLE> INVENTARIODETALLEs { get; set; }
        public virtual ICollection<INVENTARIODIFERENCIA> INVENTARIODIFERENCIAs { get; set; }
        public virtual IVA IVA { get; set; }
        public virtual ICollection<KIT> KITS { get; set; }
        public virtual LINEA LINEA { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual ICollection<ORDENCOMPRADETALLE> ORDENCOMPRADETALLEs { get; set; }
        public virtual ICollection<ORDENPRODUCCIONDETALLE> ORDENPRODUCCIONDETALLEs { get; set; }
        public virtual ICollection<ORDENPRODUCCIONDETMPRIMA> ORDENPRODUCCIONDETMPRIMAs { get; set; }
        public virtual ICollection<OTDEVOLUCIONDETALLE> OTDEVOLUCIONDETALLEs { get; set; }
        public virtual ICollection<OTPEDIDODETALLE> OTPEDIDODETALLEs { get; set; }
        public virtual PLANCUENTA PLANCUENTA { get; set; }
        public virtual PLANCUENTA PLANCUENTA1 { get; set; }
        public virtual PLANCUENTA PLANCUENTA2 { get; set; }
        public virtual ICollection<PRECIO> PRECIOs { get; set; }
        public virtual ICollection<PRESUPUESTOVENTASDETALLE> PRESUPUESTOVENTASDETALLEs { get; set; }
        public virtual ICollection<PRODUCCIONFORMULA> PRODUCCIONFORMULAs { get; set; }
        public virtual ICollection<PRODUCCIONFORMULADETALLE> PRODUCCIONFORMULADETALLEs { get; set; }
        public virtual ICollection<PRODUCCIONINGRESOPRODUCTODET> PRODUCCIONINGRESOPRODUCTODETs { get; set; }
        public virtual ICollection<PRODUCTOSUCURSAL> PRODUCTOSUCURSALs { get; set; }
        public virtual RUBRO RUBRO { get; set; }
        public virtual TALLE TALLE { get; set; }
        public virtual UNIDADMEDIDA UNIDADMEDIDA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual PROVEEDOR PROVEEDOR { get; set; }
        public virtual USUARIO USUARIO1 { get; set; }
        public virtual ICollection<SIMCARD> SIMCARDs { get; set; }
        public virtual ICollection<SIMCCARDSTOCK> SIMCCARDSTOCKs { get; set; }
        public virtual ICollection<SUCURSALLIMITEPROD> SUCURSALLIMITEPRODs { get; set; }
        public virtual ICollection<TPY> TPies { get; set; }
        public virtual ICollection<TPYSTOCK> TPYSTOCKs { get; set; }
        public virtual ICollection<TRANSFERENCIASDETALLE> TRANSFERENCIASDETALLEs { get; set; }
        public virtual ICollection<VENTASCONFIG> VENTASCONFIGs { get; set; }
        public virtual ICollection<VENTASDETALLE> VENTASDETALLEs { get; set; }
    }
}
