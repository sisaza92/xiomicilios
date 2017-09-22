using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Detalle
    {
        public void InsertarDetalle(Entidades.Detalle detalle)
        {
            Datos.Detalle datoDetalle = new Datos.Detalle();
            datoDetalle.InsertarDetalle(detalle);
            //BuscarCliente(); 

        }
        //public IList<Entidades.Cliente> BuscarCliente()
        //{
        //    IList<Entidades.Cliente> todosClientes = new List<Entidades.Cliente>();
        //    Datos.Cliente instanciaClienteDatos = new Datos.Cliente();
        //    todosClientes = instanciaClienteDatos.BuscarCliente();
        //    return todosClientes;
        //}

        public void EliminarDetalle(Entidades.Detalle detalle)
        {
            Datos.Detalle instanciaDetalleDatos = new Datos.Detalle();
            instanciaDetalleDatos.EliminarDetalle(detalle);
        }
        //public void ActualizarCliente(Entidades.Cliente cliente)
        //{
        //    Datos.Cliente datoCliente = new Datos.Cliente();
        //    datoCliente.ActualizarCliente(cliente);
        //    //BuscarCliente(); 
        //}
        //public Entidades.Cliente BuscarIdCliente(string Documento)
        //{
        //    Datos.Cliente instanciaClienteDatos = new Datos.Cliente();
        //    return instanciaClienteDatos.BuscarIdCliente(Documento);
        //}
    }
}