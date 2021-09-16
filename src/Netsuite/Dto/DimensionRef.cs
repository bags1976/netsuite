namespace Netsuite.Dto
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SelectDimensionRef))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StringDimensionRef))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public abstract partial class DimensionRef {

        private string scriptIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string scriptId {
            get {
                return this.scriptIdField;
            }
            set {
                this.scriptIdField = value;
            }
        }
    }
}