namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sales_2021_1.transactions.webservices.netsuite.com")]
    public partial class SalesOrder : Record {

        private System.DateTime createdDateField;

        private bool createdDateFieldSpecified;

        private RecordRef customFormField;

        private RecordRef entityField;

        private RecordRef jobField;

        private RecordRef currencyField;

        private RecordRef drAccountField;

        private RecordRef fxAccountField;

        private System.DateTime tranDateField;

        private bool tranDateFieldSpecified;

        private string tranIdField;

        private RecordRef entityTaxRegNumField;

        private string sourceField;

        private RecordRef createdFromField;

        private SalesOrderOrderStatus orderStatusField;

        private bool orderStatusFieldSpecified;

        private System.DateTime nextBillField;

        private bool nextBillFieldSpecified;

        private RecordRef opportunityField;

        private RecordRef salesRepField;

        private string contribPctField;

        private RecordRef partnerField;

        private RecordRef salesGroupField;

        private bool syncSalesTeamsField;

        private bool syncSalesTeamsFieldSpecified;

        private RecordRef leadSourceField;

        private System.DateTime startDateField;

        private bool startDateFieldSpecified;

        private System.DateTime endDateField;

        private bool endDateFieldSpecified;

        private string otherRefNumField;

        private string memoField;

        private System.DateTime salesEffectiveDateField;

        private bool salesEffectiveDateFieldSpecified;

        private bool excludeCommissionField;

        private bool excludeCommissionFieldSpecified;

        private double totalCostEstimateField;

        private bool totalCostEstimateFieldSpecified;

        private double estGrossProfitField;

        private bool estGrossProfitFieldSpecified;

        private double estGrossProfitPercentField;

        private bool estGrossProfitPercentFieldSpecified;

        private double exchangeRateField;

        private bool exchangeRateFieldSpecified;

        private RecordRef promoCodeField;

        private string currencyNameField;

        private RecordRef discountItemField;

        private string discountRateField;

        private bool isTaxableField;

        private bool isTaxableFieldSpecified;

        private RecordRef taxItemField;

        private double taxRateField;

        private bool taxRateFieldSpecified;

        private bool toBePrintedField;

        private bool toBePrintedFieldSpecified;

        private bool toBeEmailedField;

        private bool toBeEmailedFieldSpecified;

        private string emailField;

        private bool toBeFaxedField;

        private bool toBeFaxedFieldSpecified;

        private string faxField;

        private RecordRef messageSelField;

        private string messageField;

        private RecordRef paymentOptionField;

        private string inputAuthCodeField;

        private string inputReferenceCodeField;

        private string checkNumberField;

        private string paymentCardCscField;

        private RecordRef paymentProcessingProfileField;

        private SalesOrderHandlingMode handlingModeField;

        private bool handlingModeFieldSpecified;

        private string outputAuthCodeField;

        private string outputReferenceCodeField;

        private SalesOrderPaymentOperation paymentOperationField;

        private bool paymentOperationFieldSpecified;

        private string dynamicDescriptorField;

        private Address billingAddressField;

        private RecordRef billAddressListField;

        private Address shippingAddressField;

        private bool shipIsResidentialField;

        private bool shipIsResidentialFieldSpecified;

        private RecordRef shipAddressListField;

        private string fobField;

        private System.DateTime shipDateField;

        private bool shipDateFieldSpecified;

        private System.DateTime actualShipDateField;

        private bool actualShipDateFieldSpecified;

        private RecordRef shipMethodField;

        private double shippingCostField;

        private bool shippingCostFieldSpecified;

        private double shippingTax1RateField;

        private bool shippingTax1RateFieldSpecified;

        private bool isMultiShipToField;

        private bool isMultiShipToFieldSpecified;

        private string shippingTax2RateField;

        private RecordRef shippingTaxCodeField;

        private RecordRef handlingTaxCodeField;

        private double handlingTax1RateField;

        private bool handlingTax1RateFieldSpecified;

        private string handlingTax2RateField;

        private double handlingCostField;

        private bool handlingCostFieldSpecified;

        private string trackingNumbersField;

        private string linkedTrackingNumbersField;

        private bool shipCompleteField;

        private bool shipCompleteFieldSpecified;

        private RecordRef paymentMethodField;

        private string shopperIpAddressField;

        private bool saveOnAuthDeclineField;

        private bool saveOnAuthDeclineFieldSpecified;

        private bool canHaveStackableField;

        private bool canHaveStackableFieldSpecified;

        private RecordRef creditCardField;

        private RevenueStatus revenueStatusField;

        private bool revenueStatusFieldSpecified;

        private double recognizedRevenueField;

        private bool recognizedRevenueFieldSpecified;

        private double deferredRevenueField;

        private bool deferredRevenueFieldSpecified;

        private bool revRecOnRevCommitmentField;

        private bool revRecOnRevCommitmentFieldSpecified;

        private RevenueCommitStatus revCommitStatusField;

        private bool revCommitStatusFieldSpecified;

        private string ccNumberField;

        private System.DateTime ccExpireDateField;

        private bool ccExpireDateFieldSpecified;

        private string ccNameField;

        private string ccStreetField;

        private string ccZipCodeField;

        private string payPalStatusField;

        private RecordRef creditCardProcessorField;

        private string payPalTranIdField;

        private bool ccApprovedField;

        private bool ccApprovedFieldSpecified;

        private bool getAuthField;

        private bool getAuthFieldSpecified;

        private string authCodeField;

        private AvsMatchCode ccAvsStreetMatchField;

        private bool ccAvsStreetMatchFieldSpecified;

        private AvsMatchCode ccAvsZipMatchField;

        private bool ccAvsZipMatchFieldSpecified;

        private bool isRecurringPaymentField;

        private bool isRecurringPaymentFieldSpecified;

        private AvsMatchCode ccSecurityCodeMatchField;

        private bool ccSecurityCodeMatchFieldSpecified;

        private double altSalesTotalField;

        private bool altSalesTotalFieldSpecified;

        private bool ignoreAvsField;

        private bool ignoreAvsFieldSpecified;

        private TransactionPaymentEventResult paymentEventResultField;

        private bool paymentEventResultFieldSpecified;

        private TransactionPaymentEventHoldReason paymentEventHoldReasonField;

        private bool paymentEventHoldReasonFieldSpecified;

        private TransactionPaymentEventType paymentEventTypeField;

        private bool paymentEventTypeFieldSpecified;

        private System.DateTime paymentEventDateField;

        private bool paymentEventDateFieldSpecified;

        private string paymentEventUpdatedByField;

        private double subTotalField;

        private bool subTotalFieldSpecified;

        private double discountTotalField;

        private bool discountTotalFieldSpecified;

        private double taxTotalField;

        private bool taxTotalFieldSpecified;

        private double altShippingCostField;

        private bool altShippingCostFieldSpecified;

        private double altHandlingCostField;

        private bool altHandlingCostFieldSpecified;

        private double totalField;

        private bool totalFieldSpecified;

        private RecordRef revRecScheduleField;

        private System.DateTime revRecStartDateField;

        private bool revRecStartDateFieldSpecified;

        private System.DateTime revRecEndDateField;

        private bool revRecEndDateFieldSpecified;

        private string paypalAuthIdField;

        private double balanceField;

        private bool balanceFieldSpecified;

        private bool paypalProcessField;

        private bool paypalProcessFieldSpecified;

        private RecordRef billingScheduleField;

        private string ccSecurityCodeField;

        private string threeDStatusCodeField;

        private RecordRef classField;

        private RecordRef departmentField;

        private RecordRef subsidiaryField;

        private RecordRef intercoTransactionField;

        private IntercoStatus intercoStatusField;

        private bool intercoStatusFieldSpecified;

        private string debitCardIssueNoField;

        private System.DateTime lastModifiedDateField;

        private bool lastModifiedDateFieldSpecified;

        private RecordRef nexusField;

        private RecordRef subsidiaryTaxRegNumField;

        private bool taxRegOverrideField;

        private bool taxRegOverrideFieldSpecified;

        private System.DateTime taxPointDateField;

        private bool taxPointDateFieldSpecified;

        private bool taxDetailsOverrideField;

        private bool taxDetailsOverrideFieldSpecified;

        private RecordRef locationField;

        private string pnRefNumField;

        private string statusField;

        private double tax2TotalField;

        private bool tax2TotalFieldSpecified;

        private RecordRef termsField;

        private System.DateTime validFromField;

        private bool validFromFieldSpecified;

        private string vatRegNumField;

        private double giftCertAppliedField;

        private bool giftCertAppliedFieldSpecified;

        private double oneTimeField;

        private bool oneTimeFieldSpecified;

        private double recurWeeklyField;

        private bool recurWeeklyFieldSpecified;

        private double recurMonthlyField;

        private bool recurMonthlyFieldSpecified;

        private double recurQuarterlyField;

        private bool recurQuarterlyFieldSpecified;

        private double recurAnnuallyField;

        private bool recurAnnuallyFieldSpecified;

        private bool tranIsVsoeBundleField;

        private bool tranIsVsoeBundleFieldSpecified;

        private bool vsoeAutoCalcField;

        private bool vsoeAutoCalcFieldSpecified;

        private bool syncPartnerTeamsField;

        private bool syncPartnerTeamsFieldSpecified;

        private SalesOrderSalesTeamList salesTeamListField;

        private SalesOrderPartnersList partnersListField;

        private GiftCertRedemptionList giftCertRedemptionListField;

        private PromotionsList promotionsListField;

        private SalesOrderItemList itemListField;

        private SalesOrderShipGroupList shipGroupListField;

        private AccountingBookDetailList accountingBookDetailListField;

        private TaxDetailsList taxDetailsListField;

        private CustomFieldRef[] customFieldListField;

        private string internalIdField;

        private string externalIdField;

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
        public RecordRef customForm {
            get {
                return this.customFormField;
            }
            set {
                this.customFormField = value;
            }
        }

        /// <remarks/>
        public RecordRef entity {
            get {
                return this.entityField;
            }
            set {
                this.entityField = value;
            }
        }

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
        public RecordRef currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        public RecordRef drAccount {
            get {
                return this.drAccountField;
            }
            set {
                this.drAccountField = value;
            }
        }

        /// <remarks/>
        public RecordRef fxAccount {
            get {
                return this.fxAccountField;
            }
            set {
                this.fxAccountField = value;
            }
        }

        /// <remarks/>
        public System.DateTime tranDate {
            get {
                return this.tranDateField;
            }
            set {
                this.tranDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tranDateSpecified {
            get {
                return this.tranDateFieldSpecified;
            }
            set {
                this.tranDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string tranId {
            get {
                return this.tranIdField;
            }
            set {
                this.tranIdField = value;
            }
        }

        /// <remarks/>
        public RecordRef entityTaxRegNum {
            get {
                return this.entityTaxRegNumField;
            }
            set {
                this.entityTaxRegNumField = value;
            }
        }

        /// <remarks/>
        public string source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
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
        public SalesOrderOrderStatus orderStatus {
            get {
                return this.orderStatusField;
            }
            set {
                this.orderStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool orderStatusSpecified {
            get {
                return this.orderStatusFieldSpecified;
            }
            set {
                this.orderStatusFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime nextBill {
            get {
                return this.nextBillField;
            }
            set {
                this.nextBillField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nextBillSpecified {
            get {
                return this.nextBillFieldSpecified;
            }
            set {
                this.nextBillFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef opportunity {
            get {
                return this.opportunityField;
            }
            set {
                this.opportunityField = value;
            }
        }

        /// <remarks/>
        public RecordRef salesRep {
            get {
                return this.salesRepField;
            }
            set {
                this.salesRepField = value;
            }
        }

        /// <remarks/>
        public string contribPct {
            get {
                return this.contribPctField;
            }
            set {
                this.contribPctField = value;
            }
        }

        /// <remarks/>
        public RecordRef partner {
            get {
                return this.partnerField;
            }
            set {
                this.partnerField = value;
            }
        }

        /// <remarks/>
        public RecordRef salesGroup {
            get {
                return this.salesGroupField;
            }
            set {
                this.salesGroupField = value;
            }
        }

        /// <remarks/>
        public bool syncSalesTeams {
            get {
                return this.syncSalesTeamsField;
            }
            set {
                this.syncSalesTeamsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool syncSalesTeamsSpecified {
            get {
                return this.syncSalesTeamsFieldSpecified;
            }
            set {
                this.syncSalesTeamsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef leadSource {
            get {
                return this.leadSourceField;
            }
            set {
                this.leadSourceField = value;
            }
        }

        /// <remarks/>
        public System.DateTime startDate {
            get {
                return this.startDateField;
            }
            set {
                this.startDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool startDateSpecified {
            get {
                return this.startDateFieldSpecified;
            }
            set {
                this.startDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime endDate {
            get {
                return this.endDateField;
            }
            set {
                this.endDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool endDateSpecified {
            get {
                return this.endDateFieldSpecified;
            }
            set {
                this.endDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string otherRefNum {
            get {
                return this.otherRefNumField;
            }
            set {
                this.otherRefNumField = value;
            }
        }

        /// <remarks/>
        public string memo {
            get {
                return this.memoField;
            }
            set {
                this.memoField = value;
            }
        }

        /// <remarks/>
        public System.DateTime salesEffectiveDate {
            get {
                return this.salesEffectiveDateField;
            }
            set {
                this.salesEffectiveDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool salesEffectiveDateSpecified {
            get {
                return this.salesEffectiveDateFieldSpecified;
            }
            set {
                this.salesEffectiveDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool excludeCommission {
            get {
                return this.excludeCommissionField;
            }
            set {
                this.excludeCommissionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool excludeCommissionSpecified {
            get {
                return this.excludeCommissionFieldSpecified;
            }
            set {
                this.excludeCommissionFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double totalCostEstimate {
            get {
                return this.totalCostEstimateField;
            }
            set {
                this.totalCostEstimateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totalCostEstimateSpecified {
            get {
                return this.totalCostEstimateFieldSpecified;
            }
            set {
                this.totalCostEstimateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double estGrossProfit {
            get {
                return this.estGrossProfitField;
            }
            set {
                this.estGrossProfitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool estGrossProfitSpecified {
            get {
                return this.estGrossProfitFieldSpecified;
            }
            set {
                this.estGrossProfitFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double estGrossProfitPercent {
            get {
                return this.estGrossProfitPercentField;
            }
            set {
                this.estGrossProfitPercentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool estGrossProfitPercentSpecified {
            get {
                return this.estGrossProfitPercentFieldSpecified;
            }
            set {
                this.estGrossProfitPercentFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double exchangeRate {
            get {
                return this.exchangeRateField;
            }
            set {
                this.exchangeRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool exchangeRateSpecified {
            get {
                return this.exchangeRateFieldSpecified;
            }
            set {
                this.exchangeRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef promoCode {
            get {
                return this.promoCodeField;
            }
            set {
                this.promoCodeField = value;
            }
        }

        /// <remarks/>
        public string currencyName {
            get {
                return this.currencyNameField;
            }
            set {
                this.currencyNameField = value;
            }
        }

        /// <remarks/>
        public RecordRef discountItem {
            get {
                return this.discountItemField;
            }
            set {
                this.discountItemField = value;
            }
        }

        /// <remarks/>
        public string discountRate {
            get {
                return this.discountRateField;
            }
            set {
                this.discountRateField = value;
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
        public RecordRef taxItem {
            get {
                return this.taxItemField;
            }
            set {
                this.taxItemField = value;
            }
        }

        /// <remarks/>
        public double taxRate {
            get {
                return this.taxRateField;
            }
            set {
                this.taxRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxRateSpecified {
            get {
                return this.taxRateFieldSpecified;
            }
            set {
                this.taxRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool toBePrinted {
            get {
                return this.toBePrintedField;
            }
            set {
                this.toBePrintedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool toBePrintedSpecified {
            get {
                return this.toBePrintedFieldSpecified;
            }
            set {
                this.toBePrintedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool toBeEmailed {
            get {
                return this.toBeEmailedField;
            }
            set {
                this.toBeEmailedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool toBeEmailedSpecified {
            get {
                return this.toBeEmailedFieldSpecified;
            }
            set {
                this.toBeEmailedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }

        /// <remarks/>
        public bool toBeFaxed {
            get {
                return this.toBeFaxedField;
            }
            set {
                this.toBeFaxedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool toBeFaxedSpecified {
            get {
                return this.toBeFaxedFieldSpecified;
            }
            set {
                this.toBeFaxedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string fax {
            get {
                return this.faxField;
            }
            set {
                this.faxField = value;
            }
        }

        /// <remarks/>
        public RecordRef messageSel {
            get {
                return this.messageSelField;
            }
            set {
                this.messageSelField = value;
            }
        }

        /// <remarks/>
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }

        /// <remarks/>
        public RecordRef paymentOption {
            get {
                return this.paymentOptionField;
            }
            set {
                this.paymentOptionField = value;
            }
        }

        /// <remarks/>
        public string inputAuthCode {
            get {
                return this.inputAuthCodeField;
            }
            set {
                this.inputAuthCodeField = value;
            }
        }

        /// <remarks/>
        public string inputReferenceCode {
            get {
                return this.inputReferenceCodeField;
            }
            set {
                this.inputReferenceCodeField = value;
            }
        }

        /// <remarks/>
        public string checkNumber {
            get {
                return this.checkNumberField;
            }
            set {
                this.checkNumberField = value;
            }
        }

        /// <remarks/>
        public string paymentCardCsc {
            get {
                return this.paymentCardCscField;
            }
            set {
                this.paymentCardCscField = value;
            }
        }

        /// <remarks/>
        public RecordRef paymentProcessingProfile {
            get {
                return this.paymentProcessingProfileField;
            }
            set {
                this.paymentProcessingProfileField = value;
            }
        }

        /// <remarks/>
        public SalesOrderHandlingMode handlingMode {
            get {
                return this.handlingModeField;
            }
            set {
                this.handlingModeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool handlingModeSpecified {
            get {
                return this.handlingModeFieldSpecified;
            }
            set {
                this.handlingModeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string outputAuthCode {
            get {
                return this.outputAuthCodeField;
            }
            set {
                this.outputAuthCodeField = value;
            }
        }

        /// <remarks/>
        public string outputReferenceCode {
            get {
                return this.outputReferenceCodeField;
            }
            set {
                this.outputReferenceCodeField = value;
            }
        }

        /// <remarks/>
        public SalesOrderPaymentOperation paymentOperation {
            get {
                return this.paymentOperationField;
            }
            set {
                this.paymentOperationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool paymentOperationSpecified {
            get {
                return this.paymentOperationFieldSpecified;
            }
            set {
                this.paymentOperationFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string dynamicDescriptor {
            get {
                return this.dynamicDescriptorField;
            }
            set {
                this.dynamicDescriptorField = value;
            }
        }

        /// <remarks/>
        public Address billingAddress {
            get {
                return this.billingAddressField;
            }
            set {
                this.billingAddressField = value;
            }
        }

        /// <remarks/>
        public RecordRef billAddressList {
            get {
                return this.billAddressListField;
            }
            set {
                this.billAddressListField = value;
            }
        }

        /// <remarks/>
        public Address shippingAddress {
            get {
                return this.shippingAddressField;
            }
            set {
                this.shippingAddressField = value;
            }
        }

        /// <remarks/>
        public bool shipIsResidential {
            get {
                return this.shipIsResidentialField;
            }
            set {
                this.shipIsResidentialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shipIsResidentialSpecified {
            get {
                return this.shipIsResidentialFieldSpecified;
            }
            set {
                this.shipIsResidentialFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef shipAddressList {
            get {
                return this.shipAddressListField;
            }
            set {
                this.shipAddressListField = value;
            }
        }

        /// <remarks/>
        public string fob {
            get {
                return this.fobField;
            }
            set {
                this.fobField = value;
            }
        }

        /// <remarks/>
        public System.DateTime shipDate {
            get {
                return this.shipDateField;
            }
            set {
                this.shipDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shipDateSpecified {
            get {
                return this.shipDateFieldSpecified;
            }
            set {
                this.shipDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime actualShipDate {
            get {
                return this.actualShipDateField;
            }
            set {
                this.actualShipDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool actualShipDateSpecified {
            get {
                return this.actualShipDateFieldSpecified;
            }
            set {
                this.actualShipDateFieldSpecified = value;
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
        public double shippingCost {
            get {
                return this.shippingCostField;
            }
            set {
                this.shippingCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shippingCostSpecified {
            get {
                return this.shippingCostFieldSpecified;
            }
            set {
                this.shippingCostFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double shippingTax1Rate {
            get {
                return this.shippingTax1RateField;
            }
            set {
                this.shippingTax1RateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shippingTax1RateSpecified {
            get {
                return this.shippingTax1RateFieldSpecified;
            }
            set {
                this.shippingTax1RateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isMultiShipTo {
            get {
                return this.isMultiShipToField;
            }
            set {
                this.isMultiShipToField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isMultiShipToSpecified {
            get {
                return this.isMultiShipToFieldSpecified;
            }
            set {
                this.isMultiShipToFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string shippingTax2Rate {
            get {
                return this.shippingTax2RateField;
            }
            set {
                this.shippingTax2RateField = value;
            }
        }

        /// <remarks/>
        public RecordRef shippingTaxCode {
            get {
                return this.shippingTaxCodeField;
            }
            set {
                this.shippingTaxCodeField = value;
            }
        }

        /// <remarks/>
        public RecordRef handlingTaxCode {
            get {
                return this.handlingTaxCodeField;
            }
            set {
                this.handlingTaxCodeField = value;
            }
        }

        /// <remarks/>
        public double handlingTax1Rate {
            get {
                return this.handlingTax1RateField;
            }
            set {
                this.handlingTax1RateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool handlingTax1RateSpecified {
            get {
                return this.handlingTax1RateFieldSpecified;
            }
            set {
                this.handlingTax1RateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string handlingTax2Rate {
            get {
                return this.handlingTax2RateField;
            }
            set {
                this.handlingTax2RateField = value;
            }
        }

        /// <remarks/>
        public double handlingCost {
            get {
                return this.handlingCostField;
            }
            set {
                this.handlingCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool handlingCostSpecified {
            get {
                return this.handlingCostFieldSpecified;
            }
            set {
                this.handlingCostFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string trackingNumbers {
            get {
                return this.trackingNumbersField;
            }
            set {
                this.trackingNumbersField = value;
            }
        }

        /// <remarks/>
        public string linkedTrackingNumbers {
            get {
                return this.linkedTrackingNumbersField;
            }
            set {
                this.linkedTrackingNumbersField = value;
            }
        }

        /// <remarks/>
        public bool shipComplete {
            get {
                return this.shipCompleteField;
            }
            set {
                this.shipCompleteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shipCompleteSpecified {
            get {
                return this.shipCompleteFieldSpecified;
            }
            set {
                this.shipCompleteFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef paymentMethod {
            get {
                return this.paymentMethodField;
            }
            set {
                this.paymentMethodField = value;
            }
        }

        /// <remarks/>
        public string shopperIpAddress {
            get {
                return this.shopperIpAddressField;
            }
            set {
                this.shopperIpAddressField = value;
            }
        }

        /// <remarks/>
        public bool saveOnAuthDecline {
            get {
                return this.saveOnAuthDeclineField;
            }
            set {
                this.saveOnAuthDeclineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool saveOnAuthDeclineSpecified {
            get {
                return this.saveOnAuthDeclineFieldSpecified;
            }
            set {
                this.saveOnAuthDeclineFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool canHaveStackable {
            get {
                return this.canHaveStackableField;
            }
            set {
                this.canHaveStackableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool canHaveStackableSpecified {
            get {
                return this.canHaveStackableFieldSpecified;
            }
            set {
                this.canHaveStackableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef creditCard {
            get {
                return this.creditCardField;
            }
            set {
                this.creditCardField = value;
            }
        }

        /// <remarks/>
        public RevenueStatus revenueStatus {
            get {
                return this.revenueStatusField;
            }
            set {
                this.revenueStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool revenueStatusSpecified {
            get {
                return this.revenueStatusFieldSpecified;
            }
            set {
                this.revenueStatusFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double recognizedRevenue {
            get {
                return this.recognizedRevenueField;
            }
            set {
                this.recognizedRevenueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool recognizedRevenueSpecified {
            get {
                return this.recognizedRevenueFieldSpecified;
            }
            set {
                this.recognizedRevenueFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double deferredRevenue {
            get {
                return this.deferredRevenueField;
            }
            set {
                this.deferredRevenueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool deferredRevenueSpecified {
            get {
                return this.deferredRevenueFieldSpecified;
            }
            set {
                this.deferredRevenueFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool revRecOnRevCommitment {
            get {
                return this.revRecOnRevCommitmentField;
            }
            set {
                this.revRecOnRevCommitmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool revRecOnRevCommitmentSpecified {
            get {
                return this.revRecOnRevCommitmentFieldSpecified;
            }
            set {
                this.revRecOnRevCommitmentFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RevenueCommitStatus revCommitStatus {
            get {
                return this.revCommitStatusField;
            }
            set {
                this.revCommitStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool revCommitStatusSpecified {
            get {
                return this.revCommitStatusFieldSpecified;
            }
            set {
                this.revCommitStatusFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string ccNumber {
            get {
                return this.ccNumberField;
            }
            set {
                this.ccNumberField = value;
            }
        }

        /// <remarks/>
        public System.DateTime ccExpireDate {
            get {
                return this.ccExpireDateField;
            }
            set {
                this.ccExpireDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ccExpireDateSpecified {
            get {
                return this.ccExpireDateFieldSpecified;
            }
            set {
                this.ccExpireDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string ccName {
            get {
                return this.ccNameField;
            }
            set {
                this.ccNameField = value;
            }
        }

        /// <remarks/>
        public string ccStreet {
            get {
                return this.ccStreetField;
            }
            set {
                this.ccStreetField = value;
            }
        }

        /// <remarks/>
        public string ccZipCode {
            get {
                return this.ccZipCodeField;
            }
            set {
                this.ccZipCodeField = value;
            }
        }

        /// <remarks/>
        public string payPalStatus {
            get {
                return this.payPalStatusField;
            }
            set {
                this.payPalStatusField = value;
            }
        }

        /// <remarks/>
        public RecordRef creditCardProcessor {
            get {
                return this.creditCardProcessorField;
            }
            set {
                this.creditCardProcessorField = value;
            }
        }

        /// <remarks/>
        public string payPalTranId {
            get {
                return this.payPalTranIdField;
            }
            set {
                this.payPalTranIdField = value;
            }
        }

        /// <remarks/>
        public bool ccApproved {
            get {
                return this.ccApprovedField;
            }
            set {
                this.ccApprovedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ccApprovedSpecified {
            get {
                return this.ccApprovedFieldSpecified;
            }
            set {
                this.ccApprovedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool getAuth {
            get {
                return this.getAuthField;
            }
            set {
                this.getAuthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool getAuthSpecified {
            get {
                return this.getAuthFieldSpecified;
            }
            set {
                this.getAuthFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string authCode {
            get {
                return this.authCodeField;
            }
            set {
                this.authCodeField = value;
            }
        }

        /// <remarks/>
        public AvsMatchCode ccAvsStreetMatch {
            get {
                return this.ccAvsStreetMatchField;
            }
            set {
                this.ccAvsStreetMatchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ccAvsStreetMatchSpecified {
            get {
                return this.ccAvsStreetMatchFieldSpecified;
            }
            set {
                this.ccAvsStreetMatchFieldSpecified = value;
            }
        }

        /// <remarks/>
        public AvsMatchCode ccAvsZipMatch {
            get {
                return this.ccAvsZipMatchField;
            }
            set {
                this.ccAvsZipMatchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ccAvsZipMatchSpecified {
            get {
                return this.ccAvsZipMatchFieldSpecified;
            }
            set {
                this.ccAvsZipMatchFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isRecurringPayment {
            get {
                return this.isRecurringPaymentField;
            }
            set {
                this.isRecurringPaymentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isRecurringPaymentSpecified {
            get {
                return this.isRecurringPaymentFieldSpecified;
            }
            set {
                this.isRecurringPaymentFieldSpecified = value;
            }
        }

        /// <remarks/>
        public AvsMatchCode ccSecurityCodeMatch {
            get {
                return this.ccSecurityCodeMatchField;
            }
            set {
                this.ccSecurityCodeMatchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ccSecurityCodeMatchSpecified {
            get {
                return this.ccSecurityCodeMatchFieldSpecified;
            }
            set {
                this.ccSecurityCodeMatchFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double altSalesTotal {
            get {
                return this.altSalesTotalField;
            }
            set {
                this.altSalesTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool altSalesTotalSpecified {
            get {
                return this.altSalesTotalFieldSpecified;
            }
            set {
                this.altSalesTotalFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool ignoreAvs {
            get {
                return this.ignoreAvsField;
            }
            set {
                this.ignoreAvsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ignoreAvsSpecified {
            get {
                return this.ignoreAvsFieldSpecified;
            }
            set {
                this.ignoreAvsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public TransactionPaymentEventResult paymentEventResult {
            get {
                return this.paymentEventResultField;
            }
            set {
                this.paymentEventResultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool paymentEventResultSpecified {
            get {
                return this.paymentEventResultFieldSpecified;
            }
            set {
                this.paymentEventResultFieldSpecified = value;
            }
        }

        /// <remarks/>
        public TransactionPaymentEventHoldReason paymentEventHoldReason {
            get {
                return this.paymentEventHoldReasonField;
            }
            set {
                this.paymentEventHoldReasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool paymentEventHoldReasonSpecified {
            get {
                return this.paymentEventHoldReasonFieldSpecified;
            }
            set {
                this.paymentEventHoldReasonFieldSpecified = value;
            }
        }

        /// <remarks/>
        public TransactionPaymentEventType paymentEventType {
            get {
                return this.paymentEventTypeField;
            }
            set {
                this.paymentEventTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool paymentEventTypeSpecified {
            get {
                return this.paymentEventTypeFieldSpecified;
            }
            set {
                this.paymentEventTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime paymentEventDate {
            get {
                return this.paymentEventDateField;
            }
            set {
                this.paymentEventDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool paymentEventDateSpecified {
            get {
                return this.paymentEventDateFieldSpecified;
            }
            set {
                this.paymentEventDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string paymentEventUpdatedBy {
            get {
                return this.paymentEventUpdatedByField;
            }
            set {
                this.paymentEventUpdatedByField = value;
            }
        }

        /// <remarks/>
        public double subTotal {
            get {
                return this.subTotalField;
            }
            set {
                this.subTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool subTotalSpecified {
            get {
                return this.subTotalFieldSpecified;
            }
            set {
                this.subTotalFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double discountTotal {
            get {
                return this.discountTotalField;
            }
            set {
                this.discountTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool discountTotalSpecified {
            get {
                return this.discountTotalFieldSpecified;
            }
            set {
                this.discountTotalFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double taxTotal {
            get {
                return this.taxTotalField;
            }
            set {
                this.taxTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxTotalSpecified {
            get {
                return this.taxTotalFieldSpecified;
            }
            set {
                this.taxTotalFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double altShippingCost {
            get {
                return this.altShippingCostField;
            }
            set {
                this.altShippingCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool altShippingCostSpecified {
            get {
                return this.altShippingCostFieldSpecified;
            }
            set {
                this.altShippingCostFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double altHandlingCost {
            get {
                return this.altHandlingCostField;
            }
            set {
                this.altHandlingCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool altHandlingCostSpecified {
            get {
                return this.altHandlingCostFieldSpecified;
            }
            set {
                this.altHandlingCostFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double total {
            get {
                return this.totalField;
            }
            set {
                this.totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totalSpecified {
            get {
                return this.totalFieldSpecified;
            }
            set {
                this.totalFieldSpecified = value;
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
        public string paypalAuthId {
            get {
                return this.paypalAuthIdField;
            }
            set {
                this.paypalAuthIdField = value;
            }
        }

        /// <remarks/>
        public double balance {
            get {
                return this.balanceField;
            }
            set {
                this.balanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool balanceSpecified {
            get {
                return this.balanceFieldSpecified;
            }
            set {
                this.balanceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool paypalProcess {
            get {
                return this.paypalProcessField;
            }
            set {
                this.paypalProcessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool paypalProcessSpecified {
            get {
                return this.paypalProcessFieldSpecified;
            }
            set {
                this.paypalProcessFieldSpecified = value;
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
        public string ccSecurityCode {
            get {
                return this.ccSecurityCodeField;
            }
            set {
                this.ccSecurityCodeField = value;
            }
        }

        /// <remarks/>
        public string threeDStatusCode {
            get {
                return this.threeDStatusCodeField;
            }
            set {
                this.threeDStatusCodeField = value;
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
        public RecordRef subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
            }
        }

        /// <remarks/>
        public RecordRef intercoTransaction {
            get {
                return this.intercoTransactionField;
            }
            set {
                this.intercoTransactionField = value;
            }
        }

        /// <remarks/>
        public IntercoStatus intercoStatus {
            get {
                return this.intercoStatusField;
            }
            set {
                this.intercoStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool intercoStatusSpecified {
            get {
                return this.intercoStatusFieldSpecified;
            }
            set {
                this.intercoStatusFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string debitCardIssueNo {
            get {
                return this.debitCardIssueNoField;
            }
            set {
                this.debitCardIssueNoField = value;
            }
        }

        /// <remarks/>
        public System.DateTime lastModifiedDate {
            get {
                return this.lastModifiedDateField;
            }
            set {
                this.lastModifiedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lastModifiedDateSpecified {
            get {
                return this.lastModifiedDateFieldSpecified;
            }
            set {
                this.lastModifiedDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef nexus {
            get {
                return this.nexusField;
            }
            set {
                this.nexusField = value;
            }
        }

        /// <remarks/>
        public RecordRef subsidiaryTaxRegNum {
            get {
                return this.subsidiaryTaxRegNumField;
            }
            set {
                this.subsidiaryTaxRegNumField = value;
            }
        }

        /// <remarks/>
        public bool taxRegOverride {
            get {
                return this.taxRegOverrideField;
            }
            set {
                this.taxRegOverrideField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxRegOverrideSpecified {
            get {
                return this.taxRegOverrideFieldSpecified;
            }
            set {
                this.taxRegOverrideFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime taxPointDate {
            get {
                return this.taxPointDateField;
            }
            set {
                this.taxPointDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxPointDateSpecified {
            get {
                return this.taxPointDateFieldSpecified;
            }
            set {
                this.taxPointDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool taxDetailsOverride {
            get {
                return this.taxDetailsOverrideField;
            }
            set {
                this.taxDetailsOverrideField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxDetailsOverrideSpecified {
            get {
                return this.taxDetailsOverrideFieldSpecified;
            }
            set {
                this.taxDetailsOverrideFieldSpecified = value;
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
        public string pnRefNum {
            get {
                return this.pnRefNumField;
            }
            set {
                this.pnRefNumField = value;
            }
        }

        /// <remarks/>
        public string status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }

        /// <remarks/>
        public double tax2Total {
            get {
                return this.tax2TotalField;
            }
            set {
                this.tax2TotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tax2TotalSpecified {
            get {
                return this.tax2TotalFieldSpecified;
            }
            set {
                this.tax2TotalFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef terms {
            get {
                return this.termsField;
            }
            set {
                this.termsField = value;
            }
        }

        /// <remarks/>
        public System.DateTime validFrom {
            get {
                return this.validFromField;
            }
            set {
                this.validFromField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool validFromSpecified {
            get {
                return this.validFromFieldSpecified;
            }
            set {
                this.validFromFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string vatRegNum {
            get {
                return this.vatRegNumField;
            }
            set {
                this.vatRegNumField = value;
            }
        }

        /// <remarks/>
        public double giftCertApplied {
            get {
                return this.giftCertAppliedField;
            }
            set {
                this.giftCertAppliedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool giftCertAppliedSpecified {
            get {
                return this.giftCertAppliedFieldSpecified;
            }
            set {
                this.giftCertAppliedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double oneTime {
            get {
                return this.oneTimeField;
            }
            set {
                this.oneTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool oneTimeSpecified {
            get {
                return this.oneTimeFieldSpecified;
            }
            set {
                this.oneTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double recurWeekly {
            get {
                return this.recurWeeklyField;
            }
            set {
                this.recurWeeklyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool recurWeeklySpecified {
            get {
                return this.recurWeeklyFieldSpecified;
            }
            set {
                this.recurWeeklyFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double recurMonthly {
            get {
                return this.recurMonthlyField;
            }
            set {
                this.recurMonthlyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool recurMonthlySpecified {
            get {
                return this.recurMonthlyFieldSpecified;
            }
            set {
                this.recurMonthlyFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double recurQuarterly {
            get {
                return this.recurQuarterlyField;
            }
            set {
                this.recurQuarterlyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool recurQuarterlySpecified {
            get {
                return this.recurQuarterlyFieldSpecified;
            }
            set {
                this.recurQuarterlyFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double recurAnnually {
            get {
                return this.recurAnnuallyField;
            }
            set {
                this.recurAnnuallyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool recurAnnuallySpecified {
            get {
                return this.recurAnnuallyFieldSpecified;
            }
            set {
                this.recurAnnuallyFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool tranIsVsoeBundle {
            get {
                return this.tranIsVsoeBundleField;
            }
            set {
                this.tranIsVsoeBundleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tranIsVsoeBundleSpecified {
            get {
                return this.tranIsVsoeBundleFieldSpecified;
            }
            set {
                this.tranIsVsoeBundleFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool vsoeAutoCalc {
            get {
                return this.vsoeAutoCalcField;
            }
            set {
                this.vsoeAutoCalcField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool vsoeAutoCalcSpecified {
            get {
                return this.vsoeAutoCalcFieldSpecified;
            }
            set {
                this.vsoeAutoCalcFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool syncPartnerTeams {
            get {
                return this.syncPartnerTeamsField;
            }
            set {
                this.syncPartnerTeamsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool syncPartnerTeamsSpecified {
            get {
                return this.syncPartnerTeamsFieldSpecified;
            }
            set {
                this.syncPartnerTeamsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public SalesOrderSalesTeamList salesTeamList {
            get {
                return this.salesTeamListField;
            }
            set {
                this.salesTeamListField = value;
            }
        }

        /// <remarks/>
        public SalesOrderPartnersList partnersList {
            get {
                return this.partnersListField;
            }
            set {
                this.partnersListField = value;
            }
        }

        /// <remarks/>
        public GiftCertRedemptionList giftCertRedemptionList {
            get {
                return this.giftCertRedemptionListField;
            }
            set {
                this.giftCertRedemptionListField = value;
            }
        }

        /// <remarks/>
        public PromotionsList promotionsList {
            get {
                return this.promotionsListField;
            }
            set {
                this.promotionsListField = value;
            }
        }

        /// <remarks/>
        public SalesOrderItemList itemList {
            get {
                return this.itemListField;
            }
            set {
                this.itemListField = value;
            }
        }

        /// <remarks/>
        public SalesOrderShipGroupList shipGroupList {
            get {
                return this.shipGroupListField;
            }
            set {
                this.shipGroupListField = value;
            }
        }

        /// <remarks/>
        public AccountingBookDetailList accountingBookDetailList {
            get {
                return this.accountingBookDetailListField;
            }
            set {
                this.accountingBookDetailListField = value;
            }
        }

        /// <remarks/>
        public TaxDetailsList taxDetailsList {
            get {
                return this.taxDetailsListField;
            }
            set {
                this.taxDetailsListField = value;
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