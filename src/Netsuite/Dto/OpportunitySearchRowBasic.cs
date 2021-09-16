namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class OpportunitySearchRowBasic : SearchRowBasic {

        private SearchColumnStringField[] actionItemField;

        private SearchColumnBooleanField[] availableOfflineField;

        private SearchColumnStringField[] buyingReasonField;

        private SearchColumnStringField[] buyingTimeFrameField;

        private SearchColumnSelectField[] classField;

        private SearchColumnDateField[] closeDateField;

        private SearchColumnSelectField[] competitorField;

        private SearchColumnDoubleField[] contributionField;

        private SearchColumnDoubleField[] contributionPrimaryField;

        private SearchColumnSelectField[] currencyField;

        private SearchColumnStringField[] custTypeField;

        private SearchColumnDateField[] dateCreatedField;

        private SearchColumnLongField[] daysOpenField;

        private SearchColumnLongField[] daysToCloseField;

        private SearchColumnSelectField[] decisionMakerField;

        private SearchColumnSelectField[] departmentField;

        private SearchColumnSelectField[] entityField;

        private SearchColumnSelectField[] entityStatusField;

        private SearchColumnDoubleField[] estimatedBudgetField;

        private SearchColumnDateField[] expectedCloseDateField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnEnumSelectField[] forecastTypeField;

        private SearchColumnDoubleField[] foreignProjectedAmountField;

        private SearchColumnDoubleField[] foreignRangeHighField;

        private SearchColumnDoubleField[] foreignRangeLowField;

        private SearchColumnDoubleField[] fxTranCostEstimateField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnBooleanField[] isBudgetApprovedField;

        private SearchColumnDateField[] lastModifiedDateField;

        private SearchColumnSelectField[] leadSourceField;

        private SearchColumnSelectField[] locationField;

        private SearchColumnStringField[] memoField;

        private SearchColumnSelectField[] partnerField;

        private SearchColumnDoubleField[] partnerContributionField;

        private SearchColumnSelectField[] partnerRoleField;

        private SearchColumnSelectField[] partnerTeamMemberField;

        private SearchColumnStringField[] periodField;

        private SearchColumnDoubleField[] probabilityField;

        private SearchColumnDoubleField[] projAltSalesAmtField;

        private SearchColumnDoubleField[] projectedTotalField;

        private SearchColumnDoubleField[] rangeHighField;

        private SearchColumnDoubleField[] rangeHighAltField;

        private SearchColumnDoubleField[] rangeLowField;

        private SearchColumnDoubleField[] rangeLowAltField;

        private SearchColumnStringField[] salesReadinessField;

        private SearchColumnSelectField[] salesRepField;

        private SearchColumnSelectField[] salesTeamMemberField;

        private SearchColumnSelectField[] salesTeamRoleField;

        private SearchColumnEnumSelectField[] statusField;

        private SearchColumnSelectField[] subsidiaryField;

        private SearchColumnSelectField[] taxPeriodField;

        private SearchColumnStringField[] titleField;

        private SearchColumnDoubleField[] totalField;

        private SearchColumnDoubleField[] tranCostEstimateField;

        private SearchColumnDateField[] tranDateField;

        private SearchColumnDoubleField[] tranEstGrossProfitField;

        private SearchColumnDoubleField[] tranEstGrossProfitPctField;

        private SearchColumnDoubleField[] tranFxEstGrossProfitField;

        private SearchColumnStringField[] tranIdField;

        private SearchColumnDoubleField[] weightedTotalField;

        private SearchColumnSelectField[] winLossReasonField;

        private SearchColumnSelectField[] wonByField;

        private SearchColumnCustomField[] customFieldListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("actionItem")]
        public SearchColumnStringField[] actionItem {
            get {
                return this.actionItemField;
            }
            set {
                this.actionItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("availableOffline")]
        public SearchColumnBooleanField[] availableOffline {
            get {
                return this.availableOfflineField;
            }
            set {
                this.availableOfflineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("buyingReason")]
        public SearchColumnStringField[] buyingReason {
            get {
                return this.buyingReasonField;
            }
            set {
                this.buyingReasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("buyingTimeFrame")]
        public SearchColumnStringField[] buyingTimeFrame {
            get {
                return this.buyingTimeFrameField;
            }
            set {
                this.buyingTimeFrameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("class")]
        public SearchColumnSelectField[] @class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("closeDate")]
        public SearchColumnDateField[] closeDate {
            get {
                return this.closeDateField;
            }
            set {
                this.closeDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("competitor")]
        public SearchColumnSelectField[] competitor {
            get {
                return this.competitorField;
            }
            set {
                this.competitorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("contribution")]
        public SearchColumnDoubleField[] contribution {
            get {
                return this.contributionField;
            }
            set {
                this.contributionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("contributionPrimary")]
        public SearchColumnDoubleField[] contributionPrimary {
            get {
                return this.contributionPrimaryField;
            }
            set {
                this.contributionPrimaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("currency")]
        public SearchColumnSelectField[] currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("custType")]
        public SearchColumnStringField[] custType {
            get {
                return this.custTypeField;
            }
            set {
                this.custTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dateCreated")]
        public SearchColumnDateField[] dateCreated {
            get {
                return this.dateCreatedField;
            }
            set {
                this.dateCreatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("daysOpen")]
        public SearchColumnLongField[] daysOpen {
            get {
                return this.daysOpenField;
            }
            set {
                this.daysOpenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("daysToClose")]
        public SearchColumnLongField[] daysToClose {
            get {
                return this.daysToCloseField;
            }
            set {
                this.daysToCloseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("decisionMaker")]
        public SearchColumnSelectField[] decisionMaker {
            get {
                return this.decisionMakerField;
            }
            set {
                this.decisionMakerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("department")]
        public SearchColumnSelectField[] department {
            get {
                return this.departmentField;
            }
            set {
                this.departmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("entity")]
        public SearchColumnSelectField[] entity {
            get {
                return this.entityField;
            }
            set {
                this.entityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("entityStatus")]
        public SearchColumnSelectField[] entityStatus {
            get {
                return this.entityStatusField;
            }
            set {
                this.entityStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("estimatedBudget")]
        public SearchColumnDoubleField[] estimatedBudget {
            get {
                return this.estimatedBudgetField;
            }
            set {
                this.estimatedBudgetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("expectedCloseDate")]
        public SearchColumnDateField[] expectedCloseDate {
            get {
                return this.expectedCloseDateField;
            }
            set {
                this.expectedCloseDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("externalId")]
        public SearchColumnSelectField[] externalId {
            get {
                return this.externalIdField;
            }
            set {
                this.externalIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("forecastType")]
        public SearchColumnEnumSelectField[] forecastType {
            get {
                return this.forecastTypeField;
            }
            set {
                this.forecastTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("foreignProjectedAmount")]
        public SearchColumnDoubleField[] foreignProjectedAmount {
            get {
                return this.foreignProjectedAmountField;
            }
            set {
                this.foreignProjectedAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("foreignRangeHigh")]
        public SearchColumnDoubleField[] foreignRangeHigh {
            get {
                return this.foreignRangeHighField;
            }
            set {
                this.foreignRangeHighField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("foreignRangeLow")]
        public SearchColumnDoubleField[] foreignRangeLow {
            get {
                return this.foreignRangeLowField;
            }
            set {
                this.foreignRangeLowField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fxTranCostEstimate")]
        public SearchColumnDoubleField[] fxTranCostEstimate {
            get {
                return this.fxTranCostEstimateField;
            }
            set {
                this.fxTranCostEstimateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("internalId")]
        public SearchColumnSelectField[] internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isBudgetApproved")]
        public SearchColumnBooleanField[] isBudgetApproved {
            get {
                return this.isBudgetApprovedField;
            }
            set {
                this.isBudgetApprovedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lastModifiedDate")]
        public SearchColumnDateField[] lastModifiedDate {
            get {
                return this.lastModifiedDateField;
            }
            set {
                this.lastModifiedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("leadSource")]
        public SearchColumnSelectField[] leadSource {
            get {
                return this.leadSourceField;
            }
            set {
                this.leadSourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("location")]
        public SearchColumnSelectField[] location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("memo")]
        public SearchColumnStringField[] memo {
            get {
                return this.memoField;
            }
            set {
                this.memoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("partner")]
        public SearchColumnSelectField[] partner {
            get {
                return this.partnerField;
            }
            set {
                this.partnerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("partnerContribution")]
        public SearchColumnDoubleField[] partnerContribution {
            get {
                return this.partnerContributionField;
            }
            set {
                this.partnerContributionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("partnerRole")]
        public SearchColumnSelectField[] partnerRole {
            get {
                return this.partnerRoleField;
            }
            set {
                this.partnerRoleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("partnerTeamMember")]
        public SearchColumnSelectField[] partnerTeamMember {
            get {
                return this.partnerTeamMemberField;
            }
            set {
                this.partnerTeamMemberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("period")]
        public SearchColumnStringField[] period {
            get {
                return this.periodField;
            }
            set {
                this.periodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("probability")]
        public SearchColumnDoubleField[] probability {
            get {
                return this.probabilityField;
            }
            set {
                this.probabilityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("projAltSalesAmt")]
        public SearchColumnDoubleField[] projAltSalesAmt {
            get {
                return this.projAltSalesAmtField;
            }
            set {
                this.projAltSalesAmtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("projectedTotal")]
        public SearchColumnDoubleField[] projectedTotal {
            get {
                return this.projectedTotalField;
            }
            set {
                this.projectedTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("rangeHigh")]
        public SearchColumnDoubleField[] rangeHigh {
            get {
                return this.rangeHighField;
            }
            set {
                this.rangeHighField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("rangeHighAlt")]
        public SearchColumnDoubleField[] rangeHighAlt {
            get {
                return this.rangeHighAltField;
            }
            set {
                this.rangeHighAltField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("rangeLow")]
        public SearchColumnDoubleField[] rangeLow {
            get {
                return this.rangeLowField;
            }
            set {
                this.rangeLowField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("rangeLowAlt")]
        public SearchColumnDoubleField[] rangeLowAlt {
            get {
                return this.rangeLowAltField;
            }
            set {
                this.rangeLowAltField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("salesReadiness")]
        public SearchColumnStringField[] salesReadiness {
            get {
                return this.salesReadinessField;
            }
            set {
                this.salesReadinessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("salesRep")]
        public SearchColumnSelectField[] salesRep {
            get {
                return this.salesRepField;
            }
            set {
                this.salesRepField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("salesTeamMember")]
        public SearchColumnSelectField[] salesTeamMember {
            get {
                return this.salesTeamMemberField;
            }
            set {
                this.salesTeamMemberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("salesTeamRole")]
        public SearchColumnSelectField[] salesTeamRole {
            get {
                return this.salesTeamRoleField;
            }
            set {
                this.salesTeamRoleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("status")]
        public SearchColumnEnumSelectField[] status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("subsidiary")]
        public SearchColumnSelectField[] subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("taxPeriod")]
        public SearchColumnSelectField[] taxPeriod {
            get {
                return this.taxPeriodField;
            }
            set {
                this.taxPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("title")]
        public SearchColumnStringField[] title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("total")]
        public SearchColumnDoubleField[] total {
            get {
                return this.totalField;
            }
            set {
                this.totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tranCostEstimate")]
        public SearchColumnDoubleField[] tranCostEstimate {
            get {
                return this.tranCostEstimateField;
            }
            set {
                this.tranCostEstimateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tranDate")]
        public SearchColumnDateField[] tranDate {
            get {
                return this.tranDateField;
            }
            set {
                this.tranDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tranEstGrossProfit")]
        public SearchColumnDoubleField[] tranEstGrossProfit {
            get {
                return this.tranEstGrossProfitField;
            }
            set {
                this.tranEstGrossProfitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tranEstGrossProfitPct")]
        public SearchColumnDoubleField[] tranEstGrossProfitPct {
            get {
                return this.tranEstGrossProfitPctField;
            }
            set {
                this.tranEstGrossProfitPctField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tranFxEstGrossProfit")]
        public SearchColumnDoubleField[] tranFxEstGrossProfit {
            get {
                return this.tranFxEstGrossProfitField;
            }
            set {
                this.tranFxEstGrossProfitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tranId")]
        public SearchColumnStringField[] tranId {
            get {
                return this.tranIdField;
            }
            set {
                this.tranIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("weightedTotal")]
        public SearchColumnDoubleField[] weightedTotal {
            get {
                return this.weightedTotalField;
            }
            set {
                this.weightedTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("winLossReason")]
        public SearchColumnSelectField[] winLossReason {
            get {
                return this.winLossReasonField;
            }
            set {
                this.winLossReasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("wonBy")]
        public SearchColumnSelectField[] wonBy {
            get {
                return this.wonByField;
            }
            set {
                this.wonByField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("customField", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public SearchColumnCustomField[] customFieldList {
            get {
                return this.customFieldListField;
            }
            set {
                this.customFieldListField = value;
            }
        }
    }
}