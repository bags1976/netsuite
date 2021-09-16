namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sales_2021_1.transactions.webservices.netsuite.com")]
    public partial class Opportunity : Record {

        private RecordRef customFormField;

        private RecordRef currencyField;

        private double estimatedBudgetField;

        private bool estimatedBudgetFieldSpecified;

        private RecordRef entityField;

        private RecordRef jobField;

        private string titleField;

        private string tranIdField;

        private RecordRef entityTaxRegNumField;

        private System.DateTime taxPointDateField;

        private bool taxPointDateFieldSpecified;

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

        private string sourceField;

        private RecordRef salesRepField;

        private string contribPctField;

        private RecordRef partnerField;

        private RecordRef salesGroupField;

        private bool syncSalesTeamsField;

        private bool syncSalesTeamsFieldSpecified;

        private RecordRef leadSourceField;

        private RecordRef entityStatusField;

        private double probabilityField;

        private bool probabilityFieldSpecified;

        private System.DateTime tranDateField;

        private bool tranDateFieldSpecified;

        private System.DateTime expectedCloseDateField;

        private bool expectedCloseDateFieldSpecified;

        private long daysOpenField;

        private bool daysOpenFieldSpecified;

        private RecordRef forecastTypeField;

        private string currencyNameField;

        private double exchangeRateField;

        private bool exchangeRateFieldSpecified;

        private double projectedTotalField;

        private bool projectedTotalFieldSpecified;

        private double rangeLowField;

        private bool rangeLowFieldSpecified;

        private double rangeHighField;

        private bool rangeHighFieldSpecified;

        private double projAltSalesAmtField;

        private bool projAltSalesAmtFieldSpecified;

        private double altSalesRangeLowField;

        private bool altSalesRangeLowFieldSpecified;

        private double altSalesRangeHighField;

        private bool altSalesRangeHighFieldSpecified;

        private double weightedTotalField;

        private bool weightedTotalFieldSpecified;

        private string actionItemField;

        private RecordRef winLossReasonField;

        private string memoField;

        private double taxTotalField;

        private bool taxTotalFieldSpecified;

        private bool isBudgetApprovedField;

        private bool isBudgetApprovedFieldSpecified;

        private double tax2TotalField;

        private bool tax2TotalFieldSpecified;

        private RecordRef salesReadinessField;

        private double totalCostEstimateField;

        private bool totalCostEstimateFieldSpecified;

        private RecordRef buyingTimeFrameField;

        private double estGrossProfitField;

        private bool estGrossProfitFieldSpecified;

        private RecordRef buyingReasonField;

        private double estGrossProfitPercentField;

        private bool estGrossProfitPercentFieldSpecified;

        private Address billingAddressField;

        private RecordRef billAddressListField;

        private Address shippingAddressField;

        private bool shipIsResidentialField;

        private bool shipIsResidentialFieldSpecified;

        private RecordRef shipAddressListField;

        private RecordRef classField;

        private System.DateTime closeDateField;

        private bool closeDateFieldSpecified;

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

        private RecordRef departmentField;

        private RecordRef locationField;

        private RecordRef subsidiaryField;

        private string statusField;

        private string vatRegNumField;

        private bool syncPartnerTeamsField;

        private bool syncPartnerTeamsFieldSpecified;

        private OpportunitySalesTeamList salesTeamListField;

        private OpportunityPartnersList partnersListField;

        private OpportunityItemList itemListField;

        private OpportunityCompetitorsList competitorsListField;

        private AccountingBookDetailList accountingBookDetailListField;

        private TaxDetailsList taxDetailsListField;

        private CustomFieldRef[] customFieldListField;

        private string internalIdField;

        private string externalIdField;

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
        public double estimatedBudget {
            get {
                return this.estimatedBudgetField;
            }
            set {
                this.estimatedBudgetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool estimatedBudgetSpecified {
            get {
                return this.estimatedBudgetFieldSpecified;
            }
            set {
                this.estimatedBudgetFieldSpecified = value;
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
        public string title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
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
        public string source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
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
        public long daysOpen {
            get {
                return this.daysOpenField;
            }
            set {
                this.daysOpenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool daysOpenSpecified {
            get {
                return this.daysOpenFieldSpecified;
            }
            set {
                this.daysOpenFieldSpecified = value;
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
        public string currencyName {
            get {
                return this.currencyNameField;
            }
            set {
                this.currencyNameField = value;
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
        public double projectedTotal {
            get {
                return this.projectedTotalField;
            }
            set {
                this.projectedTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool projectedTotalSpecified {
            get {
                return this.projectedTotalFieldSpecified;
            }
            set {
                this.projectedTotalFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double rangeLow {
            get {
                return this.rangeLowField;
            }
            set {
                this.rangeLowField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rangeLowSpecified {
            get {
                return this.rangeLowFieldSpecified;
            }
            set {
                this.rangeLowFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double rangeHigh {
            get {
                return this.rangeHighField;
            }
            set {
                this.rangeHighField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rangeHighSpecified {
            get {
                return this.rangeHighFieldSpecified;
            }
            set {
                this.rangeHighFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double projAltSalesAmt {
            get {
                return this.projAltSalesAmtField;
            }
            set {
                this.projAltSalesAmtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool projAltSalesAmtSpecified {
            get {
                return this.projAltSalesAmtFieldSpecified;
            }
            set {
                this.projAltSalesAmtFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double altSalesRangeLow {
            get {
                return this.altSalesRangeLowField;
            }
            set {
                this.altSalesRangeLowField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool altSalesRangeLowSpecified {
            get {
                return this.altSalesRangeLowFieldSpecified;
            }
            set {
                this.altSalesRangeLowFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double altSalesRangeHigh {
            get {
                return this.altSalesRangeHighField;
            }
            set {
                this.altSalesRangeHighField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool altSalesRangeHighSpecified {
            get {
                return this.altSalesRangeHighFieldSpecified;
            }
            set {
                this.altSalesRangeHighFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double weightedTotal {
            get {
                return this.weightedTotalField;
            }
            set {
                this.weightedTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool weightedTotalSpecified {
            get {
                return this.weightedTotalFieldSpecified;
            }
            set {
                this.weightedTotalFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string actionItem {
            get {
                return this.actionItemField;
            }
            set {
                this.actionItemField = value;
            }
        }

        /// <remarks/>
        public RecordRef winLossReason {
            get {
                return this.winLossReasonField;
            }
            set {
                this.winLossReasonField = value;
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
        public bool isBudgetApproved {
            get {
                return this.isBudgetApprovedField;
            }
            set {
                this.isBudgetApprovedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isBudgetApprovedSpecified {
            get {
                return this.isBudgetApprovedFieldSpecified;
            }
            set {
                this.isBudgetApprovedFieldSpecified = value;
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
        public RecordRef salesReadiness {
            get {
                return this.salesReadinessField;
            }
            set {
                this.salesReadinessField = value;
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
        public RecordRef buyingTimeFrame {
            get {
                return this.buyingTimeFrameField;
            }
            set {
                this.buyingTimeFrameField = value;
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
        public RecordRef buyingReason {
            get {
                return this.buyingReasonField;
            }
            set {
                this.buyingReasonField = value;
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
        public RecordRef @class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
            }
        }

        /// <remarks/>
        public System.DateTime closeDate {
            get {
                return this.closeDateField;
            }
            set {
                this.closeDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool closeDateSpecified {
            get {
                return this.closeDateFieldSpecified;
            }
            set {
                this.closeDateFieldSpecified = value;
            }
        }

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
        public RecordRef department {
            get {
                return this.departmentField;
            }
            set {
                this.departmentField = value;
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
        public string status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
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
        public OpportunitySalesTeamList salesTeamList {
            get {
                return this.salesTeamListField;
            }
            set {
                this.salesTeamListField = value;
            }
        }

        /// <remarks/>
        public OpportunityPartnersList partnersList {
            get {
                return this.partnersListField;
            }
            set {
                this.partnersListField = value;
            }
        }

        /// <remarks/>
        public OpportunityItemList itemList {
            get {
                return this.itemListField;
            }
            set {
                this.itemListField = value;
            }
        }

        /// <remarks/>
        public OpportunityCompetitorsList competitorsList {
            get {
                return this.competitorsListField;
            }
            set {
                this.competitorsListField = value;
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