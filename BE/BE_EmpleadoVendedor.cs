using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_EmpleadoVendedor:BE_Empleado
    {
        #region Propiedades
        private string polimor;
        public string SectorV { get => polimor; set => polimor = value; }
        #endregion

        #region Constructor
        public BE_EmpleadoVendedor() : base()
        {

        }
        #endregion
        #region Constructor Sobrecargado
        public BE_EmpleadoVendedor(int Nro_Legajo, string Nombre, string Apellido) : base(Nro_Legajo, Nombre, Apellido)
        {

        }
        #endregion
        #region Polimorfismo
        public override string EmpleadoPuesto(BE_Empleado e)
        {
            if (e is BE_EmpleadoVendedor)
            {
                return this.SectorV = "Ventas";

            }
            else
            {
                return "";
            }
        }

        #endregion
    }
}
