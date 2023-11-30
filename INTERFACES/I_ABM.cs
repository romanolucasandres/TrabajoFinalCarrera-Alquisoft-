using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERFACES
{
    public interface I_ABM<T>
    {
        #region Metodos ABM
        void Alta(T x);
        void Baja(T x);
        void Modificacion(T x);
        #endregion

    }
}
