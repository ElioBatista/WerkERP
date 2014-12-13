using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public partial class Idioma
    {
        public int cod_idioma { get; set; }
        public string idioma1 { get; set; }
        public string simbolo { get; set; }
        public int cod_pais { get; set; }
        public virtual Pais Pais { get; set; }
    }
}
