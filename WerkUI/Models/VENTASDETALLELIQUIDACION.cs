using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class VENTASDETALLELIQUIDACION
    {
        public decimal CODCONLIQUIDACION { get; set; }
        public decimal CODVENTA { get; set; }
        public Nullable<decimal> CANTIDADVENTA { get; set; }
        public Nullable<decimal> PRECIOVENTABRUTO { get; set; }
        public Nullable<decimal> PRECIOVENTANETO { get; set; }
        public Nullable<decimal> PRECIOVENTALISTA { get; set; }
        public Nullable<decimal> COSTOPROMEDIO { get; set; }
        public Nullable<decimal> COSTOULTIMO { get; set; }
        public Nullable<decimal> IVA { get; set; }
        public Nullable<decimal> DESC { get; set; }
        public decimal LINEANUMERO { get; set; }
        public virtual CONCEPTOSLIQUIDACION CONCEPTOSLIQUIDACION { get; set; }
        public virtual VENTA VENTA { get; set; }
    }
}
