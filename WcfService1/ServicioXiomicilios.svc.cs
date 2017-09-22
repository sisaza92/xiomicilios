using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidades;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioXiomicilios" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServicioXiomicilios.svc or ServicioXiomicilios.svc.cs at the Solution Explorer and start debugging.
    public class ServicioXiomicilios : IServicioXiomicilios
    {
        public Cliente ActualizarPerfil(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public IList<Categoria> ListarCategorias()
        {
            throw new NotImplementedException();
        }

        public IList<Producto> ListarProductos(string idCategoria)
        {
            Negocio.ProductoBL negocioProducto = new Negocio.ProductoBL();
            return negocioProducto.ListarProductos(long.Parse(idCategoria.Trim()));
        }

        public Cliente Login(string usuario, string contrasena)
        {
            Negocio.Cliente negocioCliente = new Negocio.Cliente();
            return negocioCliente.Login(usuario, contrasena);
        }

        public void RegistrarUsuario(Entidades.Cliente cliente)
        {
            Negocio.Cliente negocioCliente = new Negocio.Cliente();
            negocioCliente.InsertarCliente(cliente);
        }
    }
}
