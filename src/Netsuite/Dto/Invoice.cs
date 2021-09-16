namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sales_2021_1.transactions.webservices.netsuite.com")]
    public partial class Invoice : Record {

        private System.DateTime createdDateField;

        private bool createdDateFieldSpecified;

        private System.DateTime lastModifiedDateField;

        private bool lastModifiedDateFieldSpecified;

        private RecordRef nexusField;

        private RecordRef subsidiaryTaxRegNumField;

        private bool taxRegOverrideField;

        private bool taxRegOverrideFieldSpecified;

        private bool taxDetailsOverrideField;

        private bool taxDetailsOverrideFieldSpecified;

        private RecordRef customFormField;

        private RecordRef nextApproverField;

        private RecordRef entityField;

        private RecordRef billingAccountField;

        private bool recurringBillField;

        private bool recurringBillFieldSpecified;

        private System.DateTime tranDateField;

        private bool tranDateFieldSpecified;

        private string tranIdField;

        private RecordRef entityTaxRegNumField;

        private System.DateTime taxPointDateField;

        private bool taxPointDateFieldSpecified;

        private string sourceField;

        private RecordRef createdFromField;

        private RecordRef postingPeriodField;

        private RecordRef opportunityField;

        private RecordRef departmentField;

        private RecordRef classField;

        private RecordRef termsField;

        private RecordRef locationField;

        private RecordRef subsidiaryField;

        private RecordRef currencyField;

        private System.DateTime dueDateField;

        private bool dueDateFieldSpecified;

        private System.DateTime discountDateField;

        private bool discountDateFieldSpecified;

        private double discountAmountField;

        private bool discountAmountFieldSpecified;

        private RecordRef salesRepField;

        private string contribPctField;

        private RecordRef partnerField;

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

        private RecordRef revRecScheduleField;

        private System.DateTime revRecStartDateField;

        private bool revRecStartDateFieldSpecified;

        private System.DateTime revRecEndDateField;

        private bool revRecEndDateFieldSpecified;

        private double amountPaidField;

        private bool amountPaidFieldSpecified;

        private double amountRemainingField;

        private bool amountRemainingFieldSpecified;

        private double balanceField;

        private bool balanceFieldSpecified;

        private RecordRef accountField;

        private string onCreditHoldField;

        private double exchangeRateField;

        private bool exchangeRateFieldSpecified;

        private string currencyNameField;

        private RecordRef promoCodeField;

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

        private bool toBeFaxedField;

        private bool toBeFaxedFieldSpecified;

        private string faxField;

        private RecordRef messageSelField;

        private string messageField;

        private Address billingAddressField;

        private RecordRef billAddressListField;

        private Address shippingAddressField;

        private bool shipIsResidentialField;

        private bool shipIsResidentialFieldSpecified;

        private RecordRef shipAddressListField;

        private string fobField;

        private System.DateTime shipDateField;

        private bool shipDateFieldSpecified;

        private RecordRef shipMethodField;

        private double shippingCostField;

        private bool shippingCostFieldSpecified;

        private double shippingTax1RateField;

        private bool shippingTax1RateFieldSpecified;

        private string shippingTax2RateField;

        private RecordRef shippingTaxCodeField;

        private RecordRef handlingTaxCodeField;

        private double handlingTax1RateField;

        private bool handlingTax1RateFieldSpecified;

        private double handlingCostField;

        private bool handlingCostFieldSpecified;

        private string handlingTax2RateField;

        private string trackingNumbersField;

        private string linkedTrackingNumbersField;

        private RecordRef salesGroupField;

        private double subTotalField;

        private bool subTotalFieldSpecified;

        private bool canHaveStackableField;

        private bool canHaveStackableFieldSpecified;

        private RevenueStatus revenueStatusField;

        private bool revenueStatusFieldSpecified;

        private double recognizedRevenueField;

        private bool recognizedRevenueFieldSpecified;

        private double deferredRevenueField;

        private bool deferredRevenueFieldSpecified;

        private bool revRecOnRevCommitmentField;

        private bool revRecOnRevCommitmentFieldSpecified;

        private bool syncSalesTeamsField;

        private bool syncSalesTeamsFieldSpecified;

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

        private string statusField;

        private RecordRef jobField;

        private RecordRef billingScheduleField;

        private string emailField;

        private double tax2TotalField;

        private bool tax2TotalFieldSpecified;

        private string vatRegNumField;

        private RecordRef expCostDiscountField;

        private RecordRef itemCostDiscountField;

        private RecordRef timeDiscountField;

        private string expCostDiscRateField;

        private string itemCostDiscRateField;

        private string timeDiscRateField;

        private double expCostDiscAmountField;

        private bool expCostDiscAmountFieldSpecified;

        private double expCostTaxRate1Field;

        private bool expCostTaxRate1FieldSpecified;

        private double expCostTaxRate2Field;

        private bool expCostTaxRate2FieldSpecified;

        private double itemCostDiscAmountField;

        private bool itemCostDiscAmountFieldSpecified;

        private RecordRef expCostTaxCodeField;

        private double expCostDiscTax1AmtField;

        private bool expCostDiscTax1AmtFieldSpecified;

        private double itemCostTaxRate1Field;

        private bool itemCostTaxRate1FieldSpecified;

        private double timeDiscAmountField;

        private bool timeDiscAmountFieldSpecified;

        private RecordRef itemCostTaxCodeField;

        private bool expCostDiscTaxableField;

        private bool expCostDiscTaxableFieldSpecified;

        private bool itemCostDiscTaxableField;

        private bool itemCostDiscTaxableFieldSpecified;

        private double itemCostTaxRate2Field;

        private bool itemCostTaxRate2FieldSpecified;

        private double itemCostDiscTax1AmtField;

        private bool itemCostDiscTax1AmtFieldSpecified;

        private bool itemCostDiscPrintField;

        private bool itemCostDiscPrintFieldSpecified;

        private bool timeDiscTaxableField;

        private bool timeDiscTaxableFieldSpecified;

        private double timeTaxRate1Field;

        private bool timeTaxRate1FieldSpecified;

        private bool expCostDiscPrintField;

        private bool expCostDiscPrintFieldSpecified;

        private RecordRef timeTaxCodeField;

        private bool timeDiscPrintField;

        private bool timeDiscPrintFieldSpecified;

        private double giftCertAppliedField;

        private bool giftCertAppliedFieldSpecified;

        private double timeDiscTax1AmtField;

        private bool timeDiscTax1AmtFieldSpecified;

        private bool tranIsVsoeBundleField;

        private bool tranIsVsoeBundleFieldSpecified;

        private double timeTaxRate2Field;

        private bool timeTaxRate2FieldSpecified;

        private bool vsoeAutoCalcField;

        private bool vsoeAutoCalcFieldSpecified;

        private bool syncPartnerTeamsField;

        private bool syncPartnerTeamsFieldSpecified;

        private InvoiceSalesTeamList salesTeamListField;

        private InvoicePartnersList partnersListField;

        private InvoiceItemList itemListField;

        private InvoiceItemCostList itemCostListField;

        private GiftCertRedemptionList giftCertRedemptionListField;

        private PromotionsList promotionsListField;

        private InvoiceExpCostList expCostListField;

        private InvoiceTimeList timeListField;

        private InvoiceShipGroupList shipGroupListField;

        private RecordRef approvalStatusField;

        private AccountingBookDetailList accountingBookDetailListField;

        private TaxDetailsList taxDetailsListField;

        private InstallmentList installmentListField;

        private bool overrideInstallmentsField;

        private bool overrideInstallmentsFieldSpecified;

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
        public RecordRef customForm {
            get {
                return this.customFormField;
            }
            set {
                this.customFormField = value;
            }
        }

        /// <remarks/>
        public RecordRef nextApprover {
            get {
                return this.nextApproverField;
            }
            set {
                this.nextApproverField = value;
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
        public RecordRef billingAccount {
            get {
                return this.billingAccountField;
            }
            set {
                this.billingAccountField = value;
            }
        }

        /// <remarks/>
        public bool recurringBill {
            get {
                return this.recurringBillField;
            }
            set {
                this.recurringBillField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool recurringBillSpecified {
            get {
                return this.recurringBillFieldSpecified;
            }
            set {
                this.recurringBillFieldSpecified = value;
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
        public RecordRef postingPeriod {
            get {
                return this.postingPeriodField;
            }
            set {
                this.postingPeriodField = value;
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
        public RecordRef terms {
            get {
                return this.termsField;
            }
            set {
                this.termsField = value;
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
        public RecordRef subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
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
        public System.DateTime dueDate {
            get {
                return this.dueDateField;
            }
            set {
                this.dueDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dueDateSpecified {
            get {
                return this.dueDateFieldSpecified;
            }
            set {
                this.dueDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime discountDate {
            get {
                return this.discountDateField;
            }
            set {
                this.discountDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool discountDateSpecified {
            get {
                return this.discountDateFieldSpecified;
            }
            set {
                this.discountDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double discountAmount {
            get {
                return this.discountAmountField;
            }
            set {
                this.discountAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool discountAmountSpecified {
            get {
                return this.discountAmountFieldSpecified;
            }
            set {
                this.discountAmountFieldSpecified = value;
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
        public double amountPaid {
            get {
                return this.amountPaidField;
            }
            set {
                this.amountPaidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool amountPaidSpecified {
            get {
                return this.amountPaidFieldSpecified;
            }
            set {
                this.amountPaidFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double amountRemaining {
            get {
                return this.amountRemainingField;
            }
            set {
                this.amountRemainingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool amountRemainingSpecified {
            get {
                return this.amountRemainingFieldSpecified;
            }
            set {
                this.amountRemainingFieldSpecified = value;
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
        public RecordRef account {
            get {
                return this.accountField;
            }
            set {
                this.accountField = value;
            }
        }

        /// <remarks/>
        public string onCreditHold {
            get {
                return this.onCreditHoldField;
            }
            set {
                this.onCreditHoldField = value;
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
        public string currencyName {
            get {
                return this.currencyNameField;
            }
            set {
                this.currencyNameField = value;
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
        public string handlingTax2Rate {
            get {
                return this.handlingTax2RateField;
            }
            set {
                this.handlingTax2RateField = value;
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
        public RecordRef salesGroup {
            get {
                return this.salesGroupField;
            }
            set {
                this.salesGroupField = value;
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
        public string status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
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
        public RecordRef billingSchedule {
            get {
                return this.billingScheduleField;
            }
            set {
                this.billingScheduleField = value;
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
        public string vatRegNum {
            get {
                return this.vatRegNumField;
            }
            set {
                this.vatRegNumField = value;
            }
        }

        /// <remarks/>
        public RecordRef expCostDiscount {
            get {
                return this.expCostDiscountField;
            }
            set {
                this.expCostDiscountField = value;
            }
        }

        /// <remarks/>
        public RecordRef itemCostDiscount {
            get {
                return this.itemCostDiscountField;
            }
            set {
                this.itemCostDiscountField = value;
            }
        }

        /// <remarks/>
        public RecordRef timeDiscount {
            get {
                return this.timeDiscountField;
            }
            set {
                this.timeDiscountField = value;
            }
        }

        /// <remarks/>
        public string expCostDiscRate {
            get {
                return this.expCostDiscRateField;
            }
            set {
                this.expCostDiscRateField = value;
            }
        }

        /// <remarks/>
        public string itemCostDiscRate {
            get {
                return this.itemCostDiscRateField;
            }
            set {
                this.itemCostDiscRateField = value;
            }
        }

        /// <remarks/>
        public string timeDiscRate {
            get {
                return this.timeDiscRateField;
            }
            set {
                this.timeDiscRateField = value;
            }
        }

        /// <remarks/>
        public double expCostDiscAmount {
            get {
                return this.expCostDiscAmountField;
            }
            set {
                this.expCostDiscAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expCostDiscAmountSpecified {
            get {
                return this.expCostDiscAmountFieldSpecified;
            }
            set {
                this.expCostDiscAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double expCostTaxRate1 {
            get {
                return this.expCostTaxRate1Field;
            }
            set {
                this.expCostTaxRate1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expCostTaxRate1Specified {
            get {
                return this.expCostTaxRate1FieldSpecified;
            }
            set {
                this.expCostTaxRate1FieldSpecified = value;
            }
        }

        /// <remarks/>
        public double expCostTaxRate2 {
            get {
                return this.expCostTaxRate2Field;
            }
            set {
                this.expCostTaxRate2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expCostTaxRate2Specified {
            get {
                return this.expCostTaxRate2FieldSpecified;
            }
            set {
                this.expCostTaxRate2FieldSpecified = value;
            }
        }

        /// <remarks/>
        public double itemCostDiscAmount {
            get {
                return this.itemCostDiscAmountField;
            }
            set {
                this.itemCostDiscAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itemCostDiscAmountSpecified {
            get {
                return this.itemCostDiscAmountFieldSpecified;
            }
            set {
                this.itemCostDiscAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef expCostTaxCode {
            get {
                return this.expCostTaxCodeField;
            }
            set {
                this.expCostTaxCodeField = value;
            }
        }

        /// <remarks/>
        public double expCostDiscTax1Amt {
            get {
                return this.expCostDiscTax1AmtField;
            }
            set {
                this.expCostDiscTax1AmtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expCostDiscTax1AmtSpecified {
            get {
                return this.expCostDiscTax1AmtFieldSpecified;
            }
            set {
                this.expCostDiscTax1AmtFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double itemCostTaxRate1 {
            get {
                return this.itemCostTaxRate1Field;
            }
            set {
                this.itemCostTaxRate1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itemCostTaxRate1Specified {
            get {
                return this.itemCostTaxRate1FieldSpecified;
            }
            set {
                this.itemCostTaxRate1FieldSpecified = value;
            }
        }

        /// <remarks/>
        public double timeDiscAmount {
            get {
                return this.timeDiscAmountField;
            }
            set {
                this.timeDiscAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool timeDiscAmountSpecified {
            get {
                return this.timeDiscAmountFieldSpecified;
            }
            set {
                this.timeDiscAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef itemCostTaxCode {
            get {
                return this.itemCostTaxCodeField;
            }
            set {
                this.itemCostTaxCodeField = value;
            }
        }

        /// <remarks/>
        public bool expCostDiscTaxable {
            get {
                return this.expCostDiscTaxableField;
            }
            set {
                this.expCostDiscTaxableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expCostDiscTaxableSpecified {
            get {
                return this.expCostDiscTaxableFieldSpecified;
            }
            set {
                this.expCostDiscTaxableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool itemCostDiscTaxable {
            get {
                return this.itemCostDiscTaxableField;
            }
            set {
                this.itemCostDiscTaxableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itemCostDiscTaxableSpecified {
            get {
                return this.itemCostDiscTaxableFieldSpecified;
            }
            set {
                this.itemCostDiscTaxableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double itemCostTaxRate2 {
            get {
                return this.itemCostTaxRate2Field;
            }
            set {
                this.itemCostTaxRate2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itemCostTaxRate2Specified {
            get {
                return this.itemCostTaxRate2FieldSpecified;
            }
            set {
                this.itemCostTaxRate2FieldSpecified = value;
            }
        }

        /// <remarks/>
        public double itemCostDiscTax1Amt {
            get {
                return this.itemCostDiscTax1AmtField;
            }
            set {
                this.itemCostDiscTax1AmtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itemCostDiscTax1AmtSpecified {
            get {
                return this.itemCostDiscTax1AmtFieldSpecified;
            }
            set {
                this.itemCostDiscTax1AmtFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool itemCostDiscPrint {
            get {
                return this.itemCostDiscPrintField;
            }
            set {
                this.itemCostDiscPrintField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itemCostDiscPrintSpecified {
            get {
                return this.itemCostDiscPrintFieldSpecified;
            }
            set {
                this.itemCostDiscPrintFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool timeDiscTaxable {
            get {
                return this.timeDiscTaxableField;
            }
            set {
                this.timeDiscTaxableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool timeDiscTaxableSpecified {
            get {
                return this.timeDiscTaxableFieldSpecified;
            }
            set {
                this.timeDiscTaxableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double timeTaxRate1 {
            get {
                return this.timeTaxRate1Field;
            }
            set {
                this.timeTaxRate1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool timeTaxRate1Specified {
            get {
                return this.timeTaxRate1FieldSpecified;
            }
            set {
                this.timeTaxRate1FieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool expCostDiscPrint {
            get {
                return this.expCostDiscPrintField;
            }
            set {
                this.expCostDiscPrintField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expCostDiscPrintSpecified {
            get {
                return this.expCostDiscPrintFieldSpecified;
            }
            set {
                this.expCostDiscPrintFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef timeTaxCode {
            get {
                return this.timeTaxCodeField;
            }
            set {
                this.timeTaxCodeField = value;
            }
        }

        /// <remarks/>
        public bool timeDiscPrint {
            get {
                return this.timeDiscPrintField;
            }
            set {
                this.timeDiscPrintField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool timeDiscPrintSpecified {
            get {
                return this.timeDiscPrintFieldSpecified;
            }
            set {
                this.timeDiscPrintFieldSpecified = value;
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
        public double timeDiscTax1Amt {
            get {
                return this.timeDiscTax1AmtField;
            }
            set {
                this.timeDiscTax1AmtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool timeDiscTax1AmtSpecified {
            get {
                return this.timeDiscTax1AmtFieldSpecified;
            }
            set {
                this.timeDiscTax1AmtFieldSpecified = value;
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
        public double timeTaxRate2 {
            get {
                return this.timeTaxRate2Field;
            }
            set {
                this.timeTaxRate2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool timeTaxRate2Specified {
            get {
                return this.timeTaxRate2FieldSpecified;
            }
            set {
                this.timeTaxRate2FieldSpecified = value;
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
        public InvoiceSalesTeamList salesTeamList {
            get {
                return this.salesTeamListField;
            }
            set {
                this.salesTeamListField = value;
            }
        }

        /// <remarks/>
        public InvoicePartnersList partnersList {
            get {
                return this.partnersListField;
            }
            set {
                this.partnersListField = value;
            }
        }

        /// <remarks/>
        public InvoiceItemList itemList {
            get {
                return this.itemListField;
            }
            set {
                this.itemListField = value;
            }
        }

        /// <remarks/>
        public InvoiceItemCostList itemCostList {
            get {
                return this.itemCostListField;
            }
            set {
                this.itemCostListField = value;
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
        public InvoiceExpCostList expCostList {
            get {
                return this.expCostListField;
            }
            set {
                this.expCostListField = value;
            }
        }

        /// <remarks/>
        public InvoiceTimeList timeList {
            get {
                return this.timeListField;
            }
            set {
                this.timeListField = value;
            }
        }

        /// <remarks/>
        public InvoiceShipGroupList shipGroupList {
            get {
                return this.shipGroupListField;
            }
            set {
                this.shipGroupListField = value;
            }
        }

        /// <remarks/>
        public RecordRef approvalStatus {
            get {
                return this.approvalStatusField;
            }
            set {
                this.approvalStatusField = value;
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
        public InstallmentList installmentList {
            get {
                return this.installmentListField;
            }
            set {
                this.installmentListField = value;
            }
        }

        /// <remarks/>
        public bool overrideInstallments {
            get {
                return this.overrideInstallmentsField;
            }
            set {
                this.overrideInstallmentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool overrideInstallmentsSpecified {
            get {
                return this.overrideInstallmentsFieldSpecified;
            }
            set {
                this.overrideInstallmentsFieldSpecified = value;
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