using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class VENTA
    {
        public VENTA()
        {
            this.CAJAINGRESOes = new List<CAJAINGRESO>();
            this.CONVENTAS = new List<CONVENTA>();
            this.DEVOLUCIONs = new List<DEVOLUCION>();
            this.DOCUMENTOSDEVUELTOS = new List<DOCUMENTOSDEVUELTO>();
            this.DOCUMENTOSENTREGADOS = new List<DOCUMENTOSENTREGADO>();
            this.EQUIPOSSTOCKs = new List<EQUIPOSSTOCK>();
            this.FACTURACOBRARs = new List<FACTURACOBRAR>();
            this.MagicIVAs = new List<MagicIVA>();
            this.MOVIASIENTOMOVIs = new List<MOVIASIENTOMOVI>();
            this.NCREDITOes = new List<NCREDITO>();
            this.NDEBITOes = new List<NDEBITO>();
            this.SIMCARDs = new List<SIMCARD>();
            this.SIMCCARDSTOCKs = new List<SIMCCARDSTOCK>();
            this.TPYSTOCKs = new List<TPYSTOCK>();
            this.VENTASDETALLEs = new List<VENTASDETALLE>();
            this.VENTASDETALLELIQUIDACIONs = new List<VENTASDETALLELIQUIDACION>();
            this.CAJAINGRESOS = new List<CAJAINGRESO1>();
            this.TRANFERENCIAs = new List<TRANFERENCIA>();
            this.PRESUPUESTOVENTAS = new List<PRESUPUESTOVENTA>();
        }

        public decimal CODVENTA { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> CODVENDEDOR { get; set; }
        public Nullable<decimal> CODCOMPROBANTE { get; set; }
        public Nullable<decimal> CODCLIENTE { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMVENTA { get; set; }
        public Nullable<System.DateTime> FECHAVENTA { get; set; }
        public Nullable<decimal> PORCENTAJEDESCUENTO { get; set; }
        public Nullable<decimal> TOTALEXENTA { get; set; }
        public Nullable<decimal> TOTALGRAVADA { get; set; }
        public Nullable<decimal> TOTALIVA { get; set; }
        public Nullable<decimal> TOTALDESCUENTO { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<byte> MODALIDADPAGO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<byte> ESTADO { get; set; }
        public Nullable<byte> TIPOVENTA { get; set; }
        public Nullable<decimal> CODPRIORIDAD { get; set; }
        public string DIRENVIO { get; set; }
        public Nullable<byte> TIPOPRECIO { get; set; }
        public Nullable<decimal> CODCONVENTAS { get; set; }
        public Nullable<decimal> NUMVENTATIMBRADO { get; set; }
        public Nullable<decimal> CODDESPACHOINTERNO { get; set; }
        public virtual ICollection<CAJAINGRESO> CAJAINGRESOes { get; set; }
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual CONVENTA CONVENTA { get; set; }
        public virtual ICollection<CONVENTA> CONVENTAS { get; set; }
        public virtual DESPACHOINTERNO DESPACHOINTERNO { get; set; }
        public virtual ICollection<DEVOLUCION> DEVOLUCIONs { get; set; }
        public virtual ICollection<DOCUMENTOSDEVUELTO> DOCUMENTOSDEVUELTOS { get; set; }
        public virtual ICollection<DOCUMENTOSENTREGADO> DOCUMENTOSENTREGADOS { get; set; }
        public virtual ICollection<EQUIPOSSTOCK> EQUIPOSSTOCKs { get; set; }
        public virtual ICollection<FACTURACOBRAR> FACTURACOBRARs { get; set; }
        public virtual ICollection<MagicIVA> MagicIVAs { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual ICollection<MOVIASIENTOMOVI> MOVIASIENTOMOVIs { get; set; }
        public virtual ICollection<NCREDITO> NCREDITOes { get; set; }
        public virtual ICollection<NDEBITO> NDEBITOes { get; set; }
        public virtual PRECIOPRIORIDAD PRECIOPRIORIDAD { get; set; }
        public virtual ICollection<SIMCARD> SIMCARDs { get; set; }
        public virtual ICollection<SIMCCARDSTOCK> SIMCCARDSTOCKs { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual TIPOCOMPROBANTE TIPOCOMPROBANTE { get; set; }
        public virtual ICollection<TPYSTOCK> TPYSTOCKs { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual VENDEDOR VENDEDOR { get; set; }
        public virtual ICollection<VENTASDETALLE> VENTASDETALLEs { get; set; }
        public virtual ICollection<VENTASDETALLELIQUIDACION> VENTASDETALLELIQUIDACIONs { get; set; }
        public virtual ICollection<CAJAINGRESO1> CAJAINGRESOS { get; set; }
        public virtual ICollection<TRANFERENCIA> TRANFERENCIAs { get; set; }
        public virtual ICollection<PRESUPUESTOVENTA> PRESUPUESTOVENTAS { get; set; }
    }
}
