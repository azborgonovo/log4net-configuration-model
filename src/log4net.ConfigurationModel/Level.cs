using System.Xml.Serialization;

namespace log4net.ConfigurationModel
{
    public class Level
    {
        [XmlAttribute("value")]
        public string Value { get; set; }
    }
}
