using BE;
using INTERFACES;
using MPP;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Login : I_Traer<BE_Usuario>
    {
        MPP_Login _mPP;

        public BLL_Login()
        {
            _mPP = new MPP_Login();
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

        public List<BE_Usuario> Admin()
        {
            try
            {
                return _mPP.Obtener_Admin();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public bool EsAdmin(BE_Usuario x)
        {
            try
            {
                return _mPP.EsAdmin(x);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public bool Validar(BE_Usuario x, string constraseña)
        {
            try
            {
                return _mPP.Validar(x, constraseña);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public bool Validar(string constraseña)
        {
            try
            {
                return _mPP.Validar(constraseña);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
}
