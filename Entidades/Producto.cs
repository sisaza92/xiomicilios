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
    public class Producto
    {
        [DataMember]
        private long idProducto;
        [DataMember]
        private Categoria categoria;
        [DataMember]
        private string nombreProducto;
        [DataMember]
        private byte imagenProducto;
        [DataMember]
        private int precioProducto;
        [DataMember]
        private string descripcion;
        [DataMember]
        private DateTime fechaProducto;
        [DataMember]
        private bool activoProducto;

        public Producto()
        {

        }

        public Producto(long idProducto, Categoria categoria, string nombreProducto, byte imagenProducto, int precioProducto, string descripcion, DateTime fechaProducto, bool activoProducto)
        {
            this.idProducto = idProducto;
            this.categoria = categoria;
            this.nombreProducto = nombreProducto;
            this.imagenProducto = imagenProducto;
            this.precioProducto = precioProducto;
            this.descripcion = descripcion;
            this.fechaProducto = fechaProducto;
            this.activoProducto = activoProducto;
        }

        public long IdProducto { get => idProducto; set => idProducto = value; }
        public Categoria Categoria{ get => categoria; set => categoria = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public byte ImagenProducto { get => imagenProducto; set => imagenProducto = value; }
        public int PrecioProducto { get => precioProducto; set => precioProducto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime FechaProducto { get => fechaProducto; set => fechaProducto = value; }
        public bool ActivoProducto { get => activoProducto; set => activoProducto = value; }
    }
}






