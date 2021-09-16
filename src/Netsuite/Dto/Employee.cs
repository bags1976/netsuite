namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:employees_2021_1.lists.webservices.netsuite.com")]
    public partial class Employee : Record {

        private RecordRef customFormField;

        private RecordRef templateField;

        private string entityIdField;

        private string salutationField;

        private string firstNameField;

        private string middleNameField;

        private string lastNameField;

        private string altNameField;

        private string phoneField;

        private string faxField;

        private string emailField;

        private string defaultAddressField;

        private bool isInactiveField;

        private bool isInactiveFieldSpecified;

        private string phoneticNameField;

        private System.DateTime lastModifiedDateField;

        private bool lastModifiedDateFieldSpecified;

        private System.DateTime dateCreatedField;

        private bool dateCreatedFieldSpecified;

        private string initialsField;

        private string officePhoneField;

        private string homePhoneField;

        private string mobilePhoneField;

        private RecordRef departmentField;

        private RecordRef classField;

        private RecordRef locationField;

        private RecordRef subsidiaryField;

        private RecordRef billingClassField;

        private string accountNumberField;

        private EmployeeCompensationCurrency compensationCurrencyField;

        private bool compensationCurrencyFieldSpecified;

        private EmployeeBaseWageType baseWageTypeField;

        private bool baseWageTypeFieldSpecified;

        private double baseWageField;

        private bool baseWageFieldSpecified;

        private string commentsField;

        private GlobalSubscriptionStatus globalSubscriptionStatusField;

        private bool globalSubscriptionStatusFieldSpecified;

        private RecordRef imageField;

        private EmployeePayFrequency payFrequencyField;

        private bool payFrequencyFieldSpecified;

        private System.DateTime lastPaidDateField;

        private bool lastPaidDateFieldSpecified;

        private RecordRef currencyField;

        private EmployeeUseTimeData useTimeDataField;

        private bool useTimeDataFieldSpecified;

        private bool usePerquestField;

        private bool usePerquestFieldSpecified;

        private RecordRef workplaceField;

        private string adpIdField;

        private bool directDepositField;

        private bool directDepositFieldSpecified;

        private double expenseLimitField;

        private bool expenseLimitFieldSpecified;

        private double purchaseOrderLimitField;

        private bool purchaseOrderLimitFieldSpecified;

        private double purchaseOrderApprovalLimitField;

        private bool purchaseOrderApprovalLimitFieldSpecified;

        private string socialSecurityNumberField;

        private RecordRef supervisorField;

        private RecordRef approverField;

        private double approvalLimitField;

        private bool approvalLimitFieldSpecified;

        private RecordRef timeApproverField;

        private RecordRef employeeTypeField;

        private bool isSalesRepField;

        private bool isSalesRepFieldSpecified;

        private RecordRef salesRoleField;

        private bool isSupportRepField;

        private bool isSupportRepFieldSpecified;

        private bool isJobResourceField;

        private bool isJobResourceFieldSpecified;

        private double laborCostField;

        private bool laborCostFieldSpecified;

        private System.DateTime birthDateField;

        private bool birthDateFieldSpecified;

        private System.DateTime hireDateField;

        private bool hireDateFieldSpecified;

        private System.DateTime releaseDateField;

        private bool releaseDateFieldSpecified;

        private string terminationDetailsField;

        private RecordRef terminationReasonField;

        private EmployeeTerminationRegretted terminationRegrettedField;

        private bool terminationRegrettedFieldSpecified;

        private EmployeeTerminationCategory terminationCategoryField;

        private bool terminationCategoryFieldSpecified;

        private RecordRef timeOffPlanField;

        private System.DateTime lastReviewDateField;

        private bool lastReviewDateFieldSpecified;

        private System.DateTime nextReviewDateField;

        private bool nextReviewDateFieldSpecified;

        private string titleField;

        private RecordRef employeeStatusField;

        private string jobDescriptionField;

        private EmployeeWorkAssignment workAssignmentField;

        private bool workAssignmentFieldSpecified;

        private RecordRef jobField;

        private RecordRef maritalStatusField;

        private RecordRef ethnicityField;

        private Gender genderField;

        private bool genderFieldSpecified;

        private RecordRef purchaseOrderApproverField;

        private RecordRef workCalendarField;

        private bool giveAccessField;

        private bool giveAccessFieldSpecified;

        private RecordRef defaultExpenseReportCurrencyField;

        private bool concurrentWebServicesUserField;

        private bool concurrentWebServicesUserFieldSpecified;

        private bool sendEmailField;

        private bool sendEmailFieldSpecified;

        private bool hasOfflineAccessField;

        private bool hasOfflineAccessFieldSpecified;

        private string passwordField;

        private string password2Field;

        private bool requirePwdChangeField;

        private bool requirePwdChangeFieldSpecified;

        private bool inheritIPRulesField;

        private bool inheritIPRulesFieldSpecified;

        private string iPAddressRuleField;

        private System.DateTime startDateTimeOffCalcField;

        private bool startDateTimeOffCalcFieldSpecified;

        private EmployeeCommissionPaymentPreference commissionPaymentPreferenceField;

        private bool commissionPaymentPreferenceFieldSpecified;

        private bool billPayField;

        private bool billPayFieldSpecified;

        private RecordRef defaultAcctCorpCardExpField;

        private bool eligibleForCommissionField;

        private bool eligibleForCommissionFieldSpecified;

        private EmployeeSubscriptionsList subscriptionsListField;

        private EmployeeRatesList ratesListField;

        private EmployeeAddressbookList addressbookListField;

        private EmployeeRolesList rolesListField;

        private EmployeeHrEducationList hrEducationListField;

        private EmployeeAccruedTimeList accruedTimeListField;

        private EmployeeDirectDepositList directDepositListField;

        private EmployeeCurrencyList currencyListField;

        private EmployeeCompanyContributionList companyContributionListField;

        private EmployeeEarningList earningListField;

        private EmployeeEmergencyContactList emergencyContactListField;

        private EmployeeHcmPositionList hcmPositionListField;

        private EmployeeDeductionList deductionListField;

        private bool isJobManagerField;

        private bool isJobManagerFieldSpecified;

        private double targetUtilizationField;

        private bool targetUtilizationFieldSpecified;

        private double bonusTargetField;

        private bool bonusTargetFieldSpecified;

        private string bonusTargetCommentField;

        private EmployeeBonusTargetType bonusTargetTypeField;

        private bool bonusTargetTypeFieldSpecified;

        private EmployeeBonusTargetPayFrequency bonusTargetPayFrequencyField;

        private bool bonusTargetPayFrequencyFieldSpecified;

        private EmployeeCorporateCardsList corporateCardsListField;

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
        public RecordRef template {
            get {
                return this.templateField;
            }
            set {
                this.templateField = value;
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
        public string salutation {
            get {
                return this.salutationField;
            }
            set {
                this.salutationField = value;
            }
        }

        /// <remarks/>
        public string firstName {
            get {
                return this.firstNameField;
            }
            set {
                this.firstNameField = value;
            }
        }

        /// <remarks/>
        public string middleName {
            get {
                return this.middleNameField;
            }
            set {
                this.middleNameField = value;
            }
        }

        /// <remarks/>
        public string lastName {
            get {
                return this.lastNameField;
            }
            set {
                this.lastNameField = value;
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
        public string phone {
            get {
                return this.phoneField;
            }
            set {
                this.phoneField = value;
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
        public string defaultAddress {
            get {
                return this.defaultAddressField;
            }
            set {
                this.defaultAddressField = value;
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
        public string phoneticName {
            get {
                return this.phoneticNameField;
            }
            set {
                this.phoneticNameField = value;
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
        public string initials {
            get {
                return this.initialsField;
            }
            set {
                this.initialsField = value;
            }
        }

        /// <remarks/>
        public string officePhone {
            get {
                return this.officePhoneField;
            }
            set {
                this.officePhoneField = value;
            }
        }

        /// <remarks/>
        public string homePhone {
            get {
                return this.homePhoneField;
            }
            set {
                this.homePhoneField = value;
            }
        }

        /// <remarks/>
        public string mobilePhone {
            get {
                return this.mobilePhoneField;
            }
            set {
                this.mobilePhoneField = value;
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
        public RecordRef billingClass {
            get {
                return this.billingClassField;
            }
            set {
                this.billingClassField = value;
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
        public EmployeeCompensationCurrency compensationCurrency {
            get {
                return this.compensationCurrencyField;
            }
            set {
                this.compensationCurrencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool compensationCurrencySpecified {
            get {
                return this.compensationCurrencyFieldSpecified;
            }
            set {
                this.compensationCurrencyFieldSpecified = value;
            }
        }

        /// <remarks/>
        public EmployeeBaseWageType baseWageType {
            get {
                return this.baseWageTypeField;
            }
            set {
                this.baseWageTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool baseWageTypeSpecified {
            get {
                return this.baseWageTypeFieldSpecified;
            }
            set {
                this.baseWageTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double baseWage {
            get {
                return this.baseWageField;
            }
            set {
                this.baseWageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool baseWageSpecified {
            get {
                return this.baseWageFieldSpecified;
            }
            set {
                this.baseWageFieldSpecified = value;
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
        public RecordRef image {
            get {
                return this.imageField;
            }
            set {
                this.imageField = value;
            }
        }

        /// <remarks/>
        public EmployeePayFrequency payFrequency {
            get {
                return this.payFrequencyField;
            }
            set {
                this.payFrequencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool payFrequencySpecified {
            get {
                return this.payFrequencyFieldSpecified;
            }
            set {
                this.payFrequencyFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime lastPaidDate {
            get {
                return this.lastPaidDateField;
            }
            set {
                this.lastPaidDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lastPaidDateSpecified {
            get {
                return this.lastPaidDateFieldSpecified;
            }
            set {
                this.lastPaidDateFieldSpecified = value;
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
        public EmployeeUseTimeData useTimeData {
            get {
                return this.useTimeDataField;
            }
            set {
                this.useTimeDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool useTimeDataSpecified {
            get {
                return this.useTimeDataFieldSpecified;
            }
            set {
                this.useTimeDataFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool usePerquest {
            get {
                return this.usePerquestField;
            }
            set {
                this.usePerquestField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool usePerquestSpecified {
            get {
                return this.usePerquestFieldSpecified;
            }
            set {
                this.usePerquestFieldSpecified = value;
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
        public string adpId {
            get {
                return this.adpIdField;
            }
            set {
                this.adpIdField = value;
            }
        }

        /// <remarks/>
        public bool directDeposit {
            get {
                return this.directDepositField;
            }
            set {
                this.directDepositField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool directDepositSpecified {
            get {
                return this.directDepositFieldSpecified;
            }
            set {
                this.directDepositFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double expenseLimit {
            get {
                return this.expenseLimitField;
            }
            set {
                this.expenseLimitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expenseLimitSpecified {
            get {
                return this.expenseLimitFieldSpecified;
            }
            set {
                this.expenseLimitFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double purchaseOrderLimit {
            get {
                return this.purchaseOrderLimitField;
            }
            set {
                this.purchaseOrderLimitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool purchaseOrderLimitSpecified {
            get {
                return this.purchaseOrderLimitFieldSpecified;
            }
            set {
                this.purchaseOrderLimitFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double purchaseOrderApprovalLimit {
            get {
                return this.purchaseOrderApprovalLimitField;
            }
            set {
                this.purchaseOrderApprovalLimitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool purchaseOrderApprovalLimitSpecified {
            get {
                return this.purchaseOrderApprovalLimitFieldSpecified;
            }
            set {
                this.purchaseOrderApprovalLimitFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string socialSecurityNumber {
            get {
                return this.socialSecurityNumberField;
            }
            set {
                this.socialSecurityNumberField = value;
            }
        }

        /// <remarks/>
        public RecordRef supervisor {
            get {
                return this.supervisorField;
            }
            set {
                this.supervisorField = value;
            }
        }

        /// <remarks/>
        public RecordRef approver {
            get {
                return this.approverField;
            }
            set {
                this.approverField = value;
            }
        }

        /// <remarks/>
        public double approvalLimit {
            get {
                return this.approvalLimitField;
            }
            set {
                this.approvalLimitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool approvalLimitSpecified {
            get {
                return this.approvalLimitFieldSpecified;
            }
            set {
                this.approvalLimitFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef timeApprover {
            get {
                return this.timeApproverField;
            }
            set {
                this.timeApproverField = value;
            }
        }

        /// <remarks/>
        public RecordRef employeeType {
            get {
                return this.employeeTypeField;
            }
            set {
                this.employeeTypeField = value;
            }
        }

        /// <remarks/>
        public bool isSalesRep {
            get {
                return this.isSalesRepField;
            }
            set {
                this.isSalesRepField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isSalesRepSpecified {
            get {
                return this.isSalesRepFieldSpecified;
            }
            set {
                this.isSalesRepFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef salesRole {
            get {
                return this.salesRoleField;
            }
            set {
                this.salesRoleField = value;
            }
        }

        /// <remarks/>
        public bool isSupportRep {
            get {
                return this.isSupportRepField;
            }
            set {
                this.isSupportRepField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isSupportRepSpecified {
            get {
                return this.isSupportRepFieldSpecified;
            }
            set {
                this.isSupportRepFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isJobResource {
            get {
                return this.isJobResourceField;
            }
            set {
                this.isJobResourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isJobResourceSpecified {
            get {
                return this.isJobResourceFieldSpecified;
            }
            set {
                this.isJobResourceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double laborCost {
            get {
                return this.laborCostField;
            }
            set {
                this.laborCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool laborCostSpecified {
            get {
                return this.laborCostFieldSpecified;
            }
            set {
                this.laborCostFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime birthDate {
            get {
                return this.birthDateField;
            }
            set {
                this.birthDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool birthDateSpecified {
            get {
                return this.birthDateFieldSpecified;
            }
            set {
                this.birthDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime hireDate {
            get {
                return this.hireDateField;
            }
            set {
                this.hireDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hireDateSpecified {
            get {
                return this.hireDateFieldSpecified;
            }
            set {
                this.hireDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime releaseDate {
            get {
                return this.releaseDateField;
            }
            set {
                this.releaseDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool releaseDateSpecified {
            get {
                return this.releaseDateFieldSpecified;
            }
            set {
                this.releaseDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string terminationDetails {
            get {
                return this.terminationDetailsField;
            }
            set {
                this.terminationDetailsField = value;
            }
        }

        /// <remarks/>
        public RecordRef terminationReason {
            get {
                return this.terminationReasonField;
            }
            set {
                this.terminationReasonField = value;
            }
        }

        /// <remarks/>
        public EmployeeTerminationRegretted terminationRegretted {
            get {
                return this.terminationRegrettedField;
            }
            set {
                this.terminationRegrettedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool terminationRegrettedSpecified {
            get {
                return this.terminationRegrettedFieldSpecified;
            }
            set {
                this.terminationRegrettedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public EmployeeTerminationCategory terminationCategory {
            get {
                return this.terminationCategoryField;
            }
            set {
                this.terminationCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool terminationCategorySpecified {
            get {
                return this.terminationCategoryFieldSpecified;
            }
            set {
                this.terminationCategoryFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef timeOffPlan {
            get {
                return this.timeOffPlanField;
            }
            set {
                this.timeOffPlanField = value;
            }
        }

        /// <remarks/>
        public System.DateTime lastReviewDate {
            get {
                return this.lastReviewDateField;
            }
            set {
                this.lastReviewDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lastReviewDateSpecified {
            get {
                return this.lastReviewDateFieldSpecified;
            }
            set {
                this.lastReviewDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime nextReviewDate {
            get {
                return this.nextReviewDateField;
            }
            set {
                this.nextReviewDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nextReviewDateSpecified {
            get {
                return this.nextReviewDateFieldSpecified;
            }
            set {
                this.nextReviewDateFieldSpecified = value;
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
        public RecordRef employeeStatus {
            get {
                return this.employeeStatusField;
            }
            set {
                this.employeeStatusField = value;
            }
        }

        /// <remarks/>
        public string jobDescription {
            get {
                return this.jobDescriptionField;
            }
            set {
                this.jobDescriptionField = value;
            }
        }

        /// <remarks/>
        public EmployeeWorkAssignment workAssignment {
            get {
                return this.workAssignmentField;
            }
            set {
                this.workAssignmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool workAssignmentSpecified {
            get {
                return this.workAssignmentFieldSpecified;
            }
            set {
                this.workAssignmentFieldSpecified = value;
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
        public RecordRef maritalStatus {
            get {
                return this.maritalStatusField;
            }
            set {
                this.maritalStatusField = value;
            }
        }

        /// <remarks/>
        public RecordRef ethnicity {
            get {
                return this.ethnicityField;
            }
            set {
                this.ethnicityField = value;
            }
        }

        /// <remarks/>
        public Gender gender {
            get {
                return this.genderField;
            }
            set {
                this.genderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool genderSpecified {
            get {
                return this.genderFieldSpecified;
            }
            set {
                this.genderFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef purchaseOrderApprover {
            get {
                return this.purchaseOrderApproverField;
            }
            set {
                this.purchaseOrderApproverField = value;
            }
        }

        /// <remarks/>
        public RecordRef workCalendar {
            get {
                return this.workCalendarField;
            }
            set {
                this.workCalendarField = value;
            }
        }

        /// <remarks/>
        public bool giveAccess {
            get {
                return this.giveAccessField;
            }
            set {
                this.giveAccessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool giveAccessSpecified {
            get {
                return this.giveAccessFieldSpecified;
            }
            set {
                this.giveAccessFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef defaultExpenseReportCurrency {
            get {
                return this.defaultExpenseReportCurrencyField;
            }
            set {
                this.defaultExpenseReportCurrencyField = value;
            }
        }

        /// <remarks/>
        public bool concurrentWebServicesUser {
            get {
                return this.concurrentWebServicesUserField;
            }
            set {
                this.concurrentWebServicesUserField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool concurrentWebServicesUserSpecified {
            get {
                return this.concurrentWebServicesUserFieldSpecified;
            }
            set {
                this.concurrentWebServicesUserFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool sendEmail {
            get {
                return this.sendEmailField;
            }
            set {
                this.sendEmailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sendEmailSpecified {
            get {
                return this.sendEmailFieldSpecified;
            }
            set {
                this.sendEmailFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool hasOfflineAccess {
            get {
                return this.hasOfflineAccessField;
            }
            set {
                this.hasOfflineAccessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hasOfflineAccessSpecified {
            get {
                return this.hasOfflineAccessFieldSpecified;
            }
            set {
                this.hasOfflineAccessFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }

        /// <remarks/>
        public string password2 {
            get {
                return this.password2Field;
            }
            set {
                this.password2Field = value;
            }
        }

        /// <remarks/>
        public bool requirePwdChange {
            get {
                return this.requirePwdChangeField;
            }
            set {
                this.requirePwdChangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool requirePwdChangeSpecified {
            get {
                return this.requirePwdChangeFieldSpecified;
            }
            set {
                this.requirePwdChangeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool inheritIPRules {
            get {
                return this.inheritIPRulesField;
            }
            set {
                this.inheritIPRulesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool inheritIPRulesSpecified {
            get {
                return this.inheritIPRulesFieldSpecified;
            }
            set {
                this.inheritIPRulesFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string IPAddressRule {
            get {
                return this.iPAddressRuleField;
            }
            set {
                this.iPAddressRuleField = value;
            }
        }

        /// <remarks/>
        public System.DateTime startDateTimeOffCalc {
            get {
                return this.startDateTimeOffCalcField;
            }
            set {
                this.startDateTimeOffCalcField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool startDateTimeOffCalcSpecified {
            get {
                return this.startDateTimeOffCalcFieldSpecified;
            }
            set {
                this.startDateTimeOffCalcFieldSpecified = value;
            }
        }

        /// <remarks/>
        public EmployeeCommissionPaymentPreference commissionPaymentPreference {
            get {
                return this.commissionPaymentPreferenceField;
            }
            set {
                this.commissionPaymentPreferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool commissionPaymentPreferenceSpecified {
            get {
                return this.commissionPaymentPreferenceFieldSpecified;
            }
            set {
                this.commissionPaymentPreferenceFieldSpecified = value;
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
        public RecordRef defaultAcctCorpCardExp {
            get {
                return this.defaultAcctCorpCardExpField;
            }
            set {
                this.defaultAcctCorpCardExpField = value;
            }
        }

        /// <remarks/>
        public bool eligibleForCommission {
            get {
                return this.eligibleForCommissionField;
            }
            set {
                this.eligibleForCommissionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool eligibleForCommissionSpecified {
            get {
                return this.eligibleForCommissionFieldSpecified;
            }
            set {
                this.eligibleForCommissionFieldSpecified = value;
            }
        }

        /// <remarks/>
        public EmployeeSubscriptionsList subscriptionsList {
            get {
                return this.subscriptionsListField;
            }
            set {
                this.subscriptionsListField = value;
            }
        }

        /// <remarks/>
        public EmployeeRatesList ratesList {
            get {
                return this.ratesListField;
            }
            set {
                this.ratesListField = value;
            }
        }

        /// <remarks/>
        public EmployeeAddressbookList addressbookList {
            get {
                return this.addressbookListField;
            }
            set {
                this.addressbookListField = value;
            }
        }

        /// <remarks/>
        public EmployeeRolesList rolesList {
            get {
                return this.rolesListField;
            }
            set {
                this.rolesListField = value;
            }
        }

        /// <remarks/>
        public EmployeeHrEducationList hrEducationList {
            get {
                return this.hrEducationListField;
            }
            set {
                this.hrEducationListField = value;
            }
        }

        /// <remarks/>
        public EmployeeAccruedTimeList accruedTimeList {
            get {
                return this.accruedTimeListField;
            }
            set {
                this.accruedTimeListField = value;
            }
        }

        /// <remarks/>
        public EmployeeDirectDepositList directDepositList {
            get {
                return this.directDepositListField;
            }
            set {
                this.directDepositListField = value;
            }
        }

        /// <remarks/>
        public EmployeeCurrencyList currencyList {
            get {
                return this.currencyListField;
            }
            set {
                this.currencyListField = value;
            }
        }

        /// <remarks/>
        public EmployeeCompanyContributionList companyContributionList {
            get {
                return this.companyContributionListField;
            }
            set {
                this.companyContributionListField = value;
            }
        }

        /// <remarks/>
        public EmployeeEarningList earningList {
            get {
                return this.earningListField;
            }
            set {
                this.earningListField = value;
            }
        }

        /// <remarks/>
        public EmployeeEmergencyContactList emergencyContactList {
            get {
                return this.emergencyContactListField;
            }
            set {
                this.emergencyContactListField = value;
            }
        }

        /// <remarks/>
        public EmployeeHcmPositionList hcmPositionList {
            get {
                return this.hcmPositionListField;
            }
            set {
                this.hcmPositionListField = value;
            }
        }

        /// <remarks/>
        public EmployeeDeductionList deductionList {
            get {
                return this.deductionListField;
            }
            set {
                this.deductionListField = value;
            }
        }

        /// <remarks/>
        public bool isJobManager {
            get {
                return this.isJobManagerField;
            }
            set {
                this.isJobManagerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isJobManagerSpecified {
            get {
                return this.isJobManagerFieldSpecified;
            }
            set {
                this.isJobManagerFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double targetUtilization {
            get {
                return this.targetUtilizationField;
            }
            set {
                this.targetUtilizationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool targetUtilizationSpecified {
            get {
                return this.targetUtilizationFieldSpecified;
            }
            set {
                this.targetUtilizationFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double bonusTarget {
            get {
                return this.bonusTargetField;
            }
            set {
                this.bonusTargetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bonusTargetSpecified {
            get {
                return this.bonusTargetFieldSpecified;
            }
            set {
                this.bonusTargetFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string bonusTargetComment {
            get {
                return this.bonusTargetCommentField;
            }
            set {
                this.bonusTargetCommentField = value;
            }
        }

        /// <remarks/>
        public EmployeeBonusTargetType bonusTargetType {
            get {
                return this.bonusTargetTypeField;
            }
            set {
                this.bonusTargetTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bonusTargetTypeSpecified {
            get {
                return this.bonusTargetTypeFieldSpecified;
            }
            set {
                this.bonusTargetTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public EmployeeBonusTargetPayFrequency bonusTargetPayFrequency {
            get {
                return this.bonusTargetPayFrequencyField;
            }
            set {
                this.bonusTargetPayFrequencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bonusTargetPayFrequencySpecified {
            get {
                return this.bonusTargetPayFrequencyFieldSpecified;
            }
            set {
                this.bonusTargetPayFrequencyFieldSpecified = value;
            }
        }

        /// <remarks/>
        public EmployeeCorporateCardsList corporateCardsList {
            get {
                return this.corporateCardsListField;
            }
            set {
                this.corporateCardsListField = value;
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