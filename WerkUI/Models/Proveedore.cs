using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public partial class Proveedore
    {
        public Proveedore()
        {
            this.Cheques = new List<Cheque>();
            this.Cheques1 = new List<Cheque>();
        }

        public long id_proveedor { get; set; }
        public string proveedor { get; set; }
        public string ruc { get; set; }
        public virtual ICollection<Cheque> Cheques { get; set; }
        public virtual ICollection<Cheque> Cheques1 { get; set; }
    }
}
