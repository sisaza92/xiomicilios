using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ProductoBL
    {
        public IList<Entidades.Producto> ListarProductos(long idCategoria)
        {
            Datos.ProductoDAO datosProducto = new Datos.ProductoDAO();
            return datosProducto.ListarProductos(idCategoria);
        }
    }
}
