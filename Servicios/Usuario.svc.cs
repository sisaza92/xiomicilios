using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidades;

namespace Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Cliente : Iusuario
    {
        public void InsertarCliente(Entidades.Cliente cliente)
        {
            Negocio.Cliente negocioCliente = new Negocio.Cliente();
            negocioCliente.InsertarCliente(cliente);
        }

        //public IList<Entidades.Cliente> BuscarCliente()
        //{
        //    IList<Entidades.Cliente> todosClientes = new List<Entidades.Cliente>();
        //    Negocio.Cliente instanciaClienteNegocio = new Negocio.Cliente();
        //    todosClientes = instanciaClienteNegocio.BuscarCliente();
        //    return todosClientes;
        //}
        public void EliminarCliente(Entidades.Cliente cliente)
        {
            Negocio.Cliente instanciaClienteNegocio = new Negocio.Cliente();
            instanciaClienteNegocio.EliminarCliente(cliente);
        }

        public void ActualizarCliente(Entidades.Cliente cliente)
        {
            Negocio.Cliente negocioCliente = new Negocio.Cliente();
            negocioCliente.ActualizarCliente(cliente);
        }
        //public Entidades.Cliente BuscarIdCliente(string Documento)
        //{
        //    Negocio.Cliente instanciaClienteNegocio = new Negocio.Cliente();
        //    return instanciaClienteNegocio.BuscarIdCliente(Documento);
        //}
    }
}
