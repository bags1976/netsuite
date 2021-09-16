namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class CustomerSearchRowBasic : SearchRowBasic {

        private SearchColumnStringField[] accountNumberField;

        private SearchColumnStringField[] addressField;

        private SearchColumnStringField[] address1Field;

        private SearchColumnStringField[] address2Field;

        private SearchColumnStringField[] address3Field;

        private SearchColumnStringField[] addresseeField;

        private SearchColumnStringField[] addressInternalIdField;

        private SearchColumnStringField[] addressLabelField;

        private SearchColumnStringField[] addressPhoneField;

        private SearchColumnStringField[] altContactField;

        private SearchColumnStringField[] altEmailField;

        private SearchColumnStringField[] altNameField;

        private SearchColumnStringField[] altPhoneField;

        private SearchColumnSelectField[] assignedSiteField;

        private SearchColumnLongField[] assignedSiteIdField;

        private SearchColumnStringField[] attentionField;

        private SearchColumnBooleanField[] availableOfflineField;

        private SearchColumnDoubleField[] balanceField;

        private SearchColumnStringField[] billAddressField;

        private SearchColumnStringField[] billAddress1Field;

        private SearchColumnStringField[] billAddress2Field;

        private SearchColumnStringField[] billAddress3Field;

        private SearchColumnStringField[] billAddresseeField;

        private SearchColumnStringField[] billAttentionField;

        private SearchColumnStringField[] billCityField;

        private SearchColumnEnumSelectField[] billCountryField;

        private SearchColumnStringField[] billCountryCodeField;

        private SearchColumnStringField[] billPhoneField;

        private SearchColumnStringField[] billStateField;

        private SearchColumnStringField[] billZipCodeField;

        private SearchColumnStringField[] buyingReasonField;

        private SearchColumnStringField[] buyingTimeFrameField;

        private SearchColumnSelectField[] categoryField;

        private SearchColumnStringField[] ccCustomerCodeField;

        private SearchColumnBooleanField[] ccDefaultField;

        private SearchColumnDateField[] ccExpDateField;

        private SearchColumnStringField[] ccHolderNameField;

        private SearchColumnStringField[] ccInternalIdField;

        private SearchColumnStringField[] ccNumberField;

        private SearchColumnSelectField[] ccStateField;

        private SearchColumnDateField[] ccStateFromField;

        private SearchColumnSelectField[] ccTypeField;

        private SearchColumnStringField[] cityField;

        private SearchColumnStringField[] commentsField;

        private SearchColumnStringField[] companyNameField;

        private SearchColumnDoubleField[] consolBalanceField;

        private SearchColumnLongField[] consolDaysOverdueField;

        private SearchColumnDoubleField[] consolDepositBalanceField;

        private SearchColumnDoubleField[] consolOverdueBalanceField;

        private SearchColumnDoubleField[] consolUnbilledOrdersField;

        private SearchColumnStringField[] contactField;

        private SearchColumnDoubleField[] contributionField;

        private SearchColumnDoubleField[] contributionPrimaryField;

        private SearchColumnDateField[] conversionDateField;

        private SearchColumnEnumSelectField[] countryField;

        private SearchColumnStringField[] countryCodeField;

        private SearchColumnEnumSelectField[] creditHoldField;

        private SearchColumnBooleanField[] creditHoldOverrideField;

        private SearchColumnDoubleField[] creditLimitField;

        private SearchColumnSelectField[] currencyField;

        private SearchColumnDateField[] dateClosedField;

        private SearchColumnDateField[] dateCreatedField;

        private SearchColumnLongField[] daysOverdueField;

        private SearchColumnSelectField[] defaultAllocationStrategyField;

        private SearchColumnDoubleField[] defaultOrderPriorityField;

        private SearchColumnStringField[] defaultTaxRegField;

        private SearchColumnDoubleField[] depositBalanceField;

        private SearchColumnStringField[] drAccountField;

        private SearchColumnStringField[] emailField;

        private SearchColumnEnumSelectField[] emailPreferenceField;

        private SearchColumnBooleanField[] emailTransactionsField;

        private SearchColumnDateField[] endDateField;

        private SearchColumnStringField[] entityIdField;

        private SearchColumnLongField[] entityNumberField;

        private SearchColumnSelectField[] entityStatusField;

        private SearchColumnDoubleField[] estimatedBudgetField;

        private SearchColumnBooleanField[] explicitConversionField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnStringField[] faxField;

        private SearchColumnBooleanField[] faxTransactionsField;

        private SearchColumnStringField[] firstNameField;

        private SearchColumnDateField[] firstOrderDateField;

        private SearchColumnDateField[] firstSaleDateField;

        private SearchColumnStringField[] fxAccountField;

        private SearchColumnDoubleField[] fxBalanceField;

        private SearchColumnDoubleField[] fxConsolBalanceField;

        private SearchColumnDoubleField[] fxConsolUnbilledOrdersField;

        private SearchColumnDoubleField[] fxUnbilledOrdersField;

        private SearchColumnBooleanField[] giveAccessField;

        private SearchColumnEnumSelectField[] globalSubscriptionStatusField;

        private SearchColumnStringField[] groupPricingLevelField;

        private SearchColumnBooleanField[] hasDuplicatesField;

        private SearchColumnStringField[] homePhoneField;

        private SearchColumnSelectField[] imageField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnBooleanField[] isBudgetApprovedField;

        private SearchColumnBooleanField[] isDefaultBillingField;

        private SearchColumnBooleanField[] isDefaultShippingField;

        private SearchColumnBooleanField[] isInactiveField;

        private SearchColumnBooleanField[] isPersonField;

        private SearchColumnBooleanField[] isShipAddressField;

        private SearchColumnStringField[] itemPricingLevelField;

        private SearchColumnDoubleField[] itemPricingUnitPriceField;

        private SearchColumnDateField[] jobEndDateField;

        private SearchColumnDateField[] jobProjectedEndField;

        private SearchColumnDateField[] jobStartDateField;

        private SearchColumnSelectField[] jobTypeField;

        private SearchColumnEnumSelectField[] languageField;

        private SearchColumnDateField[] lastModifiedDateField;

        private SearchColumnStringField[] lastNameField;

        private SearchColumnDateField[] lastOrderDateField;

        private SearchColumnDateField[] lastSaleDateField;

        private SearchColumnDateField[] leadDateField;

        private SearchColumnSelectField[] leadSourceField;

        private SearchColumnEnumSelectField[] levelField;

        private SearchColumnBooleanField[] manualCreditHoldField;

        private SearchColumnStringField[] middleNameField;

        private SearchColumnStringField[] mobilePhoneField;

        private SearchColumnEnumSelectField[] monthlyClosingField;

        private SearchColumnBooleanField[] onCreditHoldField;

        private SearchColumnDoubleField[] overdueBalanceField;

        private SearchColumnSelectField[] parentField;

        private SearchColumnSelectField[] partnerField;

        private SearchColumnDoubleField[] partnerContributionField;

        private SearchColumnStringField[] partnerRoleField;

        private SearchColumnSelectField[] partnerTeamMemberField;

        private SearchColumnStringField[] pecField;

        private SearchColumnEnumSelectField[] permissionField;

        private SearchColumnStringField[] phoneField;

        private SearchColumnStringField[] phoneticNameField;

        private SearchColumnSelectField[] prefCCProcessorField;

        private SearchColumnSelectField[] priceLevelField;

        private SearchColumnStringField[] pricingGroupField;

        private SearchColumnStringField[] pricingItemField;

        private SearchColumnBooleanField[] printTransactionsField;

        private SearchColumnDateField[] prospectDateField;

        private SearchColumnStringField[] receivablesAccountField;

        private SearchColumnLongField[] reminderDaysField;

        private SearchColumnStringField[] resaleNumberField;

        private SearchColumnStringField[] roleField;

        private SearchColumnStringField[] salesReadinessField;

        private SearchColumnSelectField[] salesRepField;

        private SearchColumnSelectField[] salesTeamMemberField;

        private SearchColumnSelectField[] salesTeamRoleField;

        private SearchColumnStringField[] salutationField;

        private SearchColumnStringField[] shipAddressField;

        private SearchColumnStringField[] shipAddress1Field;

        private SearchColumnStringField[] shipAddress2Field;

        private SearchColumnStringField[] shipAddress3Field;

        private SearchColumnStringField[] shipAddresseeField;

        private SearchColumnStringField[] shipAttentionField;

        private SearchColumnStringField[] shipCityField;

        private SearchColumnBooleanField[] shipCompleteField;

        private SearchColumnEnumSelectField[] shipCountryField;

        private SearchColumnStringField[] shipCountryCodeField;

        private SearchColumnStringField[] shipPhoneField;

        private SearchColumnSelectField[] shippingItemField;

        private SearchColumnStringField[] shipStateField;

        private SearchColumnStringField[] shipZipField;

        private SearchColumnSelectField[] sourceSiteField;

        private SearchColumnLongField[] sourceSiteIdField;

        private SearchColumnEnumSelectField[] stageField;

        private SearchColumnDateField[] startDateField;

        private SearchColumnStringField[] stateField;

        private SearchColumnSelectField[] subscriptionField;

        private SearchColumnDateField[] subscriptionDateField;

        private SearchColumnBooleanField[] subscriptionStatusField;

        private SearchColumnSelectField[] subsidiaryField;

        private SearchColumnBooleanField[] taxableField;

        private SearchColumnSelectField[] taxItemField;

        private SearchColumnSelectField[] termsField;

        private SearchColumnSelectField[] territoryField;

        private SearchColumnStringField[] titleField;

        private SearchColumnDoubleField[] unbilledOrdersField;

        private SearchColumnStringField[] urlField;

        private SearchColumnStringField[] vatRegNumberField;

        private SearchColumnBooleanField[] webLeadField;

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
        [System.Xml.Serialization.XmlElementAttribute("altContact")]
        public SearchColumnStringField[] altContact {
            get {
                return this.altContactField;
            }
            set {
                this.altContactField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("assignedSite")]
        public SearchColumnSelectField[] assignedSite {
            get {
                return this.assignedSiteField;
            }
            set {
                this.assignedSiteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("assignedSiteId")]
        public SearchColumnLongField[] assignedSiteId {
            get {
                return this.assignedSiteIdField;
            }
            set {
                this.assignedSiteIdField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("balance")]
        public SearchColumnDoubleField[] balance {
            get {
                return this.balanceField;
            }
            set {
                this.balanceField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("category")]
        public SearchColumnSelectField[] category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ccCustomerCode")]
        public SearchColumnStringField[] ccCustomerCode {
            get {
                return this.ccCustomerCodeField;
            }
            set {
                this.ccCustomerCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ccDefault")]
        public SearchColumnBooleanField[] ccDefault {
            get {
                return this.ccDefaultField;
            }
            set {
                this.ccDefaultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ccExpDate")]
        public SearchColumnDateField[] ccExpDate {
            get {
                return this.ccExpDateField;
            }
            set {
                this.ccExpDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ccHolderName")]
        public SearchColumnStringField[] ccHolderName {
            get {
                return this.ccHolderNameField;
            }
            set {
                this.ccHolderNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ccInternalId")]
        public SearchColumnStringField[] ccInternalId {
            get {
                return this.ccInternalIdField;
            }
            set {
                this.ccInternalIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ccNumber")]
        public SearchColumnStringField[] ccNumber {
            get {
                return this.ccNumberField;
            }
            set {
                this.ccNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ccState")]
        public SearchColumnSelectField[] ccState {
            get {
                return this.ccStateField;
            }
            set {
                this.ccStateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ccStateFrom")]
        public SearchColumnDateField[] ccStateFrom {
            get {
                return this.ccStateFromField;
            }
            set {
                this.ccStateFromField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ccType")]
        public SearchColumnSelectField[] ccType {
            get {
                return this.ccTypeField;
            }
            set {
                this.ccTypeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("companyName")]
        public SearchColumnStringField[] companyName {
            get {
                return this.companyNameField;
            }
            set {
                this.companyNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("consolBalance")]
        public SearchColumnDoubleField[] consolBalance {
            get {
                return this.consolBalanceField;
            }
            set {
                this.consolBalanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("consolDaysOverdue")]
        public SearchColumnLongField[] consolDaysOverdue {
            get {
                return this.consolDaysOverdueField;
            }
            set {
                this.consolDaysOverdueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("consolDepositBalance")]
        public SearchColumnDoubleField[] consolDepositBalance {
            get {
                return this.consolDepositBalanceField;
            }
            set {
                this.consolDepositBalanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("consolOverdueBalance")]
        public SearchColumnDoubleField[] consolOverdueBalance {
            get {
                return this.consolOverdueBalanceField;
            }
            set {
                this.consolOverdueBalanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("consolUnbilledOrders")]
        public SearchColumnDoubleField[] consolUnbilledOrders {
            get {
                return this.consolUnbilledOrdersField;
            }
            set {
                this.consolUnbilledOrdersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("contact")]
        public SearchColumnStringField[] contact {
            get {
                return this.contactField;
            }
            set {
                this.contactField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("conversionDate")]
        public SearchColumnDateField[] conversionDate {
            get {
                return this.conversionDateField;
            }
            set {
                this.conversionDateField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("creditHold")]
        public SearchColumnEnumSelectField[] creditHold {
            get {
                return this.creditHoldField;
            }
            set {
                this.creditHoldField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("creditHoldOverride")]
        public SearchColumnBooleanField[] creditHoldOverride {
            get {
                return this.creditHoldOverrideField;
            }
            set {
                this.creditHoldOverrideField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("creditLimit")]
        public SearchColumnDoubleField[] creditLimit {
            get {
                return this.creditLimitField;
            }
            set {
                this.creditLimitField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("dateClosed")]
        public SearchColumnDateField[] dateClosed {
            get {
                return this.dateClosedField;
            }
            set {
                this.dateClosedField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("daysOverdue")]
        public SearchColumnLongField[] daysOverdue {
            get {
                return this.daysOverdueField;
            }
            set {
                this.daysOverdueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("defaultAllocationStrategy")]
        public SearchColumnSelectField[] defaultAllocationStrategy {
            get {
                return this.defaultAllocationStrategyField;
            }
            set {
                this.defaultAllocationStrategyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("defaultOrderPriority")]
        public SearchColumnDoubleField[] defaultOrderPriority {
            get {
                return this.defaultOrderPriorityField;
            }
            set {
                this.defaultOrderPriorityField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("depositBalance")]
        public SearchColumnDoubleField[] depositBalance {
            get {
                return this.depositBalanceField;
            }
            set {
                this.depositBalanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("drAccount")]
        public SearchColumnStringField[] drAccount {
            get {
                return this.drAccountField;
            }
            set {
                this.drAccountField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("emailPreference")]
        public SearchColumnEnumSelectField[] emailPreference {
            get {
                return this.emailPreferenceField;
            }
            set {
                this.emailPreferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("emailTransactions")]
        public SearchColumnBooleanField[] emailTransactions {
            get {
                return this.emailTransactionsField;
            }
            set {
                this.emailTransactionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("endDate")]
        public SearchColumnDateField[] endDate {
            get {
                return this.endDateField;
            }
            set {
                this.endDateField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("explicitConversion")]
        public SearchColumnBooleanField[] explicitConversion {
            get {
                return this.explicitConversionField;
            }
            set {
                this.explicitConversionField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("faxTransactions")]
        public SearchColumnBooleanField[] faxTransactions {
            get {
                return this.faxTransactionsField;
            }
            set {
                this.faxTransactionsField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("firstOrderDate")]
        public SearchColumnDateField[] firstOrderDate {
            get {
                return this.firstOrderDateField;
            }
            set {
                this.firstOrderDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("firstSaleDate")]
        public SearchColumnDateField[] firstSaleDate {
            get {
                return this.firstSaleDateField;
            }
            set {
                this.firstSaleDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fxAccount")]
        public SearchColumnStringField[] fxAccount {
            get {
                return this.fxAccountField;
            }
            set {
                this.fxAccountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fxBalance")]
        public SearchColumnDoubleField[] fxBalance {
            get {
                return this.fxBalanceField;
            }
            set {
                this.fxBalanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fxConsolBalance")]
        public SearchColumnDoubleField[] fxConsolBalance {
            get {
                return this.fxConsolBalanceField;
            }
            set {
                this.fxConsolBalanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fxConsolUnbilledOrders")]
        public SearchColumnDoubleField[] fxConsolUnbilledOrders {
            get {
                return this.fxConsolUnbilledOrdersField;
            }
            set {
                this.fxConsolUnbilledOrdersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fxUnbilledOrders")]
        public SearchColumnDoubleField[] fxUnbilledOrders {
            get {
                return this.fxUnbilledOrdersField;
            }
            set {
                this.fxUnbilledOrdersField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("groupPricingLevel")]
        public SearchColumnStringField[] groupPricingLevel {
            get {
                return this.groupPricingLevelField;
            }
            set {
                this.groupPricingLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("hasDuplicates")]
        public SearchColumnBooleanField[] hasDuplicates {
            get {
                return this.hasDuplicatesField;
            }
            set {
                this.hasDuplicatesField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("isPerson")]
        public SearchColumnBooleanField[] isPerson {
            get {
                return this.isPersonField;
            }
            set {
                this.isPersonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isShipAddress")]
        public SearchColumnBooleanField[] isShipAddress {
            get {
                return this.isShipAddressField;
            }
            set {
                this.isShipAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("itemPricingLevel")]
        public SearchColumnStringField[] itemPricingLevel {
            get {
                return this.itemPricingLevelField;
            }
            set {
                this.itemPricingLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("itemPricingUnitPrice")]
        public SearchColumnDoubleField[] itemPricingUnitPrice {
            get {
                return this.itemPricingUnitPriceField;
            }
            set {
                this.itemPricingUnitPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("jobEndDate")]
        public SearchColumnDateField[] jobEndDate {
            get {
                return this.jobEndDateField;
            }
            set {
                this.jobEndDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("jobProjectedEnd")]
        public SearchColumnDateField[] jobProjectedEnd {
            get {
                return this.jobProjectedEndField;
            }
            set {
                this.jobProjectedEndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("jobStartDate")]
        public SearchColumnDateField[] jobStartDate {
            get {
                return this.jobStartDateField;
            }
            set {
                this.jobStartDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("jobType")]
        public SearchColumnSelectField[] jobType {
            get {
                return this.jobTypeField;
            }
            set {
                this.jobTypeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("lastOrderDate")]
        public SearchColumnDateField[] lastOrderDate {
            get {
                return this.lastOrderDateField;
            }
            set {
                this.lastOrderDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lastSaleDate")]
        public SearchColumnDateField[] lastSaleDate {
            get {
                return this.lastSaleDateField;
            }
            set {
                this.lastSaleDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("leadDate")]
        public SearchColumnDateField[] leadDate {
            get {
                return this.leadDateField;
            }
            set {
                this.leadDateField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("manualCreditHold")]
        public SearchColumnBooleanField[] manualCreditHold {
            get {
                return this.manualCreditHoldField;
            }
            set {
                this.manualCreditHoldField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("monthlyClosing")]
        public SearchColumnEnumSelectField[] monthlyClosing {
            get {
                return this.monthlyClosingField;
            }
            set {
                this.monthlyClosingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("onCreditHold")]
        public SearchColumnBooleanField[] onCreditHold {
            get {
                return this.onCreditHoldField;
            }
            set {
                this.onCreditHoldField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("overdueBalance")]
        public SearchColumnDoubleField[] overdueBalance {
            get {
                return this.overdueBalanceField;
            }
            set {
                this.overdueBalanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("parent")]
        public SearchColumnSelectField[] parent {
            get {
                return this.parentField;
            }
            set {
                this.parentField = value;
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
        public SearchColumnStringField[] partnerRole {
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
        [System.Xml.Serialization.XmlElementAttribute("pec")]
        public SearchColumnStringField[] pec {
            get {
                return this.pecField;
            }
            set {
                this.pecField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("prefCCProcessor")]
        public SearchColumnSelectField[] prefCCProcessor {
            get {
                return this.prefCCProcessorField;
            }
            set {
                this.prefCCProcessorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("priceLevel")]
        public SearchColumnSelectField[] priceLevel {
            get {
                return this.priceLevelField;
            }
            set {
                this.priceLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pricingGroup")]
        public SearchColumnStringField[] pricingGroup {
            get {
                return this.pricingGroupField;
            }
            set {
                this.pricingGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pricingItem")]
        public SearchColumnStringField[] pricingItem {
            get {
                return this.pricingItemField;
            }
            set {
                this.pricingItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("printTransactions")]
        public SearchColumnBooleanField[] printTransactions {
            get {
                return this.printTransactionsField;
            }
            set {
                this.printTransactionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("prospectDate")]
        public SearchColumnDateField[] prospectDate {
            get {
                return this.prospectDateField;
            }
            set {
                this.prospectDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("receivablesAccount")]
        public SearchColumnStringField[] receivablesAccount {
            get {
                return this.receivablesAccountField;
            }
            set {
                this.receivablesAccountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("reminderDays")]
        public SearchColumnLongField[] reminderDays {
            get {
                return this.reminderDaysField;
            }
            set {
                this.reminderDaysField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("resaleNumber")]
        public SearchColumnStringField[] resaleNumber {
            get {
                return this.resaleNumberField;
            }
            set {
                this.resaleNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("role")]
        public SearchColumnStringField[] role {
            get {
                return this.roleField;
            }
            set {
                this.roleField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("shipAddress")]
        public SearchColumnStringField[] shipAddress {
            get {
                return this.shipAddressField;
            }
            set {
                this.shipAddressField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("shipComplete")]
        public SearchColumnBooleanField[] shipComplete {
            get {
                return this.shipCompleteField;
            }
            set {
                this.shipCompleteField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("shippingItem")]
        public SearchColumnSelectField[] shippingItem {
            get {
                return this.shippingItemField;
            }
            set {
                this.shippingItemField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("sourceSite")]
        public SearchColumnSelectField[] sourceSite {
            get {
                return this.sourceSiteField;
            }
            set {
                this.sourceSiteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("sourceSiteId")]
        public SearchColumnLongField[] sourceSiteId {
            get {
                return this.sourceSiteIdField;
            }
            set {
                this.sourceSiteIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("stage")]
        public SearchColumnEnumSelectField[] stage {
            get {
                return this.stageField;
            }
            set {
                this.stageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("startDate")]
        public SearchColumnDateField[] startDate {
            get {
                return this.startDateField;
            }
            set {
                this.startDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("state")]
        public SearchColumnStringField[] state {
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
        [System.Xml.Serialization.XmlElementAttribute("taxable")]
        public SearchColumnBooleanField[] taxable {
            get {
                return this.taxableField;
            }
            set {
                this.taxableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("taxItem")]
        public SearchColumnSelectField[] taxItem {
            get {
                return this.taxItemField;
            }
            set {
                this.taxItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("terms")]
        public SearchColumnSelectField[] terms {
            get {
                return this.termsField;
            }
            set {
                this.termsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("territory")]
        public SearchColumnSelectField[] territory {
            get {
                return this.territoryField;
            }
            set {
                this.territoryField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("unbilledOrders")]
        public SearchColumnDoubleField[] unbilledOrders {
            get {
                return this.unbilledOrdersField;
            }
            set {
                this.unbilledOrdersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("url")]
        public SearchColumnStringField[] url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("vatRegNumber")]
        public SearchColumnStringField[] vatRegNumber {
            get {
                return this.vatRegNumberField;
            }
            set {
                this.vatRegNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("webLead")]
        public SearchColumnBooleanField[] webLead {
            get {
                return this.webLeadField;
            }
            set {
                this.webLeadField = value;
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