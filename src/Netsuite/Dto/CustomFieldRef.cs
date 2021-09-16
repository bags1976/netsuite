namespace Netsuite.Dto
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiSelectCustomFieldRef))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SelectCustomFieldRef))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DateCustomFieldRef))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StringCustomFieldRef))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BooleanCustomFieldRef))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DoubleCustomFieldRef))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LongCustomFieldRef))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public abstract partial class CustomFieldRef {

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