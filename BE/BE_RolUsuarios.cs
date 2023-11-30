using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_RolUsuarios
    {
        #region Propiedades
        private int id_Rol;
        private int id_Usuario;

        public int Id_Rol { get => id_Rol; set => id_Rol = value; }
        public int Id_Usuario{ get => id_Usuario;  set => id_Usuario = value;}
        #endregion
    }
}
