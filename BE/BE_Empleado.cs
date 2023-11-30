using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class BE_Empleado
    {
        #region Propiedades

        #endregion
        private int n_Legajo;
        private string nombre;
        private string apellido;
        
        public int N_Legajo { get => n_Legajo; set => n_Legajo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public BE_Empleado()
        {

        }

        public BE_Empleado(int n_Legajo, string nombre, string apellido)
        {
         
            this.N_Legajo = n_Legajo;
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public abstract string EmpleadoPuesto(BE_Empleado e);

        public override string ToString()
        {
            return String.Format($"Legajo {N_Legajo} - {Apellido}, {Nombre}");
        }


    }
}
