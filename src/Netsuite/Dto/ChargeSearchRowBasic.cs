namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class ChargeSearchRowBasic : SearchRowBasic {

        private SearchColumnDoubleField[] amountField;

        private SearchColumnSelectField[] billingAccountField;

        private SearchColumnSelectField[] billingItemField;

        private SearchColumnSelectField[] billToField;

        private SearchColumnDateField[] chargeDateField;

        private SearchColumnSelectField[] chargeTypeField;

        private SearchColumnSelectField[] classField;

        private SearchColumnDateField[] createdDateField;

        private SearchColumnSelectField[] currencyField;

        private SearchColumnSelectField[] departmentField;

        private SearchColumnStringField[] descriptionField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnSelectField[] locationField;

        private SearchColumnDateField[] modifiedDateField;

        private SearchColumnStringField[] postingPeriodField;

        private SearchColumnStringField[] quantityField;

        private SearchColumnStringField[] rateField;

        private SearchColumnSelectField[] ruleField;

        private SearchColumnStringField[] runIdField;

        private SearchColumnStringField[] salesOrderField;

        private SearchColumnEnumSelectField[] stageField;

        private SearchColumnSelectField[] subscriptionLineField;

        private SearchColumnEnumSelectField[] useField;

        private SearchColumnCustomField[] customFieldListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("amount")]
        public SearchColumnDoubleField[] amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billingAccount")]
        public SearchColumnSelectField[] billingAccount {
            get {
                return this.billingAccountField;
            }
            set {
                this.billingAccountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billingItem")]
        public SearchColumnSelectField[] billingItem {
            get {
                return this.billingItemField;
            }
            set {
                this.billingItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billTo")]
        public SearchColumnSelectField[] billTo {
            get {
                return this.billToField;
            }
            set {
                this.billToField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("chargeDate")]
        public SearchColumnDateField[] chargeDate {
            get {
                return this.chargeDateField;
            }
            set {
                this.chargeDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("chargeType")]
        public SearchColumnSelectField[] chargeType {
            get {
                return this.chargeTypeField;
            }
            set {
                this.chargeTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("class")]
        public SearchColumnSelectField[] @class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("createdDate")]
        public SearchColumnDateField[] createdDate {
            get {
                return this.createdDateField;
            }
            set {
                this.createdDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("currency")]
        public SearchColumnSelectField[] currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("department")]
        public SearchColumnSelectField[] department {
            get {
                return this.departmentField;
            }
            set {
                this.departmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("description")]
        public SearchColumnStringField[] description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("externalId")]
        public SearchColumnSelectField[] externalId {
            get {
                return this.externalIdField;
            }
            set {
                this.externalIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("internalId")]
        public SearchColumnSelectField[] internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("location")]
        public SearchColumnSelectField[] location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("modifiedDate")]
        public SearchColumnDateField[] modifiedDate {
            get {
                return this.modifiedDateField;
            }
            set {
                this.modifiedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("postingPeriod")]
        public SearchColumnStringField[] postingPeriod {
            get {
                return this.postingPeriodField;
            }
            set {
                this.postingPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("quantity")]
        public SearchColumnStringField[] quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("rate")]
        public SearchColumnStringField[] rate {
            get {
                return this.rateField;
            }
            set {
                this.rateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("rule")]
        public SearchColumnSelectField[] rule {
            get {
                return this.ruleField;
            }
            set {
                this.ruleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("runId")]
        public SearchColumnStringField[] runId {
            get {
                return this.runIdField;
            }
            set {
                this.runIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("salesOrder")]
        public SearchColumnStringField[] salesOrder {
            get {
                return this.salesOrderField;
            }
            set {
                this.salesOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("stage")]
        public SearchColumnEnumSelectField[] stage {
            get {
                return this.stageField;
            }
            set {
                this.stageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("subscriptionLine")]
        public SearchColumnSelectField[] subscriptionLine {
            get {
                return this.subscriptionLineField;
            }
            set {
                this.subscriptionLineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("use")]
        public SearchColumnEnumSelectField[] use {
            get {
                return this.useField;
            }
            set {
                this.useField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("customField", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public SearchColumnCustomField[] customFieldList {
            get {
                return this.customFieldListField;
            }
            set {
                this.customFieldListField = value;
            }
        }
    }
}