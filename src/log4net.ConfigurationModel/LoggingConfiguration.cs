using System;
using System.Xml.Serialization;

namespace log4net.ConfigurationModel
{
    [Serializable]
    [XmlRoot("log4net")]
    public class LoggingConfiguration
    {
        /// <summary>
        /// Optional attribute. Value must be either true or false. The default value is false. Set this attribute to true to enable internal log4net debugging for this configuration.
        /// </summary>
        [XmlAttribute("debug")]
        public bool Debug { get; set; }

        /// <summary>
        /// Optional attribute. Value must be either Merge or Overwrite. The default value is Merge. Set this attribute to Overwrite to reset the configuration of the repository being configured before applying this configuration.
        /// </summary>
        [XmlAttribute("update")]
        public string Update { get; set; }

        /// <summary>
        /// Optional attribute. Value must be the name of a level registered on the repository. The default value is ALL. Set this attribute to limit the messages that are logged across the whole repository, regardless of the logger that the message is logged to.
        /// </summary>
        [XmlAttribute("threshold")]
        public string Threshold { get; set; }

        /// <summary>
        /// Zero or more elements allowed. Defines an appender.
        /// </summary>
        [XmlElement("appender")]
        public Appender[] Appender { get; set; }

        /// <summary>
        /// Zero or more elements allowed. Defines the configuration of a logger.
        /// </summary>
        [XmlElement("logger")]
        public Logger[] Logger { get; set; }

        /// <summary>
        /// Zero or more elements allowed. Defines an object renderer.
        /// </summary>
        [XmlElement("renderer")]
        public Renderer Renderer { get; set; }

        /// <summary>
        /// Optional element, maximum of one allowed. Defines the configuration of the root logger.
        /// </summary>
        [XmlElement("root")]
        public RootLogger Root { get; set; }

        /// <summary>
        /// Zero or more elements allowed. Repository specific parameters.
        /// </summary>
        [XmlElement("param")]
        public Param[] Param { get; set; }
    }
}
