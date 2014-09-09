using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class PLANCUENTA
    {
        public PLANCUENTA()
        {
            this.ACTIVOFIJOes = new List<ACTIVOFIJO>();
            this.ACTIVOFIJOes1 = new List<ACTIVOFIJO>();
            this.ANEXOIs = new List<ANEXOI>();
            this.ANEXOIIs = new List<ANEXOII>();
            this.ANEXOIIIs = new List<ANEXOIII>();
            this.ANEXOIVs = new List<ANEXOIV>();
            this.CAJAs = new List<CAJA>();
            this.CLIENTES = new List<CLIENTE>();
            this.COMPRAS = new List<COMPRA>();
            this.COMPRAS1 = new List<COMPRA>();
            this.CONCOMPRAS = new List<CONCOMPRA>();
            this.CONCOMPRAS1 = new List<CONCOMPRA>();
            this.CONCOMPRAS2 = new List<CONCOMPRA>();
            this.CONCOMPRASDETALLEs = new List<CONCOMPRASDETALLE>();
            this.CONFIGURACIONs = new List<CONFIGURACION>();
            this.CONFIGURACIONs1 = new List<CONFIGURACION>();
            this.CONPARAMETROes = new List<CONPARAMETRO>();
            this.CONPARAMETROes1 = new List<CONPARAMETRO>();
            this.CONPARAMETROes2 = new List<CONPARAMETRO>();
            this.CONPARAMETROes3 = new List<CONPARAMETRO>();
            this.CONPARAMETROes4 = new List<CONPARAMETRO>();
            this.CONPARAMETROes5 = new List<CONPARAMETRO>();
            this.CONPARAMETROes6 = new List<CONPARAMETRO>();
            this.CONPARAMETROes7 = new List<CONPARAMETRO>();
            this.CONPARAMETROes8 = new List<CONPARAMETRO>();
            this.CONPARAMETROes9 = new List<CONPARAMETRO>();
            this.CONPARAMETROes10 = new List<CONPARAMETRO>();
            this.CONPARAMETROes11 = new List<CONPARAMETRO>();
            this.CONPARAMETROes12 = new List<CONPARAMETRO>();
            this.CONPARAMETROes13 = new List<CONPARAMETRO>();
            this.CONVENTAS = new List<CONVENTA>();
            this.CONVENTAS1 = new List<CONVENTA>();
            this.CONVENTAS2 = new List<CONVENTA>();
            this.CONVENTASDETALLEs = new List<CONVENTASDETALLE>();
            this.CUENTABANCARIAs = new List<CUENTABANCARIA>();
            this.DEBEHABERs = new List<DEBEHABER>();
            this.DETASIENTOes = new List<DETASIENTO>();
            this.DETASIENTOELIs = new List<DETASIENTOELI>();
            this.DETNOTACONCEPTOes = new List<DETNOTACONCEPTO>();
            this.EMISORAs = new List<EMISORA>();
            this.ESTADOCHEQUEs = new List<ESTADOCHEQUE>();
            this.FLUJOEFECTIVOes = new List<FLUJOEFECTIVO>();
            this.IVAs = new List<IVA>();
            this.IVAs1 = new List<IVA>();
            this.MOVIASIENTODETs = new List<MOVIASIENTODET>();
            this.PRODUCTOS = new List<PRODUCTO>();
            this.PRODUCTOS1 = new List<PRODUCTO>();
            this.PRODUCTOS2 = new List<PRODUCTO>();
            this.PROVEEDORs = new List<PROVEEDOR>();
            this.TIPOCOMPROBANTEs = new List<TIPOCOMPROBANTE>();
            this.TIPOCREDITOes = new List<TIPOCREDITO>();
            this.TIPODEBITOes = new List<TIPODEBITO>();
            this.TIPOEGRESOes = new List<TIPOEGRESO>();
            this.TIPOFORMACOBROes = new List<TIPOFORMACOBRO>();
            this.TIPOGASTODETs = new List<TIPOGASTODET>();
            this.TIPOPAGOes = new List<TIPOPAGO>();
            this.TIPORETENCIONs = new List<TIPORETENCION>();
            this.VARPATRIMONIOs = new List<VARPATRIMONIO>();
            this.TIPOMOVIMIENTOSUELDOes = new List<TIPOMOVIMIENTOSUELDO>();
        }

        public decimal CODPLANCUENTA { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> NUMPLANCUENTA { get; set; }
        public string DESPLANCUENTA { get; set; }
        public Nullable<decimal> TIPOCUENTA { get; set; }
        public Nullable<byte> ASENTABLE { get; set; }
        public Nullable<decimal> NIVELCUENTA { get; set; }
        public Nullable<decimal> SUBCUENTA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public string DESSUBCUENTA { get; set; }
        public virtual ICollection<ACTIVOFIJO> ACTIVOFIJOes { get; set; }
        public virtual ICollection<ACTIVOFIJO> ACTIVOFIJOes1 { get; set; }
        public virtual ICollection<ANEXOI> ANEXOIs { get; set; }
        public virtual ICollection<ANEXOII> ANEXOIIs { get; set; }
        public virtual ICollection<ANEXOIII> ANEXOIIIs { get; set; }
        public virtual ICollection<ANEXOIV> ANEXOIVs { get; set; }
        public virtual ICollection<CAJA> CAJAs { get; set; }
        public virtual ICollection<CLIENTE> CLIENTES { get; set; }
        public virtual ICollection<COMPRA> COMPRAS { get; set; }
        public virtual ICollection<COMPRA> COMPRAS1 { get; set; }
        public virtual ICollection<CONCOMPRA> CONCOMPRAS { get; set; }
        public virtual ICollection<CONCOMPRA> CONCOMPRAS1 { get; set; }
        public virtual ICollection<CONCOMPRA> CONCOMPRAS2 { get; set; }
        public virtual ICollection<CONCOMPRASDETALLE> CONCOMPRASDETALLEs { get; set; }
        public virtual ICollection<CONFIGURACION> CONFIGURACIONs { get; set; }
        public virtual ICollection<CONFIGURACION> CONFIGURACIONs1 { get; set; }
        public virtual ICollection<CONPARAMETRO> CONPARAMETROes { get; set; }
        public virtual ICollection<CONPARAMETRO> CONPARAMETROes1 { get; set; }
        public virtual ICollection<CONPARAMETRO> CONPARAMETROes2 { get; set; }
        public virtual ICollection<CONPARAMETRO> CONPARAMETROes3 { get; set; }
        public virtual ICollection<CONPARAMETRO> CONPARAMETROes4 { get; set; }
        public virtual ICollection<CONPARAMETRO> CONPARAMETROes5 { get; set; }
        public virtual ICollection<CONPARAMETRO> CONPARAMETROes6 { get; set; }
        public virtual ICollection<CONPARAMETRO> CONPARAMETROes7 { get; set; }
        public virtual ICollection<CONPARAMETRO> CONPARAMETROes8 { get; set; }
        public virtual ICollection<CONPARAMETRO> CONPARAMETROes9 { get; set; }
        public virtual ICollection<CONPARAMETRO> CONPARAMETROes10 { get; set; }
        public virtual ICollection<CONPARAMETRO> CONPARAMETROes11 { get; set; }
        public virtual ICollection<CONPARAMETRO> CONPARAMETROes12 { get; set; }
        public virtual ICollection<CONPARAMETRO> CONPARAMETROes13 { get; set; }
        public virtual ICollection<CONVENTA> CONVENTAS { get; set; }
        public virtual ICollection<CONVENTA> CONVENTAS1 { get; set; }
        public virtual ICollection<CONVENTA> CONVENTAS2 { get; set; }
        public virtual ICollection<CONVENTASDETALLE> CONVENTASDETALLEs { get; set; }
        public virtual ICollection<CUENTABANCARIA> CUENTABANCARIAs { get; set; }
        public virtual ICollection<DEBEHABER> DEBEHABERs { get; set; }
        public virtual ICollection<DETASIENTO> DETASIENTOes { get; set; }
        public virtual ICollection<DETASIENTOELI> DETASIENTOELIs { get; set; }
        public virtual ICollection<DETNOTACONCEPTO> DETNOTACONCEPTOes { get; set; }
        public virtual ICollection<EMISORA> EMISORAs { get; set; }
        public virtual ICollection<ESTADOCHEQUE> ESTADOCHEQUEs { get; set; }
        public virtual ICollection<FLUJOEFECTIVO> FLUJOEFECTIVOes { get; set; }
        public virtual ICollection<IVA> IVAs { get; set; }
        public virtual ICollection<IVA> IVAs1 { get; set; }
        public virtual ICollection<MOVIASIENTODET> MOVIASIENTODETs { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<PRODUCTO> PRODUCTOS { get; set; }
        public virtual ICollection<PRODUCTO> PRODUCTOS1 { get; set; }
        public virtual ICollection<PRODUCTO> PRODUCTOS2 { get; set; }
        public virtual ICollection<PROVEEDOR> PROVEEDORs { get; set; }
        public virtual ICollection<TIPOCOMPROBANTE> TIPOCOMPROBANTEs { get; set; }
        public virtual ICollection<TIPOCREDITO> TIPOCREDITOes { get; set; }
        public virtual ICollection<TIPODEBITO> TIPODEBITOes { get; set; }
        public virtual ICollection<TIPOEGRESO> TIPOEGRESOes { get; set; }
        public virtual ICollection<TIPOFORMACOBRO> TIPOFORMACOBROes { get; set; }
        public virtual ICollection<TIPOGASTODET> TIPOGASTODETs { get; set; }
        public virtual ICollection<TIPOPAGO> TIPOPAGOes { get; set; }
        public virtual ICollection<TIPORETENCION> TIPORETENCIONs { get; set; }
        public virtual ICollection<VARPATRIMONIO> VARPATRIMONIOs { get; set; }
        public virtual ICollection<TIPOMOVIMIENTOSUELDO> TIPOMOVIMIENTOSUELDOes { get; set; }
    }
}
