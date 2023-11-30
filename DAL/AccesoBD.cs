using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;

namespace DAL
{
    public class AccesoBD
    {
        private const string FileName = "Alquisoft.xml";
        private string Rute = Path.Combine(Directory.GetCurrentDirectory(), FileName);

        
        public XDocument Cargar_XML()
        {
            XDocument xDocument = null;
            try
            {
                if (File.Exists(Rute))
                    xDocument = XDocument.Load(Rute);
                else
                {
                    xDocument = XDocument.Load(Rute);
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

            return xDocument;


        }

        public XElement Cargar_Xelement()
        {
            XElement xElement = null;
            try
            {
                if (File.Exists(Rute))
                    xElement = XElement.Load(Rute);

            }
            catch (XmlException xex)
            {
                throw xex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return xElement;

        }

        public void Guardar_XML(XDocument document)
        {
            try
            {
                if (document != null)
                    document.Save(Rute);
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
    }
}
