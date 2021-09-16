namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:relationships_2021_1.lists.webservices.netsuite.com")]
    public partial class Job : Record {

        private RecordRef customFormField;

        private string entityIdField;

        private string altNameField;

        private string companyNameField;

        private string phoneticNameField;

        private RecordRef entityStatusField;

        private string defaultAddressField;

        private RecordRef parentField;

        private bool isInactiveField;

        private bool isInactiveFieldSpecified;

        private JobPercentCompleteOverrideList percentCompleteOverrideListField;

        private System.DateTime lastModifiedDateField;

        private bool lastModifiedDateFieldSpecified;

        private bool billPayField;

        private bool billPayFieldSpecified;

        private System.DateTime dateCreatedField;

        private bool dateCreatedFieldSpecified;

        private RecordRef categoryField;

        private RecordRef workplaceField;

        private RecordRef languageField;

        private string commentsField;

        private string accountNumberField;

        private RecordRef currencyField;

        private double fxRateField;

        private bool fxRateFieldSpecified;

        private System.DateTime startDateField;

        private bool startDateFieldSpecified;

        private System.DateTime endDateField;

        private bool endDateFieldSpecified;

        private string phoneField;

        private string altPhoneField;

        private System.DateTime calculatedEndDateField;

        private bool calculatedEndDateFieldSpecified;

        private System.DateTime calculatedEndDateBaselineField;

        private bool calculatedEndDateBaselineFieldSpecified;

        private System.DateTime startDateBaselineField;

        private bool startDateBaselineFieldSpecified;

        private System.DateTime projectedEndDateField;

        private bool projectedEndDateFieldSpecified;

        private System.DateTime projectedEndDateBaselineField;

        private bool projectedEndDateBaselineFieldSpecified;

        private System.DateTime lastBaselineDateField;

        private bool lastBaselineDateFieldSpecified;

        private RecordRef jobTypeField;

        private double percentCompleteField;

        private bool percentCompleteFieldSpecified;

        private double estimatedCostField;

        private bool estimatedCostFieldSpecified;

        private double estimatedRevenueField;

        private bool estimatedRevenueFieldSpecified;

        private Duration estimatedTimeField;

        private Duration estimatedTimeOverrideField;

        private string faxField;

        private string emailField;

        private EmailPreference emailPreferenceField;

        private bool emailPreferenceFieldSpecified;

        private double openingBalanceField;

        private bool openingBalanceFieldSpecified;

        private System.DateTime openingBalanceDateField;

        private bool openingBalanceDateFieldSpecified;

        private RecordRef openingBalanceAccountField;

        private RecordRef subsidiaryField;

        private JobBillingType jobBillingTypeField;

        private bool jobBillingTypeFieldSpecified;

        private RecordRef billingScheduleField;

        private RecordRef jobItemField;

        private double percentTimeCompleteField;

        private bool percentTimeCompleteFieldSpecified;

        private Duration actualTimeField;

        private bool allowTimeField;

        private bool allowTimeFieldSpecified;

        private Duration timeRemainingField;

        private bool limitTimeToAssigneesField;

        private bool limitTimeToAssigneesFieldSpecified;

        private double estimatedLaborCostField;

        private bool estimatedLaborCostFieldSpecified;

        private double estimatedLaborCostBaselineField;

        private bool estimatedLaborCostBaselineFieldSpecified;

        private RecordRef estimateRevRecTemplateField;

        private RecordRef revRecForecastRuleField;

        private bool usePercentCompleteOverrideField;

        private bool usePercentCompleteOverrideFieldSpecified;

        private double estimatedLaborRevenueField;

        private bool estimatedLaborRevenueFieldSpecified;

        private double estimatedGrossProfitField;

        private bool estimatedGrossProfitFieldSpecified;

        private double estimatedGrossProfitPercentField;

        private bool estimatedGrossProfitPercentFieldSpecified;

        private RecordRef projectExpenseTypeField;

        private bool applyProjectExpenseTypeToAllField;

        private bool applyProjectExpenseTypeToAllFieldSpecified;

        private bool allowAllResourcesForTasksField;

        private bool allowAllResourcesForTasksFieldSpecified;

        private double jobPriceField;

        private bool jobPriceFieldSpecified;

        private bool isUtilizedTimeField;

        private bool isUtilizedTimeFieldSpecified;

        private bool isProductiveTimeField;

        private bool isProductiveTimeFieldSpecified;

        private bool isExemptTimeField;

        private bool isExemptTimeFieldSpecified;

        private bool materializeTimeField;

        private bool materializeTimeFieldSpecified;

        private bool allowExpensesField;

        private bool allowExpensesFieldSpecified;

        private bool allocatePayrollExpensesField;

        private bool allocatePayrollExpensesFieldSpecified;

        private bool includeCrmTasksInTotalsField;

        private bool includeCrmTasksInTotalsFieldSpecified;

        private GlobalSubscriptionStatus globalSubscriptionStatusField;

        private bool globalSubscriptionStatusFieldSpecified;

        private JobResourcesList jobResourcesListField;

        private JobPlStatementList plStatementListField;

        private JobAddressbookList addressbookListField;

        private JobMilestonesList milestonesListField;

        private JobCreditCardsList creditCardsListField;

        private RecordRef timeApprovalField;

        private Duration plannedWorkField;

        private Duration plannedWorkBaselineField;

        private RecordRef billingRateCardField;

        private bool createChargeRuleField;

        private bool createChargeRuleFieldSpecified;

        private bool sourceServiceItemFromRateCardField;

        private bool sourceServiceItemFromRateCardFieldSpecified;

        private RecordRef projectManagerField;

        private JobSchedulingMethod schedulingMethodField;

        private bool schedulingMethodFieldSpecified;

        private System.DateTime scheduledEndDateField;

        private bool scheduledEndDateFieldSpecified;

        private System.DateTime calculatedStartDateField;

        private bool calculatedStartDateFieldSpecified;

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
        public string entityId {
            get {
                return this.entityIdField;
            }
            set {
                this.entityIdField = value;
            }
        }

        /// <remarks/>
        public string altName {
            get {
                return this.altNameField;
            }
            set {
                this.altNameField = value;
            }
        }

        /// <remarks/>
        public string companyName {
            get {
                return this.companyNameField;
            }
            set {
                this.companyNameField = value;
            }
        }

        /// <remarks/>
        public string phoneticName {
            get {
                return this.phoneticNameField;
            }
            set {
                this.phoneticNameField = value;
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
        public string defaultAddress {
            get {
                return this.defaultAddressField;
            }
            set {
                this.defaultAddressField = value;
            }
        }

        /// <remarks/>
        public RecordRef parent {
            get {
                return this.parentField;
            }
            set {
                this.parentField = value;
            }
        }

        /// <remarks/>
        public bool isInactive {
            get {
                return this.isInactiveField;
            }
            set {
                this.isInactiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isInactiveSpecified {
            get {
                return this.isInactiveFieldSpecified;
            }
            set {
                this.isInactiveFieldSpecified = value;
            }
        }

        /// <remarks/>
        public JobPercentCompleteOverrideList percentCompleteOverrideList {
            get {
                return this.percentCompleteOverrideListField;
            }
            set {
                this.percentCompleteOverrideListField = value;
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
        public bool billPay {
            get {
                return this.billPayField;
            }
            set {
                this.billPayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool billPaySpecified {
            get {
                return this.billPayFieldSpecified;
            }
            set {
                this.billPayFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime dateCreated {
            get {
                return this.dateCreatedField;
            }
            set {
                this.dateCreatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dateCreatedSpecified {
            get {
                return this.dateCreatedFieldSpecified;
            }
            set {
                this.dateCreatedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        public RecordRef workplace {
            get {
                return this.workplaceField;
            }
            set {
                this.workplaceField = value;
            }
        }

        /// <remarks/>
        public RecordRef language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
            }
        }

        /// <remarks/>
        public string comments {
            get {
                return this.commentsField;
            }
            set {
                this.commentsField = value;
            }
        }

        /// <remarks/>
        public string accountNumber {
            get {
                return this.accountNumberField;
            }
            set {
                this.accountNumberField = value;
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
        public double fxRate {
            get {
                return this.fxRateField;
            }
            set {
                this.fxRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fxRateSpecified {
            get {
                return this.fxRateFieldSpecified;
            }
            set {
                this.fxRateFieldSpecified = value;
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
        public string phone {
            get {
                return this.phoneField;
            }
            set {
                this.phoneField = value;
            }
        }

        /// <remarks/>
        public string altPhone {
            get {
                return this.altPhoneField;
            }
            set {
                this.altPhoneField = value;
            }
        }

        /// <remarks/>
        public System.DateTime calculatedEndDate {
            get {
                return this.calculatedEndDateField;
            }
            set {
                this.calculatedEndDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool calculatedEndDateSpecified {
            get {
                return this.calculatedEndDateFieldSpecified;
            }
            set {
                this.calculatedEndDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime calculatedEndDateBaseline {
            get {
                return this.calculatedEndDateBaselineField;
            }
            set {
                this.calculatedEndDateBaselineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool calculatedEndDateBaselineSpecified {
            get {
                return this.calculatedEndDateBaselineFieldSpecified;
            }
            set {
                this.calculatedEndDateBaselineFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime startDateBaseline {
            get {
                return this.startDateBaselineField;
            }
            set {
                this.startDateBaselineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool startDateBaselineSpecified {
            get {
                return this.startDateBaselineFieldSpecified;
            }
            set {
                this.startDateBaselineFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime projectedEndDate {
            get {
                return this.projectedEndDateField;
            }
            set {
                this.projectedEndDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool projectedEndDateSpecified {
            get {
                return this.projectedEndDateFieldSpecified;
            }
            set {
                this.projectedEndDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime projectedEndDateBaseline {
            get {
                return this.projectedEndDateBaselineField;
            }
            set {
                this.projectedEndDateBaselineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool projectedEndDateBaselineSpecified {
            get {
                return this.projectedEndDateBaselineFieldSpecified;
            }
            set {
                this.projectedEndDateBaselineFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime lastBaselineDate {
            get {
                return this.lastBaselineDateField;
            }
            set {
                this.lastBaselineDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lastBaselineDateSpecified {
            get {
                return this.lastBaselineDateFieldSpecified;
            }
            set {
                this.lastBaselineDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef jobType {
            get {
                return this.jobTypeField;
            }
            set {
                this.jobTypeField = value;
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
        public double estimatedCost {
            get {
                return this.estimatedCostField;
            }
            set {
                this.estimatedCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool estimatedCostSpecified {
            get {
                return this.estimatedCostFieldSpecified;
            }
            set {
                this.estimatedCostFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double estimatedRevenue {
            get {
                return this.estimatedRevenueField;
            }
            set {
                this.estimatedRevenueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool estimatedRevenueSpecified {
            get {
                return this.estimatedRevenueFieldSpecified;
            }
            set {
                this.estimatedRevenueFieldSpecified = value;
            }
        }

        /// <remarks/>
        public Duration estimatedTime {
            get {
                return this.estimatedTimeField;
            }
            set {
                this.estimatedTimeField = value;
            }
        }

        /// <remarks/>
        public Duration estimatedTimeOverride {
            get {
                return this.estimatedTimeOverrideField;
            }
            set {
                this.estimatedTimeOverrideField = value;
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
        public string email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }

        /// <remarks/>
        public EmailPreference emailPreference {
            get {
                return this.emailPreferenceField;
            }
            set {
                this.emailPreferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool emailPreferenceSpecified {
            get {
                return this.emailPreferenceFieldSpecified;
            }
            set {
                this.emailPreferenceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double openingBalance {
            get {
                return this.openingBalanceField;
            }
            set {
                this.openingBalanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool openingBalanceSpecified {
            get {
                return this.openingBalanceFieldSpecified;
            }
            set {
                this.openingBalanceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime openingBalanceDate {
            get {
                return this.openingBalanceDateField;
            }
            set {
                this.openingBalanceDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool openingBalanceDateSpecified {
            get {
                return this.openingBalanceDateFieldSpecified;
            }
            set {
                this.openingBalanceDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef openingBalanceAccount {
            get {
                return this.openingBalanceAccountField;
            }
            set {
                this.openingBalanceAccountField = value;
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
        public JobBillingType jobBillingType {
            get {
                return this.jobBillingTypeField;
            }
            set {
                this.jobBillingTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool jobBillingTypeSpecified {
            get {
                return this.jobBillingTypeFieldSpecified;
            }
            set {
                this.jobBillingTypeFieldSpecified = value;
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
        public RecordRef jobItem {
            get {
                return this.jobItemField;
            }
            set {
                this.jobItemField = value;
            }
        }

        /// <remarks/>
        public double percentTimeComplete {
            get {
                return this.percentTimeCompleteField;
            }
            set {
                this.percentTimeCompleteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool percentTimeCompleteSpecified {
            get {
                return this.percentTimeCompleteFieldSpecified;
            }
            set {
                this.percentTimeCompleteFieldSpecified = value;
            }
        }

        /// <remarks/>
        public Duration actualTime {
            get {
                return this.actualTimeField;
            }
            set {
                this.actualTimeField = value;
            }
        }

        /// <remarks/>
        public bool allowTime {
            get {
                return this.allowTimeField;
            }
            set {
                this.allowTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool allowTimeSpecified {
            get {
                return this.allowTimeFieldSpecified;
            }
            set {
                this.allowTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public Duration timeRemaining {
            get {
                return this.timeRemainingField;
            }
            set {
                this.timeRemainingField = value;
            }
        }

        /// <remarks/>
        public bool limitTimeToAssignees {
            get {
                return this.limitTimeToAssigneesField;
            }
            set {
                this.limitTimeToAssigneesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool limitTimeToAssigneesSpecified {
            get {
                return this.limitTimeToAssigneesFieldSpecified;
            }
            set {
                this.limitTimeToAssigneesFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double estimatedLaborCost {
            get {
                return this.estimatedLaborCostField;
            }
            set {
                this.estimatedLaborCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool estimatedLaborCostSpecified {
            get {
                return this.estimatedLaborCostFieldSpecified;
            }
            set {
                this.estimatedLaborCostFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double estimatedLaborCostBaseline {
            get {
                return this.estimatedLaborCostBaselineField;
            }
            set {
                this.estimatedLaborCostBaselineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool estimatedLaborCostBaselineSpecified {
            get {
                return this.estimatedLaborCostBaselineFieldSpecified;
            }
            set {
                this.estimatedLaborCostBaselineFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef estimateRevRecTemplate {
            get {
                return this.estimateRevRecTemplateField;
            }
            set {
                this.estimateRevRecTemplateField = value;
            }
        }

        /// <remarks/>
        public RecordRef revRecForecastRule {
            get {
                return this.revRecForecastRuleField;
            }
            set {
                this.revRecForecastRuleField = value;
            }
        }

        /// <remarks/>
        public bool usePercentCompleteOverride {
            get {
                return this.usePercentCompleteOverrideField;
            }
            set {
                this.usePercentCompleteOverrideField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool usePercentCompleteOverrideSpecified {
            get {
                return this.usePercentCompleteOverrideFieldSpecified;
            }
            set {
                this.usePercentCompleteOverrideFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double estimatedLaborRevenue {
            get {
                return this.estimatedLaborRevenueField;
            }
            set {
                this.estimatedLaborRevenueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool estimatedLaborRevenueSpecified {
            get {
                return this.estimatedLaborRevenueFieldSpecified;
            }
            set {
                this.estimatedLaborRevenueFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double estimatedGrossProfit {
            get {
                return this.estimatedGrossProfitField;
            }
            set {
                this.estimatedGrossProfitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool estimatedGrossProfitSpecified {
            get {
                return this.estimatedGrossProfitFieldSpecified;
            }
            set {
                this.estimatedGrossProfitFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double estimatedGrossProfitPercent {
            get {
                return this.estimatedGrossProfitPercentField;
            }
            set {
                this.estimatedGrossProfitPercentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool estimatedGrossProfitPercentSpecified {
            get {
                return this.estimatedGrossProfitPercentFieldSpecified;
            }
            set {
                this.estimatedGrossProfitPercentFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef projectExpenseType {
            get {
                return this.projectExpenseTypeField;
            }
            set {
                this.projectExpenseTypeField = value;
            }
        }

        /// <remarks/>
        public bool applyProjectExpenseTypeToAll {
            get {
                return this.applyProjectExpenseTypeToAllField;
            }
            set {
                this.applyProjectExpenseTypeToAllField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool applyProjectExpenseTypeToAllSpecified {
            get {
                return this.applyProjectExpenseTypeToAllFieldSpecified;
            }
            set {
                this.applyProjectExpenseTypeToAllFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool allowAllResourcesForTasks {
            get {
                return this.allowAllResourcesForTasksField;
            }
            set {
                this.allowAllResourcesForTasksField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool allowAllResourcesForTasksSpecified {
            get {
                return this.allowAllResourcesForTasksFieldSpecified;
            }
            set {
                this.allowAllResourcesForTasksFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double jobPrice {
            get {
                return this.jobPriceField;
            }
            set {
                this.jobPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool jobPriceSpecified {
            get {
                return this.jobPriceFieldSpecified;
            }
            set {
                this.jobPriceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isUtilizedTime {
            get {
                return this.isUtilizedTimeField;
            }
            set {
                this.isUtilizedTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isUtilizedTimeSpecified {
            get {
                return this.isUtilizedTimeFieldSpecified;
            }
            set {
                this.isUtilizedTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isProductiveTime {
            get {
                return this.isProductiveTimeField;
            }
            set {
                this.isProductiveTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isProductiveTimeSpecified {
            get {
                return this.isProductiveTimeFieldSpecified;
            }
            set {
                this.isProductiveTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isExemptTime {
            get {
                return this.isExemptTimeField;
            }
            set {
                this.isExemptTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isExemptTimeSpecified {
            get {
                return this.isExemptTimeFieldSpecified;
            }
            set {
                this.isExemptTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool materializeTime {
            get {
                return this.materializeTimeField;
            }
            set {
                this.materializeTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool materializeTimeSpecified {
            get {
                return this.materializeTimeFieldSpecified;
            }
            set {
                this.materializeTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool allowExpenses {
            get {
                return this.allowExpensesField;
            }
            set {
                this.allowExpensesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool allowExpensesSpecified {
            get {
                return this.allowExpensesFieldSpecified;
            }
            set {
                this.allowExpensesFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool allocatePayrollExpenses {
            get {
                return this.allocatePayrollExpensesField;
            }
            set {
                this.allocatePayrollExpensesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool allocatePayrollExpensesSpecified {
            get {
                return this.allocatePayrollExpensesFieldSpecified;
            }
            set {
                this.allocatePayrollExpensesFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool includeCrmTasksInTotals {
            get {
                return this.includeCrmTasksInTotalsField;
            }
            set {
                this.includeCrmTasksInTotalsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool includeCrmTasksInTotalsSpecified {
            get {
                return this.includeCrmTasksInTotalsFieldSpecified;
            }
            set {
                this.includeCrmTasksInTotalsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public GlobalSubscriptionStatus globalSubscriptionStatus {
            get {
                return this.globalSubscriptionStatusField;
            }
            set {
                this.globalSubscriptionStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool globalSubscriptionStatusSpecified {
            get {
                return this.globalSubscriptionStatusFieldSpecified;
            }
            set {
                this.globalSubscriptionStatusFieldSpecified = value;
            }
        }

        /// <remarks/>
        public JobResourcesList jobResourcesList {
            get {
                return this.jobResourcesListField;
            }
            set {
                this.jobResourcesListField = value;
            }
        }

        /// <remarks/>
        public JobPlStatementList plStatementList {
            get {
                return this.plStatementListField;
            }
            set {
                this.plStatementListField = value;
            }
        }

        /// <remarks/>
        public JobAddressbookList addressbookList {
            get {
                return this.addressbookListField;
            }
            set {
                this.addressbookListField = value;
            }
        }

        /// <remarks/>
        public JobMilestonesList milestonesList {
            get {
                return this.milestonesListField;
            }
            set {
                this.milestonesListField = value;
            }
        }

        /// <remarks/>
        public JobCreditCardsList creditCardsList {
            get {
                return this.creditCardsListField;
            }
            set {
                this.creditCardsListField = value;
            }
        }

        /// <remarks/>
        public RecordRef timeApproval {
            get {
                return this.timeApprovalField;
            }
            set {
                this.timeApprovalField = value;
            }
        }

        /// <remarks/>
        public Duration plannedWork {
            get {
                return this.plannedWorkField;
            }
            set {
                this.plannedWorkField = value;
            }
        }

        /// <remarks/>
        public Duration plannedWorkBaseline {
            get {
                return this.plannedWorkBaselineField;
            }
            set {
                this.plannedWorkBaselineField = value;
            }
        }

        /// <remarks/>
        public RecordRef billingRateCard {
            get {
                return this.billingRateCardField;
            }
            set {
                this.billingRateCardField = value;
            }
        }

        /// <remarks/>
        public bool createChargeRule {
            get {
                return this.createChargeRuleField;
            }
            set {
                this.createChargeRuleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool createChargeRuleSpecified {
            get {
                return this.createChargeRuleFieldSpecified;
            }
            set {
                this.createChargeRuleFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool sourceServiceItemFromRateCard {
            get {
                return this.sourceServiceItemFromRateCardField;
            }
            set {
                this.sourceServiceItemFromRateCardField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sourceServiceItemFromRateCardSpecified {
            get {
                return this.sourceServiceItemFromRateCardFieldSpecified;
            }
            set {
                this.sourceServiceItemFromRateCardFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef projectManager {
            get {
                return this.projectManagerField;
            }
            set {
                this.projectManagerField = value;
            }
        }

        /// <remarks/>
        public JobSchedulingMethod schedulingMethod {
            get {
                return this.schedulingMethodField;
            }
            set {
                this.schedulingMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool schedulingMethodSpecified {
            get {
                return this.schedulingMethodFieldSpecified;
            }
            set {
                this.schedulingMethodFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime scheduledEndDate {
            get {
                return this.scheduledEndDateField;
            }
            set {
                this.scheduledEndDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool scheduledEndDateSpecified {
            get {
                return this.scheduledEndDateFieldSpecified;
            }
            set {
                this.scheduledEndDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime calculatedStartDate {
            get {
                return this.calculatedStartDateField;
            }
            set {
                this.calculatedStartDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool calculatedStartDateSpecified {
            get {
                return this.calculatedStartDateFieldSpecified;
            }
            set {
                this.calculatedStartDateFieldSpecified = value;
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