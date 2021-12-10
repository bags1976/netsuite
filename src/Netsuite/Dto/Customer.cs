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
    public class Customer : Record {

        private RecordRef _customFormField;

        private string _entityIdField;

        private string _altNameField;

        private bool _isPersonField;

        private bool _isPersonFieldSpecified;

        private string _phoneticNameField;

        private string _salutationField;

        private string _firstNameField;

        private string _middleNameField;

        private string _lastNameField;

        private string _companyNameField;

        private RecordRef _entityStatusField;

        private RecordRef _parentField;

        private string _phoneField;

        private string _faxField;

        private string _emailField;

        private string _urlField;

        private string _defaultAddressField;

        private bool _isInactiveField;

        private bool _isInactiveFieldSpecified;

        private RecordRef _categoryField;

        private string _titleField;

        private string _printOnCheckAsField;

        private string _altPhoneField;

        private string _homePhoneField;

        private string _mobilePhoneField;

        private string _altEmailField;

        private string _languageField;

        private bool _languageFieldSpecified;

        private string _commentsField;

        private bool _numberFormatFieldSpecified;

        private bool _negativeNumberFormatFieldSpecified;

        private DateTime _dateCreatedField;

        private bool _dateCreatedFieldSpecified;

        private RecordRef _imageField;

        private EmailPreference _emailPreferenceField;

        private bool _emailPreferenceFieldSpecified;

        private RecordRef _subsidiaryField;

        private RecordRef _representingSubsidiaryField;

        private RecordRef _salesRepField;

        private RecordRef _territoryField;

        private string _contribPctField;

        private RecordRef _partnerField;

        private RecordRef _salesGroupField;

        private string _vatRegNumberField;

        private string _accountNumberField;

        private bool _taxExemptField;

        private bool _taxExemptFieldSpecified;

        private RecordRef _termsField;

        private double _creditLimitField;

        private bool _creditLimitFieldSpecified;

        private CustomerCreditHoldOverride _creditHoldOverrideField;

        private bool _creditHoldOverrideFieldSpecified;

        private bool _monthlyClosingFieldSpecified;

        private bool _overrideCurrencyFormatField;

        private bool _overrideCurrencyFormatFieldSpecified;

        private string _displaySymbolField;

        private bool _symbolPlacementFieldSpecified;

        private double _balanceField;

        private bool _balanceFieldSpecified;

        private double _overdueBalanceField;

        private bool _overdueBalanceFieldSpecified;

        private long _daysOverdueField;

        private bool _daysOverdueFieldSpecified;

        private double _unbilledOrdersField;

        private bool _unbilledOrdersFieldSpecified;

        private double _consolUnbilledOrdersField;

        private bool _consolUnbilledOrdersFieldSpecified;

        private double _consolOverdueBalanceField;

        private bool _consolOverdueBalanceFieldSpecified;

        private double _consolDepositBalanceField;

        private bool _consolDepositBalanceFieldSpecified;

        private double _consolBalanceField;

        private bool _consolBalanceFieldSpecified;

        private double _consolAgingField;

        private bool _consolAgingFieldSpecified;

        private double _consolAging1Field;

        private bool _consolAging1FieldSpecified;

        private double _consolAging2Field;

        private bool _consolAging2FieldSpecified;

        private double _consolAging3Field;

        private bool _consolAging3FieldSpecified;

        private double _consolAging4Field;

        private bool _consolAging4FieldSpecified;

        private long _consolDaysOverdueField;

        private bool _consolDaysOverdueFieldSpecified;

        private RecordRef _priceLevelField;

        private RecordRef _prefCcProcessorField;

        private double _depositBalanceField;

        private bool _depositBalanceFieldSpecified;

        private bool _shipCompleteField;

        private bool _shipCompleteFieldSpecified;

        private bool _taxableField;

        private bool _taxableFieldSpecified;

        private RecordRef _taxItemField;

        private string _resaleNumberField;

        private double _agingField;

        private bool _agingFieldSpecified;

        private double _aging1Field;

        private bool _aging1FieldSpecified;

        private double _aging2Field;

        private bool _aging2FieldSpecified;

        private double _aging3Field;

        private bool _aging3FieldSpecified;

        private double _aging4Field;

        private bool _aging4FieldSpecified;

        private DateTime _startDateField;

        private bool _startDateFieldSpecified;

        private bool _alcoholRecipientTypeFieldSpecified;

        private DateTime _endDateField;

        private bool _endDateFieldSpecified;

        private long _reminderDaysField;

        private bool _reminderDaysFieldSpecified;

        private RecordRef _shippingItemField;

        private string _thirdPartyAcctField;

        private string _thirdPartyZipcodeField;

        private bool _thirdPartyCountryFieldSpecified;

        private bool _giveAccessField;

        private bool _giveAccessFieldSpecified;

        private double _estimatedBudgetField;

        private bool _estimatedBudgetFieldSpecified;

        private RecordRef _accessRoleField;

        private bool _sendEmailField;

        private bool _sendEmailFieldSpecified;

        private RecordRef _assignedWebSiteField;

        private string _passwordField;

        private string _password2Field;

        private bool _requirePwdChangeField;

        private bool _requirePwdChangeFieldSpecified;

        private RecordRef _campaignCategoryField;

        private RecordRef _sourceWebSiteField;

        private RecordRef _leadSourceField;

        private RecordRef _receivablesAccountField;

        private RecordRef _drAccountField;

        private RecordRef _fxAccountField;

        private double _defaultOrderPriorityField;

        private bool _defaultOrderPriorityFieldSpecified;

        private string _webLeadField;

        private string _referrerField;

        private string _keywordsField;

        private string _clickStreamField;

        private string _lastPageVisitedField;

        private long _visitsField;

        private bool _visitsFieldSpecified;

        private DateTime _firstVisitField;

        private bool _firstVisitFieldSpecified;

        private DateTime _lastVisitField;

        private bool _lastVisitFieldSpecified;

        private bool _billPayField;

        private bool _billPayFieldSpecified;

        private double _openingBalanceField;

        private bool _openingBalanceFieldSpecified;

        private DateTime _lastModifiedDateField;

        private bool _lastModifiedDateFieldSpecified;

        private DateTime _openingBalanceDateField;

        private bool _openingBalanceDateFieldSpecified;

        private RecordRef _openingBalanceAccountField;

        private CustomerStage _stageField;

        private bool _stageFieldSpecified;

        private bool _emailTransactionsField;

        private bool _emailTransactionsFieldSpecified;

        private bool _printTransactionsField;

        private bool _printTransactionsFieldSpecified;

        private bool _faxTransactionsField;

        private bool _faxTransactionsFieldSpecified;

        private RecordRef _defaultTaxRegField;

        private bool _syncPartnerTeamsField;

        private bool _syncPartnerTeamsFieldSpecified;

        private bool _isBudgetApprovedField;

        private bool _isBudgetApprovedFieldSpecified;

        private GlobalSubscriptionStatus _globalSubscriptionStatusField;

        private bool _globalSubscriptionStatusFieldSpecified;

        private RecordRef _salesReadinessField;

        private CustomerSalesTeamList _salesTeamListField;

        private RecordRef _buyingReasonField;

        private CustomerDownloadList _downloadListField;

        private RecordRef _buyingTimeFrameField;

        private CustomerAddressbookList _addressbookListField;

        private SubscriptionsList _subscriptionsListField;

        private ContactAccessRolesList _contactRolesListField;

        private CustomerCurrencyList _currencyListField;

        private CustomerCreditCardsList _creditCardsListField;

        private CustomerPartnersList _partnersListField;

        private CustomerGroupPricingList _groupPricingListField;

        private CustomerItemPricingList _itemPricingListField;

        private CustomerTaxRegistrationList _taxRegistrationListField;

        private RecordRef _defaultAllocationStrategyField;

        private CustomFieldRef[] _customFieldListField;

        private string _internalIdField;

        private string _externalIdField;
        
        public string ShipAddressee { get; set; }
        public string ShipAddr1 { get; set; }
        public string ShipAddr2 { get; set; }
        public string ShipAddr3 { get; set; }       
        public string ShipCity { get; set; }
        public string ShipState { get; set; }
        public string ShipZip { get; set; }
        public string ShipCountry { get; set; }
        public string BillAddressee { get; set; }
        public string BillAddr1 { get; set; }
        public string BillAddr2 { get; set; }
        public string BillAddr3 { get; set; }
        public string BillCity { get; set; }
        public string BillState { get; set; }
        public string BillZip { get; set; }
        public string BillCountry { get; set; }

        /// <remarks/>
        public RecordRef CustomForm {
            get => _customFormField;
            set => _customFormField = value;
        }

        /// <remarks/>
        public string EntityId {
            get => _entityIdField;
            set => _entityIdField = value;
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
        public RecordRef EntityStatus {
            get => _entityStatusField;
            set => _entityStatusField = value;
        }

        /// <remarks/>
        public RecordRef Parent {
            get => _parentField;
            set => _parentField = value;
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
        public string Language {
            get => _languageField;
            set => _languageField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool LanguageSpecified {
            get => _languageFieldSpecified;
            set => _languageFieldSpecified = value;
        }

        /// <remarks/>
        public string Comments {
            get => _commentsField;
            set => _commentsField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool NumberFormatSpecified {
            get => _numberFormatFieldSpecified;
            set => _numberFormatFieldSpecified = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool NegativeNumberFormatSpecified {
            get => _negativeNumberFormatFieldSpecified;
            set => _negativeNumberFormatFieldSpecified = value;
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
        public RecordRef SalesRep {
            get => _salesRepField;
            set => _salesRepField = value;
        }

        /// <remarks/>
        public RecordRef Territory {
            get => _territoryField;
            set => _territoryField = value;
        }

        /// <remarks/>
        public string ContribPct {
            get => _contribPctField;
            set => _contribPctField = value;
        }

        /// <remarks/>
        public RecordRef Partner {
            get => _partnerField;
            set => _partnerField = value;
        }

        /// <remarks/>
        public RecordRef SalesGroup {
            get => _salesGroupField;
            set => _salesGroupField = value;
        }

        /// <remarks/>
        public string VatRegNumber {
            get => _vatRegNumberField;
            set => _vatRegNumberField = value;
        }

        /// <remarks/>
        public string AccountNumber {
            get => _accountNumberField;
            set => _accountNumberField = value;
        }

        /// <remarks/>
        public bool TaxExempt {
            get => _taxExemptField;
            set => _taxExemptField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TaxExemptSpecified {
            get => _taxExemptFieldSpecified;
            set => _taxExemptFieldSpecified = value;
        }

        /// <remarks/>
        public RecordRef Terms {
            get => _termsField;
            set => _termsField = value;
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
        public CustomerCreditHoldOverride CreditHoldOverride {
            get => _creditHoldOverrideField;
            set => _creditHoldOverrideField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool CreditHoldOverrideSpecified {
            get => _creditHoldOverrideFieldSpecified;
            set => _creditHoldOverrideFieldSpecified = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool MonthlyClosingSpecified {
            get => _monthlyClosingFieldSpecified;
            set => _monthlyClosingFieldSpecified = value;
        }

        /// <remarks/>
        public bool OverrideCurrencyFormat {
            get => _overrideCurrencyFormatField;
            set => _overrideCurrencyFormatField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool OverrideCurrencyFormatSpecified {
            get => _overrideCurrencyFormatFieldSpecified;
            set => _overrideCurrencyFormatFieldSpecified = value;
        }

        /// <remarks/>
        public string DisplaySymbol {
            get => _displaySymbolField;
            set => _displaySymbolField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool SymbolPlacementSpecified {
            get => _symbolPlacementFieldSpecified;
            set => _symbolPlacementFieldSpecified = value;
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
        public double OverdueBalance {
            get => _overdueBalanceField;
            set => _overdueBalanceField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool OverdueBalanceSpecified {
            get => _overdueBalanceFieldSpecified;
            set => _overdueBalanceFieldSpecified = value;
        }

        /// <remarks/>
        public long DaysOverdue {
            get => _daysOverdueField;
            set => _daysOverdueField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool DaysOverdueSpecified {
            get => _daysOverdueFieldSpecified;
            set => _daysOverdueFieldSpecified = value;
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
        public double ConsolUnbilledOrders {
            get => _consolUnbilledOrdersField;
            set => _consolUnbilledOrdersField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool ConsolUnbilledOrdersSpecified {
            get => _consolUnbilledOrdersFieldSpecified;
            set => _consolUnbilledOrdersFieldSpecified = value;
        }

        /// <remarks/>
        public double ConsolOverdueBalance {
            get => _consolOverdueBalanceField;
            set => _consolOverdueBalanceField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool ConsolOverdueBalanceSpecified {
            get => _consolOverdueBalanceFieldSpecified;
            set => _consolOverdueBalanceFieldSpecified = value;
        }

        /// <remarks/>
        public double ConsolDepositBalance {
            get => _consolDepositBalanceField;
            set => _consolDepositBalanceField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool ConsolDepositBalanceSpecified {
            get => _consolDepositBalanceFieldSpecified;
            set => _consolDepositBalanceFieldSpecified = value;
        }

        /// <remarks/>
        public double ConsolBalance {
            get => _consolBalanceField;
            set => _consolBalanceField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool ConsolBalanceSpecified {
            get => _consolBalanceFieldSpecified;
            set => _consolBalanceFieldSpecified = value;
        }

        /// <remarks/>
        public double ConsolAging {
            get => _consolAgingField;
            set => _consolAgingField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool ConsolAgingSpecified {
            get => _consolAgingFieldSpecified;
            set => _consolAgingFieldSpecified = value;
        }

        /// <remarks/>
        public double ConsolAging1 {
            get => _consolAging1Field;
            set => _consolAging1Field = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool ConsolAging1Specified {
            get => _consolAging1FieldSpecified;
            set => _consolAging1FieldSpecified = value;
        }

        /// <remarks/>
        public double ConsolAging2 {
            get => _consolAging2Field;
            set => _consolAging2Field = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool ConsolAging2Specified {
            get => _consolAging2FieldSpecified;
            set => _consolAging2FieldSpecified = value;
        }

        /// <remarks/>
        public double ConsolAging3 {
            get => _consolAging3Field;
            set => _consolAging3Field = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool ConsolAging3Specified {
            get => _consolAging3FieldSpecified;
            set => _consolAging3FieldSpecified = value;
        }

        /// <remarks/>
        public double ConsolAging4 {
            get => _consolAging4Field;
            set => _consolAging4Field = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool ConsolAging4Specified {
            get => _consolAging4FieldSpecified;
            set => _consolAging4FieldSpecified = value;
        }

        /// <remarks/>
        public long ConsolDaysOverdue {
            get => _consolDaysOverdueField;
            set => _consolDaysOverdueField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool ConsolDaysOverdueSpecified {
            get => _consolDaysOverdueFieldSpecified;
            set => _consolDaysOverdueFieldSpecified = value;
        }

        /// <remarks/>
        public RecordRef PriceLevel {
            get => _priceLevelField;
            set => _priceLevelField = value;
        }

        /// <remarks/>
        public RecordRef PrefCcProcessor {
            get => _prefCcProcessorField;
            set => _prefCcProcessorField = value;
        }

        /// <remarks/>
        public double DepositBalance {
            get => _depositBalanceField;
            set => _depositBalanceField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool DepositBalanceSpecified {
            get => _depositBalanceFieldSpecified;
            set => _depositBalanceFieldSpecified = value;
        }

        /// <remarks/>
        public bool ShipComplete {
            get => _shipCompleteField;
            set => _shipCompleteField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool ShipCompleteSpecified {
            get => _shipCompleteFieldSpecified;
            set => _shipCompleteFieldSpecified = value;
        }

        /// <remarks/>
        public bool Taxable {
            get => _taxableField;
            set => _taxableField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TaxableSpecified {
            get => _taxableFieldSpecified;
            set => _taxableFieldSpecified = value;
        }

        /// <remarks/>
        public RecordRef TaxItem {
            get => _taxItemField;
            set => _taxItemField = value;
        }

        /// <remarks/>
        public string ResaleNumber {
            get => _resaleNumberField;
            set => _resaleNumberField = value;
        }

        /// <remarks/>
        public double Aging {
            get => _agingField;
            set => _agingField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool AgingSpecified {
            get => _agingFieldSpecified;
            set => _agingFieldSpecified = value;
        }

        /// <remarks/>
        public double Aging1 {
            get => _aging1Field;
            set => _aging1Field = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool Aging1Specified {
            get => _aging1FieldSpecified;
            set => _aging1FieldSpecified = value;
        }

        /// <remarks/>
        public double Aging2 {
            get => _aging2Field;
            set => _aging2Field = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool Aging2Specified {
            get => _aging2FieldSpecified;
            set => _aging2FieldSpecified = value;
        }

        /// <remarks/>
        public double Aging3 {
            get => _aging3Field;
            set => _aging3Field = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool Aging3Specified {
            get => _aging3FieldSpecified;
            set => _aging3FieldSpecified = value;
        }

        /// <remarks/>
        public double Aging4 {
            get => _aging4Field;
            set => _aging4Field = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool Aging4Specified {
            get => _aging4FieldSpecified;
            set => _aging4FieldSpecified = value;
        }

        /// <remarks/>
        public DateTime StartDate {
            get => _startDateField;
            set => _startDateField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool StartDateSpecified {
            get => _startDateFieldSpecified;
            set => _startDateFieldSpecified = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool AlcoholRecipientTypeSpecified {
            get => _alcoholRecipientTypeFieldSpecified;
            set => _alcoholRecipientTypeFieldSpecified = value;
        }

        /// <remarks/>
        public DateTime EndDate {
            get => _endDateField;
            set => _endDateField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool EndDateSpecified {
            get => _endDateFieldSpecified;
            set => _endDateFieldSpecified = value;
        }

        /// <remarks/>
        public long ReminderDays {
            get => _reminderDaysField;
            set => _reminderDaysField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool ReminderDaysSpecified {
            get => _reminderDaysFieldSpecified;
            set => _reminderDaysFieldSpecified = value;
        }

        /// <remarks/>
        public RecordRef ShippingItem {
            get => _shippingItemField;
            set => _shippingItemField = value;
        }

        /// <remarks/>
        public string ThirdPartyAcct {
            get => _thirdPartyAcctField;
            set => _thirdPartyAcctField = value;
        }

        /// <remarks/>
        public string ThirdPartyZipcode {
            get => _thirdPartyZipcodeField;
            set => _thirdPartyZipcodeField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool ThirdPartyCountrySpecified {
            get => _thirdPartyCountryFieldSpecified;
            set => _thirdPartyCountryFieldSpecified = value;
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
        public double EstimatedBudget {
            get => _estimatedBudgetField;
            set => _estimatedBudgetField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool EstimatedBudgetSpecified {
            get => _estimatedBudgetFieldSpecified;
            set => _estimatedBudgetFieldSpecified = value;
        }

        /// <remarks/>
        public RecordRef AccessRole {
            get => _accessRoleField;
            set => _accessRoleField = value;
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
        public RecordRef AssignedWebSite {
            get => _assignedWebSiteField;
            set => _assignedWebSiteField = value;
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
        public RecordRef CampaignCategory {
            get => _campaignCategoryField;
            set => _campaignCategoryField = value;
        }

        /// <remarks/>
        public RecordRef SourceWebSite {
            get => _sourceWebSiteField;
            set => _sourceWebSiteField = value;
        }

        /// <remarks/>
        public RecordRef LeadSource {
            get => _leadSourceField;
            set => _leadSourceField = value;
        }

        /// <remarks/>
        public RecordRef ReceivablesAccount {
            get => _receivablesAccountField;
            set => _receivablesAccountField = value;
        }

        /// <remarks/>
        public RecordRef DrAccount {
            get => _drAccountField;
            set => _drAccountField = value;
        }

        /// <remarks/>
        public RecordRef FxAccount {
            get => _fxAccountField;
            set => _fxAccountField = value;
        }

        /// <remarks/>
        public double DefaultOrderPriority {
            get => _defaultOrderPriorityField;
            set => _defaultOrderPriorityField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool DefaultOrderPrioritySpecified {
            get => _defaultOrderPriorityFieldSpecified;
            set => _defaultOrderPriorityFieldSpecified = value;
        }

        /// <remarks/>
        public string WebLead {
            get => _webLeadField;
            set => _webLeadField = value;
        }

        /// <remarks/>
        public string Referrer {
            get => _referrerField;
            set => _referrerField = value;
        }

        /// <remarks/>
        public string Keywords {
            get => _keywordsField;
            set => _keywordsField = value;
        }

        /// <remarks/>
        public string ClickStream {
            get => _clickStreamField;
            set => _clickStreamField = value;
        }

        /// <remarks/>
        public string LastPageVisited {
            get => _lastPageVisitedField;
            set => _lastPageVisitedField = value;
        }

        /// <remarks/>
        public long Visits {
            get => _visitsField;
            set => _visitsField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool VisitsSpecified {
            get => _visitsFieldSpecified;
            set => _visitsFieldSpecified = value;
        }

        /// <remarks/>
        public DateTime FirstVisit {
            get => _firstVisitField;
            set => _firstVisitField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool FirstVisitSpecified {
            get => _firstVisitFieldSpecified;
            set => _firstVisitFieldSpecified = value;
        }

        /// <remarks/>
        public DateTime LastVisit {
            get => _lastVisitField;
            set => _lastVisitField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool LastVisitSpecified {
            get => _lastVisitFieldSpecified;
            set => _lastVisitFieldSpecified = value;
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
        public CustomerStage Stage {
            get => _stageField;
            set => _stageField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool StageSpecified {
            get => _stageFieldSpecified;
            set => _stageFieldSpecified = value;
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
        public bool SyncPartnerTeams {
            get => _syncPartnerTeamsField;
            set => _syncPartnerTeamsField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool SyncPartnerTeamsSpecified {
            get => _syncPartnerTeamsFieldSpecified;
            set => _syncPartnerTeamsFieldSpecified = value;
        }

        /// <remarks/>
        public bool IsBudgetApproved {
            get => _isBudgetApprovedField;
            set => _isBudgetApprovedField = value;
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool IsBudgetApprovedSpecified {
            get => _isBudgetApprovedFieldSpecified;
            set => _isBudgetApprovedFieldSpecified = value;
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
        public RecordRef SalesReadiness {
            get => _salesReadinessField;
            set => _salesReadinessField = value;
        }

        /// <remarks/>
        public CustomerSalesTeamList SalesTeamList {
            get => _salesTeamListField;
            set => _salesTeamListField = value;
        }

        /// <remarks/>
        public RecordRef BuyingReason {
            get => _buyingReasonField;
            set => _buyingReasonField = value;
        }

        /// <remarks/>
        public CustomerDownloadList DownloadList {
            get => _downloadListField;
            set => _downloadListField = value;
        }

        /// <remarks/>
        public RecordRef BuyingTimeFrame {
            get => _buyingTimeFrameField;
            set => _buyingTimeFrameField = value;
        }

        /// <remarks/>
        public CustomerAddressbookList AddressbookList {
            get => _addressbookListField;
            set => _addressbookListField = value;
        }

        /// <remarks/>
        public SubscriptionsList SubscriptionsList {
            get => _subscriptionsListField;
            set => _subscriptionsListField = value;
        }

        /// <remarks/>
        public ContactAccessRolesList ContactRolesList {
            get => _contactRolesListField;
            set => _contactRolesListField = value;
        }

        /// <remarks/>
        public CustomerCurrencyList CurrencyList {
            get => _currencyListField;
            set => _currencyListField = value;
        }

        /// <remarks/>
        public CustomerCreditCardsList CreditCardsList {
            get => _creditCardsListField;
            set => _creditCardsListField = value;
        }

        /// <remarks/>
        public CustomerPartnersList PartnersList {
            get => _partnersListField;
            set => _partnersListField = value;
        }

        /// <remarks/>
        public CustomerGroupPricingList GroupPricingList {
            get => _groupPricingListField;
            set => _groupPricingListField = value;
        }

        /// <remarks/>
        public CustomerItemPricingList ItemPricingList {
            get => _itemPricingListField;
            set => _itemPricingListField = value;
        }

        /// <remarks/>
        public CustomerTaxRegistrationList TaxRegistrationList {
            get => _taxRegistrationListField;
            set => _taxRegistrationListField = value;
        }

        /// <remarks/>
        public RecordRef DefaultAllocationStrategy {
            get => _defaultAllocationStrategyField;
            set => _defaultAllocationStrategyField = value;
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