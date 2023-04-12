using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLJSON
{
    [XmlRoot(ElementName = "catalog")]
    public class Catalog
    {

        [XmlElement(ElementName = "part")]
        public List<Part> Part { get; set; }
    }

    [XmlRoot(ElementName = "price")]
    public class Price
    {

        [XmlAttribute(AttributeName = "currency")]
        public string Currency { get; set; }

        [XmlText]
        public double Text { get; set; }
    }

    [XmlRoot(ElementName = "compatibility")]
    public class Compatibility
    {

        [XmlElement(ElementName = "make")]
        public string Make { get; set; }

        [XmlElement(ElementName = "model")]
        public string Model { get; set; }

        [XmlElement(ElementName = "year")]
        public int Year { get; set; }
    }

    [XmlRoot(ElementName = "part")]
    public class Part
    {

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "brand")]
        public string Brand { get; set; }

        [XmlElement(ElementName = "model")]
        public string Model { get; set; }

        [XmlElement(ElementName = "price")]
        public Price Price { get; set; }

        [XmlElement(ElementName = "compatibility")]
        public Compatibility Compatibility { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public int Id { get; set; }

        [XmlText]
        public string Text { get; set; }
    }
}
