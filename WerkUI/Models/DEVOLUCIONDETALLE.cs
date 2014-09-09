using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class DEVOLUCIONDETALLE
    {
        public decimal CODDEVOLUCION { get; set; }
        public decimal CODPRODUCTO { get; set; }
        public Nullable<decimal> CANTIDADDEVUELTA { get; set; }
        public Nullable<decimal> PRECIOBRUTO { get; set; }
        public Nullable<decimal> PRECIONETO { get; set; }
        public Nullable<decimal> COSTOPROMEDIO { get; set; }
        public Nullable<decimal> COSTOULTIMO { get; set; }
        public Nullable<decimal> IVA { get; set; }
        public Nullable<decimal> DESC { get; set; }
        public decimal LINEANUMERO { get; set; }
        public virtual DEVOLUCION DEVOLUCION { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
    }
}
