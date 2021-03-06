﻿using System;
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
        private long idProducto;
        [DataMember]
        private long idFactura;
        [DataMember]
        private int cantidad;
        [DataMember]
        private double precioUnitario;
        [DataMember]
        private double subtotal;

        public Detalle()
        {
        }

        public Detalle(long idDetalle, long idProducto, long idFactura, int cantidad, double precioUnitario, double subtotal)
        {
            this.idDetalle = idDetalle;
            this.idProducto = idProducto;
            this.idFactura = idFactura;
            this.cantidad = cantidad;
            this.precioUnitario = precioUnitario;
            this.subtotal = subtotal;
        }

        public long IdDetalle { get => idDetalle; set => idDetalle = value; }
        public long IdProducto { get => idProducto; set => idProducto = value; }
        public long IdFactura { get => idFactura; set => idFactura = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
        public double Subtotal { get => subtotal; set => subtotal = value; }
    }


}




