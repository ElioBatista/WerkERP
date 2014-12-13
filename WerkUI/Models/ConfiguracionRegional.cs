using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public partial class ConfiguracionRegional
    {
        public int cod_configuracion { get; set; }
        public int cod_usuario { get; set; }
        public int cod_pais { get; set; }
        public virtual Pais Pais { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
