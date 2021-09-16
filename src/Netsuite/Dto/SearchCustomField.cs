namespace Netsuite.Dto
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SearchMultiSelectCustomField))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SearchEnumMultiSelectCustomField))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SearchDateCustomField))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SearchDoubleCustomField))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SearchLongCustomField))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SearchStringCustomField))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SearchBooleanCustomField))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public abstract partial class SearchCustomField {

        private string internalIdField;

        private string scriptIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }

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