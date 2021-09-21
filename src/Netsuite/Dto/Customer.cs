using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:relationships_2021_1.lists.webservices.netsuite.com")]
    public partial class Customer : Record {

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

        private RecordRef entityStatusField;

        private RecordRef parentField;

        private string phoneField;

        private string faxField;

        private string emailField;

        private string urlField;

        private string defaultAddressField;

        private bool isInactiveField;

        private bool isInactiveFieldSpecified;

        private RecordRef categoryField;

        private string titleField;

        private string printOnCheckAsField;

        private string altPhoneField;

        private string homePhoneField;

        private string mobilePhoneField;

        private string altEmailField;

        private Language languageField;

        private bool languageFieldSpecified;

        private string commentsField;

        private CustomerNumberFormat numberFormatField;

        private bool numberFormatFieldSpecified;

        private CustomerNegativeNumberFormat negativeNumberFormatField;

        private bool negativeNumberFormatFieldSpecified;

        private System.DateTime dateCreatedField;

        private bool dateCreatedFieldSpecified;

        private RecordRef imageField;

        private EmailPreference emailPreferenceField;

        private bool emailPreferenceFieldSpecified;

        private RecordRef subsidiaryField;

        private RecordRef representingSubsidiaryField;

        private RecordRef salesRepField;

        private RecordRef territoryField;

        private string contribPctField;

        private RecordRef partnerField;

        private RecordRef salesGroupField;

        private string vatRegNumberField;

        private string accountNumberField;

        private bool taxExemptField;

        private bool taxExemptFieldSpecified;

        private RecordRef termsField;

        private double creditLimitField;

        private bool creditLimitFieldSpecified;

        private CustomerCreditHoldOverride creditHoldOverrideField;

        private bool creditHoldOverrideFieldSpecified;

        private CustomerMonthlyClosing monthlyClosingField;

        private bool monthlyClosingFieldSpecified;

        private bool overrideCurrencyFormatField;

        private bool overrideCurrencyFormatFieldSpecified;

        private string displaySymbolField;

        private CurrencySymbolPlacement symbolPlacementField;

        private bool symbolPlacementFieldSpecified;

        private double balanceField;

        private bool balanceFieldSpecified;

        private double overdueBalanceField;

        private bool overdueBalanceFieldSpecified;

        private long daysOverdueField;

        private bool daysOverdueFieldSpecified;

        private double unbilledOrdersField;

        private bool unbilledOrdersFieldSpecified;

        private double consolUnbilledOrdersField;

        private bool consolUnbilledOrdersFieldSpecified;

        private double consolOverdueBalanceField;

        private bool consolOverdueBalanceFieldSpecified;

        private double consolDepositBalanceField;

        private bool consolDepositBalanceFieldSpecified;

        private double consolBalanceField;

        private bool consolBalanceFieldSpecified;

        private double consolAgingField;

        private bool consolAgingFieldSpecified;

        private double consolAging1Field;

        private bool consolAging1FieldSpecified;

        private double consolAging2Field;

        private bool consolAging2FieldSpecified;

        private double consolAging3Field;

        private bool consolAging3FieldSpecified;

        private double consolAging4Field;

        private bool consolAging4FieldSpecified;

        private long consolDaysOverdueField;

        private bool consolDaysOverdueFieldSpecified;

        private RecordRef priceLevelField;

        private RecordRef currencyField;

        private RecordRef prefCCProcessorField;

        private double depositBalanceField;

        private bool depositBalanceFieldSpecified;

        private bool shipCompleteField;

        private bool shipCompleteFieldSpecified;

        private bool taxableField;

        private bool taxableFieldSpecified;

        private RecordRef taxItemField;

        private string resaleNumberField;

        private double agingField;

        private bool agingFieldSpecified;

        private double aging1Field;

        private bool aging1FieldSpecified;

        private double aging2Field;

        private bool aging2FieldSpecified;

        private double aging3Field;

        private bool aging3FieldSpecified;

        private double aging4Field;

        private bool aging4FieldSpecified;

        private System.DateTime startDateField;

        private bool startDateFieldSpecified;

        private AlcoholRecipientType alcoholRecipientTypeField;

        private bool alcoholRecipientTypeFieldSpecified;

        private System.DateTime endDateField;

        private bool endDateFieldSpecified;

        private long reminderDaysField;

        private bool reminderDaysFieldSpecified;

        private RecordRef shippingItemField;

        private string thirdPartyAcctField;

        private string thirdPartyZipcodeField;

        private Country thirdPartyCountryField;

        private bool thirdPartyCountryFieldSpecified;

        private bool giveAccessField;

        private bool giveAccessFieldSpecified;

        private double estimatedBudgetField;

        private bool estimatedBudgetFieldSpecified;

        private RecordRef accessRoleField;

        private bool sendEmailField;

        private bool sendEmailFieldSpecified;

        private RecordRef assignedWebSiteField;

        private string passwordField;

        private string password2Field;

        private bool requirePwdChangeField;

        private bool requirePwdChangeFieldSpecified;

        private RecordRef campaignCategoryField;

        private RecordRef sourceWebSiteField;

        private RecordRef leadSourceField;

        private RecordRef receivablesAccountField;

        private RecordRef drAccountField;

        private RecordRef fxAccountField;

        private double defaultOrderPriorityField;

        private bool defaultOrderPriorityFieldSpecified;

        private string webLeadField;

        private string referrerField;

        private string keywordsField;

        private string clickStreamField;

        private string lastPageVisitedField;

        private long visitsField;

        private bool visitsFieldSpecified;

        private System.DateTime firstVisitField;

        private bool firstVisitFieldSpecified;

        private System.DateTime lastVisitField;

        private bool lastVisitFieldSpecified;

        private bool billPayField;

        private bool billPayFieldSpecified;

        private double openingBalanceField;

        private bool openingBalanceFieldSpecified;

        private System.DateTime lastModifiedDateField;

        private bool lastModifiedDateFieldSpecified;

        private System.DateTime openingBalanceDateField;

        private bool openingBalanceDateFieldSpecified;

        private RecordRef openingBalanceAccountField;

        private CustomerStage stageField;

        private bool stageFieldSpecified;

        private bool emailTransactionsField;

        private bool emailTransactionsFieldSpecified;

        private bool printTransactionsField;

        private bool printTransactionsFieldSpecified;

        private bool faxTransactionsField;

        private bool faxTransactionsFieldSpecified;

        private RecordRef defaultTaxRegField;

        private bool syncPartnerTeamsField;

        private bool syncPartnerTeamsFieldSpecified;

        private bool isBudgetApprovedField;

        private bool isBudgetApprovedFieldSpecified;

        private GlobalSubscriptionStatus globalSubscriptionStatusField;

        private bool globalSubscriptionStatusFieldSpecified;

        private RecordRef salesReadinessField;

        private CustomerSalesTeamList salesTeamListField;

        private RecordRef buyingReasonField;

        private CustomerDownloadList downloadListField;

        private RecordRef buyingTimeFrameField;

        private CustomerAddressbookList addressbookListField;

        private SubscriptionsList subscriptionsListField;

        private ContactAccessRolesList contactRolesListField;

        private CustomerCurrencyList currencyListField;

        private CustomerCreditCardsList creditCardsListField;

        private CustomerPartnersList partnersListField;

        private CustomerGroupPricingList groupPricingListField;

        private CustomerItemPricingList itemPricingListField;

        private CustomerTaxRegistrationList taxRegistrationListField;

        private RecordRef defaultAllocationStrategyField;

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
        public RecordRef entityStatus {
            get {
                return this.entityStatusField;
            }
            set {
                this.entityStatusField = value;
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
        public Language language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool languageSpecified {
            get {
                return this.languageFieldSpecified;
            }
            set {
                this.languageFieldSpecified = value;
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
        public CustomerNumberFormat numberFormat {
            get {
                return this.numberFormatField;
            }
            set {
                this.numberFormatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numberFormatSpecified {
            get {
                return this.numberFormatFieldSpecified;
            }
            set {
                this.numberFormatFieldSpecified = value;
            }
        }

        /// <remarks/>
        public CustomerNegativeNumberFormat negativeNumberFormat {
            get {
                return this.negativeNumberFormatField;
            }
            set {
                this.negativeNumberFormatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool negativeNumberFormatSpecified {
            get {
                return this.negativeNumberFormatFieldSpecified;
            }
            set {
                this.negativeNumberFormatFieldSpecified = value;
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
        public RecordRef salesRep {
            get {
                return this.salesRepField;
            }
            set {
                this.salesRepField = value;
            }
        }

        /// <remarks/>
        public RecordRef territory {
            get {
                return this.territoryField;
            }
            set {
                this.territoryField = value;
            }
        }

        /// <remarks/>
        public string contribPct {
            get {
                return this.contribPctField;
            }
            set {
                this.contribPctField = value;
            }
        }

        /// <remarks/>
        public RecordRef partner {
            get {
                return this.partnerField;
            }
            set {
                this.partnerField = value;
            }
        }

        /// <remarks/>
        public RecordRef salesGroup {
            get {
                return this.salesGroupField;
            }
            set {
                this.salesGroupField = value;
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
        public string accountNumber {
            get {
                return this.accountNumberField;
            }
            set {
                this.accountNumberField = value;
            }
        }

        /// <remarks/>
        public bool taxExempt {
            get {
                return this.taxExemptField;
            }
            set {
                this.taxExemptField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxExemptSpecified {
            get {
                return this.taxExemptFieldSpecified;
            }
            set {
                this.taxExemptFieldSpecified = value;
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
        public CustomerCreditHoldOverride creditHoldOverride {
            get {
                return this.creditHoldOverrideField;
            }
            set {
                this.creditHoldOverrideField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool creditHoldOverrideSpecified {
            get {
                return this.creditHoldOverrideFieldSpecified;
            }
            set {
                this.creditHoldOverrideFieldSpecified = value;
            }
        }

        /// <remarks/>
        public CustomerMonthlyClosing monthlyClosing {
            get {
                return this.monthlyClosingField;
            }
            set {
                this.monthlyClosingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool monthlyClosingSpecified {
            get {
                return this.monthlyClosingFieldSpecified;
            }
            set {
                this.monthlyClosingFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool overrideCurrencyFormat {
            get {
                return this.overrideCurrencyFormatField;
            }
            set {
                this.overrideCurrencyFormatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool overrideCurrencyFormatSpecified {
            get {
                return this.overrideCurrencyFormatFieldSpecified;
            }
            set {
                this.overrideCurrencyFormatFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string displaySymbol {
            get {
                return this.displaySymbolField;
            }
            set {
                this.displaySymbolField = value;
            }
        }

        /// <remarks/>
        public CurrencySymbolPlacement symbolPlacement {
            get {
                return this.symbolPlacementField;
            }
            set {
                this.symbolPlacementField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool symbolPlacementSpecified {
            get {
                return this.symbolPlacementFieldSpecified;
            }
            set {
                this.symbolPlacementFieldSpecified = value;
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
        public double overdueBalance {
            get {
                return this.overdueBalanceField;
            }
            set {
                this.overdueBalanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool overdueBalanceSpecified {
            get {
                return this.overdueBalanceFieldSpecified;
            }
            set {
                this.overdueBalanceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long daysOverdue {
            get {
                return this.daysOverdueField;
            }
            set {
                this.daysOverdueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool daysOverdueSpecified {
            get {
                return this.daysOverdueFieldSpecified;
            }
            set {
                this.daysOverdueFieldSpecified = value;
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
        public double consolUnbilledOrders {
            get {
                return this.consolUnbilledOrdersField;
            }
            set {
                this.consolUnbilledOrdersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool consolUnbilledOrdersSpecified {
            get {
                return this.consolUnbilledOrdersFieldSpecified;
            }
            set {
                this.consolUnbilledOrdersFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double consolOverdueBalance {
            get {
                return this.consolOverdueBalanceField;
            }
            set {
                this.consolOverdueBalanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool consolOverdueBalanceSpecified {
            get {
                return this.consolOverdueBalanceFieldSpecified;
            }
            set {
                this.consolOverdueBalanceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double consolDepositBalance {
            get {
                return this.consolDepositBalanceField;
            }
            set {
                this.consolDepositBalanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool consolDepositBalanceSpecified {
            get {
                return this.consolDepositBalanceFieldSpecified;
            }
            set {
                this.consolDepositBalanceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double consolBalance {
            get {
                return this.consolBalanceField;
            }
            set {
                this.consolBalanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool consolBalanceSpecified {
            get {
                return this.consolBalanceFieldSpecified;
            }
            set {
                this.consolBalanceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double consolAging {
            get {
                return this.consolAgingField;
            }
            set {
                this.consolAgingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool consolAgingSpecified {
            get {
                return this.consolAgingFieldSpecified;
            }
            set {
                this.consolAgingFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double consolAging1 {
            get {
                return this.consolAging1Field;
            }
            set {
                this.consolAging1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool consolAging1Specified {
            get {
                return this.consolAging1FieldSpecified;
            }
            set {
                this.consolAging1FieldSpecified = value;
            }
        }

        /// <remarks/>
        public double consolAging2 {
            get {
                return this.consolAging2Field;
            }
            set {
                this.consolAging2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool consolAging2Specified {
            get {
                return this.consolAging2FieldSpecified;
            }
            set {
                this.consolAging2FieldSpecified = value;
            }
        }

        /// <remarks/>
        public double consolAging3 {
            get {
                return this.consolAging3Field;
            }
            set {
                this.consolAging3Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool consolAging3Specified {
            get {
                return this.consolAging3FieldSpecified;
            }
            set {
                this.consolAging3FieldSpecified = value;
            }
        }

        /// <remarks/>
        public double consolAging4 {
            get {
                return this.consolAging4Field;
            }
            set {
                this.consolAging4Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool consolAging4Specified {
            get {
                return this.consolAging4FieldSpecified;
            }
            set {
                this.consolAging4FieldSpecified = value;
            }
        }

        /// <remarks/>
        public long consolDaysOverdue {
            get {
                return this.consolDaysOverdueField;
            }
            set {
                this.consolDaysOverdueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool consolDaysOverdueSpecified {
            get {
                return this.consolDaysOverdueFieldSpecified;
            }
            set {
                this.consolDaysOverdueFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef priceLevel {
            get {
                return this.priceLevelField;
            }
            set {
                this.priceLevelField = value;
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
        public RecordRef prefCCProcessor {
            get {
                return this.prefCCProcessorField;
            }
            set {
                this.prefCCProcessorField = value;
            }
        }

        /// <remarks/>
        public double depositBalance {
            get {
                return this.depositBalanceField;
            }
            set {
                this.depositBalanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool depositBalanceSpecified {
            get {
                return this.depositBalanceFieldSpecified;
            }
            set {
                this.depositBalanceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool shipComplete {
            get {
                return this.shipCompleteField;
            }
            set {
                this.shipCompleteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shipCompleteSpecified {
            get {
                return this.shipCompleteFieldSpecified;
            }
            set {
                this.shipCompleteFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool taxable {
            get {
                return this.taxableField;
            }
            set {
                this.taxableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxableSpecified {
            get {
                return this.taxableFieldSpecified;
            }
            set {
                this.taxableFieldSpecified = value;
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
        public string resaleNumber {
            get {
                return this.resaleNumberField;
            }
            set {
                this.resaleNumberField = value;
            }
        }

        /// <remarks/>
        public double aging {
            get {
                return this.agingField;
            }
            set {
                this.agingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool agingSpecified {
            get {
                return this.agingFieldSpecified;
            }
            set {
                this.agingFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double aging1 {
            get {
                return this.aging1Field;
            }
            set {
                this.aging1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool aging1Specified {
            get {
                return this.aging1FieldSpecified;
            }
            set {
                this.aging1FieldSpecified = value;
            }
        }

        /// <remarks/>
        public double aging2 {
            get {
                return this.aging2Field;
            }
            set {
                this.aging2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool aging2Specified {
            get {
                return this.aging2FieldSpecified;
            }
            set {
                this.aging2FieldSpecified = value;
            }
        }

        /// <remarks/>
        public double aging3 {
            get {
                return this.aging3Field;
            }
            set {
                this.aging3Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool aging3Specified {
            get {
                return this.aging3FieldSpecified;
            }
            set {
                this.aging3FieldSpecified = value;
            }
        }

        /// <remarks/>
        public double aging4 {
            get {
                return this.aging4Field;
            }
            set {
                this.aging4Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool aging4Specified {
            get {
                return this.aging4FieldSpecified;
            }
            set {
                this.aging4FieldSpecified = value;
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
        public AlcoholRecipientType alcoholRecipientType {
            get {
                return this.alcoholRecipientTypeField;
            }
            set {
                this.alcoholRecipientTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool alcoholRecipientTypeSpecified {
            get {
                return this.alcoholRecipientTypeFieldSpecified;
            }
            set {
                this.alcoholRecipientTypeFieldSpecified = value;
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
        public long reminderDays {
            get {
                return this.reminderDaysField;
            }
            set {
                this.reminderDaysField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool reminderDaysSpecified {
            get {
                return this.reminderDaysFieldSpecified;
            }
            set {
                this.reminderDaysFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef shippingItem {
            get {
                return this.shippingItemField;
            }
            set {
                this.shippingItemField = value;
            }
        }

        /// <remarks/>
        public string thirdPartyAcct {
            get {
                return this.thirdPartyAcctField;
            }
            set {
                this.thirdPartyAcctField = value;
            }
        }

        /// <remarks/>
        public string thirdPartyZipcode {
            get {
                return this.thirdPartyZipcodeField;
            }
            set {
                this.thirdPartyZipcodeField = value;
            }
        }

        /// <remarks/>
        public Country thirdPartyCountry {
            get {
                return this.thirdPartyCountryField;
            }
            set {
                this.thirdPartyCountryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool thirdPartyCountrySpecified {
            get {
                return this.thirdPartyCountryFieldSpecified;
            }
            set {
                this.thirdPartyCountryFieldSpecified = value;
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
        public double estimatedBudget {
            get {
                return this.estimatedBudgetField;
            }
            set {
                this.estimatedBudgetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool estimatedBudgetSpecified {
            get {
                return this.estimatedBudgetFieldSpecified;
            }
            set {
                this.estimatedBudgetFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef accessRole {
            get {
                return this.accessRoleField;
            }
            set {
                this.accessRoleField = value;
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
        public RecordRef assignedWebSite {
            get {
                return this.assignedWebSiteField;
            }
            set {
                this.assignedWebSiteField = value;
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
        public RecordRef campaignCategory {
            get {
                return this.campaignCategoryField;
            }
            set {
                this.campaignCategoryField = value;
            }
        }

        /// <remarks/>
        public RecordRef sourceWebSite {
            get {
                return this.sourceWebSiteField;
            }
            set {
                this.sourceWebSiteField = value;
            }
        }

        /// <remarks/>
        public RecordRef leadSource {
            get {
                return this.leadSourceField;
            }
            set {
                this.leadSourceField = value;
            }
        }

        /// <remarks/>
        public RecordRef receivablesAccount {
            get {
                return this.receivablesAccountField;
            }
            set {
                this.receivablesAccountField = value;
            }
        }

        /// <remarks/>
        public RecordRef drAccount {
            get {
                return this.drAccountField;
            }
            set {
                this.drAccountField = value;
            }
        }

        /// <remarks/>
        public RecordRef fxAccount {
            get {
                return this.fxAccountField;
            }
            set {
                this.fxAccountField = value;
            }
        }

        /// <remarks/>
        public double defaultOrderPriority {
            get {
                return this.defaultOrderPriorityField;
            }
            set {
                this.defaultOrderPriorityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultOrderPrioritySpecified {
            get {
                return this.defaultOrderPriorityFieldSpecified;
            }
            set {
                this.defaultOrderPriorityFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string webLead {
            get {
                return this.webLeadField;
            }
            set {
                this.webLeadField = value;
            }
        }

        /// <remarks/>
        public string referrer {
            get {
                return this.referrerField;
            }
            set {
                this.referrerField = value;
            }
        }

        /// <remarks/>
        public string keywords {
            get {
                return this.keywordsField;
            }
            set {
                this.keywordsField = value;
            }
        }

        /// <remarks/>
        public string clickStream {
            get {
                return this.clickStreamField;
            }
            set {
                this.clickStreamField = value;
            }
        }

        /// <remarks/>
        public string lastPageVisited {
            get {
                return this.lastPageVisitedField;
            }
            set {
                this.lastPageVisitedField = value;
            }
        }

        /// <remarks/>
        public long visits {
            get {
                return this.visitsField;
            }
            set {
                this.visitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool visitsSpecified {
            get {
                return this.visitsFieldSpecified;
            }
            set {
                this.visitsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime firstVisit {
            get {
                return this.firstVisitField;
            }
            set {
                this.firstVisitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool firstVisitSpecified {
            get {
                return this.firstVisitFieldSpecified;
            }
            set {
                this.firstVisitFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime lastVisit {
            get {
                return this.lastVisitField;
            }
            set {
                this.lastVisitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lastVisitSpecified {
            get {
                return this.lastVisitFieldSpecified;
            }
            set {
                this.lastVisitFieldSpecified = value;
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
        public CustomerStage stage {
            get {
                return this.stageField;
            }
            set {
                this.stageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool stageSpecified {
            get {
                return this.stageFieldSpecified;
            }
            set {
                this.stageFieldSpecified = value;
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
        public bool syncPartnerTeams {
            get {
                return this.syncPartnerTeamsField;
            }
            set {
                this.syncPartnerTeamsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool syncPartnerTeamsSpecified {
            get {
                return this.syncPartnerTeamsFieldSpecified;
            }
            set {
                this.syncPartnerTeamsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isBudgetApproved {
            get {
                return this.isBudgetApprovedField;
            }
            set {
                this.isBudgetApprovedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isBudgetApprovedSpecified {
            get {
                return this.isBudgetApprovedFieldSpecified;
            }
            set {
                this.isBudgetApprovedFieldSpecified = value;
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
        public RecordRef salesReadiness {
            get {
                return this.salesReadinessField;
            }
            set {
                this.salesReadinessField = value;
            }
        }

        /// <remarks/>
        public CustomerSalesTeamList salesTeamList {
            get {
                return this.salesTeamListField;
            }
            set {
                this.salesTeamListField = value;
            }
        }

        /// <remarks/>
        public RecordRef buyingReason {
            get {
                return this.buyingReasonField;
            }
            set {
                this.buyingReasonField = value;
            }
        }

        /// <remarks/>
        public CustomerDownloadList downloadList {
            get {
                return this.downloadListField;
            }
            set {
                this.downloadListField = value;
            }
        }

        /// <remarks/>
        public RecordRef buyingTimeFrame {
            get {
                return this.buyingTimeFrameField;
            }
            set {
                this.buyingTimeFrameField = value;
            }
        }

        /// <remarks/>
        public CustomerAddressbookList addressbookList {
            get {
                return this.addressbookListField;
            }
            set {
                this.addressbookListField = value;
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
        public ContactAccessRolesList contactRolesList {
            get {
                return this.contactRolesListField;
            }
            set {
                this.contactRolesListField = value;
            }
        }

        /// <remarks/>
        public CustomerCurrencyList currencyList {
            get {
                return this.currencyListField;
            }
            set {
                this.currencyListField = value;
            }
        }

        /// <remarks/>
        public CustomerCreditCardsList creditCardsList {
            get {
                return this.creditCardsListField;
            }
            set {
                this.creditCardsListField = value;
            }
        }

        /// <remarks/>
        public CustomerPartnersList partnersList {
            get {
                return this.partnersListField;
            }
            set {
                this.partnersListField = value;
            }
        }

        /// <remarks/>
        public CustomerGroupPricingList groupPricingList {
            get {
                return this.groupPricingListField;
            }
            set {
                this.groupPricingListField = value;
            }
        }

        /// <remarks/>
        public CustomerItemPricingList itemPricingList {
            get {
                return this.itemPricingListField;
            }
            set {
                this.itemPricingListField = value;
            }
        }

        /// <remarks/>
        public CustomerTaxRegistrationList taxRegistrationList {
            get {
                return this.taxRegistrationListField;
            }
            set {
                this.taxRegistrationListField = value;
            }
        }

        /// <remarks/>
        public RecordRef defaultAllocationStrategy {
            get {
                return this.defaultAllocationStrategyField;
            }
            set {
                this.defaultAllocationStrategyField = value;
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