using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public partial class CustomizationType {

        private GetCustomizationType getCustomizationTypeField;

        private bool getCustomizationTypeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public GetCustomizationType getCustomizationType {
            get {
                return this.getCustomizationTypeField;
            }
            set {
                this.getCustomizationTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool getCustomizationTypeSpecified {
            get {
                return this.getCustomizationTypeFieldSpecified;
            }
            set {
                this.getCustomizationTypeFieldSpecified = value;
            }
        }
    }
}