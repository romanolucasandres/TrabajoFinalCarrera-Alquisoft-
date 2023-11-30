using DAL;
using INTERFACES;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;

namespace MPP
{
    public class MPP_Permiso : I_ABM<S_Componente>
    {
        private AccesoBD bd;
        public MPP_Permiso()
        {
            bd = new AccesoBD();
        }
        public void Alta(S_Componente x)
        {
            try
            {

                XDocument XML = bd.Cargar_XML();
                if (XML != null)
                {
                    if (x.ObtenerLista().Count > 0)
                    {                        
                        foreach (S_Hoja item in x.ObtenerLista())
                        {
                            //Genero un numero random para el id
                            Random numeroRandom = new Random();
                            int min = 10000;
                            int max = 99999;
                            S_Componente componente = Traer(x);
                            int numero = numeroRandom.Next(min, max);
                            if (componente?.ObtenerLista()?.Count > 0)
                            {
                                if (componente.ObtenerLista().Exists(c => c?.Nombre == item.Nombre && c?.Numero == item?.Numero))
                                    Modificacion(item);
                                else
                                {
                                    XML.Element("Alquisoft").Element("Permisos").Add(new XElement("Permiso",
                                                          new XAttribute("id", numero.ToString().Trim()),
                                                         new XElement("nombre", item.Nombre.ToString().Trim()),
                                                         new XElement("visible", item.Visible.ToString().Trim()),
                                                         new XElement("idrol", x.Numero.ToString().Trim())
                                                         ));
                                    bd.Guardar_XML(XML);
                                }
                            }
                            else
                            {
                                XML.Element("Alquisoft").Element("Permisos").Add(new XElement("Permiso",
                                                      new XAttribute("id", numero.ToString().Trim()),
                                                     new XElement("nombre", item.Nombre.ToString().Trim()),
                                                     new XElement("visible", item.Visible.ToString().Trim()),
                                                     new XElement("idrol", x.Numero.ToString().Trim())
                                                     ));
                                bd.Guardar_XML(XML);
                            }
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
        }

        public void Baja(S_Componente x)
        {
            try
            {
                XDocument XML = bd.Cargar_XML();

                var leer = from Componente in XML.Descendants("Permiso")
                           where Componente.Attribute("id")?.Value == x.Numero.ToString().Trim()
                           select Componente;
                leer.Remove();
                bd.Guardar_XML(XML);
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

        public void Modificacion(S_Componente x)
        {
            try
            {
                XDocument XML = bd.Cargar_XML();
                if (XML != null)
                {
                    if (x != null)
                    {
                        var leer = from Permiso in XML.Descendants("Permiso")
                                   where Permiso.Attribute("id").Value.Trim() == x.Numero.ToString().Trim()
                                   select Permiso;

                        foreach (var item in leer)
                        {
                            item.Element("visible").Value = x.Visible.ToString().Trim();
                            bd.Guardar_XML(XML);
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

        }
         public S_Componente Traer(S_Componente rol)
        {
            S_Componente Lista_ = null;
            try
            {
                if (rol != null)
                {
                    Lista_ = new S_Compuesto(rol.Numero, rol.Nombre);

                    XElement XML = bd.Cargar_Xelement();
                    var leer = from Permiso in XML.Elements("Permisos").Elements("Permiso")
                               where Permiso.Element("idrol")?.Value == rol.Numero.ToString()
                               select new S_Hoja(Convert.ToInt32(Permiso.Attribute("id")?.Value.ToString().Trim()), Permiso.Element("nombre")?.Value.Trim(), Convert.ToBoolean(Permiso.Element("visible")?.Value.Trim()));

                    foreach (S_Hoja item in leer)
                    {
                        if (item != null)
                        {
                            Lista_.AgregarNodo(item);
                        }
                    }
                }

            }
            catch (XmlException xex)
            {
                throw xex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Lista_;
        }
        
    }
}
