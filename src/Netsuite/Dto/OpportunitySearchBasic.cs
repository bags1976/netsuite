namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class OpportunitySearchBasic : SearchRecordBasic {

        private SearchDoubleField amountField;

        private SearchBooleanField availableOfflineField;

        private SearchMultiSelectField buyingReasonField;

        private SearchMultiSelectField buyingTimeFrameField;

        private SearchMultiSelectField classField;

        private SearchDateField closeDateField;

        private SearchMultiSelectField competitorField;

        private SearchLongField contributionField;

        private SearchMultiSelectField currencyField;

        private SearchMultiSelectField custTypeField;

        private SearchDateField dateCreatedField;

        private SearchLongField daysOpenField;

        private SearchLongField daysToCloseField;

        private SearchMultiSelectField departmentField;

        private SearchMultiSelectField entityField;

        private SearchMultiSelectField entityStatusField;

        private SearchDoubleField estimatedBudgetField;

        private SearchDateField expectedCloseDateField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchEnumMultiSelectField forecastTypeField;

        private SearchDoubleField foreignProjectedAmountField;

        private SearchDoubleField foreignRangeHighField;

        private SearchDoubleField foreignRangeLowField;

        private SearchDoubleField fxTranCostEstimateField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchBooleanField isBudgetApprovedField;

        private SearchMultiSelectField itemField;

        private SearchDateField lastModifiedDateField;

        private SearchMultiSelectField leadSourceField;

        private SearchMultiSelectField locationField;

        private SearchStringField memoField;

        private SearchLongField numberField;

        private SearchMultiSelectField partnerField;

        private SearchLongField partnerContributionField;

        private SearchMultiSelectField partnerRoleField;

        private SearchMultiSelectField partnerTeamMemberField;

        private RecordRef postingPeriodField;

        private PostingPeriodDate postingPeriodRelativeField;

        private bool postingPeriodRelativeFieldSpecified;

        private SearchLongField probabilityField;

        private SearchDoubleField projAltSalesAmtField;

        private SearchDoubleField projectedTotalField;

        private SearchDoubleField rangeHighField;

        private SearchDoubleField rangeHighAltField;

        private SearchDoubleField rangeLowField;

        private SearchDoubleField rangeLowAltField;

        private SearchMultiSelectField salesReadinessField;

        private SearchMultiSelectField salesRepField;

        private SearchMultiSelectField salesTeamMemberField;

        private SearchMultiSelectField salesTeamRoleField;

        private SearchEnumMultiSelectField statusField;

        private SearchMultiSelectField subsidiaryField;

        private RecordRef taxPeriodField;

        private PostingPeriodDate taxPeriodRelativeField;

        private bool taxPeriodRelativeFieldSpecified;

        private SearchStringField titleField;

        private SearchDoubleField tranCostEstimateField;

        private SearchDateField tranDateField;

        private SearchDoubleField tranEstGrossProfitField;

        private SearchDoubleField tranEstGrossProfitPctField;

        private SearchDoubleField tranFxEstGrossProfitField;

        private SearchStringField tranIdField;

        private SearchMultiSelectField winLossReasonField;

        private SearchMultiSelectField wonByField;

        private SearchCustomField[] customFieldListField;

        /// <remarks/>
        public SearchDoubleField amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField availableOffline {
            get {
                return this.availableOfflineField;
            }
            set {
                this.availableOfflineField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField buyingReason {
            get {
                return this.buyingReasonField;
            }
            set {
                this.buyingReasonField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField buyingTimeFrame {
            get {
                return this.buyingTimeFrameField;
            }
            set {
                this.buyingTimeFrameField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField @class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
            }
        }

        /// <remarks/>
        public SearchDateField closeDate {
            get {
                return this.closeDateField;
            }
            set {
                this.closeDateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField competitor {
            get {
                return this.competitorField;
            }
            set {
                this.competitorField = value;
            }
        }

        /// <remarks/>
        public SearchLongField contribution {
            get {
                return this.contributionField;
            }
            set {
                this.contributionField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField custType {
            get {
                return this.custTypeField;
            }
            set {
                this.custTypeField = value;
            }
        }

        /// <remarks/>
        public SearchDateField dateCreated {
            get {
                return this.dateCreatedField;
            }
            set {
                this.dateCreatedField = value;
            }
        }

        /// <remarks/>
        public SearchLongField daysOpen {
            get {
                return this.daysOpenField;
            }
            set {
                this.daysOpenField = value;
            }
        }

        /// <remarks/>
        public SearchLongField daysToClose {
            get {
                return this.daysToCloseField;
            }
            set {
                this.daysToCloseField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField department {
            get {
                return this.departmentField;
            }
            set {
                this.departmentField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField entity {
            get {
                return this.entityField;
            }
            set {
                this.entityField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField entityStatus {
            get {
                return this.entityStatusField;
            }
            set {
                this.entityStatusField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField estimatedBudget {
            get {
                return this.estimatedBudgetField;
            }
            set {
                this.estimatedBudgetField = value;
            }
        }

        /// <remarks/>
        public SearchDateField expectedCloseDate {
            get {
                return this.expectedCloseDateField;
            }
            set {
                this.expectedCloseDateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField externalId {
            get {
                return this.externalIdField;
            }
            set {
                this.externalIdField = value;
            }
        }

        /// <remarks/>
        public SearchStringField externalIdString {
            get {
                return this.externalIdStringField;
            }
            set {
                this.externalIdStringField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField forecastType {
            get {
                return this.forecastTypeField;
            }
            set {
                this.forecastTypeField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField foreignProjectedAmount {
            get {
                return this.foreignProjectedAmountField;
            }
            set {
                this.foreignProjectedAmountField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField foreignRangeHigh {
            get {
                return this.foreignRangeHighField;
            }
            set {
                this.foreignRangeHighField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField foreignRangeLow {
            get {
                return this.foreignRangeLowField;
            }
            set {
                this.foreignRangeLowField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField fxTranCostEstimate {
            get {
                return this.fxTranCostEstimateField;
            }
            set {
                this.fxTranCostEstimateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }

        /// <remarks/>
        public SearchLongField internalIdNumber {
            get {
                return this.internalIdNumberField;
            }
            set {
                this.internalIdNumberField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isBudgetApproved {
            get {
                return this.isBudgetApprovedField;
            }
            set {
                this.isBudgetApprovedField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }

        /// <remarks/>
        public SearchDateField lastModifiedDate {
            get {
                return this.lastModifiedDateField;
            }
            set {
                this.lastModifiedDateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField leadSource {
            get {
                return this.leadSourceField;
            }
            set {
                this.leadSourceField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }

        /// <remarks/>
        public SearchStringField memo {
            get {
                return this.memoField;
            }
            set {
                this.memoField = value;
            }
        }

        /// <remarks/>
        public SearchLongField number {
            get {
                return this.numberField;
            }
            set {
                this.numberField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField partner {
            get {
                return this.partnerField;
            }
            set {
                this.partnerField = value;
            }
        }

        /// <remarks/>
        public SearchLongField partnerContribution {
            get {
                return this.partnerContributionField;
            }
            set {
                this.partnerContributionField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField partnerRole {
            get {
                return this.partnerRoleField;
            }
            set {
                this.partnerRoleField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField partnerTeamMember {
            get {
                return this.partnerTeamMemberField;
            }
            set {
                this.partnerTeamMemberField = value;
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
        public PostingPeriodDate postingPeriodRelative {
            get {
                return this.postingPeriodRelativeField;
            }
            set {
                this.postingPeriodRelativeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool postingPeriodRelativeSpecified {
            get {
                return this.postingPeriodRelativeFieldSpecified;
            }
            set {
                this.postingPeriodRelativeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public SearchLongField probability {
            get {
                return this.probabilityField;
            }
            set {
                this.probabilityField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField projAltSalesAmt {
            get {
                return this.projAltSalesAmtField;
            }
            set {
                this.projAltSalesAmtField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField projectedTotal {
            get {
                return this.projectedTotalField;
            }
            set {
                this.projectedTotalField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField rangeHigh {
            get {
                return this.rangeHighField;
            }
            set {
                this.rangeHighField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField rangeHighAlt {
            get {
                return this.rangeHighAltField;
            }
            set {
                this.rangeHighAltField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField rangeLow {
            get {
                return this.rangeLowField;
            }
            set {
                this.rangeLowField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField rangeLowAlt {
            get {
                return this.rangeLowAltField;
            }
            set {
                this.rangeLowAltField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField salesReadiness {
            get {
                return this.salesReadinessField;
            }
            set {
                this.salesReadinessField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField salesRep {
            get {
                return this.salesRepField;
            }
            set {
                this.salesRepField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField salesTeamMember {
            get {
                return this.salesTeamMemberField;
            }
            set {
                this.salesTeamMemberField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField salesTeamRole {
            get {
                return this.salesTeamRoleField;
            }
            set {
                this.salesTeamRoleField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
            }
        }

        /// <remarks/>
        public RecordRef taxPeriod {
            get {
                return this.taxPeriodField;
            }
            set {
                this.taxPeriodField = value;
            }
        }

        /// <remarks/>
        public PostingPeriodDate taxPeriodRelative {
            get {
                return this.taxPeriodRelativeField;
            }
            set {
                this.taxPeriodRelativeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxPeriodRelativeSpecified {
            get {
                return this.taxPeriodRelativeFieldSpecified;
            }
            set {
                this.taxPeriodRelativeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public SearchStringField title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField tranCostEstimate {
            get {
                return this.tranCostEstimateField;
            }
            set {
                this.tranCostEstimateField = value;
            }
        }

        /// <remarks/>
        public SearchDateField tranDate {
            get {
                return this.tranDateField;
            }
            set {
                this.tranDateField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField tranEstGrossProfit {
            get {
                return this.tranEstGrossProfitField;
            }
            set {
                this.tranEstGrossProfitField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField tranEstGrossProfitPct {
            get {
                return this.tranEstGrossProfitPctField;
            }
            set {
                this.tranEstGrossProfitPctField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField tranFxEstGrossProfit {
            get {
                return this.tranFxEstGrossProfitField;
            }
            set {
                this.tranFxEstGrossProfitField = value;
            }
        }

        /// <remarks/>
        public SearchStringField tranId {
            get {
                return this.tranIdField;
            }
            set {
                this.tranIdField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField winLossReason {
            get {
                return this.winLossReasonField;
            }
            set {
                this.winLossReasonField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField wonBy {
            get {
                return this.wonByField;
            }
            set {
                this.wonByField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("customField", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public SearchCustomField[] customFieldList {
            get {
                return this.customFieldListField;
            }
            set {
                this.customFieldListField = value;
            }
        }
    }
}