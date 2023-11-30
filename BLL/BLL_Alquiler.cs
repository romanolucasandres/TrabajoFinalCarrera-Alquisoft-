using BE;
using INTERFACES;
using MPP;
using System;
using Service;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Alquiler : I_Existe<bool, BE_Alquiler>, I_Traer<BE_Alquiler>
    {
        private MPP_Alquiler _mPP;
        public BLL_Alquiler()
        {
            _mPP = new MPP_Alquiler();
        }
        public void Alta(BE_Alquiler x)
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

        public void Baja(BE_Alquiler x)
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

        public void Modificacion(BE_Alquiler x,bool bool1)
        {
            try
            {
                _mPP.Modificacion(x);
                if (bool1)
                {
                    CrearAbrirComprobante(x);
                }
                    
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool ExisteObjeto(BE_Alquiler objeto)
        {
            try
            {
                return _mPP.ExisteObjeto(objeto);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<BE_Alquiler> Traer()
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
        public List<BE_Alquiler> Traer(DateTime? fechaingreso = null, DateTime? fechaegreso = null, bool? isfacturado = null)
        {
            try
            {
                return _mPP.Traer(fechaingreso,fechaegreso, isfacturado);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        } 
        public List<BE_Alquiler> Traer(DateTime? fechaingreso = null, bool? isfacturado = null)
        {
            try
            {
                return _mPP.Traer(fechaingreso, isfacturado);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool ExisteClienteAlquiler(BE_Cliente cliente, DateTime? fechainicio,DateTime? fechafin)
        {
            try
            {
                return _mPP.ExisteAlquilerCliente(cliente, fechainicio,fechafin);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool ExisteUnidadAlquiler(BE_Unidades unidad, DateTime? fechainicio, DateTime? fechafin)
        {
            try
            {
                return _mPP.ExisteAlquilerUnidad(unidad, fechainicio, fechafin);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public string ObtenerUltimoCodigoAlquiler()
        {
            try
            {
                return _mPP.ObtenerUltimoCodigoAlquiler();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

       
        public bool IsFacturado(BE_Alquiler x)
        {
            try
            {
                return _mPP.IsFacturado(x);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void CrearAbrirComprobante(BE_Alquiler x)
        {
            try
            {
                S_ImprimirComprobantes.CrearComprobante(S_ImprimirComprobantes.Alquiler, x.ToString(), x.ToString(),
                   x.Cliente.ToString(), x.Codigo.ToString(), x.FechaIngreso.ToString(), x.Unidad.ToString(),"");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
