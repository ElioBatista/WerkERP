using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class PRESUPUESTOVENTASDETALLE
    {
        public decimal CODPRODUCTO { get; set; }
        public decimal CODPRESUPUESTO { get; set; }
        public decimal LINEANUMERO { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> CANTIDAD { get; set; }
        public Nullable<decimal> PRECIOVENTABRUTO { get; set; }
        public Nullable<decimal> PRECIOVENTANETO { get; set; }
        public Nullable<decimal> PRECIOVENTALISTA { get; set; }
        public Nullable<decimal> COSTOULTIMO { get; set; }
        public Nullable<decimal> IVA { get; set; }
        public Nullable<decimal> DESCUENTO { get; set; }
        public Nullable<decimal> PORCENCOMI { get; set; }
        public virtual PRESUPUESTOVENTA PRESUPUESTOVENTA { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
    }
}
