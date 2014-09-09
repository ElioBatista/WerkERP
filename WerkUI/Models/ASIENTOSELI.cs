using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class ASIENTOSELI
    {
        public ASIENTOSELI()
        {
            this.DETASIENTOELIs = new List<DETASIENTOELI>();
        }

        public decimal CODASIENTOELI { get; set; }
        public decimal CODASIENTO { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public Nullable<decimal> CODCENTRO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> NUMASIENTO { get; set; }
        public Nullable<System.DateTime> FECHAASIENTO { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<byte> MARCACIERRE { get; set; }
        public Nullable<byte> GENERADO { get; set; }
        public Nullable<byte> HISTORICO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<System.DateTime> FECELIMINADO { get; set; }
        public Nullable<decimal> USUELIMINADO { get; set; }
        public Nullable<byte> ELIMINADO { get; set; }
        public virtual CENTROCOSTO CENTROCOSTO { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<DETASIENTOELI> DETASIENTOELIs { get; set; }
    }
}
