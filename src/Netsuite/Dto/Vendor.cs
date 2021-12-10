using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [GeneratedCode("wsdl", "4.8.3928.0")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace="urn:relationships_2021_1.lists.webservices.netsuite.com")]
    public class Vendor : Record {

        private RecordRef _customFormField;

        private string _altNameField;

        private bool _isPersonField;

        private bool _isPersonFieldSpecified;

        private string _phoneticNameField;

        private string _salutationField;

        private string _firstNameField;

        private string _middleNameField;

        private string _lastNameField;

        private string _companyNameField;

        private string _phoneField;

        private string _faxField;

        private string _emailField;

        private string _urlField;

        private string _defaultAddressField;

        private bool _isInactiveField;

        private bool _isInactiveFieldSpecified;

        private DateTime _lastModifiedDateField;

        private bool _lastModifiedDateFieldSpecified;

        private DateTime _dateCreatedField;

        private bool _dateCreatedFieldSpecified;

        private RecordRef _categoryField;

        private string _titleField;

        private string _printOnCheckAsField;

        private string _altPhoneField;

        private string _homePhoneField;

        private string _mobilePhoneField;

        private string _altEmailField;

        private string _commentsField;

        private GlobalSubscriptionStatus _globalSubscriptionStatusField;

        private bool _globalSubscriptionStatusFieldSpecified;

        private RecordRef _imageField;

        private EmailPreference _emailPreferenceField;

        private bool _emailPreferenceFieldSpecified;

        private RecordRef _subsidiaryField;

        private RecordRef _representingSubsidiaryField;

        private string _accountNumberField;

        private string _legalNameField;

        private string _vatRegNumberField;

        private RecordRef _expenseAccountField;

        private RecordRef _payablesAccountField;

        private RecordRef _termsField;

        private RecordRef _incotermField;

        private double _creditLimitField;

        private bool _creditLimitFieldSpecified;

        private double _balancePrimaryField;

        private bool _balancePrimaryFieldSpecified;

        private double _openingBalanceField;

        private bool _openingBalanceFieldSpecified;

        private DateTime _openingBalanceDateField;

        private bool _openingBalanceDateFieldSpecified;

        private RecordRef _openingBalanceAccountField;

        private double _balanceField;

        private bool _balanceFieldSpecified;

        private double _unbilledOrdersPrimaryField;

        private bool _unbilledOrdersPrimaryFieldSpecified;

        private string _bcnField;

        private double _unbilledOrdersField;

        private bool _unbilledOrdersFieldSpecified;

        private bool _is1099EligibleField;

        private bool _is1099EligibleFieldSpecified;

        private bool _isJobResourceVendField;

        private bool _isJobResourceVendFieldSpecified;

        private double _laborCostField;

        private bool _laborCostFieldSpecified;

        private double _purchaseOrderQuantityField;

        private bool _purchaseOrderQuantityFieldSpecified;

        private double _purchaseOrderAmountField;

        private bool _purchaseOrderAmountFieldSpecified;

        private double _purchaseOrderQuantityDiffField;

        private bool _purchaseOrderQuantityDiffFieldSpecified;

        private double _receiptQuantityField;

        private bool _receiptQuantityFieldSpecified;

        private double _receiptAmountField;

        private bool _receiptAmountFieldSpecified;

        private double _receiptQuantityDiffField;

        private bool _receiptQuantityDiffFieldSpecified;

        private RecordRef _workCalendarField;

        private string _taxIdNumField;

        private RecordRef _taxItemField;

        private bool _giveAccessField;

        private bool _giveAccessFieldSpecified;

        private bool _sendEmailField;

        private bool _sendEmailFieldSpecified;

        private bool _billPayField;

        private bool _billPayFieldSpecified;

        private bool _isAccountantField;

        private bool _isAccountantFieldSpecified;

        private string _passwordField;

        private string _password2Field;

        private bool _requirePwdChangeField;

        private bool _requirePwdChangeFieldSpecified;

        private bool _eligibleForCommissionField;

        private bool _eligibleForCommissionFieldSpecified;

        private bool _emailTransactionsField;

        private bool _emailTransactionsFieldSpecified;

        private bool _printTransactionsField;

        private bool _printTransactionsFieldSpecified;

        private bool _faxTransactionsField;

        private bool _faxTransactionsFieldSpecified;

        private RecordRef _defaultTaxRegField;

        private VendorPricingScheduleList _pricingScheduleListField;

        private SubscriptionsList _subscriptionsListField;

        private VendorAddressbookList _addressbookListField;

        private VendorCurrencyList _currencyListField;

        private VendorRolesList _rolesListField;

        private VendorTaxRegistrationList _taxRegistrationListField;

        private long _predictedDaysField;

        private bool _predictedDaysFieldSpecified;

        private double _predConfidenceField;

        private bool _predConfidenceFieldSpecified;

        private CustomFieldRef[] _customFieldListField;

        private string _internalIdField;

        private string _externalIdField;
        
        public string EntityId { get; set; }
        public string EntityTitle { get; set; }

        /// <remarks/>
        public RecordRef CustomForm {
            get => _customFormField;
            set => _customFormField = value;
        }

        /// <remarks/>
        public string AltName {
            get => _altNameField;
            set => _altNameField = value;
        }

        /// <remarks/>
        public bool IsPerson {
            get => _isPersonField;
            set => _isPersonField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool IsPersonSpecified {
            get => _isPersonFieldSpecified;
            set => _isPersonFieldSpecified = value;
        }

        /// <remarks/>
        public string PhoneticName {
            get => _phoneticNameField;
            set => _phoneticNameField = value;
        }

        /// <remarks/>
        public string Salutation {
            get => _salutationField;
            set => _salutationField = value;
        }

        /// <remarks/>
        public string FirstName {
            get => _firstNameField;
            set => _firstNameField = value;
        }

        /// <remarks/>
        public string MiddleName {
            get => _middleNameField;
            set => _middleNameField = value;
        }

        /// <remarks/>
        public string LastName {
            get => _lastNameField;
            set => _lastNameField = value;
        }

        /// <remarks/>
        public string CompanyName {
            get => _companyNameField;
            set => _companyNameField = value;
        }

        /// <remarks/>
        public string Phone {
            get => _phoneField;
            set => _phoneField = value;
        }

        /// <remarks/>
        public string Fax {
            get => _faxField;
            set => _faxField = value;
        }

        /// <remarks/>
        public string Email {
            get => _emailField;
            set => _emailField = value;
        }

        /// <remarks/>
        public string Url {
            get => _urlField;
            set => _urlField = value;
        }

        /// <remarks/>
        public string DefaultAddress {
            get => _defaultAddressField;
            set => _defaultAddressField = value;
        }

        /// <remarks/>
        public bool IsInactive {
            get => _isInactiveField;
            set => _isInactiveField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool IsInactiveSpecified {
            get => _isInactiveFieldSpecified;
            set => _isInactiveFieldSpecified = value;
        }

        /// <remarks/>
        public DateTime LastModifiedDate {
            get => _lastModifiedDateField;
            set => _lastModifiedDateField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool LastModifiedDateSpecified {
            get => _lastModifiedDateFieldSpecified;
            set => _lastModifiedDateFieldSpecified = value;
        }

        /// <remarks/>
        public DateTime DateCreated {
            get => _dateCreatedField;
            set => _dateCreatedField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool DateCreatedSpecified {
            get => _dateCreatedFieldSpecified;
            set => _dateCreatedFieldSpecified = value;
        }

        /// <remarks/>
        public RecordRef Category {
            get => _categoryField;
            set => _categoryField = value;
        }

        /// <remarks/>
        public string Title {
            get => _titleField;
            set => _titleField = value;
        }

        /// <remarks/>
        public string PrintOnCheckAs {
            get => _printOnCheckAsField;
            set => _printOnCheckAsField = value;
        }

        /// <remarks/>
        public string AltPhone {
            get => _altPhoneField;
            set => _altPhoneField = value;
        }

        /// <remarks/>
        public string HomePhone {
            get => _homePhoneField;
            set => _homePhoneField = value;
        }

        /// <remarks/>
        public string MobilePhone {
            get => _mobilePhoneField;
            set => _mobilePhoneField = value;
        }

        /// <remarks/>
        public string AltEmail {
            get => _altEmailField;
            set => _altEmailField = value;
        }

        /// <remarks/>
        public string Comments {
            get => _commentsField;
            set => _commentsField = value;
        }

        /// <remarks/>
        public GlobalSubscriptionStatus GlobalSubscriptionStatus {
            get => _globalSubscriptionStatusField;
            set => _globalSubscriptionStatusField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool GlobalSubscriptionStatusSpecified {
            get => _globalSubscriptionStatusFieldSpecified;
            set => _globalSubscriptionStatusFieldSpecified = value;
        }

        /// <remarks/>
        public RecordRef Image {
            get => _imageField;
            set => _imageField = value;
        }

        /// <remarks/>
        public EmailPreference EmailPreference {
            get => _emailPreferenceField;
            set => _emailPreferenceField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool EmailPreferenceSpecified {
            get => _emailPreferenceFieldSpecified;
            set => _emailPreferenceFieldSpecified = value;
        }

        /// <remarks/>
        public RecordRef Subsidiary {
            get => _subsidiaryField;
            set => _subsidiaryField = value;
        }

        /// <remarks/>
        public RecordRef RepresentingSubsidiary {
            get => _representingSubsidiaryField;
            set => _representingSubsidiaryField = value;
        }

        /// <remarks/>
        public string AccountNumber {
            get => _accountNumberField;
            set => _accountNumberField = value;
        }

        /// <remarks/>
        public string LegalName {
            get => _legalNameField;
            set => _legalNameField = value;
        }

        /// <remarks/>
        public string VatRegNumber {
            get => _vatRegNumberField;
            set => _vatRegNumberField = value;
        }

        /// <remarks/>
        public RecordRef ExpenseAccount {
            get => _expenseAccountField;
            set => _expenseAccountField = value;
        }

        /// <remarks/>
        public RecordRef PayablesAccount {
            get => _payablesAccountField;
            set => _payablesAccountField = value;
        }

        /// <remarks/>
        public RecordRef Terms {
            get => _termsField;
            set => _termsField = value;
        }

        /// <remarks/>
        public RecordRef Incoterm {
            get => _incotermField;
            set => _incotermField = value;
        }

        /// <remarks/>
        public double CreditLimit {
            get => _creditLimitField;
            set => _creditLimitField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool CreditLimitSpecified {
            get => _creditLimitFieldSpecified;
            set => _creditLimitFieldSpecified = value;
        }

        /// <remarks/>
        public double BalancePrimary {
            get => _balancePrimaryField;
            set => _balancePrimaryField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool BalancePrimarySpecified {
            get => _balancePrimaryFieldSpecified;
            set => _balancePrimaryFieldSpecified = value;
        }

        /// <remarks/>
        public double OpeningBalance {
            get => _openingBalanceField;
            set => _openingBalanceField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool OpeningBalanceSpecified {
            get => _openingBalanceFieldSpecified;
            set => _openingBalanceFieldSpecified = value;
        }

        /// <remarks/>
        public DateTime OpeningBalanceDate {
            get => _openingBalanceDateField;
            set => _openingBalanceDateField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool OpeningBalanceDateSpecified {
            get => _openingBalanceDateFieldSpecified;
            set => _openingBalanceDateFieldSpecified = value;
        }

        /// <remarks/>
        public RecordRef OpeningBalanceAccount {
            get => _openingBalanceAccountField;
            set => _openingBalanceAccountField = value;
        }

        /// <remarks/>
        public double Balance {
            get => _balanceField;
            set => _balanceField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool BalanceSpecified {
            get => _balanceFieldSpecified;
            set => _balanceFieldSpecified = value;
        }

        /// <remarks/>
        public double UnbilledOrdersPrimary {
            get => _unbilledOrdersPrimaryField;
            set => _unbilledOrdersPrimaryField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool UnbilledOrdersPrimarySpecified {
            get => _unbilledOrdersPrimaryFieldSpecified;
            set => _unbilledOrdersPrimaryFieldSpecified = value;
        }

        /// <remarks/>
        public string Bcn {
            get => _bcnField;
            set => _bcnField = value;
        }

        /// <remarks/>
        public double UnbilledOrders {
            get => _unbilledOrdersField;
            set => _unbilledOrdersField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool UnbilledOrdersSpecified {
            get => _unbilledOrdersFieldSpecified;
            set => _unbilledOrdersFieldSpecified = value;
        }

        /// <remarks/>
        public bool Is1099Eligible {
            get => _is1099EligibleField;
            set => _is1099EligibleField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool Is1099EligibleSpecified {
            get => _is1099EligibleFieldSpecified;
            set => _is1099EligibleFieldSpecified = value;
        }

        /// <remarks/>
        public bool IsJobResourceVend {
            get => _isJobResourceVendField;
            set => _isJobResourceVendField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool IsJobResourceVendSpecified {
            get => _isJobResourceVendFieldSpecified;
            set => _isJobResourceVendFieldSpecified = value;
        }

        /// <remarks/>
        public double LaborCost {
            get => _laborCostField;
            set => _laborCostField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool LaborCostSpecified {
            get => _laborCostFieldSpecified;
            set => _laborCostFieldSpecified = value;
        }

        /// <remarks/>
        public double PurchaseOrderQuantity {
            get => _purchaseOrderQuantityField;
            set => _purchaseOrderQuantityField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool PurchaseOrderQuantitySpecified {
            get => _purchaseOrderQuantityFieldSpecified;
            set => _purchaseOrderQuantityFieldSpecified = value;
        }

        /// <remarks/>
        public double PurchaseOrderAmount {
            get => _purchaseOrderAmountField;
            set => _purchaseOrderAmountField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool PurchaseOrderAmountSpecified {
            get => _purchaseOrderAmountFieldSpecified;
            set => _purchaseOrderAmountFieldSpecified = value;
        }

        /// <remarks/>
        public double PurchaseOrderQuantityDiff {
            get => _purchaseOrderQuantityDiffField;
            set => _purchaseOrderQuantityDiffField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool PurchaseOrderQuantityDiffSpecified {
            get => _purchaseOrderQuantityDiffFieldSpecified;
            set => _purchaseOrderQuantityDiffFieldSpecified = value;
        }

        /// <remarks/>
        public double ReceiptQuantity {
            get => _receiptQuantityField;
            set => _receiptQuantityField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool ReceiptQuantitySpecified {
            get => _receiptQuantityFieldSpecified;
            set => _receiptQuantityFieldSpecified = value;
        }

        /// <remarks/>
        public double ReceiptAmount {
            get => _receiptAmountField;
            set => _receiptAmountField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool ReceiptAmountSpecified {
            get => _receiptAmountFieldSpecified;
            set => _receiptAmountFieldSpecified = value;
        }

        /// <remarks/>
        public double ReceiptQuantityDiff {
            get => _receiptQuantityDiffField;
            set => _receiptQuantityDiffField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool ReceiptQuantityDiffSpecified {
            get => _receiptQuantityDiffFieldSpecified;
            set => _receiptQuantityDiffFieldSpecified = value;
        }

        /// <remarks/>
        public RecordRef WorkCalendar {
            get => _workCalendarField;
            set => _workCalendarField = value;
        }

        /// <remarks/>
        public string TaxIdNum {
            get => _taxIdNumField;
            set => _taxIdNumField = value;
        }

        /// <remarks/>
        public RecordRef TaxItem {
            get => _taxItemField;
            set => _taxItemField = value;
        }

        /// <remarks/>
        public bool GiveAccess {
            get => _giveAccessField;
            set => _giveAccessField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool GiveAccessSpecified {
            get => _giveAccessFieldSpecified;
            set => _giveAccessFieldSpecified = value;
        }

        /// <remarks/>
        public bool SendEmail {
            get => _sendEmailField;
            set => _sendEmailField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool SendEmailSpecified {
            get => _sendEmailFieldSpecified;
            set => _sendEmailFieldSpecified = value;
        }

        /// <remarks/>
        public bool BillPay {
            get => _billPayField;
            set => _billPayField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool BillPaySpecified {
            get => _billPayFieldSpecified;
            set => _billPayFieldSpecified = value;
        }

        /// <remarks/>
        public bool IsAccountant {
            get => _isAccountantField;
            set => _isAccountantField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool IsAccountantSpecified {
            get => _isAccountantFieldSpecified;
            set => _isAccountantFieldSpecified = value;
        }

        /// <remarks/>
        public string Password {
            get => _passwordField;
            set => _passwordField = value;
        }

        /// <remarks/>
        public string Password2 {
            get => _password2Field;
            set => _password2Field = value;
        }

        /// <remarks/>
        public bool RequirePwdChange {
            get => _requirePwdChangeField;
            set => _requirePwdChangeField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool RequirePwdChangeSpecified {
            get => _requirePwdChangeFieldSpecified;
            set => _requirePwdChangeFieldSpecified = value;
        }

        /// <remarks/>
        public bool EligibleForCommission {
            get => _eligibleForCommissionField;
            set => _eligibleForCommissionField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool EligibleForCommissionSpecified {
            get => _eligibleForCommissionFieldSpecified;
            set => _eligibleForCommissionFieldSpecified = value;
        }

        /// <remarks/>
        public bool EmailTransactions {
            get => _emailTransactionsField;
            set => _emailTransactionsField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool EmailTransactionsSpecified {
            get => _emailTransactionsFieldSpecified;
            set => _emailTransactionsFieldSpecified = value;
        }

        /// <remarks/>
        public bool PrintTransactions {
            get => _printTransactionsField;
            set => _printTransactionsField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool PrintTransactionsSpecified {
            get => _printTransactionsFieldSpecified;
            set => _printTransactionsFieldSpecified = value;
        }

        /// <remarks/>
        public bool FaxTransactions {
            get => _faxTransactionsField;
            set => _faxTransactionsField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool FaxTransactionsSpecified {
            get => _faxTransactionsFieldSpecified;
            set => _faxTransactionsFieldSpecified = value;
        }

        /// <remarks/>
        public RecordRef DefaultTaxReg {
            get => _defaultTaxRegField;
            set => _defaultTaxRegField = value;
        }

        /// <remarks/>
        public VendorPricingScheduleList PricingScheduleList {
            get => _pricingScheduleListField;
            set => _pricingScheduleListField = value;
        }

        /// <remarks/>
        public SubscriptionsList SubscriptionsList {
            get => _subscriptionsListField;
            set => _subscriptionsListField = value;
        }

        /// <remarks/>
        public VendorAddressbookList AddressbookList {
            get => _addressbookListField;
            set => _addressbookListField = value;
        }

        /// <remarks/>
        public VendorCurrencyList CurrencyList {
            get => _currencyListField;
            set => _currencyListField = value;
        }

        /// <remarks/>
        public VendorRolesList RolesList {
            get => _rolesListField;
            set => _rolesListField = value;
        }

        /// <remarks/>
        public VendorTaxRegistrationList TaxRegistrationList {
            get => _taxRegistrationListField;
            set => _taxRegistrationListField = value;
        }

        /// <remarks/>
        public long PredictedDays {
            get => _predictedDaysField;
            set => _predictedDaysField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool PredictedDaysSpecified {
            get => _predictedDaysFieldSpecified;
            set => _predictedDaysFieldSpecified = value;
        }

        /// <remarks/>
        public double PredConfidence {
            get => _predConfidenceField;
            set => _predConfidenceField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool PredConfidenceSpecified {
            get => _predConfidenceFieldSpecified;
            set => _predConfidenceFieldSpecified = value;
        }

        /// <remarks/>
        [XmlArrayItemAttribute("customField", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public CustomFieldRef[] CustomFieldList {
            get => _customFieldListField;
            set => _customFieldListField = value;
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string InternalId {
            get => _internalIdField;
            set => _internalIdField = value;
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string ExternalId {
            get => _externalIdField;
            set => _externalIdField = value;
        }
    }
}