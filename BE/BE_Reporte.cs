using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Reporte
    {
        #region Propiedades
        private int codigoAlquiler;
        private DateTime fechaI;
        private DateTime fechaE;
        private int cliente;
        private int unidades;
        private int vendedor;

        public int CodigoAlquiler { get => codigoAlquiler; set => codigoAlquiler = value; }
        public DateTime FechaI { get => fechaI; set => fechaI = value; }
        public DateTime FechaE { get => fechaE; set => fechaE = value; }
        public int ClienteAlquiler { get => cliente; set => cliente = value; }
        public int Unidades { get => unidades; set => unidades = value; }
        public int Vendedor { get => vendedor; set => vendedor  = value; }


        #endregion

        public BE_Reporte()
        {

        }
    }
}
