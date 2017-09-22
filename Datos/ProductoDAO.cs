using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    class ProductoDAO
    {
        public IList<Entidades.Producto> ListarProductos()
        {
            Conectividad aux = new Conectividad();
            SqlCommand cmd = new SqlCommand();
            {
                cmd.Connection = aux.conectar();
                cmd.CommandText = "spr_productos_por_categoria";
                cmd.CommandType = CommandType.StoredProcedure;
            };

            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            IList<Entidades.Producto> productList = new List<Entidades.Producto>();
            Entidades.Producto producto;
            while (sqlDataReader.Read())
            {
                producto = new Entidades.Producto
                {
                    IdProducto = long.Parse(sqlDataReader["idProducto"].ToString().Trim()),
                    IdCategoria = long.Parse(sqlDataReader["idCategoria"].ToString().Trim()),
                    Descripcion = sqlDataReader["descripcion"].ToString().Trim(),
                    NombreProducto = sqlDataReader["nombreProducto"].ToString().Trim(),
                    PrecioProducto = Double.Parse(sqlDataReader["precioProducto"].ToString().Trim()),
                    FechaProducto = DateTime.Parse(sqlDataReader["fechaProducto"].ToString().Trim()),
                    ActivoProducto = bool.Parse(sqlDataReader["activoProducto"].ToString())
                    //Imagen
                };

                productList.Add(producto);
            }

            aux.conectar();

            return productList;
        }
    }
}
