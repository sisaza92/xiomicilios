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
        private Cliente cliente;
        [DataMember]
        private Double total;
        [DataMember]
        private DateTime fechaFactura;
        [DataMember]
        private bool activoFactura;

        public Factura()
        {
        }

        public Factura(long idFactura, Cliente cliente, double total, DateTime fechaFactura, bool activoFactura)
        {
            this.idFactura = idFactura;
            this.cliente = cliente;
            this.total = total;
            this.fechaFactura = fechaFactura;
            this.activoFactura = activoFactura;
        }


        public long IdFactura { get => idFactura; set => idFactura = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public double Total { get => total; set => total = value; }
        public DateTime FechaFactura { get => fechaFactura; set => fechaFactura = value; }
        public bool ActivoFactura { get => activoFactura; set => activoFactura = value; }
    }
}
