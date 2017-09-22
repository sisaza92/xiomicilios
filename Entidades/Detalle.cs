using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Entidades
{
    [DataContract]
    public class Detalle
    {
        [DataMember]
        private long idDetalle;
        [DataMember]
        private Producto producto;
        [DataMember]
        private Factura factura;
        [DataMember]
        private int cantidad;
        [DataMember]
        private double precioUnitario;
        [DataMember]
        private double subtotal;

        public Detalle(long idDetalle, Producto producto, Factura factura, int cantidad, double precioUnitario, double subtotal)
        {
            this.idDetalle = idDetalle;
            this.producto = producto;
            this.factura = factura;
            this.cantidad = cantidad;
            this.precioUnitario = precioUnitario;
            this.subtotal = subtotal;
        }

        public long IdDetalle { get => idDetalle; set => idDetalle = value; }
        public Producto Producto { get => producto; set => producto = value; }
        public Factura Factura { get => factura; set => factura = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
        public double Subtotal { get => subtotal; set => subtotal = value; }
    }


}




