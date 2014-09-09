using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class ADJUNTO
    {
        public ADJUNTO()
        {
            this.LIQUIADJUNTOes = new List<LIQUIADJUNTO>();
        }

        public decimal CODADJUNTO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMADJUNTO { get; set; }
        public string DESADJUNTO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<LIQUIADJUNTO> LIQUIADJUNTOes { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
