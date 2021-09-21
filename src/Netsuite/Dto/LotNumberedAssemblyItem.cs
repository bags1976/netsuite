using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class LotNumberedAssemblyItem : Record {

        private System.DateTime createdDateField;

        private bool createdDateFieldSpecified;

        private System.DateTime lastModifiedDateField;

        private bool lastModifiedDateFieldSpecified;

        private RecordRef customFormField;

        private string itemIdField;

        private string upcCodeField;

        private string displayNameField;

        private string vendorNameField;

        private RecordRef parentField;

        private bool printItemsField;

        private bool printItemsFieldSpecified;

        private bool isOnlineField;

        private bool isOnlineFieldSpecified;

        private bool isGcoCompliantField;

        private bool isGcoCompliantFieldSpecified;

        private bool offerSupportField;

        private bool offerSupportFieldSpecified;

        private bool useComponentYieldField;

        private bool useComponentYieldFieldSpecified;

        private bool isInactiveField;

        private bool isInactiveFieldSpecified;

        private bool availableToPartnersField;

        private bool availableToPartnersFieldSpecified;

        private RecordRef[] subsidiaryListField;

        private RecordRef departmentField;

        private bool includeChildrenField;

        private bool includeChildrenFieldSpecified;

        private RecordRef classField;

        private RecordRef locationField;

        private RecordRef costCategoryField;

        private string descriptionField;

        private RecordRef cogsAccountField;

        private RecordRef vendorField;

        private RecordRef incomeAccountField;

        private RecordRef intercoIncomeAccountField;

        private RecordRef assetAccountField;

        private bool matchBillToReceiptField;

        private bool matchBillToReceiptFieldSpecified;

        private RecordRef billQtyVarianceAcctField;

        private RecordRef billPriceVarianceAcctField;

        private RecordRef billExchRateVarianceAcctField;

        private RecordRef gainLossAccountField;

        private RecordRef salesTaxCodeField;

        private RecordRef purchaseTaxCodeField;

        private RecordRef prodQtyVarianceAcctField;

        private RecordRef prodPriceVarianceAcctField;

        private RecordRef purchasePriceVarianceAcctField;

        private RecordRef wipVarianceAcctField;

        private RecordRef taxScheduleField;

        private RecordRef scrapAcctField;

        private double shippingCostField;

        private bool shippingCostFieldSpecified;

        private RecordRef wipAcctField;

        private double handlingCostField;

        private bool handlingCostFieldSpecified;

        private double weightField;

        private bool weightFieldSpecified;

        private ItemWeightUnit weightUnitField;

        private bool weightUnitFieldSpecified;

        private ItemCostingMethod costingMethodField;

        private bool costingMethodFieldSpecified;

        private bool isTaxableField;

        private bool isTaxableFieldSpecified;

        private string costingMethodDisplayField;

        private double rateField;

        private bool rateFieldSpecified;

        private RecordRef unitsTypeField;

        private RecordRef stockUnitField;

        private RecordRef purchaseUnitField;

        private RecordRef saleUnitField;

        private bool trackLandedCostField;

        private bool trackLandedCostFieldSpecified;

        private string matrixItemNameTemplateField;

        private RecordRef billingScheduleField;

        private RecordRef deferredRevenueAccountField;

        private RecordRef revRecScheduleField;

        private string stockDescriptionField;

        private bool producerField;

        private bool producerFieldSpecified;

        private string manufacturerField;

        private string mpnField;

        private bool multManufactureAddrField;

        private bool multManufactureAddrFieldSpecified;

        private string manufactureraddr1Field;

        private string manufacturerCityField;

        private string manufacturerStateField;

        private string manufacturerZipField;

        private Country countryOfManufactureField;

        private bool countryOfManufactureFieldSpecified;

        private AssemblyItemEffectiveBomControl effectiveBomControlField;

        private bool effectiveBomControlFieldSpecified;

        private string manufacturerTaxIdField;

        private string defaultRevisionField;

        private RecordRef defaultItemShipMethodField;

        private ShippingCarrier itemCarrierField;

        private bool itemCarrierFieldSpecified;

        private bool roundUpAsComponentField;

        private bool roundUpAsComponentFieldSpecified;

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

        private bool isDropShipItemField;

        private bool isDropShipItemFieldSpecified;

        private bool isPhantomField;

        private bool isPhantomFieldSpecified;

        private RecordRef[] itemShipMethodListField;

        private string scheduleBNumberField;

        private long scheduleBQuantityField;

        private bool scheduleBQuantityFieldSpecified;

        private RecordRef scheduleBCodeField;

        private string manufacturerTariffField;

        private ItemPreferenceCriterion preferenceCriterionField;

        private bool preferenceCriterionFieldSpecified;

        private RecordRef issueProductField;

        private long minimumQuantityField;

        private bool minimumQuantityFieldSpecified;

        private bool enforceMinQtyInternallyField;

        private bool enforceMinQtyInternallyFieldSpecified;

        private long maximumQuantityField;

        private bool maximumQuantityFieldSpecified;

        private RecordRef softDescriptorField;

        private bool isSpecialWorkOrderItemField;

        private bool isSpecialWorkOrderItemFieldSpecified;

        private bool pricesIncludeTaxField;

        private bool pricesIncludeTaxFieldSpecified;

        private RecordRef quantityPricingScheduleField;

        private bool buildEntireAssemblyField;

        private bool buildEntireAssemblyFieldSpecified;

        private double quantityOnHandField;

        private bool quantityOnHandFieldSpecified;

        private bool useMarginalRatesField;

        private bool useMarginalRatesFieldSpecified;

        private long reorderMultipleField;

        private bool reorderMultipleFieldSpecified;

        private double costField;

        private bool costFieldSpecified;

        private ItemCostEstimateType costEstimateTypeField;

        private bool costEstimateTypeFieldSpecified;

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

        private double costEstimateField;

        private bool costEstimateFieldSpecified;

        private double transferPriceField;

        private bool transferPriceFieldSpecified;

        private ItemOverallQuantityPricingType overallQuantityPricingTypeField;

        private bool overallQuantityPricingTypeFieldSpecified;

        private RecordRef pricingGroupField;

        private RecordRef intercoCogsAccountField;

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

        private RecordRef unbuildVarianceAccountField;

        private RecordRef revenueRecognitionRuleField;

        private RecordRef revRecForecastRuleField;

        private RecordRef revenueAllocationGroupField;

        private RecordRef createRevenuePlansOnField;

        private bool directRevenuePostingField;

        private bool directRevenuePostingFieldSpecified;

        private RecordRef dropshipExpenseAccountField;

        private RecordRef preferredLocationField;

        private bool isStorePickupAllowedField;

        private bool isStorePickupAllowedFieldSpecified;

        private double totalValueField;

        private bool totalValueFieldSpecified;

        private bool useBinsField;

        private bool useBinsFieldSpecified;

        private double averageCostField;

        private bool averageCostFieldSpecified;

        private double lastPurchasePriceField;

        private bool lastPurchasePriceFieldSpecified;

        private string purchaseDescriptionField;

        private long leadTimeField;

        private bool leadTimeFieldSpecified;

        private bool autoLeadTimeField;

        private bool autoLeadTimeFieldSpecified;

        private double buildTimeField;

        private bool buildTimeFieldSpecified;

        private double buildTimeLotSizeField;

        private bool buildTimeLotSizeFieldSpecified;

        private double fixedBuildTimeField;

        private bool fixedBuildTimeFieldSpecified;

        private RecordRef planningItemCategoryField;

        private double safetyStockLevelField;

        private bool safetyStockLevelFieldSpecified;

        private long safetyStockLevelDaysField;

        private bool safetyStockLevelDaysFieldSpecified;

        private bool seasonalDemandField;

        private bool seasonalDemandFieldSpecified;

        private string serialNumbersField;

        private double reorderPointField;

        private bool reorderPointFieldSpecified;

        private double preferredStockLevelField;

        private bool preferredStockLevelFieldSpecified;

        private System.DateTime expirationDateField;

        private bool expirationDateFieldSpecified;

        private System.DateTime lastInvtCountDateField;

        private bool lastInvtCountDateFieldSpecified;

        private System.DateTime nextInvtCountDateField;

        private bool nextInvtCountDateFieldSpecified;

        private long invtCountIntervalField;

        private bool invtCountIntervalFieldSpecified;

        private ItemInvtClassification invtClassificationField;

        private bool invtClassificationFieldSpecified;

        private double demandModifierField;

        private bool demandModifierFieldSpecified;

        private bool autoReorderPointField;

        private bool autoReorderPointFieldSpecified;

        private bool autoPreferredStockLevelField;

        private bool autoPreferredStockLevelFieldSpecified;

        private double preferredStockLevelDaysField;

        private bool preferredStockLevelDaysFieldSpecified;

        private bool shipIndividuallyField;

        private bool shipIndividuallyFieldSpecified;

        private RecordRef shipPackageField;

        private double defaultReturnCostField;

        private bool defaultReturnCostFieldSpecified;

        private RecordRef supplyReplenishmentMethodField;

        private RecordRef alternateDemandSourceItemField;

        private double fixedLotSizeField;

        private bool fixedLotSizeFieldSpecified;

        private RecordRef supplyTypeField;

        private long demandTimeFenceField;

        private bool demandTimeFenceFieldSpecified;

        private long supplyTimeFenceField;

        private bool supplyTimeFenceFieldSpecified;

        private long rescheduleInDaysField;

        private bool rescheduleInDaysFieldSpecified;

        private long rescheduleOutDaysField;

        private bool rescheduleOutDaysFieldSpecified;

        private RecordRef supplyLotSizingMethodField;

        private RecordRef demandSourceField;

        private double quantityCommittedField;

        private bool quantityCommittedFieldSpecified;

        private double quantityAvailableField;

        private bool quantityAvailableFieldSpecified;

        private double quantityBackOrderedField;

        private bool quantityBackOrderedFieldSpecified;

        private double quantityOnOrderField;

        private bool quantityOnOrderFieldSpecified;

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

        private string urlComponentField;

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

        private string shoppingDotComCategoryField;

        private ItemOutOfStockBehavior outOfStockBehaviorField;

        private bool outOfStockBehaviorFieldSpecified;

        private long shopzillaCategoryIdField;

        private bool shopzillaCategoryIdFieldSpecified;

        private string nexTagCategoryField;

        private ItemProductFeed[] productFeedListField;

        private string relatedItemsDescriptionField;

        private bool onSpecialField;

        private bool onSpecialFieldSpecified;

        private string specialsDescriptionField;

        private string featuredDescriptionField;

        private RecordRef[] itemOptionsListField;

        private RecordRef[] itemNumberOptionsListField;

        private ItemVendorList itemVendorListField;

        private PricingMatrix pricingMatrixField;

        private LotNumberedAssemblyItemBillOfMaterialsList billOfMaterialsListField;

        private ItemMemberList memberListField;

        private ItemAccountingBookDetailList accountingBookDetailListField;

        private LotNumberedInventoryItemLocationsList locationsListField;

        private SiteCategoryList siteCategoryListField;

        private InventoryItemBinNumberList binNumberListField;

        private LotNumberedInventoryItemNumbersList numbersListField;

        private TranslationList translationsListField;

        private PresentationItemList presentationItemListField;

        private LotNumberedAssemblyItemHierarchyVersionsList hierarchyVersionsListField;

        private long futureHorizonField;

        private bool futureHorizonFieldSpecified;

        private RecordRef consumptionUnitField;

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
        public bool printItems {
            get {
                return this.printItemsField;
            }
            set {
                this.printItemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printItemsSpecified {
            get {
                return this.printItemsFieldSpecified;
            }
            set {
                this.printItemsFieldSpecified = value;
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
        public bool useComponentYield {
            get {
                return this.useComponentYieldField;
            }
            set {
                this.useComponentYieldField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool useComponentYieldSpecified {
            get {
                return this.useComponentYieldFieldSpecified;
            }
            set {
                this.useComponentYieldFieldSpecified = value;
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
        public RecordRef department {
            get {
                return this.departmentField;
            }
            set {
                this.departmentField = value;
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
        public RecordRef costCategory {
            get {
                return this.costCategoryField;
            }
            set {
                this.costCategoryField = value;
            }
        }

        /// <remarks/>
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public RecordRef cogsAccount {
            get {
                return this.cogsAccountField;
            }
            set {
                this.cogsAccountField = value;
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
        public RecordRef assetAccount {
            get {
                return this.assetAccountField;
            }
            set {
                this.assetAccountField = value;
            }
        }

        /// <remarks/>
        public bool matchBillToReceipt {
            get {
                return this.matchBillToReceiptField;
            }
            set {
                this.matchBillToReceiptField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool matchBillToReceiptSpecified {
            get {
                return this.matchBillToReceiptFieldSpecified;
            }
            set {
                this.matchBillToReceiptFieldSpecified = value;
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
        public RecordRef gainLossAccount {
            get {
                return this.gainLossAccountField;
            }
            set {
                this.gainLossAccountField = value;
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
        public RecordRef purchaseTaxCode {
            get {
                return this.purchaseTaxCodeField;
            }
            set {
                this.purchaseTaxCodeField = value;
            }
        }

        /// <remarks/>
        public RecordRef prodQtyVarianceAcct {
            get {
                return this.prodQtyVarianceAcctField;
            }
            set {
                this.prodQtyVarianceAcctField = value;
            }
        }

        /// <remarks/>
        public RecordRef prodPriceVarianceAcct {
            get {
                return this.prodPriceVarianceAcctField;
            }
            set {
                this.prodPriceVarianceAcctField = value;
            }
        }

        /// <remarks/>
        public RecordRef purchasePriceVarianceAcct {
            get {
                return this.purchasePriceVarianceAcctField;
            }
            set {
                this.purchasePriceVarianceAcctField = value;
            }
        }

        /// <remarks/>
        public RecordRef wipVarianceAcct {
            get {
                return this.wipVarianceAcctField;
            }
            set {
                this.wipVarianceAcctField = value;
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
        public RecordRef scrapAcct {
            get {
                return this.scrapAcctField;
            }
            set {
                this.scrapAcctField = value;
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
        public RecordRef wipAcct {
            get {
                return this.wipAcctField;
            }
            set {
                this.wipAcctField = value;
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
        public ItemCostingMethod costingMethod {
            get {
                return this.costingMethodField;
            }
            set {
                this.costingMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool costingMethodSpecified {
            get {
                return this.costingMethodFieldSpecified;
            }
            set {
                this.costingMethodFieldSpecified = value;
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
        public string costingMethodDisplay {
            get {
                return this.costingMethodDisplayField;
            }
            set {
                this.costingMethodDisplayField = value;
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
        public RecordRef unitsType {
            get {
                return this.unitsTypeField;
            }
            set {
                this.unitsTypeField = value;
            }
        }

        /// <remarks/>
        public RecordRef stockUnit {
            get {
                return this.stockUnitField;
            }
            set {
                this.stockUnitField = value;
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
        public bool trackLandedCost {
            get {
                return this.trackLandedCostField;
            }
            set {
                this.trackLandedCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool trackLandedCostSpecified {
            get {
                return this.trackLandedCostFieldSpecified;
            }
            set {
                this.trackLandedCostFieldSpecified = value;
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
        public string manufactureraddr1 {
            get {
                return this.manufactureraddr1Field;
            }
            set {
                this.manufactureraddr1Field = value;
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
        public AssemblyItemEffectiveBomControl effectiveBomControl {
            get {
                return this.effectiveBomControlField;
            }
            set {
                this.effectiveBomControlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool effectiveBomControlSpecified {
            get {
                return this.effectiveBomControlFieldSpecified;
            }
            set {
                this.effectiveBomControlFieldSpecified = value;
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
        public string defaultRevision {
            get {
                return this.defaultRevisionField;
            }
            set {
                this.defaultRevisionField = value;
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
        public bool roundUpAsComponent {
            get {
                return this.roundUpAsComponentField;
            }
            set {
                this.roundUpAsComponentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool roundUpAsComponentSpecified {
            get {
                return this.roundUpAsComponentFieldSpecified;
            }
            set {
                this.roundUpAsComponentFieldSpecified = value;
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
        public bool isPhantom {
            get {
                return this.isPhantomField;
            }
            set {
                this.isPhantomField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPhantomSpecified {
            get {
                return this.isPhantomFieldSpecified;
            }
            set {
                this.isPhantomFieldSpecified = value;
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
        public RecordRef scheduleBCode {
            get {
                return this.scheduleBCodeField;
            }
            set {
                this.scheduleBCodeField = value;
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
        public RecordRef issueProduct {
            get {
                return this.issueProductField;
            }
            set {
                this.issueProductField = value;
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
        public RecordRef softDescriptor {
            get {
                return this.softDescriptorField;
            }
            set {
                this.softDescriptorField = value;
            }
        }

        /// <remarks/>
        public bool isSpecialWorkOrderItem {
            get {
                return this.isSpecialWorkOrderItemField;
            }
            set {
                this.isSpecialWorkOrderItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isSpecialWorkOrderItemSpecified {
            get {
                return this.isSpecialWorkOrderItemFieldSpecified;
            }
            set {
                this.isSpecialWorkOrderItemFieldSpecified = value;
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
        public bool buildEntireAssembly {
            get {
                return this.buildEntireAssemblyField;
            }
            set {
                this.buildEntireAssemblyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool buildEntireAssemblySpecified {
            get {
                return this.buildEntireAssemblyFieldSpecified;
            }
            set {
                this.buildEntireAssemblyFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double quantityOnHand {
            get {
                return this.quantityOnHandField;
            }
            set {
                this.quantityOnHandField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantityOnHandSpecified {
            get {
                return this.quantityOnHandFieldSpecified;
            }
            set {
                this.quantityOnHandFieldSpecified = value;
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
        public long reorderMultiple {
            get {
                return this.reorderMultipleField;
            }
            set {
                this.reorderMultipleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool reorderMultipleSpecified {
            get {
                return this.reorderMultipleFieldSpecified;
            }
            set {
                this.reorderMultipleFieldSpecified = value;
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
        public double transferPrice {
            get {
                return this.transferPriceField;
            }
            set {
                this.transferPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool transferPriceSpecified {
            get {
                return this.transferPriceFieldSpecified;
            }
            set {
                this.transferPriceFieldSpecified = value;
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
        public RecordRef intercoCogsAccount {
            get {
                return this.intercoCogsAccountField;
            }
            set {
                this.intercoCogsAccountField = value;
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
        public RecordRef unbuildVarianceAccount {
            get {
                return this.unbuildVarianceAccountField;
            }
            set {
                this.unbuildVarianceAccountField = value;
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
        public RecordRef dropshipExpenseAccount {
            get {
                return this.dropshipExpenseAccountField;
            }
            set {
                this.dropshipExpenseAccountField = value;
            }
        }

        /// <remarks/>
        public RecordRef preferredLocation {
            get {
                return this.preferredLocationField;
            }
            set {
                this.preferredLocationField = value;
            }
        }

        /// <remarks/>
        public bool isStorePickupAllowed {
            get {
                return this.isStorePickupAllowedField;
            }
            set {
                this.isStorePickupAllowedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isStorePickupAllowedSpecified {
            get {
                return this.isStorePickupAllowedFieldSpecified;
            }
            set {
                this.isStorePickupAllowedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double totalValue {
            get {
                return this.totalValueField;
            }
            set {
                this.totalValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totalValueSpecified {
            get {
                return this.totalValueFieldSpecified;
            }
            set {
                this.totalValueFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool useBins {
            get {
                return this.useBinsField;
            }
            set {
                this.useBinsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool useBinsSpecified {
            get {
                return this.useBinsFieldSpecified;
            }
            set {
                this.useBinsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double averageCost {
            get {
                return this.averageCostField;
            }
            set {
                this.averageCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool averageCostSpecified {
            get {
                return this.averageCostFieldSpecified;
            }
            set {
                this.averageCostFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double lastPurchasePrice {
            get {
                return this.lastPurchasePriceField;
            }
            set {
                this.lastPurchasePriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lastPurchasePriceSpecified {
            get {
                return this.lastPurchasePriceFieldSpecified;
            }
            set {
                this.lastPurchasePriceFieldSpecified = value;
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
        public long leadTime {
            get {
                return this.leadTimeField;
            }
            set {
                this.leadTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool leadTimeSpecified {
            get {
                return this.leadTimeFieldSpecified;
            }
            set {
                this.leadTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool autoLeadTime {
            get {
                return this.autoLeadTimeField;
            }
            set {
                this.autoLeadTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool autoLeadTimeSpecified {
            get {
                return this.autoLeadTimeFieldSpecified;
            }
            set {
                this.autoLeadTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double buildTime {
            get {
                return this.buildTimeField;
            }
            set {
                this.buildTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool buildTimeSpecified {
            get {
                return this.buildTimeFieldSpecified;
            }
            set {
                this.buildTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double buildTimeLotSize {
            get {
                return this.buildTimeLotSizeField;
            }
            set {
                this.buildTimeLotSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool buildTimeLotSizeSpecified {
            get {
                return this.buildTimeLotSizeFieldSpecified;
            }
            set {
                this.buildTimeLotSizeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double fixedBuildTime {
            get {
                return this.fixedBuildTimeField;
            }
            set {
                this.fixedBuildTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fixedBuildTimeSpecified {
            get {
                return this.fixedBuildTimeFieldSpecified;
            }
            set {
                this.fixedBuildTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef planningItemCategory {
            get {
                return this.planningItemCategoryField;
            }
            set {
                this.planningItemCategoryField = value;
            }
        }

        /// <remarks/>
        public double safetyStockLevel {
            get {
                return this.safetyStockLevelField;
            }
            set {
                this.safetyStockLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool safetyStockLevelSpecified {
            get {
                return this.safetyStockLevelFieldSpecified;
            }
            set {
                this.safetyStockLevelFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long safetyStockLevelDays {
            get {
                return this.safetyStockLevelDaysField;
            }
            set {
                this.safetyStockLevelDaysField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool safetyStockLevelDaysSpecified {
            get {
                return this.safetyStockLevelDaysFieldSpecified;
            }
            set {
                this.safetyStockLevelDaysFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool seasonalDemand {
            get {
                return this.seasonalDemandField;
            }
            set {
                this.seasonalDemandField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool seasonalDemandSpecified {
            get {
                return this.seasonalDemandFieldSpecified;
            }
            set {
                this.seasonalDemandFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string serialNumbers {
            get {
                return this.serialNumbersField;
            }
            set {
                this.serialNumbersField = value;
            }
        }

        /// <remarks/>
        public double reorderPoint {
            get {
                return this.reorderPointField;
            }
            set {
                this.reorderPointField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool reorderPointSpecified {
            get {
                return this.reorderPointFieldSpecified;
            }
            set {
                this.reorderPointFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double preferredStockLevel {
            get {
                return this.preferredStockLevelField;
            }
            set {
                this.preferredStockLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool preferredStockLevelSpecified {
            get {
                return this.preferredStockLevelFieldSpecified;
            }
            set {
                this.preferredStockLevelFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime expirationDate {
            get {
                return this.expirationDateField;
            }
            set {
                this.expirationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expirationDateSpecified {
            get {
                return this.expirationDateFieldSpecified;
            }
            set {
                this.expirationDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime lastInvtCountDate {
            get {
                return this.lastInvtCountDateField;
            }
            set {
                this.lastInvtCountDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lastInvtCountDateSpecified {
            get {
                return this.lastInvtCountDateFieldSpecified;
            }
            set {
                this.lastInvtCountDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime nextInvtCountDate {
            get {
                return this.nextInvtCountDateField;
            }
            set {
                this.nextInvtCountDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nextInvtCountDateSpecified {
            get {
                return this.nextInvtCountDateFieldSpecified;
            }
            set {
                this.nextInvtCountDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long invtCountInterval {
            get {
                return this.invtCountIntervalField;
            }
            set {
                this.invtCountIntervalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool invtCountIntervalSpecified {
            get {
                return this.invtCountIntervalFieldSpecified;
            }
            set {
                this.invtCountIntervalFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ItemInvtClassification invtClassification {
            get {
                return this.invtClassificationField;
            }
            set {
                this.invtClassificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool invtClassificationSpecified {
            get {
                return this.invtClassificationFieldSpecified;
            }
            set {
                this.invtClassificationFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double demandModifier {
            get {
                return this.demandModifierField;
            }
            set {
                this.demandModifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool demandModifierSpecified {
            get {
                return this.demandModifierFieldSpecified;
            }
            set {
                this.demandModifierFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool autoReorderPoint {
            get {
                return this.autoReorderPointField;
            }
            set {
                this.autoReorderPointField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool autoReorderPointSpecified {
            get {
                return this.autoReorderPointFieldSpecified;
            }
            set {
                this.autoReorderPointFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool autoPreferredStockLevel {
            get {
                return this.autoPreferredStockLevelField;
            }
            set {
                this.autoPreferredStockLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool autoPreferredStockLevelSpecified {
            get {
                return this.autoPreferredStockLevelFieldSpecified;
            }
            set {
                this.autoPreferredStockLevelFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double preferredStockLevelDays {
            get {
                return this.preferredStockLevelDaysField;
            }
            set {
                this.preferredStockLevelDaysField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool preferredStockLevelDaysSpecified {
            get {
                return this.preferredStockLevelDaysFieldSpecified;
            }
            set {
                this.preferredStockLevelDaysFieldSpecified = value;
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
        public RecordRef shipPackage {
            get {
                return this.shipPackageField;
            }
            set {
                this.shipPackageField = value;
            }
        }

        /// <remarks/>
        public double defaultReturnCost {
            get {
                return this.defaultReturnCostField;
            }
            set {
                this.defaultReturnCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultReturnCostSpecified {
            get {
                return this.defaultReturnCostFieldSpecified;
            }
            set {
                this.defaultReturnCostFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef supplyReplenishmentMethod {
            get {
                return this.supplyReplenishmentMethodField;
            }
            set {
                this.supplyReplenishmentMethodField = value;
            }
        }

        /// <remarks/>
        public RecordRef alternateDemandSourceItem {
            get {
                return this.alternateDemandSourceItemField;
            }
            set {
                this.alternateDemandSourceItemField = value;
            }
        }

        /// <remarks/>
        public double fixedLotSize {
            get {
                return this.fixedLotSizeField;
            }
            set {
                this.fixedLotSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fixedLotSizeSpecified {
            get {
                return this.fixedLotSizeFieldSpecified;
            }
            set {
                this.fixedLotSizeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef supplyType {
            get {
                return this.supplyTypeField;
            }
            set {
                this.supplyTypeField = value;
            }
        }

        /// <remarks/>
        public long demandTimeFence {
            get {
                return this.demandTimeFenceField;
            }
            set {
                this.demandTimeFenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool demandTimeFenceSpecified {
            get {
                return this.demandTimeFenceFieldSpecified;
            }
            set {
                this.demandTimeFenceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long supplyTimeFence {
            get {
                return this.supplyTimeFenceField;
            }
            set {
                this.supplyTimeFenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool supplyTimeFenceSpecified {
            get {
                return this.supplyTimeFenceFieldSpecified;
            }
            set {
                this.supplyTimeFenceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long rescheduleInDays {
            get {
                return this.rescheduleInDaysField;
            }
            set {
                this.rescheduleInDaysField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rescheduleInDaysSpecified {
            get {
                return this.rescheduleInDaysFieldSpecified;
            }
            set {
                this.rescheduleInDaysFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long rescheduleOutDays {
            get {
                return this.rescheduleOutDaysField;
            }
            set {
                this.rescheduleOutDaysField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rescheduleOutDaysSpecified {
            get {
                return this.rescheduleOutDaysFieldSpecified;
            }
            set {
                this.rescheduleOutDaysFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef supplyLotSizingMethod {
            get {
                return this.supplyLotSizingMethodField;
            }
            set {
                this.supplyLotSizingMethodField = value;
            }
        }

        /// <remarks/>
        public RecordRef demandSource {
            get {
                return this.demandSourceField;
            }
            set {
                this.demandSourceField = value;
            }
        }

        /// <remarks/>
        public double quantityCommitted {
            get {
                return this.quantityCommittedField;
            }
            set {
                this.quantityCommittedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantityCommittedSpecified {
            get {
                return this.quantityCommittedFieldSpecified;
            }
            set {
                this.quantityCommittedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double quantityAvailable {
            get {
                return this.quantityAvailableField;
            }
            set {
                this.quantityAvailableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantityAvailableSpecified {
            get {
                return this.quantityAvailableFieldSpecified;
            }
            set {
                this.quantityAvailableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double quantityBackOrdered {
            get {
                return this.quantityBackOrderedField;
            }
            set {
                this.quantityBackOrderedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantityBackOrderedSpecified {
            get {
                return this.quantityBackOrderedFieldSpecified;
            }
            set {
                this.quantityBackOrderedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double quantityOnOrder {
            get {
                return this.quantityOnOrderField;
            }
            set {
                this.quantityOnOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantityOnOrderSpecified {
            get {
                return this.quantityOnOrderFieldSpecified;
            }
            set {
                this.quantityOnOrderFieldSpecified = value;
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
        public string urlComponent {
            get {
                return this.urlComponentField;
            }
            set {
                this.urlComponentField = value;
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
        public string shoppingDotComCategory {
            get {
                return this.shoppingDotComCategoryField;
            }
            set {
                this.shoppingDotComCategoryField = value;
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
        public string relatedItemsDescription {
            get {
                return this.relatedItemsDescriptionField;
            }
            set {
                this.relatedItemsDescriptionField = value;
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
        [System.Xml.Serialization.XmlArrayItemAttribute("recordRef", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public RecordRef[] itemNumberOptionsList {
            get {
                return this.itemNumberOptionsListField;
            }
            set {
                this.itemNumberOptionsListField = value;
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
        public LotNumberedAssemblyItemBillOfMaterialsList billOfMaterialsList {
            get {
                return this.billOfMaterialsListField;
            }
            set {
                this.billOfMaterialsListField = value;
            }
        }

        /// <remarks/>
        public ItemMemberList memberList {
            get {
                return this.memberListField;
            }
            set {
                this.memberListField = value;
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
        public LotNumberedInventoryItemLocationsList locationsList {
            get {
                return this.locationsListField;
            }
            set {
                this.locationsListField = value;
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
        public InventoryItemBinNumberList binNumberList {
            get {
                return this.binNumberListField;
            }
            set {
                this.binNumberListField = value;
            }
        }

        /// <remarks/>
        public LotNumberedInventoryItemNumbersList numbersList {
            get {
                return this.numbersListField;
            }
            set {
                this.numbersListField = value;
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
        public PresentationItemList presentationItemList {
            get {
                return this.presentationItemListField;
            }
            set {
                this.presentationItemListField = value;
            }
        }

        /// <remarks/>
        public LotNumberedAssemblyItemHierarchyVersionsList hierarchyVersionsList {
            get {
                return this.hierarchyVersionsListField;
            }
            set {
                this.hierarchyVersionsListField = value;
            }
        }

        /// <remarks/>
        public long futureHorizon {
            get {
                return this.futureHorizonField;
            }
            set {
                this.futureHorizonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool futureHorizonSpecified {
            get {
                return this.futureHorizonFieldSpecified;
            }
            set {
                this.futureHorizonFieldSpecified = value;
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