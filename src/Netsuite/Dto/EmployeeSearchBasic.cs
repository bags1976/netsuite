namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class EmployeeSearchBasic : SearchRecordBasic {

        private SearchStringField addressField;

        private SearchStringField addresseeField;

        private SearchStringField addressLabelField;

        private SearchStringField addressPhoneField;

        private SearchStringField alienNumberField;

        private SearchDoubleField allocationField;

        private SearchDateField anniversaryField;

        private SearchDoubleField approvalLimitField;

        private SearchMultiSelectField approverField;

        private SearchStringField attentionField;

        private SearchDateField authWorkDateField;

        private SearchDoubleField baseWageField;

        private SearchEnumMultiSelectField baseWageTypeField;

        private SearchStringField billAddressField;

        private SearchMultiSelectField billingClassField;

        private SearchDateField birthDateField;

        private SearchDateField birthDayField;

        private SearchDoubleField bonusTargetField;

        private SearchStringField bonusTargetCommentField;

        private SearchEnumMultiSelectField bonusTargetPayFrequencyField;

        private SearchEnumMultiSelectField bonusTargetTypeField;

        private SearchMultiSelectField cContributionField;

        private SearchStringField cityField;

        private SearchMultiSelectField classField;

        private SearchStringField commentsField;

        private SearchMultiSelectField commissionPlanField;

        private SearchEnumMultiSelectField compensationCurrencyField;

        private SearchBooleanField concurrentWebServicesUserField;

        private SearchMultiSelectField corporateCardProfileField;

        private SearchEnumMultiSelectField countryField;

        private SearchStringField countyField;

        private SearchDateField dateCreatedField;

        private SearchMultiSelectField deductionField;

        private SearchMultiSelectField defaultAcctCorpCardExpField;

        private SearchMultiSelectField defaultExpenseReportCurrencyField;

        private SearchMultiSelectField defaultTaxRegField;

        private SearchStringField defaultTaxRegTextField;

        private SearchMultiSelectField departmentField;

        private SearchMultiSelectField earningField;

        private SearchMultiSelectField educationField;

        private SearchBooleanField eligibleForCommissionField;

        private SearchStringField emailField;

        private SearchStringField embossedNameField;

        private SearchMultiSelectField employeeStatusField;

        private SearchMultiSelectField employeeTypeField;

        private SearchBooleanField employeeTypeKpiField;

        private SearchStringField entityIdField;

        private SearchMultiSelectField ethnicityField;

        private SearchDoubleField expenseLimitField;

        private SearchMultiSelectField expenseReportCurrencyField;

        private SearchDateField expirationField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchStringField faxField;

        private SearchStringField firstNameField;

        private SearchEnumMultiSelectField genderField;

        private SearchBooleanField giveAccessField;

        private SearchEnumMultiSelectField globalSubscriptionStatusField;

        private SearchMultiSelectField groupField;

        private SearchDateField hireDateField;

        private SearchBooleanField i9VerifiedField;

        private SearchStringField imageField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchBooleanField isDefaultBillingField;

        private SearchBooleanField isDefaultShippingField;

        private SearchBooleanField isInactiveField;

        private SearchBooleanField isJobManagerField;

        private SearchBooleanField isJobResourceField;

        private SearchBooleanField isTemplateField;

        private SearchMultiSelectField jobField;

        private SearchStringField jobDescriptionField;

        private SearchDoubleField laborCostField;

        private SearchEnumMultiSelectField languageField;

        private SearchDateField lastModifiedDateField;

        private SearchStringField lastNameField;

        private SearchDateField lastPaidDateField;

        private SearchDateField lastReviewDateField;

        private SearchEnumMultiSelectField levelField;

        private SearchMultiSelectField locationField;

        private SearchMultiSelectField maritalStatusField;

        private SearchStringField middleNameField;

        private SearchDateField nextReviewDateField;

        private SearchBooleanField offlineAccessField;

        private SearchEnumMultiSelectField payFrequencyField;

        private SearchDateField permChangeDateField;

        private SearchEnumMultiSelectField permissionField;

        private SearchEnumMultiSelectField permissionChangeField;

        private SearchStringField phoneField;

        private SearchStringField phoneticNameField;

        private SearchMultiSelectField positionTitleField;

        private SearchDoubleField primaryEarningAmountField;

        private SearchStringField primaryEarningItemField;

        private SearchStringField primaryEarningTypeField;

        private SearchDoubleField purchaseOrderApprovalLimitField;

        private SearchMultiSelectField purchaseOrderApproverField;

        private SearchDoubleField purchaseOrderLimitField;

        private SearchDateField releaseDateField;

        private SearchMultiSelectField residentStatusField;

        private SearchMultiSelectField roleField;

        private SearchMultiSelectField roleChangeField;

        private SearchDateField roleChangeDateField;

        private SearchBooleanField salesRepField;

        private SearchMultiSelectField salesRoleField;

        private SearchStringField salutationField;

        private SearchStringField socialSecurityNumberField;

        private SearchDateField startDateTimeOffCalcField;

        private SearchStringField stateField;

        private SearchMultiSelectField subsidiaryField;

        private SearchMultiSelectField supervisorField;

        private SearchBooleanField supportRepField;

        private SearchDoubleField targetUtilizationField;

        private SearchEnumMultiSelectField terminationCategoryField;

        private SearchStringField terminationDetailsField;

        private SearchMultiSelectField terminationReasonField;

        private SearchEnumMultiSelectField terminationRegrettedField;

        private SearchMultiSelectField timeApproverField;

        private SearchMultiSelectField timeOffPlanField;

        private SearchStringField titleField;

        private SearchBooleanField usePerquestField;

        private SearchBooleanField useTimeDataField;

        private SearchDateField visaExpDateField;

        private SearchMultiSelectField visaTypeField;

        private SearchMultiSelectField withholdingField;

        private SearchMultiSelectField workCalendarField;

        private SearchMultiSelectField workplaceField;

        private SearchStringField zipCodeField;

        private SearchCustomField[] customFieldListField;

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
        public SearchStringField alienNumber {
            get {
                return this.alienNumberField;
            }
            set {
                this.alienNumberField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField allocation {
            get {
                return this.allocationField;
            }
            set {
                this.allocationField = value;
            }
        }

        /// <remarks/>
        public SearchDateField anniversary {
            get {
                return this.anniversaryField;
            }
            set {
                this.anniversaryField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField approvalLimit {
            get {
                return this.approvalLimitField;
            }
            set {
                this.approvalLimitField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField approver {
            get {
                return this.approverField;
            }
            set {
                this.approverField = value;
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
        public SearchDateField authWorkDate {
            get {
                return this.authWorkDateField;
            }
            set {
                this.authWorkDateField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField baseWage {
            get {
                return this.baseWageField;
            }
            set {
                this.baseWageField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField baseWageType {
            get {
                return this.baseWageTypeField;
            }
            set {
                this.baseWageTypeField = value;
            }
        }

        /// <remarks/>
        public SearchStringField billAddress {
            get {
                return this.billAddressField;
            }
            set {
                this.billAddressField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField billingClass {
            get {
                return this.billingClassField;
            }
            set {
                this.billingClassField = value;
            }
        }

        /// <remarks/>
        public SearchDateField birthDate {
            get {
                return this.birthDateField;
            }
            set {
                this.birthDateField = value;
            }
        }

        /// <remarks/>
        public SearchDateField birthDay {
            get {
                return this.birthDayField;
            }
            set {
                this.birthDayField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField bonusTarget {
            get {
                return this.bonusTargetField;
            }
            set {
                this.bonusTargetField = value;
            }
        }

        /// <remarks/>
        public SearchStringField bonusTargetComment {
            get {
                return this.bonusTargetCommentField;
            }
            set {
                this.bonusTargetCommentField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField bonusTargetPayFrequency {
            get {
                return this.bonusTargetPayFrequencyField;
            }
            set {
                this.bonusTargetPayFrequencyField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField bonusTargetType {
            get {
                return this.bonusTargetTypeField;
            }
            set {
                this.bonusTargetTypeField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField cContribution {
            get {
                return this.cContributionField;
            }
            set {
                this.cContributionField = value;
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
        public SearchMultiSelectField @class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
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
        public SearchMultiSelectField commissionPlan {
            get {
                return this.commissionPlanField;
            }
            set {
                this.commissionPlanField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField compensationCurrency {
            get {
                return this.compensationCurrencyField;
            }
            set {
                this.compensationCurrencyField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField concurrentWebServicesUser {
            get {
                return this.concurrentWebServicesUserField;
            }
            set {
                this.concurrentWebServicesUserField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField corporateCardProfile {
            get {
                return this.corporateCardProfileField;
            }
            set {
                this.corporateCardProfileField = value;
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
        public SearchDateField dateCreated {
            get {
                return this.dateCreatedField;
            }
            set {
                this.dateCreatedField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField deduction {
            get {
                return this.deductionField;
            }
            set {
                this.deductionField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField defaultAcctCorpCardExp {
            get {
                return this.defaultAcctCorpCardExpField;
            }
            set {
                this.defaultAcctCorpCardExpField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField defaultExpenseReportCurrency {
            get {
                return this.defaultExpenseReportCurrencyField;
            }
            set {
                this.defaultExpenseReportCurrencyField = value;
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
        public SearchMultiSelectField department {
            get {
                return this.departmentField;
            }
            set {
                this.departmentField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField earning {
            get {
                return this.earningField;
            }
            set {
                this.earningField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField education {
            get {
                return this.educationField;
            }
            set {
                this.educationField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField eligibleForCommission {
            get {
                return this.eligibleForCommissionField;
            }
            set {
                this.eligibleForCommissionField = value;
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
        public SearchStringField embossedName {
            get {
                return this.embossedNameField;
            }
            set {
                this.embossedNameField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField employeeStatus {
            get {
                return this.employeeStatusField;
            }
            set {
                this.employeeStatusField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField employeeType {
            get {
                return this.employeeTypeField;
            }
            set {
                this.employeeTypeField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField employeeTypeKpi {
            get {
                return this.employeeTypeKpiField;
            }
            set {
                this.employeeTypeKpiField = value;
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
        public SearchMultiSelectField ethnicity {
            get {
                return this.ethnicityField;
            }
            set {
                this.ethnicityField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField expenseLimit {
            get {
                return this.expenseLimitField;
            }
            set {
                this.expenseLimitField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField expenseReportCurrency {
            get {
                return this.expenseReportCurrencyField;
            }
            set {
                this.expenseReportCurrencyField = value;
            }
        }

        /// <remarks/>
        public SearchDateField expiration {
            get {
                return this.expirationField;
            }
            set {
                this.expirationField = value;
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
        public SearchStringField firstName {
            get {
                return this.firstNameField;
            }
            set {
                this.firstNameField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField gender {
            get {
                return this.genderField;
            }
            set {
                this.genderField = value;
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
        public SearchMultiSelectField group {
            get {
                return this.groupField;
            }
            set {
                this.groupField = value;
            }
        }

        /// <remarks/>
        public SearchDateField hireDate {
            get {
                return this.hireDateField;
            }
            set {
                this.hireDateField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField I9Verified {
            get {
                return this.i9VerifiedField;
            }
            set {
                this.i9VerifiedField = value;
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
        public SearchBooleanField isInactive {
            get {
                return this.isInactiveField;
            }
            set {
                this.isInactiveField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isJobManager {
            get {
                return this.isJobManagerField;
            }
            set {
                this.isJobManagerField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isJobResource {
            get {
                return this.isJobResourceField;
            }
            set {
                this.isJobResourceField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isTemplate {
            get {
                return this.isTemplateField;
            }
            set {
                this.isTemplateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField job {
            get {
                return this.jobField;
            }
            set {
                this.jobField = value;
            }
        }

        /// <remarks/>
        public SearchStringField jobDescription {
            get {
                return this.jobDescriptionField;
            }
            set {
                this.jobDescriptionField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField laborCost {
            get {
                return this.laborCostField;
            }
            set {
                this.laborCostField = value;
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
        public SearchDateField lastModifiedDate {
            get {
                return this.lastModifiedDateField;
            }
            set {
                this.lastModifiedDateField = value;
            }
        }

        /// <remarks/>
        public SearchStringField lastName {
            get {
                return this.lastNameField;
            }
            set {
                this.lastNameField = value;
            }
        }

        /// <remarks/>
        public SearchDateField lastPaidDate {
            get {
                return this.lastPaidDateField;
            }
            set {
                this.lastPaidDateField = value;
            }
        }

        /// <remarks/>
        public SearchDateField lastReviewDate {
            get {
                return this.lastReviewDateField;
            }
            set {
                this.lastReviewDateField = value;
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
        public SearchMultiSelectField location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField maritalStatus {
            get {
                return this.maritalStatusField;
            }
            set {
                this.maritalStatusField = value;
            }
        }

        /// <remarks/>
        public SearchStringField middleName {
            get {
                return this.middleNameField;
            }
            set {
                this.middleNameField = value;
            }
        }

        /// <remarks/>
        public SearchDateField nextReviewDate {
            get {
                return this.nextReviewDateField;
            }
            set {
                this.nextReviewDateField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField offlineAccess {
            get {
                return this.offlineAccessField;
            }
            set {
                this.offlineAccessField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField payFrequency {
            get {
                return this.payFrequencyField;
            }
            set {
                this.payFrequencyField = value;
            }
        }

        /// <remarks/>
        public SearchDateField permChangeDate {
            get {
                return this.permChangeDateField;
            }
            set {
                this.permChangeDateField = value;
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
        public SearchEnumMultiSelectField permissionChange {
            get {
                return this.permissionChangeField;
            }
            set {
                this.permissionChangeField = value;
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
        public SearchMultiSelectField positionTitle {
            get {
                return this.positionTitleField;
            }
            set {
                this.positionTitleField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField primaryEarningAmount {
            get {
                return this.primaryEarningAmountField;
            }
            set {
                this.primaryEarningAmountField = value;
            }
        }

        /// <remarks/>
        public SearchStringField primaryEarningItem {
            get {
                return this.primaryEarningItemField;
            }
            set {
                this.primaryEarningItemField = value;
            }
        }

        /// <remarks/>
        public SearchStringField primaryEarningType {
            get {
                return this.primaryEarningTypeField;
            }
            set {
                this.primaryEarningTypeField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField purchaseOrderApprovalLimit {
            get {
                return this.purchaseOrderApprovalLimitField;
            }
            set {
                this.purchaseOrderApprovalLimitField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField purchaseOrderApprover {
            get {
                return this.purchaseOrderApproverField;
            }
            set {
                this.purchaseOrderApproverField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField purchaseOrderLimit {
            get {
                return this.purchaseOrderLimitField;
            }
            set {
                this.purchaseOrderLimitField = value;
            }
        }

        /// <remarks/>
        public SearchDateField releaseDate {
            get {
                return this.releaseDateField;
            }
            set {
                this.releaseDateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField residentStatus {
            get {
                return this.residentStatusField;
            }
            set {
                this.residentStatusField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField role {
            get {
                return this.roleField;
            }
            set {
                this.roleField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField roleChange {
            get {
                return this.roleChangeField;
            }
            set {
                this.roleChangeField = value;
            }
        }

        /// <remarks/>
        public SearchDateField roleChangeDate {
            get {
                return this.roleChangeDateField;
            }
            set {
                this.roleChangeDateField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField salesRep {
            get {
                return this.salesRepField;
            }
            set {
                this.salesRepField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField salesRole {
            get {
                return this.salesRoleField;
            }
            set {
                this.salesRoleField = value;
            }
        }

        /// <remarks/>
        public SearchStringField salutation {
            get {
                return this.salutationField;
            }
            set {
                this.salutationField = value;
            }
        }

        /// <remarks/>
        public SearchStringField socialSecurityNumber {
            get {
                return this.socialSecurityNumberField;
            }
            set {
                this.socialSecurityNumberField = value;
            }
        }

        /// <remarks/>
        public SearchDateField startDateTimeOffCalc {
            get {
                return this.startDateTimeOffCalcField;
            }
            set {
                this.startDateTimeOffCalcField = value;
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
        public SearchMultiSelectField subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField supervisor {
            get {
                return this.supervisorField;
            }
            set {
                this.supervisorField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField supportRep {
            get {
                return this.supportRepField;
            }
            set {
                this.supportRepField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField targetUtilization {
            get {
                return this.targetUtilizationField;
            }
            set {
                this.targetUtilizationField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField terminationCategory {
            get {
                return this.terminationCategoryField;
            }
            set {
                this.terminationCategoryField = value;
            }
        }

        /// <remarks/>
        public SearchStringField terminationDetails {
            get {
                return this.terminationDetailsField;
            }
            set {
                this.terminationDetailsField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField terminationReason {
            get {
                return this.terminationReasonField;
            }
            set {
                this.terminationReasonField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField terminationRegretted {
            get {
                return this.terminationRegrettedField;
            }
            set {
                this.terminationRegrettedField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField timeApprover {
            get {
                return this.timeApproverField;
            }
            set {
                this.timeApproverField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField timeOffPlan {
            get {
                return this.timeOffPlanField;
            }
            set {
                this.timeOffPlanField = value;
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
        public SearchBooleanField usePerquest {
            get {
                return this.usePerquestField;
            }
            set {
                this.usePerquestField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField useTimeData {
            get {
                return this.useTimeDataField;
            }
            set {
                this.useTimeDataField = value;
            }
        }

        /// <remarks/>
        public SearchDateField visaExpDate {
            get {
                return this.visaExpDateField;
            }
            set {
                this.visaExpDateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField visaType {
            get {
                return this.visaTypeField;
            }
            set {
                this.visaTypeField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField withholding {
            get {
                return this.withholdingField;
            }
            set {
                this.withholdingField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField workCalendar {
            get {
                return this.workCalendarField;
            }
            set {
                this.workCalendarField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField workplace {
            get {
                return this.workplaceField;
            }
            set {
                this.workplaceField = value;
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