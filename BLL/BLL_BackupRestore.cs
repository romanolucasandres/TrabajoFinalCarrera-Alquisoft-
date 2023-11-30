using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_BackupRestore
    {
        public string RealizarBackup(DateTime fecha)
        {
            try
            {
                return S_BackupRestore.Backup(fecha);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public string RealizarRestore(string nombrearchivo)
        {
            try
            {
                return S_BackupRestore.Restore(nombrearchivo);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<string> ObtenerArchivos()
        {
            try
            {
                return S_BackupRestore.ObtenerListaArchivos();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public string ObtenerRutaBackup()
        {
            try
            {
                return S_BackupRestore.ObtenerRutaBackup();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
