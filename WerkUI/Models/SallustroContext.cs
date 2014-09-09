using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using WerkUI.Models.Mapping;

namespace WerkUI.Models
{
    public class SallustroContext : DbContext
    {
        static SallustroContext()
        {
            Database.SetInitializer<SallustroContext>(null);
        }

		public SallustroContext()
			: base("Name=SallustroContext")
		{
		}

        public DbSet<ACTIVOFIJO> ACTIVOFIJOes { get; set; }
        public DbSet<Adecuacion> Adecuacions { get; set; }
        public DbSet<ADJUNTO> ADJUNTOes { get; set; }
        public DbSet<ADUANA> ADUANAs { get; set; }
        public DbSet<AJUSTE> AJUSTEs { get; set; }
        public DbSet<AJUSTEDETALLE> AJUSTEDETALLEs { get; set; }
        public DbSet<AJUSTEDETALLERANGO> AJUSTEDETALLERANGOS { get; set; }
        public DbSet<AJUSTESUBDETALLE> AJUSTESUBDETALLEs { get; set; }
        public DbSet<ANEXOI> ANEXOIs { get; set; }
        public DbSet<ANEXOII> ANEXOIIs { get; set; }
        public DbSet<ANEXOIII> ANEXOIIIs { get; set; }
        public DbSet<ANEXOIV> ANEXOIVs { get; set; }
        public DbSet<APLICACIONRECIBO> APLICACIONRECIBOes { get; set; }
        public DbSet<APLICACIONRECIBOPAGO> APLICACIONRECIBOPAGOes { get; set; }
        public DbSet<ASIENTO> ASIENTOS { get; set; }
        public DbSet<ASIENTOSELI> ASIENTOSELIs { get; set; }
        public DbSet<AUDITORIAMOVIMIENTO> AUDITORIAMOVIMIENTOS { get; set; }
        public DbSet<AUDITORIATABLA> AUDITORIATABLAS { get; set; }
        public DbSet<AUTORIZACION> AUTORIZACIONs { get; set; }
        public DbSet<BANCO> BANCOes { get; set; }
        public DbSet<BILLETE> BILLETES { get; set; }
        public DbSet<BULTO> BULTOes { get; set; }
        public DbSet<CAJA> CAJAs { get; set; }
        public DbSet<CAJACHEQUESRECIBIDO> CAJACHEQUESRECIBIDOS { get; set; }
        public DbSet<CAJACIERRE> CAJACIERREs { get; set; }
        public DbSet<CAJAEGRESO> CAJAEGRESOS { get; set; }
        public DbSet<CAJAFACTURASCREDITO> CAJAFACTURASCREDITOes { get; set; }
        public DbSet<CAJAFORMACOBRO> CAJAFORMACOBROes { get; set; }
        public DbSet<CAJAINGRESO> CAJAINGRESOes { get; set; }
        public DbSet<CAJAINGRESO1> CAJAINGRESOS { get; set; }
        public DbSet<CAJANOTACREDITO> CAJANOTACREDITOes { get; set; }
        public DbSet<CAJASALDO> CAJASALDOes { get; set; }
        public DbSet<CAJATARJETA> CAJATARJETAS { get; set; }
        public DbSet<CARGO> CARGOes { get; set; }
        public DbSet<CARGOCONTACTO> CARGOCONTACTOes { get; set; }
        public DbSet<CATEGORIA> CATEGORIAs { get; set; }
        public DbSet<CENTROCOSTO> CENTROCOSTOes { get; set; }
        public DbSet<CHEQUEEMITIDO> CHEQUEEMITIDOes { get; set; }
        public DbSet<CHEQUERA> CHEQUERAs { get; set; }
        public DbSet<CHEQUERECIBIDO> CHEQUERECIBIDOes { get; set; }
        public DbSet<CHOFERE> CHOFERES { get; set; }
        public DbSet<CIERRETICKET> CIERRETICKETs { get; set; }
        public DbSet<CIRCUITO> CIRCUITOes { get; set; }
        public DbSet<CIRCUITODIA> CIRCUITODIAS { get; set; }
        public DbSet<CIRCUITORUTA> CIRCUITORUTAs { get; set; }
        public DbSet<CIRCUITOVISITA> CIRCUITOVISITAS { get; set; }
        public DbSet<CIUDAD> CIUDADs { get; set; }
        public DbSet<CLASE> CLASEs { get; set; }
        public DbSet<CLIENTE> CLIENTES { get; set; }
        public DbSet<COBRADOR> COBRADORs { get; set; }
        public DbSet<COBRANZA> COBRANZAS { get; set; }
        public DbSet<COBRODI> COBRODIs { get; set; }
        public DbSet<COBRORETENCION> COBRORETENCIONs { get; set; }
        public DbSet<COBROSANULADO> COBROSANULADOS { get; set; }
        public DbSet<COBROSCUPONE> COBROSCUPONES { get; set; }
        public DbSet<COBROTIPORETEN> COBROTIPORETENs { get; set; }
        public DbSet<CODEUDORE> CODEUDORES { get; set; }
        public DbSet<COLOR> COLORs { get; set; }
        public DbSet<COMPRA> COMPRAS { get; set; }
        public DbSet<COMPRASCHEQUESEMITIDO> COMPRASCHEQUESEMITIDOS { get; set; }
        public DbSet<COMPRASDETALLE> COMPRASDETALLEs { get; set; }
        public DbSet<COMPRASDETALLERANGO> COMPRASDETALLERANGOS { get; set; }
        public DbSet<COMPRASFORMAPAGO> COMPRASFORMAPAGOes { get; set; }
        public DbSet<COMPRASGASTO> COMPRASGASTOS { get; set; }
        public DbSet<COMPRASNOTACREDITO> COMPRASNOTACREDITOes { get; set; }
        public DbSet<COMPRASORDENCOMPRA> COMPRASORDENCOMPRAs { get; set; }
        public DbSet<COMPRASRECEPCION> COMPRASRECEPCIONs { get; set; }
        public DbSet<COMPRASRECEPCIONDETALLE> COMPRASRECEPCIONDETALLEs { get; set; }
        public DbSet<COMPRASTARJETA> COMPRASTARJETAS { get; set; }
        public DbSet<CONCEPTO> CONCEPTOes { get; set; }
        public DbSet<CONCEPTOSLIQUIDACION> CONCEPTOSLIQUIDACIONs { get; set; }
        public DbSet<CONCEPTOTIPOMOVIMIENTO> CONCEPTOTIPOMOVIMIENTOS { get; set; }
        public DbSet<CONCOMPRA> CONCOMPRAS { get; set; }
        public DbSet<CONCOMPRASDETALLE> CONCOMPRASDETALLEs { get; set; }
        public DbSet<CONFIGURACION> CONFIGURACIONs { get; set; }
        public DbSet<CONOCIMIENTO> CONOCIMIENTOes { get; set; }
        public DbSet<CONPARAMETRO> CONPARAMETROes { get; set; }
        public DbSet<CONVENTA> CONVENTAS { get; set; }
        public DbSet<CONVENTASDETALLE> CONVENTASDETALLEs { get; set; }
        public DbSet<COTIZACION> COTIZACIONs { get; set; }
        public DbSet<CREDITORECIBIDO> CREDITORECIBIDOes { get; set; }
        public DbSet<CREDITO> CREDITOS { get; set; }
        public DbSet<CUENTABANCARIA> CUENTABANCARIAs { get; set; }
        public DbSet<CUPONE> CUPONES { get; set; }
        public DbSet<DEBEHABER> DEBEHABERs { get; set; }
        public DbSet<DEBITO> DEBITOS { get; set; }
        public DbSet<DEFINIDO> DEFINIDOS { get; set; }
        public DbSet<DEPARTAMENTO> DEPARTAMENTOes { get; set; }
        public DbSet<DEPARTAMENTOEMPRESA> DEPARTAMENTOEMPRESAs { get; set; }
        public DbSet<DEPOSITADO> DEPOSITADOes { get; set; }
        public DbSet<DEPOSITOCUPON> DEPOSITOCUPONs { get; set; }
        public DbSet<DEPRECIACION> DEPRECIACIONs { get; set; }
        public DbSet<DESCUENTOCLIENTEPRODUCTO> DESCUENTOCLIENTEPRODUCTOes { get; set; }
        public DbSet<DESCUENTOPRODUCTO> DESCUENTOPRODUCTOes { get; set; }
        public DbSet<DESGLOSEBILLETE> DESGLOSEBILLETEs { get; set; }
        public DbSet<DESGLOSEBILLETEDET> DESGLOSEBILLETEDETs { get; set; }
        public DbSet<DESPACHANTE> DESPACHANTEs { get; set; }
        public DbSet<DESPACHO> DESPACHOes { get; set; }
        public DbSet<DESPACHODETALLE> DESPACHODETALLEs { get; set; }
        public DbSet<DESPACHOINTERNO> DESPACHOINTERNOes { get; set; }
        public DbSet<DESPACHOTEXTO> DESPACHOTEXTOes { get; set; }
        public DbSet<Det2Adecuacion> Det2Adecuacion { get; set; }
        public DbSet<DetAdecuacion> DetAdecuacions { get; set; }
        public DbSet<DETASIENTO> DETASIENTOes { get; set; }
        public DbSet<DETASIENTOELI> DETASIENTOELIs { get; set; }
        public DbSet<DETCAJA> DETCAJAs { get; set; }
        public DbSet<DETNCREDITO> DETNCREDITOes { get; set; }
        public DbSet<DETNDEBITO> DETNDEBITOes { get; set; }
        public DbSet<DETNOTACONCEPTO> DETNOTACONCEPTOes { get; set; }
        public DbSet<DETPC> DETPCs { get; set; }
        public DbSet<DEVOLUCION> DEVOLUCIONs { get; set; }
        public DbSet<DEVOLUCIONDETALLE> DEVOLUCIONDETALLEs { get; set; }
        public DbSet<DEVOLUCIONSUBDETALLE> DEVOLUCIONSUBDETALLEs { get; set; }
        public DbSet<DIASEMISORA> DIASEMISORAs { get; set; }
        public DbSet<DIASHABILESPORME> DIASHABILESPORMES { get; set; }
        public DbSet<DIVISIONEMPRESA> DIVISIONEMPRESAs { get; set; }
        public DbSet<DOCUMENTO> DOCUMENTOS { get; set; }
        public DbSet<DOCUMENTOSDEVUELTO> DOCUMENTOSDEVUELTOS { get; set; }
        public DbSet<DOCUMENTOSENTREGADO> DOCUMENTOSENTREGADOS { get; set; }
        public DbSet<dtproperty> dtproperties { get; set; }
        public DbSet<EJECUTIVOCTA> EJECUTIVOCTAs { get; set; }
        public DbSet<EMISORA> EMISORAs { get; set; }
        public DbSet<EMPLEADO> EMPLEADOes { get; set; }
        public DbSet<EMPRESA> EMPRESAs { get; set; }
        public DbSet<EQUIPOS> EQUIPOS { get; set; }
        public DbSet<EQUIPOSSTOCK> EQUIPOSSTOCKs { get; set; }
        public DbSet<ESCALAVACACIONE> ESCALAVACACIONES { get; set; }
        public DbSet<ESTADOCHEQUE> ESTADOCHEQUEs { get; set; }
        public DbSet<ESTADOCIVIL> ESTADOCIVILs { get; set; }
        public DbSet<ESTADOCUPON> ESTADOCUPONs { get; set; }
        public DbSet<ESTADOPRODUCTO> ESTADOPRODUCTOes { get; set; }
        public DbSet<ESTADOREPARTO> ESTADOREPARTOes { get; set; }
        public DbSet<F800> F800 { get; set; }
        public DbSet<F801> F801 { get; set; }
        public DbSet<F805> F805 { get; set; }
        public DbSet<FACTURAAFECTADA> FACTURAAFECTADAs { get; set; }
        public DbSet<FACTURAAFECTADA2> FACTURAAFECTADA2 { get; set; }
        public DbSet<FACTURACOBRAR> FACTURACOBRARs { get; set; }
        public DbSet<FACTURAPAGAR> FACTURAPAGARs { get; set; }
        public DbSet<FACTURAPAGOAFECTADA> FACTURAPAGOAFECTADAs { get; set; }
        public DbSet<FAMILIA> FAMILIAs { get; set; }
        public DbSet<FERIADO> FERIADOS { get; set; }
        public DbSet<FLUJOEFECTIVO> FLUJOEFECTIVOes { get; set; }
        public DbSet<GASTOCOMPRA> GASTOCOMPRAs { get; set; }
        public DbSet<HACIENDA> HACIENDAs { get; set; }
        public DbSet<HIJO> HIJOS { get; set; }
        public DbSet<HORARIO> HORARIOs { get; set; }
        public DbSet<INVENTARIO> INVENTARIOs { get; set; }
        public DbSet<INVENTARIODETALLE> INVENTARIODETALLEs { get; set; }
        public DbSet<INVENTARIODIFERENCIA> INVENTARIODIFERENCIAs { get; set; }
        public DbSet<INVENTARIOSUBDETALLE> INVENTARIOSUBDETALLEs { get; set; }
        public DbSet<IVA> IVAs { get; set; }
        public DbSet<KIT> KITS { get; set; }
        public DbSet<LEGAJO> LEGAJOes { get; set; }
        public DbSet<LINEA> LINEAs { get; set; }
        public DbSet<LIQUIADJUNTO> LIQUIADJUNTOes { get; set; }
        public DbSet<LIQUIDACION> LIQUIDACIONs { get; set; }
        public DbSet<LIQUIDACIONCABECERA> LIQUIDACIONCABECERAs { get; set; }
        public DbSet<MagicIVA> MagicIVAs { get; set; }
        public DbSet<MODELO> MODELOes { get; set; }
        public DbSet<MODULO> MODULOS { get; set; }
        public DbSet<MODULOUSUARIO> MODULOUSUARIOs { get; set; }
        public DbSet<MONEDA> MONEDAs { get; set; }
        public DbSet<MOVIASIENTO> MOVIASIENTOes { get; set; }
        public DbSet<MOVIASIENTODET> MOVIASIENTODETs { get; set; }
        public DbSet<MOVIASIENTOMOVI> MOVIASIENTOMOVIs { get; set; }
        public DbSet<MOVISUELDO> MOVISUELDOes { get; set; }
        public DbSet<MOVISUELDODETALLE> MOVISUELDODETALLEs { get; set; }
        public DbSet<NACIONALIDAD> NACIONALIDADs { get; set; }
        public DbSet<NCREDITO> NCREDITOes { get; set; }
        public DbSet<NDEBITO> NDEBITOes { get; set; }
        public DbSet<NIVELESTUDIO> NIVELESTUDIOS { get; set; }
        public DbSet<NOMBRECONTACTO> NOMBRECONTACTOes { get; set; }
        public DbSet<NOMBRECONTACTO2> NOMBRECONTACTO2 { get; set; }
        public DbSet<NOTACONCEPTO> NOTACONCEPTOes { get; set; }
        public DbSet<NOTACREDITO> NOTACREDITOes { get; set; }
        public DbSet<NUMERORECIBO> NUMERORECIBOes { get; set; }
        public DbSet<ORDENCOMPRA> ORDENCOMPRAs { get; set; }
        public DbSet<ORDENCOMPRADETALLE> ORDENCOMPRADETALLEs { get; set; }
        public DbSet<ORDENCOMPRAORIGEN> ORDENCOMPRAORIGENs { get; set; }
        public DbSet<ORDENCOMPRAPROVEEDOR> ORDENCOMPRAPROVEEDORs { get; set; }
        public DbSet<ORDENCOMPRAPROVEEDORDETALLE> ORDENCOMPRAPROVEEDORDETALLEs { get; set; }
        public DbSet<ORDENCOMPRAPROVEEDORELI> ORDENCOMPRAPROVEEDORELIs { get; set; }
        public DbSet<ORDENCOMPRARESPONSABLE> ORDENCOMPRARESPONSABLEs { get; set; }
        public DbSet<ORDENPAGO> ORDENPAGOes { get; set; }
        public DbSet<ORDENPAGOAFECTADA> ORDENPAGOAFECTADAS { get; set; }
        public DbSet<ORDENPAGOCHEQUE> ORDENPAGOCHEQUEs { get; set; }
        public DbSet<ORDENPAGOCLIENTE> ORDENPAGOCLIENTEs { get; set; }
        public DbSet<ORDENPAGOCLIENTEDETALLE> ORDENPAGOCLIENTEDETALLEs { get; set; }
        public DbSet<ORDENPLANDECUENTA> ORDENPLANDECUENTAS { get; set; }
        public DbSet<ORDENPRODUCCIONCABECERA> ORDENPRODUCCIONCABECERAs { get; set; }
        public DbSet<ORDENPRODUCCIONDETALLE> ORDENPRODUCCIONDETALLEs { get; set; }
        public DbSet<ORDENPRODUCCIONDETMPRIMA> ORDENPRODUCCIONDETMPRIMAs { get; set; }
        public DbSet<OTCABECERA> OTCABECERAs { get; set; }
        public DbSet<OTDEVOLUCIONCABECERA> OTDEVOLUCIONCABECERAs { get; set; }
        public DbSet<OTDEVOLUCIONDETALLE> OTDEVOLUCIONDETALLEs { get; set; }
        public DbSet<OTMANOOBRA> OTMANOOBRAs { get; set; }
        public DbSet<OTPEDIDOCABECERA> OTPEDIDOCABECERAs { get; set; }
        public DbSet<OTPEDIDODETALLE> OTPEDIDODETALLEs { get; set; }
        public DbSet<OTPROBLEMADETALLE> OTPROBLEMADETALLEs { get; set; }
        public DbSet<OTPROBLEMASOLUCION> OTPROBLEMASOLUCIONs { get; set; }
        public DbSet<OTTECNICO> OTTECNICOes { get; set; }
        public DbSet<PAGANZA> PAGANZAS { get; set; }
        public DbSet<PAGARE> PAGAREs { get; set; }
        public DbSet<PAGARECUOTA> PAGARECUOTAS { get; set; }
        public DbSet<PAGAREFACTURA> PAGAREFACTURAs { get; set; }
        public DbSet<PAGOCHEQUE> PAGOCHEQUEs { get; set; }
        public DbSet<PAGOERETENNC> PAGOERETENNCs { get; set; }
        public DbSet<PAGONCCONCEPTO> PAGONCCONCEPTOes { get; set; }
        public DbSet<PAGONOTACREDITO> PAGONOTACREDITOes { get; set; }
        public DbSet<PAGORETENCION> PAGORETENCIONs { get; set; }
        public DbSet<PAGORETENFACTURA> PAGORETENFACTURAs { get; set; }
        public DbSet<PAGORETENNC> PAGORETENNCs { get; set; }
        public DbSet<PAGOTIPORETEN> PAGOTIPORETENs { get; set; }
        public DbSet<PAI> PAIS { get; set; }
        public DbSet<PC> PCs { get; set; }
        public DbSet<PEDIDOAJUSTE> PEDIDOAJUSTEs { get; set; }
        public DbSet<PLANCUENTA> PLANCUENTAS { get; set; }
        public DbSet<PLANE> PLANES { get; set; }
        public DbSet<PRECIO> PRECIOs { get; set; }
        public DbSet<PRECIOPRIORIDAD> PRECIOPRIORIDADs { get; set; }
        public DbSet<PRESUPUESTO> PRESUPUESTOes { get; set; }
        public DbSet<PRESUPUESTOVENTA> PRESUPUESTOVENTAS { get; set; }
        public DbSet<PRESUPUESTOVENTASDETALLE> PRESUPUESTOVENTASDETALLEs { get; set; }
        public DbSet<PROCEDENCIA> PROCEDENCIAs { get; set; }
        public DbSet<PRODUCCIONFORMULA> PRODUCCIONFORMULAs { get; set; }
        public DbSet<PRODUCCIONFORMULADETALLE> PRODUCCIONFORMULADETALLEs { get; set; }
        public DbSet<PRODUCCIONINGRESOPRODUCTO> PRODUCCIONINGRESOPRODUCTOes { get; set; }
        public DbSet<PRODUCCIONINGRESOPRODUCTODET> PRODUCCIONINGRESOPRODUCTODETs { get; set; }
        public DbSet<PRODUCTO> PRODUCTOS { get; set; }
        public DbSet<PRODUCTOSUCURSAL> PRODUCTOSUCURSALs { get; set; }
        public DbSet<PROFESION> PROFESIONs { get; set; }
        public DbSet<PROPOSITOCHEQUE> PROPOSITOCHEQUEs { get; set; }
        public DbSet<PROVEEDOR> PROVEEDORs { get; set; }
        public DbSet<REPARTO> REPARTOes { get; set; }
        public DbSet<RESPONSABLE> RESPONSABLEs { get; set; }
        public DbSet<RESPONSABLERECEPCION> RESPONSABLERECEPCIONs { get; set; }
        public DbSet<Resultado> Resultados { get; set; }
        public DbSet<RETENCION> RETENCIONs { get; set; }
        public DbSet<REVALUO> REVALUOs { get; set; }
        public DbSet<RUBRO> RUBROes { get; set; }
        public DbSet<RUBRO1> RUBRO1 { get; set; }
        public DbSet<RUTA> RUTAS { get; set; }
        public DbSet<SALARIO> SALARIOs { get; set; }
        public DbSet<SALARIOADICIONAL> SALARIOADICIONALs { get; set; }
        public DbSet<SALARIOSMINIMO> SALARIOSMINIMOS { get; set; }
        public DbSet<SEXO> SEXOes { get; set; }
        public DbSet<SIMCARD> SIMCARDs { get; set; }
        public DbSet<SIMCCARDSTOCK> SIMCCARDSTOCKs { get; set; }
        public DbSet<SISTEMA> SISTEMAS { get; set; }
        public DbSet<SUCURSAL> SUCURSALs { get; set; }
        public DbSet<SUCURSALLIMITEPROD> SUCURSALLIMITEPRODs { get; set; }
        public DbSet<SUELDOCONFIG> SUELDOCONFIGs { get; set; }
        public DbSet<SUELDOSTIPOMOVEMPLEADO> SUELDOSTIPOMOVEMPLEADOes { get; set; }
        public DbSet<SUPERVISORVENTA> SUPERVISORVENTAs { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<TALLE> TALLEs { get; set; }
        public DbSet<TARJETA> TARJETAs { get; set; }
        public DbSet<TIPOASIENTO> TIPOASIENTOes { get; set; }
        public DbSet<TIPOCHEQUE> TIPOCHEQUEs { get; set; }
        public DbSet<TIPOCLIENTE> TIPOCLIENTEs { get; set; }
        public DbSet<TIPOCOBRO> TIPOCOBROes { get; set; }
        public DbSet<TIPOCOMPROBANTE> TIPOCOMPROBANTEs { get; set; }
        public DbSet<TIPOCREDITO> TIPOCREDITOes { get; set; }
        public DbSet<TIPOCUENTA> TIPOCUENTAs { get; set; }
        public DbSet<TIPODEBITO> TIPODEBITOes { get; set; }
        public DbSet<TIPOEGRESO> TIPOEGRESOes { get; set; }
        public DbSet<TIPOFORMACOBRO> TIPOFORMACOBROes { get; set; }
        public DbSet<TIPOGASTO> TIPOGASTOes { get; set; }
        public DbSet<TIPOGASTODET> TIPOGASTODETs { get; set; }
        public DbSet<TIPOLIQUIDACION> TIPOLIQUIDACIONs { get; set; }
        public DbSet<TIPOMOVIMIENTO> TIPOMOVIMIENTOes { get; set; }
        public DbSet<TIPOMOVIMIENTOSUELDO> TIPOMOVIMIENTOSUELDOes { get; set; }
        public DbSet<TIPOMOVIMIENTOSUELDODETALLE> TIPOMOVIMIENTOSUELDODETALLEs { get; set; }
        public DbSet<TIPOPAGO> TIPOPAGOes { get; set; }
        public DbSet<TIPORETENCION> TIPORETENCIONs { get; set; }
        public DbSet<TIPOSALARIO> TIPOSALARIOs { get; set; }
        public DbSet<TIPOTARJETA> TIPOTARJETAs { get; set; }
        public DbSet<TIPOTRANSPORTE> TIPOTRANSPORTEs { get; set; }
        public DbSet<TIPOVENDEDOR> TIPOVENDEDORs { get; set; }
        public DbSet<TPY> TPies { get; set; }
        public DbSet<TPYSTOCK> TPYSTOCKs { get; set; }
        public DbSet<TRANFERENCIA> TRANFERENCIAs { get; set; }
        public DbSet<TRANSFERENCIASDETALLE> TRANSFERENCIASDETALLEs { get; set; }
        public DbSet<TRANSFERENCIASDETALLERANGO> TRANSFERENCIASDETALLERANGOS { get; set; }
        public DbSet<TRANSFERENCIASUBDETALLE> TRANSFERENCIASUBDETALLEs { get; set; }
        public DbSet<TRANSPORTE> TRANSPORTEs { get; set; }
        public DbSet<UNIDADMEDIDA> UNIDADMEDIDAs { get; set; }
        public DbSet<USUARIO> USUARIOs { get; set; }
        public DbSet<VARPATRIMONIO> VARPATRIMONIOs { get; set; }
        public DbSet<VEHICULO> VEHICULOS { get; set; }
        public DbSet<VENDEDOR> VENDEDORs { get; set; }
        public DbSet<VENTA> VENTAS { get; set; }
        public DbSet<VENTASCIERRE> VENTASCIERREs { get; set; }
        public DbSet<VENTASCONFIG> VENTASCONFIGs { get; set; }
        public DbSet<VENTASDETALLE> VENTASDETALLEs { get; set; }
        public DbSet<VENTASDETALLELIQUIDACION> VENTASDETALLELIQUIDACIONs { get; set; }
        public DbSet<VENTASDETALLERANGO> VENTASDETALLERANGOS { get; set; }
        public DbSet<VENTASENTREGA> VENTASENTREGAs { get; set; }
        public DbSet<VENTASSUBDETALLE> VENTASSUBDETALLEs { get; set; }
        public DbSet<VIDAUTIL> VIDAUTILs { get; set; }
        public DbSet<ZONA> ZONAs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ACTIVOFIJOMap());
            modelBuilder.Configurations.Add(new AdecuacionMap());
            modelBuilder.Configurations.Add(new ADJUNTOMap());
            modelBuilder.Configurations.Add(new ADUANAMap());
            modelBuilder.Configurations.Add(new AJUSTEMap());
            modelBuilder.Configurations.Add(new AJUSTEDETALLEMap());
            modelBuilder.Configurations.Add(new AJUSTEDETALLERANGOMap());
            modelBuilder.Configurations.Add(new AJUSTESUBDETALLEMap());
            modelBuilder.Configurations.Add(new ANEXOIMap());
            modelBuilder.Configurations.Add(new ANEXOIIMap());
            modelBuilder.Configurations.Add(new ANEXOIIIMap());
            modelBuilder.Configurations.Add(new ANEXOIVMap());
            modelBuilder.Configurations.Add(new APLICACIONRECIBOMap());
            modelBuilder.Configurations.Add(new APLICACIONRECIBOPAGOMap());
            modelBuilder.Configurations.Add(new ASIENTOMap());
            modelBuilder.Configurations.Add(new ASIENTOSELIMap());
            modelBuilder.Configurations.Add(new AUDITORIAMOVIMIENTOMap());
            modelBuilder.Configurations.Add(new AUDITORIATABLAMap());
            modelBuilder.Configurations.Add(new AUTORIZACIONMap());
            modelBuilder.Configurations.Add(new BANCOMap());
            modelBuilder.Configurations.Add(new BILLETEMap());
            modelBuilder.Configurations.Add(new BULTOMap());
            modelBuilder.Configurations.Add(new CAJAMap());
            modelBuilder.Configurations.Add(new CAJACHEQUESRECIBIDOMap());
            modelBuilder.Configurations.Add(new CAJACIERREMap());
            modelBuilder.Configurations.Add(new CAJAEGRESOMap());
            modelBuilder.Configurations.Add(new CAJAFACTURASCREDITOMap());
            modelBuilder.Configurations.Add(new CAJAFORMACOBROMap());
            modelBuilder.Configurations.Add(new CAJAINGRESOMap());
            modelBuilder.Configurations.Add(new CAJAINGRESO1Map());
            modelBuilder.Configurations.Add(new CAJANOTACREDITOMap());
            modelBuilder.Configurations.Add(new CAJASALDOMap());
            modelBuilder.Configurations.Add(new CAJATARJETAMap());
            modelBuilder.Configurations.Add(new CARGOMap());
            modelBuilder.Configurations.Add(new CARGOCONTACTOMap());
            modelBuilder.Configurations.Add(new CATEGORIAMap());
            modelBuilder.Configurations.Add(new CENTROCOSTOMap());
            modelBuilder.Configurations.Add(new CHEQUEEMITIDOMap());
            modelBuilder.Configurations.Add(new CHEQUERAMap());
            modelBuilder.Configurations.Add(new CHEQUERECIBIDOMap());
            modelBuilder.Configurations.Add(new CHOFEREMap());
            modelBuilder.Configurations.Add(new CIERRETICKETMap());
            modelBuilder.Configurations.Add(new CIRCUITOMap());
            modelBuilder.Configurations.Add(new CIRCUITODIAMap());
            modelBuilder.Configurations.Add(new CIRCUITORUTAMap());
            modelBuilder.Configurations.Add(new CIRCUITOVISITAMap());
            modelBuilder.Configurations.Add(new CIUDADMap());
            modelBuilder.Configurations.Add(new CLASEMap());
            modelBuilder.Configurations.Add(new CLIENTEMap());
            modelBuilder.Configurations.Add(new COBRADORMap());
            modelBuilder.Configurations.Add(new COBRANZAMap());
            modelBuilder.Configurations.Add(new COBRODIMap());
            modelBuilder.Configurations.Add(new COBRORETENCIONMap());
            modelBuilder.Configurations.Add(new COBROSANULADOMap());
            modelBuilder.Configurations.Add(new COBROSCUPONEMap());
            modelBuilder.Configurations.Add(new COBROTIPORETENMap());
            modelBuilder.Configurations.Add(new CODEUDOREMap());
            modelBuilder.Configurations.Add(new COLORMap());
            modelBuilder.Configurations.Add(new COMPRAMap());
            modelBuilder.Configurations.Add(new COMPRASCHEQUESEMITIDOMap());
            modelBuilder.Configurations.Add(new COMPRASDETALLEMap());
            modelBuilder.Configurations.Add(new COMPRASDETALLERANGOMap());
            modelBuilder.Configurations.Add(new COMPRASFORMAPAGOMap());
            modelBuilder.Configurations.Add(new COMPRASGASTOMap());
            modelBuilder.Configurations.Add(new COMPRASNOTACREDITOMap());
            modelBuilder.Configurations.Add(new COMPRASORDENCOMPRAMap());
            modelBuilder.Configurations.Add(new COMPRASRECEPCIONMap());
            modelBuilder.Configurations.Add(new COMPRASRECEPCIONDETALLEMap());
            modelBuilder.Configurations.Add(new COMPRASTARJETAMap());
            modelBuilder.Configurations.Add(new CONCEPTOMap());
            modelBuilder.Configurations.Add(new CONCEPTOSLIQUIDACIONMap());
            modelBuilder.Configurations.Add(new CONCEPTOTIPOMOVIMIENTOMap());
            modelBuilder.Configurations.Add(new CONCOMPRAMap());
            modelBuilder.Configurations.Add(new CONCOMPRASDETALLEMap());
            modelBuilder.Configurations.Add(new CONFIGURACIONMap());
            modelBuilder.Configurations.Add(new CONOCIMIENTOMap());
            modelBuilder.Configurations.Add(new CONPARAMETROMap());
            modelBuilder.Configurations.Add(new CONVENTAMap());
            modelBuilder.Configurations.Add(new CONVENTASDETALLEMap());
            modelBuilder.Configurations.Add(new COTIZACIONMap());
            modelBuilder.Configurations.Add(new CREDITORECIBIDOMap());
            modelBuilder.Configurations.Add(new CREDITOMap());
            modelBuilder.Configurations.Add(new CUENTABANCARIAMap());
            modelBuilder.Configurations.Add(new CUPONEMap());
            modelBuilder.Configurations.Add(new DEBEHABERMap());
            modelBuilder.Configurations.Add(new DEBITOMap());
            modelBuilder.Configurations.Add(new DEFINIDOMap());
            modelBuilder.Configurations.Add(new DEPARTAMENTOMap());
            modelBuilder.Configurations.Add(new DEPARTAMENTOEMPRESAMap());
            modelBuilder.Configurations.Add(new DEPOSITADOMap());
            modelBuilder.Configurations.Add(new DEPOSITOCUPONMap());
            modelBuilder.Configurations.Add(new DEPRECIACIONMap());
            modelBuilder.Configurations.Add(new DESCUENTOCLIENTEPRODUCTOMap());
            modelBuilder.Configurations.Add(new DESCUENTOPRODUCTOMap());
            modelBuilder.Configurations.Add(new DESGLOSEBILLETEMap());
            modelBuilder.Configurations.Add(new DESGLOSEBILLETEDETMap());
            modelBuilder.Configurations.Add(new DESPACHANTEMap());
            modelBuilder.Configurations.Add(new DESPACHOMap());
            modelBuilder.Configurations.Add(new DESPACHODETALLEMap());
            modelBuilder.Configurations.Add(new DESPACHOINTERNOMap());
            modelBuilder.Configurations.Add(new DESPACHOTEXTOMap());
            modelBuilder.Configurations.Add(new Det2AdecuacionMap());
            modelBuilder.Configurations.Add(new DetAdecuacionMap());
            modelBuilder.Configurations.Add(new DETASIENTOMap());
            modelBuilder.Configurations.Add(new DETASIENTOELIMap());
            modelBuilder.Configurations.Add(new DETCAJAMap());
            modelBuilder.Configurations.Add(new DETNCREDITOMap());
            modelBuilder.Configurations.Add(new DETNDEBITOMap());
            modelBuilder.Configurations.Add(new DETNOTACONCEPTOMap());
            modelBuilder.Configurations.Add(new DETPCMap());
            modelBuilder.Configurations.Add(new DEVOLUCIONMap());
            modelBuilder.Configurations.Add(new DEVOLUCIONDETALLEMap());
            modelBuilder.Configurations.Add(new DEVOLUCIONSUBDETALLEMap());
            modelBuilder.Configurations.Add(new DIASEMISORAMap());
            modelBuilder.Configurations.Add(new DIASHABILESPORMEMap());
            modelBuilder.Configurations.Add(new DIVISIONEMPRESAMap());
            modelBuilder.Configurations.Add(new DOCUMENTOMap());
            modelBuilder.Configurations.Add(new DOCUMENTOSDEVUELTOMap());
            modelBuilder.Configurations.Add(new DOCUMENTOSENTREGADOMap());
            modelBuilder.Configurations.Add(new dtpropertyMap());
            modelBuilder.Configurations.Add(new EJECUTIVOCTAMap());
            modelBuilder.Configurations.Add(new EMISORAMap());
            modelBuilder.Configurations.Add(new EMPLEADOMap());
            modelBuilder.Configurations.Add(new EMPRESAMap());
            modelBuilder.Configurations.Add(new EQUIPOSMap());
            modelBuilder.Configurations.Add(new EQUIPOSSTOCKMap());
            modelBuilder.Configurations.Add(new ESCALAVACACIONEMap());
            modelBuilder.Configurations.Add(new ESTADOCHEQUEMap());
            modelBuilder.Configurations.Add(new ESTADOCIVILMap());
            modelBuilder.Configurations.Add(new ESTADOCUPONMap());
            modelBuilder.Configurations.Add(new ESTADOPRODUCTOMap());
            modelBuilder.Configurations.Add(new ESTADOREPARTOMap());
            modelBuilder.Configurations.Add(new F800Map());
            modelBuilder.Configurations.Add(new F801Map());
            modelBuilder.Configurations.Add(new F805Map());
            modelBuilder.Configurations.Add(new FACTURAAFECTADAMap());
            modelBuilder.Configurations.Add(new FACTURAAFECTADA2Map());
            modelBuilder.Configurations.Add(new FACTURACOBRARMap());
            modelBuilder.Configurations.Add(new FACTURAPAGARMap());
            modelBuilder.Configurations.Add(new FACTURAPAGOAFECTADAMap());
            modelBuilder.Configurations.Add(new FAMILIAMap());
            modelBuilder.Configurations.Add(new FERIADOMap());
            modelBuilder.Configurations.Add(new FLUJOEFECTIVOMap());
            modelBuilder.Configurations.Add(new GASTOCOMPRAMap());
            modelBuilder.Configurations.Add(new HACIENDAMap());
            modelBuilder.Configurations.Add(new HIJOMap());
            modelBuilder.Configurations.Add(new HORARIOMap());
            modelBuilder.Configurations.Add(new INVENTARIOMap());
            modelBuilder.Configurations.Add(new INVENTARIODETALLEMap());
            modelBuilder.Configurations.Add(new INVENTARIODIFERENCIAMap());
            modelBuilder.Configurations.Add(new INVENTARIOSUBDETALLEMap());
            modelBuilder.Configurations.Add(new IVAMap());
            modelBuilder.Configurations.Add(new KITMap());
            modelBuilder.Configurations.Add(new LEGAJOMap());
            modelBuilder.Configurations.Add(new LINEAMap());
            modelBuilder.Configurations.Add(new LIQUIADJUNTOMap());
            modelBuilder.Configurations.Add(new LIQUIDACIONMap());
            modelBuilder.Configurations.Add(new LIQUIDACIONCABECERAMap());
            modelBuilder.Configurations.Add(new MagicIVAMap());
            modelBuilder.Configurations.Add(new MODELOMap());
            modelBuilder.Configurations.Add(new MODULOMap());
            modelBuilder.Configurations.Add(new MODULOUSUARIOMap());
            modelBuilder.Configurations.Add(new MONEDAMap());
            modelBuilder.Configurations.Add(new MOVIASIENTOMap());
            modelBuilder.Configurations.Add(new MOVIASIENTODETMap());
            modelBuilder.Configurations.Add(new MOVIASIENTOMOVIMap());
            modelBuilder.Configurations.Add(new MOVISUELDOMap());
            modelBuilder.Configurations.Add(new MOVISUELDODETALLEMap());
            modelBuilder.Configurations.Add(new NACIONALIDADMap());
            modelBuilder.Configurations.Add(new NCREDITOMap());
            modelBuilder.Configurations.Add(new NDEBITOMap());
            modelBuilder.Configurations.Add(new NIVELESTUDIOMap());
            modelBuilder.Configurations.Add(new NOMBRECONTACTOMap());
            modelBuilder.Configurations.Add(new NOMBRECONTACTO2Map());
            modelBuilder.Configurations.Add(new NOTACONCEPTOMap());
            modelBuilder.Configurations.Add(new NOTACREDITOMap());
            modelBuilder.Configurations.Add(new NUMERORECIBOMap());
            modelBuilder.Configurations.Add(new ORDENCOMPRAMap());
            modelBuilder.Configurations.Add(new ORDENCOMPRADETALLEMap());
            modelBuilder.Configurations.Add(new ORDENCOMPRAORIGENMap());
            modelBuilder.Configurations.Add(new ORDENCOMPRAPROVEEDORMap());
            modelBuilder.Configurations.Add(new ORDENCOMPRAPROVEEDORDETALLEMap());
            modelBuilder.Configurations.Add(new ORDENCOMPRAPROVEEDORELIMap());
            modelBuilder.Configurations.Add(new ORDENCOMPRARESPONSABLEMap());
            modelBuilder.Configurations.Add(new ORDENPAGOMap());
            modelBuilder.Configurations.Add(new ORDENPAGOAFECTADAMap());
            modelBuilder.Configurations.Add(new ORDENPAGOCHEQUEMap());
            modelBuilder.Configurations.Add(new ORDENPAGOCLIENTEMap());
            modelBuilder.Configurations.Add(new ORDENPAGOCLIENTEDETALLEMap());
            modelBuilder.Configurations.Add(new ORDENPLANDECUENTAMap());
            modelBuilder.Configurations.Add(new ORDENPRODUCCIONCABECERAMap());
            modelBuilder.Configurations.Add(new ORDENPRODUCCIONDETALLEMap());
            modelBuilder.Configurations.Add(new ORDENPRODUCCIONDETMPRIMAMap());
            modelBuilder.Configurations.Add(new OTCABECERAMap());
            modelBuilder.Configurations.Add(new OTDEVOLUCIONCABECERAMap());
            modelBuilder.Configurations.Add(new OTDEVOLUCIONDETALLEMap());
            modelBuilder.Configurations.Add(new OTMANOOBRAMap());
            modelBuilder.Configurations.Add(new OTPEDIDOCABECERAMap());
            modelBuilder.Configurations.Add(new OTPEDIDODETALLEMap());
            modelBuilder.Configurations.Add(new OTPROBLEMADETALLEMap());
            modelBuilder.Configurations.Add(new OTPROBLEMASOLUCIONMap());
            modelBuilder.Configurations.Add(new OTTECNICOMap());
            modelBuilder.Configurations.Add(new PAGANZAMap());
            modelBuilder.Configurations.Add(new PAGAREMap());
            modelBuilder.Configurations.Add(new PAGARECUOTAMap());
            modelBuilder.Configurations.Add(new PAGAREFACTURAMap());
            modelBuilder.Configurations.Add(new PAGOCHEQUEMap());
            modelBuilder.Configurations.Add(new PAGOERETENNCMap());
            modelBuilder.Configurations.Add(new PAGONCCONCEPTOMap());
            modelBuilder.Configurations.Add(new PAGONOTACREDITOMap());
            modelBuilder.Configurations.Add(new PAGORETENCIONMap());
            modelBuilder.Configurations.Add(new PAGORETENFACTURAMap());
            modelBuilder.Configurations.Add(new PAGORETENNCMap());
            modelBuilder.Configurations.Add(new PAGOTIPORETENMap());
            modelBuilder.Configurations.Add(new PAIMap());
            modelBuilder.Configurations.Add(new PCMap());
            modelBuilder.Configurations.Add(new PEDIDOAJUSTEMap());
            modelBuilder.Configurations.Add(new PLANCUENTAMap());
            modelBuilder.Configurations.Add(new PLANEMap());
            modelBuilder.Configurations.Add(new PRECIOMap());
            modelBuilder.Configurations.Add(new PRECIOPRIORIDADMap());
            modelBuilder.Configurations.Add(new PRESUPUESTOMap());
            modelBuilder.Configurations.Add(new PRESUPUESTOVENTAMap());
            modelBuilder.Configurations.Add(new PRESUPUESTOVENTASDETALLEMap());
            modelBuilder.Configurations.Add(new PROCEDENCIAMap());
            modelBuilder.Configurations.Add(new PRODUCCIONFORMULAMap());
            modelBuilder.Configurations.Add(new PRODUCCIONFORMULADETALLEMap());
            modelBuilder.Configurations.Add(new PRODUCCIONINGRESOPRODUCTOMap());
            modelBuilder.Configurations.Add(new PRODUCCIONINGRESOPRODUCTODETMap());
            modelBuilder.Configurations.Add(new PRODUCTOMap());
            modelBuilder.Configurations.Add(new PRODUCTOSUCURSALMap());
            modelBuilder.Configurations.Add(new PROFESIONMap());
            modelBuilder.Configurations.Add(new PROPOSITOCHEQUEMap());
            modelBuilder.Configurations.Add(new PROVEEDORMap());
            modelBuilder.Configurations.Add(new REPARTOMap());
            modelBuilder.Configurations.Add(new RESPONSABLEMap());
            modelBuilder.Configurations.Add(new RESPONSABLERECEPCIONMap());
            modelBuilder.Configurations.Add(new ResultadoMap());
            modelBuilder.Configurations.Add(new RETENCIONMap());
            modelBuilder.Configurations.Add(new REVALUOMap());
            modelBuilder.Configurations.Add(new RUBROMap());
            modelBuilder.Configurations.Add(new RUBRO1Map());
            modelBuilder.Configurations.Add(new RUTAMap());
            modelBuilder.Configurations.Add(new SALARIOMap());
            modelBuilder.Configurations.Add(new SALARIOADICIONALMap());
            modelBuilder.Configurations.Add(new SALARIOSMINIMOMap());
            modelBuilder.Configurations.Add(new SEXOMap());
            modelBuilder.Configurations.Add(new SIMCARDMap());
            modelBuilder.Configurations.Add(new SIMCCARDSTOCKMap());
            modelBuilder.Configurations.Add(new SISTEMAMap());
            modelBuilder.Configurations.Add(new SUCURSALMap());
            modelBuilder.Configurations.Add(new SUCURSALLIMITEPRODMap());
            modelBuilder.Configurations.Add(new SUELDOCONFIGMap());
            modelBuilder.Configurations.Add(new SUELDOSTIPOMOVEMPLEADOMap());
            modelBuilder.Configurations.Add(new SUPERVISORVENTAMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new TALLEMap());
            modelBuilder.Configurations.Add(new TARJETAMap());
            modelBuilder.Configurations.Add(new TIPOASIENTOMap());
            modelBuilder.Configurations.Add(new TIPOCHEQUEMap());
            modelBuilder.Configurations.Add(new TIPOCLIENTEMap());
            modelBuilder.Configurations.Add(new TIPOCOBROMap());
            modelBuilder.Configurations.Add(new TIPOCOMPROBANTEMap());
            modelBuilder.Configurations.Add(new TIPOCREDITOMap());
            modelBuilder.Configurations.Add(new TIPOCUENTAMap());
            modelBuilder.Configurations.Add(new TIPODEBITOMap());
            modelBuilder.Configurations.Add(new TIPOEGRESOMap());
            modelBuilder.Configurations.Add(new TIPOFORMACOBROMap());
            modelBuilder.Configurations.Add(new TIPOGASTOMap());
            modelBuilder.Configurations.Add(new TIPOGASTODETMap());
            modelBuilder.Configurations.Add(new TIPOLIQUIDACIONMap());
            modelBuilder.Configurations.Add(new TIPOMOVIMIENTOMap());
            modelBuilder.Configurations.Add(new TIPOMOVIMIENTOSUELDOMap());
            modelBuilder.Configurations.Add(new TIPOMOVIMIENTOSUELDODETALLEMap());
            modelBuilder.Configurations.Add(new TIPOPAGOMap());
            modelBuilder.Configurations.Add(new TIPORETENCIONMap());
            modelBuilder.Configurations.Add(new TIPOSALARIOMap());
            modelBuilder.Configurations.Add(new TIPOTARJETAMap());
            modelBuilder.Configurations.Add(new TIPOTRANSPORTEMap());
            modelBuilder.Configurations.Add(new TIPOVENDEDORMap());
            modelBuilder.Configurations.Add(new TPYMap());
            modelBuilder.Configurations.Add(new TPYSTOCKMap());
            modelBuilder.Configurations.Add(new TRANFERENCIAMap());
            modelBuilder.Configurations.Add(new TRANSFERENCIASDETALLEMap());
            modelBuilder.Configurations.Add(new TRANSFERENCIASDETALLERANGOMap());
            modelBuilder.Configurations.Add(new TRANSFERENCIASUBDETALLEMap());
            modelBuilder.Configurations.Add(new TRANSPORTEMap());
            modelBuilder.Configurations.Add(new UNIDADMEDIDAMap());
            modelBuilder.Configurations.Add(new USUARIOMap());
            modelBuilder.Configurations.Add(new VARPATRIMONIOMap());
            modelBuilder.Configurations.Add(new VEHICULOMap());
            modelBuilder.Configurations.Add(new VENDEDORMap());
            modelBuilder.Configurations.Add(new VENTAMap());
            modelBuilder.Configurations.Add(new VENTASCIERREMap());
            modelBuilder.Configurations.Add(new VENTASCONFIGMap());
            modelBuilder.Configurations.Add(new VENTASDETALLEMap());
            modelBuilder.Configurations.Add(new VENTASDETALLELIQUIDACIONMap());
            modelBuilder.Configurations.Add(new VENTASDETALLERANGOMap());
            modelBuilder.Configurations.Add(new VENTASENTREGAMap());
            modelBuilder.Configurations.Add(new VENTASSUBDETALLEMap());
            modelBuilder.Configurations.Add(new VIDAUTILMap());
            modelBuilder.Configurations.Add(new ZONAMap());
        }
    }
}
