using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class SIMCCARDSTOCK
    {
        public SIMCCARDSTOCK()
        {
            this.AJUSTESUBDETALLEs = new List<AJUSTESUBDETALLE>();
            this.DEVOLUCIONSUBDETALLEs = new List<DEVOLUCIONSUBDETALLE>();
            this.INVENTARIOSUBDETALLEs = new List<INVENTARIOSUBDETALLE>();
            this.TRANSFERENCIASUBDETALLEs = new List<TRANSFERENCIASUBDETALLE>();
            this.VENTASSUBDETALLEs = new List<VENTASSUBDETALLE>();
        }

        public decimal CODSIMCARD { get; set; }
        public Nullable<decimal> CODPRODUCTO { get; set; }
        public string NUMSINCARD { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public Nullable<decimal> CODCOMPRA { get; set; }
        public Nullable<decimal> CODVENTA { get; set; }
        public Nullable<decimal> CODDEVOLUCION { get; set; }
        public Nullable<decimal> CODAJUSTE { get; set; }
        public Nullable<decimal> CODTRANSFERENCIA { get; set; }
        public Nullable<byte> ESTADO { get; set; }
        public Nullable<System.DateTime> FECHAULTIMOMOV { get; set; }
        public string NUMCELULAR { get; set; }
        public virtual AJUSTE AJUSTE { get; set; }
        public virtual ICollection<AJUSTESUBDETALLE> AJUSTESUBDETALLEs { get; set; }
        public virtual COMPRA COMPRA { get; set; }
        public virtual ICollection<DEVOLUCIONSUBDETALLE> DEVOLUCIONSUBDETALLEs { get; set; }
        public virtual ICollection<INVENTARIOSUBDETALLE> INVENTARIOSUBDETALLEs { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual TRANFERENCIA TRANFERENCIA { get; set; }
        public virtual VENTA VENTA { get; set; }
        public virtual ICollection<TRANSFERENCIASUBDETALLE> TRANSFERENCIASUBDETALLEs { get; set; }
        public virtual ICollection<VENTASSUBDETALLE> VENTASSUBDETALLEs { get; set; }
    }
}
