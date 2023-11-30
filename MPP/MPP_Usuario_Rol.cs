using DAL;
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
    public class MPP_Usuario_Rol
    {
        private AccesoBD bd;
        public MPP_Usuario_Rol()
        {
            bd = new AccesoBD();
        }

        public void Alta(List<S_Compuesto> listaroles, int idusuario)
        {

            try
            {
                if (idusuario > 0 && listaroles?.Count > 0)
                {
                    XDocument XML = bd.Cargar_XML();
                    if (XML != null)
                    {
                        foreach (S_Compuesto rol in listaroles)
                        {
                            if (!Existe(rol.Numero, idusuario))
                            {
                                XML.Element("Alquisoft").Element("UsuarioRol").Add(new XElement("Relacion",
                                                        new XElement("usuarioid", idusuario.ToString().Trim()),
                                                       new XElement("rolid", rol?.Numero.ToString().Trim())
                                                       ));
                            }
                        }
                    }
                    bd.Guardar_XML(XML);
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
        }

        public void Modificacion(List<S_Compuesto> listaroles, int idusuario)
        {
            try
            {
                this.Baja(idusuario);
                this.Alta(listaroles, idusuario);
            }
            catch (XmlException xex)
            {
                throw xex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void Baja(int idusuario)
        {
            try
            {
                XDocument XML = bd.Cargar_XML();

                if (XML != null)
                {
                    var leer = from Usurol in XML.Descendants("UsuarioRol").Descendants("Relacion")
                               where Usurol.Element("usuarioid").Value == idusuario.ToString().Trim()
                               select Usurol;
                    leer.Remove();
                    bd.Guardar_XML(XML);
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
        }

        public List<S_Compuesto> ObtenerRolesAsociados(int idusuario)
        {

            try
            {

                XElement XML = bd.Cargar_Xelement();
                var leer = from rol in XML.Elements("UsuarioRol").Elements("Relacion").Where(r => r?.Element("usuarioid")?.Value == idusuario.ToString().Trim())
                           select new S_Compuesto(Convert.ToInt32(rol.Element("rolid")?.Value.Trim()), ObtenerNombreRol(rol.Element("rolid")?.Value.Trim()));



                List<S_Compuesto> Lista= leer.ToList<S_Compuesto>();
                return Lista;
            }
            catch (XmlException xex)
            {
                throw xex;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        private string ObtenerNombreRol(string nrorol)
        {
            try
            {
                string nombre = "";
                XElement XML = bd.Cargar_Xelement();
                if (XML != null && !string.IsNullOrEmpty(nrorol))
                {
                    var leer = from Rol in XML.Descendants("Rol")
                               where Rol?.Attribute("id")?.Value == nrorol.Trim()
                               select Rol;
                    foreach (var item in leer)
                    {
                        if (item != null)
                            nombre = item.Element("nombre")?.Value.Trim();

                    }
                }

                return nombre;
            }
            catch (XmlException xex)
            {
                throw xex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private bool Existe(int idrol, int idusuario)
        {
            try
            {
                return this.ObtenerRolesAsociados(idusuario).Exists(x => x?.Numero == idrol);
            }
            catch (XmlException xex)
            {
                throw xex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
