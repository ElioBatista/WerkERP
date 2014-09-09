using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class TRANFERENCIA
    {
        public TRANFERENCIA()
        {
            this.EQUIPOSSTOCKs = new List<EQUIPOSSTOCK>();
            this.MOVIASIENTOMOVIs = new List<MOVIASIENTOMOVI>();
            this.SIMCCARDSTOCKs = new List<SIMCCARDSTOCK>();
            this.TPYSTOCKs = new List<TPYSTOCK>();
            this.TRANSFERENCIASDETALLEs = new List<TRANSFERENCIASDETALLE>();
            this.VENTAS = new List<VENTA>();
        }

        public decimal CODTRANSFERENCIA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public string NUMTRANSFERENCIA { get; set; }
        public Nullable<System.DateTime> FECHATRANSFERENCIA { get; set; }
        public Nullable<decimal> SUCURSALDESTINO { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> CODCOMPROBANTE { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<byte> ASR { get; set; }
        public virtual ICollection<EQUIPOSSTOCK> EQUIPOSSTOCKs { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual ICollection<MOVIASIENTOMOVI> MOVIASIENTOMOVIs { get; set; }
        public virtual ICollection<SIMCCARDSTOCK> SIMCCARDSTOCKs { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual TIPOCOMPROBANTE TIPOCOMPROBANTE { get; set; }
        public virtual ICollection<TPYSTOCK> TPYSTOCKs { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<TRANSFERENCIASDETALLE> TRANSFERENCIASDETALLEs { get; set; }
        public virtual ICollection<VENTA> VENTAS { get; set; }
    }
}
