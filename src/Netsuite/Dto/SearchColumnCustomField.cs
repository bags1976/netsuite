namespace Netsuite.Dto
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SearchColumnMultiSelectCustomField))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SearchColumnSelectCustomField))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SearchColumnEnumMultiSelectCustomField))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SearchColumnDateCustomField))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SearchColumnDoubleCustomField))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SearchColumnLongCustomField))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SearchColumnStringCustomField))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SearchColumnBooleanCustomField))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public abstract partial class SearchColumnCustomField {

        private string customLabelField;

        private string internalIdField;

        private string scriptIdField;

        /// <remarks/>
        public string customLabel {
            get {
                return this.customLabelField;
            }
            set {
                this.customLabelField = value;
            }
        }

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