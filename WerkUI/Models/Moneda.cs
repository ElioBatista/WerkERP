using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class Moneda
    {
        public int cod_moneda { get; set; }
        public string moneda1 { get; set; }
        public string simbolo { get; set; }
        public string formato { get; set; }
        public Nullable<int> cod_pais { get; set; }
        public virtual Pais Pais { get; set; }
    }
}
