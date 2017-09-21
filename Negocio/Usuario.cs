using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Cliente
    {
        public void InsertarCliente(Entidades.Cliente cliente)
        {
            Datos.Cliente datoCliente = new Datos.Cliente();
            datoCliente.InsertarCliente(cliente);
            //BuscarCliente(); 

        }
        //public IList<Entidades.Cliente> BuscarCliente()
        //{
        //    IList<Entidades.Cliente> todosClientes = new List<Entidades.Cliente>();
        //    Datos.Cliente instanciaClienteDatos = new Datos.Cliente();
        //    todosClientes = instanciaClienteDatos.BuscarCliente();
        //    return todosClientes;
        //}

        public void EliminarCliente(Entidades.Cliente cliente)
        {
            Datos.Cliente instanciaClienteDatos = new Datos.Cliente();
            instanciaClienteDatos.EliminarCliente(cliente);
        }
        public void ActualizarCliente(Entidades.Cliente cliente)
        {
            Datos.Cliente datoCliente = new Datos.Cliente();
            datoCliente.ActualizarCliente(cliente);
            //BuscarCliente(); 
        }
        //public Entidades.Cliente BuscarIdCliente(string Documento)
        //{
        //    Datos.Cliente instanciaClienteDatos = new Datos.Cliente();
        //    return instanciaClienteDatos.BuscarIdCliente(Documento);
        //}
    }
}