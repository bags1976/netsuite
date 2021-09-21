using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:employees_2021_1.lists.webservices.netsuite.com")]
    public partial class PayrollItem : Record {

        private RecordRef subsidiaryField;

        private RecordRef itemTypeField;

        private string nameField;

        private RecordRef vendorField;

        private RecordRef expenseAccountField;

        private RecordRef liabilityAccountField;

        private bool employeePaidField;

        private bool employeePaidFieldSpecified;

        private PayrollItemAccountCategory accountCategoryField;

        private bool accountCategoryFieldSpecified;

        private bool inactiveField;

        private bool inactiveFieldSpecified;

        private CustomFieldRef[] customFieldListField;

        private string internalIdField;

        private string externalIdField;

        /// <remarks/>
        public RecordRef subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
            }
        }

        /// <remarks/>
        public RecordRef itemType {
            get {
                return this.itemTypeField;
            }
            set {
                this.itemTypeField = value;
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
        public RecordRef vendor {
            get {
                return this.vendorField;
            }
            set {
                this.vendorField = value;
            }
        }

        /// <remarks/>
        public RecordRef expenseAccount {
            get {
                return this.expenseAccountField;
            }
            set {
                this.expenseAccountField = value;
            }
        }

        /// <remarks/>
        public RecordRef liabilityAccount {
            get {
                return this.liabilityAccountField;
            }
            set {
                this.liabilityAccountField = value;
            }
        }

        /// <remarks/>
        public bool employeePaid {
            get {
                return this.employeePaidField;
            }
            set {
                this.employeePaidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool employeePaidSpecified {
            get {
                return this.employeePaidFieldSpecified;
            }
            set {
                this.employeePaidFieldSpecified = value;
            }
        }

        /// <remarks/>
        public PayrollItemAccountCategory accountCategory {
            get {
                return this.accountCategoryField;
            }
            set {
                this.accountCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool accountCategorySpecified {
            get {
                return this.accountCategoryFieldSpecified;
            }
            set {
                this.accountCategoryFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool inactive {
            get {
                return this.inactiveField;
            }
            set {
                this.inactiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool inactiveSpecified {
            get {
                return this.inactiveFieldSpecified;
            }
            set {
                this.inactiveFieldSpecified = value;
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