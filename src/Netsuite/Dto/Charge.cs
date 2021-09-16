namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:customers_2021_1.transactions.webservices.netsuite.com")]
    public partial class Charge : Record {

        private RecordRef customFormField;

        private RecordRef salesOrderField;

        private RecordRef billToField;

        private RecordRef billingAccountField;

        private ChargeStage stageField;

        private bool stageFieldSpecified;

        private System.DateTime chargeDateField;

        private bool chargeDateFieldSpecified;

        private ChargeUse useField;

        private bool useFieldSpecified;

        private RecordRef chargeTypeField;

        private RecordRef projectTaskField;

        private string descriptionField;

        private System.DateTime createdDateField;

        private bool createdDateFieldSpecified;

        private RecordRef timeRecordField;

        private string rateField;

        private double quantityField;

        private bool quantityFieldSpecified;

        private double amountField;

        private bool amountFieldSpecified;

        private RecordRef billingItemField;

        private RecordRef currencyField;

        private RecordRef transactionField;

        private RecordRef transactionLineField;

        private RecordRef classField;

        private RecordRef departmentField;

        private RecordRef locationField;

        private RecordRef salesOrderLineField;

        private RecordRef subscriptionLineField;

        private RecordRef invoiceField;

        private RecordRef invoiceLineField;

        private RecordRef ruleField;

        private string runIdField;

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
        public RecordRef salesOrder {
            get {
                return this.salesOrderField;
            }
            set {
                this.salesOrderField = value;
            }
        }

        /// <remarks/>
        public RecordRef billTo {
            get {
                return this.billToField;
            }
            set {
                this.billToField = value;
            }
        }

        /// <remarks/>
        public RecordRef billingAccount {
            get {
                return this.billingAccountField;
            }
            set {
                this.billingAccountField = value;
            }
        }

        /// <remarks/>
        public ChargeStage stage {
            get {
                return this.stageField;
            }
            set {
                this.stageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool stageSpecified {
            get {
                return this.stageFieldSpecified;
            }
            set {
                this.stageFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime chargeDate {
            get {
                return this.chargeDateField;
            }
            set {
                this.chargeDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool chargeDateSpecified {
            get {
                return this.chargeDateFieldSpecified;
            }
            set {
                this.chargeDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ChargeUse use {
            get {
                return this.useField;
            }
            set {
                this.useField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool useSpecified {
            get {
                return this.useFieldSpecified;
            }
            set {
                this.useFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef chargeType {
            get {
                return this.chargeTypeField;
            }
            set {
                this.chargeTypeField = value;
            }
        }

        /// <remarks/>
        public RecordRef projectTask {
            get {
                return this.projectTaskField;
            }
            set {
                this.projectTaskField = value;
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
        public RecordRef timeRecord {
            get {
                return this.timeRecordField;
            }
            set {
                this.timeRecordField = value;
            }
        }

        /// <remarks/>
        public string rate {
            get {
                return this.rateField;
            }
            set {
                this.rateField = value;
            }
        }

        /// <remarks/>
        public double quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantitySpecified {
            get {
                return this.quantityFieldSpecified;
            }
            set {
                this.quantityFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool amountSpecified {
            get {
                return this.amountFieldSpecified;
            }
            set {
                this.amountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef billingItem {
            get {
                return this.billingItemField;
            }
            set {
                this.billingItemField = value;
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
        public RecordRef transaction {
            get {
                return this.transactionField;
            }
            set {
                this.transactionField = value;
            }
        }

        /// <remarks/>
        public RecordRef transactionLine {
            get {
                return this.transactionLineField;
            }
            set {
                this.transactionLineField = value;
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
        public RecordRef department {
            get {
                return this.departmentField;
            }
            set {
                this.departmentField = value;
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
        public RecordRef salesOrderLine {
            get {
                return this.salesOrderLineField;
            }
            set {
                this.salesOrderLineField = value;
            }
        }

        /// <remarks/>
        public RecordRef subscriptionLine {
            get {
                return this.subscriptionLineField;
            }
            set {
                this.subscriptionLineField = value;
            }
        }

        /// <remarks/>
        public RecordRef invoice {
            get {
                return this.invoiceField;
            }
            set {
                this.invoiceField = value;
            }
        }

        /// <remarks/>
        public RecordRef invoiceLine {
            get {
                return this.invoiceLineField;
            }
            set {
                this.invoiceLineField = value;
            }
        }

        /// <remarks/>
        public RecordRef rule {
            get {
                return this.ruleField;
            }
            set {
                this.ruleField = value;
            }
        }

        /// <remarks/>
        public string runId {
            get {
                return this.runIdField;
            }
            set {
                this.runIdField = value;
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