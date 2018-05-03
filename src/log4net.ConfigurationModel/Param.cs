using System.Xml.Serialization;

namespace log4net.ConfigurationModel
{
    // TODO: needs to be improved to handle Compact Parameter Syntax
    public class Param
    {
        /// <summary>
        /// Required attribute. Value must be the name of the parameter to set on the parent object.
        /// </summary>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <summary>
        /// Optional attribute. One of value or type attributes must be specified. The value of this attribute is a string that can be converted to the value of the parameter.
        /// </summary>
        [XmlAttribute("value")]
        public string Value { get; set; }

        /// <summary>
        /// Optional attribute. One of value or type attributes must be specified. The value of this attribute is a type name to create and set as the value of the parameter. If the type is not defined in the log4net assembly this type name must be fully assembly qualified.
        /// </summary>
        [XmlAttribute("type")]
        public string Type { get; set; }

        /// <summary>
        /// Zero or more elements allowed. Parameter specific parameters.
        /// </summary>
        [XmlElement("param")]
        public Param[] NestedParams { get; set; }
    }
}
