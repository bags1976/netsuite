using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:customers_2021_1.transactions.webservices.netsuite.com")]
    public partial class CreditMemo : Record {

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

        private RecordRef currencyField;

        private RecordRef entityField;

        private string vatRegNumField;

        private System.DateTime tranDateField;

        private bool tranDateFieldSpecified;

        private string tranIdField;

        private RecordRef entityTaxRegNumField;

        private System.DateTime taxPointDateField;

        private bool taxPointDateFieldSpecified;

        private RecordRef createdFromField;

        private RecordRef postingPeriodField;

        private RecordRef departmentField;

        private RecordRef classField;

        private RecordRef locationField;

        private RecordRef subsidiaryField;

        private RecordRef jobField;

        private RecordRef salesRepField;

        private RecordRef partnerField;

        private string contribPctField;

        private string otherRefNumField;

        private string memoField;

        private bool excludeCommissionField;

        private bool excludeCommissionFieldSpecified;

        private RecordRef leadSourceField;

        private double balanceField;

        private bool balanceFieldSpecified;

        private RecordRef accountField;

        private double exchangeRateField;

        private bool exchangeRateFieldSpecified;

        private string onCreditHoldField;

        private double amountPaidField;

        private bool amountPaidFieldSpecified;

        private System.DateTime salesEffectiveDateField;

        private bool salesEffectiveDateFieldSpecified;

        private double totalCostEstimateField;

        private bool totalCostEstimateFieldSpecified;

        private double estGrossProfitField;

        private bool estGrossProfitFieldSpecified;

        private double estGrossProfitPercentField;

        private bool estGrossProfitPercentFieldSpecified;

        private string currencyNameField;

        private RecordRef promoCodeField;

        private double amountRemainingField;

        private bool amountRemainingFieldSpecified;

        private RecordRef discountItemField;

        private string sourceField;

        private string discountRateField;

        private bool isTaxableField;

        private bool isTaxableFieldSpecified;

        private RecordRef taxItemField;

        private double taxRateField;

        private bool taxRateFieldSpecified;

        private double unappliedField;

        private bool unappliedFieldSpecified;

        private bool autoApplyField;

        private bool autoApplyFieldSpecified;

        private double appliedField;

        private bool appliedFieldSpecified;

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

        private Address billingAddressField;

        private RecordRef billAddressListField;

        private RecordRef shipMethodField;

        private double shippingCostField;

        private bool shippingCostFieldSpecified;

        private double shippingTax1RateField;

        private bool shippingTax1RateFieldSpecified;

        private RecordRef shippingTaxCodeField;

        private RecordRef handlingTaxCodeField;

        private string shippingTax2RateField;

        private double handlingTax1RateField;

        private bool handlingTax1RateFieldSpecified;

        private string handlingTax2RateField;

        private double handlingCostField;

        private bool handlingCostFieldSpecified;

        private double subTotalField;

        private bool subTotalFieldSpecified;

        private double discountTotalField;

        private bool discountTotalFieldSpecified;

        private RevenueStatus revenueStatusField;

        private bool revenueStatusFieldSpecified;

        private double recognizedRevenueField;

        private bool recognizedRevenueFieldSpecified;

        private double deferredRevenueField;

        private bool deferredRevenueFieldSpecified;

        private bool revRecOnRevCommitmentField;

        private bool revRecOnRevCommitmentFieldSpecified;

        private double taxTotalField;

        private bool taxTotalFieldSpecified;

        private double tax2TotalField;

        private bool tax2TotalFieldSpecified;

        private double altShippingCostField;

        private bool altShippingCostFieldSpecified;

        private double altHandlingCostField;

        private bool altHandlingCostFieldSpecified;

        private bool isMultiShipToField;

        private bool isMultiShipToFieldSpecified;

        private double totalField;

        private bool totalFieldSpecified;

        private RecordRef salesGroupField;

        private bool syncSalesTeamsField;

        private bool syncSalesTeamsFieldSpecified;

        private string statusField;

        private RecordRef giftCertField;

        private double giftCertTotalField;

        private bool giftCertTotalFieldSpecified;

        private double giftCertAppliedField;

        private bool giftCertAppliedFieldSpecified;

        private double giftCertAvailableField;

        private bool giftCertAvailableFieldSpecified;

        private bool tranIsVsoeBundleField;

        private bool tranIsVsoeBundleFieldSpecified;

        private bool vsoeAutoCalcField;

        private bool vsoeAutoCalcFieldSpecified;

        private bool syncPartnerTeamsField;

        private bool syncPartnerTeamsFieldSpecified;

        private CreditMemoSalesTeamList salesTeamListField;

        private CreditMemoItemList itemListField;

        private AccountingBookDetailList accountingBookDetailListField;

        private CreditMemoPartnersList partnersListField;

        private CreditMemoApplyList applyListField;

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
        public RecordRef currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
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
        public string vatRegNum {
            get {
                return this.vatRegNumField;
            }
            set {
                this.vatRegNumField = value;
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
        public RecordRef subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
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
        public RecordRef salesRep {
            get {
                return this.salesRepField;
            }
            set {
                this.salesRepField = value;
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
        public string contribPct {
            get {
                return this.contribPctField;
            }
            set {
                this.contribPctField = value;
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
        public RecordRef leadSource {
            get {
                return this.leadSourceField;
            }
            set {
                this.leadSourceField = value;
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
        public string onCreditHold {
            get {
                return this.onCreditHoldField;
            }
            set {
                this.onCreditHoldField = value;
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
        public RecordRef discountItem {
            get {
                return this.discountItemField;
            }
            set {
                this.discountItemField = value;
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
        public double unapplied {
            get {
                return this.unappliedField;
            }
            set {
                this.unappliedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unappliedSpecified {
            get {
                return this.unappliedFieldSpecified;
            }
            set {
                this.unappliedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool autoApply {
            get {
                return this.autoApplyField;
            }
            set {
                this.autoApplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool autoApplySpecified {
            get {
                return this.autoApplyFieldSpecified;
            }
            set {
                this.autoApplyFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double applied {
            get {
                return this.appliedField;
            }
            set {
                this.appliedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool appliedSpecified {
            get {
                return this.appliedFieldSpecified;
            }
            set {
                this.appliedFieldSpecified = value;
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
        public string shippingTax2Rate {
            get {
                return this.shippingTax2RateField;
            }
            set {
                this.shippingTax2RateField = value;
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
        public string status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }

        /// <remarks/>
        public RecordRef giftCert {
            get {
                return this.giftCertField;
            }
            set {
                this.giftCertField = value;
            }
        }

        /// <remarks/>
        public double giftCertTotal {
            get {
                return this.giftCertTotalField;
            }
            set {
                this.giftCertTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool giftCertTotalSpecified {
            get {
                return this.giftCertTotalFieldSpecified;
            }
            set {
                this.giftCertTotalFieldSpecified = value;
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
        public double giftCertAvailable {
            get {
                return this.giftCertAvailableField;
            }
            set {
                this.giftCertAvailableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool giftCertAvailableSpecified {
            get {
                return this.giftCertAvailableFieldSpecified;
            }
            set {
                this.giftCertAvailableFieldSpecified = value;
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
        public CreditMemoSalesTeamList salesTeamList {
            get {
                return this.salesTeamListField;
            }
            set {
                this.salesTeamListField = value;
            }
        }

        /// <remarks/>
        public CreditMemoItemList itemList {
            get {
                return this.itemListField;
            }
            set {
                this.itemListField = value;
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
        public CreditMemoPartnersList partnersList {
            get {
                return this.partnersListField;
            }
            set {
                this.partnersListField = value;
            }
        }

        /// <remarks/>
        public CreditMemoApplyList applyList {
            get {
                return this.applyListField;
            }
            set {
                this.applyListField = value;
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