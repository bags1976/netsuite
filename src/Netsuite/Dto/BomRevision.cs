namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class BomRevision : Record {

        private RecordRef customFormField;

        private string nameField;

        private System.DateTime createdDateField;

        private bool createdDateFieldSpecified;

        private RecordRef billOfMaterialsField;

        private string memoField;

        private bool isInactiveField;

        private bool isInactiveFieldSpecified;

        private System.DateTime effectiveStartDateField;

        private bool effectiveStartDateFieldSpecified;

        private System.DateTime effectiveEndDateField;

        private bool effectiveEndDateFieldSpecified;

        private BomRevisionComponentList componentListField;

        private CustomFieldRef[] customFieldListField;

        private string internalIdField;

        private string externalIdField;

        /// <remarks/>
        public RecordRef customForm {
            get {
                return this.customFormField;
            }
            set {
                this.customFormField = value;
            }
        }

        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public System.DateTime createdDate {
            get {
                return this.createdDateField;
            }
            set {
                this.createdDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool createdDateSpecified {
            get {
                return this.createdDateFieldSpecified;
            }
            set {
                this.createdDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef billOfMaterials {
            get {
                return this.billOfMaterialsField;
            }
            set {
                this.billOfMaterialsField = value;
            }
        }

        /// <remarks/>
        public string memo {
            get {
                return this.memoField;
            }
            set {
                this.memoField = value;
            }
        }

        /// <remarks/>
        public bool isInactive {
            get {
                return this.isInactiveField;
            }
            set {
                this.isInactiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isInactiveSpecified {
            get {
                return this.isInactiveFieldSpecified;
            }
            set {
                this.isInactiveFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime effectiveStartDate {
            get {
                return this.effectiveStartDateField;
            }
            set {
                this.effectiveStartDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool effectiveStartDateSpecified {
            get {
                return this.effectiveStartDateFieldSpecified;
            }
            set {
                this.effectiveStartDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime effectiveEndDate {
            get {
                return this.effectiveEndDateField;
            }
            set {
                this.effectiveEndDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool effectiveEndDateSpecified {
            get {
                return this.effectiveEndDateFieldSpecified;
            }
            set {
                this.effectiveEndDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public BomRevisionComponentList componentList {
            get {
                return this.componentListField;
            }
            set {
                this.componentListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("customField", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public CustomFieldRef[] customFieldList {
            get {
                return this.customFieldListField;
            }
            set {
                this.customFieldListField = value;
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
        public string externalId {
            get {
                return this.externalIdField;
            }
            set {
                this.externalIdField = value;
            }
        }
    }
}