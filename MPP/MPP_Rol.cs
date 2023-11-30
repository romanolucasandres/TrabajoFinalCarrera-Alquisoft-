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
    public class MPP_Rol : I_ABM<S_Componente>, I_Traer<S_Componente>
    {
        private AccesoBD bd;
        public MPP_Rol()
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
                    XML.Element("Alquisoft").Element("Roles").Add(new XElement("Rol",
                                                    new XAttribute("id", x.Numero.ToString().Trim()),
                                                   new XElement("nombre", x.Nombre.ToString().Trim())
                                                   ));
                }
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

        public void Baja(S_Componente x)
        {
            try
            {
                XDocument XML = bd.Cargar_XML();


                var leer = from Componente in XML.Descendants("Rol")
                           where Componente.Attribute("id")?.Value == x.Numero.ToString().Trim()
                           select Componente;
                leer.Remove();
                var leer2 = from Permiso in XML.Descendants("Permiso")
                            where Permiso.Element("rolid")?.Value.Trim() == x.Numero.ToString().Trim()
                            select Permiso;
                leer2.Remove();

                bd.Guardar_XML(XML);
                this.BajaRol(x.Numero);



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
                    var leer = from Rol in XML.Descendants("Rol")
                               where Rol.Attribute("id").Value == x.Numero.ToString().Trim()
                               select Rol;

                    foreach (var item in leer)
                    {
                        item.Element("nombre").Value = x.Nombre.ToString().Trim();
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

        public List<S_Componente> Traer()
        {
            List<S_Componente> ListaComponente = null;
            try
            {
                XElement XML = bd.Cargar_Xelement();
                var leer = from Rol in XML.Elements("Roles").Elements("Rol")
                           select new S_Compuesto(Convert.ToInt32(Rol.Attribute("id")?.Value.Trim()), Rol.Element("nombre")?.Value.Trim());

                ListaComponente = leer.ToList<S_Componente>();

            }
            catch (XmlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            return ListaComponente;
        }

        public void BajaRol(int codigo)
        {
            try
            {
                XDocument XML = bd.Cargar_XML();

                if (XML != null)
                {
                    var leer = from Usurol in XML.Descendants("RolUsuario").Descendants("Relacion")
                               where Usurol.Element("id").Value == codigo.ToString().Trim()
                               select Usurol;
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
        public S_Componente TraerRol(int codigo)
        {
            S_Componente rol = null;
            try
            {
                XDocument XML = bd.Cargar_XML();
                if (XML != null)
                {
                    var leer = from Rol in XML.Descendants("Rol")
                               where Rol.Attribute("id").Value == codigo.ToString().Trim()
                               select Rol;
                    foreach (var item in leer)
                    {
                        if (item != null)
                            rol = new S_Compuesto(Convert.ToInt32(item.Attribute("id").Value.Trim()), item.Element("nombre").Value.Trim());

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
            return rol;
        }
    }
}
