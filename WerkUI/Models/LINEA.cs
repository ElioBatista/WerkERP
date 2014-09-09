using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class LINEA
    {
        public LINEA()
        {
            this.PRODUCTOS = new List<PRODUCTO>();
            this.RUBROes = new List<RUBRO>();
            this.VENTASCONFIGs = new List<VENTASCONFIG>();
            this.VENTASCONFIGs1 = new List<VENTASCONFIG>();
            this.VENTASCONFIGs2 = new List<VENTASCONFIG>();
        }

        public decimal CODLINEA { get; set; }
        public Nullable<decimal> CODFAMILIA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMLINEA { get; set; }
        public string DESLINEA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual FAMILIA FAMILIA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<PRODUCTO> PRODUCTOS { get; set; }
        public virtual ICollection<RUBRO> RUBROes { get; set; }
        public virtual ICollection<VENTASCONFIG> VENTASCONFIGs { get; set; }
        public virtual ICollection<VENTASCONFIG> VENTASCONFIGs1 { get; set; }
        public virtual ICollection<VENTASCONFIG> VENTASCONFIGs2 { get; set; }
    }
}
