using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace XML_API_CP.Models
{
    [Serializable]
    public class MColonia
    {
        [XmlAttribute("ID")]
        public int ID { get; set; }

        [XmlElement("DESCRIPCION_COLONIA")]
        public string DescripcionColonia { get; set; }

        [XmlElement("CODIGO_COLONIA")]
        public int CodigoColonia { get; set; }
    }
    [Serializable]
    public class MData
    {
        [XmlElement("COLONIAS")]
        public Colonias Colonias { get; set; }
    }
    [Serializable]
    public class Colonias
    {
        [XmlElement("COLONIA")]
        public List<MColonia> ListaColonias { get; set; }
    }

    public class MColoniaL
    {
        
        public int Id { get; set; }

        public string DescripcionColonia { get; set; }

        public int CodigoColonia { get; set; }
    }
}