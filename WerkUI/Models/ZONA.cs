using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class ZONA
    {
        public ZONA()
        {
            this.CLIENTES = new List<CLIENTE>();
            this.PROVEEDORs = new List<PROVEEDOR>();
            this.SUCURSALs = new List<SUCURSAL>();
            this.SUPERVISORVENTAs = new List<SUPERVISORVENTA>();
        }

        public decimal CODZONA { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODCIUDAD { get; set; }
        public string NUMZONA { get; set; }
        public string DESZONA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual CIUDAD CIUDAD { get; set; }
        public virtual ICollection<CLIENTE> CLIENTES { get; set; }
        public virtual ICollection<PROVEEDOR> PROVEEDORs { get; set; }
        public virtual ICollection<SUCURSAL> SUCURSALs { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual ICollection<SUPERVISORVENTA> SUPERVISORVENTAs { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
