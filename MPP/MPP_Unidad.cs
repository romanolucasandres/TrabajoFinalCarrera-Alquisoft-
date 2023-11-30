using BE;
using DAL;
using INTERFACES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.Collections;

namespace MPP
{
    public class MPP_Unidad : I_ABM<BE_Unidades>, I_Traer<BE_Unidades>
    {
        private AccesoBD bd;
        public MPP_Unidad()
        {
            bd = new AccesoBD();
        }
        public void Alta(BE_Unidades x)
        {
            try
            {
                XDocument XML = bd.Cargar_XML();
                if (XML != null)
                {

                    XML.Element("Alquisoft").Element("Unidades").Add(new XElement("Unidad",
                                                    new XAttribute("id", x.Codigo.ToString().Trim()),
                                                   new XElement("ciudad", x.Ciudad.ToString().Trim()),
                                                   new XElement("pais", x.Pais.ToString().Trim()),
                                                   new XElement("direccion", x.Direccion.ToString().Trim()),
                                                   new XElement("ambientes", x.Ambientes.ToString().Trim()),
                                                   new XElement("plazas", x.Plaza.ToString().Trim()),
                                                   new XElement("valordia", x.PrecioDia.ToString().Trim()),
                                                   new XElement("estado", x.Estado.ToString().Trim())
                                                   ));
                    bd.Guardar_XML(XML);

                }
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

        public void Baja(BE_Unidades x)
        {
            try
            {
                XDocument XML = bd.Cargar_XML();

                if (x.Lista_Alquiler?.Count > 0)
                {
                    throw new Exception("Esta unidad no se puede eliminar por estar asociado a un alquiler.");
                }
                if (XML != null)
                {
                    var leer = from Unidad in XML.Descendants("Unidad")
                               where Unidad.Attribute("id").Value == x.Codigo.ToString().Trim()
                               select Unidad;


                    leer.Remove();
                    bd.Guardar_XML(XML);
                }
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

        public void Modificacion(BE_Unidades x)
        {
            try
            {
                XDocument XML = bd.Cargar_XML();
                if (XML != null)
                {
                    var leer = from Unidad in XML.Descendants("Unidad")
                               where Unidad.Attribute("id").Value == x.Codigo.ToString().Trim()
                               select Unidad;

                    foreach (var item in leer)
                    {
                        item.Element("ciudad").Value = x.Ciudad.ToString().Trim();
                        item.Element("pais").Value = x.Pais.ToString().Trim();
                        item.Element("direccion").Value = x.Direccion.ToString().Trim();
                        item.Element("ambientes").Value = x.Ambientes.ToString().Trim();
                        item.Element("plazas").Value = x.Plaza.ToString().Trim();
                        item.Element("valordia").Value = x.PrecioDia.ToString().Trim();
                        item.Element("estado").Value = x.Estado.ToString().Trim();
                    }
                    bd.Guardar_XML(XML);
                }
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

        public List<BE_Unidades> Traer()
        {
            try
            {
                XElement XML = bd.Cargar_Xelement();
                var leer = from Alquiler in XML.Elements("Unidades").Elements("Unidad")
                           select new BE_Unidades
                           {
                               Codigo = Convert.ToInt32(Alquiler.Attribute("id").Value.Trim()),
                               Ciudad = Alquiler.Element("ciudad").Value.Trim(),
                               Pais = Alquiler.Element("pais").Value.Trim(),
                               Direccion = Alquiler.Element("direccion").Value.Trim(),
                               Ambientes = Convert.ToInt32(Alquiler.Element("ambientes").Value.Trim()),
                               Plaza = Convert.ToInt32(Alquiler.Element("plazas").Value.Trim()),
                               PrecioDia = Convert.ToDecimal(Alquiler.Element("valordia")?.Value.Trim()),
                               Lista_Alquiler = TraerRelacionAlquileres(Convert.ToInt32(Alquiler.Attribute("id").Value.Trim())),
                               Estado = Convert.ToBoolean(Alquiler.Element("estado").Value.Trim())
                           };

                List<BE_Unidades> Lista = leer.ToList<BE_Unidades>();
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

        public string ObtenerUltimoCodigo()
        {
            string codigoU = string.Empty;
            try
            {
                //orden DESC y primero en lista
                var unidad = this.Traer().OrderByDescending(x => x?.Codigo).Where(c => c?.Codigo != null).FirstOrDefault();
                if (unidad?.Codigo != null)
                {
                    codigoU = (unidad.Codigo + 1).ToString();
                }
                else
                {
                    codigoU = "1";
                }


            }
            catch (XmlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            return codigoU;
        }
        public List<BE_Unidades> Traer(string estado)
        {
            List<BE_Unidades> Lista = null;
            try
            {
               
                Lista = this.Traer();

                if (Lista != null)
                {
                    if (estado == "Disponible")
                        Lista = Lista.Where(i => i != null && i.Estado == true).ToList();
                    else if (estado == "No Disponible")
                        Lista = Lista.Where(j => j != null && j.Estado == false).ToList();
                }

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

        private List<BE_Alquiler> TraerRelacionAlquileres(int codigo)
        {
            List<BE_Alquiler> Lista = new List<BE_Alquiler>();
            try
            {


                XDocument XML = bd.Cargar_XML();
                if (XML != null)
                {
                    var leer = from Alquiler in XML.Descendants("Alquiler")
                               where Alquiler.Attribute("codigo").Value == codigo.ToString().Trim()
                               select Alquiler;
                    foreach (var item in leer)
                    {
                        if (item != null)
                        {
                            BE_Alquiler alquiler = new BE_Alquiler();

                            alquiler.Codigo = Convert.ToInt32(item.Attribute("codigo")?.Value.Trim());
                            alquiler.Cliente.DNI = Convert.ToInt32(item.Element("cliente")?.Value.Trim());
                            alquiler.FechaIngreso = Convert.ToDateTime(item.Element("fechaingreso")?.Value.Trim());
                            alquiler.FechaEgreso = Convert.ToDateTime(item.Element("fechaegreso")?.Value.Trim());
                            alquiler.Unidad.Codigo = Convert.ToInt32(item.Element("unidad")?.Value.Trim());
                            alquiler.Total = Convert.ToDecimal(item.Element("total")?.Value.Trim());
                            alquiler.Vendedor.N_Legajo = Convert.ToInt32(item.Element("vendedor")?.Value.Trim());
                            alquiler.IsFacturado = Convert.ToBoolean(item.Element("isfacturado")?.Value.Trim());
                            Lista.Add(alquiler);
                        }
                    }
                }
            }
            catch (XmlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            return Lista;

        }
        public List<BE_Unidades> ObtenerUnidadesDisponibles(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<BE_Unidades> RetornaLista = new List<BE_Unidades>();
            try
            {
                List<BE_Unidades> ListaUnidadesDisponibles = this.Traer().FindAll(k => k?.Estado == true);

                foreach (BE_Unidades unidad in ListaUnidadesDisponibles)
                {
                    bool existe = false;
                    if (unidad.Lista_Alquiler?.Count == 0 || unidad.Lista_Alquiler == null)
                        RetornaLista.Add(unidad);
                    else
                    {
                        foreach (BE_Alquiler alqui in unidad.Lista_Alquiler)
                        {
                            if (alqui.FechaIngreso == fechaDesde && alqui.FechaEgreso == fechaHasta)
                                existe = true;
                        }

                        if (!existe)
                        {
                            RetornaLista.Add(unidad);
                        }
                    }
                }
            }
            catch (XmlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            return RetornaLista;
        }
    }
}
