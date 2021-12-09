using System.Xml.Serialization;
using Netsuite.Enum;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace Netsuite.Dto
{
    /// <remarks/>
    [GeneratedCode("wsdl", "4.8.3928.0")]
    [SerializableAttribute()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlTypeAttribute(Namespace = "urn:sales_2021_1.transactions.webservices.netsuite.com")]
    public partial class SalesOrderItem
    {
        #region private autogenerated fields

        private RecordRef _jobField;

        private RecordRef _subscriptionField;

        private RecordRef _itemField;

        private decimal _quantityAvailableField;

        private bool _quantityAvailableFieldSpecified;

        private bool _expandItemGroupField;

        private bool _expandItemGroupFieldSpecified;

        private long _lineUniqueKeyField;

        private bool _lineUniqueKeyFieldSpecified;

        private decimal _quantityOnHandField;

        private bool _quantityOnHandFieldSpecified;

        private decimal _quantityField;

        private bool _quantityFieldSpecified;

        private InventoryDetail _inventoryDetailField;

        private string _descriptionField;

        private RecordRef _priceField;

        private decimal _rateField;

        private string _serialNumbersField;

        private decimal _amountField;

        private bool _isTaxableField;

        private bool _isTaxableFieldSpecified;

        private SalesOrderItemCommitInventory _commitInventoryField;

        private bool _commitInventoryFieldSpecified;

        private decimal _orderPriorityField;

        private bool _orderPriorityFieldSpecified;

        private string _licenseCodeField;

        private CustomFieldRef[] _optionsField;

        private RecordRef _departmentField;

        private RecordRef _classField;

        private RecordRef _locationField;

        private SalesOrderItemCreatePo _createPoField;

        private bool _createPoFieldSpecified;

        private RecordRef _createdPoField;

        private decimal _altSalesAmtField;

        private bool _altSalesAmtFieldSpecified;

        private bool _createWoField;

        private bool _createWoFieldSpecified;

        private RecordRef _poVendorField;

        private string _poCurrencyField;

        private decimal _poRateField;

        private bool _poRateFieldSpecified;

        private RecordRef _revRecScheduleField;

        private DateTime _revRecStartDateField;

        private bool _revRecStartDateFieldSpecified;

        private long _revRecTermInMonthsField;

        private bool _revRecTermInMonthsFieldSpecified;

        private DateTime _revRecEndDateField;

        private bool _revRecEndDateFieldSpecified;

        private bool _deferRevRecField;

        private bool _deferRevRecFieldSpecified;

        private bool _isClosedField;

        private bool _isClosedFieldSpecified;

        private SalesOrderItemFulfillmentChoice _itemFulfillmentChoiceField;

        private bool _itemFulfillmentChoiceFieldSpecified;

        private RecordRef _catchUpPeriodField;

        private RecordRef _billingScheduleField;

        private bool _fromJobField;

        private bool _fromJobFieldSpecified;

        private decimal _grossAmtField;

        private bool _grossAmtFieldSpecified;

        private decimal _taxAmountField;

        private bool _taxAmountFieldSpecified;

        private bool _excludeFromRateRequestField;

        private bool _excludeFromRateRequestFieldSpecified;

        private bool _isEstimateField;

        private bool _isEstimateFieldSpecified;

        private RecordRef _inventoryLocationField;

        private RecordRef _inventorySubsidiaryField;

        private int _lineField;

        private bool _lineFieldSpecified;

        private decimal _percentCompleteField;

        private bool _percentCompleteFieldSpecified;

        private ItemCostEstimateType _costEstimateTypeField;

        private bool _costEstimateTypeFieldSpecified;

        private decimal _costEstimateField;

        private bool _costEstimateFieldSpecified;

        private decimal _quantityBackOrderedField;

        private bool _quantityBackOrderedFieldSpecified;

        private decimal _quantityBilledField;

        private bool _quantityBilledFieldSpecified;

        private decimal _quantityCommittedField;

        private bool _quantityCommittedFieldSpecified;

        private decimal _quantityFulfilledField;

        private bool _quantityFulfilledFieldSpecified;

        private decimal _quantityPackedField;

        private bool _quantityPackedFieldSpecified;

        private decimal _quantityPickedField;

        private bool _quantityPickedFieldSpecified;

        private decimal _tax1AmtField;

        private bool _tax1AmtFieldSpecified;

        private RecordRef _taxCodeField;

        private decimal _taxRate1Field;

        private bool _taxRate1FieldSpecified;

        private decimal _taxRate2Field;

        private bool _taxRate2FieldSpecified;

        private string _giftCertFromField;

        private string _giftCertRecipientNameField;

        private string _giftCertRecipientEmailField;

        private string _giftCertMessageField;

        private string _giftCertNumberField;

        private long _shipGroupField;

        private bool _shipGroupFieldSpecified;

        private bool _itemIsFulfilledField;

        private bool _itemIsFulfilledFieldSpecified;

        private RecordRef _shipAddressField;

        private RecordRef _shipMethodField;

        private VsoeSopGroup _vsoeSopGroupField;

        private bool _vsoeSopGroupFieldSpecified;

        private bool _vsoeIsEstimateField;

        private bool _vsoeIsEstimateFieldSpecified;

        private decimal _vsoePriceField;

        private bool _vsoePriceFieldSpecified;

        private decimal _vsoeAmountField;

        private bool _vsoeAmountFieldSpecified;

        private decimal _vsoeAllocationField;

        private bool _vsoeAllocationFieldSpecified;

        private VsoeDeferral _vsoeDeferralField;

        private bool _vsoeDeferralFieldSpecified;

        private VsoePermitDiscount _vsoePermitDiscountField;

        private bool _vsoePermitDiscountFieldSpecified;

        private bool _vsoeDeliveredField;

        private bool _vsoeDeliveredFieldSpecified;

        private DateTime _expectedShipDateField;

        private bool _expectedShipDateFieldSpecified;

        private bool _noAutoAssignLocationField;

        private bool _noAutoAssignLocationFieldSpecified;

        private bool _locationAutoAssignedField;

        private bool _locationAutoAssignedFieldSpecified;

        private string _taxDetailsReferenceField;

        private RecordRef _chargeTypeField;

        private RecordRef _orderAllocationStrategyField;

        private DateTime _requestedDateField;

        private bool _requestedDateFieldSpecified;

        private CustomFieldRef[] _customFieldListField;

        #endregion

        public bool HasFulfillableItems { get; set; }
        public bool TaxLine { get; set; }
        public bool BinItem { get; set; }
        public bool LocationUsesBins { get; set; }
        public bool IsPosting { get; set; }
        public bool ItemPicked { get; set; }
        public bool IsSerial { get; set; }
        public bool IsOpen { get; set; }
        public bool Fulfillable { get; set; }
        public bool ItemPacked { get; set; }
        public decimal OnOrder { get; set; }
        public decimal OrigQuantity { get; set; }
        public decimal UnitConversionRate { get; set; }
        public string WeightInLb { get; set; }
        public string Subsidiary { get; set; }
        public string Units { get; set; }
        public string Units_Display { get; set; }
        public string Item_Display { get; set; }
        public string Id { get; set; }

        //public

        #region public autogenerated fields

        /// <remarks/>
        public RecordRef Job
        {
            get => _jobField;
            set => _jobField = value;
        }

        /// <remarks/>
        public RecordRef Subscription
        {
            get => _subscriptionField;
            set => _subscriptionField = value;
        }

        /// <remarks/>
        public RecordRef Item
        {
            get => _itemField;
            set => _itemField = value;
        }

        /// <remarks/>
        public decimal QuantityAvailable
        {
            get => _quantityAvailableField;
            set => _quantityAvailableField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool QuantityAvailableSpecified
        {
            get => _quantityAvailableFieldSpecified;
            set => _quantityAvailableFieldSpecified = value;
        }

        /// <remarks/>
        public bool ExpandItemGroup
        {
            get => _expandItemGroupField;
            set => _expandItemGroupField = value;
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool ExpandItemGroupSpecified
        {
            get => _expandItemGroupFieldSpecified;
            set => _expandItemGroupFieldSpecified = value;
        }

        /// <remarks/>
        public long LineUniqueKey
        {
            get => _lineUniqueKeyField;
            set => _lineUniqueKeyField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool LineUniqueKeySpecified
        {
            get => _lineUniqueKeyFieldSpecified;
            set => _lineUniqueKeyFieldSpecified = value;
        }

        /// <remarks/>
        public decimal QuantityOnHand
        {
            get => _quantityOnHandField;
            set => _quantityOnHandField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool QuantityOnHandSpecified
        {
            get => _quantityOnHandFieldSpecified;
            set => _quantityOnHandFieldSpecified = value;
        }

        /// <remarks/>
        public decimal Quantity
        {
            get => _quantityField;
            set => _quantityField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool QuantitySpecified
        {
            get => _quantityFieldSpecified;
            set => _quantityFieldSpecified = value;
        }

        /// <remarks/>
        public InventoryDetail InventoryDetail
        {
            get => _inventoryDetailField;
            set => _inventoryDetailField = value;
        }

        /// <remarks/>
        public string Description
        {
            get => _descriptionField;
            set => _descriptionField = value;
        }

        /// <remarks/>
        public RecordRef Price
        {
            get => _priceField;
            set => _priceField = value;
        }

        /// <remarks/>
        public decimal Rate
        {
            get => _rateField;
            set => _rateField = value;
        }

        /// <remarks/>
        public string SerialNumbers
        {
            get => _serialNumbersField;
            set => _serialNumbersField = value;
        }

        /// <remarks/>
        public decimal Amount
        {
            get => _amountField;
            set => _amountField = value;
        }

        /// <remarks/>
        public bool IsTaxable
        {
            get => _isTaxableField;
            set => _isTaxableField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool IsTaxableSpecified
        {
            get => _isTaxableFieldSpecified;
            set => _isTaxableFieldSpecified = value;
        }

        /// <remarks/>
        public SalesOrderItemCommitInventory CommitInventory
        {
            get => _commitInventoryField;
            set => _commitInventoryField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool CommitInventorySpecified
        {
            get => _commitInventoryFieldSpecified;
            set => _commitInventoryFieldSpecified = value;
        }

        /// <remarks/>
        public decimal OrderPriority
        {
            get => _orderPriorityField;
            set => _orderPriorityField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool OrderPrioritySpecified
        {
            get => _orderPriorityFieldSpecified;
            set => _orderPriorityFieldSpecified = value;
        }

        /// <remarks/>
        public string LicenseCode
        {
            get => _licenseCodeField;
            set => _licenseCodeField = value;
        }

        /// <remarks/>
        [XmlArrayItemAttribute("customField", Namespace = "urn:core_2021_1.platform.webservices.netsuite.com", IsNullable = false)]
        public CustomFieldRef[] Options
        {
            get => _optionsField;
            set => _optionsField = value;
        }

        /// <remarks/>
        public RecordRef Department
        {
            get => _departmentField;
            set => _departmentField = value;
        }

        /// <remarks/>
        public RecordRef Class
        {
            get => _classField;
            set => _classField = value;
        }

        /// <remarks/>
        public RecordRef Location
        {
            get => _locationField;
            set => _locationField = value;
        }

        /// <remarks/>
        public SalesOrderItemCreatePo CreatePo
        {
            get => _createPoField;
            set => _createPoField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool CreatePoSpecified
        {
            get => _createPoFieldSpecified;
            set => _createPoFieldSpecified = value;
        }

        /// <remarks/>
        public RecordRef CreatedPo
        {
            get => _createdPoField;
            set => _createdPoField = value;
        }

        /// <remarks/>
        public decimal AltSalesAmt
        {
            get => _altSalesAmtField;
            set => _altSalesAmtField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool AltSalesAmtSpecified
        {
            get => _altSalesAmtFieldSpecified;
            set => _altSalesAmtFieldSpecified = value;
        }

        /// <remarks/>
        public bool CreateWo
        {
            get => _createWoField;
            set => _createWoField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool CreateWoSpecified
        {
            get => _createWoFieldSpecified;
            set => _createWoFieldSpecified = value;
        }

        /// <remarks/>
        public RecordRef PoVendor
        {
            get => _poVendorField;
            set => _poVendorField = value;
        }

        /// <remarks/>
        public string PoCurrency
        {
            get => _poCurrencyField;
            set => _poCurrencyField = value;
        }

        /// <remarks/>
        public decimal PoRate
        {
            get => _poRateField;
            set => _poRateField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool PoRateSpecified
        {
            get => _poRateFieldSpecified;
            set => _poRateFieldSpecified = value;
        }

        /// <remarks/>
        public RecordRef RevRecSchedule
        {
            get => _revRecScheduleField;
            set => _revRecScheduleField = value;
        }

        /// <remarks/>
        public DateTime RevRecStartDate
        {
            get => _revRecStartDateField;
            set => _revRecStartDateField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool RevRecStartDateSpecified
        {
            get => _revRecStartDateFieldSpecified;
            set => _revRecStartDateFieldSpecified = value;
        }

        /// <remarks/>
        public long RevRecTermInMonths
        {
            get => _revRecTermInMonthsField;
            set => _revRecTermInMonthsField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool RevRecTermInMonthsSpecified
        {
            get => _revRecTermInMonthsFieldSpecified;
            set => _revRecTermInMonthsFieldSpecified = value;
        }

        /// <remarks/>
        public DateTime RevRecEndDate
        {
            get => _revRecEndDateField;
            set => _revRecEndDateField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool RevRecEndDateSpecified
        {
            get => _revRecEndDateFieldSpecified;
            set => _revRecEndDateFieldSpecified = value;
        }

        /// <remarks/>
        public bool DeferRevRec
        {
            get => _deferRevRecField;
            set => _deferRevRecField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool DeferRevRecSpecified
        {
            get => _deferRevRecFieldSpecified;
            set => _deferRevRecFieldSpecified = value;
        }

        /// <remarks/>
        public bool IsClosed
        {
            get => _isClosedField;
            set => _isClosedField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool IsClosedSpecified
        {
            get => _isClosedFieldSpecified;
            set => _isClosedFieldSpecified = value;
        }

        /// <remarks/>
        public SalesOrderItemFulfillmentChoice ItemFulfillmentChoice
        {
            get => _itemFulfillmentChoiceField;
            set => _itemFulfillmentChoiceField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool ItemFulfillmentChoiceSpecified
        {
            get => _itemFulfillmentChoiceFieldSpecified;
            set => _itemFulfillmentChoiceFieldSpecified = value;
        }

        /// <remarks/>
        public RecordRef CatchUpPeriod
        {
            get => _catchUpPeriodField;
            set => _catchUpPeriodField = value;
        }

        /// <remarks/>
        public RecordRef BillingSchedule
        {
            get => _billingScheduleField;
            set => _billingScheduleField = value;
        }

        /// <remarks/>
        public bool FromJob
        {
            get => _fromJobField;
            set => _fromJobField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool FromJobSpecified
        {
            get => _fromJobFieldSpecified;
            set => _fromJobFieldSpecified = value;
        }

        /// <remarks/>
        public decimal GrossAmt
        {
            get => _grossAmtField;
            set => _grossAmtField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool GrossAmtSpecified
        {
            get => _grossAmtFieldSpecified;
            set => _grossAmtFieldSpecified = value;
        }

        /// <remarks/>
        public decimal TaxAmount
        {
            get => _taxAmountField;
            set => _taxAmountField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TaxAmountSpecified
        {
            get => _taxAmountFieldSpecified;
            set => _taxAmountFieldSpecified = value;
        }

        /// <remarks/>
        public bool ExcludeFromRateRequest
        {
            get => _excludeFromRateRequestField;
            set => _excludeFromRateRequestField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool ExcludeFromRateRequestSpecified
        {
            get => _excludeFromRateRequestFieldSpecified;
            set => _excludeFromRateRequestFieldSpecified = value;
        }

        /// <remarks/>
        public bool IsEstimate
        {
            get => _isEstimateField;
            set => _isEstimateField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool IsEstimateSpecified
        {
            get => _isEstimateFieldSpecified;
            set => _isEstimateFieldSpecified = value;
        }

        /// <remarks/>
        public RecordRef InventoryLocation
        {
            get => _inventoryLocationField;
            set => _inventoryLocationField = value;
        }

        /// <remarks/>
        public RecordRef InventorySubsidiary
        {
            get => _inventorySubsidiaryField;
            set => _inventorySubsidiaryField = value;
        }

        /// <remarks/>
        public int Line
        {
            get => _lineField;
            set => _lineField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool LineSpecified
        {
            get => _lineFieldSpecified;
            set => _lineFieldSpecified = value;
        }

        /// <remarks/>
        public decimal PercentComplete
        {
            get => _percentCompleteField;
            set => _percentCompleteField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool PercentCompleteSpecified
        {
            get => _percentCompleteFieldSpecified;
            set => _percentCompleteFieldSpecified = value;
        }

        /// <remarks/>
        public ItemCostEstimateType CostEstimateType
        {
            get => _costEstimateTypeField;
            set => _costEstimateTypeField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool CostEstimateTypeSpecified
        {
            get => _costEstimateTypeFieldSpecified;
            set => _costEstimateTypeFieldSpecified = value;
        }

        /// <remarks/>
        public decimal CostEstimate
        {
            get => _costEstimateField;
            set => _costEstimateField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool CostEstimateSpecified
        {
            get => _costEstimateFieldSpecified;
            set => _costEstimateFieldSpecified = value;
        }

        /// <remarks/>
        public decimal QuantityBackOrdered
        {
            get => _quantityBackOrderedField;
            set => _quantityBackOrderedField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool QuantityBackOrderedSpecified
        {
            get => _quantityBackOrderedFieldSpecified;
            set => _quantityBackOrderedFieldSpecified = value;
        }

        /// <remarks/>
        public decimal QuantityBilled
        {
            get => _quantityBilledField;
            set => _quantityBilledField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool QuantityBilledSpecified
        {
            get => _quantityBilledFieldSpecified;
            set => _quantityBilledFieldSpecified = value;
        }

        /// <remarks/>
        public decimal QuantityCommitted
        {
            get => _quantityCommittedField;
            set => _quantityCommittedField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool QuantityCommittedSpecified
        {
            get => _quantityCommittedFieldSpecified;
            set => _quantityCommittedFieldSpecified = value;
        }

        /// <remarks/>
        public decimal QuantityFulfilled
        {
            get => _quantityFulfilledField;
            set => _quantityFulfilledField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool QuantityFulfilledSpecified
        {
            get => _quantityFulfilledFieldSpecified;
            set => _quantityFulfilledFieldSpecified = value;
        }

        /// <remarks/>
        public decimal QuantityPacked
        {
            get => _quantityPackedField;
            set => _quantityPackedField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool QuantityPackedSpecified
        {
            get => _quantityPackedFieldSpecified;
            set => _quantityPackedFieldSpecified = value;
        }

        /// <remarks/>
        public decimal QuantityPicked
        {
            get => _quantityPickedField;
            set => _quantityPickedField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool QuantityPickedSpecified
        {
            get => _quantityPickedFieldSpecified;
            set => _quantityPickedFieldSpecified = value;
        }

        /// <remarks/>
        public decimal Tax1Amt
        {
            get => _tax1AmtField;
            set => _tax1AmtField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool Tax1AmtSpecified
        {
            get => _tax1AmtFieldSpecified;
            set => _tax1AmtFieldSpecified = value;
        }

        /// <remarks/>
        public RecordRef TaxCode
        {
            get => _taxCodeField;
            set => _taxCodeField = value;
        }

        /// <remarks/>
        public decimal TaxRate1
        {
            get => _taxRate1Field;
            set => _taxRate1Field = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TaxRate1Specified
        {
            get => _taxRate1FieldSpecified;
            set => _taxRate1FieldSpecified = value;
        }

        /// <remarks/>
        public decimal TaxRate2
        {
            get => _taxRate2Field;
            set => _taxRate2Field = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TaxRate2Specified
        {
            get => _taxRate2FieldSpecified;
            set => _taxRate2FieldSpecified = value;
        }

        /// <remarks/>
        public string GiftCertFrom
        {
            get => _giftCertFromField;
            set => _giftCertFromField = value;
        }

        /// <remarks/>
        public string GiftCertRecipientName
        {
            get => _giftCertRecipientNameField;
            set => _giftCertRecipientNameField = value;
        }

        /// <remarks/>
        public string GiftCertRecipientEmail
        {
            get => _giftCertRecipientEmailField;
            set => _giftCertRecipientEmailField = value;
        }

        /// <remarks/>
        public string GiftCertMessage
        {
            get => _giftCertMessageField;
            set => _giftCertMessageField = value;
        }

        /// <remarks/>
        public string GiftCertNumber
        {
            get => _giftCertNumberField;
            set => _giftCertNumberField = value;
        }

        /// <remarks/>
        public long ShipGroup
        {
            get => _shipGroupField;
            set => _shipGroupField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool ShipGroupSpecified
        {
            get => _shipGroupFieldSpecified;
            set => _shipGroupFieldSpecified = value;
        }

        /// <remarks/>
        public bool ItemIsFulfilled
        {
            get => _itemIsFulfilledField;
            set => _itemIsFulfilledField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool ItemIsFulfilledSpecified
        {
            get => _itemIsFulfilledFieldSpecified;
            set => _itemIsFulfilledFieldSpecified = value;
        }

        /// <remarks/>
        public RecordRef ShipAddress
        {
            get => _shipAddressField;
            set => _shipAddressField = value;
        }

        /// <remarks/>
        public RecordRef ShipMethod
        {
            get => _shipMethodField;
            set => _shipMethodField = value;
        }

        /// <remarks/>
        public VsoeSopGroup VsoeSopGroup
        {
            get => _vsoeSopGroupField;
            set => _vsoeSopGroupField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool VsoeSopGroupSpecified
        {
            get => _vsoeSopGroupFieldSpecified;
            set => _vsoeSopGroupFieldSpecified = value;
        }

        /// <remarks/>
        public bool VsoeIsEstimate
        {
            get => _vsoeIsEstimateField;
            set => _vsoeIsEstimateField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool VsoeIsEstimateSpecified
        {
            get => _vsoeIsEstimateFieldSpecified;
            set => _vsoeIsEstimateFieldSpecified = value;
        }

        /// <remarks/>
        public decimal VsoePrice
        {
            get => _vsoePriceField;
            set => _vsoePriceField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool VsoePriceSpecified
        {
            get => _vsoePriceFieldSpecified;
            set => _vsoePriceFieldSpecified = value;
        }

        /// <remarks/>
        public decimal VsoeAmount
        {
            get => _vsoeAmountField;
            set => _vsoeAmountField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool VsoeAmountSpecified
        {
            get => _vsoeAmountFieldSpecified;
            set => _vsoeAmountFieldSpecified = value;
        }

        /// <remarks/>
        public decimal VsoeAllocation
        {
            get => _vsoeAllocationField;
            set => _vsoeAllocationField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool VsoeAllocationSpecified
        {
            get => _vsoeAllocationFieldSpecified;
            set => _vsoeAllocationFieldSpecified = value;
        }

        /// <remarks/>
        public VsoeDeferral VsoeDeferral
        {
            get => _vsoeDeferralField;
            set => _vsoeDeferralField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool VsoeDeferralSpecified
        {
            get => _vsoeDeferralFieldSpecified;
            set => _vsoeDeferralFieldSpecified = value;
        }

        /// <remarks/>
        public VsoePermitDiscount VsoePermitDiscount
        {
            get => _vsoePermitDiscountField;
            set => _vsoePermitDiscountField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool VsoePermitDiscountSpecified
        {
            get => _vsoePermitDiscountFieldSpecified;
            set => _vsoePermitDiscountFieldSpecified = value;
        }

        /// <remarks/>
        public bool VsoeDelivered
        {
            get => _vsoeDeliveredField;
            set => _vsoeDeliveredField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool VsoeDeliveredSpecified
        {
            get => _vsoeDeliveredFieldSpecified;
            set => _vsoeDeliveredFieldSpecified = value;
        }

        /// <remarks/>
        public DateTime ExpectedShipDate
        {
            get => _expectedShipDateField;
            set => _expectedShipDateField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool ExpectedShipDateSpecified
        {
            get => _expectedShipDateFieldSpecified;
            set => _expectedShipDateFieldSpecified = value;
        }

        /// <remarks/>
        public bool NoAutoAssignLocation
        {
            get => _noAutoAssignLocationField;
            set => _noAutoAssignLocationField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool NoAutoAssignLocationSpecified
        {
            get => _noAutoAssignLocationFieldSpecified;
            set => _noAutoAssignLocationFieldSpecified = value;
        }

        /// <remarks/>
        public bool LocationAutoAssigned
        {
            get => _locationAutoAssignedField;
            set => _locationAutoAssignedField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool LocationAutoAssignedSpecified
        {
            get => _locationAutoAssignedFieldSpecified;
            set => _locationAutoAssignedFieldSpecified = value;
        }

        /// <remarks/>
        public string TaxDetailsReference
        {
            get => _taxDetailsReferenceField;
            set => _taxDetailsReferenceField = value;
        }

        /// <remarks/>
        public RecordRef ChargeType
        {
            get => _chargeTypeField;
            set => _chargeTypeField = value;
        }

        /// <remarks/>
        public RecordRef OrderAllocationStrategy
        {
            get => _orderAllocationStrategyField;
            set => _orderAllocationStrategyField = value;
        }

        /// <remarks/>
        public DateTime RequestedDate
        {
            get => _requestedDateField;
            set => _requestedDateField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool RequestedDateSpecified
        {
            get => _requestedDateFieldSpecified;
            set => _requestedDateFieldSpecified = value;
        }

        /// <remarks/>
        [XmlArrayItemAttribute("customField", Namespace = "urn:core_2021_1.platform.webservices.netsuite.com", IsNullable = false)]
        public CustomFieldRef[] CustomFieldList
        {
            get => _customFieldListField;
            set => _customFieldListField = value;
        }

        #endregion
    }
}
