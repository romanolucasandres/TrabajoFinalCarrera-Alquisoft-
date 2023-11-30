using BE;
using INTERFACES;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Usuario : I_ABM<BE_Usuario>, I_Traer<BE_Usuario>
    {
        MPP_Usuario _mPP;

        public BLL_Usuario()
        {
            _mPP = new MPP_Usuario();
        }
        public void Alta(BE_Usuario x)
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

        public void Baja(BE_Usuario x)
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

        public void Modificacion(BE_Usuario x)
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

        public List<BE_Usuario> Traer()
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
        public List<BE_Usuario> ObtenerUsuario(int usuario, string pass)
        {
            try
            {
                return _mPP.ObtenerUsuario(usuario,pass);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
