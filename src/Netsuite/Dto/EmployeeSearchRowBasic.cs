namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class EmployeeSearchRowBasic : SearchRowBasic {

        private SearchColumnStringField[] accountNumberField;

        private SearchColumnStringField[] addressField;

        private SearchColumnStringField[] address1Field;

        private SearchColumnStringField[] address2Field;

        private SearchColumnStringField[] address3Field;

        private SearchColumnStringField[] addresseeField;

        private SearchColumnStringField[] addressInternalIdField;

        private SearchColumnStringField[] addressLabelField;

        private SearchColumnStringField[] addressPhoneField;

        private SearchColumnStringField[] alienNumberField;

        private SearchColumnDoubleField[] allocationField;

        private SearchColumnStringField[] altEmailField;

        private SearchColumnStringField[] altNameField;

        private SearchColumnStringField[] altPhoneField;

        private SearchColumnDoubleField[] approvalLimitField;

        private SearchColumnSelectField[] approverField;

        private SearchColumnStringField[] attentionField;

        private SearchColumnDateField[] authWorkDateField;

        private SearchColumnDoubleField[] baseWageField;

        private SearchEnumMultiSelectField[] baseWageTypeField;

        private SearchColumnStringField[] billAddressField;

        private SearchColumnStringField[] billAddress1Field;

        private SearchColumnStringField[] billAddress2Field;

        private SearchColumnStringField[] billAddress3Field;

        private SearchColumnStringField[] billAddresseeField;

        private SearchColumnStringField[] billAttentionField;

        private SearchColumnStringField[] billCityField;

        private SearchColumnEnumSelectField[] billCountryField;

        private SearchColumnStringField[] billCountryCodeField;

        private SearchColumnSelectField[] billingClassField;

        private SearchColumnStringField[] billPhoneField;

        private SearchColumnStringField[] billStateField;

        private SearchColumnStringField[] billZipCodeField;

        private SearchColumnDateField[] birthDateField;

        private SearchColumnDateField[] birthDayField;

        private SearchColumnDoubleField[] bonusTargetField;

        private SearchColumnStringField[] bonusTargetCommentField;

        private SearchColumnEnumSelectField[] bonusTargetPayFrequencyField;

        private SearchColumnEnumSelectField[] bonusTargetTypeField;

        private SearchColumnStringField[] cityField;

        private SearchColumnSelectField[] classField;

        private SearchColumnStringField[] commentsField;

        private SearchColumnEnumSelectField[] compensationCurrencyField;

        private SearchColumnBooleanField[] concurrentWebServicesUserField;

        private SearchColumnSelectField[] corporateCardProfileField;

        private SearchColumnEnumSelectField[] countryField;

        private SearchColumnStringField[] countryCodeField;

        private SearchColumnDateField[] dateCreatedField;

        private SearchColumnSelectField[] defaultAcctCorpCardExpField;

        private SearchColumnSelectField[] defaultExpenseReportCurrencyField;

        private SearchColumnStringField[] defaultTaxRegField;

        private SearchColumnSelectField[] departmentField;

        private SearchColumnBooleanField[] eligibleForCommissionField;

        private SearchColumnStringField[] emailField;

        private SearchColumnStringField[] embossedNameField;

        private SearchColumnSelectField[] employeeStatusField;

        private SearchColumnSelectField[] employeeTypeField;

        private SearchColumnStringField[] entityIdField;

        private SearchColumnLongField[] entityNumberField;

        private SearchColumnSelectField[] ethnicityField;

        private SearchColumnDoubleField[] expenseLimitField;

        private SearchColumnSelectField[] expenseReportCurrencyField;

        private SearchColumnDateField[] expirationField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnStringField[] faxField;

        private SearchColumnStringField[] firstNameField;

        private SearchColumnEnumSelectField[] genderField;

        private SearchColumnBooleanField[] giveAccessField;

        private SearchColumnEnumSelectField[] globalSubscriptionStatusField;

        private SearchColumnDateField[] hireDateField;

        private SearchColumnStringField[] homePhoneField;

        private SearchColumnBooleanField[] i9VerifiedField;

        private SearchColumnSelectField[] imageField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnBooleanField[] isDefaultBillingField;

        private SearchColumnBooleanField[] isDefaultShippingField;

        private SearchColumnBooleanField[] isInactiveField;

        private SearchColumnBooleanField[] isJobManagerField;

        private SearchColumnBooleanField[] isJobResourceField;

        private SearchColumnBooleanField[] isSalesRepField;

        private SearchColumnBooleanField[] isSupportRepField;

        private SearchColumnBooleanField[] isTemplateField;

        private SearchColumnSelectField[] jobField;

        private SearchColumnDoubleField[] laborCostField;

        private SearchColumnEnumSelectField[] languageField;

        private SearchColumnDateField[] lastModifiedDateField;

        private SearchColumnStringField[] lastNameField;

        private SearchColumnDateField[] lastPaidDateField;

        private SearchColumnDateField[] lastReviewDateField;

        private SearchColumnEnumSelectField[] levelField;

        private SearchColumnSelectField[] locationField;

        private SearchColumnSelectField[] maritalStatusField;

        private SearchColumnStringField[] middleNameField;

        private SearchColumnStringField[] mobilePhoneField;

        private SearchColumnDateField[] nextReviewDateField;

        private SearchColumnBooleanField[] offlineAccessField;

        private SearchColumnEnumSelectField[] payFrequencyField;

        private SearchColumnDateField[] permChangeDateField;

        private SearchColumnStringField[] permChangeLevelField;

        private SearchColumnEnumSelectField[] permissionField;

        private SearchColumnEnumSelectField[] permissionChangeField;

        private SearchColumnStringField[] phoneField;

        private SearchColumnStringField[] phoneticNameField;

        private SearchColumnStringField[] positionTitleField;

        private SearchColumnDoubleField[] primaryEarningAmountField;

        private SearchColumnStringField[] primaryEarningItemField;

        private SearchColumnStringField[] primaryEarningTypeField;

        private SearchColumnDoubleField[] purchaseOrderApprovalLimitField;

        private SearchColumnSelectField[] purchaseOrderApproverField;

        private SearchColumnDoubleField[] purchaseOrderLimitField;

        private SearchColumnDateField[] releaseDateField;

        private SearchColumnSelectField[] residentStatusField;

        private SearchColumnSelectField[] roleField;

        private SearchColumnStringField[] roleChangeField;

        private SearchColumnStringField[] roleChangeActionField;

        private SearchColumnDateField[] roleChangeDateField;

        private SearchColumnSelectField[] salesRoleField;

        private SearchColumnStringField[] salutationField;

        private SearchColumnStringField[] shipAddress1Field;

        private SearchColumnStringField[] shipAddress2Field;

        private SearchColumnStringField[] shipAddress3Field;

        private SearchColumnStringField[] shipAddresseeField;

        private SearchColumnStringField[] shipAttentionField;

        private SearchColumnStringField[] shipCityField;

        private SearchColumnEnumSelectField[] shipCountryField;

        private SearchColumnStringField[] shipCountryCodeField;

        private SearchColumnStringField[] shipPhoneField;

        private SearchColumnStringField[] shipStateField;

        private SearchColumnStringField[] shipZipField;

        private SearchColumnStringField[] socialSecurityNumberField;

        private SearchColumnDateField[] startDateTimeOffCalcField;

        private SearchColumnEnumSelectField[] stateField;

        private SearchColumnSelectField[] subscriptionField;

        private SearchColumnDateField[] subscriptionDateField;

        private SearchColumnBooleanField[] subscriptionStatusField;

        private SearchColumnSelectField[] subsidiaryField;

        private SearchColumnSelectField[] supervisorField;

        private SearchColumnDoubleField[] targetUtilizationField;

        private SearchColumnEnumSelectField[] terminationCategoryField;

        private SearchColumnStringField[] terminationDetailsField;

        private SearchColumnSelectField[] terminationReasonField;

        private SearchColumnEnumSelectField[] terminationRegrettedField;

        private SearchColumnSelectField[] timeApproverField;

        private SearchColumnStringField[] timeOffPlanField;

        private SearchColumnStringField[] titleField;

        private SearchColumnBooleanField[] usePerquestField;

        private SearchColumnBooleanField[] useTimeDataField;

        private SearchColumnDateField[] visaExpDateField;

        private SearchColumnSelectField[] visaTypeField;

        private SearchColumnStringField[] workCalendarField;

        private SearchColumnSelectField[] workplaceField;

        private SearchColumnStringField[] zipCodeField;

        private SearchColumnCustomField[] customFieldListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("accountNumber")]
        public SearchColumnStringField[] accountNumber {
            get {
                return this.accountNumberField;
            }
            set {
                this.accountNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("address")]
        public SearchColumnStringField[] address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("address1")]
        public SearchColumnStringField[] address1 {
            get {
                return this.address1Field;
            }
            set {
                this.address1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("address2")]
        public SearchColumnStringField[] address2 {
            get {
                return this.address2Field;
            }
            set {
                this.address2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("address3")]
        public SearchColumnStringField[] address3 {
            get {
                return this.address3Field;
            }
            set {
                this.address3Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("addressee")]
        public SearchColumnStringField[] addressee {
            get {
                return this.addresseeField;
            }
            set {
                this.addresseeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("addressInternalId")]
        public SearchColumnStringField[] addressInternalId {
            get {
                return this.addressInternalIdField;
            }
            set {
                this.addressInternalIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("addressLabel")]
        public SearchColumnStringField[] addressLabel {
            get {
                return this.addressLabelField;
            }
            set {
                this.addressLabelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("addressPhone")]
        public SearchColumnStringField[] addressPhone {
            get {
                return this.addressPhoneField;
            }
            set {
                this.addressPhoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("alienNumber")]
        public SearchColumnStringField[] alienNumber {
            get {
                return this.alienNumberField;
            }
            set {
                this.alienNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("allocation")]
        public SearchColumnDoubleField[] allocation {
            get {
                return this.allocationField;
            }
            set {
                this.allocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("altEmail")]
        public SearchColumnStringField[] altEmail {
            get {
                return this.altEmailField;
            }
            set {
                this.altEmailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("altName")]
        public SearchColumnStringField[] altName {
            get {
                return this.altNameField;
            }
            set {
                this.altNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("altPhone")]
        public SearchColumnStringField[] altPhone {
            get {
                return this.altPhoneField;
            }
            set {
                this.altPhoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("approvalLimit")]
        public SearchColumnDoubleField[] approvalLimit {
            get {
                return this.approvalLimitField;
            }
            set {
                this.approvalLimitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("approver")]
        public SearchColumnSelectField[] approver {
            get {
                return this.approverField;
            }
            set {
                this.approverField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("attention")]
        public SearchColumnStringField[] attention {
            get {
                return this.attentionField;
            }
            set {
                this.attentionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("authWorkDate")]
        public SearchColumnDateField[] authWorkDate {
            get {
                return this.authWorkDateField;
            }
            set {
                this.authWorkDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("baseWage")]
        public SearchColumnDoubleField[] baseWage {
            get {
                return this.baseWageField;
            }
            set {
                this.baseWageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("baseWageType")]
        public SearchEnumMultiSelectField[] baseWageType {
            get {
                return this.baseWageTypeField;
            }
            set {
                this.baseWageTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billAddress")]
        public SearchColumnStringField[] billAddress {
            get {
                return this.billAddressField;
            }
            set {
                this.billAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billAddress1")]
        public SearchColumnStringField[] billAddress1 {
            get {
                return this.billAddress1Field;
            }
            set {
                this.billAddress1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billAddress2")]
        public SearchColumnStringField[] billAddress2 {
            get {
                return this.billAddress2Field;
            }
            set {
                this.billAddress2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billAddress3")]
        public SearchColumnStringField[] billAddress3 {
            get {
                return this.billAddress3Field;
            }
            set {
                this.billAddress3Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billAddressee")]
        public SearchColumnStringField[] billAddressee {
            get {
                return this.billAddresseeField;
            }
            set {
                this.billAddresseeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billAttention")]
        public SearchColumnStringField[] billAttention {
            get {
                return this.billAttentionField;
            }
            set {
                this.billAttentionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billCity")]
        public SearchColumnStringField[] billCity {
            get {
                return this.billCityField;
            }
            set {
                this.billCityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billCountry")]
        public SearchColumnEnumSelectField[] billCountry {
            get {
                return this.billCountryField;
            }
            set {
                this.billCountryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billCountryCode")]
        public SearchColumnStringField[] billCountryCode {
            get {
                return this.billCountryCodeField;
            }
            set {
                this.billCountryCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billingClass")]
        public SearchColumnSelectField[] billingClass {
            get {
                return this.billingClassField;
            }
            set {
                this.billingClassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billPhone")]
        public SearchColumnStringField[] billPhone {
            get {
                return this.billPhoneField;
            }
            set {
                this.billPhoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billState")]
        public SearchColumnStringField[] billState {
            get {
                return this.billStateField;
            }
            set {
                this.billStateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billZipCode")]
        public SearchColumnStringField[] billZipCode {
            get {
                return this.billZipCodeField;
            }
            set {
                this.billZipCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("birthDate")]
        public SearchColumnDateField[] birthDate {
            get {
                return this.birthDateField;
            }
            set {
                this.birthDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("birthDay")]
        public SearchColumnDateField[] birthDay {
            get {
                return this.birthDayField;
            }
            set {
                this.birthDayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("bonusTarget")]
        public SearchColumnDoubleField[] bonusTarget {
            get {
                return this.bonusTargetField;
            }
            set {
                this.bonusTargetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("bonusTargetComment")]
        public SearchColumnStringField[] bonusTargetComment {
            get {
                return this.bonusTargetCommentField;
            }
            set {
                this.bonusTargetCommentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("bonusTargetPayFrequency")]
        public SearchColumnEnumSelectField[] bonusTargetPayFrequency {
            get {
                return this.bonusTargetPayFrequencyField;
            }
            set {
                this.bonusTargetPayFrequencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("bonusTargetType")]
        public SearchColumnEnumSelectField[] bonusTargetType {
            get {
                return this.bonusTargetTypeField;
            }
            set {
                this.bonusTargetTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("city")]
        public SearchColumnStringField[] city {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("comments")]
        public SearchColumnStringField[] comments {
            get {
                return this.commentsField;
            }
            set {
                this.commentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("compensationCurrency")]
        public SearchColumnEnumSelectField[] compensationCurrency {
            get {
                return this.compensationCurrencyField;
            }
            set {
                this.compensationCurrencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("concurrentWebServicesUser")]
        public SearchColumnBooleanField[] concurrentWebServicesUser {
            get {
                return this.concurrentWebServicesUserField;
            }
            set {
                this.concurrentWebServicesUserField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("corporateCardProfile")]
        public SearchColumnSelectField[] corporateCardProfile {
            get {
                return this.corporateCardProfileField;
            }
            set {
                this.corporateCardProfileField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("country")]
        public SearchColumnEnumSelectField[] country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("countryCode")]
        public SearchColumnStringField[] countryCode {
            get {
                return this.countryCodeField;
            }
            set {
                this.countryCodeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("defaultAcctCorpCardExp")]
        public SearchColumnSelectField[] defaultAcctCorpCardExp {
            get {
                return this.defaultAcctCorpCardExpField;
            }
            set {
                this.defaultAcctCorpCardExpField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("defaultExpenseReportCurrency")]
        public SearchColumnSelectField[] defaultExpenseReportCurrency {
            get {
                return this.defaultExpenseReportCurrencyField;
            }
            set {
                this.defaultExpenseReportCurrencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("defaultTaxReg")]
        public SearchColumnStringField[] defaultTaxReg {
            get {
                return this.defaultTaxRegField;
            }
            set {
                this.defaultTaxRegField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("eligibleForCommission")]
        public SearchColumnBooleanField[] eligibleForCommission {
            get {
                return this.eligibleForCommissionField;
            }
            set {
                this.eligibleForCommissionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("email")]
        public SearchColumnStringField[] email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("embossedName")]
        public SearchColumnStringField[] embossedName {
            get {
                return this.embossedNameField;
            }
            set {
                this.embossedNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("employeeStatus")]
        public SearchColumnSelectField[] employeeStatus {
            get {
                return this.employeeStatusField;
            }
            set {
                this.employeeStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("employeeType")]
        public SearchColumnSelectField[] employeeType {
            get {
                return this.employeeTypeField;
            }
            set {
                this.employeeTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("entityId")]
        public SearchColumnStringField[] entityId {
            get {
                return this.entityIdField;
            }
            set {
                this.entityIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("entityNumber")]
        public SearchColumnLongField[] entityNumber {
            get {
                return this.entityNumberField;
            }
            set {
                this.entityNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ethnicity")]
        public SearchColumnSelectField[] ethnicity {
            get {
                return this.ethnicityField;
            }
            set {
                this.ethnicityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("expenseLimit")]
        public SearchColumnDoubleField[] expenseLimit {
            get {
                return this.expenseLimitField;
            }
            set {
                this.expenseLimitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("expenseReportCurrency")]
        public SearchColumnSelectField[] expenseReportCurrency {
            get {
                return this.expenseReportCurrencyField;
            }
            set {
                this.expenseReportCurrencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("expiration")]
        public SearchColumnDateField[] expiration {
            get {
                return this.expirationField;
            }
            set {
                this.expirationField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("fax")]
        public SearchColumnStringField[] fax {
            get {
                return this.faxField;
            }
            set {
                this.faxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("firstName")]
        public SearchColumnStringField[] firstName {
            get {
                return this.firstNameField;
            }
            set {
                this.firstNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("gender")]
        public SearchColumnEnumSelectField[] gender {
            get {
                return this.genderField;
            }
            set {
                this.genderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("giveAccess")]
        public SearchColumnBooleanField[] giveAccess {
            get {
                return this.giveAccessField;
            }
            set {
                this.giveAccessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("globalSubscriptionStatus")]
        public SearchColumnEnumSelectField[] globalSubscriptionStatus {
            get {
                return this.globalSubscriptionStatusField;
            }
            set {
                this.globalSubscriptionStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("hireDate")]
        public SearchColumnDateField[] hireDate {
            get {
                return this.hireDateField;
            }
            set {
                this.hireDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("homePhone")]
        public SearchColumnStringField[] homePhone {
            get {
                return this.homePhoneField;
            }
            set {
                this.homePhoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("i9Verified")]
        public SearchColumnBooleanField[] i9Verified {
            get {
                return this.i9VerifiedField;
            }
            set {
                this.i9VerifiedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("image")]
        public SearchColumnSelectField[] image {
            get {
                return this.imageField;
            }
            set {
                this.imageField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("isDefaultBilling")]
        public SearchColumnBooleanField[] isDefaultBilling {
            get {
                return this.isDefaultBillingField;
            }
            set {
                this.isDefaultBillingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isDefaultShipping")]
        public SearchColumnBooleanField[] isDefaultShipping {
            get {
                return this.isDefaultShippingField;
            }
            set {
                this.isDefaultShippingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isInactive")]
        public SearchColumnBooleanField[] isInactive {
            get {
                return this.isInactiveField;
            }
            set {
                this.isInactiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isJobManager")]
        public SearchColumnBooleanField[] isJobManager {
            get {
                return this.isJobManagerField;
            }
            set {
                this.isJobManagerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isJobResource")]
        public SearchColumnBooleanField[] isJobResource {
            get {
                return this.isJobResourceField;
            }
            set {
                this.isJobResourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isSalesRep")]
        public SearchColumnBooleanField[] isSalesRep {
            get {
                return this.isSalesRepField;
            }
            set {
                this.isSalesRepField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isSupportRep")]
        public SearchColumnBooleanField[] isSupportRep {
            get {
                return this.isSupportRepField;
            }
            set {
                this.isSupportRepField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isTemplate")]
        public SearchColumnBooleanField[] isTemplate {
            get {
                return this.isTemplateField;
            }
            set {
                this.isTemplateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("job")]
        public SearchColumnSelectField[] job {
            get {
                return this.jobField;
            }
            set {
                this.jobField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("laborCost")]
        public SearchColumnDoubleField[] laborCost {
            get {
                return this.laborCostField;
            }
            set {
                this.laborCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("language")]
        public SearchColumnEnumSelectField[] language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("lastName")]
        public SearchColumnStringField[] lastName {
            get {
                return this.lastNameField;
            }
            set {
                this.lastNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lastPaidDate")]
        public SearchColumnDateField[] lastPaidDate {
            get {
                return this.lastPaidDateField;
            }
            set {
                this.lastPaidDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lastReviewDate")]
        public SearchColumnDateField[] lastReviewDate {
            get {
                return this.lastReviewDateField;
            }
            set {
                this.lastReviewDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("level")]
        public SearchColumnEnumSelectField[] level {
            get {
                return this.levelField;
            }
            set {
                this.levelField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("maritalStatus")]
        public SearchColumnSelectField[] maritalStatus {
            get {
                return this.maritalStatusField;
            }
            set {
                this.maritalStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("middleName")]
        public SearchColumnStringField[] middleName {
            get {
                return this.middleNameField;
            }
            set {
                this.middleNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mobilePhone")]
        public SearchColumnStringField[] mobilePhone {
            get {
                return this.mobilePhoneField;
            }
            set {
                this.mobilePhoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("nextReviewDate")]
        public SearchColumnDateField[] nextReviewDate {
            get {
                return this.nextReviewDateField;
            }
            set {
                this.nextReviewDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("offlineAccess")]
        public SearchColumnBooleanField[] offlineAccess {
            get {
                return this.offlineAccessField;
            }
            set {
                this.offlineAccessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("payFrequency")]
        public SearchColumnEnumSelectField[] payFrequency {
            get {
                return this.payFrequencyField;
            }
            set {
                this.payFrequencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("permChangeDate")]
        public SearchColumnDateField[] permChangeDate {
            get {
                return this.permChangeDateField;
            }
            set {
                this.permChangeDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("permChangeLevel")]
        public SearchColumnStringField[] permChangeLevel {
            get {
                return this.permChangeLevelField;
            }
            set {
                this.permChangeLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("permission")]
        public SearchColumnEnumSelectField[] permission {
            get {
                return this.permissionField;
            }
            set {
                this.permissionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("permissionChange")]
        public SearchColumnEnumSelectField[] permissionChange {
            get {
                return this.permissionChangeField;
            }
            set {
                this.permissionChangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("phone")]
        public SearchColumnStringField[] phone {
            get {
                return this.phoneField;
            }
            set {
                this.phoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("phoneticName")]
        public SearchColumnStringField[] phoneticName {
            get {
                return this.phoneticNameField;
            }
            set {
                this.phoneticNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("positionTitle")]
        public SearchColumnStringField[] positionTitle {
            get {
                return this.positionTitleField;
            }
            set {
                this.positionTitleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("primaryEarningAmount")]
        public SearchColumnDoubleField[] primaryEarningAmount {
            get {
                return this.primaryEarningAmountField;
            }
            set {
                this.primaryEarningAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("primaryEarningItem")]
        public SearchColumnStringField[] primaryEarningItem {
            get {
                return this.primaryEarningItemField;
            }
            set {
                this.primaryEarningItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("primaryEarningType")]
        public SearchColumnStringField[] primaryEarningType {
            get {
                return this.primaryEarningTypeField;
            }
            set {
                this.primaryEarningTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("purchaseOrderApprovalLimit")]
        public SearchColumnDoubleField[] purchaseOrderApprovalLimit {
            get {
                return this.purchaseOrderApprovalLimitField;
            }
            set {
                this.purchaseOrderApprovalLimitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("purchaseOrderApprover")]
        public SearchColumnSelectField[] purchaseOrderApprover {
            get {
                return this.purchaseOrderApproverField;
            }
            set {
                this.purchaseOrderApproverField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("purchaseOrderLimit")]
        public SearchColumnDoubleField[] purchaseOrderLimit {
            get {
                return this.purchaseOrderLimitField;
            }
            set {
                this.purchaseOrderLimitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("releaseDate")]
        public SearchColumnDateField[] releaseDate {
            get {
                return this.releaseDateField;
            }
            set {
                this.releaseDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("residentStatus")]
        public SearchColumnSelectField[] residentStatus {
            get {
                return this.residentStatusField;
            }
            set {
                this.residentStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("role")]
        public SearchColumnSelectField[] role {
            get {
                return this.roleField;
            }
            set {
                this.roleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("roleChange")]
        public SearchColumnStringField[] roleChange {
            get {
                return this.roleChangeField;
            }
            set {
                this.roleChangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("roleChangeAction")]
        public SearchColumnStringField[] roleChangeAction {
            get {
                return this.roleChangeActionField;
            }
            set {
                this.roleChangeActionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("roleChangeDate")]
        public SearchColumnDateField[] roleChangeDate {
            get {
                return this.roleChangeDateField;
            }
            set {
                this.roleChangeDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("salesRole")]
        public SearchColumnSelectField[] salesRole {
            get {
                return this.salesRoleField;
            }
            set {
                this.salesRoleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("salutation")]
        public SearchColumnStringField[] salutation {
            get {
                return this.salutationField;
            }
            set {
                this.salutationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("shipAddress1")]
        public SearchColumnStringField[] shipAddress1 {
            get {
                return this.shipAddress1Field;
            }
            set {
                this.shipAddress1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("shipAddress2")]
        public SearchColumnStringField[] shipAddress2 {
            get {
                return this.shipAddress2Field;
            }
            set {
                this.shipAddress2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("shipAddress3")]
        public SearchColumnStringField[] shipAddress3 {
            get {
                return this.shipAddress3Field;
            }
            set {
                this.shipAddress3Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("shipAddressee")]
        public SearchColumnStringField[] shipAddressee {
            get {
                return this.shipAddresseeField;
            }
            set {
                this.shipAddresseeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("shipAttention")]
        public SearchColumnStringField[] shipAttention {
            get {
                return this.shipAttentionField;
            }
            set {
                this.shipAttentionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("shipCity")]
        public SearchColumnStringField[] shipCity {
            get {
                return this.shipCityField;
            }
            set {
                this.shipCityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("shipCountry")]
        public SearchColumnEnumSelectField[] shipCountry {
            get {
                return this.shipCountryField;
            }
            set {
                this.shipCountryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("shipCountryCode")]
        public SearchColumnStringField[] shipCountryCode {
            get {
                return this.shipCountryCodeField;
            }
            set {
                this.shipCountryCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("shipPhone")]
        public SearchColumnStringField[] shipPhone {
            get {
                return this.shipPhoneField;
            }
            set {
                this.shipPhoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("shipState")]
        public SearchColumnStringField[] shipState {
            get {
                return this.shipStateField;
            }
            set {
                this.shipStateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("shipZip")]
        public SearchColumnStringField[] shipZip {
            get {
                return this.shipZipField;
            }
            set {
                this.shipZipField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("socialSecurityNumber")]
        public SearchColumnStringField[] socialSecurityNumber {
            get {
                return this.socialSecurityNumberField;
            }
            set {
                this.socialSecurityNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("startDateTimeOffCalc")]
        public SearchColumnDateField[] startDateTimeOffCalc {
            get {
                return this.startDateTimeOffCalcField;
            }
            set {
                this.startDateTimeOffCalcField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("state")]
        public SearchColumnEnumSelectField[] state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("subscription")]
        public SearchColumnSelectField[] subscription {
            get {
                return this.subscriptionField;
            }
            set {
                this.subscriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("subscriptionDate")]
        public SearchColumnDateField[] subscriptionDate {
            get {
                return this.subscriptionDateField;
            }
            set {
                this.subscriptionDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("subscriptionStatus")]
        public SearchColumnBooleanField[] subscriptionStatus {
            get {
                return this.subscriptionStatusField;
            }
            set {
                this.subscriptionStatusField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("supervisor")]
        public SearchColumnSelectField[] supervisor {
            get {
                return this.supervisorField;
            }
            set {
                this.supervisorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("targetUtilization")]
        public SearchColumnDoubleField[] targetUtilization {
            get {
                return this.targetUtilizationField;
            }
            set {
                this.targetUtilizationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("terminationCategory")]
        public SearchColumnEnumSelectField[] terminationCategory {
            get {
                return this.terminationCategoryField;
            }
            set {
                this.terminationCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("terminationDetails")]
        public SearchColumnStringField[] terminationDetails {
            get {
                return this.terminationDetailsField;
            }
            set {
                this.terminationDetailsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("terminationReason")]
        public SearchColumnSelectField[] terminationReason {
            get {
                return this.terminationReasonField;
            }
            set {
                this.terminationReasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("terminationRegretted")]
        public SearchColumnEnumSelectField[] terminationRegretted {
            get {
                return this.terminationRegrettedField;
            }
            set {
                this.terminationRegrettedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("timeApprover")]
        public SearchColumnSelectField[] timeApprover {
            get {
                return this.timeApproverField;
            }
            set {
                this.timeApproverField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("timeOffPlan")]
        public SearchColumnStringField[] timeOffPlan {
            get {
                return this.timeOffPlanField;
            }
            set {
                this.timeOffPlanField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("usePerquest")]
        public SearchColumnBooleanField[] usePerquest {
            get {
                return this.usePerquestField;
            }
            set {
                this.usePerquestField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("useTimeData")]
        public SearchColumnBooleanField[] useTimeData {
            get {
                return this.useTimeDataField;
            }
            set {
                this.useTimeDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("visaExpDate")]
        public SearchColumnDateField[] visaExpDate {
            get {
                return this.visaExpDateField;
            }
            set {
                this.visaExpDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("visaType")]
        public SearchColumnSelectField[] visaType {
            get {
                return this.visaTypeField;
            }
            set {
                this.visaTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("workCalendar")]
        public SearchColumnStringField[] workCalendar {
            get {
                return this.workCalendarField;
            }
            set {
                this.workCalendarField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("workplace")]
        public SearchColumnSelectField[] workplace {
            get {
                return this.workplaceField;
            }
            set {
                this.workplaceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("zipCode")]
        public SearchColumnStringField[] zipCode {
            get {
                return this.zipCodeField;
            }
            set {
                this.zipCodeField = value;
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