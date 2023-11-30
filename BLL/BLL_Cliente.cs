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
    public class BLL_Cliente : I_ABM<BE_Cliente>, I_Traer<BE_Cliente>, I_Existe<bool, int>
    {
        MPP_Cliente Cliente;

        public BLL_Cliente()
        {
            Cliente = new MPP_Cliente();
        }
        public void Alta(BE_Cliente x)
        {
            try
            {
                Cliente.Alta(x);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Baja(BE_Cliente x)
        {
            try
            {
                Cliente.Baja(x);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        

        public void Modificacion(BE_Cliente x)
        {
            try
            {
                Cliente.Modificacion(x);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool ExisteObjeto(int objeto)
        {
            try
            {
                return Cliente.ExisteObjeto(objeto);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<BE_Cliente> Traer()
        {
            try
            {
                return Cliente.Traer();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //este metodo es para el form buscar cliente
        public List<BE_Cliente> ObtenerClientesBusqueda(int dni)
        {
            try
            {
                
                 return Cliente.ObtenerListaClientes(dni);
                
              
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
 