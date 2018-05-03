using System.Xml.Serialization;

namespace log4net.ConfigurationModel
{
    public class Logger
    {
        /// <summary>
        /// Required attribute. Value must be the name of the logger.
        /// </summary>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <summary>
        /// Optional attribute. Value may be either true or false. The default value is true. Set this attribute to false to prevent this logger from inheriting the appenders defined on parent loggers.
        /// </summary>
        [XmlAttribute("additivity")]
        public string Additivity { get; set; }

        /// <summary>
        /// Zero or more elements allowed. Allows the logger to reference appenders by name.
        /// </summary>
        [XmlElement("appender-ref")]
        public string AppenderRef { get; set; }

        /// <summary>
        /// Optional element, maximum of one allowed. Defines the logging level for this logger. This logger will only accept event that are at this level or above.
        /// </summary>
        [XmlAttribute("level")]
        public string Level { get; set; }

        /// <summary>
        /// Zero or more elements allowed. Logger specific parameters.
        /// </summary>
        [XmlElement("param")]
        public string[] Param { get; set; }
    }
}
