using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class PRECIOPRIORIDAD
    {
        public PRECIOPRIORIDAD()
        {
            this.PRECIOs = new List<PRECIO>();
            this.VENTAS = new List<VENTA>();
            this.VENTASDETALLEs = new List<VENTASDETALLE>();
        }

        public decimal CODPRIORIDAD { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMPRIORIDAD { get; set; }
        public string DESPRIORIDAD { get; set; }
        public Nullable<decimal> ORDEN { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<PRECIO> PRECIOs { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<VENTA> VENTAS { get; set; }
        public virtual ICollection<VENTASDETALLE> VENTASDETALLEs { get; set; }
    }
}
