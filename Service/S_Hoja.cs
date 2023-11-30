using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class S_Hoja : S_Componente
    {
        private List<S_Componente> listaComponente;


        public S_Hoja() : base()
        {

        }

        public S_Hoja(string str) : base(str)
        {
            listaComponente = new List<S_Componente>();
        }
        public S_Hoja(string str, bool visible) : base(str, visible)
        {

        }


        public S_Hoja(int nro, string str) : base(nro, str)
        {
            listaComponente = new List<S_Componente>();
        }
        public S_Hoja(int nro, string str, bool visible) : base(nro, str, visible)
        {
            listaComponente = new List<S_Componente>();
        }

        public override void AgregarNodo(S_Componente c)
        {
        }

        public override List<S_Componente> ObtenerLista()
        {
            return null;
        }
        public override string ToString()
        {
            return $"{Nombre}";
        }
    }
}
