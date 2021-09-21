using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sales_2021_1.transactions.webservices.netsuite.com")]
    public partial class SalesOrderItem {

        private RecordRef jobField;

        private RecordRef subscriptionField;

        private RecordRef itemField;

        private double quantityAvailableField;

        private bool quantityAvailableFieldSpecified;

        private bool expandItemGroupField;

        private bool expandItemGroupFieldSpecified;

        private long lineUniqueKeyField;

        private bool lineUniqueKeyFieldSpecified;

        private double quantityOnHandField;

        private bool quantityOnHandFieldSpecified;

        private double quantityField;

        private bool quantityFieldSpecified;

        private RecordRef unitsField;

        private InventoryDetail inventoryDetailField;

        private string descriptionField;

        private RecordRef priceField;

        private string rateField;

        private string serialNumbersField;

        private double amountField;

        private bool amountFieldSpecified;

        private bool isTaxableField;

        private bool isTaxableFieldSpecified;

        private SalesOrderItemCommitInventory commitInventoryField;

        private bool commitInventoryFieldSpecified;

        private double orderPriorityField;

        private bool orderPriorityFieldSpecified;

        private string licenseCodeField;

        private CustomFieldRef[] optionsField;

        private RecordRef departmentField;

        private RecordRef classField;

        private RecordRef locationField;

        private SalesOrderItemCreatePo createPoField;

        private bool createPoFieldSpecified;

        private RecordRef createdPoField;

        private double altSalesAmtField;

        private bool altSalesAmtFieldSpecified;

        private bool createWoField;

        private bool createWoFieldSpecified;

        private RecordRef poVendorField;

        private string poCurrencyField;

        private double poRateField;

        private bool poRateFieldSpecified;

        private RecordRef revRecScheduleField;

        private System.DateTime revRecStartDateField;

        private bool revRecStartDateFieldSpecified;

        private long revRecTermInMonthsField;

        private bool revRecTermInMonthsFieldSpecified;

        private System.DateTime revRecEndDateField;

        private bool revRecEndDateFieldSpecified;

        private bool deferRevRecField;

        private bool deferRevRecFieldSpecified;

        private bool isClosedField;

        private bool isClosedFieldSpecified;

        private SalesOrderItemFulfillmentChoice itemFulfillmentChoiceField;

        private bool itemFulfillmentChoiceFieldSpecified;

        private RecordRef catchUpPeriodField;

        private RecordRef billingScheduleField;

        private bool fromJobField;

        private bool fromJobFieldSpecified;

        private double grossAmtField;

        private bool grossAmtFieldSpecified;

        private double taxAmountField;

        private bool taxAmountFieldSpecified;

        private bool excludeFromRateRequestField;

        private bool excludeFromRateRequestFieldSpecified;

        private bool isEstimateField;

        private bool isEstimateFieldSpecified;

        private RecordRef inventoryLocationField;

        private RecordRef inventorySubsidiaryField;

        private long lineField;

        private bool lineFieldSpecified;

        private double percentCompleteField;

        private bool percentCompleteFieldSpecified;

        private ItemCostEstimateType costEstimateTypeField;

        private bool costEstimateTypeFieldSpecified;

        private double costEstimateField;

        private bool costEstimateFieldSpecified;

        private double quantityBackOrderedField;

        private bool quantityBackOrderedFieldSpecified;

        private double quantityBilledField;

        private bool quantityBilledFieldSpecified;

        private double quantityCommittedField;

        private bool quantityCommittedFieldSpecified;

        private double quantityFulfilledField;

        private bool quantityFulfilledFieldSpecified;

        private double quantityPackedField;

        private bool quantityPackedFieldSpecified;

        private double quantityPickedField;

        private bool quantityPickedFieldSpecified;

        private double tax1AmtField;

        private bool tax1AmtFieldSpecified;

        private RecordRef taxCodeField;

        private double taxRate1Field;

        private bool taxRate1FieldSpecified;

        private double taxRate2Field;

        private bool taxRate2FieldSpecified;

        private string giftCertFromField;

        private string giftCertRecipientNameField;

        private string giftCertRecipientEmailField;

        private string giftCertMessageField;

        private string giftCertNumberField;

        private long shipGroupField;

        private bool shipGroupFieldSpecified;

        private bool itemIsFulfilledField;

        private bool itemIsFulfilledFieldSpecified;

        private RecordRef shipAddressField;

        private RecordRef shipMethodField;

        private VsoeSopGroup vsoeSopGroupField;

        private bool vsoeSopGroupFieldSpecified;

        private bool vsoeIsEstimateField;

        private bool vsoeIsEstimateFieldSpecified;

        private double vsoePriceField;

        private bool vsoePriceFieldSpecified;

        private double vsoeAmountField;

        private bool vsoeAmountFieldSpecified;

        private double vsoeAllocationField;

        private bool vsoeAllocationFieldSpecified;

        private VsoeDeferral vsoeDeferralField;

        private bool vsoeDeferralFieldSpecified;

        private VsoePermitDiscount vsoePermitDiscountField;

        private bool vsoePermitDiscountFieldSpecified;

        private bool vsoeDeliveredField;

        private bool vsoeDeliveredFieldSpecified;

        private System.DateTime expectedShipDateField;

        private bool expectedShipDateFieldSpecified;

        private bool noAutoAssignLocationField;

        private bool noAutoAssignLocationFieldSpecified;

        private bool locationAutoAssignedField;

        private bool locationAutoAssignedFieldSpecified;

        private string taxDetailsReferenceField;

        private RecordRef chargeTypeField;

        private RecordRef orderAllocationStrategyField;

        private System.DateTime requestedDateField;

        private bool requestedDateFieldSpecified;

        private CustomFieldRef[] customFieldListField;

        /// <remarks/>
        public RecordRef job {
            get {
                return this.jobField;
            }
            set {
                this.jobField = value;
            }
        }

        /// <remarks/>
        public RecordRef subscription {
            get {
                return this.subscriptionField;
            }
            set {
                this.subscriptionField = value;
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

        /// <remarks/>
        public long lineUniqueKey {
            get {
                return this.lineUniqueKeyField;
            }
            set {
                this.lineUniqueKeyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lineUniqueKeySpecified {
            get {
                return this.lineUniqueKeyFieldSpecified;
            }
            set {
                this.lineUniqueKeyFieldSpecified = value;
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
        public RecordRef price {
            get {
                return this.priceField;
            }
            set {
                this.priceField = value;
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
        public string serialNumbers {
            get {
                return this.serialNumbersField;
            }
            set {
                this.serialNumbersField = value;
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
        public bool isTaxable {
            get {
                return this.isTaxableField;
            }
            set {
                this.isTaxableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isTaxableSpecified {
            get {
                return this.isTaxableFieldSpecified;
            }
            set {
                this.isTaxableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public SalesOrderItemCommitInventory commitInventory {
            get {
                return this.commitInventoryField;
            }
            set {
                this.commitInventoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool commitInventorySpecified {
            get {
                return this.commitInventoryFieldSpecified;
            }
            set {
                this.commitInventoryFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double orderPriority {
            get {
                return this.orderPriorityField;
            }
            set {
                this.orderPriorityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool orderPrioritySpecified {
            get {
                return this.orderPriorityFieldSpecified;
            }
            set {
                this.orderPriorityFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string licenseCode {
            get {
                return this.licenseCodeField;
            }
            set {
                this.licenseCodeField = value;
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
        public RecordRef location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }

        /// <remarks/>
        public SalesOrderItemCreatePo createPo {
            get {
                return this.createPoField;
            }
            set {
                this.createPoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool createPoSpecified {
            get {
                return this.createPoFieldSpecified;
            }
            set {
                this.createPoFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef createdPo {
            get {
                return this.createdPoField;
            }
            set {
                this.createdPoField = value;
            }
        }

        /// <remarks/>
        public double altSalesAmt {
            get {
                return this.altSalesAmtField;
            }
            set {
                this.altSalesAmtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool altSalesAmtSpecified {
            get {
                return this.altSalesAmtFieldSpecified;
            }
            set {
                this.altSalesAmtFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool createWo {
            get {
                return this.createWoField;
            }
            set {
                this.createWoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool createWoSpecified {
            get {
                return this.createWoFieldSpecified;
            }
            set {
                this.createWoFieldSpecified = value;
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
        public string poCurrency {
            get {
                return this.poCurrencyField;
            }
            set {
                this.poCurrencyField = value;
            }
        }

        /// <remarks/>
        public double poRate {
            get {
                return this.poRateField;
            }
            set {
                this.poRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool poRateSpecified {
            get {
                return this.poRateFieldSpecified;
            }
            set {
                this.poRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef revRecSchedule {
            get {
                return this.revRecScheduleField;
            }
            set {
                this.revRecScheduleField = value;
            }
        }

        /// <remarks/>
        public System.DateTime revRecStartDate {
            get {
                return this.revRecStartDateField;
            }
            set {
                this.revRecStartDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool revRecStartDateSpecified {
            get {
                return this.revRecStartDateFieldSpecified;
            }
            set {
                this.revRecStartDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long revRecTermInMonths {
            get {
                return this.revRecTermInMonthsField;
            }
            set {
                this.revRecTermInMonthsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool revRecTermInMonthsSpecified {
            get {
                return this.revRecTermInMonthsFieldSpecified;
            }
            set {
                this.revRecTermInMonthsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime revRecEndDate {
            get {
                return this.revRecEndDateField;
            }
            set {
                this.revRecEndDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool revRecEndDateSpecified {
            get {
                return this.revRecEndDateFieldSpecified;
            }
            set {
                this.revRecEndDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool deferRevRec {
            get {
                return this.deferRevRecField;
            }
            set {
                this.deferRevRecField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool deferRevRecSpecified {
            get {
                return this.deferRevRecFieldSpecified;
            }
            set {
                this.deferRevRecFieldSpecified = value;
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
        public SalesOrderItemFulfillmentChoice itemFulfillmentChoice {
            get {
                return this.itemFulfillmentChoiceField;
            }
            set {
                this.itemFulfillmentChoiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itemFulfillmentChoiceSpecified {
            get {
                return this.itemFulfillmentChoiceFieldSpecified;
            }
            set {
                this.itemFulfillmentChoiceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef catchUpPeriod {
            get {
                return this.catchUpPeriodField;
            }
            set {
                this.catchUpPeriodField = value;
            }
        }

        /// <remarks/>
        public RecordRef billingSchedule {
            get {
                return this.billingScheduleField;
            }
            set {
                this.billingScheduleField = value;
            }
        }

        /// <remarks/>
        public bool fromJob {
            get {
                return this.fromJobField;
            }
            set {
                this.fromJobField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fromJobSpecified {
            get {
                return this.fromJobFieldSpecified;
            }
            set {
                this.fromJobFieldSpecified = value;
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
        public bool excludeFromRateRequest {
            get {
                return this.excludeFromRateRequestField;
            }
            set {
                this.excludeFromRateRequestField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool excludeFromRateRequestSpecified {
            get {
                return this.excludeFromRateRequestFieldSpecified;
            }
            set {
                this.excludeFromRateRequestFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isEstimate {
            get {
                return this.isEstimateField;
            }
            set {
                this.isEstimateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isEstimateSpecified {
            get {
                return this.isEstimateFieldSpecified;
            }
            set {
                this.isEstimateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef inventoryLocation {
            get {
                return this.inventoryLocationField;
            }
            set {
                this.inventoryLocationField = value;
            }
        }

        /// <remarks/>
        public RecordRef inventorySubsidiary {
            get {
                return this.inventorySubsidiaryField;
            }
            set {
                this.inventorySubsidiaryField = value;
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
        public double percentComplete {
            get {
                return this.percentCompleteField;
            }
            set {
                this.percentCompleteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool percentCompleteSpecified {
            get {
                return this.percentCompleteFieldSpecified;
            }
            set {
                this.percentCompleteFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ItemCostEstimateType costEstimateType {
            get {
                return this.costEstimateTypeField;
            }
            set {
                this.costEstimateTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool costEstimateTypeSpecified {
            get {
                return this.costEstimateTypeFieldSpecified;
            }
            set {
                this.costEstimateTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double costEstimate {
            get {
                return this.costEstimateField;
            }
            set {
                this.costEstimateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool costEstimateSpecified {
            get {
                return this.costEstimateFieldSpecified;
            }
            set {
                this.costEstimateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double quantityBackOrdered {
            get {
                return this.quantityBackOrderedField;
            }
            set {
                this.quantityBackOrderedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantityBackOrderedSpecified {
            get {
                return this.quantityBackOrderedFieldSpecified;
            }
            set {
                this.quantityBackOrderedFieldSpecified = value;
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
        public double quantityCommitted {
            get {
                return this.quantityCommittedField;
            }
            set {
                this.quantityCommittedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantityCommittedSpecified {
            get {
                return this.quantityCommittedFieldSpecified;
            }
            set {
                this.quantityCommittedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double quantityFulfilled {
            get {
                return this.quantityFulfilledField;
            }
            set {
                this.quantityFulfilledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantityFulfilledSpecified {
            get {
                return this.quantityFulfilledFieldSpecified;
            }
            set {
                this.quantityFulfilledFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double quantityPacked {
            get {
                return this.quantityPackedField;
            }
            set {
                this.quantityPackedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantityPackedSpecified {
            get {
                return this.quantityPackedFieldSpecified;
            }
            set {
                this.quantityPackedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double quantityPicked {
            get {
                return this.quantityPickedField;
            }
            set {
                this.quantityPickedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantityPickedSpecified {
            get {
                return this.quantityPickedFieldSpecified;
            }
            set {
                this.quantityPickedFieldSpecified = value;
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
        public string giftCertFrom {
            get {
                return this.giftCertFromField;
            }
            set {
                this.giftCertFromField = value;
            }
        }

        /// <remarks/>
        public string giftCertRecipientName {
            get {
                return this.giftCertRecipientNameField;
            }
            set {
                this.giftCertRecipientNameField = value;
            }
        }

        /// <remarks/>
        public string giftCertRecipientEmail {
            get {
                return this.giftCertRecipientEmailField;
            }
            set {
                this.giftCertRecipientEmailField = value;
            }
        }

        /// <remarks/>
        public string giftCertMessage {
            get {
                return this.giftCertMessageField;
            }
            set {
                this.giftCertMessageField = value;
            }
        }

        /// <remarks/>
        public string giftCertNumber {
            get {
                return this.giftCertNumberField;
            }
            set {
                this.giftCertNumberField = value;
            }
        }

        /// <remarks/>
        public long shipGroup {
            get {
                return this.shipGroupField;
            }
            set {
                this.shipGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shipGroupSpecified {
            get {
                return this.shipGroupFieldSpecified;
            }
            set {
                this.shipGroupFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool itemIsFulfilled {
            get {
                return this.itemIsFulfilledField;
            }
            set {
                this.itemIsFulfilledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itemIsFulfilledSpecified {
            get {
                return this.itemIsFulfilledFieldSpecified;
            }
            set {
                this.itemIsFulfilledFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef shipAddress {
            get {
                return this.shipAddressField;
            }
            set {
                this.shipAddressField = value;
            }
        }

        /// <remarks/>
        public RecordRef shipMethod {
            get {
                return this.shipMethodField;
            }
            set {
                this.shipMethodField = value;
            }
        }

        /// <remarks/>
        public VsoeSopGroup vsoeSopGroup {
            get {
                return this.vsoeSopGroupField;
            }
            set {
                this.vsoeSopGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool vsoeSopGroupSpecified {
            get {
                return this.vsoeSopGroupFieldSpecified;
            }
            set {
                this.vsoeSopGroupFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool vsoeIsEstimate {
            get {
                return this.vsoeIsEstimateField;
            }
            set {
                this.vsoeIsEstimateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool vsoeIsEstimateSpecified {
            get {
                return this.vsoeIsEstimateFieldSpecified;
            }
            set {
                this.vsoeIsEstimateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double vsoePrice {
            get {
                return this.vsoePriceField;
            }
            set {
                this.vsoePriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool vsoePriceSpecified {
            get {
                return this.vsoePriceFieldSpecified;
            }
            set {
                this.vsoePriceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double vsoeAmount {
            get {
                return this.vsoeAmountField;
            }
            set {
                this.vsoeAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool vsoeAmountSpecified {
            get {
                return this.vsoeAmountFieldSpecified;
            }
            set {
                this.vsoeAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double vsoeAllocation {
            get {
                return this.vsoeAllocationField;
            }
            set {
                this.vsoeAllocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool vsoeAllocationSpecified {
            get {
                return this.vsoeAllocationFieldSpecified;
            }
            set {
                this.vsoeAllocationFieldSpecified = value;
            }
        }

        /// <remarks/>
        public VsoeDeferral vsoeDeferral {
            get {
                return this.vsoeDeferralField;
            }
            set {
                this.vsoeDeferralField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool vsoeDeferralSpecified {
            get {
                return this.vsoeDeferralFieldSpecified;
            }
            set {
                this.vsoeDeferralFieldSpecified = value;
            }
        }

        /// <remarks/>
        public VsoePermitDiscount vsoePermitDiscount {
            get {
                return this.vsoePermitDiscountField;
            }
            set {
                this.vsoePermitDiscountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool vsoePermitDiscountSpecified {
            get {
                return this.vsoePermitDiscountFieldSpecified;
            }
            set {
                this.vsoePermitDiscountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool vsoeDelivered {
            get {
                return this.vsoeDeliveredField;
            }
            set {
                this.vsoeDeliveredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool vsoeDeliveredSpecified {
            get {
                return this.vsoeDeliveredFieldSpecified;
            }
            set {
                this.vsoeDeliveredFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime expectedShipDate {
            get {
                return this.expectedShipDateField;
            }
            set {
                this.expectedShipDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expectedShipDateSpecified {
            get {
                return this.expectedShipDateFieldSpecified;
            }
            set {
                this.expectedShipDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool noAutoAssignLocation {
            get {
                return this.noAutoAssignLocationField;
            }
            set {
                this.noAutoAssignLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool noAutoAssignLocationSpecified {
            get {
                return this.noAutoAssignLocationFieldSpecified;
            }
            set {
                this.noAutoAssignLocationFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool locationAutoAssigned {
            get {
                return this.locationAutoAssignedField;
            }
            set {
                this.locationAutoAssignedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool locationAutoAssignedSpecified {
            get {
                return this.locationAutoAssignedFieldSpecified;
            }
            set {
                this.locationAutoAssignedFieldSpecified = value;
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
        public RecordRef chargeType {
            get {
                return this.chargeTypeField;
            }
            set {
                this.chargeTypeField = value;
            }
        }

        /// <remarks/>
        public RecordRef orderAllocationStrategy {
            get {
                return this.orderAllocationStrategyField;
            }
            set {
                this.orderAllocationStrategyField = value;
            }
        }

        /// <remarks/>
        public System.DateTime requestedDate {
            get {
                return this.requestedDateField;
            }
            set {
                this.requestedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool requestedDateSpecified {
            get {
                return this.requestedDateFieldSpecified;
            }
            set {
                this.requestedDateFieldSpecified = value;
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