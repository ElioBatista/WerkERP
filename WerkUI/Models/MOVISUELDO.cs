using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class MOVISUELDO
    {
        public MOVISUELDO()
        {
            this.MOVISUELDODETALLEs = new List<MOVISUELDODETALLE>();
        }

        public decimal CODMOVI { get; set; }
        public Nullable<decimal> CODTIPOMOV { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> NUMMOVI { get; set; }
        public Nullable<System.DateTime> FECHAMOVI { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual ICollection<MOVISUELDODETALLE> MOVISUELDODETALLEs { get; set; }
        public virtual TIPOMOVIMIENTOSUELDO TIPOMOVIMIENTOSUELDO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
