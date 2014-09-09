using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class ORDENCOMPRARESPONSABLE
    {
        public ORDENCOMPRARESPONSABLE()
        {
            this.ORDENCOMPRAPROVEEDORs = new List<ORDENCOMPRAPROVEEDOR>();
        }

        public decimal CODRESPONSABLE { get; set; }
        public string NUMRESPONSABLE { get; set; }
        public string DESCRIPCION { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<ORDENCOMPRAPROVEEDOR> ORDENCOMPRAPROVEEDORs { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
