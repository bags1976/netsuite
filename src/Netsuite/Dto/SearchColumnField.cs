namespace Netsuite.Dto
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SearchColumnSelectField))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SearchColumnEnumSelectField))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SearchColumnDateField))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SearchColumnDoubleField))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SearchColumnTextNumberField))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SearchColumnLongField))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SearchColumnStringField))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SearchColumnBooleanField))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public abstract partial class SearchColumnField {

        private string customLabelField;

        /// <remarks/>
        public string customLabel {
            get {
                return this.customLabelField;
            }
            set {
                this.customLabelField = value;
            }
        }
    }
}