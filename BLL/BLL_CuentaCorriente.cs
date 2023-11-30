using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_CuentaCorriente
    {
        private MPP_CuentaCorriente _mPP;
        public BLL_CuentaCorriente()
        {
            _mPP = new MPP_CuentaCorriente();
        }

        public List<BE_CuentaCorriente> ObtenerCuentaCorriente(List<BE_ComprobanteCobroAlquiler> cobros, List<BE_ComprobanteFactura> facturas)
        {
            try
            {
                return _mPP.ObtenerCuentaCorriente(cobros, facturas);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public decimal ObtenerSaldo(List<BE_CuentaCorriente> ctacte)
        {
            try
            {
                return _mPP.ObtenerSaldo(ctacte);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
