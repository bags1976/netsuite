namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class JobSearchRowBasic : SearchRowBasic {

        private SearchColumnStringField[] accountNumberField;

        private SearchColumnDoubleField[] actualTimeField;

        private SearchColumnStringField[] addressField;

        private SearchColumnStringField[] address1Field;

        private SearchColumnStringField[] address2Field;

        private SearchColumnStringField[] address3Field;

        private SearchColumnStringField[] addresseeField;

        private SearchColumnStringField[] addressInternalIdField;

        private SearchColumnStringField[] addressLabelField;

        private SearchColumnStringField[] addressPhoneField;

        private SearchColumnBooleanField[] allocatePayrollExpensesField;

        private SearchColumnBooleanField[] allowAllResourcesForTasksField;

        private SearchColumnBooleanField[] allowExpensesField;

        private SearchColumnBooleanField[] allowTimeField;

        private SearchColumnStringField[] altContactField;

        private SearchColumnStringField[] altEmailField;

        private SearchColumnStringField[] altNameField;

        private SearchColumnStringField[] altPhoneField;

        private SearchColumnStringField[] attentionField;

        private SearchColumnStringField[] billAddress1Field;

        private SearchColumnStringField[] billAddress2Field;

        private SearchColumnStringField[] billAddress3Field;

        private SearchColumnStringField[] billAddresseeField;

        private SearchColumnStringField[] billAttentionField;

        private SearchColumnStringField[] billCityField;

        private SearchColumnEnumSelectField[] billCountryField;

        private SearchColumnStringField[] billCountryCodeField;

        private SearchColumnSelectField[] billingRateCardField;

        private SearchColumnSelectField[] billingScheduleField;

        private SearchColumnStringField[] billPhoneField;

        private SearchColumnStringField[] billStateField;

        private SearchColumnStringField[] billZipCodeField;

        private SearchColumnDateField[] calculatedEndDateField;

        private SearchColumnDateField[] calculatedEndDateBaselineField;

        private SearchColumnDateField[] calculatedStartDateField;

        private SearchColumnSelectField[] categoryField;

        private SearchColumnStringField[] cityField;

        private SearchColumnStringField[] commentsField;

        private SearchColumnStringField[] companyNameField;

        private SearchColumnStringField[] contactField;

        private SearchColumnEnumSelectField[] countryField;

        private SearchColumnStringField[] countryCodeField;

        private SearchColumnSelectField[] customerField;

        private SearchColumnDateField[] dateCreatedField;

        private SearchColumnStringField[] defaultTaxRegField;

        private SearchColumnStringField[] emailField;

        private SearchColumnDateField[] endDateField;

        private SearchColumnStringField[] entityIdField;

        private SearchColumnLongField[] entityNumberField;

        private SearchColumnSelectField[] entityStatusField;

        private SearchColumnDoubleField[] estimatedCostField;

        private SearchColumnDoubleField[] estimatedGrossProfitField;

        private SearchColumnDoubleField[] estimatedGrossProfitPercentField;

        private SearchColumnDoubleField[] estimatedLaborCostField;

        private SearchColumnDoubleField[] estimatedLaborCostBaselineField;

        private SearchColumnDoubleField[] estimatedLaborRevenueField;

        private SearchColumnDoubleField[] estimatedRevenueField;

        private SearchColumnDoubleField[] estimatedTimeField;

        private SearchColumnDoubleField[] estimatedTimeOverrideField;

        private SearchColumnDoubleField[] estimatedTimeOverrideBaselineField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnStringField[] faxField;

        private SearchColumnEnumSelectField[] globalSubscriptionStatusField;

        private SearchColumnSelectField[] imageField;

        private SearchColumnBooleanField[] includeCrmTasksInTotalsField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnBooleanField[] isDefaultBillingField;

        private SearchColumnBooleanField[] isDefaultShippingField;

        private SearchColumnBooleanField[] isExemptTimeField;

        private SearchColumnBooleanField[] isInactiveField;

        private SearchColumnBooleanField[] isProductiveTimeField;

        private SearchColumnBooleanField[] isUtilizedTimeField;

        private SearchColumnEnumSelectField[] jobBillingTypeField;

        private SearchColumnSelectField[] jobItemField;

        private SearchColumnDoubleField[] jobPriceField;

        private SearchColumnSelectField[] jobResourceField;

        private SearchColumnSelectField[] jobResourceRoleField;

        private SearchColumnEnumSelectField[] languageField;

        private SearchColumnDateField[] lastBaselineDateField;

        private SearchColumnDateField[] lastModifiedDateField;

        private SearchColumnEnumSelectField[] levelField;

        private SearchColumnBooleanField[] limitTimeToAssigneesField;

        private SearchColumnBooleanField[] materializeTimeField;

        private SearchColumnDoubleField[] percentCompleteField;

        private SearchColumnDoubleField[] percentTimeCompleteField;

        private SearchColumnEnumSelectField[] permissionField;

        private SearchColumnStringField[] phoneField;

        private SearchColumnStringField[] phoneticNameField;

        private SearchColumnDoubleField[] plannedWorkField;

        private SearchColumnDoubleField[] plannedWorkBaselineField;

        private SearchColumnDateField[] projectedEndDateField;

        private SearchColumnDateField[] projectedEndDateBaselineField;

        private SearchColumnSelectField[] projectExpenseTypeField;

        private SearchColumnSelectField[] projectManagerField;

        private SearchColumnSelectField[] revRecForecastRuleField;

        private SearchColumnDateField[] scheduledEndDateField;

        private SearchColumnEnumSelectField[] schedulingMethodField;

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

        private SearchColumnBooleanField[] sourceServiceItemFromRateCardField;

        private SearchColumnDateField[] startDateField;

        private SearchColumnDateField[] startDateBaselineField;

        private SearchColumnStringField[] stateField;

        private SearchColumnSelectField[] subscriptionField;

        private SearchColumnDateField[] subscriptionDateField;

        private SearchColumnBooleanField[] subscriptionStatusField;

        private SearchColumnSelectField[] subsidiaryField;

        private SearchColumnSelectField[] timeApprovalField;

        private SearchColumnDoubleField[] timeRemainingField;

        private SearchColumnBooleanField[] usePercentCompleteOverrideField;

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
        [System.Xml.Serialization.XmlElementAttribute("actualTime")]
        public SearchColumnDoubleField[] actualTime {
            get {
                return this.actualTimeField;
            }
            set {
                this.actualTimeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("allocatePayrollExpenses")]
        public SearchColumnBooleanField[] allocatePayrollExpenses {
            get {
                return this.allocatePayrollExpensesField;
            }
            set {
                this.allocatePayrollExpensesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("allowAllResourcesForTasks")]
        public SearchColumnBooleanField[] allowAllResourcesForTasks {
            get {
                return this.allowAllResourcesForTasksField;
            }
            set {
                this.allowAllResourcesForTasksField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("allowExpenses")]
        public SearchColumnBooleanField[] allowExpenses {
            get {
                return this.allowExpensesField;
            }
            set {
                this.allowExpensesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("allowTime")]
        public SearchColumnBooleanField[] allowTime {
            get {
                return this.allowTimeField;
            }
            set {
                this.allowTimeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("billingRateCard")]
        public SearchColumnSelectField[] billingRateCard {
            get {
                return this.billingRateCardField;
            }
            set {
                this.billingRateCardField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billingSchedule")]
        public SearchColumnSelectField[] billingSchedule {
            get {
                return this.billingScheduleField;
            }
            set {
                this.billingScheduleField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("calculatedEndDate")]
        public SearchColumnDateField[] calculatedEndDate {
            get {
                return this.calculatedEndDateField;
            }
            set {
                this.calculatedEndDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("calculatedEndDateBaseline")]
        public SearchColumnDateField[] calculatedEndDateBaseline {
            get {
                return this.calculatedEndDateBaselineField;
            }
            set {
                this.calculatedEndDateBaselineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("calculatedStartDate")]
        public SearchColumnDateField[] calculatedStartDate {
            get {
                return this.calculatedStartDateField;
            }
            set {
                this.calculatedStartDateField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("customer")]
        public SearchColumnSelectField[] customer {
            get {
                return this.customerField;
            }
            set {
                this.customerField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("estimatedCost")]
        public SearchColumnDoubleField[] estimatedCost {
            get {
                return this.estimatedCostField;
            }
            set {
                this.estimatedCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("estimatedGrossProfit")]
        public SearchColumnDoubleField[] estimatedGrossProfit {
            get {
                return this.estimatedGrossProfitField;
            }
            set {
                this.estimatedGrossProfitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("estimatedGrossProfitPercent")]
        public SearchColumnDoubleField[] estimatedGrossProfitPercent {
            get {
                return this.estimatedGrossProfitPercentField;
            }
            set {
                this.estimatedGrossProfitPercentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("estimatedLaborCost")]
        public SearchColumnDoubleField[] estimatedLaborCost {
            get {
                return this.estimatedLaborCostField;
            }
            set {
                this.estimatedLaborCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("estimatedLaborCostBaseline")]
        public SearchColumnDoubleField[] estimatedLaborCostBaseline {
            get {
                return this.estimatedLaborCostBaselineField;
            }
            set {
                this.estimatedLaborCostBaselineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("estimatedLaborRevenue")]
        public SearchColumnDoubleField[] estimatedLaborRevenue {
            get {
                return this.estimatedLaborRevenueField;
            }
            set {
                this.estimatedLaborRevenueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("estimatedRevenue")]
        public SearchColumnDoubleField[] estimatedRevenue {
            get {
                return this.estimatedRevenueField;
            }
            set {
                this.estimatedRevenueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("estimatedTime")]
        public SearchColumnDoubleField[] estimatedTime {
            get {
                return this.estimatedTimeField;
            }
            set {
                this.estimatedTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("estimatedTimeOverride")]
        public SearchColumnDoubleField[] estimatedTimeOverride {
            get {
                return this.estimatedTimeOverrideField;
            }
            set {
                this.estimatedTimeOverrideField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("estimatedTimeOverrideBaseline")]
        public SearchColumnDoubleField[] estimatedTimeOverrideBaseline {
            get {
                return this.estimatedTimeOverrideBaselineField;
            }
            set {
                this.estimatedTimeOverrideBaselineField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("includeCrmTasksInTotals")]
        public SearchColumnBooleanField[] includeCrmTasksInTotals {
            get {
                return this.includeCrmTasksInTotalsField;
            }
            set {
                this.includeCrmTasksInTotalsField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("isExemptTime")]
        public SearchColumnBooleanField[] isExemptTime {
            get {
                return this.isExemptTimeField;
            }
            set {
                this.isExemptTimeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("isProductiveTime")]
        public SearchColumnBooleanField[] isProductiveTime {
            get {
                return this.isProductiveTimeField;
            }
            set {
                this.isProductiveTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isUtilizedTime")]
        public SearchColumnBooleanField[] isUtilizedTime {
            get {
                return this.isUtilizedTimeField;
            }
            set {
                this.isUtilizedTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("jobBillingType")]
        public SearchColumnEnumSelectField[] jobBillingType {
            get {
                return this.jobBillingTypeField;
            }
            set {
                this.jobBillingTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("jobItem")]
        public SearchColumnSelectField[] jobItem {
            get {
                return this.jobItemField;
            }
            set {
                this.jobItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("jobPrice")]
        public SearchColumnDoubleField[] jobPrice {
            get {
                return this.jobPriceField;
            }
            set {
                this.jobPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("jobResource")]
        public SearchColumnSelectField[] jobResource {
            get {
                return this.jobResourceField;
            }
            set {
                this.jobResourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("jobResourceRole")]
        public SearchColumnSelectField[] jobResourceRole {
            get {
                return this.jobResourceRoleField;
            }
            set {
                this.jobResourceRoleField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("lastBaselineDate")]
        public SearchColumnDateField[] lastBaselineDate {
            get {
                return this.lastBaselineDateField;
            }
            set {
                this.lastBaselineDateField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("limitTimeToAssignees")]
        public SearchColumnBooleanField[] limitTimeToAssignees {
            get {
                return this.limitTimeToAssigneesField;
            }
            set {
                this.limitTimeToAssigneesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("materializeTime")]
        public SearchColumnBooleanField[] materializeTime {
            get {
                return this.materializeTimeField;
            }
            set {
                this.materializeTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("percentComplete")]
        public SearchColumnDoubleField[] percentComplete {
            get {
                return this.percentCompleteField;
            }
            set {
                this.percentCompleteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("percentTimeComplete")]
        public SearchColumnDoubleField[] percentTimeComplete {
            get {
                return this.percentTimeCompleteField;
            }
            set {
                this.percentTimeCompleteField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("plannedWork")]
        public SearchColumnDoubleField[] plannedWork {
            get {
                return this.plannedWorkField;
            }
            set {
                this.plannedWorkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("plannedWorkBaseline")]
        public SearchColumnDoubleField[] plannedWorkBaseline {
            get {
                return this.plannedWorkBaselineField;
            }
            set {
                this.plannedWorkBaselineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("projectedEndDate")]
        public SearchColumnDateField[] projectedEndDate {
            get {
                return this.projectedEndDateField;
            }
            set {
                this.projectedEndDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("projectedEndDateBaseline")]
        public SearchColumnDateField[] projectedEndDateBaseline {
            get {
                return this.projectedEndDateBaselineField;
            }
            set {
                this.projectedEndDateBaselineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("projectExpenseType")]
        public SearchColumnSelectField[] projectExpenseType {
            get {
                return this.projectExpenseTypeField;
            }
            set {
                this.projectExpenseTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("projectManager")]
        public SearchColumnSelectField[] projectManager {
            get {
                return this.projectManagerField;
            }
            set {
                this.projectManagerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("revRecForecastRule")]
        public SearchColumnSelectField[] revRecForecastRule {
            get {
                return this.revRecForecastRuleField;
            }
            set {
                this.revRecForecastRuleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("scheduledEndDate")]
        public SearchColumnDateField[] scheduledEndDate {
            get {
                return this.scheduledEndDateField;
            }
            set {
                this.scheduledEndDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("schedulingMethod")]
        public SearchColumnEnumSelectField[] schedulingMethod {
            get {
                return this.schedulingMethodField;
            }
            set {
                this.schedulingMethodField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("sourceServiceItemFromRateCard")]
        public SearchColumnBooleanField[] sourceServiceItemFromRateCard {
            get {
                return this.sourceServiceItemFromRateCardField;
            }
            set {
                this.sourceServiceItemFromRateCardField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("startDateBaseline")]
        public SearchColumnDateField[] startDateBaseline {
            get {
                return this.startDateBaselineField;
            }
            set {
                this.startDateBaselineField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("timeApproval")]
        public SearchColumnSelectField[] timeApproval {
            get {
                return this.timeApprovalField;
            }
            set {
                this.timeApprovalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("timeRemaining")]
        public SearchColumnDoubleField[] timeRemaining {
            get {
                return this.timeRemainingField;
            }
            set {
                this.timeRemainingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("usePercentCompleteOverride")]
        public SearchColumnBooleanField[] usePercentCompleteOverride {
            get {
                return this.usePercentCompleteOverrideField;
            }
            set {
                this.usePercentCompleteOverrideField = value;
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