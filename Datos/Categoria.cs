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
  public  class Categoria
    { 
        public IList<Entidades.Categoria> ListarCategoria()
        {
            Conectividad aux = new Conectividad();
            SqlCommand cmd = new SqlCommand();
            {
                cmd.Connection = aux.conectar();
                cmd.CommandText = "spr_listar_categorias";
                cmd.CommandType = CommandType.StoredProcedure;
            };

            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            IList<Entidades.Categoria> categoriaList = new List<Entidades.Categoria>();
            Entidades.Categoria categoria;
            while (sqlDataReader.Read())
            {
                categoria = new Entidades.Categoria
                {
                    IdCategoria = long.Parse(  sqlDataReader["idCategoria"].ToString()),
                    NombreCategoria = sqlDataReader["nombreCategoria"].ToString().Trim(),
                    FechaCategoria = DateTime.Parse( sqlDataReader["fechaCategoria"].ToString()),
                    ActivoCategoria = bool.Parse( sqlDataReader["activoCategoria"].ToString()),
                    //ImagenCategoria =sqlDataReader["imagenCategoria"].ToString(), falta convertir imagen
                    //Activo = bool.Parse(sqlDataReader["activo"].ToString())  
                    //SegundoApellido = sqlDataReader[COLUMN_SEGUNDO_APELLIDO].ToString(),
                    //FechaNacimiento = new DateTime(),
                    //Direccion = sqlDataReader[COLUMN_TELEFONO].ToString(),
                    //Telefono = sqlDataReader[COLUMN_DIRECCION].ToString()
                };

                categoriaList.Add(categoria);
            }

            aux.conectar();

            return categoriaList;

        }
    }
}

