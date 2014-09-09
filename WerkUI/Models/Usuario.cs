using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class Usuario
    {
        public Usuario()
        {
            this.ConfiguracionRegionals = new List<ConfiguracionRegional>();
        }

        public int cod_usuario { get; set; }
        public string usuario1 { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string password { get; set; }
        public virtual ICollection<ConfiguracionRegional> ConfiguracionRegionals { get; set; }
    }
}
