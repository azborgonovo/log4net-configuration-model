using System.Xml.Serialization;

namespace log4net.ConfigurationModel
{
    public class Appender
    {
        /// <summary>
        /// Required attribute. Value must be a string name for this appender. The name must be unique among all the appenders defined in this configuration file. This name is used by the <appender-ref> element of a Logger to reference an appender.
        /// </summary>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <summary>
        /// Required attribute. Value must be the type name for this appender. If the appender is not defined in the log4net assembly this type name must be fully assembly qualified.
        /// </summary>
        [XmlAttribute("type")]
        public string Type { get; set; }

        /// <summary>
        /// Zero or more elements allowed. Allows the appender to reference other appenders. Not supported by all appenders.
        /// </summary>
        [XmlElement("appender-ref")]
        public string[] AppenderRef { get; set; }

        /// <summary>
        /// Zero or more elements allowed. Defines the filters used by this appender.
        /// </summary>
        [XmlElement("filter")]
        public Filter[] Filter { get; set; }

        /// <summary>
        /// Optional element, maximum of one allowed. Defines the layout used by this appender.
        /// </summary>
        [XmlElement("layout")]
        public Layout Layout { get; set; }

        /// <summary>
        /// Zero or more elements allowed. Appender specific parameters.
        /// </summary>
        [XmlElement("param")]
        public Param[] Param { get; set; }
    }
}
