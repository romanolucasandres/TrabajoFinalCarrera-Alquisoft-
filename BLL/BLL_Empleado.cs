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
    public class BLL_Empleado : I_ABM<BE_Empleado>, I_Traer<BE_Empleado>
    {
        MPP_Empleado _mPP;

        public BLL_Empleado()
        {
            _mPP = new MPP_Empleado();
        }
        public void Alta(BE_Empleado x)
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

        public void Baja(BE_Empleado x)
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

        public void Modificacion(BE_Empleado x)
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

        public List<BE_Empleado> Traer()
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
    }
}
