using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_CuentaCorriente
    {
        #region Propiedades

        #endregion
        private string tipoComprobante;
        private int nroComprobante;
        private decimal montoFactura;
        private decimal montoCobro;
        private DateTime fecha;
        
        public const string factura = "Factura de Alquiler";
        public const string CobroDeAlquiler = "Cobro de Alquiler";
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int NroComprobante { get => nroComprobante; set => nroComprobante = value; }
        public string TipoComprobante { get => tipoComprobante; set => tipoComprobante = value; }
        public decimal MontoFactura { get => montoFactura; set => montoFactura = value; }
        public decimal MontoCobro { get => montoCobro; set => montoCobro = value; }
    }
}
