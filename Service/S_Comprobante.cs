using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public static class S_Comprobante
    {
        public static string factura = "Factura";
        public static string cobro = "Cobro";
        public static string alquiler = "Alquiler";
        public static void CrearComprobante(string carpeta, string nombreArchivo, string tipoComprobante, string cliente, string numero, string fecha, string descripcion, string total)
        {
            try
            {
                string directorio = Path.Combine(Directory.GetCurrentDirectory(), carpeta);
                string ruta = Path.Combine(directorio, $"{nombreArchivo}.txt");

                if (!Directory.Exists(directorio))
                    Directory.CreateDirectory(directorio);

                using (StreamWriter writer = new StreamWriter(ruta))
                {

                    writer.WriteLine("     #- ALQUISOFT -#");
                    writer.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.");
                    writer.WriteLine($"Fecha: {fecha}");
                    writer.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.");
                    writer.WriteLine($"{tipoComprobante}: {numero}");                    
                    writer.WriteLine($"Cliente: {cliente}");
                    writer.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.");
                    if (!string.IsNullOrEmpty(descripcion))
                        writer.WriteLine($"Descripción: {descripcion}");
                    if (!string.IsNullOrEmpty(total))
                        writer.WriteLine($"Total: ${total}");
                }
                AbrirComprobante(ruta);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void AbrirComprobante(string ruta)
        {
            try
            {
                Process.Start("notepad.exe", ruta);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
