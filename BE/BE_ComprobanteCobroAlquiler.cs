using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_ComprobanteCobroAlquiler:BE_Comprobante
    {
        #region Propiedades
        private BE_ComprobanteFactura n_Factura;
        public BE_ComprobanteFactura N_Factura { get => n_Factura; set => n_Factura = value; }
        #endregion

        #region Constructor
        public BE_ComprobanteCobroAlquiler()
        {
            ClienteComprobante = new BE_Cliente();
        }
        #endregion
        public override string ToString()
        {
            return $"Comprobante Número {this.NroComprobante}";
        }
        
    }
}
