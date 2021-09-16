namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:purchases_2021_1.transactions.webservices.netsuite.com")]
    public partial class PurchaseOrderItem {

        private RecordRef itemField;

        private long lineField;

        private bool lineFieldSpecified;

        private double quantityOnShipmentsField;

        private bool quantityOnShipmentsFieldSpecified;

        private string vendorNameField;

        private double quantityReceivedField;

        private bool quantityReceivedFieldSpecified;

        private double quantityBilledField;

        private bool quantityBilledFieldSpecified;

        private double quantityAvailableField;

        private bool quantityAvailableFieldSpecified;

        private double quantityOnHandField;

        private bool quantityOnHandFieldSpecified;

        private RecordRef taxCodeField;

        private double taxRate1Field;

        private bool taxRate1FieldSpecified;

        private double taxRate2Field;

        private bool taxRate2FieldSpecified;

        private double quantityField;

        private bool quantityFieldSpecified;

        private double tax1AmtField;

        private bool tax1AmtFieldSpecified;

        private double grossAmtField;

        private bool grossAmtFieldSpecified;

        private RecordRef unitsField;

        private InventoryDetail inventoryDetailField;

        private string serialNumbersField;

        private string descriptionField;

        private RecordRef purchaseContractField;

        private string rateField;

        private double amountField;

        private bool amountFieldSpecified;

        private CustomFieldRef[] optionsField;

        private double taxAmountField;

        private bool taxAmountFieldSpecified;

        private RecordRef departmentField;

        private RecordRef classField;

        private RecordRef locationField;

        private RecordRef landedCostCategoryField;

        private RecordRef customerField;

        private bool isBillableField;

        private bool isBillableFieldSpecified;

        private TransactionBillVarianceStatus billVarianceStatusField;

        private bool billVarianceStatusFieldSpecified;

        private bool matchBillToReceiptField;

        private bool matchBillToReceiptFieldSpecified;

        private System.DateTime expectedReceiptDateField;

        private bool expectedReceiptDateFieldSpecified;

        private bool isClosedField;

        private bool isClosedFieldSpecified;

        private string taxDetailsReferenceField;

        private RecordRef createdFromField;

        private RecordRef[] linkedOrderListField;

        private CustomFieldRef[] customFieldListField;

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
        public double quantityOnShipments {
            get {
                return this.quantityOnShipmentsField;
            }
            set {
                this.quantityOnShipmentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantityOnShipmentsSpecified {
            get {
                return this.quantityOnShipmentsFieldSpecified;
            }
            set {
                this.quantityOnShipmentsFieldSpecified = value;
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
        public double quantityReceived {
            get {
                return this.quantityReceivedField;
            }
            set {
                this.quantityReceivedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantityReceivedSpecified {
            get {
                return this.quantityReceivedFieldSpecified;
            }
            set {
                this.quantityReceivedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double quantityBilled {
            get {
                return this.quantityBilledField;
            }
            set {
                this.quantityBilledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantityBilledSpecified {
            get {
                return this.quantityBilledFieldSpecified;
            }
            set {
                this.quantityBilledFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double quantityAvailable {
            get {
                return this.quantityAvailableField;
            }
            set {
                this.quantityAvailableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantityAvailableSpecified {
            get {
                return this.quantityAvailableFieldSpecified;
            }
            set {
                this.quantityAvailableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double quantityOnHand {
            get {
                return this.quantityOnHandField;
            }
            set {
                this.quantityOnHandField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantityOnHandSpecified {
            get {
                return this.quantityOnHandFieldSpecified;
            }
            set {
                this.quantityOnHandFieldSpecified = value;
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
        public double tax1Amt {
            get {
                return this.tax1AmtField;
            }
            set {
                this.tax1AmtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tax1AmtSpecified {
            get {
                return this.tax1AmtFieldSpecified;
            }
            set {
                this.tax1AmtFieldSpecified = value;
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
        public RecordRef units {
            get {
                return this.unitsField;
            }
            set {
                this.unitsField = value;
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
        public string serialNumbers {
            get {
                return this.serialNumbersField;
            }
            set {
                this.serialNumbersField = value;
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
        public RecordRef purchaseContract {
            get {
                return this.purchaseContractField;
            }
            set {
                this.purchaseContractField = value;
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
        public double taxAmount {
            get {
                return this.taxAmountField;
            }
            set {
                this.taxAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxAmountSpecified {
            get {
                return this.taxAmountFieldSpecified;
            }
            set {
                this.taxAmountFieldSpecified = value;
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
        public RecordRef landedCostCategory {
            get {
                return this.landedCostCategoryField;
            }
            set {
                this.landedCostCategoryField = value;
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
        public TransactionBillVarianceStatus billVarianceStatus {
            get {
                return this.billVarianceStatusField;
            }
            set {
                this.billVarianceStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool billVarianceStatusSpecified {
            get {
                return this.billVarianceStatusFieldSpecified;
            }
            set {
                this.billVarianceStatusFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool matchBillToReceipt {
            get {
                return this.matchBillToReceiptField;
            }
            set {
                this.matchBillToReceiptField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool matchBillToReceiptSpecified {
            get {
                return this.matchBillToReceiptFieldSpecified;
            }
            set {
                this.matchBillToReceiptFieldSpecified = value;
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
        public string taxDetailsReference {
            get {
                return this.taxDetailsReferenceField;
            }
            set {
                this.taxDetailsReferenceField = value;
            }
        }

        /// <remarks/>
        public RecordRef createdFrom {
            get {
                return this.createdFromField;
            }
            set {
                this.createdFromField = value;
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
        [System.Xml.Serialization.XmlArrayItemAttribute("customField", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public CustomFieldRef[] customFieldList {
            get {
                return this.customFieldListField;
            }
            set {
                this.customFieldListField = value;
            }
        }
    }
}