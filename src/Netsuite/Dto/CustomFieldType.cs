namespace Netsuite.Dto
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ItemNumberCustomField))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CustomRecordCustomField))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ItemOptionCustomField))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TransactionColumnCustomField))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TransactionBodyCustomField))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ItemCustomField))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherCustomField))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CrmCustomField))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityCustomField))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:customization_2021_1.setup.webservices.netsuite.com")]
    public abstract partial class CustomFieldType : Record {

        private CustomizationFieldType fieldTypeField;

        private bool fieldTypeFieldSpecified;

        private string scriptIdField;

        /// <remarks/>
        public CustomizationFieldType fieldType {
            get {
                return this.fieldTypeField;
            }
            set {
                this.fieldTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fieldTypeSpecified {
            get {
                return this.fieldTypeFieldSpecified;
            }
            set {
                this.fieldTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
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