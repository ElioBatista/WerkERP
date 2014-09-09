using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class Pais
    {
        public Pais()
        {
            this.ConfiguracionRegionals = new List<ConfiguracionRegional>();
            this.Idiomas = new List<Idioma>();
            this.Monedas = new List<Moneda>();
        }

        public int cod_pais { get; set; }
        public string pais1 { get; set; }
        public string codigo { get; set; }
        public virtual ICollection<ConfiguracionRegional> ConfiguracionRegionals { get; set; }
        public virtual ICollection<Idioma> Idiomas { get; set; }
        public virtual ICollection<Moneda> Monedas { get; set; }
    }
}
