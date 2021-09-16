namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class ChargeSearchBasic : SearchRecordBasic {

        private SearchDoubleField amountField;

        private SearchMultiSelectField billingAccountField;

        private SearchMultiSelectField billingItemField;

        private SearchMultiSelectField billToField;

        private SearchDateField chargeDateField;

        private SearchMultiSelectField chargeTypeField;

        private SearchMultiSelectField classField;

        private SearchDateField createdDateField;

        private SearchMultiSelectField currencyField;

        private SearchMultiSelectField departmentField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchMultiSelectField locationField;

        private SearchDateField modifiedDateField;

        private RecordRef postingPeriodField;

        private PostingPeriodDate postingPeriodRelativeField;

        private bool postingPeriodRelativeFieldSpecified;

        private SearchDoubleField quantityField;

        private SearchDoubleField rateField;

        private SearchMultiSelectField ruleField;

        private SearchStringField runIdField;

        private SearchLongField salesOrderField;

        private SearchEnumMultiSelectField stageField;

        private SearchMultiSelectField subscriptionLineField;

        private SearchEnumMultiSelectField useField;

        private SearchCustomField[] customFieldListField;

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
        public SearchMultiSelectField billingAccount {
            get {
                return this.billingAccountField;
            }
            set {
                this.billingAccountField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField billingItem {
            get {
                return this.billingItemField;
            }
            set {
                this.billingItemField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField billTo {
            get {
                return this.billToField;
            }
            set {
                this.billToField = value;
            }
        }

        /// <remarks/>
        public SearchDateField chargeDate {
            get {
                return this.chargeDateField;
            }
            set {
                this.chargeDateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField chargeType {
            get {
                return this.chargeTypeField;
            }
            set {
                this.chargeTypeField = value;
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
        public SearchDateField createdDate {
            get {
                return this.createdDateField;
            }
            set {
                this.createdDateField = value;
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
        public SearchMultiSelectField department {
            get {
                return this.departmentField;
            }
            set {
                this.departmentField = value;
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
        public SearchMultiSelectField location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }

        /// <remarks/>
        public SearchDateField modifiedDate {
            get {
                return this.modifiedDateField;
            }
            set {
                this.modifiedDateField = value;
            }
        }

        /// <remarks/>
        public RecordRef postingPeriod {
            get {
                return this.postingPeriodField;
            }
            set {
                this.postingPeriodField = value;
            }
        }

        /// <remarks/>
        public PostingPeriodDate postingPeriodRelative {
            get {
                return this.postingPeriodRelativeField;
            }
            set {
                this.postingPeriodRelativeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool postingPeriodRelativeSpecified {
            get {
                return this.postingPeriodRelativeFieldSpecified;
            }
            set {
                this.postingPeriodRelativeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField rate {
            get {
                return this.rateField;
            }
            set {
                this.rateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField rule {
            get {
                return this.ruleField;
            }
            set {
                this.ruleField = value;
            }
        }

        /// <remarks/>
        public SearchStringField runId {
            get {
                return this.runIdField;
            }
            set {
                this.runIdField = value;
            }
        }

        /// <remarks/>
        public SearchLongField salesOrder {
            get {
                return this.salesOrderField;
            }
            set {
                this.salesOrderField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField stage {
            get {
                return this.stageField;
            }
            set {
                this.stageField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField subscriptionLine {
            get {
                return this.subscriptionLineField;
            }
            set {
                this.subscriptionLineField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField use {
            get {
                return this.useField;
            }
            set {
                this.useField = value;
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