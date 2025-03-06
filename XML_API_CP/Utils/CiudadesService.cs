using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using XML_API_CP.Models;

namespace XML_API_CP.Utils
{
    public class CiudadesService
    {
        public static List<MColoniaL> GetCities(int? zipCode)
        {
            List<MColoniaL> Lcolonias = new List<MColoniaL>();
            XmlDocument doc = new XmlDocument();
            string xmlFilePath = ConfigurationManager.AppSettings["ArchivoXML"];
            doc.Load(xmlFilePath);
            foreach (XmlNode n1 in doc.DocumentElement.ChildNodes)
            {
                MColoniaL colonia = new MColoniaL();
                for (int i = 0; i < n1.ChildNodes.Count; i++)
                {
                    string Name = n1.ChildNodes[i].Name;

                    if (colonia.Id == 0 && n1.Attributes.Count>0)
                        colonia.Id = Convert.ToInt32(n1.Attributes["ID"].Value);
                    if (Name == "DESCRIPCION_COLONIA")
                        colonia.DescripcionColonia = n1.ChildNodes[i].InnerText;
                    
                    if (Name == "CODIGO_COLONIA")
                        colonia.CodigoColonia = Convert.ToInt32(n1.ChildNodes[i].InnerText);
                }
                        Lcolonias.Add(colonia);
            }
            var LZipCode = Lcolonias.Where(x => x.CodigoColonia == zipCode).ToList();

            return LZipCode;
        }
    }
}