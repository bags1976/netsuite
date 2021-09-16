namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class ExpenseCategory : Record {

        private RecordRef customFormField;

        private string nameField;

        private string descriptionField;

        private RecordRef expenseAcctField;

        private bool isInactiveField;

        private bool isInactiveFieldSpecified;

        private bool rateRequiredField;

        private bool rateRequiredFieldSpecified;

        private RecordRef[] subsidiaryListField;

        private double defaultRateField;

        private bool defaultRateFieldSpecified;

        private ExpenseCategoryRatesList ratesListField;

        private TranslationList translationsListField;

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
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public RecordRef expenseAcct {
            get {
                return this.expenseAcctField;
            }
            set {
                this.expenseAcctField = value;
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
        public bool rateRequired {
            get {
                return this.rateRequiredField;
            }
            set {
                this.rateRequiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rateRequiredSpecified {
            get {
                return this.rateRequiredFieldSpecified;
            }
            set {
                this.rateRequiredFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recordRef", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public RecordRef[] subsidiaryList {
            get {
                return this.subsidiaryListField;
            }
            set {
                this.subsidiaryListField = value;
            }
        }

        /// <remarks/>
        public double defaultRate {
            get {
                return this.defaultRateField;
            }
            set {
                this.defaultRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultRateSpecified {
            get {
                return this.defaultRateFieldSpecified;
            }
            set {
                this.defaultRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ExpenseCategoryRatesList ratesList {
            get {
                return this.ratesListField;
            }
            set {
                this.ratesListField = value;
            }
        }

        /// <remarks/>
        public TranslationList translationsList {
            get {
                return this.translationsListField;
            }
            set {
                this.translationsListField = value;
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