using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Usuario
    {
        #region Propiedades
        private string contraseña;
        private BE_Empleado empleado;
        private bool admin;

        [Browsable(false)]
        public string Contraseña {get => contraseña; set => contraseña = value;}

        public BE_Empleado Empleado{ get => empleado; set => empleado = value;}

        [Browsable(false)]
        public bool Admin{ get => admin; set => admin = value;}


        #endregion
        public override string ToString()
        {
            return $"{this.Empleado.N_Legajo} {Empleado.Apellido} {Empleado.Nombre}";
        }

    }
}
