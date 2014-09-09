using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class ASIENTO
    {
        public ASIENTO()
        {
            this.CONVENTAS = new List<CONVENTA>();
            this.CONCOMPRAS = new List<CONCOMPRA>();
            this.DETASIENTOes = new List<DETASIENTO>();
            this.MOVIASIENTOes = new List<MOVIASIENTO>();
            this.REVALUOs = new List<REVALUO>();
            this.REVALUOs1 = new List<REVALUO>();
        }

        public decimal CODASIENTO { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODCENTRO { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public Nullable<decimal> NUMASIENTO { get; set; }
        public Nullable<System.DateTime> FECHAASIENTO { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<byte> MARCACIERRE { get; set; }
        public Nullable<byte> GENERADO { get; set; }
        public byte HISTORICO { get; set; }
        public Nullable<byte> ELIMINADO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual CENTROCOSTO CENTROCOSTO { get; set; }
        public virtual ICollection<CONVENTA> CONVENTAS { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<CONCOMPRA> CONCOMPRAS { get; set; }
        public virtual ICollection<DETASIENTO> DETASIENTOes { get; set; }
        public virtual ICollection<MOVIASIENTO> MOVIASIENTOes { get; set; }
        public virtual ICollection<REVALUO> REVALUOs { get; set; }
        public virtual ICollection<REVALUO> REVALUOs1 { get; set; }
    }
}
