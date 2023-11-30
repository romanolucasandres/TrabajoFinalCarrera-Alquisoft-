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
using System.Data;

namespace MPP
{
    public class MPP_ComprobanteCobroAlquiler : I_ABM<BE_ComprobanteCobroAlquiler>, I_Traer<BE_ComprobanteCobroAlquiler>
    {
        private AccesoBD bd;

        public MPP_ComprobanteCobroAlquiler()
        {
            bd = new AccesoBD();
        }
        public void Alta(BE_ComprobanteCobroAlquiler x)
        {
            try
            {
                XDocument xDocument = bd.Cargar_XML();
                if(xDocument != null )
                {
                    xDocument.Element("Alquisoft").Element("Cobros").Add(new XElement("Cobro",
                        new XAttribute("n_comprobante", x.NroComprobante.ToString().Trim()),
                        new XElement("importetotal", x.ImporteTotal.ToString().Trim()),
                        new XElement("medio", x.Medio.ToString().Trim()),
                        new XElement("fecha", x.Fecha.ToString().Trim()),
                        new XElement("clientecomprobante",x.ClienteComprobante.DNI.ToString().Trim()),
                        new XElement("n_factura", x.N_Factura.NroComprobante.ToString().Trim())
                        ));
                    bd.Guardar_XML(xDocument);

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

        public void Baja(BE_ComprobanteCobroAlquiler x)
        {
            try
            {
                XDocument XML = bd.Cargar_XML();

                if (XML != null)
                {
                    var leer = from Cobro in XML.Descendants("Cobro")
                               where Cobro.Attribute("n_comprobante").Value == x.NroComprobante.ToString().Trim()
                               select Cobro;
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

        public void Modificacion(BE_ComprobanteCobroAlquiler x)
        {
            try
            {
                XDocument XML = bd.Cargar_XML();
                if (XML != null)
                {
                    var leer = from Cobro in XML.Descendants("Cobro")
                               where Cobro.Attribute("n_comprobante").Value == x.NroComprobante.ToString().Trim()
                               select Cobro;

                    foreach (var item in leer)
                    {
                        item.Element("importetotal").Value = x.ImporteTotal.ToString().Trim();
                        item.Element("fecha").Value = x.Fecha.ToString().Trim();
                        item.Element("medio").Value = x.Medio.ToString().Trim();
                        item.Element("clientecomprobante").Value = x.ClienteComprobante.DNI.ToString().Trim();
                        item.Element("factura").Value = x.N_Factura.NroComprobante.ToString().Trim();
                        
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

        public List<BE_ComprobanteCobroAlquiler> Traer()
        {
            try
            {
                XElement xElement = bd.Cargar_Xelement();
                var leer = from Cobro in xElement.Elements("Cobros").Elements("Cobro")
                           select new BE_ComprobanteCobroAlquiler
                           {
                               NroComprobante = Convert.ToInt32(Cobro.Attribute("n_comprobante")?.Value.Trim()),
                               ImporteTotal = Convert.ToDecimal(Cobro.Element("importetotal")?.Value.Trim()),
                               Medio = Cobro.Element("medio")?.Value.Trim(),
                               Fecha = Convert.ToDateTime(Cobro.Element("fecha")?.Value.Trim()),
                               ClienteComprobante = TraerRelacionCliente(Convert.ToInt32(Cobro.Element("clientecomprobante")?.Value.Trim())),
                               N_Factura = TraerRelacionFactura(Convert.ToInt32(Cobro.Element("n_factura")?.Value.Trim()))
                           };

                List<BE_ComprobanteCobroAlquiler> Lista_Cobros = leer.ToList();
                return Lista_Cobros;
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

        public List<BE_ComprobanteCobroAlquiler> Traer(DateTime fecha)
        {
            try
            {
                return this.Traer().Where(x => x?.Fecha.Date == fecha .Date).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<BE_ComprobanteCobroAlquiler> Traer(BE_Cliente cliente)
        {
            try
            {
                return this.Traer().Where(x => x?.ClienteComprobante.Nro_Cliente == cliente?.Nro_Cliente).ToList();
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
                            ClienteRel.Nro_Cliente = Convert.ToInt32(item.Attribute("nro_cliente").Value.Trim());
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

        public BE_ComprobanteFactura TraerRelacionFactura(int nrofactura)
        {

            BE_ComprobanteFactura ComprobanteFactura = null;
            
            try
            {

                XDocument XML = bd.Cargar_XML();
                if (XML != null)
                {
                    var leer = from Factura in XML.Descendants("Factura")
                               where Factura.Attribute("n_comprobante").Value == nrofactura.ToString().Trim()
                               select Factura;
                    foreach (var item in leer)
                    {
                        if (item != null)
                        {
                            ComprobanteFactura = new BE_ComprobanteFactura();
                            ComprobanteFactura.NroComprobante = Convert.ToInt32(Convert.ToString(item.Attribute("n_comprobante")?.Value).Trim());
                            ComprobanteFactura.ImporteTotal = Convert.ToDecimal(item.Element("importetotal")?.Value.Trim());
                            ComprobanteFactura.Fecha = Convert.ToDateTime(item.Element("fecha")?.Value.Trim());
                            ComprobanteFactura.Subtotal = Convert.ToDecimal(item.Element("subtotal")?.Value.Trim());
                            ComprobanteFactura.Porcentaje = Convert.ToDecimal(item.Element("porcentaje")?.Value.Trim());
                            ComprobanteFactura.Iva = Convert.ToDecimal(item.Element("iva")?.Value.Trim());
                            ComprobanteFactura.EstadoPagado = Convert.ToBoolean(item.Element("estadopagado")?.Value.Trim());        
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
           
            return ComprobanteFactura;
        }
        public decimal ObtenerFacturaCobrada(BE_ComprobanteFactura factura)
        {
            try
            {
                decimal saldo = 0;
                List<BE_ComprobanteCobroAlquiler> cobros = this.Traer().Where(cobro => cobro != null && cobro.N_Factura.NroComprobante == factura.NroComprobante).ToList();
                if (cobros?.Count > 0)
                    cobros.ForEach(cobro => saldo += cobro.ImporteTotal);

                return saldo;
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
        public string ObtenerUltimoNumero()
        {
            string ultimonumero = "";
            try
            {
                var cobro = this.Traer().OrderByDescending(x => x?.NroComprobante).Where(t => t?.NroComprobante != null).FirstOrDefault();
                if (cobro?.NroComprobante != null)
                    ultimonumero = (cobro.NroComprobante + 1).ToString();
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
    }

}
