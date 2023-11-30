using BE;
using INTERFACES;
using MPP;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Unidad : I_ABM<BE_Unidades>, I_Traer<BE_Unidades>
    {
        MPP_Unidad _mPP;
        public BLL_Unidad()
        {
            _mPP = new MPP_Unidad(); 
        }

        public void Alta(BE_Unidades x)
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

        public void Baja(BE_Unidades x)
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

        public void Modificacion(BE_Unidades x)
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

        public List<BE_Unidades> Traer()
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
        public List<BE_Unidades> Traer(string estado)
        {

            try
            {
                return _mPP.Traer(estado);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public string ObtenerUltimoCodigo()
        {
            try
            {
                return _mPP.ObtenerUltimoCodigo();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<BE_Unidades> ObtenerUnidadesDisponibles(DateTime ingreso,DateTime egreso)
        {
            try
            {
                return _mPP.ObtenerUnidadesDisponibles(ingreso,egreso);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
