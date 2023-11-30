using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Unidades
    {
        #region Propiedades
        private List<BE_Alquiler> lista_Alquiler;
        public int Codigo { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public string Direccion { get; set; }
        public int Ambientes { get; set; }
        public int Plaza { get; set; }
        public decimal PrecioDia { get; set; }
        public bool Estado { get; set; }
        public List<BE_Alquiler> Lista_Alquiler { get => lista_Alquiler; set => lista_Alquiler = value; }
        #endregion

        public BE_Unidades()
        {
            Lista_Alquiler = new List<BE_Alquiler>();
        }

        public override string ToString()
        {
            if (Estado)
            {
                return String.Format($"Unidad: #{Codigo} - {Direccion} - Disponible ");
            }             
            else
                return String.Format($"Unidad: #{Codigo} - {Direccion} - No Disponible ");
        }
    }
}
