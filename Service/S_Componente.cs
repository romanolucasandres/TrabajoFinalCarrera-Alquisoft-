using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public abstract class S_Componente
    {
        private int nro;
        private string nombre;
        private bool esVisible;


        public string Nombre { get => nombre; }
        public int Numero { get => nro; }
        [Browsable(false)]
        public bool Visible { get => esVisible; }

        public S_Componente()
        {

        }
        public S_Componente(string str)
        {
            nombre = str;
        }

        public S_Componente(int id, string str)
        {
            nro = id;
            nombre = str;
        }

        public S_Componente(string str, bool visible)
        {
            nombre = str;
            esVisible = visible;
        }
        public S_Componente(int id, string str, bool visible)
        {
            nro = id;
            nombre = str;
            esVisible = visible;
        }

        public void Cambiarvisible(bool cambio)
        {
            esVisible = cambio;
        }

        public abstract void AgregarNodo(S_Componente c);
        public abstract List<S_Componente> ObtenerLista();
    }
}
