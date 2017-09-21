using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [DataContract]
    public class Factura
    {
        [DataMember]
        long idFactura;
        [DataMember]
        long idUsuario;
        [DataMember]
        Double total;
        [DataMember]
        DateTime fechaFactura;
        [DataMember]
        bool activoFactura;

        public Factura()
        {
        }

        public Factura(long idFactura, long idUsuario, double total, DateTime fechaFactura, bool activoFactura)
        {
            this.idFactura = idFactura;
            this.idUsuario = idUsuario;
            this.total = total;
            this.fechaFactura = fechaFactura;
            this.activoFactura = activoFactura;
        }


        public long IdFactura { get => idFactura; set => idFactura = value; }
        public long IdUsuario { get => idUsuario; set => idUsuario = value; }
        public double Total { get => total; set => total = value; }
        public DateTime FechaFactura { get => fechaFactura; set => fechaFactura = value; }
        public bool ActivoFactura { get => activoFactura; set => activoFactura = value; }
    }
}
