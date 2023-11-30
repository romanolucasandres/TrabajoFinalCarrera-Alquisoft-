using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using BE;

namespace MPP
{
    public class MPP_Reporte
    {
        private AccesoBD bd;

        public MPP_Reporte()
        {
            bd = new AccesoBD();
        }

        public List<BE_Reporte> Traer()
        {
            try
            {
                XElement XML = bd.Cargar_Xelement();
                var leer = from Alquiler in XML.Elements("Alquileres").Elements("Alquiler")
                           select new BE_Reporte
                           {
                               CodigoAlquiler = Convert.ToInt32(Alquiler.Attribute("id")?.Value.Trim()),
                               FechaI = Convert.ToDateTime(Alquiler.Element("fechaingreso")?.Value.Trim()),
                               FechaE = Convert.ToDateTime(Alquiler.Element("fechaegreso")?.Value.Trim()),
                               ClienteAlquiler = Convert.ToInt32(Alquiler.Element("cliente")?.Value.Trim()),
                               Unidades = Convert.ToInt32(Alquiler.Element("unidad")?.Value.Trim()),
                               Vendedor = Convert.ToInt32(Alquiler.Element("vendedor")?.Value.Trim())
                           };

                List<BE_Reporte> Lista = leer.ToList();
                return Lista;
            }
            catch (XmlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
