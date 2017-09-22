using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Datos
{
    public class Detalle
    {
        public void InsertarDetalle(Entidades.Detalle detalle)
        {
            Conectividad aux = new Conectividad();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = aux.conectar();
            SqlParameter parametroNombre = new SqlParameter();

        

            parametroNombre.ParameterName = "@idDetalle";
            parametroNombre.Value = detalle.IdDetalle;
            cmd.Parameters.Add(parametroNombre);
            cmd.Parameters.Add(new SqlParameter("@precioUnitario", detalle.PrecioUnitario));
            cmd.Parameters.Add(new SqlParameter("@subtotal", detalle.Subtotal));
            cmd.Parameters.Add(new SqlParameter("@cantidad", detalle.Cantidad));
            cmd.Parameters.Add(new SqlParameter("@factura", detalle.Factura));
            //cmd.Parameters.Add(new SqlParameter("@fechaUsuario", cliente.FechaCliente));
            cmd.CommandText = "spr_InsertarDetalle";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            aux.conectar();
            
           
      
    }

        //public void BuscarCliente(Entidades.Cliente clienteList)
        //{
        //    throw new NotImplementedException();
        //}

        //public IList<Entidades.Cliente> BuscarCliente()
        //{
        //    Conectividad aux = new Conectividad();
        //    SqlCommand cmd = new SqlCommand();
        //    {
        //        cmd.Connection = aux.conectar();
        //        cmd.CommandText = "spr_BuscarCliente";
        //        cmd.CommandType = CommandType.StoredProcedure;
        //    };

        //    SqlDataReader sqlDataReader = cmd.ExecuteReader();

        //    IList<Entidades.Cliente> clienteList = new List<Entidades.Cliente>();
        //    Entidades.Cliente cliente;
        //    while (sqlDataReader.Read())
        //    {
        //        cliente = new Entidades.Cliente
        //        {
        //            Documento = sqlDataReader["Documento"].ToString().Trim(),
        //            Ciudad = sqlDataReader["Ciudad"].ToString().Trim(),
        //            Nombre = sqlDataReader["Nombre"].ToString().Trim(),
        //            Correo = sqlDataReader["Correo"].ToString().Trim(),
        //            Apellido = sqlDataReader["Apellido"].ToString().Trim(),
        //            Activo = bool.Parse(sqlDataReader["activo"].ToString())
        //            //SegundoApellido = sqlDataReader[COLUMN_SEGUNDO_APELLIDO].ToString(),
        //            //FechaNacimiento = new DateTime(),
        //            //Direccion = sqlDataReader[COLUMN_TELEFONO].ToString(),
        //            //Telefono = sqlDataReader[COLUMN_DIRECCION].ToString()
        //        };

        //        clienteList.Add(cliente);
        //    }

        //    aux.conectar();

        //    return clienteList;

        //}



        public void EliminarDetalle(Entidades.Detalle detalle)
        {
            Conectividad aux = new Conectividad();
            SqlCommand cmd = new SqlCommand();
            {
                cmd.Connection = aux.conectar();
                cmd.Parameters.Add(new SqlParameter("@idDetalle", detalle.IdDetalle));
                cmd.CommandText = "spr_EliminarDetalle";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
            };

            cmd.Connection = aux.conectar();

            //< a href = "javascript:__doPostBack('GridView','Delete$0')" > Delete </ a >



        }

        //public void ActualizarDetalle(Entidades.Detalle detalle)
        //{

        //    Conectividad aux = new Conectividad();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = aux.conectar();
        //    SqlParameter parametroNombre = new SqlParameter();
        //    parametroNombre.ParameterName = "@nombreUsuario";
        //    parametroNombre.Value = cliente.NombreCliente;
        //    cmd.Parameters.Add(parametroNombre);
        //    cmd.Parameters.Add(new SqlParameter("@Apellido", cliente.Apellido));
        //    cmd.Parameters.Add(new SqlParameter("@Ciudad", cliente.Ciudad));
        //    cmd.Parameters.Add(new SqlParameter("@Correo", cliente.Correo));
        //    cmd.Parameters.Add(new SqlParameter("@usuario", cliente.Usuario));
        //    cmd.Parameters.Add(new SqlParameter("@idUsuario", cliente.IdCliente));
        //    cmd.Parameters.Add(new SqlParameter("@contrasena", cliente.Contrasena));
        //    cmd.Parameters.Add(new SqlParameter("@direccion", cliente.Direccion));
        //    cmd.Parameters.Add(new SqlParameter("@activoUsuario", cliente.ActivoCliente));
        //    cmd.Parameters.Add(new SqlParameter("@telefono", cliente.Telefono));
        //    cmd.Parameters.Add(new SqlParameter("@fechaUsuario", cliente.FechaCliente));
        //    cmd.CommandText = "spr_ActualizarCliente";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.ExecuteNonQuery();
        //    aux.conectar();



        //}
    }
}

//        public Entidades.Cliente BuscarIdCliente(string Documento)
//        {
//            Conectividad aux = new Conectividad();
//            SqlCommand cmd = new SqlCommand();
//            {
//                cmd.Connection = aux.conectar();
//                cmd.CommandText = "spr_BuscarIdCliente";
//                cmd.CommandType = CommandType.StoredProcedure;
//            };
//            cmd.Parameters.Add(new SqlParameter("@Documento", Documento));
//            SqlDataReader sqlDataReader = cmd.ExecuteReader();

//            sqlDataReader.Read();
//            Entidades.Cliente cliente = new Entidades.Cliente
//            {
//                Documento = sqlDataReader["Documento"].ToString().Trim(),
//                Ciudad = sqlDataReader["Ciudad"].ToString().Trim(),
//                Nombre = sqlDataReader["Nombre"].ToString().Trim(),
//                Correo = sqlDataReader["Correo"].ToString().Trim(),
//                Apellido = sqlDataReader["Apellido"].ToString().Trim(),
//                Activo = bool.Parse(sqlDataReader["activo"].ToString())
//                //SegundoApellido = sqlDataReader[COLUMN_SEGUNDO_APELLIDO].ToString(),
//                //FechaNacimiento = new DateTime(),
//                //Direccion = sqlDataReader[COLUMN_TELEFONO].ToString(),
//                //Telefono = sqlDataReader[COLUMN_DIRECCION].ToString()
//            };

//            sqlDataReader.Close();
//            aux.conectar();

//            return cliente;

//        }

//    }
//}