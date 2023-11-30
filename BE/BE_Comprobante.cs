using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class BE_Comprobante
    {
        #region Propiedades
        private int nroComprobante;
        private decimal total;
        private string medio;
        private DateTime fecha;
        private BE_Cliente cliente;

        public int NroComprobante { get => nroComprobante; set => nroComprobante = value;}          
        public decimal ImporteTotal { get => total; set => total = value; }
        public string Medio { get => medio; set => medio = value; }        
        public DateTime Fecha { get => fecha; set => fecha = value; }        
        public BE_Cliente ClienteComprobante { get => cliente; set => cliente = value; }
        #endregion

        
    }
}
