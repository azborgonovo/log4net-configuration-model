using System.Xml.Serialization;

namespace log4net.ConfigurationModel
{
    public class AppenderRef
    {
        [XmlAttribute("ref")]
        public string Ref { get; set; }
    }
}
