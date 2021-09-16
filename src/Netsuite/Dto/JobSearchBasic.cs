namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class JobSearchBasic : SearchRecordBasic {

        private SearchStringField accountNumberField;

        private SearchDoubleField actualTimeField;

        private SearchStringField addressField;

        private SearchStringField addresseeField;

        private SearchStringField addressLabelField;

        private SearchStringField addressPhoneField;

        private SearchBooleanField allocatePayrollExpensesField;

        private SearchBooleanField allowAllResourcesForTasksField;

        private SearchBooleanField allowExpensesField;

        private SearchBooleanField allowTimeField;

        private SearchBooleanField applyProjectExpenseTypeToAllField;

        private SearchStringField attentionField;

        private SearchMultiSelectField billingRateCardField;

        private SearchMultiSelectField billingScheduleField;

        private SearchDateField calculatedEndDateField;

        private SearchDateField calculatedEndDateBaselineField;

        private SearchDateField calculatedStartDateField;

        private SearchMultiSelectField categoryField;

        private SearchStringField cityField;

        private SearchStringField commentsField;

        private SearchStringField contactField;

        private SearchEnumMultiSelectField countryField;

        private SearchStringField countyField;

        private SearchMultiSelectField customerField;

        private SearchDateField dateCreatedField;

        private SearchMultiSelectField defaultTaxRegField;

        private SearchStringField defaultTaxRegTextField;

        private SearchStringField emailField;

        private SearchDateField endDateField;

        private SearchStringField entityIdField;

        private SearchDoubleField estCostField;

        private SearchDateField estEndDateField;

        private SearchDoubleField estimatedGrossProfitField;

        private SearchDoubleField estimatedGrossProfitPercentField;

        private SearchDoubleField estimatedLaborCostField;

        private SearchDoubleField estimatedLaborCostBaselineField;

        private SearchDoubleField estimatedLaborRevenueField;

        private SearchDoubleField estimatedTimeField;

        private SearchDoubleField estimatedTimeOverrideField;

        private SearchDoubleField estimatedTimeOverrideBaselineField;

        private SearchDoubleField estRevenueField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchStringField faxField;

        private SearchBooleanField giveAccessField;

        private SearchEnumMultiSelectField globalSubscriptionStatusField;

        private SearchStringField imageField;

        private SearchBooleanField includeCrmTasksInTotalsField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchBooleanField isDefaultBillingField;

        private SearchBooleanField isDefaultShippingField;

        private SearchBooleanField isExemptTimeField;

        private SearchBooleanField isInactiveField;

        private SearchBooleanField isProductiveTimeField;

        private SearchBooleanField isUtilizedTimeField;

        private SearchEnumMultiSelectField jobBillingTypeField;

        private SearchMultiSelectField jobItemField;

        private SearchDoubleField jobPriceField;

        private SearchMultiSelectField jobResourceField;

        private SearchMultiSelectField jobResourceRoleField;

        private SearchEnumMultiSelectField languageField;

        private SearchDateField lastBaselineDateField;

        private SearchDateField lastModifiedDateField;

        private SearchEnumMultiSelectField levelField;

        private SearchBooleanField limitTimeToAssigneesField;

        private SearchBooleanField materializeTimeField;

        private SearchMultiSelectField parentField;

        private SearchLongField pctCompleteField;

        private SearchLongField percentTimeCompleteField;

        private SearchEnumMultiSelectField permissionField;

        private SearchStringField phoneField;

        private SearchStringField phoneticNameField;

        private SearchDoubleField plannedWorkField;

        private SearchDoubleField plannedWorkBaselineField;

        private SearchDateField projectedEndDateBaselineField;

        private SearchMultiSelectField projectExpenseTypeField;

        private SearchMultiSelectField projectManagerField;

        private SearchMultiSelectField revRecForecastRuleField;

        private SearchDateField scheduledEndDateField;

        private SearchEnumMultiSelectField schedulingMethodField;

        private SearchBooleanField sourceServiceItemFromRateCardField;

        private SearchDateField startDateField;

        private SearchDateField startDateBaselineField;

        private SearchStringField stateField;

        private SearchMultiSelectField statusField;

        private SearchMultiSelectField subsidiaryField;

        private SearchMultiSelectField timeApprovalField;

        private SearchDoubleField timeRemainingField;

        private SearchMultiSelectField typeField;

        private SearchBooleanField usePercentCompleteOverrideField;

        private SearchStringField zipCodeField;

        private SearchCustomField[] customFieldListField;

        /// <remarks/>
        public SearchStringField accountNumber {
            get {
                return this.accountNumberField;
            }
            set {
                this.accountNumberField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField actualTime {
            get {
                return this.actualTimeField;
            }
            set {
                this.actualTimeField = value;
            }
        }

        /// <remarks/>
        public SearchStringField address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
            }
        }

        /// <remarks/>
        public SearchStringField addressee {
            get {
                return this.addresseeField;
            }
            set {
                this.addresseeField = value;
            }
        }

        /// <remarks/>
        public SearchStringField addressLabel {
            get {
                return this.addressLabelField;
            }
            set {
                this.addressLabelField = value;
            }
        }

        /// <remarks/>
        public SearchStringField addressPhone {
            get {
                return this.addressPhoneField;
            }
            set {
                this.addressPhoneField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField allocatePayrollExpenses {
            get {
                return this.allocatePayrollExpensesField;
            }
            set {
                this.allocatePayrollExpensesField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField allowAllResourcesForTasks {
            get {
                return this.allowAllResourcesForTasksField;
            }
            set {
                this.allowAllResourcesForTasksField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField allowExpenses {
            get {
                return this.allowExpensesField;
            }
            set {
                this.allowExpensesField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField allowTime {
            get {
                return this.allowTimeField;
            }
            set {
                this.allowTimeField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField applyProjectExpenseTypeToAll {
            get {
                return this.applyProjectExpenseTypeToAllField;
            }
            set {
                this.applyProjectExpenseTypeToAllField = value;
            }
        }

        /// <remarks/>
        public SearchStringField attention {
            get {
                return this.attentionField;
            }
            set {
                this.attentionField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField billingRateCard {
            get {
                return this.billingRateCardField;
            }
            set {
                this.billingRateCardField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField billingSchedule {
            get {
                return this.billingScheduleField;
            }
            set {
                this.billingScheduleField = value;
            }
        }

        /// <remarks/>
        public SearchDateField calculatedEndDate {
            get {
                return this.calculatedEndDateField;
            }
            set {
                this.calculatedEndDateField = value;
            }
        }

        /// <remarks/>
        public SearchDateField calculatedEndDateBaseline {
            get {
                return this.calculatedEndDateBaselineField;
            }
            set {
                this.calculatedEndDateBaselineField = value;
            }
        }

        /// <remarks/>
        public SearchDateField calculatedStartDate {
            get {
                return this.calculatedStartDateField;
            }
            set {
                this.calculatedStartDateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        public SearchStringField city {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public SearchStringField comments {
            get {
                return this.commentsField;
            }
            set {
                this.commentsField = value;
            }
        }

        /// <remarks/>
        public SearchStringField contact {
            get {
                return this.contactField;
            }
            set {
                this.contactField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
            }
        }

        /// <remarks/>
        public SearchStringField county {
            get {
                return this.countyField;
            }
            set {
                this.countyField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField customer {
            get {
                return this.customerField;
            }
            set {
                this.customerField = value;
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
        public SearchMultiSelectField defaultTaxReg {
            get {
                return this.defaultTaxRegField;
            }
            set {
                this.defaultTaxRegField = value;
            }
        }

        /// <remarks/>
        public SearchStringField defaultTaxRegText {
            get {
                return this.defaultTaxRegTextField;
            }
            set {
                this.defaultTaxRegTextField = value;
            }
        }

        /// <remarks/>
        public SearchStringField email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }

        /// <remarks/>
        public SearchDateField endDate {
            get {
                return this.endDateField;
            }
            set {
                this.endDateField = value;
            }
        }

        /// <remarks/>
        public SearchStringField entityId {
            get {
                return this.entityIdField;
            }
            set {
                this.entityIdField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField estCost {
            get {
                return this.estCostField;
            }
            set {
                this.estCostField = value;
            }
        }

        /// <remarks/>
        public SearchDateField estEndDate {
            get {
                return this.estEndDateField;
            }
            set {
                this.estEndDateField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField estimatedGrossProfit {
            get {
                return this.estimatedGrossProfitField;
            }
            set {
                this.estimatedGrossProfitField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField estimatedGrossProfitPercent {
            get {
                return this.estimatedGrossProfitPercentField;
            }
            set {
                this.estimatedGrossProfitPercentField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField estimatedLaborCost {
            get {
                return this.estimatedLaborCostField;
            }
            set {
                this.estimatedLaborCostField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField estimatedLaborCostBaseline {
            get {
                return this.estimatedLaborCostBaselineField;
            }
            set {
                this.estimatedLaborCostBaselineField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField estimatedLaborRevenue {
            get {
                return this.estimatedLaborRevenueField;
            }
            set {
                this.estimatedLaborRevenueField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField estimatedTime {
            get {
                return this.estimatedTimeField;
            }
            set {
                this.estimatedTimeField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField estimatedTimeOverride {
            get {
                return this.estimatedTimeOverrideField;
            }
            set {
                this.estimatedTimeOverrideField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField estimatedTimeOverrideBaseline {
            get {
                return this.estimatedTimeOverrideBaselineField;
            }
            set {
                this.estimatedTimeOverrideBaselineField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField estRevenue {
            get {
                return this.estRevenueField;
            }
            set {
                this.estRevenueField = value;
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
        public SearchStringField fax {
            get {
                return this.faxField;
            }
            set {
                this.faxField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField giveAccess {
            get {
                return this.giveAccessField;
            }
            set {
                this.giveAccessField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField globalSubscriptionStatus {
            get {
                return this.globalSubscriptionStatusField;
            }
            set {
                this.globalSubscriptionStatusField = value;
            }
        }

        /// <remarks/>
        public SearchStringField image {
            get {
                return this.imageField;
            }
            set {
                this.imageField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField includeCrmTasksInTotals {
            get {
                return this.includeCrmTasksInTotalsField;
            }
            set {
                this.includeCrmTasksInTotalsField = value;
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
        public SearchBooleanField isDefaultBilling {
            get {
                return this.isDefaultBillingField;
            }
            set {
                this.isDefaultBillingField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isDefaultShipping {
            get {
                return this.isDefaultShippingField;
            }
            set {
                this.isDefaultShippingField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isExemptTime {
            get {
                return this.isExemptTimeField;
            }
            set {
                this.isExemptTimeField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isInactive {
            get {
                return this.isInactiveField;
            }
            set {
                this.isInactiveField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isProductiveTime {
            get {
                return this.isProductiveTimeField;
            }
            set {
                this.isProductiveTimeField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isUtilizedTime {
            get {
                return this.isUtilizedTimeField;
            }
            set {
                this.isUtilizedTimeField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField jobBillingType {
            get {
                return this.jobBillingTypeField;
            }
            set {
                this.jobBillingTypeField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField jobItem {
            get {
                return this.jobItemField;
            }
            set {
                this.jobItemField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField jobPrice {
            get {
                return this.jobPriceField;
            }
            set {
                this.jobPriceField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField jobResource {
            get {
                return this.jobResourceField;
            }
            set {
                this.jobResourceField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField jobResourceRole {
            get {
                return this.jobResourceRoleField;
            }
            set {
                this.jobResourceRoleField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
            }
        }

        /// <remarks/>
        public SearchDateField lastBaselineDate {
            get {
                return this.lastBaselineDateField;
            }
            set {
                this.lastBaselineDateField = value;
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
        public SearchEnumMultiSelectField level {
            get {
                return this.levelField;
            }
            set {
                this.levelField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField limitTimeToAssignees {
            get {
                return this.limitTimeToAssigneesField;
            }
            set {
                this.limitTimeToAssigneesField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField materializeTime {
            get {
                return this.materializeTimeField;
            }
            set {
                this.materializeTimeField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField parent {
            get {
                return this.parentField;
            }
            set {
                this.parentField = value;
            }
        }

        /// <remarks/>
        public SearchLongField pctComplete {
            get {
                return this.pctCompleteField;
            }
            set {
                this.pctCompleteField = value;
            }
        }

        /// <remarks/>
        public SearchLongField percentTimeComplete {
            get {
                return this.percentTimeCompleteField;
            }
            set {
                this.percentTimeCompleteField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField permission {
            get {
                return this.permissionField;
            }
            set {
                this.permissionField = value;
            }
        }

        /// <remarks/>
        public SearchStringField phone {
            get {
                return this.phoneField;
            }
            set {
                this.phoneField = value;
            }
        }

        /// <remarks/>
        public SearchStringField phoneticName {
            get {
                return this.phoneticNameField;
            }
            set {
                this.phoneticNameField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField plannedWork {
            get {
                return this.plannedWorkField;
            }
            set {
                this.plannedWorkField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField plannedWorkBaseline {
            get {
                return this.plannedWorkBaselineField;
            }
            set {
                this.plannedWorkBaselineField = value;
            }
        }

        /// <remarks/>
        public SearchDateField projectedEndDateBaseline {
            get {
                return this.projectedEndDateBaselineField;
            }
            set {
                this.projectedEndDateBaselineField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField projectExpenseType {
            get {
                return this.projectExpenseTypeField;
            }
            set {
                this.projectExpenseTypeField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField projectManager {
            get {
                return this.projectManagerField;
            }
            set {
                this.projectManagerField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField revRecForecastRule {
            get {
                return this.revRecForecastRuleField;
            }
            set {
                this.revRecForecastRuleField = value;
            }
        }

        /// <remarks/>
        public SearchDateField scheduledEndDate {
            get {
                return this.scheduledEndDateField;
            }
            set {
                this.scheduledEndDateField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField schedulingMethod {
            get {
                return this.schedulingMethodField;
            }
            set {
                this.schedulingMethodField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField sourceServiceItemFromRateCard {
            get {
                return this.sourceServiceItemFromRateCardField;
            }
            set {
                this.sourceServiceItemFromRateCardField = value;
            }
        }

        /// <remarks/>
        public SearchDateField startDate {
            get {
                return this.startDateField;
            }
            set {
                this.startDateField = value;
            }
        }

        /// <remarks/>
        public SearchDateField startDateBaseline {
            get {
                return this.startDateBaselineField;
            }
            set {
                this.startDateBaselineField = value;
            }
        }

        /// <remarks/>
        public SearchStringField state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField status {
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
        public SearchMultiSelectField timeApproval {
            get {
                return this.timeApprovalField;
            }
            set {
                this.timeApprovalField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField timeRemaining {
            get {
                return this.timeRemainingField;
            }
            set {
                this.timeRemainingField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField usePercentCompleteOverride {
            get {
                return this.usePercentCompleteOverrideField;
            }
            set {
                this.usePercentCompleteOverrideField = value;
            }
        }

        /// <remarks/>
        public SearchStringField zipCode {
            get {
                return this.zipCodeField;
            }
            set {
                this.zipCodeField = value;
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