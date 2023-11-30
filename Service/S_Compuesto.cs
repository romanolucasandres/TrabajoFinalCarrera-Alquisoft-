using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class S_Compuesto : S_Componente
    {
        private List<S_Componente> listaComponente;

        public S_Compuesto() : base()
        {
            listaComponente = new List<S_Componente>();
        }
        public S_Compuesto(string str) : base(str)
        {
            listaComponente = new List<S_Componente>();
        }

        public S_Compuesto(int nro, string str) : base(nro, str)
        {
            listaComponente = new List<S_Componente>();
        }

        public S_Compuesto(int nro, string str, bool visible) : base(nro, str, visible)
        {
            listaComponente = new List<S_Componente>();
        }
        public override void AgregarNodo(S_Componente c)
        {
            if (c != null)
            {
                listaComponente.Add(c);
            }
        }
        public override List<S_Componente> ObtenerLista()
        {
            return listaComponente;
        }
        public override string ToString()
        {
            return $"{Nombre}";
        }

    }
}
