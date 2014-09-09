using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class CAJA
    {
        public CAJA()
        {
            this.CAJACIERREs = new List<CAJACIERRE>();
            this.CAJAEGRESOS = new List<CAJAEGRESO>();
            this.CAJAINGRESOS = new List<CAJAINGRESO1>();
            this.CIERRETICKETs = new List<CIERRETICKET>();
        }

        public decimal NUMCAJA { get; set; }
        public string NUMEROCAJA { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public Nullable<decimal> CODPLANCUENTA { get; set; }
        public Nullable<decimal> CODCOBRADOR { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual COBRADOR COBRADOR { get; set; }
        public virtual PLANCUENTA PLANCUENTA { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<CAJACIERRE> CAJACIERREs { get; set; }
        public virtual ICollection<CAJAEGRESO> CAJAEGRESOS { get; set; }
        public virtual ICollection<CAJAINGRESO1> CAJAINGRESOS { get; set; }
        public virtual ICollection<CIERRETICKET> CIERRETICKETs { get; set; }
    }
}
