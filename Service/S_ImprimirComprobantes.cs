using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class S_ImprimirComprobantes
    {
        public static string Facturas = "Facturas";
        public static string Cobros = "Cobros";
        public static string Alquiler = "Alquileres";
        public static void CrearComprobante(string carpeta, string nombrearchivo, string tipocomprobante, string cliente, string numero, string fecha, string detalle, string importe)
        {
            try
            {
                string carpetabase = Path.Combine(Directory.GetCurrentDirectory(), carpeta);
                string rutabase = Path.Combine(carpetabase, $"{nombrearchivo}.txt");

                if (!Directory.Exists(carpetabase))
                    Directory.CreateDirectory(carpetabase);

                using (StreamWriter writer = new StreamWriter(rutabase))
                {
                    writer.WriteLine("#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#");
                    writer.WriteLine("-------------------------ALQUISOFT-----------------------");
                    writer.WriteLine("#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#");
                    writer.WriteLine($"Tipo: {tipocomprobante}");
                    writer.WriteLine($"Número: {numero}");
                    writer.WriteLine($"Fecha: {fecha}");
                    writer.WriteLine($"Cliente: {cliente}");
                    writer.WriteLine("---------------------------------------------------------");
                    if (!string.IsNullOrEmpty(detalle))
                        writer.WriteLine($"Detalle: {detalle}");
                    if (!string.IsNullOrEmpty(importe))
                        writer.WriteLine($"Importe: {importe}");


                }

                AbrirComprobante(rutabase);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void AbrirComprobante(string rutabase)
        {
            try
            {
                Process.Start("notepad.exe", rutabase);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
