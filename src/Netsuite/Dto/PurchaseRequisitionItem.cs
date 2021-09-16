namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:purchases_2021_1.transactions.webservices.netsuite.com")]
    public partial class PurchaseRequisitionItem {

        private long lineField;

        private bool lineFieldSpecified;

        private RecordRef itemField;

        private string vendorNameField;

        private RecordRef poVendorField;

        private double quantityField;

        private bool quantityFieldSpecified;

        private RecordRef unitsField;

        private string serialNumbersField;

        private InventoryDetail inventoryDetailField;

        private string descriptionField;

        private double estimatedRateField;

        private bool estimatedRateFieldSpecified;

        private double estimatedAmountField;

        private bool estimatedAmountFieldSpecified;

        private string rateField;

        private double amountField;

        private bool amountFieldSpecified;

        private RecordRef taxCodeField;

        private double taxRate1Field;

        private bool taxRate1FieldSpecified;

        private double taxRate2Field;

        private bool taxRate2FieldSpecified;

        private double grossAmtField;

        private bool grossAmtFieldSpecified;

        private CustomFieldRef[] optionsField;

        private RecordRef departmentField;

        private RecordRef classField;

        private RecordRef customerField;

        private bool isBillableField;

        private bool isBillableFieldSpecified;

        private RecordRef[] linkedOrderListField;

        private string linkedOrderStatusField;

        private System.DateTime expectedReceiptDateField;

        private bool expectedReceiptDateFieldSpecified;

        private bool isClosedField;

        private bool isClosedFieldSpecified;

        private bool expandItemGroupField;

        private bool expandItemGroupFieldSpecified;

        /// <remarks/>
        public long line {
            get {
                return this.lineField;
            }
            set {
                this.lineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lineSpecified {
            get {
                return this.lineFieldSpecified;
            }
            set {
                this.lineFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }

        /// <remarks/>
        public string vendorName {
            get {
                return this.vendorNameField;
            }
            set {
                this.vendorNameField = value;
            }
        }

        /// <remarks/>
        public RecordRef poVendor {
            get {
                return this.poVendorField;
            }
            set {
                this.poVendorField = value;
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
        public RecordRef units {
            get {
                return this.unitsField;
            }
            set {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        public string serialNumbers {
            get {
                return this.serialNumbersField;
            }
            set {
                this.serialNumbersField = value;
            }
        }

        /// <remarks/>
        public InventoryDetail inventoryDetail {
            get {
                return this.inventoryDetailField;
            }
            set {
                this.inventoryDetailField = value;
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
        public double estimatedRate {
            get {
                return this.estimatedRateField;
            }
            set {
                this.estimatedRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool estimatedRateSpecified {
            get {
                return this.estimatedRateFieldSpecified;
            }
            set {
                this.estimatedRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double estimatedAmount {
            get {
                return this.estimatedAmountField;
            }
            set {
                this.estimatedAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool estimatedAmountSpecified {
            get {
                return this.estimatedAmountFieldSpecified;
            }
            set {
                this.estimatedAmountFieldSpecified = value;
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
        public RecordRef taxCode {
            get {
                return this.taxCodeField;
            }
            set {
                this.taxCodeField = value;
            }
        }

        /// <remarks/>
        public double taxRate1 {
            get {
                return this.taxRate1Field;
            }
            set {
                this.taxRate1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxRate1Specified {
            get {
                return this.taxRate1FieldSpecified;
            }
            set {
                this.taxRate1FieldSpecified = value;
            }
        }

        /// <remarks/>
        public double taxRate2 {
            get {
                return this.taxRate2Field;
            }
            set {
                this.taxRate2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxRate2Specified {
            get {
                return this.taxRate2FieldSpecified;
            }
            set {
                this.taxRate2FieldSpecified = value;
            }
        }

        /// <remarks/>
        public double grossAmt {
            get {
                return this.grossAmtField;
            }
            set {
                this.grossAmtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool grossAmtSpecified {
            get {
                return this.grossAmtFieldSpecified;
            }
            set {
                this.grossAmtFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("customField", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public CustomFieldRef[] options {
            get {
                return this.optionsField;
            }
            set {
                this.optionsField = value;
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
        public RecordRef customer {
            get {
                return this.customerField;
            }
            set {
                this.customerField = value;
            }
        }

        /// <remarks/>
        public bool isBillable {
            get {
                return this.isBillableField;
            }
            set {
                this.isBillableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isBillableSpecified {
            get {
                return this.isBillableFieldSpecified;
            }
            set {
                this.isBillableFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recordRef", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public RecordRef[] linkedOrderList {
            get {
                return this.linkedOrderListField;
            }
            set {
                this.linkedOrderListField = value;
            }
        }

        /// <remarks/>
        public string linkedOrderStatus {
            get {
                return this.linkedOrderStatusField;
            }
            set {
                this.linkedOrderStatusField = value;
            }
        }

        /// <remarks/>
        public System.DateTime expectedReceiptDate {
            get {
                return this.expectedReceiptDateField;
            }
            set {
                this.expectedReceiptDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expectedReceiptDateSpecified {
            get {
                return this.expectedReceiptDateFieldSpecified;
            }
            set {
                this.expectedReceiptDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isClosed {
            get {
                return this.isClosedField;
            }
            set {
                this.isClosedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isClosedSpecified {
            get {
                return this.isClosedFieldSpecified;
            }
            set {
                this.isClosedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool expandItemGroup {
            get {
                return this.expandItemGroupField;
            }
            set {
                this.expandItemGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expandItemGroupSpecified {
            get {
                return this.expandItemGroupFieldSpecified;
            }
            set {
                this.expandItemGroupFieldSpecified = value;
            }
        }
    }
}