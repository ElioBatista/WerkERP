using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class PAGORETENCION
    {
        public PAGORETENCION()
        {
            this.PAGOERETENNCs = new List<PAGOERETENNC>();
            this.PAGORETENNCs = new List<PAGORETENNC>();
            this.PAGOTIPORETENs = new List<PAGOTIPORETEN>();
            this.PAGANZAS = new List<PAGANZA>();
        }

        public decimal CODRETEN { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public string NUMRETEN { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public string CONCEPTO { get; set; }
        public Nullable<decimal> VALORRENTA { get; set; }
        public Nullable<decimal> VALORRENTA2 { get; set; }
        public Nullable<decimal> VALORIVA { get; set; }
        public Nullable<decimal> MONTO { get; set; }
        public Nullable<decimal> BASE { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public string RESPONSABLE { get; set; }
        public string RUCCI { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> CODPROVEEDOR { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<System.DateTime> FECHAEMISION { get; set; }
        public string NUMEROEMISION { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual ICollection<PAGOERETENNC> PAGOERETENNCs { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual PROVEEDOR PROVEEDOR { get; set; }
        public virtual PROVEEDOR PROVEEDOR1 { get; set; }
        public virtual ICollection<PAGORETENNC> PAGORETENNCs { get; set; }
        public virtual ICollection<PAGOTIPORETEN> PAGOTIPORETENs { get; set; }
        public virtual ICollection<PAGANZA> PAGANZAS { get; set; }
    }
}
