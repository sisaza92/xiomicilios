using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioXiomicilios" in both code and config file together.
    [ServiceContract]
    public interface IServicioXiomicilios
    {
        [OperationContract]
        [WebInvoke(Method = "*", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "registrarUsuario")]
        void RegistrarUsuario(Entidades.Cliente cliente);

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "listarProductos/{idCategoria}")]
        IList<Entidades.Producto> ListarProductos(String idCategoria);

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "listarCategorias")]
        IList<Entidades.Categoria> ListarCategorias();

        [OperationContract]
        [WebInvoke(Method = "*", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,BodyStyle =WebMessageBodyStyle.Wrapped, UriTemplate = "login")]
        Entidades.Cliente Login(String usuario, String contrasena);

        [OperationContract]
        [WebInvoke(Method = "*", RequestFormat =WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "actualizarPerfil")]
        void ActualizarPerfil(Entidades.Cliente cliente);

    }


}
