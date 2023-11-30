using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Cliente
    {
        #region Propiedades
        private int nro_Cliente;
        private string nombre;
        private string apellido;
        private int Dni;
        private int telefono;
        private string pais;
        private string ciudad;

        public int Nro_Cliente { get => nro_Cliente; set => nro_Cliente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public int DNI { get => Dni; set => Dni = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Localidad { get => ciudad; set => ciudad = value; }
        #endregion




        public override string ToString()
        {
            return String.Format($"{nro_Cliente } - {Apellido}, {Nombre}");
        }
    }
}
