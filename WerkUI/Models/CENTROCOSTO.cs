using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class CENTROCOSTO
    {
        public CENTROCOSTO()
        {
            this.ACTIVOFIJOes = new List<ACTIVOFIJO>();
            this.ASIENTOS = new List<ASIENTO>();
            this.ASIENTOSELIs = new List<ASIENTOSELI>();
            this.COMPRAS = new List<COMPRA>();
            this.CONCOMPRAS = new List<CONCOMPRA>();
            this.CONVENTAS = new List<CONVENTA>();
            this.MOVIASIENTOes = new List<MOVIASIENTO>();
        }

        public decimal CODCENTRO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public string NUMCENTRO { get; set; }
        public string DESCENTRO { get; set; }
        public Nullable<byte> PRIORIDAD { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<ACTIVOFIJO> ACTIVOFIJOes { get; set; }
        public virtual ICollection<ASIENTO> ASIENTOS { get; set; }
        public virtual ICollection<ASIENTOSELI> ASIENTOSELIs { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<COMPRA> COMPRAS { get; set; }
        public virtual ICollection<CONCOMPRA> CONCOMPRAS { get; set; }
        public virtual ICollection<CONVENTA> CONVENTAS { get; set; }
        public virtual ICollection<MOVIASIENTO> MOVIASIENTOes { get; set; }
    }
}
