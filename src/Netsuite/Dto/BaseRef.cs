namespace Netsuite.Dto
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InitializeAuxRef))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InitializeRef))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CustomTransactionRef))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CustomRecordRef))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RecordRef))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CustomizationRef))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public abstract partial class BaseRef {

        private string nameField;

        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
}