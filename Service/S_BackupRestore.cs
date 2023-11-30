using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public static class S_BackupRestore
    {
        private const string nombrebasededatos = "Alquisoft.xml";
        private const string nombredirectorioBackup = "BackupAlquisoft";
        private static string rutadirectoriobase = Directory.GetCurrentDirectory();
        private static string rutafinalrestore = Path.Combine(rutadirectoriobase, nombrebasededatos);
        private static string rutafinalbackup = Path.Combine(rutadirectoriobase, nombredirectorioBackup);

        public static string Backup(DateTime fecha)
        {
            string mensaje = "No se pudo realizar el backup";
            try
            {
                string nombrearchivo = $"Alquisoft-{fecha.ToString("yyyy-MM-dd-HH-mm-ss")}-{S_UsuarioLogueado.Usuario}.xml";
                if (Directory.Exists(rutafinalbackup))
                {
                    if (File.Exists(rutafinalrestore))
                    {
                        string ruta = Path.Combine(rutafinalbackup, nombrearchivo);
                        File.Copy(rutafinalrestore, ruta, false);
                        mensaje = "Backup Realizado";
                        S_Registros.RegistrarSuceso($"{mensaje}--{nombrearchivo}");
                    }
                }
                else
                {
                    Directory.CreateDirectory(rutafinalbackup);
                    Backup(fecha);
                }
            }
            catch (Exception ex)
            {
                S_Registros.RegistrarSuceso($"{ex.ToString()}");
                throw ex;

            }
            return mensaje;
        }

        public static string Restore(string nombrearchivo)
        {
            string mensaje = "No se pudo realizar el restore";
            try
            {
                if (Directory.Exists(rutafinalbackup))
                {
                    string rutacompletaseleccionado = Path.Combine(rutafinalbackup, nombrearchivo);
                    File.Copy(rutacompletaseleccionado, rutafinalrestore, true);
                    mensaje = "Restore Realizado";
                    S_Registros.RegistrarSuceso($"{mensaje}--{nombrearchivo}");
                }
                else
                {
                    Directory.CreateDirectory(rutafinalbackup);
                    Restore(nombrearchivo);
                }
            }
            catch (Exception ex)
            {
                S_Registros.RegistrarSuceso($"{ex.ToString()}");
                throw ex;
            }
            return mensaje;
        }

        public static List<string> ObtenerListaArchivos()
        {
            List<string> archivos = new List<string>();
            try
            {
                if (Directory.Exists(rutafinalbackup))
                {
                    DirectoryInfo info = new DirectoryInfo(rutafinalbackup);
                    foreach (var item in info.GetFiles())
                    {
                        if (item != null)
                        {
                            archivos.Add(item.Name);
                        }
                    }

                }
                else
                {
                    Directory.CreateDirectory(rutafinalbackup);
                    ObtenerListaArchivos();
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }
            return archivos;


        }

        public static string ObtenerRutaBackup()
        {
            try
            {
                if (!Directory.Exists(rutafinalbackup))
                    Directory.CreateDirectory(rutafinalbackup);

                return rutafinalbackup;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
