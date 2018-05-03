using System.Xml.Serialization;

namespace log4net.ConfigurationModel
{
    public class Filter
    {
        /// <summary>
        /// Required attribute. Value must be the type name for this filter. If the filter is not defined in the log4net assembly this type name must be fully assembly qualified.
        /// </summary>
        [XmlAttribute("type")]
        public string Type { get; set; }

        /// <summary>
        /// Zero or more elements allowed. Filter specific parameters.
        /// </summary>
        [XmlElement("param")]
        public Param[] Param { get; set; }
    }
}
