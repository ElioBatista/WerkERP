using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class PAGONOTACREDITO
    {
        public PAGONOTACREDITO()
        {
            this.MagicIVAs = new List<MagicIVA>();
            this.PAGOERETENNCs = new List<PAGOERETENNC>();
            this.PAGORETENNCs = new List<PAGORETENNC>();
        }

        public decimal CODNCREDITO { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public Nullable<decimal> CODPROVEEDOR { get; set; }
        public Nullable<decimal> CODCOMPROBANTE { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public string NUMCOMPROBANTE { get; set; }
        public Nullable<byte> ESTADO { get; set; }
        public Nullable<decimal> CODCONCEPTO { get; set; }
        public Nullable<decimal> TOTALEXENTA { get; set; }
        public Nullable<decimal> TOTALGRAVADA { get; set; }
        public Nullable<decimal> TOTALDESCUENTO { get; set; }
        public Nullable<decimal> TOTALIVA { get; set; }
        public Nullable<decimal> TOTALCOMPROBANTE { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<decimal> CODCOMPRA { get; set; }
        public Nullable<decimal> CODDEVOLUCION { get; set; }
        public string OBSERVACION { get; set; }
        public Nullable<decimal> CODPAGANZAS { get; set; }
        public Nullable<decimal> CODTIPOPAGO { get; set; }
        public Nullable<decimal> MON_CODMONEDA { get; set; }
        public Nullable<System.DateTime> FECHACOMPROBANTE { get; set; }
        public virtual COMPRA COMPRA { get; set; }
        public virtual ICollection<MagicIVA> MagicIVAs { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual PAGANZA PAGANZA { get; set; }
        public virtual ICollection<PAGOERETENNC> PAGOERETENNCs { get; set; }
        public virtual PAGONCCONCEPTO PAGONCCONCEPTO { get; set; }
        public virtual PROVEEDOR PROVEEDOR { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual TIPOCOMPROBANTE TIPOCOMPROBANTE { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<PAGORETENNC> PAGORETENNCs { get; set; }
    }
}
