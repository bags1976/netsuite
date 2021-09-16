namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class Account : Record {

        private AccountType acctTypeField;

        private bool acctTypeFieldSpecified;

        private RecordRef unitsTypeField;

        private RecordRef unitField;

        private string acctNumberField;

        private string acctNameField;

        private string legalNameField;

        private bool includeChildrenField;

        private bool includeChildrenFieldSpecified;

        private RecordRef currencyField;

        private string exchangeRateField;

        private ConsolidatedRate generalRateField;

        private bool generalRateFieldSpecified;

        private RecordRef parentField;

        private ConsolidatedRate cashFlowRateField;

        private bool cashFlowRateFieldSpecified;

        private RecordRef billableExpensesAcctField;

        private RecordRef deferralAcctField;

        private string descriptionField;

        private long curDocNumField;

        private bool curDocNumFieldSpecified;

        private bool isInactiveField;

        private bool isInactiveFieldSpecified;

        private RecordRef departmentField;

        private RecordRef classField;

        private RecordRef locationField;

        private RecordRef[] restrictToAccountingBookListField;

        private bool inventoryField;

        private bool inventoryFieldSpecified;

        private bool eliminateField;

        private bool eliminateFieldSpecified;

        private RecordRef[] subsidiaryListField;

        private RecordRef category1099miscField;

        private AccountLocalizationsList localizationsListField;

        private double openingBalanceField;

        private bool openingBalanceFieldSpecified;

        private System.DateTime tranDateField;

        private bool tranDateFieldSpecified;

        private bool revalueField;

        private bool revalueFieldSpecified;

        private CustomFieldRef[] customFieldListField;

        private string internalIdField;

        private string externalIdField;

        /// <remarks/>
        public AccountType acctType {
            get {
                return this.acctTypeField;
            }
            set {
                this.acctTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool acctTypeSpecified {
            get {
                return this.acctTypeFieldSpecified;
            }
            set {
                this.acctTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef unitsType {
            get {
                return this.unitsTypeField;
            }
            set {
                this.unitsTypeField = value;
            }
        }

        /// <remarks/>
        public RecordRef unit {
            get {
                return this.unitField;
            }
            set {
                this.unitField = value;
            }
        }

        /// <remarks/>
        public string acctNumber {
            get {
                return this.acctNumberField;
            }
            set {
                this.acctNumberField = value;
            }
        }

        /// <remarks/>
        public string acctName {
            get {
                return this.acctNameField;
            }
            set {
                this.acctNameField = value;
            }
        }

        /// <remarks/>
        public string legalName {
            get {
                return this.legalNameField;
            }
            set {
                this.legalNameField = value;
            }
        }

        /// <remarks/>
        public bool includeChildren {
            get {
                return this.includeChildrenField;
            }
            set {
                this.includeChildrenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool includeChildrenSpecified {
            get {
                return this.includeChildrenFieldSpecified;
            }
            set {
                this.includeChildrenFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        public string exchangeRate {
            get {
                return this.exchangeRateField;
            }
            set {
                this.exchangeRateField = value;
            }
        }

        /// <remarks/>
        public ConsolidatedRate generalRate {
            get {
                return this.generalRateField;
            }
            set {
                this.generalRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool generalRateSpecified {
            get {
                return this.generalRateFieldSpecified;
            }
            set {
                this.generalRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef parent {
            get {
                return this.parentField;
            }
            set {
                this.parentField = value;
            }
        }

        /// <remarks/>
        public ConsolidatedRate cashFlowRate {
            get {
                return this.cashFlowRateField;
            }
            set {
                this.cashFlowRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cashFlowRateSpecified {
            get {
                return this.cashFlowRateFieldSpecified;
            }
            set {
                this.cashFlowRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef billableExpensesAcct {
            get {
                return this.billableExpensesAcctField;
            }
            set {
                this.billableExpensesAcctField = value;
            }
        }

        /// <remarks/>
        public RecordRef deferralAcct {
            get {
                return this.deferralAcctField;
            }
            set {
                this.deferralAcctField = value;
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
        public long curDocNum {
            get {
                return this.curDocNumField;
            }
            set {
                this.curDocNumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool curDocNumSpecified {
            get {
                return this.curDocNumFieldSpecified;
            }
            set {
                this.curDocNumFieldSpecified = value;
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
        public RecordRef department {
            get {
                return this.departmentField;
            }
            set {
                this.departmentField = value;
            }
        }

        /// <remarks/>
        public RecordRef @class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
            }
        }

        /// <remarks/>
        public RecordRef location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recordRef", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public RecordRef[] restrictToAccountingBookList {
            get {
                return this.restrictToAccountingBookListField;
            }
            set {
                this.restrictToAccountingBookListField = value;
            }
        }

        /// <remarks/>
        public bool inventory {
            get {
                return this.inventoryField;
            }
            set {
                this.inventoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool inventorySpecified {
            get {
                return this.inventoryFieldSpecified;
            }
            set {
                this.inventoryFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool eliminate {
            get {
                return this.eliminateField;
            }
            set {
                this.eliminateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool eliminateSpecified {
            get {
                return this.eliminateFieldSpecified;
            }
            set {
                this.eliminateFieldSpecified = value;
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
        public RecordRef category1099misc {
            get {
                return this.category1099miscField;
            }
            set {
                this.category1099miscField = value;
            }
        }

        /// <remarks/>
        public AccountLocalizationsList localizationsList {
            get {
                return this.localizationsListField;
            }
            set {
                this.localizationsListField = value;
            }
        }

        /// <remarks/>
        public double openingBalance {
            get {
                return this.openingBalanceField;
            }
            set {
                this.openingBalanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool openingBalanceSpecified {
            get {
                return this.openingBalanceFieldSpecified;
            }
            set {
                this.openingBalanceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime tranDate {
            get {
                return this.tranDateField;
            }
            set {
                this.tranDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tranDateSpecified {
            get {
                return this.tranDateFieldSpecified;
            }
            set {
                this.tranDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool revalue {
            get {
                return this.revalueField;
            }
            set {
                this.revalueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool revalueSpecified {
            get {
                return this.revalueFieldSpecified;
            }
            set {
                this.revalueFieldSpecified = value;
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