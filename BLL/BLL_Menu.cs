using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;

namespace BLL
{
    public class BLL_Menu
    {
        private MPP_Menu _mPP;
        public BLL_Menu()
        {
            _mPP = new MPP_Menu();
        }
        public S_Componente Traer()
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

        public void Alta(S_Componente x)
        {
            try
            {
                _mPP.Alta_Modificar(x);
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

        }
    }
}
