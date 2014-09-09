using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class ConceptosMarcado
    {
        public int Cod__Liquidación { get; set; }
        public int Cod__Concepto { get; set; }
        public Nullable<int> Grupo { get; set; }
        public Nullable<int> Secuencia { get; set; }
        public string Concepto { get; set; }
        public decimal Importe { get; set; }
        public string Comentario { get; set; }
    }
}
