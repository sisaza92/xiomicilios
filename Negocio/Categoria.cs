using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Categoria
    {
        //public void InsertarDetalle(Entidades.Detalle detalle)
        //{
        //    Datos.Detalle datoDetalle = new Datos.Detalle();
        //    datoDetalle.InsertarDetalle(detalle);
        //    //BuscarCliente(); 

        //}
        public IList<Entidades.Categoria> ListarCategoria()
        {
            IList<Entidades.Categoria> todosCategorias = new List<Entidades.Categoria>();
            Datos.Categoria instanciaCategoriaDatos = new Datos.Categoria();
            todosCategorias = instanciaCategoriaDatos.ListarCategoria();
            return todosCategorias;
        }

        //public void EliminarDetalle(Entidades.Detalle detalle)
        //{
        //    Datos.Detalle instanciaDetalleDatos = new Datos.Detalle();
        //    instanciaDetalleDatos.EliminarDetalle(detalle);
        //}
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