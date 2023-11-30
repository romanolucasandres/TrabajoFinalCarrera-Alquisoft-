using BE;
using DAL;
using INTERFACES;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace MPP
{
    public class MPP_Alquiler : I_ABM<BE_Alquiler>, I_Traer<BE_Alquiler>, I_Existe<bool, BE_Alquiler>
    {
        private AccesoBD bd;

        public MPP_Alquiler()
        {
            bd = new AccesoBD();
        }
        public void Alta(BE_Alquiler x)
        {
            try
            {
                XDocument XML = bd.Cargar_XML();

                int alqui = this.Traer().Count(v => v.Cliente.DNI == x.Cliente.DNI && v.FechaIngreso == x.FechaIngreso && v.FechaEgreso == x.FechaEgreso);
                if (alqui == 1)
                {
                    throw new Exception($"El cliente con DNI N°: {x.Cliente.DNI} ya tiene un alquiler otorgado para estas fechas.");
                }

                if (XML != null)
                {
                    XML.Element("Alquisoft").Element("Alquileres").Add(new XElement("Alquiler",
                                                    new XAttribute("codigo", x.Codigo.ToString().Trim()),
                                                   new XElement("cliente", x.Cliente.Nro_Cliente.ToString().Trim()),
                                                   new XElement("unidad", x.Unidad.Codigo.ToString().Trim()),
                                                   new XElement("vendedor", x.Vendedor.N_Legajo.ToString().Trim()),
                                                   new XElement("fechaingreso", x.FechaIngreso.ToString().Trim()),
                                                   new XElement("fechaegreso", x.FechaEgreso.ToString().Trim()),
                                                   new XElement("total", x.Total.ToString().Trim()),
                                                   new XElement("isfacturado", x.IsFacturado.ToString().Trim())
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


        public void Baja(BE_Alquiler x)
        {
            try
            {
                XDocument XML = bd.Cargar_XML();

                if (x.IsFacturado == true)
                {
                    throw new Exception("Acción no válida, el alquiler ya ha sido facturado.");
                }

                if (XML != null)
                {
                    var alquiler = from Alquiler in XML.Descendants("alquiler")
                                   where Alquiler.Attribute("codigo").Value == x.Codigo.ToString().Trim()
                                   select Alquiler;

                    alquiler.Remove();
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

        public bool ExisteObjeto(BE_Alquiler objeto)
        {
            try
            {
                return this.Traer().Exists(x => x?.Codigo == objeto?.Codigo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modificacion(BE_Alquiler x)
        {
            try
            {
                XDocument XML = bd.Cargar_XML();
                if (XML != null)
                {

                    int alqui = this.Traer().Count(v => v.Cliente.DNI == x.Cliente.DNI && v.FechaIngreso == x.FechaIngreso && v.FechaEgreso == x.FechaEgreso);
                    if (alqui == 1 && !ExisteAlquilerCliente(x.Cliente, x.FechaIngreso, x.FechaEgreso))
                    {
                        throw new Exception($"El cliente con DNI N°: {x.Cliente.DNI} ya tiene un alquiler otorgado para estas fechas.");
                    }

                    var alquiler = from Alquiler in XML.Descendants("Alquiler")
                                   where Alquiler.Attribute("codigo")?.Value == x.Codigo.ToString().Trim()
                                   select Alquiler;

                    foreach (var item in alquiler)
                    {
                        if (item.Element("isfacturado").Value == true.ToString() && item.Element("cliente").Value != x.Cliente.DNI.ToString())
                        {
                            throw new Exception("Acción no válida, el alquiler ya ha sido facturado.");
                        }

                        item.Element("cliente").Value = x.Cliente.DNI.ToString().Trim();
                        item.Element("unidad").Value = x.Unidad.Codigo.ToString().Trim();
                        item.Element("vendedor").Value = x.Vendedor.N_Legajo.ToString().Trim();
                        item.Element("fechaingreso").Value = x.FechaIngreso.ToString().Trim();
                        item.Element("fechaegreso").Value = x.FechaEgreso.ToString().Trim();
                        item.Element("total").Value = x.Total.ToString().Trim();
                        item.Element("isfacturado").Value = x.IsFacturado.ToString().Trim();
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

        public List<BE_Alquiler> Traer()
        {
            try
            {

                XElement XML = bd.Cargar_Xelement();
                var leer = from Alquiler in XML.Elements("Alquileres").Elements("Alquiler")
                           select new BE_Alquiler
                           {
                               Codigo = Convert.ToInt32(Alquiler.Attribute("codigo")?.Value.Trim()),
                               Cliente = TraerRelacionCliente(Convert.ToInt32(Alquiler.Element("cliente")?.Value.Trim())),
                               Unidad = TraerRelacionUnidad(Convert.ToInt32(Alquiler.Element("unidad")?.Value.Trim())),
                               Vendedor = TraerRelacionVendedor(Convert.ToInt32(Alquiler.Element("vendedor")?.Value.Trim())),
                               FechaIngreso = Convert.ToDateTime(Alquiler.Element("fechaingreso")?.Value.Trim()),
                               FechaEgreso = Convert.ToDateTime(Alquiler.Element("fechaegreso")?.Value.Trim()),
                               IsFacturado = Convert.ToBoolean(Alquiler.Element("isfacturado")?.Value.Trim()),
                               Total = Convert.ToDecimal(Alquiler.Element("total")?.Value.Trim())
                           };

                List<BE_Alquiler> Lista = leer.ToList<BE_Alquiler>();
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
        public List<BE_Alquiler> Traer(DateTime? fechaingreso = null, DateTime? fechaegreso = null, bool? isfacturado = null)
        {

            try
            {
                List<BE_Alquiler> alquiler = this.Traer();
                if (fechaingreso != null)
                    alquiler = alquiler.Where(x => x?.FechaIngreso.Date == fechaingreso.Value.Date).ToList();

                if (isfacturado != null)
                    alquiler = alquiler.Where(x => x?.IsFacturado == isfacturado.Value).ToList();

                return alquiler;
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
        public List<BE_Alquiler> Traer(DateTime? fechaingreso = null, bool? isfacturado = null)
        {

            try
            {
                List<BE_Alquiler> alquiler = this.Traer();
                if (fechaingreso != null)
                    alquiler = alquiler.Where(x => x?.FechaIngreso.Date == fechaingreso.Value.Date).ToList();

                if (isfacturado != null)
                    alquiler = alquiler.Where(x => x?.IsFacturado == isfacturado.Value).ToList();

                return alquiler;
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
        public List<BE_Alquiler> TraerSoloFacturados(List<BE_Alquiler> alquileres, bool solofacturados)
        {
            try
            {
                if (alquileres?.Count > 0)
                {
                    if (solofacturados)
                        alquileres = alquileres.Where(x => x?.IsFacturado == true).ToList();
                    else
                        alquileres = alquileres.Where(x => x?.IsFacturado == false).ToList();
                }

                return alquileres;
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
        public bool ExisteAlquilerCliente(BE_Cliente cli, DateTime? date, DateTime? date2)
        {
            bool existe = false;
            try
            {
                // hago consuta con linq para ver si existe y que cambie a true en el caso de que exista
                if (date == null|| date2 ==null)
                { 
                    existe = this.Traer().Exists(x => x?.Cliente.DNI == cli.DNI);
                }    
                else
                {
                    existe = this.Traer().Exists(x => x?.Cliente.DNI == cli.DNI &&
                                       x?.FechaIngreso <= date2 &&
                                       x?.FechaEgreso >= date);
                }
            }
            catch (XmlException e)
            {

                throw e;
            }
            catch(Exception e)
            {
                throw e;
            }
            return existe;

        }
        public bool ExisteAlquilerUnidad(BE_Unidades unidad, DateTime? date, DateTime? date2)
        {
            bool existe = false;
            try
            {
                // hago consuta con linq para ver si existe y que cambie a true en el caso de que exista
                if (date == null || date2 == null)
                {
                    
                    existe = this.Traer().Exists(x => x?.Codigo == unidad.Codigo);
                }
                
                else
                {
                    existe = this.Traer().Exists(x=>x?.Codigo == unidad.Codigo && 
                    x?.FechaIngreso <= date &&
                    x?.FechaEgreso >=date2);
                }
            }
            catch (XmlException e)
            {

                throw e;
            }
            catch(Exception e)
            {
                throw e;
            }
            return existe;

        }
        public bool IsFacturado(BE_Alquiler objeto)
        {
            try
            {
                return this.Traer().Exists(x => x?.Codigo == objeto?.Codigo && x?.IsFacturado == true);
            }
            catch (Exception e) { throw e; }

        }

        public string ObtenerUltimoCodigoAlquiler()
        {
            string ultimoCodigoAlquiler = string.Empty;
            try
            {
                //orden DESC y primero en lista
                var alquiler = this.Traer().OrderByDescending(x => x?.Codigo).Where(c => c?.Codigo != null).FirstOrDefault();
                if (alquiler?.Codigo != null)
                {
                    ultimoCodigoAlquiler = (alquiler.Codigo + 1).ToString();
                }
                else
                {
                    ultimoCodigoAlquiler = "1";
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
            return ultimoCodigoAlquiler;
        }
        public BE_Cliente TraerRelacionCliente(int nro_cliente)
        {

            BE_Cliente ClienteRel = null;
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
                            ClienteRel = new BE_Cliente();
                            ClienteRel.Nro_Cliente = Convert.ToInt32(item.Attribute("nro_cliente").Value);
                            ClienteRel.Nombre = Convert.ToString(item.Element("nombre").Value).Trim();
                            ClienteRel.Apellido = Convert.ToString(item.Element("apellido").Value).Trim();
                            ClienteRel.Telefono =  Convert.ToInt32(item.Element("telefono").Value);
                            ClienteRel.Pais = Convert.ToString(item.Element("pais").Value).Trim();
                            ClienteRel.Localidad = Convert.ToString(item.Element("ciudad").Value).Trim();
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
            return ClienteRel;

        }
        public BE_Unidades TraerRelacionUnidad(int codigo)
        {

            BE_Unidades Unidad = null;
            try
            {
                XDocument XML = bd.Cargar_XML();
                if (XML != null)
                {
                    var leer = from Unidades in XML.Descendants("Unidad")
                               where Unidades.Attribute("id").Value == codigo.ToString().Trim()
                               select Unidades;
                    foreach (var item in leer)
                    {
                        if (item != null)
                        {
                            Unidad = new BE_Unidades();
                            Unidad.Codigo = Convert.ToInt32(Convert.ToString(item.Attribute("id").Value).Trim());
                            Unidad.Ciudad = Convert.ToString(item.Element("ciudad").Value.Trim());
                            Unidad.Pais = Convert.ToString(item.Element("pais").Value).Trim();
                            Unidad.Ambientes = Convert.ToInt32(item.Element("ambientes").Value.Trim());
                            Unidad.Plaza = Convert.ToInt32(item.Element("plazas").Value.Trim());
                            Unidad.PrecioDia = Convert.ToDecimal(item.Element("valordia").Value.Trim());
                            Unidad.Estado = Convert.ToBoolean(item.Element("estado").Value.Trim());
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
            return Unidad;

        }

        public BE_EmpleadoVendedor TraerRelacionVendedor(int n_legajo)
        {
            BE_EmpleadoVendedor V = null;
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
                            V = new BE_EmpleadoVendedor();
                            V.N_Legajo = Convert.ToInt32(Convert.ToString(item.Attribute("n_legajo").Value).Trim());
                            V.Nombre = Convert.ToString(item.Element("nombre").Value.Trim());
                            V.Apellido = Convert.ToString(item.Element("apellido").Value).Trim();
                            V.SectorV = Convert.ToString(item.Element("sectorv").Value).Trim();
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
            return V;

        }

        
    }
}
