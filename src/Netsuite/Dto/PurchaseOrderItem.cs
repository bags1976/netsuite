using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:purchases_2021_1.transactions.webservices.netsuite.com")]
    public partial class PurchaseOrderItem {

        private RecordRef _itemField;

        private long _lineField;

        private bool _lineFieldSpecified;

        private decimal _quantityOnShipmentsField;

        private bool _quantityOnShipmentsFieldSpecified;

        private string _vendorNameField;

        private decimal _quantityReceivedField;

        private bool _quantityReceivedFieldSpecified;

        private decimal _quantityBilledField;

        private bool _quantityBilledFieldSpecified;

        private decimal _quantityAvailableField;

        private bool _quantityAvailableFieldSpecified;

        private decimal _quantityOnHandField;

        private bool _quantityOnHandFieldSpecified;

        private RecordRef _taxCodeField;

        private decimal _taxRate1Field;

        private bool _taxRate1FieldSpecified;

        private decimal _taxRate2Field;

        private bool _taxRate2FieldSpecified;

        private decimal _quantityField;

        private bool _quantityFieldSpecified;

        private decimal _tax1AmtField;

        private bool _tax1AmtFieldSpecified;

        private decimal _grossAmtField;

        private bool _grossAmtFieldSpecified;

        private RecordRef _unitsField;

        private InventoryDetail _inventoryDetailField;

        private string _serialNumbersField;

        private string _descriptionField;

        private RecordRef _purchaseContractField;

        private string _rateField;

        private decimal _amountField;

        private bool _amountFieldSpecified;

        private CustomFieldRef[] _optionsField;

        private decimal _taxAmountField;

        private bool _taxAmountFieldSpecified;

        private RecordRef _departmentField;

        private RecordRef _classField;

        private RecordRef _locationField;

        private RecordRef _landedCostCategoryField;

        private RecordRef _customerField;

        private bool _isBillableField;

        private bool _isBillableFieldSpecified;

        private TransactionBillVarianceStatus _billVarianceStatusField;

        private bool _billVarianceStatusFieldSpecified;

        private bool _matchBillToReceiptField;

        private bool _matchBillToReceiptFieldSpecified;

        private System.DateTime _expectedReceiptDateField;

        private bool _expectedReceiptDateFieldSpecified;

        private bool _isClosedField;

        private bool _isClosedFieldSpecified;

        private string _taxDetailsReferenceField;

        private RecordRef _createdFromField;

        public string Subsidiary { get; set; }
        public string NetAmount { get; set; }
        public bool Fulfillable { get; set; }
        public string Id { get; set; }

        /// <remarks/>
        public RecordRef Item {
            get {
                return this._itemField;
            }
            set {
                this._itemField = value;
            }
        }

        /// <remarks/>
        public long Line {
            get {
                return this._lineField;
            }
            set {
                this._lineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LineSpecified {
            get {
                return this._lineFieldSpecified;
            }
            set {
                this._lineFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal QuantityOnShipments {
            get {
                return this._quantityOnShipmentsField;
            }
            set {
                this._quantityOnShipmentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantityOnShipmentsSpecified {
            get {
                return this._quantityOnShipmentsFieldSpecified;
            }
            set {
                this._quantityOnShipmentsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string VendorName {
            get {
                return this._vendorNameField;
            }
            set {
                this._vendorNameField = value;
            }
        }

        /// <remarks/>
        public decimal QuantityReceived {
            get {
                return this._quantityReceivedField;
            }
            set {
                this._quantityReceivedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantityReceivedSpecified {
            get {
                return this._quantityReceivedFieldSpecified;
            }
            set {
                this._quantityReceivedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal QuantityBilled {
            get {
                return this._quantityBilledField;
            }
            set {
                this._quantityBilledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantityBilledSpecified {
            get {
                return this._quantityBilledFieldSpecified;
            }
            set {
                this._quantityBilledFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal QuantityAvailable {
            get {
                return this._quantityAvailableField;
            }
            set {
                this._quantityAvailableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantityAvailableSpecified {
            get {
                return this._quantityAvailableFieldSpecified;
            }
            set {
                this._quantityAvailableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal QuantityOnHand {
            get {
                return this._quantityOnHandField;
            }
            set {
                this._quantityOnHandField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantityOnHandSpecified {
            get {
                return this._quantityOnHandFieldSpecified;
            }
            set {
                this._quantityOnHandFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef TaxCode {
            get {
                return this._taxCodeField;
            }
            set {
                this._taxCodeField = value;
            }
        }

        /// <remarks/>
        public decimal TaxRate1 {
            get {
                return this._taxRate1Field;
            }
            set {
                this._taxRate1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxRate1Specified {
            get {
                return this._taxRate1FieldSpecified;
            }
            set {
                this._taxRate1FieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal TaxRate2 {
            get {
                return this._taxRate2Field;
            }
            set {
                this._taxRate2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxRate2Specified {
            get {
                return this._taxRate2FieldSpecified;
            }
            set {
                this._taxRate2FieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal Quantity {
            get {
                return this._quantityField;
            }
            set {
                this._quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantitySpecified {
            get {
                return this._quantityFieldSpecified;
            }
            set {
                this._quantityFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal Tax1Amt {
            get {
                return this._tax1AmtField;
            }
            set {
                this._tax1AmtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Tax1AmtSpecified {
            get {
                return this._tax1AmtFieldSpecified;
            }
            set {
                this._tax1AmtFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal GrossAmt {
            get {
                return this._grossAmtField;
            }
            set {
                this._grossAmtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GrossAmtSpecified {
            get {
                return this._grossAmtFieldSpecified;
            }
            set {
                this._grossAmtFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef Units {
            get {
                return this._unitsField;
            }
            set {
                this._unitsField = value;
            }
        }

        /// <remarks/>
        public InventoryDetail InventoryDetail {
            get {
                return this._inventoryDetailField;
            }
            set {
                this._inventoryDetailField = value;
            }
        }

        /// <remarks/>
        public string SerialNumbers {
            get {
                return this._serialNumbersField;
            }
            set {
                this._serialNumbersField = value;
            }
        }

        /// <remarks/>
        public string Description {
            get {
                return this._descriptionField;
            }
            set {
                this._descriptionField = value;
            }
        }

        /// <remarks/>
        public RecordRef PurchaseContract {
            get {
                return this._purchaseContractField;
            }
            set {
                this._purchaseContractField = value;
            }
        }

        /// <remarks/>
        public string Rate {
            get {
                return this._rateField;
            }
            set {
                this._rateField = value;
            }
        }

        /// <remarks/>
        public decimal Amount {
            get {
                return this._amountField;
            }
            set {
                this._amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AmountSpecified {
            get {
                return this._amountFieldSpecified;
            }
            set {
                this._amountFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("customField", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public CustomFieldRef[] Options {
            get {
                return this._optionsField;
            }
            set {
                this._optionsField = value;
            }
        }

        /// <remarks/>
        public decimal TaxAmount {
            get {
                return this._taxAmountField;
            }
            set {
                this._taxAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxAmountSpecified {
            get {
                return this._taxAmountFieldSpecified;
            }
            set {
                this._taxAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef Department {
            get {
                return this._departmentField;
            }
            set {
                this._departmentField = value;
            }
        }

        /// <remarks/>
        public RecordRef Class {
            get {
                return this._classField;
            }
            set {
                this._classField = value;
            }
        }

        /// <remarks/>
        public RecordRef Location {
            get {
                return this._locationField;
            }
            set {
                this._locationField = value;
            }
        }

        /// <remarks/>
        public RecordRef LandedCostCategory {
            get {
                return this._landedCostCategoryField;
            }
            set {
                this._landedCostCategoryField = value;
            }
        }

        /// <remarks/>
        public RecordRef Customer {
            get {
                return this._customerField;
            }
            set {
                this._customerField = value;
            }
        }

        /// <remarks/>
        public bool IsBillable {
            get {
                return this._isBillableField;
            }
            set {
                this._isBillableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsBillableSpecified {
            get {
                return this._isBillableFieldSpecified;
            }
            set {
                this._isBillableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public TransactionBillVarianceStatus BillVarianceStatus {
            get {
                return this._billVarianceStatusField;
            }
            set {
                this._billVarianceStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BillVarianceStatusSpecified {
            get {
                return this._billVarianceStatusFieldSpecified;
            }
            set {
                this._billVarianceStatusFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool MatchBillToReceipt {
            get {
                return this._matchBillToReceiptField;
            }
            set {
                this._matchBillToReceiptField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MatchBillToReceiptSpecified {
            get {
                return this._matchBillToReceiptFieldSpecified;
            }
            set {
                this._matchBillToReceiptFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime ExpectedReceiptDate {
            get {
                return this._expectedReceiptDateField;
            }
            set {
                this._expectedReceiptDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExpectedReceiptDateSpecified {
            get {
                return this._expectedReceiptDateFieldSpecified;
            }
            set {
                this._expectedReceiptDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool IsClosed {
            get {
                return this._isClosedField;
            }
            set {
                this._isClosedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsClosedSpecified {
            get {
                return this._isClosedFieldSpecified;
            }
            set {
                this._isClosedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string TaxDetailsReference {
            get {
                return this._taxDetailsReferenceField;
            }
            set {
                this._taxDetailsReferenceField = value;
            }
        }

        /// <remarks/>
        public RecordRef CreatedFrom {
            get {
                return this._createdFromField;
            }
            set {
                this._createdFromField = value;
            }
        }

    }
}