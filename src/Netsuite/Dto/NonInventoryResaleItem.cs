using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class NonInventoryResaleItem : Record {

        private System.DateTime createdDateField;

        private bool createdDateFieldSpecified;

        private System.DateTime lastModifiedDateField;

        private bool lastModifiedDateFieldSpecified;

        private string purchaseDescriptionField;

        private bool copyDescriptionField;

        private bool copyDescriptionFieldSpecified;

        private double costField;

        private bool costFieldSpecified;

        private string costUnitsField;

        private RecordRef expenseAccountField;

        private RecordRef intercoExpenseAccountField;

        private string salesDescriptionField;

        private bool includeChildrenField;

        private bool includeChildrenFieldSpecified;

        private RecordRef incomeAccountField;

        private RecordRef intercoIncomeAccountField;

        private bool isTaxableField;

        private bool isTaxableFieldSpecified;

        private ItemMatrixType matrixTypeField;

        private bool matrixTypeFieldSpecified;

        private RecordRef taxScheduleField;

        private RecordRef dropshipExpenseAccountField;

        private bool deferRevRecField;

        private bool deferRevRecFieldSpecified;

        private RecordRef revenueRecognitionRuleField;

        private RecordRef revRecForecastRuleField;

        private RecordRef revenueAllocationGroupField;

        private RecordRef createRevenuePlansOnField;

        private bool directRevenuePostingField;

        private bool directRevenuePostingFieldSpecified;

        private bool isDropShipItemField;

        private bool isDropShipItemFieldSpecified;

        private bool isSpecialOrderItemField;

        private bool isSpecialOrderItemFieldSpecified;

        private double shippingCostField;

        private bool shippingCostFieldSpecified;

        private string shippingCostUnitsField;

        private double handlingCostField;

        private bool handlingCostFieldSpecified;

        private string handlingCostUnitsField;

        private ItemCostEstimateType costEstimateTypeField;

        private bool costEstimateTypeFieldSpecified;

        private double costEstimateField;

        private bool costEstimateFieldSpecified;

        private double weightField;

        private bool weightFieldSpecified;

        private ItemWeightUnit weightUnitField;

        private bool weightUnitFieldSpecified;

        private string weightUnitsField;

        private string costEstimateUnitsField;

        private RecordRef unitsTypeField;

        private RecordRef purchaseUnitField;

        private RecordRef saleUnitField;

        private RecordRef issueProductField;

        private RecordRef billingScheduleField;

        private RecordRef deferredRevenueAccountField;

        private RecordRef revRecScheduleField;

        private RecordRef deferralAccountField;

        private RecordRef amortizationTemplateField;

        private string residualField;

        private long amortizationPeriodField;

        private bool amortizationPeriodFieldSpecified;

        private string stockDescriptionField;

        private bool producerField;

        private bool producerFieldSpecified;

        private string manufacturerField;

        private string mpnField;

        private bool multManufactureAddrField;

        private bool multManufactureAddrFieldSpecified;

        private string manufacturerAddr1Field;

        private string manufacturerCityField;

        private string manufacturerStateField;

        private string manufacturerZipField;

        private Country countryOfManufactureField;

        private bool countryOfManufactureFieldSpecified;

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

        private string manufacturerTaxIdField;

        private string scheduleBNumberField;

        private long scheduleBQuantityField;

        private bool scheduleBQuantityFieldSpecified;

        private ScheduleBCode scheduleBCodeField;

        private bool scheduleBCodeFieldSpecified;

        private string manufacturerTariffField;

        private ItemPreferenceCriterion preferenceCriterionField;

        private bool preferenceCriterionFieldSpecified;

        private long minimumQuantityField;

        private bool minimumQuantityFieldSpecified;

        private bool enforceMinQtyInternallyField;

        private bool enforceMinQtyInternallyFieldSpecified;

        private long maximumQuantityField;

        private bool maximumQuantityFieldSpecified;

        private string softDescriptorField;

        private RecordRef shipPackageField;

        private bool shipIndividuallyField;

        private bool shipIndividuallyFieldSpecified;

        private bool isFulfillableField;

        private bool isFulfillableFieldSpecified;

        private bool generateAccrualsField;

        private bool generateAccrualsFieldSpecified;

        private RecordRef costCategoryField;

        private bool pricesIncludeTaxField;

        private bool pricesIncludeTaxFieldSpecified;

        private RecordRef quantityPricingScheduleField;

        private bool useMarginalRatesField;

        private bool useMarginalRatesFieldSpecified;

        private ItemOverallQuantityPricingType overallQuantityPricingTypeField;

        private bool overallQuantityPricingTypeFieldSpecified;

        private RecordRef pricingGroupField;

        private string minimumQuantityUnitsField;

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

        private string storeDisplayNameField;

        private RecordRef storeDisplayThumbnailField;

        private RecordRef storeDisplayImageField;

        private string storeDescriptionField;

        private string storeDetailedDescriptionField;

        private RecordRef storeItemTemplateField;

        private string pageTitleField;

        private string metaTagHtmlField;

        private bool excludeFromSitemapField;

        private bool excludeFromSitemapFieldSpecified;

        private SitemapPriority sitemapPriorityField;

        private bool sitemapPriorityFieldSpecified;

        private string searchKeywordsField;

        private bool isDonationItemField;

        private bool isDonationItemFieldSpecified;

        private bool showDefaultDonationAmountField;

        private bool showDefaultDonationAmountFieldSpecified;

        private double maxDonationAmountField;

        private bool maxDonationAmountFieldSpecified;

        private bool dontShowPriceField;

        private bool dontShowPriceFieldSpecified;

        private string noPriceMessageField;

        private string outOfStockMessageField;

        private bool onSpecialField;

        private bool onSpecialFieldSpecified;

        private ItemOutOfStockBehavior outOfStockBehaviorField;

        private bool outOfStockBehaviorFieldSpecified;

        private string relatedItemsDescriptionField;

        private string specialsDescriptionField;

        private string featuredDescriptionField;

        private string shoppingDotComCategoryField;

        private long shopzillaCategoryIdField;

        private bool shopzillaCategoryIdFieldSpecified;

        private string nexTagCategoryField;

        private ItemProductFeed[] productFeedListField;

        private string urlComponentField;

        private RecordRef customFormField;

        private string itemIdField;

        private string upcCodeField;

        private string displayNameField;

        private string vendorNameField;

        private RecordRef parentField;

        private bool isOnlineField;

        private bool isOnlineFieldSpecified;

        private bool isHazmatItemField;

        private bool isHazmatItemFieldSpecified;

        private string hazmatIdField;

        private string hazmatShippingNameField;

        private string hazmatHazardClassField;

        private HazmatPackingGroup hazmatPackingGroupField;

        private bool hazmatPackingGroupFieldSpecified;

        private string hazmatItemUnitsField;

        private double hazmatItemUnitsQtyField;

        private bool hazmatItemUnitsQtyFieldSpecified;

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

        private RecordRef defaultItemShipMethodField;

        private ShippingCarrier itemCarrierField;

        private bool itemCarrierFieldSpecified;

        private RecordRef[] itemShipMethodListField;

        private RecordRef[] subsidiaryListField;

        private string currencyField;

        private RecordRef[] itemOptionsListField;

        private SelectCustomFieldRef[] matrixOptionListField;

        private ItemVendorList itemVendorListField;

        private PricingMatrix pricingMatrixField;

        private ItemAccountingBookDetailList accountingBookDetailListField;

        private RecordRef purchaseTaxCodeField;

        private double rateField;

        private bool rateFieldSpecified;

        private RecordRef salesTaxCodeField;

        private SiteCategoryList siteCategoryListField;

        private TranslationList translationsListField;

        private RecordRef vendorField;

        private PresentationItemList presentationItemListField;

        private NonInventoryResaleItemHierarchyVersionsList hierarchyVersionsListField;

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
        public string purchaseDescription {
            get {
                return this.purchaseDescriptionField;
            }
            set {
                this.purchaseDescriptionField = value;
            }
        }

        /// <remarks/>
        public bool copyDescription {
            get {
                return this.copyDescriptionField;
            }
            set {
                this.copyDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool copyDescriptionSpecified {
            get {
                return this.copyDescriptionFieldSpecified;
            }
            set {
                this.copyDescriptionFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double cost {
            get {
                return this.costField;
            }
            set {
                this.costField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool costSpecified {
            get {
                return this.costFieldSpecified;
            }
            set {
                this.costFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string costUnits {
            get {
                return this.costUnitsField;
            }
            set {
                this.costUnitsField = value;
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
        public RecordRef intercoExpenseAccount {
            get {
                return this.intercoExpenseAccountField;
            }
            set {
                this.intercoExpenseAccountField = value;
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
        public RecordRef intercoIncomeAccount {
            get {
                return this.intercoIncomeAccountField;
            }
            set {
                this.intercoIncomeAccountField = value;
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
        public RecordRef dropshipExpenseAccount {
            get {
                return this.dropshipExpenseAccountField;
            }
            set {
                this.dropshipExpenseAccountField = value;
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
        public bool isDropShipItem {
            get {
                return this.isDropShipItemField;
            }
            set {
                this.isDropShipItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isDropShipItemSpecified {
            get {
                return this.isDropShipItemFieldSpecified;
            }
            set {
                this.isDropShipItemFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isSpecialOrderItem {
            get {
                return this.isSpecialOrderItemField;
            }
            set {
                this.isSpecialOrderItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isSpecialOrderItemSpecified {
            get {
                return this.isSpecialOrderItemFieldSpecified;
            }
            set {
                this.isSpecialOrderItemFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double shippingCost {
            get {
                return this.shippingCostField;
            }
            set {
                this.shippingCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shippingCostSpecified {
            get {
                return this.shippingCostFieldSpecified;
            }
            set {
                this.shippingCostFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string shippingCostUnits {
            get {
                return this.shippingCostUnitsField;
            }
            set {
                this.shippingCostUnitsField = value;
            }
        }

        /// <remarks/>
        public double handlingCost {
            get {
                return this.handlingCostField;
            }
            set {
                this.handlingCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool handlingCostSpecified {
            get {
                return this.handlingCostFieldSpecified;
            }
            set {
                this.handlingCostFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string handlingCostUnits {
            get {
                return this.handlingCostUnitsField;
            }
            set {
                this.handlingCostUnitsField = value;
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
        public double weight {
            get {
                return this.weightField;
            }
            set {
                this.weightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool weightSpecified {
            get {
                return this.weightFieldSpecified;
            }
            set {
                this.weightFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ItemWeightUnit weightUnit {
            get {
                return this.weightUnitField;
            }
            set {
                this.weightUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool weightUnitSpecified {
            get {
                return this.weightUnitFieldSpecified;
            }
            set {
                this.weightUnitFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string weightUnits {
            get {
                return this.weightUnitsField;
            }
            set {
                this.weightUnitsField = value;
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
        public RecordRef unitsType {
            get {
                return this.unitsTypeField;
            }
            set {
                this.unitsTypeField = value;
            }
        }

        /// <remarks/>
        public RecordRef purchaseUnit {
            get {
                return this.purchaseUnitField;
            }
            set {
                this.purchaseUnitField = value;
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
        public RecordRef deferralAccount {
            get {
                return this.deferralAccountField;
            }
            set {
                this.deferralAccountField = value;
            }
        }

        /// <remarks/>
        public RecordRef amortizationTemplate {
            get {
                return this.amortizationTemplateField;
            }
            set {
                this.amortizationTemplateField = value;
            }
        }

        /// <remarks/>
        public string residual {
            get {
                return this.residualField;
            }
            set {
                this.residualField = value;
            }
        }

        /// <remarks/>
        public long amortizationPeriod {
            get {
                return this.amortizationPeriodField;
            }
            set {
                this.amortizationPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool amortizationPeriodSpecified {
            get {
                return this.amortizationPeriodFieldSpecified;
            }
            set {
                this.amortizationPeriodFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string stockDescription {
            get {
                return this.stockDescriptionField;
            }
            set {
                this.stockDescriptionField = value;
            }
        }

        /// <remarks/>
        public bool producer {
            get {
                return this.producerField;
            }
            set {
                this.producerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool producerSpecified {
            get {
                return this.producerFieldSpecified;
            }
            set {
                this.producerFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string manufacturer {
            get {
                return this.manufacturerField;
            }
            set {
                this.manufacturerField = value;
            }
        }

        /// <remarks/>
        public string mpn {
            get {
                return this.mpnField;
            }
            set {
                this.mpnField = value;
            }
        }

        /// <remarks/>
        public bool multManufactureAddr {
            get {
                return this.multManufactureAddrField;
            }
            set {
                this.multManufactureAddrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool multManufactureAddrSpecified {
            get {
                return this.multManufactureAddrFieldSpecified;
            }
            set {
                this.multManufactureAddrFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string manufacturerAddr1 {
            get {
                return this.manufacturerAddr1Field;
            }
            set {
                this.manufacturerAddr1Field = value;
            }
        }

        /// <remarks/>
        public string manufacturerCity {
            get {
                return this.manufacturerCityField;
            }
            set {
                this.manufacturerCityField = value;
            }
        }

        /// <remarks/>
        public string manufacturerState {
            get {
                return this.manufacturerStateField;
            }
            set {
                this.manufacturerStateField = value;
            }
        }

        /// <remarks/>
        public string manufacturerZip {
            get {
                return this.manufacturerZipField;
            }
            set {
                this.manufacturerZipField = value;
            }
        }

        /// <remarks/>
        public Country countryOfManufacture {
            get {
                return this.countryOfManufactureField;
            }
            set {
                this.countryOfManufactureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool countryOfManufactureSpecified {
            get {
                return this.countryOfManufactureFieldSpecified;
            }
            set {
                this.countryOfManufactureFieldSpecified = value;
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
        public string manufacturerTaxId {
            get {
                return this.manufacturerTaxIdField;
            }
            set {
                this.manufacturerTaxIdField = value;
            }
        }

        /// <remarks/>
        public string scheduleBNumber {
            get {
                return this.scheduleBNumberField;
            }
            set {
                this.scheduleBNumberField = value;
            }
        }

        /// <remarks/>
        public long scheduleBQuantity {
            get {
                return this.scheduleBQuantityField;
            }
            set {
                this.scheduleBQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool scheduleBQuantitySpecified {
            get {
                return this.scheduleBQuantityFieldSpecified;
            }
            set {
                this.scheduleBQuantityFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ScheduleBCode scheduleBCode {
            get {
                return this.scheduleBCodeField;
            }
            set {
                this.scheduleBCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool scheduleBCodeSpecified {
            get {
                return this.scheduleBCodeFieldSpecified;
            }
            set {
                this.scheduleBCodeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string manufacturerTariff {
            get {
                return this.manufacturerTariffField;
            }
            set {
                this.manufacturerTariffField = value;
            }
        }

        /// <remarks/>
        public ItemPreferenceCriterion preferenceCriterion {
            get {
                return this.preferenceCriterionField;
            }
            set {
                this.preferenceCriterionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool preferenceCriterionSpecified {
            get {
                return this.preferenceCriterionFieldSpecified;
            }
            set {
                this.preferenceCriterionFieldSpecified = value;
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
        public RecordRef shipPackage {
            get {
                return this.shipPackageField;
            }
            set {
                this.shipPackageField = value;
            }
        }

        /// <remarks/>
        public bool shipIndividually {
            get {
                return this.shipIndividuallyField;
            }
            set {
                this.shipIndividuallyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shipIndividuallySpecified {
            get {
                return this.shipIndividuallyFieldSpecified;
            }
            set {
                this.shipIndividuallyFieldSpecified = value;
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
        public bool generateAccruals {
            get {
                return this.generateAccrualsField;
            }
            set {
                this.generateAccrualsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool generateAccrualsSpecified {
            get {
                return this.generateAccrualsFieldSpecified;
            }
            set {
                this.generateAccrualsFieldSpecified = value;
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
        public string minimumQuantityUnits {
            get {
                return this.minimumQuantityUnitsField;
            }
            set {
                this.minimumQuantityUnitsField = value;
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
        public string storeDisplayName {
            get {
                return this.storeDisplayNameField;
            }
            set {
                this.storeDisplayNameField = value;
            }
        }

        /// <remarks/>
        public RecordRef storeDisplayThumbnail {
            get {
                return this.storeDisplayThumbnailField;
            }
            set {
                this.storeDisplayThumbnailField = value;
            }
        }

        /// <remarks/>
        public RecordRef storeDisplayImage {
            get {
                return this.storeDisplayImageField;
            }
            set {
                this.storeDisplayImageField = value;
            }
        }

        /// <remarks/>
        public string storeDescription {
            get {
                return this.storeDescriptionField;
            }
            set {
                this.storeDescriptionField = value;
            }
        }

        /// <remarks/>
        public string storeDetailedDescription {
            get {
                return this.storeDetailedDescriptionField;
            }
            set {
                this.storeDetailedDescriptionField = value;
            }
        }

        /// <remarks/>
        public RecordRef storeItemTemplate {
            get {
                return this.storeItemTemplateField;
            }
            set {
                this.storeItemTemplateField = value;
            }
        }

        /// <remarks/>
        public string pageTitle {
            get {
                return this.pageTitleField;
            }
            set {
                this.pageTitleField = value;
            }
        }

        /// <remarks/>
        public string metaTagHtml {
            get {
                return this.metaTagHtmlField;
            }
            set {
                this.metaTagHtmlField = value;
            }
        }

        /// <remarks/>
        public bool excludeFromSitemap {
            get {
                return this.excludeFromSitemapField;
            }
            set {
                this.excludeFromSitemapField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool excludeFromSitemapSpecified {
            get {
                return this.excludeFromSitemapFieldSpecified;
            }
            set {
                this.excludeFromSitemapFieldSpecified = value;
            }
        }

        /// <remarks/>
        public SitemapPriority sitemapPriority {
            get {
                return this.sitemapPriorityField;
            }
            set {
                this.sitemapPriorityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sitemapPrioritySpecified {
            get {
                return this.sitemapPriorityFieldSpecified;
            }
            set {
                this.sitemapPriorityFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string searchKeywords {
            get {
                return this.searchKeywordsField;
            }
            set {
                this.searchKeywordsField = value;
            }
        }

        /// <remarks/>
        public bool isDonationItem {
            get {
                return this.isDonationItemField;
            }
            set {
                this.isDonationItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isDonationItemSpecified {
            get {
                return this.isDonationItemFieldSpecified;
            }
            set {
                this.isDonationItemFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool showDefaultDonationAmount {
            get {
                return this.showDefaultDonationAmountField;
            }
            set {
                this.showDefaultDonationAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool showDefaultDonationAmountSpecified {
            get {
                return this.showDefaultDonationAmountFieldSpecified;
            }
            set {
                this.showDefaultDonationAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double maxDonationAmount {
            get {
                return this.maxDonationAmountField;
            }
            set {
                this.maxDonationAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maxDonationAmountSpecified {
            get {
                return this.maxDonationAmountFieldSpecified;
            }
            set {
                this.maxDonationAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool dontShowPrice {
            get {
                return this.dontShowPriceField;
            }
            set {
                this.dontShowPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dontShowPriceSpecified {
            get {
                return this.dontShowPriceFieldSpecified;
            }
            set {
                this.dontShowPriceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string noPriceMessage {
            get {
                return this.noPriceMessageField;
            }
            set {
                this.noPriceMessageField = value;
            }
        }

        /// <remarks/>
        public string outOfStockMessage {
            get {
                return this.outOfStockMessageField;
            }
            set {
                this.outOfStockMessageField = value;
            }
        }

        /// <remarks/>
        public bool onSpecial {
            get {
                return this.onSpecialField;
            }
            set {
                this.onSpecialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool onSpecialSpecified {
            get {
                return this.onSpecialFieldSpecified;
            }
            set {
                this.onSpecialFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ItemOutOfStockBehavior outOfStockBehavior {
            get {
                return this.outOfStockBehaviorField;
            }
            set {
                this.outOfStockBehaviorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool outOfStockBehaviorSpecified {
            get {
                return this.outOfStockBehaviorFieldSpecified;
            }
            set {
                this.outOfStockBehaviorFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string relatedItemsDescription {
            get {
                return this.relatedItemsDescriptionField;
            }
            set {
                this.relatedItemsDescriptionField = value;
            }
        }

        /// <remarks/>
        public string specialsDescription {
            get {
                return this.specialsDescriptionField;
            }
            set {
                this.specialsDescriptionField = value;
            }
        }

        /// <remarks/>
        public string featuredDescription {
            get {
                return this.featuredDescriptionField;
            }
            set {
                this.featuredDescriptionField = value;
            }
        }

        /// <remarks/>
        public string shoppingDotComCategory {
            get {
                return this.shoppingDotComCategoryField;
            }
            set {
                this.shoppingDotComCategoryField = value;
            }
        }

        /// <remarks/>
        public long shopzillaCategoryId {
            get {
                return this.shopzillaCategoryIdField;
            }
            set {
                this.shopzillaCategoryIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shopzillaCategoryIdSpecified {
            get {
                return this.shopzillaCategoryIdFieldSpecified;
            }
            set {
                this.shopzillaCategoryIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string nexTagCategory {
            get {
                return this.nexTagCategoryField;
            }
            set {
                this.nexTagCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("productFeed", IsNullable=false)]
        public ItemProductFeed[] productFeedList {
            get {
                return this.productFeedListField;
            }
            set {
                this.productFeedListField = value;
            }
        }

        /// <remarks/>
        public string urlComponent {
            get {
                return this.urlComponentField;
            }
            set {
                this.urlComponentField = value;
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
        public string vendorName {
            get {
                return this.vendorNameField;
            }
            set {
                this.vendorNameField = value;
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
        public bool isHazmatItem {
            get {
                return this.isHazmatItemField;
            }
            set {
                this.isHazmatItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isHazmatItemSpecified {
            get {
                return this.isHazmatItemFieldSpecified;
            }
            set {
                this.isHazmatItemFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string hazmatId {
            get {
                return this.hazmatIdField;
            }
            set {
                this.hazmatIdField = value;
            }
        }

        /// <remarks/>
        public string hazmatShippingName {
            get {
                return this.hazmatShippingNameField;
            }
            set {
                this.hazmatShippingNameField = value;
            }
        }

        /// <remarks/>
        public string hazmatHazardClass {
            get {
                return this.hazmatHazardClassField;
            }
            set {
                this.hazmatHazardClassField = value;
            }
        }

        /// <remarks/>
        public HazmatPackingGroup hazmatPackingGroup {
            get {
                return this.hazmatPackingGroupField;
            }
            set {
                this.hazmatPackingGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hazmatPackingGroupSpecified {
            get {
                return this.hazmatPackingGroupFieldSpecified;
            }
            set {
                this.hazmatPackingGroupFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string hazmatItemUnits {
            get {
                return this.hazmatItemUnitsField;
            }
            set {
                this.hazmatItemUnitsField = value;
            }
        }

        /// <remarks/>
        public double hazmatItemUnitsQty {
            get {
                return this.hazmatItemUnitsQtyField;
            }
            set {
                this.hazmatItemUnitsQtyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hazmatItemUnitsQtySpecified {
            get {
                return this.hazmatItemUnitsQtyFieldSpecified;
            }
            set {
                this.hazmatItemUnitsQtyFieldSpecified = value;
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
        public RecordRef defaultItemShipMethod {
            get {
                return this.defaultItemShipMethodField;
            }
            set {
                this.defaultItemShipMethodField = value;
            }
        }

        /// <remarks/>
        public ShippingCarrier itemCarrier {
            get {
                return this.itemCarrierField;
            }
            set {
                this.itemCarrierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itemCarrierSpecified {
            get {
                return this.itemCarrierFieldSpecified;
            }
            set {
                this.itemCarrierFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recordRef", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public RecordRef[] itemShipMethodList {
            get {
                return this.itemShipMethodListField;
            }
            set {
                this.itemShipMethodListField = value;
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
        public string currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
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
        public ItemVendorList itemVendorList {
            get {
                return this.itemVendorListField;
            }
            set {
                this.itemVendorListField = value;
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
        public SiteCategoryList siteCategoryList {
            get {
                return this.siteCategoryListField;
            }
            set {
                this.siteCategoryListField = value;
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
        public RecordRef vendor {
            get {
                return this.vendorField;
            }
            set {
                this.vendorField = value;
            }
        }

        /// <remarks/>
        public PresentationItemList presentationItemList {
            get {
                return this.presentationItemListField;
            }
            set {
                this.presentationItemListField = value;
            }
        }

        /// <remarks/>
        public NonInventoryResaleItemHierarchyVersionsList hierarchyVersionsList {
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