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
using Service;

namespace MPP
{
    public class MPP_Usuario : I_ABM<BE_Usuario>, I_Traer<BE_Usuario>
    {
        private AccesoBD bd;
        public MPP_Usuario()
        {
            bd = new AccesoBD();
        }
        public void Alta(BE_Usuario x)
        {
            try
            {
                XDocument XML = bd.Cargar_XML();
                if (XML != null)
                {
                    if (x != null)
                    {
                        XML.Element("Alquisoft").Element("Usuarios").Add(new XElement("Usuario",
                                                        new XAttribute("id", x.Empleado.N_Legajo.ToString().Trim()),
                                                       new XElement("contraseña", S_Encriptar.EncriptarPW(x.Contraseña.Trim())),
                                                       new XElement("admin", "False")
                                                       ));
                        bd.Guardar_XML(XML);
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

        public void Baja(BE_Usuario x)
        {
            try
            {
                XDocument XML = bd.Cargar_XML();

                if (XML != null)
                {
                    var leer = from Usuario in XML.Descendants("Usuario")
                               where Usuario.Attribute("id").Value?.Trim() == x.Empleado.N_Legajo.ToString().Trim()
                               select Usuario;
                    leer.Remove();
                    bd.Guardar_XML(XML);
                    this.BajaUsuario(x.Empleado.N_Legajo);
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

        public void Modificacion(BE_Usuario x)
        {
            try
            {
                XDocument XML = bd.Cargar_XML();
                if (XML != null)
                {
                    var leer = from Usuario in XML.Descendants("Usuario")
                               where Usuario.Attribute("id").Value?.Trim() == x.Empleado.N_Legajo.ToString().Trim()
                               select Usuario;

                    foreach (var item in leer)
                    {
                        item.Element("contraseña").Value = S_Encriptar.EncriptarPW(x.Contraseña.Trim());
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

        public List<BE_Usuario> Traer()
        {
            try
            {

                XElement XML = bd.Cargar_Xelement();



                var leer = from Usuario in XML.Elements("Usuarios").Elements("Usuario")
                           where Usuario.Attribute("id").Value.Trim() != "0" && Usuario.Element("admin").Value.Trim() == "False"
                           select new BE_Usuario
                           {

                               Empleado = TraerRelacionEmpleado(Convert.ToInt32(Usuario.Attribute("id").Value.Trim())),
                               Contraseña = S_Encriptar.EncriptarPW(Convert.ToString(Usuario.Element("contraseña").Value).Trim())
                           };
                List<BE_Usuario> Lista_Vuelta = leer.ToList<BE_Usuario>();
                return Lista_Vuelta;
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
        public void BajaUsuario(int idusuario)
        {
            try
            {
                XDocument XML = bd.Cargar_XML();

                if (XML != null)
                {
                    var leer = from Usurol in XML.Descendants("Rol").Descendants("Relacion")
                               where Usurol.Element("usuarioid").Value == idusuario.ToString().Trim()
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

        public BE_Empleado TraerRelacionEmpleado(int n_Legajo)
        {
            BE_Empleado Emp = null;

            try
            {
                XDocument XML_BD = bd.Cargar_XML();
                if (XML_BD != null)
                {
                    var leer = from Empleado in XML_BD.Descendants("Empleado")
                               where Empleado.Attribute("n_legajo").Value == n_Legajo.ToString().Trim() 
                               select Empleado;
                    foreach (var item in leer)
                    {
                        if (item != null)
                        {
                            if (!string.IsNullOrEmpty(item.Element("sector").Value.Trim()))
                            {
                                Emp = new BE_EmpleadoAdministrativo();
                                ((BE_EmpleadoAdministrativo)Emp).Sector = item.Element("sector").Value.Trim();
                            }
                            else if (!string.IsNullOrEmpty(item.Element("sectorg").Value.Trim()))
                            {
                                Emp = new BE_EmpleadoGerente();
                                ((BE_EmpleadoGerente)Emp).SectorG = item.Element("sectorg").Value.Trim();
                            }
                            else if (!string.IsNullOrEmpty(item.Element("sectorv").Value.Trim()))
                            {
                                Emp = new BE_EmpleadoVendedor();
                                ((BE_EmpleadoVendedor)Emp).SectorV = item.Element("sectorv").Value.Trim();
                            }
                            else
                            {
                                Emp = new BE_EmpleadoGenerico();
                            }
                            Emp.N_Legajo = Convert.ToInt32(Convert.ToString(item.Attribute("n_legajo").Value).Trim());
                            Emp.Nombre = Convert.ToString(item.Element("nombre").Value.Trim());
                            Emp.Apellido = Convert.ToString(item.Element("apellido").Value).Trim();
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
            return Emp;
        }

        public List<BE_Usuario> ObtenerUsuario(int usuario, string pass)
        {
            List<BE_Usuario> usuariosL = null;
            try
            {
                if (usuario >= 0 && !string.IsNullOrEmpty(pass))
                    usuariosL = this.Traer().Where(cl => cl != null && cl.Empleado.N_Legajo == usuario && cl.Contraseña.Contains(pass)).ToList();

            }
            catch (XmlException xex)
            {
                throw xex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return usuariosL;
        }
    }
}
