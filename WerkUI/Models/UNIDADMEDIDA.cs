using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class UNIDADMEDIDA
    {
        public UNIDADMEDIDA()
        {
            this.ORDENPRODUCCIONDETMPRIMAs = new List<ORDENPRODUCCIONDETMPRIMA>();
            this.PRODUCCIONFORMULADETALLEs = new List<PRODUCCIONFORMULADETALLE>();
            this.PRODUCTOS = new List<PRODUCTO>();
        }

        public decimal CODMEDIDA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMMEDIDA { get; set; }
        public string DESMEDIDA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<ORDENPRODUCCIONDETMPRIMA> ORDENPRODUCCIONDETMPRIMAs { get; set; }
        public virtual ICollection<PRODUCCIONFORMULADETALLE> PRODUCCIONFORMULADETALLEs { get; set; }
        public virtual ICollection<PRODUCTO> PRODUCTOS { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
