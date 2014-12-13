using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public partial class EstadoSolicitud
    {
        public EstadoSolicitud()
        {
            this.SolicitudOrdenPagoes = new List<SolicitudOrdenPago>();
        }

        public short id_estado { get; set; }
        public string estado { get; set; }
        public virtual ICollection<SolicitudOrdenPago> SolicitudOrdenPagoes { get; set; }
    }
}
