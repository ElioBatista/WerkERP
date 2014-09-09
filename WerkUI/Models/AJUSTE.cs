using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class AJUSTE
    {
        public AJUSTE()
        {
            this.AJUSTEDETALLEs = new List<AJUSTEDETALLE>();
            this.EQUIPOSSTOCKs = new List<EQUIPOSSTOCK>();
            this.MOVIASIENTOMOVIs = new List<MOVIASIENTOMOVI>();
            this.SIMCCARDSTOCKs = new List<SIMCCARDSTOCK>();
            this.TPYSTOCKs = new List<TPYSTOCK>();
        }

        public decimal CODAJUSTE { get; set; }
        public Nullable<decimal> CODCOMPROBANTE { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public Nullable<decimal> CODCONCEPTO { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public string NUMAJUSTE { get; set; }
        public Nullable<System.DateTime> FECHAAJUSTE { get; set; }
        public Nullable<byte> TIPOAJUSTE { get; set; }
        public Nullable<decimal> TOTALCOSTOAJUSTE { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual CONCEPTO CONCEPTO { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual TIPOCOMPROBANTE TIPOCOMPROBANTE { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<AJUSTEDETALLE> AJUSTEDETALLEs { get; set; }
        public virtual ICollection<EQUIPOSSTOCK> EQUIPOSSTOCKs { get; set; }
        public virtual ICollection<MOVIASIENTOMOVI> MOVIASIENTOMOVIs { get; set; }
        public virtual ICollection<SIMCCARDSTOCK> SIMCCARDSTOCKs { get; set; }
        public virtual ICollection<TPYSTOCK> TPYSTOCKs { get; set; }
    }
}
