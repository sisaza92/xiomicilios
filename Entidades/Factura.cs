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
        private long idFactura;
        [DataMember]
        private long idCliente;
        [DataMember]
        private Double total;
        [DataMember]
        private DateTime fechaFactura;
        [DataMember]
        private bool activoFactura;

        public Factura()
        {
        }

        public Factura(long idFactura, long idCliente, double total, DateTime fechaFactura, bool activoFactura)
        {
            this.idFactura = idFactura;
            this.idCliente = idCliente;
            this.total = total;
            this.fechaFactura = fechaFactura;
            this.activoFactura = activoFactura;
        }

        public long IdFactura { get => idFactura; set => idFactura = value; }
        public long IdCliente { get => idCliente; set => idCliente = value; }
        public double Total { get => total; set => total = value; }
        public DateTime FechaFactura { get => fechaFactura; set => fechaFactura = value; }
        public bool ActivoFactura { get => activoFactura; set => activoFactura = value; }
    }
}
