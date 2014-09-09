using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class HACIENDA
    {
        public HACIENDA()
        {
            this.ANEXOIs = new List<ANEXOI>();
            this.ANEXOIIs = new List<ANEXOII>();
            this.ANEXOIIIs = new List<ANEXOIII>();
            this.ANEXOIVs = new List<ANEXOIV>();
            this.FLUJOEFECTIVOes = new List<FLUJOEFECTIVO>();
            this.VARPATRIMONIOs = new List<VARPATRIMONIO>();
        }

        public decimal CODHACIENDA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public string DESHACIENDA { get; set; }
        public string RAZONSOCIAL { get; set; }
        public string NOMBRES { get; set; }
        public string REPRESENTANTE { get; set; }
        public string CONTADOR { get; set; }
        public string CONTADORRUC { get; set; }
        public string FORMNUM { get; set; }
        public string ORDENNUM { get; set; }
        public string RUC { get; set; }
        public Nullable<System.DateTime> DESDEI { get; set; }
        public Nullable<System.DateTime> DESDEII { get; set; }
        public Nullable<System.DateTime> HASTAI { get; set; }
        public Nullable<System.DateTime> HASTAII { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<ANEXOI> ANEXOIs { get; set; }
        public virtual ICollection<ANEXOII> ANEXOIIs { get; set; }
        public virtual ICollection<ANEXOIII> ANEXOIIIs { get; set; }
        public virtual ICollection<ANEXOIV> ANEXOIVs { get; set; }
        public virtual ICollection<FLUJOEFECTIVO> FLUJOEFECTIVOes { get; set; }
        public virtual ICollection<VARPATRIMONIO> VARPATRIMONIOs { get; set; }
    }
}
