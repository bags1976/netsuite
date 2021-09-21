using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sales_2021_1.transactions.webservices.netsuite.com")]
    public partial class CashSaleItem {

        private RecordRef jobField;

        private RecordRef itemField;

        private long lineField;

        private bool lineFieldSpecified;

        private double quantityAvailableField;

        private bool quantityAvailableFieldSpecified;

        private double quantityOnHandField;

        private bool quantityOnHandFieldSpecified;

        private double quantityFulfilledField;

        private bool quantityFulfilledFieldSpecified;

        private double quantityField;

        private bool quantityFieldSpecified;

        private RecordRef unitsField;

        private InventoryDetail inventoryDetailField;

        private string serialNumbersField;

        private string binNumbersField;

        private string descriptionField;

        private RecordRef priceField;

        private string rateField;

        private double amountField;

        private bool amountFieldSpecified;

        private long orderLineField;

        private bool orderLineFieldSpecified;

        private string licenseCodeField;

        private bool isTaxableField;

        private bool isTaxableFieldSpecified;

        private CustomFieldRef[] optionsField;

        private bool deferRevRecField;

        private bool deferRevRecFieldSpecified;

        private double currentPercentField;

        private bool currentPercentFieldSpecified;

        private RecordRef departmentField;

        private double percentCompleteField;

        private bool percentCompleteFieldSpecified;

        private RecordRef classField;

        private RecordRef locationField;

        private RecordRef revRecScheduleField;

        private System.DateTime revRecStartDateField;

        private bool revRecStartDateFieldSpecified;

        private System.DateTime revRecEndDateField;

        private bool revRecEndDateFieldSpecified;

        private RecordRef subscriptionLineField;

        private double grossAmtField;

        private bool grossAmtFieldSpecified;

        private ItemCostEstimateType costEstimateTypeField;

        private bool costEstimateTypeFieldSpecified;

        private bool excludeFromRateRequestField;

        private bool excludeFromRateRequestFieldSpecified;

        private RecordRef catchUpPeriodField;

        private double costEstimateField;

        private bool costEstimateFieldSpecified;

        private string taxDetailsReferenceField;

        private double amountOrderedField;

        private bool amountOrderedFieldSpecified;

        private double tax1AmtField;

        private bool tax1AmtFieldSpecified;

        private double quantityOrderedField;

        private bool quantityOrderedFieldSpecified;

        private double quantityRemainingField;

        private bool quantityRemainingFieldSpecified;

        private RecordRef taxCodeField;

        private double taxRate1Field;

        private bool taxRate1FieldSpecified;

        private double taxRate2Field;

        private bool taxRate2FieldSpecified;

        private string giftCertFromField;

        private string giftCertRecipientNameField;

        private string giftCertRecipientEmailField;

        private string giftCertMessageField;

        private double taxAmountField;

        private bool taxAmountFieldSpecified;

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

        private RecordRef chargeTypeField;

        private RecordRef[] chargesListField;

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
        public string serialNumbers {
            get {
                return this.serialNumbersField;
            }
            set {
                this.serialNumbersField = value;
            }
        }

        /// <remarks/>
        public string binNumbers {
            get {
                return this.binNumbersField;
            }
            set {
                this.binNumbersField = value;
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
        public long orderLine {
            get {
                return this.orderLineField;
            }
            set {
                this.orderLineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool orderLineSpecified {
            get {
                return this.orderLineFieldSpecified;
            }
            set {
                this.orderLineFieldSpecified = value;
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
        public double currentPercent {
            get {
                return this.currentPercentField;
            }
            set {
                this.currentPercentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool currentPercentSpecified {
            get {
                return this.currentPercentFieldSpecified;
            }
            set {
                this.currentPercentFieldSpecified = value;
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
        public RecordRef subscriptionLine {
            get {
                return this.subscriptionLineField;
            }
            set {
                this.subscriptionLineField = value;
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
        public RecordRef catchUpPeriod {
            get {
                return this.catchUpPeriodField;
            }
            set {
                this.catchUpPeriodField = value;
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
        public string taxDetailsReference {
            get {
                return this.taxDetailsReferenceField;
            }
            set {
                this.taxDetailsReferenceField = value;
            }
        }

        /// <remarks/>
        public double amountOrdered {
            get {
                return this.amountOrderedField;
            }
            set {
                this.amountOrderedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool amountOrderedSpecified {
            get {
                return this.amountOrderedFieldSpecified;
            }
            set {
                this.amountOrderedFieldSpecified = value;
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
        public double quantityOrdered {
            get {
                return this.quantityOrderedField;
            }
            set {
                this.quantityOrderedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantityOrderedSpecified {
            get {
                return this.quantityOrderedFieldSpecified;
            }
            set {
                this.quantityOrderedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double quantityRemaining {
            get {
                return this.quantityRemainingField;
            }
            set {
                this.quantityRemainingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantityRemainingSpecified {
            get {
                return this.quantityRemainingFieldSpecified;
            }
            set {
                this.quantityRemainingFieldSpecified = value;
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
        public RecordRef chargeType {
            get {
                return this.chargeTypeField;
            }
            set {
                this.chargeTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recordRef", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public RecordRef[] chargesList {
            get {
                return this.chargesListField;
            }
            set {
                this.chargesListField = value;
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