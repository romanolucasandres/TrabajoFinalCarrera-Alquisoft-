using INTERFACES;
using MPP;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Rol : I_ABM<S_Componente>,I_Traer<S_Componente>
    {
        MPP_Rol _mPP;
        public BLL_Rol()
        {
            _mPP = new MPP_Rol();
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

        public List<S_Componente> Traer()
        {
            try
            {
                return _mPP.Traer();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public S_Componente Traer(int rol)
        {
            try
            {
                return _mPP.TraerRol(rol);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
