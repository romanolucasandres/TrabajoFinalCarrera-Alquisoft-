using DAL;
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
    public class MPP_Menu
    {
        private AccesoBD bd;
        public MPP_Menu()
        {
            bd = new AccesoBD();
        }


        public void Alta_Modificar(S_Componente x)
        {
            try
            {
                XDocument XML = bd.Cargar_XML();
                if (XML != null)
                {
                    var menuPadres = Traer().ObtenerLista();
                    List<S_Componente> menuhijos = new List<S_Componente>();
                    menuPadres.ForEach(p => menuhijos.AddRange(p.ObtenerLista()));

                    foreach (S_Compuesto padreactual in x.ObtenerLista())
                    {
                        if (!menuPadres.Exists(j => j.Numero == padreactual.Numero && j.Nombre == padreactual.Nombre))
                            this.Alta(padreactual, XML);
                        else if (menuPadres.Exists(j => j.Numero == padreactual.Numero && j.Nombre != padreactual.Nombre))
                            this.Modificacion(padreactual, XML);

                        if (padreactual.ObtenerLista()?.Count > 0)
                        {
                            foreach (S_Hoja hijoactual in padreactual.ObtenerLista())
                            {
                                if (!menuhijos.Exists(h => h.Numero == hijoactual.Numero))
                                    this.Alta(hijoactual, XML, padreactual.Numero);
                                else if (menuhijos.Exists(h => h?.Numero == hijoactual?.Numero && h?.Nombre != hijoactual?.Nombre))
                                    this.Modificacion(hijoactual, XML, padreactual.Numero);

                            }
                        }
                    }
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
                List<S_Componente> hijos = new List<S_Componente>();

                if (XML != null)
                {
                    S_Componente listaComponentes = this.Traer();
                    var padres = x.ObtenerLista();

                    padres.ForEach(p => hijos.AddRange(p.ObtenerLista()));
                    if (listaComponentes != null && padres != null && hijos != null)
                    {
                        foreach (var menu in listaComponentes.ObtenerLista())
                        {
                            if (padres.Exists(i => i.Numero == menu.Numero && i.Nombre != menu.Nombre))
                            {
                                var leer = from Componente in XML.Descendants("MenuPadresHijos")
                                           where Componente.Attribute("id").Value == menu.Numero.ToString().Trim()
                                           select Componente;
                                leer.Remove();
                            }

                            if (menu?.ObtenerLista()?.Count > 0)
                            {
                                foreach (var itemmenu in menu.ObtenerLista())
                                {
                                    if (hijos.Exists(j => j.Numero == itemmenu.Numero && j.Nombre != itemmenu.Nombre))
                                    {
                                        var leerhijo = from Componente in XML.Descendants("MenuPadresHijos")
                                                       where Componente.Attribute("id").Value == itemmenu.Numero.ToString().Trim()
                                                       select Componente;
                                        leerhijo.Remove();
                                    }
                                }
                            }
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

        private void Alta(S_Componente componente, XDocument XML, int? nro_padre = null)
        {
            try
            {
                if (XML != null)
                {
                    XML.Element("Alquisoft").Element("Menu").Add(new XElement("MenuPadresHijos",
                                                                                                   new XAttribute("id", componente.Numero.ToString().Trim()),
                                                                                                  new XElement("nombre", componente.Nombre.ToString().Trim()),
                                                                                                  nro_padre != null ? new XElement("idpadre", nro_padre.Value.ToString().Trim()) : null
                                                                                                  ));
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

        private void Modificacion(S_Componente componente, XDocument XML, int? nropadre = null)
        {
            try
            {

                if (XML != null)
                {
                    var leer = from Itemmenu in XML.Descendants("MenuPadresHijos")
                               where Itemmenu.Attribute("id").Value == componente.Numero.ToString().Trim()
                               select Itemmenu;

                    foreach (var item in leer)
                    {
                        item.Element("nombre").Value = componente.Nombre.ToString().Trim();
                        if (nropadre != null)
                            item.Element("idpadre").Value = nropadre.Value.ToString().Trim();
                    }
                }
            }
            catch (XmlException e) 
            { throw e; }
            catch (Exception e) 
            { throw e; }
        }

        public S_Componente Traer()
        {
            S_Componente Componente = null;
            try
            {

                XElement XML = bd.Cargar_Xelement();
                var leer = from Menuitems in XML.Elements("Menu").Elements("MenuPadresHijos")
                           where Menuitems.Attribute("id").Value.Trim() != "0" && Menuitems.Element("idpadre")?.Value == null
                           select new S_Compuesto(Convert.ToInt32(Menuitems.Attribute("id").Value.Trim()), Menuitems.Element("nombre").Value.Trim());

                Componente = new S_Compuesto("Menu");
                foreach (S_Compuesto item in leer)
                {
                    if (item != null)
                    {
                        List<S_Componente> hijos = Traerhijos(item.Numero, XML);
                        if (hijos?.Count > 0)
                        {
                            foreach (S_Hoja item2 in hijos)
                            {
                                item.AgregarNodo(item2);

                            }

                        }
                        Componente.AgregarNodo(item);
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
            return Componente;
        }

        private List<S_Componente> Traerhijos(int nro_padre, XElement x)
        {
            List<S_Componente> Lista = null;
            try
            {

                var leer = from MenuItemsHijos in x.Elements("Menu").Elements("MenuPadresHijos")
                           where MenuItemsHijos.Element("idpadre")?.Value != null && MenuItemsHijos.Element("idpadre")?.Value?.Trim() == nro_padre.ToString().Trim()
                           select new S_Hoja(Convert.ToInt32(MenuItemsHijos.Attribute("id").Value.Trim()), MenuItemsHijos.Element("nombre").Value.Trim());
                Lista = leer.ToList<S_Componente>();
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
