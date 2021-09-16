namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class BudgetSearchBasic : SearchRecordBasic {

        private SearchMultiSelectField accountField;

        private SearchMultiSelectField accountingBookField;

        private SearchDoubleField amountField;

        private SearchMultiSelectField categoryField;

        private SearchMultiSelectField classField;

        private SearchMultiSelectField currencyField;

        private SearchMultiSelectField customerField;

        private SearchMultiSelectField departmentField;

        private SearchBooleanField globalField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchMultiSelectField itemField;

        private SearchMultiSelectField locationField;

        private SearchMultiSelectField subsidiaryField;

        private SearchMultiSelectField yearField;

        private SearchMultiSelectField year2Field;

        private SearchCustomField[] customFieldListField;

        /// <remarks/>
        public SearchMultiSelectField account {
            get {
                return this.accountField;
            }
            set {
                this.accountField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField accountingBook {
            get {
                return this.accountingBookField;
            }
            set {
                this.accountingBookField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField @class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField customer {
            get {
                return this.customerField;
            }
            set {
                this.customerField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField department {
            get {
                return this.departmentField;
            }
            set {
                this.departmentField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField global {
            get {
                return this.globalField;
            }
            set {
                this.globalField = value;
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
        public SearchMultiSelectField item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
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
        public SearchMultiSelectField year {
            get {
                return this.yearField;
            }
            set {
                this.yearField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField year2 {
            get {
                return this.year2Field;
            }
            set {
                this.year2Field = value;
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