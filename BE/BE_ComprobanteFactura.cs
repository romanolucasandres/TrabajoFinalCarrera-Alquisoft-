using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_ComprobanteFactura :BE_Comprobante
    {
        #region Propiedades
        private decimal subtotal;
        private decimal porcentaje;
        private decimal iva;
        private bool esdescuento;
        private bool estado;
        private BE_Alquiler alquiler;
        public decimal Subtotal {get => subtotal; set => subtotal = value; }
        public decimal Porcentaje { get => porcentaje; set => porcentaje = value; }       
        public decimal Iva { get => iva; set => iva = value; }
        public bool EsDescuento { get => esdescuento; set => esdescuento = value; }
        public bool EstadoPagado { get => estado; set => estado = value; }
        public BE_Alquiler Alquiler { get => alquiler; set => alquiler = value; }
        #endregion

        public BE_ComprobanteFactura()
        {
            ClienteComprobante = new BE_Cliente();
            Alquiler = new BE_Alquiler();
        }

        public override string ToString()
        {
            return String.Format($"Factura Número {this.NroComprobante}");
        }
    }
}
