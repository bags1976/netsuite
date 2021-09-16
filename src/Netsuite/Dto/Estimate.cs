namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sales_2021_1.transactions.webservices.netsuite.com")]
    public partial class Estimate : Record {

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

        private RecordRef entityField;

        private RecordRef jobField;

        private System.DateTime tranDateField;

        private bool tranDateFieldSpecified;

        private string tranIdField;

        private RecordRef entityTaxRegNumField;

        private System.DateTime taxPointDateField;

        private bool taxPointDateFieldSpecified;

        private string sourceField;

        private RecordRef customFormField;

        private RecordRef currencyField;

        private string titleField;

        private RecordRef entityStatusField;

        private double probabilityField;

        private bool probabilityFieldSpecified;

        private bool includeInForecastField;

        private bool includeInForecastFieldSpecified;

        private RecordRef forecastTypeField;

        private RecordRef opportunityField;

        private RecordRef departmentField;

        private RecordRef classField;

        private RecordRef termsField;

        private System.DateTime dueDateField;

        private bool dueDateFieldSpecified;

        private RecordRef locationField;

        private RecordRef subsidiaryField;

        private RecordRef billingScheduleField;

        private string statusField;

        private RecordRef salesRepField;

        private RecordRef partnerField;

        private string contribPctField;

        private RecordRef leadSourceField;

        private System.DateTime expectedCloseDateField;

        private bool expectedCloseDateFieldSpecified;

        private string otherRefNumField;

        private string memoField;

        private System.DateTime endDateField;

        private bool endDateFieldSpecified;

        private System.DateTime startDateField;

        private bool startDateFieldSpecified;

        private double totalCostEstimateField;

        private bool totalCostEstimateFieldSpecified;

        private double estGrossProfitField;

        private bool estGrossProfitFieldSpecified;

        private double estGrossProfitPercentField;

        private bool estGrossProfitPercentFieldSpecified;

        private RecordRef createdFromField;

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

        private string vatRegNumField;

        private bool toBePrintedField;

        private bool toBePrintedFieldSpecified;

        private bool toBeEmailedField;

        private bool toBeEmailedFieldSpecified;

        private string emailField;

        private bool toBeFaxedField;

        private bool toBeFaxedFieldSpecified;

        private string faxField;

        private bool visibleToCustomerField;

        private bool visibleToCustomerFieldSpecified;

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

        private RecordRef shippingTaxCodeField;

        private string shippingTax2RateField;

        private RecordRef handlingTaxCodeField;

        private double handlingTax1RateField;

        private bool handlingTax1RateFieldSpecified;

        private double handlingCostField;

        private bool handlingCostFieldSpecified;

        private string trackingNumbersField;

        private string handlingTax2RateField;

        private string linkedTrackingNumbersField;

        private RecordRef salesGroupField;

        private bool syncSalesTeamsField;

        private bool syncSalesTeamsFieldSpecified;

        private double altSalesTotalField;

        private bool altSalesTotalFieldSpecified;

        private bool canHaveStackableField;

        private bool canHaveStackableFieldSpecified;

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

        private double tax2TotalField;

        private bool tax2TotalFieldSpecified;

        private EstimateItemList itemListField;

        private AccountingBookDetailList accountingBookDetailListField;

        private EstimateSalesTeamList salesTeamListField;

        private bool syncPartnerTeamsField;

        private bool syncPartnerTeamsFieldSpecified;

        private EstimatePartnersList partnersListField;

        private PromotionsList promotionsListField;

        private EstimateShipGroupList shipGroupListField;

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
        public string title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }

        /// <remarks/>
        public RecordRef entityStatus {
            get {
                return this.entityStatusField;
            }
            set {
                this.entityStatusField = value;
            }
        }

        /// <remarks/>
        public double probability {
            get {
                return this.probabilityField;
            }
            set {
                this.probabilityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool probabilitySpecified {
            get {
                return this.probabilityFieldSpecified;
            }
            set {
                this.probabilityFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool includeInForecast {
            get {
                return this.includeInForecastField;
            }
            set {
                this.includeInForecastField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool includeInForecastSpecified {
            get {
                return this.includeInForecastFieldSpecified;
            }
            set {
                this.includeInForecastFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef forecastType {
            get {
                return this.forecastTypeField;
            }
            set {
                this.forecastTypeField = value;
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
        public RecordRef billingSchedule {
            get {
                return this.billingScheduleField;
            }
            set {
                this.billingScheduleField = value;
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
        public RecordRef leadSource {
            get {
                return this.leadSourceField;
            }
            set {
                this.leadSourceField = value;
            }
        }

        /// <remarks/>
        public System.DateTime expectedCloseDate {
            get {
                return this.expectedCloseDateField;
            }
            set {
                this.expectedCloseDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expectedCloseDateSpecified {
            get {
                return this.expectedCloseDateFieldSpecified;
            }
            set {
                this.expectedCloseDateFieldSpecified = value;
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
        public RecordRef createdFrom {
            get {
                return this.createdFromField;
            }
            set {
                this.createdFromField = value;
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
        public string vatRegNum {
            get {
                return this.vatRegNumField;
            }
            set {
                this.vatRegNumField = value;
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
        public bool visibleToCustomer {
            get {
                return this.visibleToCustomerField;
            }
            set {
                this.visibleToCustomerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool visibleToCustomerSpecified {
            get {
                return this.visibleToCustomerFieldSpecified;
            }
            set {
                this.visibleToCustomerFieldSpecified = value;
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
        public RecordRef shippingTaxCode {
            get {
                return this.shippingTaxCodeField;
            }
            set {
                this.shippingTaxCodeField = value;
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
        public string trackingNumbers {
            get {
                return this.trackingNumbersField;
            }
            set {
                this.trackingNumbersField = value;
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
        public EstimateItemList itemList {
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
        public EstimateSalesTeamList salesTeamList {
            get {
                return this.salesTeamListField;
            }
            set {
                this.salesTeamListField = value;
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
        public EstimatePartnersList partnersList {
            get {
                return this.partnersListField;
            }
            set {
                this.partnersListField = value;
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
        public EstimateShipGroupList shipGroupList {
            get {
                return this.shipGroupListField;
            }
            set {
                this.shipGroupListField = value;
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