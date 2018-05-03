using System.Xml.Serialization;

namespace log4net.ConfigurationModel
{
    public class RootLogger
    {
        /// <summary>
        /// Zero or more elements allowed. Allows the logger to reference appenders by name.
        /// </summary>
        [XmlElement("appender-ref")]
        public AppenderRef AppenderRef { get; set; }

        /// <summary>
        /// Optional element, maximum of one allowed. Defines the logging level for this logger. This logger will only accept event that are at this level or above.
        /// </summary>
        [XmlElement("level")]
        public Level Level { get; set; }

        /// <summary>
        /// Zero or more elements allowed. Logger specific parameters.
        /// </summary>
        [XmlElement("param")]
        public Param[] Param { get; set; }
    }
}
