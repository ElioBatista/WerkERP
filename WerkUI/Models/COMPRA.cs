using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class COMPRA
    {
        public COMPRA()
        {
            this.ORDENPAGOes = new List<ORDENPAGO>();
            this.COMPRASDETALLEs = new List<COMPRASDETALLE>();
            this.COMPRASFORMAPAGOes = new List<COMPRASFORMAPAGO>();
            this.COMPRASORDENCOMPRAs = new List<COMPRASORDENCOMPRA>();
            this.COMPRASRECEPCIONDETALLEs = new List<COMPRASRECEPCIONDETALLE>();
            this.CONCOMPRAS = new List<CONCOMPRA>();
            this.EQUIPOS = new List<EQUIPOS>();
            this.EQUIPOSSTOCKs = new List<EQUIPOSSTOCK>();
            this.FACTURAPAGARs = new List<FACTURAPAGAR>();
            this.MagicIVAs = new List<MagicIVA>();
            this.MOVIASIENTOMOVIs = new List<MOVIASIENTOMOVI>();
            this.PAGOERETENNCs = new List<PAGOERETENNC>();
            this.PAGONOTACREDITOes = new List<PAGONOTACREDITO>();
            this.PAGORETENFACTURAs = new List<PAGORETENFACTURA>();
            this.PAGORETENNCs = new List<PAGORETENNC>();
            this.SIMCARDs = new List<SIMCARD>();
            this.SIMCCARDSTOCKs = new List<SIMCCARDSTOCK>();
            this.TPies = new List<TPY>();
            this.TPYSTOCKs = new List<TPYSTOCK>();
        }

        public decimal CODCOMPRA { get; set; }
        public string NUMRESPONSABLE { get; set; }
        public Nullable<decimal> RES_CODEMPRESA { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public Nullable<decimal> CODCOMPROBANTE { get; set; }
        public Nullable<decimal> CODPROVEEDOR { get; set; }
        public string NUMCOMPRA { get; set; }
        public Nullable<System.DateTime> FECHACOMPRA { get; set; }
        public Nullable<decimal> TOTALEXENTA { get; set; }
        public Nullable<decimal> TOTALGRAVADA { get; set; }
        public Nullable<decimal> TOTALIVA { get; set; }
        public Nullable<decimal> TOTALCOMPRA { get; set; }
        public Nullable<decimal> TOTALDESCUENTO { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<byte> ESTADO { get; set; }
        public Nullable<decimal> CODCONCOMPRA { get; set; }
        public Nullable<decimal> CODTIPOGASTODET { get; set; }
        public Nullable<byte> MODALIDADPAGO { get; set; }
        public Nullable<decimal> CODCENTRO { get; set; }
        public Nullable<decimal> BASEIMPONIBLE { get; set; }
        public Nullable<decimal> CODPLANCUENTADEBE { get; set; }
        public Nullable<decimal> CODPLANCUENTAHABER { get; set; }
        public virtual CENTROCOSTO CENTROCOSTO { get; set; }
        public virtual PLANCUENTA PLANCUENTA { get; set; }
        public virtual PLANCUENTA PLANCUENTA1 { get; set; }
        public virtual ICollection<ORDENPAGO> ORDENPAGOes { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual PROVEEDOR PROVEEDOR { get; set; }
        public virtual RESPONSABLE RESPONSABLE { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual TIPOCOMPROBANTE TIPOCOMPROBANTE { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual TIPOGASTODET TIPOGASTODET { get; set; }
        public virtual ICollection<COMPRASDETALLE> COMPRASDETALLEs { get; set; }
        public virtual ICollection<COMPRASFORMAPAGO> COMPRASFORMAPAGOes { get; set; }
        public virtual ICollection<COMPRASORDENCOMPRA> COMPRASORDENCOMPRAs { get; set; }
        public virtual ICollection<COMPRASRECEPCIONDETALLE> COMPRASRECEPCIONDETALLEs { get; set; }
        public virtual CONCOMPRA CONCOMPRA { get; set; }
        public virtual ICollection<CONCOMPRA> CONCOMPRAS { get; set; }
        public virtual ICollection<EQUIPOS> EQUIPOS { get; set; }
        public virtual ICollection<EQUIPOSSTOCK> EQUIPOSSTOCKs { get; set; }
        public virtual ICollection<FACTURAPAGAR> FACTURAPAGARs { get; set; }
        public virtual ICollection<MagicIVA> MagicIVAs { get; set; }
        public virtual ICollection<MOVIASIENTOMOVI> MOVIASIENTOMOVIs { get; set; }
        public virtual ICollection<PAGOERETENNC> PAGOERETENNCs { get; set; }
        public virtual ICollection<PAGONOTACREDITO> PAGONOTACREDITOes { get; set; }
        public virtual ICollection<PAGORETENFACTURA> PAGORETENFACTURAs { get; set; }
        public virtual ICollection<PAGORETENNC> PAGORETENNCs { get; set; }
        public virtual ICollection<SIMCARD> SIMCARDs { get; set; }
        public virtual ICollection<SIMCCARDSTOCK> SIMCCARDSTOCKs { get; set; }
        public virtual ICollection<TPY> TPies { get; set; }
        public virtual ICollection<TPYSTOCK> TPYSTOCKs { get; set; }
    }
}
