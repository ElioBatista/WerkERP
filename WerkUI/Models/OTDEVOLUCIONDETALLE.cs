using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class OTDEVOLUCIONDETALLE
    {
        public decimal CODDETALLE { get; set; }
        public decimal CODOTDEVOLUCION { get; set; }
        public Nullable<decimal> CODPRODUCTO { get; set; }
        public Nullable<decimal> PRECIO { get; set; }
        public Nullable<decimal> COSTOULTIMO { get; set; }
        public Nullable<decimal> COSTOPP { get; set; }
        public Nullable<decimal> CODMONEDAPRODUCTO { get; set; }
        public Nullable<decimal> PORCENTAJEIVA { get; set; }
        public Nullable<decimal> CANTIDAD { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual OTDEVOLUCIONCABECERA OTDEVOLUCIONCABECERA { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
    }
}
