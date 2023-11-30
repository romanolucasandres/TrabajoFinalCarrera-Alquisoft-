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
    public class BLL_ComprobanteCobroAlquiler : I_ABM<BE_ComprobanteCobroAlquiler>, I_Traer<BE_ComprobanteCobroAlquiler>
    {
        MPP_ComprobanteCobroAlquiler _mPP;
        public BLL_ComprobanteCobroAlquiler()
        {
            _mPP = new MPP_ComprobanteCobroAlquiler();
        }
        public void Alta(BE_ComprobanteCobroAlquiler x)
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

        public void Baja(BE_ComprobanteCobroAlquiler x)
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

        public void Modificacion(BE_ComprobanteCobroAlquiler x)
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

        public List<BE_ComprobanteCobroAlquiler> Traer()
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
        public List<BE_ComprobanteCobroAlquiler> Traer(BE_Cliente cliente)
        {
            try
            {
                return _mPP.Traer(cliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<BE_ComprobanteCobroAlquiler> Traer(DateTime fecha)
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
        public decimal ObtenerCobradoFactura(BE_ComprobanteFactura factura)
        {
            try
            {
                return _mPP.ObtenerFacturaCobrada(factura);
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

        public void CrearAbrirComprobante(BE_ComprobanteCobroAlquiler x)
        {
            try
            {
                S_ImprimirComprobantes.CrearComprobante(S_ImprimirComprobantes.Cobros, x.ToString(), x.ToString(),
                   x.ClienteComprobante.ToString(), x.NroComprobante.ToString(), x.Fecha.ToString(), x.N_Factura.ToString(), x.ImporteTotal.ToString());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
