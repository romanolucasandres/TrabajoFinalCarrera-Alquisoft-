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
    public class BLL_Reporte : I_Traer<BE_Reporte>
    {
        MPP_Reporte _mPP;
        public BLL_Reporte()
        {
            _mPP = new MPP_Reporte();
        }
        public List<BE_Reporte> Traer()
        {
            try
            {
                return _mPP.Traer();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
