using System.Xml.Serialization;

namespace log4net.ConfigurationModel
{
    public class Renderer
    {
        /// <summary>
        /// Required attribute. Value must be the type name for this renderer. If the type is not defined in the log4net assembly this type name must be fully assembly qualified. This is the type of the object that will take responsibility for rendering the renderedClass.
        /// </summary>
        [XmlAttribute("renderingClass")]
        public string RenderingClass { get; set; }

        /// <summary>
        /// Required attribute. Value must be the type name for the target type for this renderer. If the type is not defined in the log4net assembly this type name must be fully assembly qualified. This is the name of the type that this renderer will render.
        /// </summary>
        [XmlAttribute("renderedClass")]
        public string RenderedClass { get; set; }
    }
}
