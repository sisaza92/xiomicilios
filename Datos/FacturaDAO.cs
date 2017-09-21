using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class FacturaDAO
    {
        private static readonly string COLUMN_ID_FACTURA = "idFactura";
        private static readonly string COLUMN_ID_USUARIO = "idUsuario";
        private static readonly string COLUMN_TOTAL = "total";
        private static readonly string COLUMN_FECHA_FACTURA = "fechaFactura";
        private static readonly string COLUMN_ACTIVO_FACTURA = "activoFactura";

        private static readonly string PROCEDURE_INSERT = "spr_insertar_factura";

        Conectividad conectividad;
        SqlCommand sqlCommand;

        public void InsertarFactura(Entidades.Factura factura)
        {

            conectividad = new Conectividad();

            sqlCommand = new SqlCommand();
            sqlCommand.Connection = conectividad.conectar();

            sqlCommand.Parameters.Add(new SqlParameter("@" + COLUMN_ID_FACTURA, factura.IdFactura));
            sqlCommand.Parameters.Add(new SqlParameter("@" + COLUMN_ID_USUARIO, factura.IdUsuario));
            sqlCommand.Parameters.Add(new SqlParameter("@" + COLUMN_TOTAL, factura.Total));
            sqlCommand.Parameters.Add(new SqlParameter("@" + COLUMN_FECHA_FACTURA, factura.FechaFactura));
            sqlCommand.Parameters.Add(new SqlParameter("@" + COLUMN_ACTIVO_FACTURA, factura.ActivoFactura));

            sqlCommand.CommandText = PROCEDURE_INSERT;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.ExecuteNonQuery();

            conectividad.conectar();

        }
    }
}
