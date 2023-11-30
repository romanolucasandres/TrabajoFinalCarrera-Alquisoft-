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
    public class MPP_ComprobanteFactura : I_ABM<BE_ComprobanteFactura>, I_Traer<BE_ComprobanteFactura>
    {
        private AccesoBD bd;

        public MPP_ComprobanteFactura()
        {
            bd = new AccesoBD();
        }
        public void Alta(BE_ComprobanteFactura x)
        {
            try
            {
                XDocument XML = bd.Cargar_XML();
                if (XML != null)
                {

                    XML.Element("Alquisoft").Element("Facturas").Add(new XElement("Factura",
                                                    new XAttribute("n_comprobante", x.NroComprobante.ToString().Trim()),
                                                    new XElement("importetotal", x.ImporteTotal.ToString().Trim()),
                                                    new XElement("medio", x.Medio.ToString().Trim()),
                                                    new XElement("fecha", x.Fecha.ToString().Trim()),
                                                    new XElement("cliente", x.ClienteComprobante.DNI.ToString().Trim()),
                                                    new XElement("subtotal", x.Subtotal.ToString().Trim()),
                                                    new XElement("porcentaje", x.Porcentaje.ToString().Trim()),
                                                    new XElement("iva", x.Iva.ToString().Trim()),
                                                    new XElement("esdescuento", x.EsDescuento.ToString().Trim()),
                                                    new XElement("estadopagado", x.EstadoPagado.ToString().Trim()),
                                                    new XElement("alquiler", x.Alquiler.Codigo.ToString().Trim())                                                
                                                   ));
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

        public void Baja(BE_ComprobanteFactura x)
        {
            try
            {
                XDocument XML = bd.Cargar_XML();

                if (XML != null)
                {
                    var leer = from Factura in XML.Descendants("Factura")
                               where Factura.Attribute("n_comprobante").Value == x.NroComprobante.ToString().Trim()
                               select Factura;

                    if (x.EstadoPagado == true || TraerRelacionCobro(x.NroComprobante)?.Count > 0)
                    {
                        throw new Exception("¡No se puede eliminar! \n Ya tiene cobros asignados.");
                    }

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

        public void Modificacion(BE_ComprobanteFactura x)
        {
            try
            {
                XDocument XML = bd.Cargar_XML();
                if (TraerRelacionCobro(x.NroComprobante)?.Count > 0)
                {
                    decimal suma = 0;
                    TraerRelacionCobro(x.NroComprobante).ForEach(co => suma += co.ImporteTotal);
                    if (suma > x.ImporteTotal)
                        throw new Exception("El importe de la factura debe ser mayor o igual al cobro del alquiler");
                    else if (suma == x.ImporteTotal)
                        x.EstadoPagado = true;

                }

                if (XML != null)
                {
                    var leer = from Factura in XML.Descendants("Factura")
                               where Factura.Attribute("n_comprobante")?.Value == x.NroComprobante.ToString().Trim()
                               select Factura;

                    foreach (var item in leer)
                    {
                        item.Element("fecha").Value = x.Fecha.ToString().Trim();
                        item.Element("importetotal").Value = x.ImporteTotal.ToString().Trim();
                        item.Element("subtotal").Value = x.Subtotal.ToString().Trim();
                        item.Element("porcentaje").Value = x.Porcentaje.ToString().Trim();
                        item.Element("iva").Value = x.Iva.ToString().Trim();
                        item.Element("esdescuento").Value = x.EsDescuento.ToString().Trim();
                        item.Element("estadopagado").Value = x.EstadoPagado.ToString().Trim();      
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

        public List<BE_ComprobanteFactura> Traer()
        {
            try
            {

                XElement XML = bd.Cargar_Xelement();
                var leer = from comprobante in XML.Elements("Facturas").Elements("Factura")
                           select new BE_ComprobanteFactura
                           {
                               NroComprobante = Convert.ToInt32(comprobante.Attribute("n_comprobante")?.Value.Trim()),
                               Fecha = Convert.ToDateTime(comprobante.Element("fecha")?.Value.Trim()),
                               ClienteComprobante = TraerRelacionCliente(Convert.ToInt32(comprobante.Element("cliente")?.Value.Trim())),
                               Alquiler = TraerRelacionAlquiler(Convert.ToInt32(comprobante.Element("alquiler")?.Value.Trim())),
                               EsDescuento = Convert.ToBoolean(comprobante.Element("esdescuento")?.Value.Trim()),
                               Medio = comprobante.Element("medio")?.Value.Trim(),
                               Porcentaje = Convert.ToDecimal(comprobante.Element("porcentaje")?.Value.Trim()),
                               ImporteTotal = Convert.ToDecimal(comprobante.Element("importetotal")?.Value.Trim()),
                               Iva = Convert.ToDecimal(comprobante.Element("iva")?.Value.Trim()),
                               Subtotal = Convert.ToDecimal(comprobante.Element("subtotal")?.Value.Trim()),
                               EstadoPagado = Convert.ToBoolean(comprobante.Element("estadopagado")?.Value.Trim())

                           };

                List<BE_ComprobanteFactura> ListaFacturas = leer.ToList<BE_ComprobanteFactura>();
                return ListaFacturas;
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

        public List<BE_ComprobanteFactura> Traer(DateTime fecha)
        {
            try
            {
                return this.Traer().Where(x => x?.Fecha.Date == fecha.Date).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<BE_ComprobanteFactura> Traer(BE_Cliente cliente, bool esbool)
        {
            try
            {
                if (esbool)
                    return this.Traer().Where(x => x?.ClienteComprobante.DNI == cliente?.DNI).ToList();
                else
                    return this.Traer().Where(x => x?.ClienteComprobante.DNI == cliente.DNI && x?.EstadoPagado == false).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public BE_ComprobanteFactura Traer(int nroComprobante)
        {
            try
            {
                return this.Traer().Find(x => x?.NroComprobante == nroComprobante);
            }
            catch (Exception ex)
            {
                throw ex;
            }

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
                            ClienteRel.DNI = Convert.ToInt32(item.Attribute("nro_cliente").Value.Trim());
                            ClienteRel.Nombre = Convert.ToString(item.Element("nombre").Value).Trim();
                            ClienteRel.Apellido = Convert.ToString(item.Element("apellido").Value).Trim();
                            ClienteRel.Telefono = Convert.ToInt32(item.Element("telefono").Value.Trim());
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

        private BE_Alquiler TraerRelacionAlquiler(int codigo)
        {

            BE_Alquiler alquiler = null;
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
                            alquiler = new BE_Alquiler()
                            {
                                Codigo = Convert.ToInt32(item.Attribute("codigo")?.Value.Trim()),
                                Cliente= TraerRelacionCliente(Convert.ToInt32(item.Element("cliente")?.Value.Trim())),
                                FechaIngreso = Convert.ToDateTime(item.Element("fechaingreso")?.Value.Trim()),
                                FechaEgreso = Convert.ToDateTime(item.Element("fechaegreso")?.Value.Trim()),
                                Unidad = TraerRelacionUnidad(Convert.ToInt32(item.Element("unidad")?.Value.Trim())),
                                Vendedor = TraerRelacionVendedor(Convert.ToInt32(item.Element("vendedor")?.Value.Trim())),
                                IsFacturado = Convert.ToBoolean(item.Element("isfacturado")?.Value.Trim())   
                            };
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
            return alquiler;

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
                            Unidad.Ambientes = Convert.ToInt32(item.Element("ambientes").Value);
                            Unidad.Plaza = Convert.ToInt32(item.Element("plazas").Value);
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
        private List<BE_ComprobanteCobroAlquiler> TraerRelacionCobro(int nroComprobante)
        {

            List<BE_ComprobanteCobroAlquiler> lista = new List<BE_ComprobanteCobroAlquiler>();
            try
            {

                XDocument XML = bd.Cargar_XML();
                if (XML != null)
                {
                    var leer = from Cobro in XML.Descendants("Cobro")
                               where Cobro.Element("factura")?.Value == nroComprobante.ToString().Trim()
                               select Cobro;
                    foreach (var item in leer)
                    {
                        if (item != null)
                        {
                            BE_ComprobanteCobroAlquiler cobro = new BE_ComprobanteCobroAlquiler();
                            cobro.NroComprobante = Convert.ToInt32(Convert.ToString(item.Attribute("codigo").Value).Trim());
                            cobro.ImporteTotal = Convert.ToDecimal(item.Element("monto")?.Value.Trim());
                            lista.Add(cobro);

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
            return lista;

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

        public string ObtenerUltimoNumero()
        {
            string ultimonumero = "";
            try
            {
                var alquiler = this.Traer().OrderByDescending(x => x?.NroComprobante).Where(t => t?.NroComprobante != null).FirstOrDefault();
                if (alquiler?.NroComprobante != null)
                    ultimonumero = (alquiler.NroComprobante + 1).ToString();
                else
                    ultimonumero = "1";

            }
            catch (XmlException xex)
            {
                throw xex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ultimonumero;
        }

        public decimal ObtenerSubtotalAlquileres(List<BE_Alquiler> alquileres)
        {
            decimal subtotal = 0;
            try
            {
                if (alquileres?.Count > 0)
                    //ver esto
                    alquileres.Where(a => a.IsFacturado == true).ToList().ForEach(a => subtotal += 1);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return subtotal;
        }

        public (decimal, decimal) Calcular(decimal subtotal, decimal porcentaje, bool esDescuento)
        {
            try
            {
                decimal total = 0;
                decimal iva = 0;
                if (subtotal > 0)
                {
                    subtotal = porcentaje > 0 ? esDescuento ? subtotal - (subtotal * (porcentaje / 100m)) : subtotal * ((porcentaje / 100) + 1) : subtotal;
                    iva = Math.Round(subtotal * 0.21M, 2);
                    total = Math.Round(subtotal + iva, 2);

                    if (iva < 0)
                        iva = total = 0;
                }
                return (iva, total);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
