using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERFACES
{
    public interface I_Existe<T, TT>
    {
        T ExisteObjeto(TT objeto);
    }
}
