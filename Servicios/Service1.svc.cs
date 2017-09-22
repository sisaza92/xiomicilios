using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.ServiceModel.Description;
using System.Text;
namespace Servicios
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Service1
    {
        // To use HTTP GET, add [WebGet] attribute. (Default ResponseFormat is WebMessageFormat.Json)
        // To create an operation that returns XML,
        //     add [WebGet(ResponseFormat=WebMessageFormat.Xml)],
        //     and include the following line in the operation body:
        //         WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml";
        [OperationContract]
        [WebGet(UriTemplate ="servClientes")]
        
        public Entidades.Cliente DoWork()
        {
            Entidades.Cliente cliente = new Entidades.Cliente();
            cliente.NombreCliente = "fran";
            cliente.Apellido = "fabra";
            // Add your operation implementation here
            return cliente;
        }

        // Add more operations here and mark them with [OperationContract]
    }
}
