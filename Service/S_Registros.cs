using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public static class S_Registros
    {
        private const string archivo_txt = "Log.txt";
        private const string directorioBackup = "Logs";
        private static string rutaBitacoraBase = Path.Combine(Directory.GetCurrentDirectory(), directorioBackup);
        private static string rutaBitacoraCompleta = Path.Combine(rutaBitacoraBase, archivo_txt);

        public static void RegistrarSuceso(string suceso)
        {
            try
            {
                CrearCarpetaArchivo();
                using (StreamWriter sw = File.AppendText(rutaBitacoraCompleta))
                {
                    string msje = $"{DateTime.Now}: ({S_UsuarioLogueado.Usuario}) {suceso}";
                    sw.WriteLine(msje);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private static void CrearCarpetaArchivo()
        {
            try
            {
                if (!Directory.Exists(rutaBitacoraBase))
                    Directory.CreateDirectory(rutaBitacoraBase);
                if (!File.Exists(rutaBitacoraCompleta))
                {
                    using (File.Create(rutaBitacoraCompleta)) { }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<string> ObtenerDatosArchivo()
        {
            List<string> listaDatos = new List<string>();
            try
            {
                CrearCarpetaArchivo();
                listaDatos = File.ReadLines(rutaBitacoraCompleta)?.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listaDatos;
        }

        
    }
}
