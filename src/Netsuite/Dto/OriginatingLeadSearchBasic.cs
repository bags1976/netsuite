namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class OriginatingLeadSearchBasic : SearchRecordBasic {

        private SearchStringField accountNumberField;

        private SearchStringField addressField;

        private SearchStringField addresseeField;

        private SearchStringField addressLabelField;

        private SearchStringField addressPhoneField;

        private SearchMultiSelectField assignedSiteField;

        private SearchMultiSelectField assignedSiteIdField;

        private SearchStringField attentionField;

        private SearchBooleanField availableOfflineField;

        private SearchDoubleField balanceField;

        private SearchStringField billAddressField;

        private SearchDoubleField boughtAmountField;

        private SearchDateField boughtDateField;

        private SearchMultiSelectField buyingReasonField;

        private SearchMultiSelectField buyingTimeFrameField;

        private SearchMultiSelectField categoryField;

        private SearchStringField ccCustomerCodeField;

        private SearchBooleanField ccDefaultField;

        private SearchDateField ccExpDateField;

        private SearchStringField ccHolderNameField;

        private SearchStringField ccNumberField;

        private SearchMultiSelectField ccStateField;

        private SearchDateField ccStateFromField;

        private SearchMultiSelectField ccTypeField;

        private SearchStringField cityField;

        private SearchMultiSelectField classBoughtField;

        private SearchStringField commentsField;

        private SearchStringField companyNameField;

        private SearchDoubleField consolBalanceField;

        private SearchLongField consolDaysOverdueField;

        private SearchDoubleField consolDepositBalanceField;

        private SearchDoubleField consolOverdueBalanceField;

        private SearchDoubleField consolUnbilledOrdersField;

        private SearchStringField contactField;

        private SearchLongField contributionField;

        private SearchDateField conversionDateField;

        private SearchEnumMultiSelectField countryField;

        private SearchStringField countyField;

        private SearchEnumMultiSelectField creditHoldField;

        private SearchBooleanField creditHoldOverrideField;

        private SearchDoubleField creditLimitField;

        private SearchMultiSelectField currencyField;

        private SearchMultiSelectField custStageField;

        private SearchMultiSelectField custStatusField;

        private SearchDateField dateClosedField;

        private SearchDateField dateCreatedField;

        private SearchLongField daysOverdueField;

        private SearchDoubleField defaultOrderPriorityField;

        private SearchMultiSelectField defaultTaxRegField;

        private SearchStringField defaultTaxRegTextField;

        private SearchDoubleField depositBalanceField;

        private SearchMultiSelectField deptBoughtField;

        private SearchMultiSelectField drAccountField;

        private SearchStringField emailField;

        private SearchEnumMultiSelectField emailPreferenceField;

        private SearchBooleanField emailTransactionsField;

        private SearchDateField endDateField;

        private SearchStringField entityIdField;

        private SearchMultiSelectField entityStatusField;

        private SearchDoubleField estimatedBudgetField;

        private SearchBooleanField explicitConversionField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchStringField faxField;

        private SearchBooleanField faxTransactionsField;

        private SearchStringField firstNameField;

        private SearchDateField firstOrderDateField;

        private SearchDateField firstSaleDateField;

        private SearchMultiSelectField fxAccountField;

        private SearchDoubleField fxBalanceField;

        private SearchDoubleField fxConsolBalanceField;

        private SearchDoubleField fxConsolUnbilledOrdersField;

        private SearchDoubleField fxUnbilledOrdersField;

        private SearchBooleanField giveAccessField;

        private SearchEnumMultiSelectField globalSubscriptionStatusField;

        private SearchMultiSelectField groupField;

        private SearchMultiSelectField groupPricingLevelField;

        private SearchBooleanField hasDuplicatesField;

        private SearchStringField imageField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchBooleanField isBudgetApprovedField;

        private SearchBooleanField isDefaultBillingField;

        private SearchBooleanField isDefaultShippingField;

        private SearchBooleanField isInactiveField;

        private SearchBooleanField isPersonField;

        private SearchBooleanField isReportedLeadField;

        private SearchBooleanField isShipAddressField;

        private SearchMultiSelectField itemPricingLevelField;

        private SearchDoubleField itemPricingUnitPriceField;

        private SearchMultiSelectField itemsBoughtField;

        private SearchMultiSelectField itemsOrderedField;

        private SearchEnumMultiSelectField languageField;

        private SearchDateField lastModifiedDateField;

        private SearchStringField lastNameField;

        private SearchDateField lastOrderDateField;

        private SearchDateField lastSaleDateField;

        private SearchDateField leadDateField;

        private SearchMultiSelectField leadSourceField;

        private SearchEnumMultiSelectField levelField;

        private SearchMultiSelectField locationBoughtField;

        private SearchBooleanField manualCreditHoldField;

        private SearchMultiSelectField merchantAccountField;

        private SearchStringField middleNameField;

        private SearchEnumMultiSelectField monthlyClosingField;

        private SearchBooleanField onCreditHoldField;

        private SearchDoubleField orderedAmountField;

        private SearchDateField orderedDateField;

        private SearchEnumMultiSelectField otherRelationshipsField;

        private SearchDoubleField overdueBalanceField;

        private SearchMultiSelectField parentField;

        private SearchMultiSelectField parentItemsBoughtField;

        private SearchMultiSelectField parentItemsOrderedField;

        private SearchMultiSelectField partnerField;

        private SearchLongField partnerContributionField;

        private SearchMultiSelectField partnerRoleField;

        private SearchMultiSelectField partnerTeamMemberField;

        private SearchStringField pecField;

        private SearchEnumMultiSelectField permissionField;

        private SearchStringField phoneField;

        private SearchStringField phoneticNameField;

        private SearchMultiSelectField priceLevelField;

        private SearchMultiSelectField pricingGroupField;

        private SearchMultiSelectField pricingItemField;

        private SearchBooleanField printTransactionsField;

        private SearchDateField prospectDateField;

        private SearchBooleanField pstExemptField;

        private SearchMultiSelectField receivablesAccountField;

        private SearchDateField reminderDateField;

        private SearchStringField resaleNumberField;

        private SearchMultiSelectField roleField;

        private SearchMultiSelectField salesReadinessField;

        private SearchMultiSelectField salesRepField;

        private SearchMultiSelectField salesTeamMemberField;

        private SearchMultiSelectField salesTeamRoleField;

        private SearchStringField salutationField;

        private SearchStringField shipAddressField;

        private SearchBooleanField shipCompleteField;

        private SearchMultiSelectField shippingItemField;

        private SearchMultiSelectField sourceSiteField;

        private SearchMultiSelectField sourceSiteIdField;

        private SearchMultiSelectField stageField;

        private SearchDateField startDateField;

        private SearchStringField stateField;

        private SearchMultiSelectField subsidBoughtField;

        private SearchMultiSelectField subsidiaryField;

        private SearchBooleanField taxableField;

        private SearchMultiSelectField termsField;

        private SearchMultiSelectField territoryField;

        private SearchStringField titleField;

        private SearchDoubleField unbilledOrdersField;

        private SearchStringField urlField;

        private SearchStringField vatRegNumberField;

        private SearchBooleanField webLeadField;

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
        public SearchMultiSelectField assignedSite {
            get {
                return this.assignedSiteField;
            }
            set {
                this.assignedSiteField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField assignedSiteId {
            get {
                return this.assignedSiteIdField;
            }
            set {
                this.assignedSiteIdField = value;
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
        public SearchBooleanField availableOffline {
            get {
                return this.availableOfflineField;
            }
            set {
                this.availableOfflineField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField balance {
            get {
                return this.balanceField;
            }
            set {
                this.balanceField = value;
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
        public SearchDoubleField boughtAmount {
            get {
                return this.boughtAmountField;
            }
            set {
                this.boughtAmountField = value;
            }
        }

        /// <remarks/>
        public SearchDateField boughtDate {
            get {
                return this.boughtDateField;
            }
            set {
                this.boughtDateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField buyingReason {
            get {
                return this.buyingReasonField;
            }
            set {
                this.buyingReasonField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField buyingTimeFrame {
            get {
                return this.buyingTimeFrameField;
            }
            set {
                this.buyingTimeFrameField = value;
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
        public SearchStringField ccCustomerCode {
            get {
                return this.ccCustomerCodeField;
            }
            set {
                this.ccCustomerCodeField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField ccDefault {
            get {
                return this.ccDefaultField;
            }
            set {
                this.ccDefaultField = value;
            }
        }

        /// <remarks/>
        public SearchDateField ccExpDate {
            get {
                return this.ccExpDateField;
            }
            set {
                this.ccExpDateField = value;
            }
        }

        /// <remarks/>
        public SearchStringField ccHolderName {
            get {
                return this.ccHolderNameField;
            }
            set {
                this.ccHolderNameField = value;
            }
        }

        /// <remarks/>
        public SearchStringField ccNumber {
            get {
                return this.ccNumberField;
            }
            set {
                this.ccNumberField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField ccState {
            get {
                return this.ccStateField;
            }
            set {
                this.ccStateField = value;
            }
        }

        /// <remarks/>
        public SearchDateField ccStateFrom {
            get {
                return this.ccStateFromField;
            }
            set {
                this.ccStateFromField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField ccType {
            get {
                return this.ccTypeField;
            }
            set {
                this.ccTypeField = value;
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
        public SearchMultiSelectField classBought {
            get {
                return this.classBoughtField;
            }
            set {
                this.classBoughtField = value;
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
        public SearchStringField companyName {
            get {
                return this.companyNameField;
            }
            set {
                this.companyNameField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField consolBalance {
            get {
                return this.consolBalanceField;
            }
            set {
                this.consolBalanceField = value;
            }
        }

        /// <remarks/>
        public SearchLongField consolDaysOverdue {
            get {
                return this.consolDaysOverdueField;
            }
            set {
                this.consolDaysOverdueField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField consolDepositBalance {
            get {
                return this.consolDepositBalanceField;
            }
            set {
                this.consolDepositBalanceField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField consolOverdueBalance {
            get {
                return this.consolOverdueBalanceField;
            }
            set {
                this.consolOverdueBalanceField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField consolUnbilledOrders {
            get {
                return this.consolUnbilledOrdersField;
            }
            set {
                this.consolUnbilledOrdersField = value;
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
        public SearchLongField contribution {
            get {
                return this.contributionField;
            }
            set {
                this.contributionField = value;
            }
        }

        /// <remarks/>
        public SearchDateField conversionDate {
            get {
                return this.conversionDateField;
            }
            set {
                this.conversionDateField = value;
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
        public SearchEnumMultiSelectField creditHold {
            get {
                return this.creditHoldField;
            }
            set {
                this.creditHoldField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField creditHoldOverride {
            get {
                return this.creditHoldOverrideField;
            }
            set {
                this.creditHoldOverrideField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField creditLimit {
            get {
                return this.creditLimitField;
            }
            set {
                this.creditLimitField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField custStage {
            get {
                return this.custStageField;
            }
            set {
                this.custStageField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField custStatus {
            get {
                return this.custStatusField;
            }
            set {
                this.custStatusField = value;
            }
        }

        /// <remarks/>
        public SearchDateField dateClosed {
            get {
                return this.dateClosedField;
            }
            set {
                this.dateClosedField = value;
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
        public SearchLongField daysOverdue {
            get {
                return this.daysOverdueField;
            }
            set {
                this.daysOverdueField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField defaultOrderPriority {
            get {
                return this.defaultOrderPriorityField;
            }
            set {
                this.defaultOrderPriorityField = value;
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
        public SearchDoubleField depositBalance {
            get {
                return this.depositBalanceField;
            }
            set {
                this.depositBalanceField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField deptBought {
            get {
                return this.deptBoughtField;
            }
            set {
                this.deptBoughtField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField drAccount {
            get {
                return this.drAccountField;
            }
            set {
                this.drAccountField = value;
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
        public SearchEnumMultiSelectField emailPreference {
            get {
                return this.emailPreferenceField;
            }
            set {
                this.emailPreferenceField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField emailTransactions {
            get {
                return this.emailTransactionsField;
            }
            set {
                this.emailTransactionsField = value;
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
        public SearchMultiSelectField entityStatus {
            get {
                return this.entityStatusField;
            }
            set {
                this.entityStatusField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField estimatedBudget {
            get {
                return this.estimatedBudgetField;
            }
            set {
                this.estimatedBudgetField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField explicitConversion {
            get {
                return this.explicitConversionField;
            }
            set {
                this.explicitConversionField = value;
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
        public SearchBooleanField faxTransactions {
            get {
                return this.faxTransactionsField;
            }
            set {
                this.faxTransactionsField = value;
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
        public SearchDateField firstOrderDate {
            get {
                return this.firstOrderDateField;
            }
            set {
                this.firstOrderDateField = value;
            }
        }

        /// <remarks/>
        public SearchDateField firstSaleDate {
            get {
                return this.firstSaleDateField;
            }
            set {
                this.firstSaleDateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField fxAccount {
            get {
                return this.fxAccountField;
            }
            set {
                this.fxAccountField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField fxBalance {
            get {
                return this.fxBalanceField;
            }
            set {
                this.fxBalanceField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField fxConsolBalance {
            get {
                return this.fxConsolBalanceField;
            }
            set {
                this.fxConsolBalanceField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField fxConsolUnbilledOrders {
            get {
                return this.fxConsolUnbilledOrdersField;
            }
            set {
                this.fxConsolUnbilledOrdersField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField fxUnbilledOrders {
            get {
                return this.fxUnbilledOrdersField;
            }
            set {
                this.fxUnbilledOrdersField = value;
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
        public SearchMultiSelectField groupPricingLevel {
            get {
                return this.groupPricingLevelField;
            }
            set {
                this.groupPricingLevelField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField hasDuplicates {
            get {
                return this.hasDuplicatesField;
            }
            set {
                this.hasDuplicatesField = value;
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
        public SearchBooleanField isBudgetApproved {
            get {
                return this.isBudgetApprovedField;
            }
            set {
                this.isBudgetApprovedField = value;
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
        public SearchBooleanField isPerson {
            get {
                return this.isPersonField;
            }
            set {
                this.isPersonField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isReportedLead {
            get {
                return this.isReportedLeadField;
            }
            set {
                this.isReportedLeadField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isShipAddress {
            get {
                return this.isShipAddressField;
            }
            set {
                this.isShipAddressField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField itemPricingLevel {
            get {
                return this.itemPricingLevelField;
            }
            set {
                this.itemPricingLevelField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField itemPricingUnitPrice {
            get {
                return this.itemPricingUnitPriceField;
            }
            set {
                this.itemPricingUnitPriceField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField itemsBought {
            get {
                return this.itemsBoughtField;
            }
            set {
                this.itemsBoughtField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField itemsOrdered {
            get {
                return this.itemsOrderedField;
            }
            set {
                this.itemsOrderedField = value;
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
        public SearchDateField lastOrderDate {
            get {
                return this.lastOrderDateField;
            }
            set {
                this.lastOrderDateField = value;
            }
        }

        /// <remarks/>
        public SearchDateField lastSaleDate {
            get {
                return this.lastSaleDateField;
            }
            set {
                this.lastSaleDateField = value;
            }
        }

        /// <remarks/>
        public SearchDateField leadDate {
            get {
                return this.leadDateField;
            }
            set {
                this.leadDateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField leadSource {
            get {
                return this.leadSourceField;
            }
            set {
                this.leadSourceField = value;
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
        public SearchMultiSelectField locationBought {
            get {
                return this.locationBoughtField;
            }
            set {
                this.locationBoughtField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField manualCreditHold {
            get {
                return this.manualCreditHoldField;
            }
            set {
                this.manualCreditHoldField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField merchantAccount {
            get {
                return this.merchantAccountField;
            }
            set {
                this.merchantAccountField = value;
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
        public SearchEnumMultiSelectField monthlyClosing {
            get {
                return this.monthlyClosingField;
            }
            set {
                this.monthlyClosingField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField onCreditHold {
            get {
                return this.onCreditHoldField;
            }
            set {
                this.onCreditHoldField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField orderedAmount {
            get {
                return this.orderedAmountField;
            }
            set {
                this.orderedAmountField = value;
            }
        }

        /// <remarks/>
        public SearchDateField orderedDate {
            get {
                return this.orderedDateField;
            }
            set {
                this.orderedDateField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField otherRelationships {
            get {
                return this.otherRelationshipsField;
            }
            set {
                this.otherRelationshipsField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField overdueBalance {
            get {
                return this.overdueBalanceField;
            }
            set {
                this.overdueBalanceField = value;
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
        public SearchMultiSelectField parentItemsBought {
            get {
                return this.parentItemsBoughtField;
            }
            set {
                this.parentItemsBoughtField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField parentItemsOrdered {
            get {
                return this.parentItemsOrderedField;
            }
            set {
                this.parentItemsOrderedField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField partner {
            get {
                return this.partnerField;
            }
            set {
                this.partnerField = value;
            }
        }

        /// <remarks/>
        public SearchLongField partnerContribution {
            get {
                return this.partnerContributionField;
            }
            set {
                this.partnerContributionField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField partnerRole {
            get {
                return this.partnerRoleField;
            }
            set {
                this.partnerRoleField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField partnerTeamMember {
            get {
                return this.partnerTeamMemberField;
            }
            set {
                this.partnerTeamMemberField = value;
            }
        }

        /// <remarks/>
        public SearchStringField pec {
            get {
                return this.pecField;
            }
            set {
                this.pecField = value;
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
        public SearchMultiSelectField priceLevel {
            get {
                return this.priceLevelField;
            }
            set {
                this.priceLevelField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField pricingGroup {
            get {
                return this.pricingGroupField;
            }
            set {
                this.pricingGroupField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField pricingItem {
            get {
                return this.pricingItemField;
            }
            set {
                this.pricingItemField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField printTransactions {
            get {
                return this.printTransactionsField;
            }
            set {
                this.printTransactionsField = value;
            }
        }

        /// <remarks/>
        public SearchDateField prospectDate {
            get {
                return this.prospectDateField;
            }
            set {
                this.prospectDateField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField pstExempt {
            get {
                return this.pstExemptField;
            }
            set {
                this.pstExemptField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField receivablesAccount {
            get {
                return this.receivablesAccountField;
            }
            set {
                this.receivablesAccountField = value;
            }
        }

        /// <remarks/>
        public SearchDateField reminderDate {
            get {
                return this.reminderDateField;
            }
            set {
                this.reminderDateField = value;
            }
        }

        /// <remarks/>
        public SearchStringField resaleNumber {
            get {
                return this.resaleNumberField;
            }
            set {
                this.resaleNumberField = value;
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
        public SearchMultiSelectField salesReadiness {
            get {
                return this.salesReadinessField;
            }
            set {
                this.salesReadinessField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField salesRep {
            get {
                return this.salesRepField;
            }
            set {
                this.salesRepField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField salesTeamMember {
            get {
                return this.salesTeamMemberField;
            }
            set {
                this.salesTeamMemberField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField salesTeamRole {
            get {
                return this.salesTeamRoleField;
            }
            set {
                this.salesTeamRoleField = value;
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
        public SearchStringField shipAddress {
            get {
                return this.shipAddressField;
            }
            set {
                this.shipAddressField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField shipComplete {
            get {
                return this.shipCompleteField;
            }
            set {
                this.shipCompleteField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField shippingItem {
            get {
                return this.shippingItemField;
            }
            set {
                this.shippingItemField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField sourceSite {
            get {
                return this.sourceSiteField;
            }
            set {
                this.sourceSiteField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField sourceSiteId {
            get {
                return this.sourceSiteIdField;
            }
            set {
                this.sourceSiteIdField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField stage {
            get {
                return this.stageField;
            }
            set {
                this.stageField = value;
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
        public SearchStringField state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField subsidBought {
            get {
                return this.subsidBoughtField;
            }
            set {
                this.subsidBoughtField = value;
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
        public SearchBooleanField taxable {
            get {
                return this.taxableField;
            }
            set {
                this.taxableField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField terms {
            get {
                return this.termsField;
            }
            set {
                this.termsField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField territory {
            get {
                return this.territoryField;
            }
            set {
                this.territoryField = value;
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
        public SearchDoubleField unbilledOrders {
            get {
                return this.unbilledOrdersField;
            }
            set {
                this.unbilledOrdersField = value;
            }
        }

        /// <remarks/>
        public SearchStringField url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
            }
        }

        /// <remarks/>
        public SearchStringField vatRegNumber {
            get {
                return this.vatRegNumberField;
            }
            set {
                this.vatRegNumberField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField webLead {
            get {
                return this.webLeadField;
            }
            set {
                this.webLeadField = value;
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