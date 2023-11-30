using INTERFACES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;
using MPP;

namespace BLL
{
    public class BLL_Permiso : I_ABM<S_Componente>
    {
        MPP_Permiso _mPP;
        public BLL_Permiso()
        {
            _mPP = new MPP_Permiso();
        }
        public void Alta(S_Componente x)
        {
            try
            {
                _mPP.Alta(x);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void Baja(S_Componente x)
        {
            try
            {
                _mPP.Baja(x);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Modificacion(S_Componente x)
        {
            try
            {
                _mPP.Modificacion(x);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public S_Componente Traer(S_Componente x)
        {
            try
            {
                return _mPP.Traer(x);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
