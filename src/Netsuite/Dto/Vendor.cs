using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:relationships_2021_1.lists.webservices.netsuite.com")]
    public partial class Vendor : Record {

        private RecordRef customFormField;

        private string entityIdField;

        private string altNameField;

        private bool isPersonField;

        private bool isPersonFieldSpecified;

        private string phoneticNameField;

        private string salutationField;

        private string firstNameField;

        private string middleNameField;

        private string lastNameField;

        private string companyNameField;

        private string phoneField;

        private string faxField;

        private string emailField;

        private string urlField;

        private string defaultAddressField;

        private bool isInactiveField;

        private bool isInactiveFieldSpecified;

        private System.DateTime lastModifiedDateField;

        private bool lastModifiedDateFieldSpecified;

        private System.DateTime dateCreatedField;

        private bool dateCreatedFieldSpecified;

        private RecordRef categoryField;

        private string titleField;

        private string printOnCheckAsField;

        private string altPhoneField;

        private string homePhoneField;

        private string mobilePhoneField;

        private string altEmailField;

        private string commentsField;

        private GlobalSubscriptionStatus globalSubscriptionStatusField;

        private bool globalSubscriptionStatusFieldSpecified;

        private RecordRef imageField;

        private EmailPreference emailPreferenceField;

        private bool emailPreferenceFieldSpecified;

        private RecordRef subsidiaryField;

        private RecordRef representingSubsidiaryField;

        private string accountNumberField;

        private string legalNameField;

        private string vatRegNumberField;

        private RecordRef expenseAccountField;

        private RecordRef payablesAccountField;

        private RecordRef termsField;

        private RecordRef incotermField;

        private double creditLimitField;

        private bool creditLimitFieldSpecified;

        private double balancePrimaryField;

        private bool balancePrimaryFieldSpecified;

        private double openingBalanceField;

        private bool openingBalanceFieldSpecified;

        private System.DateTime openingBalanceDateField;

        private bool openingBalanceDateFieldSpecified;

        private RecordRef openingBalanceAccountField;

        private double balanceField;

        private bool balanceFieldSpecified;

        private double unbilledOrdersPrimaryField;

        private bool unbilledOrdersPrimaryFieldSpecified;

        private string bcnField;

        private double unbilledOrdersField;

        private bool unbilledOrdersFieldSpecified;

        private RecordRef currencyField;

        private bool is1099EligibleField;

        private bool is1099EligibleFieldSpecified;

        private bool isJobResourceVendField;

        private bool isJobResourceVendFieldSpecified;

        private double laborCostField;

        private bool laborCostFieldSpecified;

        private double purchaseOrderQuantityField;

        private bool purchaseOrderQuantityFieldSpecified;

        private double purchaseOrderAmountField;

        private bool purchaseOrderAmountFieldSpecified;

        private double purchaseOrderQuantityDiffField;

        private bool purchaseOrderQuantityDiffFieldSpecified;

        private double receiptQuantityField;

        private bool receiptQuantityFieldSpecified;

        private double receiptAmountField;

        private bool receiptAmountFieldSpecified;

        private double receiptQuantityDiffField;

        private bool receiptQuantityDiffFieldSpecified;

        private RecordRef workCalendarField;

        private string taxIdNumField;

        private RecordRef taxItemField;

        private bool giveAccessField;

        private bool giveAccessFieldSpecified;

        private bool sendEmailField;

        private bool sendEmailFieldSpecified;

        private bool billPayField;

        private bool billPayFieldSpecified;

        private bool isAccountantField;

        private bool isAccountantFieldSpecified;

        private string passwordField;

        private string password2Field;

        private bool requirePwdChangeField;

        private bool requirePwdChangeFieldSpecified;

        private bool eligibleForCommissionField;

        private bool eligibleForCommissionFieldSpecified;

        private bool emailTransactionsField;

        private bool emailTransactionsFieldSpecified;

        private bool printTransactionsField;

        private bool printTransactionsFieldSpecified;

        private bool faxTransactionsField;

        private bool faxTransactionsFieldSpecified;

        private RecordRef defaultTaxRegField;

        private VendorPricingScheduleList pricingScheduleListField;

        private SubscriptionsList subscriptionsListField;

        private VendorAddressbookList addressbookListField;

        private VendorCurrencyList currencyListField;

        private VendorRolesList rolesListField;

        private VendorTaxRegistrationList taxRegistrationListField;

        private long predictedDaysField;

        private bool predictedDaysFieldSpecified;

        private double predConfidenceField;

        private bool predConfidenceFieldSpecified;

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
        public bool isPerson {
            get {
                return this.isPersonField;
            }
            set {
                this.isPersonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPersonSpecified {
            get {
                return this.isPersonFieldSpecified;
            }
            set {
                this.isPersonFieldSpecified = value;
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
        public string companyName {
            get {
                return this.companyNameField;
            }
            set {
                this.companyNameField = value;
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
        public string url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
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
        public RecordRef category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
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
        public string printOnCheckAs {
            get {
                return this.printOnCheckAsField;
            }
            set {
                this.printOnCheckAsField = value;
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
        public string altEmail {
            get {
                return this.altEmailField;
            }
            set {
                this.altEmailField = value;
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
        public RecordRef subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
            }
        }

        /// <remarks/>
        public RecordRef representingSubsidiary {
            get {
                return this.representingSubsidiaryField;
            }
            set {
                this.representingSubsidiaryField = value;
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
        public string legalName {
            get {
                return this.legalNameField;
            }
            set {
                this.legalNameField = value;
            }
        }

        /// <remarks/>
        public string vatRegNumber {
            get {
                return this.vatRegNumberField;
            }
            set {
                this.vatRegNumberField = value;
            }
        }

        /// <remarks/>
        public RecordRef expenseAccount {
            get {
                return this.expenseAccountField;
            }
            set {
                this.expenseAccountField = value;
            }
        }

        /// <remarks/>
        public RecordRef payablesAccount {
            get {
                return this.payablesAccountField;
            }
            set {
                this.payablesAccountField = value;
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
        public RecordRef incoterm {
            get {
                return this.incotermField;
            }
            set {
                this.incotermField = value;
            }
        }

        /// <remarks/>
        public double creditLimit {
            get {
                return this.creditLimitField;
            }
            set {
                this.creditLimitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool creditLimitSpecified {
            get {
                return this.creditLimitFieldSpecified;
            }
            set {
                this.creditLimitFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double balancePrimary {
            get {
                return this.balancePrimaryField;
            }
            set {
                this.balancePrimaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool balancePrimarySpecified {
            get {
                return this.balancePrimaryFieldSpecified;
            }
            set {
                this.balancePrimaryFieldSpecified = value;
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
        public double unbilledOrdersPrimary {
            get {
                return this.unbilledOrdersPrimaryField;
            }
            set {
                this.unbilledOrdersPrimaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unbilledOrdersPrimarySpecified {
            get {
                return this.unbilledOrdersPrimaryFieldSpecified;
            }
            set {
                this.unbilledOrdersPrimaryFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string bcn {
            get {
                return this.bcnField;
            }
            set {
                this.bcnField = value;
            }
        }

        /// <remarks/>
        public double unbilledOrders {
            get {
                return this.unbilledOrdersField;
            }
            set {
                this.unbilledOrdersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unbilledOrdersSpecified {
            get {
                return this.unbilledOrdersFieldSpecified;
            }
            set {
                this.unbilledOrdersFieldSpecified = value;
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
        public bool is1099Eligible {
            get {
                return this.is1099EligibleField;
            }
            set {
                this.is1099EligibleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool is1099EligibleSpecified {
            get {
                return this.is1099EligibleFieldSpecified;
            }
            set {
                this.is1099EligibleFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isJobResourceVend {
            get {
                return this.isJobResourceVendField;
            }
            set {
                this.isJobResourceVendField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isJobResourceVendSpecified {
            get {
                return this.isJobResourceVendFieldSpecified;
            }
            set {
                this.isJobResourceVendFieldSpecified = value;
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
        public double purchaseOrderQuantity {
            get {
                return this.purchaseOrderQuantityField;
            }
            set {
                this.purchaseOrderQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool purchaseOrderQuantitySpecified {
            get {
                return this.purchaseOrderQuantityFieldSpecified;
            }
            set {
                this.purchaseOrderQuantityFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double purchaseOrderAmount {
            get {
                return this.purchaseOrderAmountField;
            }
            set {
                this.purchaseOrderAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool purchaseOrderAmountSpecified {
            get {
                return this.purchaseOrderAmountFieldSpecified;
            }
            set {
                this.purchaseOrderAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double purchaseOrderQuantityDiff {
            get {
                return this.purchaseOrderQuantityDiffField;
            }
            set {
                this.purchaseOrderQuantityDiffField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool purchaseOrderQuantityDiffSpecified {
            get {
                return this.purchaseOrderQuantityDiffFieldSpecified;
            }
            set {
                this.purchaseOrderQuantityDiffFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double receiptQuantity {
            get {
                return this.receiptQuantityField;
            }
            set {
                this.receiptQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool receiptQuantitySpecified {
            get {
                return this.receiptQuantityFieldSpecified;
            }
            set {
                this.receiptQuantityFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double receiptAmount {
            get {
                return this.receiptAmountField;
            }
            set {
                this.receiptAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool receiptAmountSpecified {
            get {
                return this.receiptAmountFieldSpecified;
            }
            set {
                this.receiptAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double receiptQuantityDiff {
            get {
                return this.receiptQuantityDiffField;
            }
            set {
                this.receiptQuantityDiffField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool receiptQuantityDiffSpecified {
            get {
                return this.receiptQuantityDiffFieldSpecified;
            }
            set {
                this.receiptQuantityDiffFieldSpecified = value;
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
        public string taxIdNum {
            get {
                return this.taxIdNumField;
            }
            set {
                this.taxIdNumField = value;
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
        public bool isAccountant {
            get {
                return this.isAccountantField;
            }
            set {
                this.isAccountantField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAccountantSpecified {
            get {
                return this.isAccountantFieldSpecified;
            }
            set {
                this.isAccountantFieldSpecified = value;
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
        public bool emailTransactions {
            get {
                return this.emailTransactionsField;
            }
            set {
                this.emailTransactionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool emailTransactionsSpecified {
            get {
                return this.emailTransactionsFieldSpecified;
            }
            set {
                this.emailTransactionsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool printTransactions {
            get {
                return this.printTransactionsField;
            }
            set {
                this.printTransactionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printTransactionsSpecified {
            get {
                return this.printTransactionsFieldSpecified;
            }
            set {
                this.printTransactionsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool faxTransactions {
            get {
                return this.faxTransactionsField;
            }
            set {
                this.faxTransactionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool faxTransactionsSpecified {
            get {
                return this.faxTransactionsFieldSpecified;
            }
            set {
                this.faxTransactionsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef defaultTaxReg {
            get {
                return this.defaultTaxRegField;
            }
            set {
                this.defaultTaxRegField = value;
            }
        }

        /// <remarks/>
        public VendorPricingScheduleList pricingScheduleList {
            get {
                return this.pricingScheduleListField;
            }
            set {
                this.pricingScheduleListField = value;
            }
        }

        /// <remarks/>
        public SubscriptionsList subscriptionsList {
            get {
                return this.subscriptionsListField;
            }
            set {
                this.subscriptionsListField = value;
            }
        }

        /// <remarks/>
        public VendorAddressbookList addressbookList {
            get {
                return this.addressbookListField;
            }
            set {
                this.addressbookListField = value;
            }
        }

        /// <remarks/>
        public VendorCurrencyList currencyList {
            get {
                return this.currencyListField;
            }
            set {
                this.currencyListField = value;
            }
        }

        /// <remarks/>
        public VendorRolesList rolesList {
            get {
                return this.rolesListField;
            }
            set {
                this.rolesListField = value;
            }
        }

        /// <remarks/>
        public VendorTaxRegistrationList taxRegistrationList {
            get {
                return this.taxRegistrationListField;
            }
            set {
                this.taxRegistrationListField = value;
            }
        }

        /// <remarks/>
        public long predictedDays {
            get {
                return this.predictedDaysField;
            }
            set {
                this.predictedDaysField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool predictedDaysSpecified {
            get {
                return this.predictedDaysFieldSpecified;
            }
            set {
                this.predictedDaysFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double predConfidence {
            get {
                return this.predConfidenceField;
            }
            set {
                this.predConfidenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool predConfidenceSpecified {
            get {
                return this.predConfidenceFieldSpecified;
            }
            set {
                this.predConfidenceFieldSpecified = value;
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