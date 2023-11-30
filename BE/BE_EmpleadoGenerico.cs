using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_EmpleadoGenerico:BE_Empleado
    {
        #region Metodo Constructor
        public BE_EmpleadoGenerico() : base()
        {

        }
        #endregion
        #region Metodo Constructor Sobrecargado
        public BE_EmpleadoGenerico(int Nro_Legajo, string Nombre, string Apellido) : base(Nro_Legajo, Nombre, Apellido)
        {

        }
        #endregion
        public override string EmpleadoPuesto(BE_Empleado e)
        {
            return "";
        }
    }
}
