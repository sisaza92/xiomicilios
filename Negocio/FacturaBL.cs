using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    class FacturaBL
    {
        public void InsertarFactura(Entidades.Factura factura)
        {
            Datos.FacturaDAO facturaDAO = new Datos.FacturaDAO();
            facturaDAO.InsertarFactura(factura);
        }
    }
}
