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
    public class MPP_Empleado : I_ABM<BE_Empleado>,  I_Traer<BE_Empleado>
    {
        private AccesoBD bd;

        public MPP_Empleado()
        {
            bd = new AccesoBD();
        }
        public void Alta(BE_Empleado x)
        {
            try
            {
                XDocument XML = bd.Cargar_XML();
                if (XML != null)
                {
                    if (x != null)
                    {

                        if (x is BE_EmpleadoAdministrativo)
                        {
                            XML.Element("Alquisoft").Element("Empleados").Add(new XElement("Empleado",
                                                            new XAttribute("n_legajo", x.N_Legajo.ToString().Trim()),
                                                           new XElement("nombre", x.Nombre.Trim()),
                                                           new XElement("apellido", x.Apellido.Trim()),
                                                           new XElement("sector", x.EmpleadoPuesto(x)),
                                                           new XElement("sectorg", string.Empty),
                                                           new XElement("sectorv", string.Empty)
                                                           ));
                        }
                        else if (x is BE_EmpleadoGerente)
                        {
                            XML.Element("Alquisoft").Element("Empleados").Add(new XElement("Empleado",
                                                            new XAttribute("n_legajo", x.N_Legajo.ToString().Trim()),
                                                           new XElement("nombre", x.Nombre.Trim()),
                                                           new XElement("apellido", x.Apellido.Trim()),
                                                           new XElement("sector", string.Empty),
                                                           new XElement("sectorg", x.EmpleadoPuesto(x)),
                                                           new XElement("sectorv", string.Empty)
                                                           ));
                        }
                        else if (x is BE_EmpleadoVendedor)
                        {
                            XML.Element("Alquisoft").Element("Empleados").Add(new XElement("Empleado",
                                                            new XAttribute("n_legajo", x.N_Legajo.ToString().Trim()),
                                                           new XElement("nombre", x.Nombre.Trim()),
                                                           new XElement("apellido", x.Apellido.Trim()),
                                                           new XElement("sector", string.Empty),
                                                           new XElement("sectorg", string.Empty),
                                                           new XElement("sectorv", x.EmpleadoPuesto(x))
                                                           ));

                        }
                        else
                        {
                            XML.Element("Alquisoft").Element("Empleados").Add(new XElement("Empleado",
                                                             new XAttribute("n_legajo", x.N_Legajo.ToString().Trim()),
                                                            new XElement("nombre", x.Nombre.Trim()),
                                                            new XElement("apellido", x.Apellido.Trim()),
                                                            new XElement("sector", string.Empty),
                                                            new XElement("sectorg", string.Empty),
                                                            new XElement("sectorv", string.Empty)
                                                            ));
                        }
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

        public void Baja(BE_Empleado x)
        {
            try
            {
                XDocument XML = bd.Cargar_XML();
                if (this.EsUsuario(x.N_Legajo))
                {
                    throw new Exception("El empleado no se puede eliminar, asociación usuario!");
                }
                if (XML != null)
                {
                    var leer = from Empleado in XML.Descendants("Empleado")
                               where Empleado.Attribute("n_legajo").Value?.Trim() == x.N_Legajo.ToString().Trim()
                               select Empleado;
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

        public void Modificacion(BE_Empleado x)
        {
            try
            {
                XDocument XML = bd.Cargar_XML();
                if (XML != null)
                {
                    var leer = from Empleado in XML.Descendants("Empleado")
                               where Empleado.Attribute("n_legajo").Value?.Trim() == x.N_Legajo.ToString().Trim()
                               select Empleado;

                    foreach (var item in leer)
                    {
                        item.Element("nombre").Value = x.Nombre.Trim();
                        item.Element("apellido").Value = x.Apellido.Trim();
                        if (x is BE_EmpleadoAdministrativo)
                        {

                            item.Element("sector").Value = x.EmpleadoPuesto(x).Trim();
                            item.Element("sectorg").Value = string.Empty;
                            item.Element("sectorv").Value = string.Empty;

                        }
                        else if (x is BE_EmpleadoGerente)
                        {
                            item.Element("sector").Value = string.Empty;
                            item.Element("sectorg").Value = x.EmpleadoPuesto(x).Trim();
                            item.Element("sectorv").Value = string.Empty;
                        }
                        else if (x is BE_EmpleadoVendedor)
                        {
                            item.Element("sector").Value = string.Empty;
                            item.Element("sectorg").Value = string.Empty;
                            item.Element("sectorv").Value = x.EmpleadoPuesto(x).Trim();
                        }
                        else
                        {
                            item.Element("sector").Value = string.Empty;
                            item.Element("sectorg").Value = string.Empty;
                            item.Element("sectorv").Value = string.Empty;
                        }
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

        public List<BE_Empleado> Traer()
        {
            List<BE_Empleado> Lista_Epleados = new List<BE_Empleado>();
            try
            {
                XElement XML = bd.Cargar_Xelement();
                var leer = from Empleado in XML.Elements("Empleados").Elements("Empleado")
                           where Empleado.Element("sector").Value.Trim() != ""
                           select new BE_EmpleadoAdministrativo
                           {
                               N_Legajo = Convert.ToInt32(Convert.ToString(Empleado.Attribute("n_legajo").Value).Trim()),
                               Nombre = Convert.ToString(Empleado.Element("nombre").Value).Trim(),
                               Apellido = Convert.ToString(Empleado.Element("apellido").Value).Trim(),
                               Sector = Convert.ToString(Empleado.Element("sector").Value).Trim()

                           };
                Lista_Epleados.AddRange(leer);

                var leer_2 = from Empleado in XML.Elements("Empleados").Elements("Empleado")
                           where Empleado.Element("sectorg").Value.Trim() != ""
                           select new BE_EmpleadoGerente
                           {
                               N_Legajo = Convert.ToInt32(Convert.ToString(Empleado.Attribute("n_legajo").Value).Trim()),
                               Nombre = Convert.ToString(Empleado.Element("nombre").Value).Trim(),
                               Apellido = Convert.ToString(Empleado.Element("apellido").Value).Trim(),
                               SectorG = Convert.ToString(Empleado.Element("sectorg").Value).Trim()

                           };
                Lista_Epleados.AddRange(leer_2);

                var leer_3 = from Empleado in XML.Elements("Empleados").Elements("Empleado")
                             where Empleado.Element("sectorv").Value.Trim() != ""
                             select new BE_EmpleadoVendedor
                             {
                                 N_Legajo = Convert.ToInt32(Convert.ToString(Empleado.Attribute("n_legajo").Value).Trim()),
                                 Nombre = Convert.ToString(Empleado.Element("nombre").Value).Trim(),
                                 Apellido = Convert.ToString(Empleado.Element("apellido").Value).Trim(),
                                 SectorV = Convert.ToString(Empleado.Element("sectorv").Value).Trim()

                             };
                Lista_Epleados.AddRange(leer_3);

                var leer_4 = from Empleado in XML.Elements("Empleados").Elements("Empleado")
                            where Empleado.Element("sector").Value.Trim() == "" && Empleado.Element("sectorg").Value.Trim() == "" && Empleado.Element("sectorv").Value.Trim() == ""
                            select new BE_EmpleadoGenerico
                            {
                                N_Legajo = Convert.ToInt32(Convert.ToString(Empleado.Attribute("n_legajo").Value).Trim()),
                                Nombre = Convert.ToString(Empleado.Element("nombre").Value).Trim(),
                                Apellido = Convert.ToString(Empleado.Element("apellido").Value).Trim()
                            };
                Lista_Epleados.AddRange(leer_4);

            }
            catch (XmlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            return Lista_Epleados;
        }

        private bool EsUsuario(int n_legajo)
        {
            try
            {
                bool es = false;
                XElement XML = bd.Cargar_Xelement();

                var leer = from Usuario in XML.Elements("Usuarios").Elements("Usuario")
                           where Usuario.Attribute("id").Value.Trim() != "0" && Usuario.Element("admin").Value.Trim() == "False" && Usuario.Attribute("id").Value.Trim() == n_legajo.ToString().Trim()
                           select Usuario;

                foreach (var item in leer)
                {
                    if (item != null && item.Attribute("id")?.Value == n_legajo.ToString())
                    {
                        es = true;
                    }
                }
                return es;
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
                    var leer = from Alquiler in XML.Descendants("Alquileres")
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
    }
}
