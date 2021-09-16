namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class OtherChargeSaleItem : Record {

        private System.DateTime createdDateField;

        private bool createdDateFieldSpecified;

        private System.DateTime lastModifiedDateField;

        private bool lastModifiedDateFieldSpecified;

        private string salesDescriptionField;

        private bool includeChildrenField;

        private bool includeChildrenFieldSpecified;

        private RecordRef incomeAccountField;

        private bool isTaxableField;

        private bool isTaxableFieldSpecified;

        private ItemMatrixType matrixTypeField;

        private bool matrixTypeFieldSpecified;

        private RecordRef taxScheduleField;

        private ItemCostEstimateType costEstimateTypeField;

        private bool costEstimateTypeFieldSpecified;

        private double costEstimateField;

        private bool costEstimateFieldSpecified;

        private RecordRef unitsTypeField;

        private RecordRef saleUnitField;

        private RecordRef issueProductField;

        private string costEstimateUnitsField;

        private RecordRef billingScheduleField;

        private RecordRef deferredRevenueAccountField;

        private RecordRef revRecScheduleField;

        private long minimumQuantityField;

        private bool minimumQuantityFieldSpecified;

        private string minimumQuantityUnitsField;

        private bool enforceMinQtyInternallyField;

        private bool enforceMinQtyInternallyFieldSpecified;

        private long maximumQuantityField;

        private bool maximumQuantityFieldSpecified;

        private string softDescriptorField;

        private bool isFulfillableField;

        private bool isFulfillableFieldSpecified;

        private RecordRef costCategoryField;

        private bool pricesIncludeTaxField;

        private bool pricesIncludeTaxFieldSpecified;

        private RecordRef quantityPricingScheduleField;

        private bool useMarginalRatesField;

        private bool useMarginalRatesFieldSpecified;

        private ItemOverallQuantityPricingType overallQuantityPricingTypeField;

        private bool overallQuantityPricingTypeFieldSpecified;

        private RecordRef pricingGroupField;

        private RecordRef customFormField;

        private string itemIdField;

        private string upcCodeField;

        private string displayNameField;

        private RecordRef parentField;

        private bool isOnlineField;

        private bool isOnlineFieldSpecified;

        private bool isGcoCompliantField;

        private bool isGcoCompliantFieldSpecified;

        private bool offerSupportField;

        private bool offerSupportFieldSpecified;

        private bool isInactiveField;

        private bool isInactiveFieldSpecified;

        private string matrixItemNameTemplateField;

        private bool availableToPartnersField;

        private bool availableToPartnersFieldSpecified;

        private RecordRef departmentField;

        private RecordRef classField;

        private RecordRef locationField;

        private double vsoePriceField;

        private bool vsoePriceFieldSpecified;

        private VsoeSopGroup vsoeSopGroupField;

        private bool vsoeSopGroupFieldSpecified;

        private VsoeDeferral vsoeDeferralField;

        private bool vsoeDeferralFieldSpecified;

        private VsoePermitDiscount vsoePermitDiscountField;

        private bool vsoePermitDiscountFieldSpecified;

        private bool vsoeDeliveredField;

        private bool vsoeDeliveredFieldSpecified;

        private RecordRef itemRevenueCategoryField;

        private bool deferRevRecField;

        private bool deferRevRecFieldSpecified;

        private RecordRef revenueRecognitionRuleField;

        private RecordRef revRecForecastRuleField;

        private RecordRef revenueAllocationGroupField;

        private RecordRef createRevenuePlansOnField;

        private bool directRevenuePostingField;

        private bool directRevenuePostingFieldSpecified;

        private bool contingentRevenueHandlingField;

        private bool contingentRevenueHandlingFieldSpecified;

        private RecordRef revReclassFXAccountField;

        private RecordRef[] subsidiaryListField;

        private RecordRef[] itemOptionsListField;

        private SelectCustomFieldRef[] matrixOptionListField;

        private PricingMatrix pricingMatrixField;

        private ItemAccountingBookDetailList accountingBookDetailListField;

        private RecordRef purchaseTaxCodeField;

        private double rateField;

        private bool rateFieldSpecified;

        private RecordRef salesTaxCodeField;

        private TranslationList translationsListField;

        private OtherChargeSaleItemHierarchyVersionsList hierarchyVersionsListField;

        private RecordRef consumptionUnitField;

        private RecordRef billQtyVarianceAcctField;

        private RecordRef billPriceVarianceAcctField;

        private RecordRef billExchRateVarianceAcctField;

        private CustomFieldRef[] customFieldListField;

        private string internalIdField;

        private string externalIdField;

        /// <remarks/>
        public System.DateTime createdDate {
            get {
                return this.createdDateField;
            }
            set {
                this.createdDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool createdDateSpecified {
            get {
                return this.createdDateFieldSpecified;
            }
            set {
                this.createdDateFieldSpecified = value;
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
        public string salesDescription {
            get {
                return this.salesDescriptionField;
            }
            set {
                this.salesDescriptionField = value;
            }
        }

        /// <remarks/>
        public bool includeChildren {
            get {
                return this.includeChildrenField;
            }
            set {
                this.includeChildrenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool includeChildrenSpecified {
            get {
                return this.includeChildrenFieldSpecified;
            }
            set {
                this.includeChildrenFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef incomeAccount {
            get {
                return this.incomeAccountField;
            }
            set {
                this.incomeAccountField = value;
            }
        }

        /// <remarks/>
        public bool isTaxable {
            get {
                return this.isTaxableField;
            }
            set {
                this.isTaxableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isTaxableSpecified {
            get {
                return this.isTaxableFieldSpecified;
            }
            set {
                this.isTaxableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ItemMatrixType matrixType {
            get {
                return this.matrixTypeField;
            }
            set {
                this.matrixTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool matrixTypeSpecified {
            get {
                return this.matrixTypeFieldSpecified;
            }
            set {
                this.matrixTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef taxSchedule {
            get {
                return this.taxScheduleField;
            }
            set {
                this.taxScheduleField = value;
            }
        }

        /// <remarks/>
        public ItemCostEstimateType costEstimateType {
            get {
                return this.costEstimateTypeField;
            }
            set {
                this.costEstimateTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool costEstimateTypeSpecified {
            get {
                return this.costEstimateTypeFieldSpecified;
            }
            set {
                this.costEstimateTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double costEstimate {
            get {
                return this.costEstimateField;
            }
            set {
                this.costEstimateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool costEstimateSpecified {
            get {
                return this.costEstimateFieldSpecified;
            }
            set {
                this.costEstimateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef unitsType {
            get {
                return this.unitsTypeField;
            }
            set {
                this.unitsTypeField = value;
            }
        }

        /// <remarks/>
        public RecordRef saleUnit {
            get {
                return this.saleUnitField;
            }
            set {
                this.saleUnitField = value;
            }
        }

        /// <remarks/>
        public RecordRef issueProduct {
            get {
                return this.issueProductField;
            }
            set {
                this.issueProductField = value;
            }
        }

        /// <remarks/>
        public string costEstimateUnits {
            get {
                return this.costEstimateUnitsField;
            }
            set {
                this.costEstimateUnitsField = value;
            }
        }

        /// <remarks/>
        public RecordRef billingSchedule {
            get {
                return this.billingScheduleField;
            }
            set {
                this.billingScheduleField = value;
            }
        }

        /// <remarks/>
        public RecordRef deferredRevenueAccount {
            get {
                return this.deferredRevenueAccountField;
            }
            set {
                this.deferredRevenueAccountField = value;
            }
        }

        /// <remarks/>
        public RecordRef revRecSchedule {
            get {
                return this.revRecScheduleField;
            }
            set {
                this.revRecScheduleField = value;
            }
        }

        /// <remarks/>
        public long minimumQuantity {
            get {
                return this.minimumQuantityField;
            }
            set {
                this.minimumQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool minimumQuantitySpecified {
            get {
                return this.minimumQuantityFieldSpecified;
            }
            set {
                this.minimumQuantityFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string minimumQuantityUnits {
            get {
                return this.minimumQuantityUnitsField;
            }
            set {
                this.minimumQuantityUnitsField = value;
            }
        }

        /// <remarks/>
        public bool enforceMinQtyInternally {
            get {
                return this.enforceMinQtyInternallyField;
            }
            set {
                this.enforceMinQtyInternallyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool enforceMinQtyInternallySpecified {
            get {
                return this.enforceMinQtyInternallyFieldSpecified;
            }
            set {
                this.enforceMinQtyInternallyFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long maximumQuantity {
            get {
                return this.maximumQuantityField;
            }
            set {
                this.maximumQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maximumQuantitySpecified {
            get {
                return this.maximumQuantityFieldSpecified;
            }
            set {
                this.maximumQuantityFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string softDescriptor {
            get {
                return this.softDescriptorField;
            }
            set {
                this.softDescriptorField = value;
            }
        }

        /// <remarks/>
        public bool isFulfillable {
            get {
                return this.isFulfillableField;
            }
            set {
                this.isFulfillableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isFulfillableSpecified {
            get {
                return this.isFulfillableFieldSpecified;
            }
            set {
                this.isFulfillableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef costCategory {
            get {
                return this.costCategoryField;
            }
            set {
                this.costCategoryField = value;
            }
        }

        /// <remarks/>
        public bool pricesIncludeTax {
            get {
                return this.pricesIncludeTaxField;
            }
            set {
                this.pricesIncludeTaxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pricesIncludeTaxSpecified {
            get {
                return this.pricesIncludeTaxFieldSpecified;
            }
            set {
                this.pricesIncludeTaxFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef quantityPricingSchedule {
            get {
                return this.quantityPricingScheduleField;
            }
            set {
                this.quantityPricingScheduleField = value;
            }
        }

        /// <remarks/>
        public bool useMarginalRates {
            get {
                return this.useMarginalRatesField;
            }
            set {
                this.useMarginalRatesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool useMarginalRatesSpecified {
            get {
                return this.useMarginalRatesFieldSpecified;
            }
            set {
                this.useMarginalRatesFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ItemOverallQuantityPricingType overallQuantityPricingType {
            get {
                return this.overallQuantityPricingTypeField;
            }
            set {
                this.overallQuantityPricingTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool overallQuantityPricingTypeSpecified {
            get {
                return this.overallQuantityPricingTypeFieldSpecified;
            }
            set {
                this.overallQuantityPricingTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef pricingGroup {
            get {
                return this.pricingGroupField;
            }
            set {
                this.pricingGroupField = value;
            }
        }

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
        public string itemId {
            get {
                return this.itemIdField;
            }
            set {
                this.itemIdField = value;
            }
        }

        /// <remarks/>
        public string upcCode {
            get {
                return this.upcCodeField;
            }
            set {
                this.upcCodeField = value;
            }
        }

        /// <remarks/>
        public string displayName {
            get {
                return this.displayNameField;
            }
            set {
                this.displayNameField = value;
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
        public bool isOnline {
            get {
                return this.isOnlineField;
            }
            set {
                this.isOnlineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isOnlineSpecified {
            get {
                return this.isOnlineFieldSpecified;
            }
            set {
                this.isOnlineFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isGcoCompliant {
            get {
                return this.isGcoCompliantField;
            }
            set {
                this.isGcoCompliantField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isGcoCompliantSpecified {
            get {
                return this.isGcoCompliantFieldSpecified;
            }
            set {
                this.isGcoCompliantFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool offerSupport {
            get {
                return this.offerSupportField;
            }
            set {
                this.offerSupportField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool offerSupportSpecified {
            get {
                return this.offerSupportFieldSpecified;
            }
            set {
                this.offerSupportFieldSpecified = value;
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
        public string matrixItemNameTemplate {
            get {
                return this.matrixItemNameTemplateField;
            }
            set {
                this.matrixItemNameTemplateField = value;
            }
        }

        /// <remarks/>
        public bool availableToPartners {
            get {
                return this.availableToPartnersField;
            }
            set {
                this.availableToPartnersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool availableToPartnersSpecified {
            get {
                return this.availableToPartnersFieldSpecified;
            }
            set {
                this.availableToPartnersFieldSpecified = value;
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
        public double vsoePrice {
            get {
                return this.vsoePriceField;
            }
            set {
                this.vsoePriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool vsoePriceSpecified {
            get {
                return this.vsoePriceFieldSpecified;
            }
            set {
                this.vsoePriceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public VsoeSopGroup vsoeSopGroup {
            get {
                return this.vsoeSopGroupField;
            }
            set {
                this.vsoeSopGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool vsoeSopGroupSpecified {
            get {
                return this.vsoeSopGroupFieldSpecified;
            }
            set {
                this.vsoeSopGroupFieldSpecified = value;
            }
        }

        /// <remarks/>
        public VsoeDeferral vsoeDeferral {
            get {
                return this.vsoeDeferralField;
            }
            set {
                this.vsoeDeferralField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool vsoeDeferralSpecified {
            get {
                return this.vsoeDeferralFieldSpecified;
            }
            set {
                this.vsoeDeferralFieldSpecified = value;
            }
        }

        /// <remarks/>
        public VsoePermitDiscount vsoePermitDiscount {
            get {
                return this.vsoePermitDiscountField;
            }
            set {
                this.vsoePermitDiscountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool vsoePermitDiscountSpecified {
            get {
                return this.vsoePermitDiscountFieldSpecified;
            }
            set {
                this.vsoePermitDiscountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool vsoeDelivered {
            get {
                return this.vsoeDeliveredField;
            }
            set {
                this.vsoeDeliveredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool vsoeDeliveredSpecified {
            get {
                return this.vsoeDeliveredFieldSpecified;
            }
            set {
                this.vsoeDeliveredFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef itemRevenueCategory {
            get {
                return this.itemRevenueCategoryField;
            }
            set {
                this.itemRevenueCategoryField = value;
            }
        }

        /// <remarks/>
        public bool deferRevRec {
            get {
                return this.deferRevRecField;
            }
            set {
                this.deferRevRecField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool deferRevRecSpecified {
            get {
                return this.deferRevRecFieldSpecified;
            }
            set {
                this.deferRevRecFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef revenueRecognitionRule {
            get {
                return this.revenueRecognitionRuleField;
            }
            set {
                this.revenueRecognitionRuleField = value;
            }
        }

        /// <remarks/>
        public RecordRef revRecForecastRule {
            get {
                return this.revRecForecastRuleField;
            }
            set {
                this.revRecForecastRuleField = value;
            }
        }

        /// <remarks/>
        public RecordRef revenueAllocationGroup {
            get {
                return this.revenueAllocationGroupField;
            }
            set {
                this.revenueAllocationGroupField = value;
            }
        }

        /// <remarks/>
        public RecordRef createRevenuePlansOn {
            get {
                return this.createRevenuePlansOnField;
            }
            set {
                this.createRevenuePlansOnField = value;
            }
        }

        /// <remarks/>
        public bool directRevenuePosting {
            get {
                return this.directRevenuePostingField;
            }
            set {
                this.directRevenuePostingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool directRevenuePostingSpecified {
            get {
                return this.directRevenuePostingFieldSpecified;
            }
            set {
                this.directRevenuePostingFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool contingentRevenueHandling {
            get {
                return this.contingentRevenueHandlingField;
            }
            set {
                this.contingentRevenueHandlingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool contingentRevenueHandlingSpecified {
            get {
                return this.contingentRevenueHandlingFieldSpecified;
            }
            set {
                this.contingentRevenueHandlingFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef revReclassFXAccount {
            get {
                return this.revReclassFXAccountField;
            }
            set {
                this.revReclassFXAccountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recordRef", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public RecordRef[] subsidiaryList {
            get {
                return this.subsidiaryListField;
            }
            set {
                this.subsidiaryListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("itemOptions", IsNullable=false)]
        public RecordRef[] itemOptionsList {
            get {
                return this.itemOptionsListField;
            }
            set {
                this.itemOptionsListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("matrixOption", IsNullable=false)]
        public SelectCustomFieldRef[] matrixOptionList {
            get {
                return this.matrixOptionListField;
            }
            set {
                this.matrixOptionListField = value;
            }
        }

        /// <remarks/>
        public PricingMatrix pricingMatrix {
            get {
                return this.pricingMatrixField;
            }
            set {
                this.pricingMatrixField = value;
            }
        }

        /// <remarks/>
        public ItemAccountingBookDetailList accountingBookDetailList {
            get {
                return this.accountingBookDetailListField;
            }
            set {
                this.accountingBookDetailListField = value;
            }
        }

        /// <remarks/>
        public RecordRef purchaseTaxCode {
            get {
                return this.purchaseTaxCodeField;
            }
            set {
                this.purchaseTaxCodeField = value;
            }
        }

        /// <remarks/>
        public double rate {
            get {
                return this.rateField;
            }
            set {
                this.rateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rateSpecified {
            get {
                return this.rateFieldSpecified;
            }
            set {
                this.rateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef salesTaxCode {
            get {
                return this.salesTaxCodeField;
            }
            set {
                this.salesTaxCodeField = value;
            }
        }

        /// <remarks/>
        public TranslationList translationsList {
            get {
                return this.translationsListField;
            }
            set {
                this.translationsListField = value;
            }
        }

        /// <remarks/>
        public OtherChargeSaleItemHierarchyVersionsList hierarchyVersionsList {
            get {
                return this.hierarchyVersionsListField;
            }
            set {
                this.hierarchyVersionsListField = value;
            }
        }

        /// <remarks/>
        public RecordRef consumptionUnit {
            get {
                return this.consumptionUnitField;
            }
            set {
                this.consumptionUnitField = value;
            }
        }

        /// <remarks/>
        public RecordRef billQtyVarianceAcct {
            get {
                return this.billQtyVarianceAcctField;
            }
            set {
                this.billQtyVarianceAcctField = value;
            }
        }

        /// <remarks/>
        public RecordRef billPriceVarianceAcct {
            get {
                return this.billPriceVarianceAcctField;
            }
            set {
                this.billPriceVarianceAcctField = value;
            }
        }

        /// <remarks/>
        public RecordRef billExchRateVarianceAcct {
            get {
                return this.billExchRateVarianceAcctField;
            }
            set {
                this.billExchRateVarianceAcctField = value;
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