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

namespace MPP
{
    public class MPP_Cliente : I_ABM<BE_Cliente>, I_Traer<BE_Cliente>, I_Existe<bool, int>
    {
        private AccesoBD bd;

        public MPP_Cliente()
        {
            bd = new AccesoBD();
        }
        public void Alta(BE_Cliente x)
        {
            try
            {
                XDocument XML = bd.Cargar_XML();
                if (XML != null)
                {

                    XML.Element("Alquisoft").Element("Clientes").Add(new XElement("Cliente",
                                                    new XAttribute("nro_cliente", x.Nro_Cliente.ToString().Trim()),
                                                   new XElement("nombre", x.Nombre.Trim()),
                                                   new XElement("apellido", x.Apellido.Trim()),
                                                   new XElement("dni", x.DNI.ToString().Trim()),
                                                   new XElement("pais", x.Pais.Trim()),
                                                   new XElement("ciudad", x.Localidad.Trim()),
                                                   new XElement("telefono", x.Telefono.ToString().Trim())

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

        public void Baja(BE_Cliente x)
        {

            try
            {
                XDocument XML = bd.Cargar_XML();

                if (XML != null)
                {
                    var leer = from Cliente in XML.Descendants("Cliente")
                               where Cliente.Attribute("nro_cliente").Value == x.DNI.ToString().Trim()
                               select Cliente;

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

        public void Modificacion(BE_Cliente x)
        {
            try
            {
                XDocument XML = bd.Cargar_XML();
                if (XML != null)
                {
                    var leer = from Cliente in XML.Descendants("Cliente")
                               where Cliente.Attribute("nro_cliente").Value == x.DNI.ToString().Trim()
                               select Cliente;

                    foreach (var item in leer)
                    {
                        item.Element("nombre").Value = x.Nombre.Trim();
                        item.Element("apellido").Value = x.Apellido.Trim();
                        item.Element("dni").Value = x.DNI.ToString().Trim();
                        item.Element("pais").Value = x.Localidad.Trim();
                        item.Element("ciudad").Value = x.Localidad.Trim();
                        item.Element("telefono").Value = Convert.ToString(x.Telefono).Trim();
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

        public List<BE_Cliente> Traer()
        {
            try
            {

                XElement element = bd.Cargar_Xelement();
                var leer = from Cliente in element.Elements("Clientes").Elements("Cliente")
                           select new BE_Cliente
                           {
                               Nro_Cliente = Convert.ToInt32(Convert.ToString(Cliente.Attribute("nro_cliente")?.Value).Trim()),
                               Nombre = Convert.ToString(Cliente.Element("nombre")?.Value).Trim(),
                               Apellido = Convert.ToString(Cliente.Element("apellido")?.Value).Trim(),
                               DNI = Convert.ToInt32(Cliente.Element("dni")?.Value.Trim()),
                               Pais = Convert.ToString(Cliente.Element("pais")?.Value).Trim(),                               
                               Localidad = Convert.ToString(Cliente.Element("ciudad")?.Value).Trim(),
                               Telefono = Convert.ToInt32(Cliente.Element("telefono")?.Value.Trim())
                           };
                List<BE_Cliente> Lista = leer.ToList<BE_Cliente>();
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

        public BE_Cliente Traer(string nro_cliente)
        {

            BE_Cliente cliente = null;
            try
            {

                XDocument XML = bd.Cargar_XML();
                if (XML != null)
                {
                    var leer = from Cliente in XML.Descendants("Cliente")
                               where Cliente.Attribute("nro_cliente").Value == nro_cliente.ToString().Trim()
                               select Cliente;
                    foreach (var item in leer)
                    {
                        if (item != null)
                        {
                            cliente = new BE_Cliente();
                            cliente.Nro_Cliente = Convert.ToInt32(Convert.ToString(item.Attribute("nro_cliente")?.Value).Trim());
                            cliente.DNI = Convert.ToInt32(item.Element("id").Value);
                            cliente.Nombre = Convert.ToString(item.Element("nombre").Value).Trim();
                            cliente.Apellido = Convert.ToString(item.Element("apellido").Value).Trim();
                            cliente.Pais = Convert.ToString(item.Element("pais").Value).Trim();                            
                            cliente.Localidad = Convert.ToString(item.Element("ciudad").Value).Trim();
                            cliente.Telefono = Convert.ToInt32(item.Element("telefono").Value);
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
            return cliente;

        }
        public bool ExisteObjeto(int objeto)
        {
            try
            {
                return this.Traer().Exists(x => x?.DNI == objeto);
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

        public List<BE_Cliente> ObtenerListaClientes(int dni)
        {
            List<BE_Cliente> lista_clientes = null;
            try
            {
                if (dni > 0)
                    lista_clientes = this.Traer().Where(cl => cl != null && cl.DNI.ToString().Contains(dni.ToString())).ToList();
                else
                    lista_clientes = this.Traer();

            }
            catch (XmlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            return lista_clientes;
        }

        public List<BE_Cliente> ObtenerListaClientes(string nombre = null, string apellido = null)
        {
            List<BE_Cliente> clientes = null;
            try
            {
                if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido))
                    clientes = this.Traer().Where(cl => cl != null && cl.Nombre.Contains(nombre) && cl.Apellido.Contains(apellido)).ToList();
                else if (!string.IsNullOrEmpty(nombre))
                    clientes = this.Traer().Where(cl => cl != null && cl.Nombre.Contains(nombre)).ToList();
                else if (!string.IsNullOrEmpty(apellido))
                    clientes = this.Traer().Where(cl => cl != null && cl.Apellido.Contains(apellido)).ToList();
                else
                    clientes = this.Traer();

            }
            catch (XmlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            return clientes;
        }
    }
}
