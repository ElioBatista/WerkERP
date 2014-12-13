using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public partial class Chequera
    {
        public Chequera()
        {
            this.Cheques = new List<Cheque>();
            this.Cheques1 = new List<Cheque>();
        }

        public int id_chequera { get; set; }
        public int id_banco { get; set; }
        public System.DateTime fecha_emision { get; set; }
        public long serie_inicio { get; set; }
        public long serie_fin { get; set; }
        public short id_tipo_chequera { get; set; }
        public string nro_talon { get; set; }
        public virtual Banco Banco { get; set; }
        public virtual Banco Banco1 { get; set; }
        public virtual TiposChequera TiposChequera { get; set; }
        public virtual ICollection<Cheque> Cheques { get; set; }
        public virtual ICollection<Cheque> Cheques1 { get; set; }
    }
}
