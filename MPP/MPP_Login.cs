using BE;
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
    public class MPP_Login : I_Traer<BE_Usuario>
    {
        private AccesoBD bd;

        public MPP_Login()
        {
            bd = new AccesoBD();
        }
        public List<BE_Usuario> Traer()
        {
            try
            {
                XElement XML = bd.Cargar_Xelement();

                var leer = from Usuario in XML.Elements("Usuarios").Elements("Usuario")
                           where Usuario.Attribute("id")?.Value.Trim() != "0" && Usuario.Element("admin")?.Value.Trim() == "False"
                           select new BE_Usuario
                           {
                               Empleado = TraerRelacionEmpleado(Convert.ToInt32(Usuario.Attribute("id").Value.Trim()))
                           };
                List<BE_Usuario> Lista = leer.ToList<BE_Usuario>();
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

        public BE_Empleado TraerRelacionEmpleado(int n_legajo)
        {
            BE_Empleado EmpleadoTraer = null;
            try
            {
                XDocument XML = bd.Cargar_XML();
                if (XML != null)
                {
                    var leer = from Empleado in XML.Descendants("Empleado")
                               where Empleado.Attribute("n_legajo").Value == n_legajo.ToString().Trim()
                               select Empleado;
                    foreach (var item in leer)
                    {
                        if (item != null)
                        {
                            if (!string.IsNullOrEmpty(item.Element("sector").Value.Trim()))
                                EmpleadoTraer = new BE_EmpleadoAdministrativo();
                            else if (!string.IsNullOrEmpty(item.Element("sectorg").Value.Trim()))
                                EmpleadoTraer = new BE_EmpleadoGenerico();
                            else
                                EmpleadoTraer = new BE_EmpleadoVendedor();
                            EmpleadoTraer.N_Legajo = Convert.ToInt32(Convert.ToString(item.Attribute("n_legajo").Value).Trim());
                            EmpleadoTraer.Nombre = Convert.ToString(item.Element("nombre").Value.Trim());
                            EmpleadoTraer.Apellido = Convert.ToString(item.Element("apellido").Value).Trim();
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
            return EmpleadoTraer;
        }

        public List<BE_Usuario> Obtener_Admin()
        {
            List<BE_Usuario> Lista = null;

            try
            {
                Lista = new List<BE_Usuario>();
                XDocument XML = bd.Cargar_XML();
                if (XML != null)
                {
                    var leer = from Usuario in XML.Descendants("Usuario")
                               where Usuario.Attribute("id").Value == "0" && Usuario.Element("admin").Value.Trim() == "True"
                               select new BE_Usuario
                               {
                                   Empleado = new BE_EmpleadoGenerico(0,"", "SuperUsuario")
                               };

                    Lista = leer.ToList<BE_Usuario>();
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

        public bool EsAdmin(BE_Usuario usuario)
        {
            try
            {
                return Obtener_Admin().Exists(a => a.Empleado.N_Legajo == usuario.Empleado.N_Legajo);
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

        public bool Validar(BE_Usuario x, string constraseña)
        {
            bool validacion = false;
            try
            {
                XDocument XML = bd.Cargar_XML();
                if (XML != null)
                {
                    var leer = from Usuario in XML.Descendants("Usuario")
                               where Usuario.Attribute("id").Value == x.Empleado.N_Legajo.ToString().Trim()
                               && Usuario.Element("contraseña").Value.Trim() == S_Encriptar.EncriptarPW(constraseña.Trim())
                               select Usuario;
                    foreach (var item in leer)
                    {
                        if (item != null)
                            validacion = true;
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

            return validacion;
        }

        public bool Validar(string pass)
        {
            bool validacion = false;
            try
            {
                XDocument XML = bd.Cargar_XML();
                if (XML != null)
                {
                    var leer = from Usuario in XML.Descendants("Usuario")
                               where Usuario.Attribute("id").Value == "0"
                               && Usuario.Element("contraseña").Value.Trim() == S_Encriptar.EncriptarPW(pass.Trim())
                               select Usuario;
                    foreach (var item in leer)
                    {
                        if (item != null)
                            validacion = true;
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
            return validacion;
        }
    }
}
