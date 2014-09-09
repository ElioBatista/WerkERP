using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class VENTASDETALLE
    {
        public decimal CODPRODUCTO { get; set; }
        public decimal CODVENTA { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> CANTIDADVENTA { get; set; }
        public Nullable<decimal> PRECIOVENTABRUTO { get; set; }
        public Nullable<decimal> PRECIOVENTANETO { get; set; }
        public Nullable<decimal> PRECIOVENTALISTA { get; set; }
        public Nullable<decimal> COSTOPROMEDIO { get; set; }
        public Nullable<decimal> COSTOULTIMO { get; set; }
        public Nullable<decimal> IVA { get; set; }
        public Nullable<decimal> DESC { get; set; }
        public Nullable<decimal> PORCENCOMI { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public Nullable<decimal> CODPRIORIDAD { get; set; }
        public string NUMCELULAR { get; set; }
        public decimal LINEANUMERO { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual PRECIOPRIORIDAD PRECIOPRIORIDAD { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual VENTA VENTA { get; set; }
    }
}
