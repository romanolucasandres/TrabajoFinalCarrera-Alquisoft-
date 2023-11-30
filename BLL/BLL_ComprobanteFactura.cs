using BE;
using INTERFACES;
using MPP;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_ComprobanteFactura : I_ABM<BE_ComprobanteFactura>, I_Traer<BE_ComprobanteFactura>
    {
        MPP_ComprobanteFactura _mPP;
        public BLL_ComprobanteFactura()
        {
            _mPP = new MPP_ComprobanteFactura();
        }
        public void Alta(BE_ComprobanteFactura x)
        {
            try
            {
                _mPP.Alta(x);
                CrearAbrirComprobante(x);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Baja(BE_ComprobanteFactura x)
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

        public void Modificacion(BE_ComprobanteFactura x)
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

        public List<BE_ComprobanteFactura> Traer()
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

        public List<BE_ComprobanteFactura> Traer(DateTime fecha)
        {
            try
            {
                return _mPP.Traer(fecha);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<BE_ComprobanteFactura> Traer(BE_Cliente cliente, bool todos)
        {
            try
            {
                return _mPP.Traer(cliente, todos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BE_ComprobanteFactura Traer(int nrofactura)
        {
            try
            {
                return _mPP.Traer(nrofactura);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string ObtenerUltimoNumero()
        {
            try
            {
                return _mPP.ObtenerUltimoNumero();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public decimal ObtenerSubtotal(List<BE_Alquiler> alquileres)
        {
            try
            {
                return _mPP.ObtenerSubtotalAlquileres(alquileres);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public (decimal, decimal) CalcularValores(decimal subtotal, decimal porcentaje, bool esDescuento)
        {
            try
            {
                return _mPP.Calcular(subtotal, porcentaje, esDescuento);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void CrearAbrirComprobante(BE_ComprobanteFactura x)
        {
            try
            {
                S_ImprimirComprobantes.CrearComprobante(S_ImprimirComprobantes.Facturas, x.ToString(), x.ToString(),
                      x.ClienteComprobante.ToString(), x.NroComprobante.ToString(), x.Fecha.ToString(), x.Alquiler.ToString(), x.ImporteTotal.ToString());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
