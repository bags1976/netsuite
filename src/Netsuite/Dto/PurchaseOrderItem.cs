using Netsuite.Enum;
using System;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [SerializableAttribute()]
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
            get => _itemField;
            set => _itemField = value;
        }

        /// <remarks/>
        public long Line {
            get => _lineField;
            set => _lineField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LineSpecified {
            get => _lineFieldSpecified;
            set => _lineFieldSpecified = value;
        }

        /// <remarks/>
        public decimal QuantityOnShipments {
            get => _quantityOnShipmentsField;
            set => _quantityOnShipmentsField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantityOnShipmentsSpecified {
            get => _quantityOnShipmentsFieldSpecified;
            set => _quantityOnShipmentsFieldSpecified = value;
        }

        /// <remarks/>
        public string VendorName {
            get => _vendorNameField;
            set => _vendorNameField = value;
        }

        /// <remarks/>
        public decimal QuantityReceived {
            get => _quantityReceivedField;
            set => _quantityReceivedField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantityReceivedSpecified {
            get => _quantityReceivedFieldSpecified;
            set => _quantityReceivedFieldSpecified = value;
        }

        /// <remarks/>
        public decimal QuantityBilled {
            get => _quantityBilledField;
            set => _quantityBilledField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantityBilledSpecified {
            get => _quantityBilledFieldSpecified;
            set => _quantityBilledFieldSpecified = value;
        }

        /// <remarks/>
        public decimal QuantityAvailable {
            get => _quantityAvailableField;
            set => _quantityAvailableField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantityAvailableSpecified {
            get => _quantityAvailableFieldSpecified;
            set => _quantityAvailableFieldSpecified = value;
        }

        /// <remarks/>
        public decimal QuantityOnHand {
            get => _quantityOnHandField;
            set => _quantityOnHandField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantityOnHandSpecified {
            get => _quantityOnHandFieldSpecified;
            set => _quantityOnHandFieldSpecified = value;
        }

        /// <remarks/>
        public RecordRef TaxCode {
            get => _taxCodeField;
            set => _taxCodeField = value;
        }

        /// <remarks/>
        public decimal TaxRate1 {
            get => _taxRate1Field;
            set => _taxRate1Field = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxRate1Specified {
            get => _taxRate1FieldSpecified;
            set => _taxRate1FieldSpecified = value;
        }

        /// <remarks/>
        public decimal TaxRate2 {
            get => _taxRate2Field;
            set => _taxRate2Field = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxRate2Specified {
            get => _taxRate2FieldSpecified;
            set => _taxRate2FieldSpecified = value;
        }

        /// <remarks/>
        public decimal Quantity {
            get => _quantityField;
            set => _quantityField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantitySpecified {
            get => _quantityFieldSpecified;
            set => _quantityFieldSpecified = value;
        }

        /// <remarks/>
        public decimal Tax1Amt {
            get => _tax1AmtField;
            set => _tax1AmtField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Tax1AmtSpecified {
            get => _tax1AmtFieldSpecified;
            set => _tax1AmtFieldSpecified = value;
        }

        /// <remarks/>
        public decimal GrossAmt {
            get => _grossAmtField;
            set => _grossAmtField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GrossAmtSpecified {
            get => _grossAmtFieldSpecified;
            set => _grossAmtFieldSpecified = value;
        }

        /// <remarks/>
        public RecordRef Units {
            get => _unitsField;
            set => _unitsField = value;
        }

        /// <remarks/>
        public InventoryDetail InventoryDetail {
            get => _inventoryDetailField;
            set => _inventoryDetailField = value;
        }

        /// <remarks/>
        public string SerialNumbers {
            get => _serialNumbersField;
            set => _serialNumbersField = value;
        }

        /// <remarks/>
        public string Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }

        /// <remarks/>
        public RecordRef PurchaseContract {
            get => _purchaseContractField;
            set => _purchaseContractField = value;
        }

        /// <remarks/>
        public string Rate {
            get => _rateField;
            set => _rateField = value;
        }

        /// <remarks/>
        public decimal Amount {
            get => _amountField;
            set => _amountField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AmountSpecified {
            get => _amountFieldSpecified;
            set => _amountFieldSpecified = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("customField", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public CustomFieldRef[] Options {
            get => _optionsField;
            set => _optionsField = value;
        }

        /// <remarks/>
        public decimal TaxAmount {
            get => _taxAmountField;
            set => _taxAmountField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxAmountSpecified {
            get => _taxAmountFieldSpecified;
            set => _taxAmountFieldSpecified = value;
        }

        /// <remarks/>
        public RecordRef Department {
            get => _departmentField;
            set => _departmentField = value;
        }

        /// <remarks/>
        public RecordRef Class {
            get => _classField;
            set => _classField = value;
        }

        /// <remarks/>
        public RecordRef Location {
            get => _locationField;
            set => _locationField = value;
        }

        /// <remarks/>
        public RecordRef LandedCostCategory {
            get => _landedCostCategoryField;
            set => _landedCostCategoryField = value;
        }

        /// <remarks/>
        public RecordRef Customer {
            get => _customerField;
            set => _customerField = value;
        }

        /// <remarks/>
        public bool IsBillable {
            get => _isBillableField;
            set => _isBillableField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsBillableSpecified {
            get => _isBillableFieldSpecified;
            set => _isBillableFieldSpecified = value;
        }

        /// <remarks/>
        public TransactionBillVarianceStatus BillVarianceStatus {
            get => _billVarianceStatusField;
            set => _billVarianceStatusField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BillVarianceStatusSpecified {
            get => _billVarianceStatusFieldSpecified;
            set => _billVarianceStatusFieldSpecified = value;
        }

        /// <remarks/>
        public bool MatchBillToReceipt {
            get => _matchBillToReceiptField;
            set => _matchBillToReceiptField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MatchBillToReceiptSpecified {
            get => _matchBillToReceiptFieldSpecified;
            set => _matchBillToReceiptFieldSpecified = value;
        }

        /// <remarks/>
        public DateTime? ExpectedReceiptDate { get; set; }

        /// <remarks/>
        public bool IsClosed {
            get => _isClosedField;
            set => _isClosedField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsClosedSpecified {
            get => _isClosedFieldSpecified;
            set => _isClosedFieldSpecified = value;
        }

        /// <remarks/>
        public string TaxDetailsReference {
            get => _taxDetailsReferenceField;
            set => _taxDetailsReferenceField = value;
        }

        /// <remarks/>
        public RecordRef CreatedFrom {
            get => _createdFromField;
            set => _createdFromField = value;
        }

    }
}