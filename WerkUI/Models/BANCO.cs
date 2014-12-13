using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public partial class Banco
    {
        public Banco()
        {
            this.Chequeras = new List<Chequera>();
            this.Chequeras1 = new List<Chequera>();
        }

        public int id_banco { get; set; }
        public string banco1 { get; set; }
        public virtual ICollection<Chequera> Chequeras { get; set; }
        public virtual ICollection<Chequera> Chequeras1 { get; set; }
    }
}
