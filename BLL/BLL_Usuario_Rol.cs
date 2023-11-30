using MPP;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Usuario_Rol
    {
        private MPP_Usuario_Rol _mPP;
        public BLL_Usuario_Rol()
        {
            _mPP = new MPP_Usuario_Rol();
        }
        public List<S_Compuesto> ObtenerRoles(int x)
        {
            try
            {
                return _mPP.ObtenerRolesAsociados(x);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Alta(List<S_Compuesto> listaroles, int x)
        {
            try
            {
                _mPP.Alta(listaroles, x);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Modificacion(List<S_Compuesto> listaroles, int x)
        {
            try
            {
                _mPP.Modificacion(listaroles, x);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
