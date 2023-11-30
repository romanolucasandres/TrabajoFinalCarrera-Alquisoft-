using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_GenerarComprobante
    {
        public const string Facturas = "Facturas";
        public const string Cobros = "Cobros";
        public const string Alquileres = "Alquileres";
        public void CrearComprobante(string carpeta, string nombrearchivo, string tipocomprobante, string cliente, string numero, string fecha, string detalle, string importe)
        {
            try
            {
                S_ImprimirComprobantes.CrearComprobante(carpeta, nombrearchivo, tipocomprobante, cliente, numero, fecha, detalle, importe);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
