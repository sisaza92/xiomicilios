using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace Servicios
{
    [ServiceContract]
    public interface Iusuario
    {
        [OperationContract]
        void InsertarCliente(Entidades.Cliente cliente);
        //[OperationContract]
        //IList<Entidades.Cliente> BuscarCliente();
        [OperationContract]
        void EliminarCliente(Entidades.Cliente cliente);
        [OperationContract]
        void ActualizarCliente(Entidades.Cliente cliente);
        //[OperationContract]
        //Entidades.Cliente BuscarIdCliente(string Documento);

    }
}