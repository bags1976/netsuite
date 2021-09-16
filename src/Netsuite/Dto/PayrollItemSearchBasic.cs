namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class PayrollItemSearchBasic : SearchRecordBasic {

        private SearchMultiSelectField expenseAccountField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchEnumMultiSelectField itemTypeNoHierarchyField;

        private SearchMultiSelectField liabilityAccountField;

        private SearchStringField nameField;

        private SearchMultiSelectField subsidiaryField;

        private SearchMultiSelectField vendorField;

        private SearchCustomField[] customFieldListField;

        /// <remarks/>
        public SearchMultiSelectField expenseAccount {
            get {
                return this.expenseAccountField;
            }
            set {
                this.expenseAccountField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField externalId {
            get {
                return this.externalIdField;
            }
            set {
                this.externalIdField = value;
            }
        }

        /// <remarks/>
        public SearchStringField externalIdString {
            get {
                return this.externalIdStringField;
            }
            set {
                this.externalIdStringField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }

        /// <remarks/>
        public SearchLongField internalIdNumber {
            get {
                return this.internalIdNumberField;
            }
            set {
                this.internalIdNumberField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField itemTypeNoHierarchy {
            get {
                return this.itemTypeNoHierarchyField;
            }
            set {
                this.itemTypeNoHierarchyField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField liabilityAccount {
            get {
                return this.liabilityAccountField;
            }
            set {
                this.liabilityAccountField = value;
            }
        }

        /// <remarks/>
        public SearchStringField name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField vendor {
            get {
                return this.vendorField;
            }
            set {
                this.vendorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("customField", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public SearchCustomField[] customFieldList {
            get {
                return this.customFieldListField;
            }
            set {
                this.customFieldListField = value;
            }
        }
    }
}