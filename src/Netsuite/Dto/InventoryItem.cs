using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using Netsuite.Dto;
using Netsuite.Enum;

/// <remarks/>
[GeneratedCode("wsdl", "4.8.3928.0")]
[Serializable()]
[DebuggerStepThrough()]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:accounting_2021_1.lists.webservices.netsuite.com")]
public partial class InventoryItem
{
    private DateTime createdDateField;

    private bool createdDateFieldSpecified;

    private DateTime lastModifiedDateField;

    private bool lastModifiedDateFieldSpecified;

    private string purchaseDescriptionField;

    private bool copyDescriptionField;

    private bool copyDescriptionFieldSpecified;

    private RecordRef expenseAccountField;

    private DateTime dateConvertedToInvField;

    private bool dateConvertedToInvFieldSpecified;

    private ItemType originalItemTypeField;

    private bool originalItemTypeFieldSpecified;

    private ItemSubType originalItemSubtypeField;

    private bool originalItemSubtypeFieldSpecified;

    private RecordRef cogsAccountField;

    private RecordRef intercoCogsAccountField;

    private string salesDescriptionField;

    private bool includeChildrenField;

    private bool includeChildrenFieldSpecified;

    private RecordRef incomeAccountField;

    private RecordRef intercoIncomeAccountField;

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

    private bool contingentRevenueHandlingField;

    private bool contingentRevenueHandlingFieldSpecified;

    private RecordRef revReclassFXAccountField;

    private bool isTaxableField;

    private bool isTaxableFieldSpecified;

    private RecordRef assetAccountField;

    private bool matchBillToReceiptField;

    private bool matchBillToReceiptFieldSpecified;

    private RecordRef billQtyVarianceAcctField;

    private RecordRef billPriceVarianceAcctField;

    private RecordRef billExchRateVarianceAcctField;

    private RecordRef gainLossAccountField;

    private double shippingCostField;

    private bool shippingCostFieldSpecified;

    private string shippingCostUnitsField;

    private double handlingCostField;

    private bool handlingCostFieldSpecified;

    private string handlingCostUnitsField;

    private double weightField;

    private bool weightFieldSpecified;

    private ItemWeightUnit weightUnitField;

    private bool weightUnitFieldSpecified;

    private string weightUnitsField;

    private string costingMethodDisplayField;

    private RecordRef unitsTypeField;

    private RecordRef stockUnitField;

    private RecordRef purchaseUnitField;

    private RecordRef saleUnitField;

    private RecordRef issueProductField;

    private RecordRef billingScheduleField;

    private bool trackLandedCostField;

    private bool trackLandedCostFieldSpecified;

    private string matrixItemNameTemplateField;

    private bool isDropShipItemField;

    private bool isDropShipItemFieldSpecified;

    private bool isSpecialOrderItemField;

    private bool isSpecialOrderItemFieldSpecified;

    private string stockDescriptionField;

    private RecordRef deferredRevenueAccountField;

    private RecordRef intercoDefRevAccountField;

    private bool producerField;

    private bool producerFieldSpecified;

    private string manufacturerField;

    private RecordRef revRecScheduleField;

    private string mpnField;

    private bool multManufactureAddrField;

    private bool multManufactureAddrFieldSpecified;

    private string manufacturerAddr1Field;

    private string manufacturerCityField;

    private string manufacturerStateField;

    private string manufacturerZipField;

    private string countryOfManufactureField;

    private bool countryOfManufactureFieldSpecified;

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

    private RecordRef defaultItemShipMethodField;

    private string itemCarrierField;

    private bool itemCarrierFieldSpecified;

    private RecordRef[] itemShipMethodListField;

    private string manufacturerTaxIdField;

    private string scheduleBNumberField;

    private long scheduleBQuantityField;

    private bool scheduleBQuantityFieldSpecified;

    private ScheduleBCode scheduleBCodeField;

    private bool scheduleBCodeFieldSpecified;

    private string manufacturerTariffField;

    private string preferenceCriterionField;

    private bool preferenceCriterionFieldSpecified;

    private long minimumQuantityField;

    private bool minimumQuantityFieldSpecified;

    private bool enforceMinQtyInternallyField;

    private bool enforceMinQtyInternallyFieldSpecified;

    private long maximumQuantityField;

    private bool maximumQuantityFieldSpecified;

    private string minimumQuantityUnitsField;

    private RecordRef softDescriptorField;

    private RecordRef shipPackageField;

    private bool shipIndividuallyField;

    private bool shipIndividuallyFieldSpecified;

    private RecordRef costCategoryField;

    private bool pricesIncludeTaxField;

    private bool pricesIncludeTaxFieldSpecified;

    private RecordRef purchasePriceVarianceAcctField;

    private RecordRef quantityPricingScheduleField;

    private string reorderPointUnitsField;

    private bool useMarginalRatesField;

    private bool useMarginalRatesFieldSpecified;

    private string preferredStockLevelUnitsField;

    private ItemCostEstimateType costEstimateTypeField;

    private bool costEstimateTypeFieldSpecified;

    private double costEstimateField;

    private bool costEstimateFieldSpecified;

    private double transferPriceField;

    private bool transferPriceFieldSpecified;

    private ItemOverallQuantityPricingType overallQuantityPricingTypeField;

    private bool overallQuantityPricingTypeFieldSpecified;

    private RecordRef pricingGroupField;

    private double vsoePriceField;

    private bool vsoePriceFieldSpecified;

    private VsoeSopGroup vsoeSopGroupField;

    private bool vsoeSopGroupFieldSpecified;

    private string costEstimateUnitsField;

    private VsoeDeferral vsoeDeferralField;

    private bool vsoeDeferralFieldSpecified;

    private VsoePermitDiscount vsoePermitDiscountField;

    private bool vsoePermitDiscountFieldSpecified;

    private bool vsoeDeliveredField;

    private bool vsoeDeliveredFieldSpecified;

    private RecordRef itemRevenueCategoryField;

    private RecordRef preferredLocationField;

    private bool isStorePickupAllowedField;

    private bool isStorePickupAllowedFieldSpecified;

    private long reorderMultipleField;

    private bool reorderMultipleFieldSpecified;

    private double costField;

    private bool costFieldSpecified;

    private DateTime lastInvtCountDateField;

    private bool lastInvtCountDateFieldSpecified;

    private DateTime nextInvtCountDateField;

    private bool nextInvtCountDateFieldSpecified;

    private long invtCountIntervalField;

    private bool invtCountIntervalFieldSpecified;

    private ItemInvtClassification invtClassificationField;

    private bool invtClassificationFieldSpecified;

    private string costUnitsField;

    private double totalValueField;

    private bool totalValueFieldSpecified;

    private double averageCostField;

    private bool averageCostFieldSpecified;

    private bool useBinsField;

    private bool useBinsFieldSpecified;

    private string quantityReorderUnitsField;

    private long leadTimeField;

    private bool leadTimeFieldSpecified;

    private bool autoLeadTimeField;

    private bool autoLeadTimeFieldSpecified;

    private double lastPurchasePriceField;

    private bool lastPurchasePriceFieldSpecified;

    private bool autoPreferredStockLevelField;

    private bool autoPreferredStockLevelFieldSpecified;

    private double preferredStockLevelDaysField;

    private bool preferredStockLevelDaysFieldSpecified;

    private double safetyStockLevelField;

    private bool safetyStockLevelFieldSpecified;

    private long safetyStockLevelDaysField;

    private bool safetyStockLevelDaysFieldSpecified;

    private long backwardConsumptionDaysField;

    private bool backwardConsumptionDaysFieldSpecified;

    private bool seasonalDemandField;

    private bool seasonalDemandFieldSpecified;

    private string safetyStockLevelUnitsField;

    private double demandModifierField;

    private bool demandModifierFieldSpecified;

    private RecordRef distributionNetworkField;

    private RecordRef distributionCategoryField;

    private bool autoReorderPointField;

    private bool autoReorderPointFieldSpecified;

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

    private string urlComponentField;

    private RecordRef customFormField;

    private string itemIdField;

    private string idField;

    private string upcCodeField;

    private string displayNameField;

    private string fullnameField;

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

    private bool isLotItemField;

    private bool isInactiveFieldSpecified;

    private bool availableToPartnersField;

    private bool availableToPartnersFieldSpecified;

    private RecordRef departmentField;

    private RecordRef classField;

    private RecordRef locationField;

    private ItemCostingMethod costingMethodField;

    private bool costingMethodFieldSpecified;

    private string currencyField;

    private double preferredStockLevelField;

    private bool preferredStockLevelFieldSpecified;

    private PricingMatrix pricingMatrixField;

    private InventoryItemHierarchyVersionsList hierarchyVersionsListField;

    private ItemAccountingBookDetailList accountingBookDetailListField;

    private RecordRef purchaseTaxCodeField;

    private double defaultReturnCostField;

    private bool defaultReturnCostFieldSpecified;

    private RecordRef supplyReplenishmentMethodField;

    private RecordRef alternateDemandSourceItemField;

    private double fixedLotSizeField;

    private bool fixedLotSizeFieldSpecified;

    private PeriodicLotSizeType periodicLotSizeTypeField;

    private bool periodicLotSizeTypeFieldSpecified;

    private RecordRef supplyTypeField;

    private long demandTimeFenceField;

    private bool demandTimeFenceFieldSpecified;

    private long supplyTimeFenceField;

    private bool supplyTimeFenceFieldSpecified;

    private long rescheduleInDaysField;

    private bool rescheduleInDaysFieldSpecified;

    private long rescheduleOutDaysField;

    private bool rescheduleOutDaysFieldSpecified;

    private long periodicLotSizeDaysField;

    private bool periodicLotSizeDaysFieldSpecified;

    private RecordRef supplyLotSizingMethodField;

    private long forwardConsumptionDaysField;

    private bool forwardConsumptionDaysFieldSpecified;

    private RecordRef demandSourceField;

    private double quantityBackOrderedField;

    private bool quantityBackOrderedFieldSpecified;

    private double quantityCommittedField;

    private bool quantityCommittedFieldSpecified;

    private double quantityAvailableField;

    private bool quantityAvailableFieldSpecified;

    private double quantityOnHandField;

    private bool quantityOnHandFieldSpecified;

    private double onHandValueMliField;

    private bool onHandValueMliFieldSpecified;

    private double quantityOnOrderField;

    private bool quantityOnOrderFieldSpecified;

    private double rateField;

    private bool rateFieldSpecified;

    private double reorderPointField;

    private bool reorderPointFieldSpecified;

    private string quantityCommittedUnitsField;

    private RecordRef salesTaxCodeField;

    private string quantityAvailableUnitsField;

    private string quantityOnHandUnitsField;

    private RecordRef vendorField;

    private string quantityOnOrderUnitsField;

    private ItemProductFeed[] productFeedListField;

    private RecordRef[] subsidiaryListField;

    private RecordRef[] itemOptionsListField;

    private ItemVendorList itemVendorListField;

    private SiteCategoryList siteCategoryListField;

    private TranslationList translationsListField;

    private InventoryItemBinNumberList binNumberListField;

    private InventoryItemLocationsList locationsListField;

    private SelectCustomFieldRef[] matrixOptionListField;

    private PresentationItemList presentationItemListField;

    private long futureHorizonField;

    private bool futureHorizonFieldSpecified;

    private RecordRef consumptionUnitField;

    private bool enableCatchWeightField;

    private bool enableCatchWeightFieldSpecified;

    private RecordRef secondaryUnitsTypeField;

    private RecordRef secondaryBaseUnitField;

    private double conversionRateField;

    private bool conversionRateFieldSpecified;

    private RecordRef secondaryStockUnitField;

    private RecordRef secondarySaleUnitField;

    private RecordRef secondaryPurchaseUnitField;

    private RecordRef secondaryConsumptionUnitField;

    private double lowerWarningLimitField;

    private bool lowerWarningLimitFieldSpecified;

    private double upperWarningLimitField;

    private bool upperWarningLimitFieldSpecified;

    private RecordRef planningItemCategoryField;

    private CustomFieldRef[] customFieldListField;

    private string internalIdField;

    private string externalIdField;

    /// <remarks/>
    public DateTime createdDate
    {
        get { return this.createdDateField; }
        set { this.createdDateField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool createdDateSpecified
    {
        get { return this.createdDateFieldSpecified; }
        set { this.createdDateFieldSpecified = value; }
    }

    /// <remarks/>
    public DateTime lastModifiedDate
    {
        get { return this.lastModifiedDateField; }
        set { this.lastModifiedDateField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool lastModifiedDateSpecified
    {
        get { return this.lastModifiedDateFieldSpecified; }
        set { this.lastModifiedDateFieldSpecified = value; }
    }

    /// <remarks/>
    public string purchaseDescription
    {
        get { return this.purchaseDescriptionField; }
        set { this.purchaseDescriptionField = value; }
    }

    /// <remarks/>
    public bool copyDescription
    {
        get { return this.copyDescriptionField; }
        set { this.copyDescriptionField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool copyDescriptionSpecified
    {
        get { return this.copyDescriptionFieldSpecified; }
        set { this.copyDescriptionFieldSpecified = value; }
    }

    /// <remarks/>
    public RecordRef expenseAccount
    {
        get { return this.expenseAccountField; }
        set { this.expenseAccountField = value; }
    }

    /// <remarks/>
    public DateTime dateConvertedToInv
    {
        get { return this.dateConvertedToInvField; }
        set { this.dateConvertedToInvField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool dateConvertedToInvSpecified
    {
        get { return this.dateConvertedToInvFieldSpecified; }
        set { this.dateConvertedToInvFieldSpecified = value; }
    }

    /// <remarks/>
    public ItemType originalItemType
    {
        get { return this.originalItemTypeField; }
        set { this.originalItemTypeField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool originalItemTypeSpecified
    {
        get { return this.originalItemTypeFieldSpecified; }
        set { this.originalItemTypeFieldSpecified = value; }
    }

    /// <remarks/>
    public ItemSubType originalItemSubtype
    {
        get { return this.originalItemSubtypeField; }
        set { this.originalItemSubtypeField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool originalItemSubtypeSpecified
    {
        get { return this.originalItemSubtypeFieldSpecified; }
        set { this.originalItemSubtypeFieldSpecified = value; }
    }

    /// <remarks/>
    public RecordRef cogsAccount
    {
        get { return this.cogsAccountField; }
        set { this.cogsAccountField = value; }
    }

    /// <remarks/>
    public RecordRef intercoCogsAccount
    {
        get { return this.intercoCogsAccountField; }
        set { this.intercoCogsAccountField = value; }
    }

    /// <remarks/>
    public string salesDescription
    {
        get { return this.salesDescriptionField; }
        set { this.salesDescriptionField = value; }
    }

    /// <remarks/>
    public bool includeChildren
    {
        get { return this.includeChildrenField; }
        set { this.includeChildrenField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool includeChildrenSpecified
    {
        get { return this.includeChildrenFieldSpecified; }
        set { this.includeChildrenFieldSpecified = value; }
    }

    /// <remarks/>
    public RecordRef incomeAccount
    {
        get { return this.incomeAccountField; }
        set { this.incomeAccountField = value; }
    }

    /// <remarks/>
    public RecordRef intercoIncomeAccount
    {
        get { return this.intercoIncomeAccountField; }
        set { this.intercoIncomeAccountField = value; }
    }

    /// <remarks/>
    public RecordRef taxSchedule
    {
        get { return this.taxScheduleField; }
        set { this.taxScheduleField = value; }
    }

    /// <remarks/>
    public RecordRef dropshipExpenseAccount
    {
        get { return this.dropshipExpenseAccountField; }
        set { this.dropshipExpenseAccountField = value; }
    }

    /// <remarks/>
    public bool deferRevRec
    {
        get { return this.deferRevRecField; }
        set { this.deferRevRecField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool deferRevRecSpecified
    {
        get { return this.deferRevRecFieldSpecified; }
        set { this.deferRevRecFieldSpecified = value; }
    }

    /// <remarks/>
    public RecordRef revenueRecognitionRule
    {
        get { return this.revenueRecognitionRuleField; }
        set { this.revenueRecognitionRuleField = value; }
    }

    /// <remarks/>
    public RecordRef revRecForecastRule
    {
        get { return this.revRecForecastRuleField; }
        set { this.revRecForecastRuleField = value; }
    }

    /// <remarks/>
    public RecordRef revenueAllocationGroup
    {
        get { return this.revenueAllocationGroupField; }
        set { this.revenueAllocationGroupField = value; }
    }

    /// <remarks/>
    public RecordRef createRevenuePlansOn
    {
        get { return this.createRevenuePlansOnField; }
        set { this.createRevenuePlansOnField = value; }
    }

    /// <remarks/>
    public bool directRevenuePosting
    {
        get { return this.directRevenuePostingField; }
        set { this.directRevenuePostingField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool directRevenuePostingSpecified
    {
        get { return this.directRevenuePostingFieldSpecified; }
        set { this.directRevenuePostingFieldSpecified = value; }
    }

    /// <remarks/>
    public bool contingentRevenueHandling
    {
        get { return this.contingentRevenueHandlingField; }
        set { this.contingentRevenueHandlingField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool contingentRevenueHandlingSpecified
    {
        get { return this.contingentRevenueHandlingFieldSpecified; }
        set { this.contingentRevenueHandlingFieldSpecified = value; }
    }

    /// <remarks/>
    public RecordRef revReclassFXAccount
    {
        get { return this.revReclassFXAccountField; }
        set { this.revReclassFXAccountField = value; }
    }

    /// <remarks/>
    public bool isTaxable
    {
        get { return this.isTaxableField; }
        set { this.isTaxableField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool isTaxableSpecified
    {
        get { return this.isTaxableFieldSpecified; }
        set { this.isTaxableFieldSpecified = value; }
    }

    /// <remarks/>
    public RecordRef assetAccount
    {
        get { return this.assetAccountField; }
        set { this.assetAccountField = value; }
    }

    /// <remarks/>
    public bool matchBillToReceipt
    {
        get { return this.matchBillToReceiptField; }
        set { this.matchBillToReceiptField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool matchBillToReceiptSpecified
    {
        get { return this.matchBillToReceiptFieldSpecified; }
        set { this.matchBillToReceiptFieldSpecified = value; }
    }

    /// <remarks/>
    public RecordRef billQtyVarianceAcct
    {
        get { return this.billQtyVarianceAcctField; }
        set { this.billQtyVarianceAcctField = value; }
    }

    /// <remarks/>
    public RecordRef billPriceVarianceAcct
    {
        get { return this.billPriceVarianceAcctField; }
        set { this.billPriceVarianceAcctField = value; }
    }

    /// <remarks/>
    public RecordRef billExchRateVarianceAcct
    {
        get { return this.billExchRateVarianceAcctField; }
        set { this.billExchRateVarianceAcctField = value; }
    }

    /// <remarks/>
    public RecordRef gainLossAccount
    {
        get { return this.gainLossAccountField; }
        set { this.gainLossAccountField = value; }
    }

    /// <remarks/>
    public double shippingCost
    {
        get { return this.shippingCostField; }
        set { this.shippingCostField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool shippingCostSpecified
    {
        get { return this.shippingCostFieldSpecified; }
        set { this.shippingCostFieldSpecified = value; }
    }

    /// <remarks/>
    public string shippingCostUnits
    {
        get { return this.shippingCostUnitsField; }
        set { this.shippingCostUnitsField = value; }
    }

    /// <remarks/>
    public double handlingCost
    {
        get { return this.handlingCostField; }
        set { this.handlingCostField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool handlingCostSpecified
    {
        get { return this.handlingCostFieldSpecified; }
        set { this.handlingCostFieldSpecified = value; }
    }

    /// <remarks/>
    public string handlingCostUnits
    {
        get { return this.handlingCostUnitsField; }
        set { this.handlingCostUnitsField = value; }
    }

    /// <remarks/>
    public double weight
    {
        get { return this.weightField; }
        set { this.weightField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool weightSpecified
    {
        get { return this.weightFieldSpecified; }
        set { this.weightFieldSpecified = value; }
    }

    /// <remarks/>
    public ItemWeightUnit weightUnit
    {
        get { return this.weightUnitField; }
        set { this.weightUnitField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool weightUnitSpecified
    {
        get { return this.weightUnitFieldSpecified; }
        set { this.weightUnitFieldSpecified = value; }
    }

    /// <remarks/>
    public string weightUnits
    {
        get { return this.weightUnitsField; }
        set { this.weightUnitsField = value; }
    }

    /// <remarks/>
    public string costingMethodDisplay
    {
        get { return this.costingMethodDisplayField; }
        set { this.costingMethodDisplayField = value; }
    }

    /// <remarks/>
    public RecordRef unitsType
    {
        get { return this.unitsTypeField; }
        set { this.unitsTypeField = value; }
    }

    /// <remarks/>
    public RecordRef stockUnit
    {
        get { return this.stockUnitField; }
        set { this.stockUnitField = value; }
    }

    /// <remarks/>
    public RecordRef purchaseUnit
    {
        get { return this.purchaseUnitField; }
        set { this.purchaseUnitField = value; }
    }

    /// <remarks/>
    public RecordRef saleUnit
    {
        get { return this.saleUnitField; }
        set { this.saleUnitField = value; }
    }

    /// <remarks/>
    public RecordRef issueProduct
    {
        get { return this.issueProductField; }
        set { this.issueProductField = value; }
    }

    /// <remarks/>
    public RecordRef billingSchedule
    {
        get { return this.billingScheduleField; }
        set { this.billingScheduleField = value; }
    }

    /// <remarks/>
    public bool trackLandedCost
    {
        get { return this.trackLandedCostField; }
        set { this.trackLandedCostField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool trackLandedCostSpecified
    {
        get { return this.trackLandedCostFieldSpecified; }
        set { this.trackLandedCostFieldSpecified = value; }
    }

    /// <remarks/>
    public string matrixItemNameTemplate
    {
        get { return this.matrixItemNameTemplateField; }
        set { this.matrixItemNameTemplateField = value; }
    }

    /// <remarks/>
    public bool isDropShipItem
    {
        get { return this.isDropShipItemField; }
        set { this.isDropShipItemField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool isDropShipItemSpecified
    {
        get { return this.isDropShipItemFieldSpecified; }
        set { this.isDropShipItemFieldSpecified = value; }
    }

    /// <remarks/>
    public bool isSpecialOrderItem
    {
        get { return this.isSpecialOrderItemField; }
        set { this.isSpecialOrderItemField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool isSpecialOrderItemSpecified
    {
        get { return this.isSpecialOrderItemFieldSpecified; }
        set { this.isSpecialOrderItemFieldSpecified = value; }
    }

    /// <remarks/>
    public string stockDescription
    {
        get { return this.stockDescriptionField; }
        set { this.stockDescriptionField = value; }
    }

    /// <remarks/>
    public RecordRef deferredRevenueAccount
    {
        get { return this.deferredRevenueAccountField; }
        set { this.deferredRevenueAccountField = value; }
    }

    /// <remarks/>
    public RecordRef intercoDefRevAccount
    {
        get { return this.intercoDefRevAccountField; }
        set { this.intercoDefRevAccountField = value; }
    }

    /// <remarks/>
    public bool producer
    {
        get { return this.producerField; }
        set { this.producerField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool producerSpecified
    {
        get { return this.producerFieldSpecified; }
        set { this.producerFieldSpecified = value; }
    }

    /// <remarks/>
    public string manufacturer
    {
        get { return this.manufacturerField; }
        set { this.manufacturerField = value; }
    }

    /// <remarks/>
    public RecordRef revRecSchedule
    {
        get { return this.revRecScheduleField; }
        set { this.revRecScheduleField = value; }
    }

    /// <remarks/>
    public string mpn
    {
        get { return this.mpnField; }
        set { this.mpnField = value; }
    }

    /// <remarks/>
    public bool multManufactureAddr
    {
        get { return this.multManufactureAddrField; }
        set { this.multManufactureAddrField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool multManufactureAddrSpecified
    {
        get { return this.multManufactureAddrFieldSpecified; }
        set { this.multManufactureAddrFieldSpecified = value; }
    }

    /// <remarks/>
    public string manufacturerAddr1
    {
        get { return this.manufacturerAddr1Field; }
        set { this.manufacturerAddr1Field = value; }
    }

    /// <remarks/>
    public string manufacturerCity
    {
        get { return this.manufacturerCityField; }
        set { this.manufacturerCityField = value; }
    }

    /// <remarks/>
    public string manufacturerState
    {
        get { return this.manufacturerStateField; }
        set { this.manufacturerStateField = value; }
    }

    /// <remarks/>
    public string manufacturerZip
    {
        get { return this.manufacturerZipField; }
        set { this.manufacturerZipField = value; }
    }

    /// <remarks/>
    public string countryOfManufacture
    {
        get { return this.countryOfManufactureField; }
        set { this.countryOfManufactureField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool countryOfManufactureSpecified
    {
        get { return this.countryOfManufactureFieldSpecified; }
        set { this.countryOfManufactureFieldSpecified = value; }
    }

    /// <remarks/>
    public bool roundUpAsComponent
    {
        get { return this.roundUpAsComponentField; }
        set { this.roundUpAsComponentField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool roundUpAsComponentSpecified
    {
        get { return this.roundUpAsComponentFieldSpecified; }
        set { this.roundUpAsComponentFieldSpecified = value; }
    }

    /// <remarks/>
    public double purchaseOrderQuantity
    {
        get { return this.purchaseOrderQuantityField; }
        set { this.purchaseOrderQuantityField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool purchaseOrderQuantitySpecified
    {
        get { return this.purchaseOrderQuantityFieldSpecified; }
        set { this.purchaseOrderQuantityFieldSpecified = value; }
    }

    /// <remarks/>
    public double purchaseOrderAmount
    {
        get { return this.purchaseOrderAmountField; }
        set { this.purchaseOrderAmountField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool purchaseOrderAmountSpecified
    {
        get { return this.purchaseOrderAmountFieldSpecified; }
        set { this.purchaseOrderAmountFieldSpecified = value; }
    }

    /// <remarks/>
    public double purchaseOrderQuantityDiff
    {
        get { return this.purchaseOrderQuantityDiffField; }
        set { this.purchaseOrderQuantityDiffField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool purchaseOrderQuantityDiffSpecified
    {
        get { return this.purchaseOrderQuantityDiffFieldSpecified; }
        set { this.purchaseOrderQuantityDiffFieldSpecified = value; }
    }

    /// <remarks/>
    public double receiptQuantity
    {
        get { return this.receiptQuantityField; }
        set { this.receiptQuantityField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool receiptQuantitySpecified
    {
        get { return this.receiptQuantityFieldSpecified; }
        set { this.receiptQuantityFieldSpecified = value; }
    }

    /// <remarks/>
    public double receiptAmount
    {
        get { return this.receiptAmountField; }
        set { this.receiptAmountField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool receiptAmountSpecified
    {
        get { return this.receiptAmountFieldSpecified; }
        set { this.receiptAmountFieldSpecified = value; }
    }

    /// <remarks/>
    public double receiptQuantityDiff
    {
        get { return this.receiptQuantityDiffField; }
        set { this.receiptQuantityDiffField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool receiptQuantityDiffSpecified
    {
        get { return this.receiptQuantityDiffFieldSpecified; }
        set { this.receiptQuantityDiffFieldSpecified = value; }
    }

    /// <remarks/>
    public RecordRef defaultItemShipMethod
    {
        get { return this.defaultItemShipMethodField; }
        set { this.defaultItemShipMethodField = value; }
    }

    /// <remarks/>
    public string itemCarrier
    {
        get { return this.itemCarrierField; }
        set { this.itemCarrierField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool itemCarrierSpecified
    {
        get { return this.itemCarrierFieldSpecified; }
        set { this.itemCarrierFieldSpecified = value; }
    }

    /// <remarks/>
    [XmlArrayItem("recordRef", Namespace = "urn:core_2021_1.platform.webservices.netsuite.com", IsNullable = false)]
    public RecordRef[] itemShipMethodList
    {
        get { return this.itemShipMethodListField; }
        set { this.itemShipMethodListField = value; }
    }

    /// <remarks/>
    public string manufacturerTaxId
    {
        get { return this.manufacturerTaxIdField; }
        set { this.manufacturerTaxIdField = value; }
    }

    /// <remarks/>
    public string scheduleBNumber
    {
        get { return this.scheduleBNumberField; }
        set { this.scheduleBNumberField = value; }
    }

    /// <remarks/>
    public long scheduleBQuantity
    {
        get { return this.scheduleBQuantityField; }
        set { this.scheduleBQuantityField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool scheduleBQuantitySpecified
    {
        get { return this.scheduleBQuantityFieldSpecified; }
        set { this.scheduleBQuantityFieldSpecified = value; }
    }

    /// <remarks/>
    public ScheduleBCode scheduleBCode
    {
        get { return this.scheduleBCodeField; }
        set { this.scheduleBCodeField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool scheduleBCodeSpecified
    {
        get { return this.scheduleBCodeFieldSpecified; }
        set { this.scheduleBCodeFieldSpecified = value; }
    }

    /// <remarks/>
    public string manufacturerTariff
    {
        get { return this.manufacturerTariffField; }
        set { this.manufacturerTariffField = value; }
    }

    /// <remarks/>
    public string preferenceCriterion
    {
        get { return this.preferenceCriterionField; }
        set { this.preferenceCriterionField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool preferenceCriterionSpecified
    {
        get { return this.preferenceCriterionFieldSpecified; }
        set { this.preferenceCriterionFieldSpecified = value; }
    }

    /// <remarks/>
    public long minimumQuantity
    {
        get { return this.minimumQuantityField; }
        set { this.minimumQuantityField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool minimumQuantitySpecified
    {
        get { return this.minimumQuantityFieldSpecified; }
        set { this.minimumQuantityFieldSpecified = value; }
    }

    /// <remarks/>
    public bool enforceMinQtyInternally
    {
        get { return this.enforceMinQtyInternallyField; }
        set { this.enforceMinQtyInternallyField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool enforceMinQtyInternallySpecified
    {
        get { return this.enforceMinQtyInternallyFieldSpecified; }
        set { this.enforceMinQtyInternallyFieldSpecified = value; }
    }

    /// <remarks/>
    public long maximumQuantity
    {
        get { return this.maximumQuantityField; }
        set { this.maximumQuantityField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool maximumQuantitySpecified
    {
        get { return this.maximumQuantityFieldSpecified; }
        set { this.maximumQuantityFieldSpecified = value; }
    }

    /// <remarks/>
    public string minimumQuantityUnits
    {
        get { return this.minimumQuantityUnitsField; }
        set { this.minimumQuantityUnitsField = value; }
    }

    /// <remarks/>
    public RecordRef softDescriptor
    {
        get { return this.softDescriptorField; }
        set { this.softDescriptorField = value; }
    }

    /// <remarks/>
    public RecordRef shipPackage
    {
        get { return this.shipPackageField; }
        set { this.shipPackageField = value; }
    }

    /// <remarks/>
    public bool shipIndividually
    {
        get { return this.shipIndividuallyField; }
        set { this.shipIndividuallyField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool shipIndividuallySpecified
    {
        get { return this.shipIndividuallyFieldSpecified; }
        set { this.shipIndividuallyFieldSpecified = value; }
    }

    /// <remarks/>
    public RecordRef costCategory
    {
        get { return this.costCategoryField; }
        set { this.costCategoryField = value; }
    }

    /// <remarks/>
    public bool pricesIncludeTax
    {
        get { return this.pricesIncludeTaxField; }
        set { this.pricesIncludeTaxField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool pricesIncludeTaxSpecified
    {
        get { return this.pricesIncludeTaxFieldSpecified; }
        set { this.pricesIncludeTaxFieldSpecified = value; }
    }

    /// <remarks/>
    public RecordRef purchasePriceVarianceAcct
    {
        get { return this.purchasePriceVarianceAcctField; }
        set { this.purchasePriceVarianceAcctField = value; }
    }

    /// <remarks/>
    public RecordRef quantityPricingSchedule
    {
        get { return this.quantityPricingScheduleField; }
        set { this.quantityPricingScheduleField = value; }
    }

    /// <remarks/>
    public string reorderPointUnits
    {
        get { return this.reorderPointUnitsField; }
        set { this.reorderPointUnitsField = value; }
    }

    /// <remarks/>
    public bool useMarginalRates
    {
        get { return this.useMarginalRatesField; }
        set { this.useMarginalRatesField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool useMarginalRatesSpecified
    {
        get { return this.useMarginalRatesFieldSpecified; }
        set { this.useMarginalRatesFieldSpecified = value; }
    }

    /// <remarks/>
    public string preferredStockLevelUnits
    {
        get { return this.preferredStockLevelUnitsField; }
        set { this.preferredStockLevelUnitsField = value; }
    }

    /// <remarks/>
    public ItemCostEstimateType costEstimateType
    {
        get { return this.costEstimateTypeField; }
        set { this.costEstimateTypeField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool costEstimateTypeSpecified
    {
        get { return this.costEstimateTypeFieldSpecified; }
        set { this.costEstimateTypeFieldSpecified = value; }
    }

    /// <remarks/>
    public double costEstimate
    {
        get { return this.costEstimateField; }
        set { this.costEstimateField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool costEstimateSpecified
    {
        get { return this.costEstimateFieldSpecified; }
        set { this.costEstimateFieldSpecified = value; }
    }

    /// <remarks/>
    public double transferPrice
    {
        get { return this.transferPriceField; }
        set { this.transferPriceField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool transferPriceSpecified
    {
        get { return this.transferPriceFieldSpecified; }
        set { this.transferPriceFieldSpecified = value; }
    }

    /// <remarks/>
    public ItemOverallQuantityPricingType overallQuantityPricingType
    {
        get { return this.overallQuantityPricingTypeField; }
        set { this.overallQuantityPricingTypeField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool overallQuantityPricingTypeSpecified
    {
        get { return this.overallQuantityPricingTypeFieldSpecified; }
        set { this.overallQuantityPricingTypeFieldSpecified = value; }
    }

    /// <remarks/>
    public RecordRef pricingGroup
    {
        get { return this.pricingGroupField; }
        set { this.pricingGroupField = value; }
    }

    /// <remarks/>
    public double vsoePrice
    {
        get { return this.vsoePriceField; }
        set { this.vsoePriceField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool vsoePriceSpecified
    {
        get { return this.vsoePriceFieldSpecified; }
        set { this.vsoePriceFieldSpecified = value; }
    }

    /// <remarks/>
    public VsoeSopGroup vsoeSopGroup
    {
        get { return this.vsoeSopGroupField; }
        set { this.vsoeSopGroupField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool vsoeSopGroupSpecified
    {
        get { return this.vsoeSopGroupFieldSpecified; }
        set { this.vsoeSopGroupFieldSpecified = value; }
    }

    /// <remarks/>
    public string costEstimateUnits
    {
        get { return this.costEstimateUnitsField; }
        set { this.costEstimateUnitsField = value; }
    }

    /// <remarks/>
    public VsoeDeferral vsoeDeferral
    {
        get { return this.vsoeDeferralField; }
        set { this.vsoeDeferralField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool vsoeDeferralSpecified
    {
        get { return this.vsoeDeferralFieldSpecified; }
        set { this.vsoeDeferralFieldSpecified = value; }
    }

    /// <remarks/>
    public VsoePermitDiscount vsoePermitDiscount
    {
        get { return this.vsoePermitDiscountField; }
        set { this.vsoePermitDiscountField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool vsoePermitDiscountSpecified
    {
        get { return this.vsoePermitDiscountFieldSpecified; }
        set { this.vsoePermitDiscountFieldSpecified = value; }
    }

    /// <remarks/>
    public bool vsoeDelivered
    {
        get { return this.vsoeDeliveredField; }
        set { this.vsoeDeliveredField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool vsoeDeliveredSpecified
    {
        get { return this.vsoeDeliveredFieldSpecified; }
        set { this.vsoeDeliveredFieldSpecified = value; }
    }

    /// <remarks/>
    public RecordRef itemRevenueCategory
    {
        get { return this.itemRevenueCategoryField; }
        set { this.itemRevenueCategoryField = value; }
    }

    /// <remarks/>
    public RecordRef preferredLocation
    {
        get { return this.preferredLocationField; }
        set { this.preferredLocationField = value; }
    }

    /// <remarks/>
    public bool isStorePickupAllowed
    {
        get { return this.isStorePickupAllowedField; }
        set { this.isStorePickupAllowedField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool isStorePickupAllowedSpecified
    {
        get { return this.isStorePickupAllowedFieldSpecified; }
        set { this.isStorePickupAllowedFieldSpecified = value; }
    }

    /// <remarks/>
    public long reorderMultiple
    {
        get { return this.reorderMultipleField; }
        set { this.reorderMultipleField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool reorderMultipleSpecified
    {
        get { return this.reorderMultipleFieldSpecified; }
        set { this.reorderMultipleFieldSpecified = value; }
    }

    /// <remarks/>
    public double cost
    {
        get { return this.costField; }
        set { this.costField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool costSpecified
    {
        get { return this.costFieldSpecified; }
        set { this.costFieldSpecified = value; }
    }

    /// <remarks/>
    public DateTime lastInvtCountDate
    {
        get { return this.lastInvtCountDateField; }
        set { this.lastInvtCountDateField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool lastInvtCountDateSpecified
    {
        get { return this.lastInvtCountDateFieldSpecified; }
        set { this.lastInvtCountDateFieldSpecified = value; }
    }

    /// <remarks/>
    public DateTime nextInvtCountDate
    {
        get { return this.nextInvtCountDateField; }
        set { this.nextInvtCountDateField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool nextInvtCountDateSpecified
    {
        get { return this.nextInvtCountDateFieldSpecified; }
        set { this.nextInvtCountDateFieldSpecified = value; }
    }

    /// <remarks/>
    public long invtCountInterval
    {
        get { return this.invtCountIntervalField; }
        set { this.invtCountIntervalField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool invtCountIntervalSpecified
    {
        get { return this.invtCountIntervalFieldSpecified; }
        set { this.invtCountIntervalFieldSpecified = value; }
    }

    /// <remarks/>
    public ItemInvtClassification invtClassification
    {
        get { return this.invtClassificationField; }
        set { this.invtClassificationField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool invtClassificationSpecified
    {
        get { return this.invtClassificationFieldSpecified; }
        set { this.invtClassificationFieldSpecified = value; }
    }

    /// <remarks/>
    public string costUnits
    {
        get { return this.costUnitsField; }
        set { this.costUnitsField = value; }
    }

    /// <remarks/>
    public double totalValue
    {
        get { return this.totalValueField; }
        set { this.totalValueField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool totalValueSpecified
    {
        get { return this.totalValueFieldSpecified; }
        set { this.totalValueFieldSpecified = value; }
    }

    /// <remarks/>
    public double averageCost
    {
        get { return this.averageCostField; }
        set { this.averageCostField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool averageCostSpecified
    {
        get { return this.averageCostFieldSpecified; }
        set { this.averageCostFieldSpecified = value; }
    }

    /// <remarks/>
    public bool useBins
    {
        get { return this.useBinsField; }
        set { this.useBinsField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool useBinsSpecified
    {
        get { return this.useBinsFieldSpecified; }
        set { this.useBinsFieldSpecified = value; }
    }

    /// <remarks/>
    public string quantityReorderUnits
    {
        get { return this.quantityReorderUnitsField; }
        set { this.quantityReorderUnitsField = value; }
    }

    /// <remarks/>
    public long leadTime
    {
        get { return this.leadTimeField; }
        set { this.leadTimeField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool leadTimeSpecified
    {
        get { return this.leadTimeFieldSpecified; }
        set { this.leadTimeFieldSpecified = value; }
    }

    /// <remarks/>
    public bool autoLeadTime
    {
        get { return this.autoLeadTimeField; }
        set { this.autoLeadTimeField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool autoLeadTimeSpecified
    {
        get { return this.autoLeadTimeFieldSpecified; }
        set { this.autoLeadTimeFieldSpecified = value; }
    }

    /// <remarks/>
    public double lastPurchasePrice
    {
        get { return this.lastPurchasePriceField; }
        set { this.lastPurchasePriceField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool lastPurchasePriceSpecified
    {
        get { return this.lastPurchasePriceFieldSpecified; }
        set { this.lastPurchasePriceFieldSpecified = value; }
    }

    /// <remarks/>
    public bool autoPreferredStockLevel
    {
        get { return this.autoPreferredStockLevelField; }
        set { this.autoPreferredStockLevelField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool autoPreferredStockLevelSpecified
    {
        get { return this.autoPreferredStockLevelFieldSpecified; }
        set { this.autoPreferredStockLevelFieldSpecified = value; }
    }

    /// <remarks/>
    public double preferredStockLevelDays
    {
        get { return this.preferredStockLevelDaysField; }
        set { this.preferredStockLevelDaysField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool preferredStockLevelDaysSpecified
    {
        get { return this.preferredStockLevelDaysFieldSpecified; }
        set { this.preferredStockLevelDaysFieldSpecified = value; }
    }

    /// <remarks/>
    public double safetyStockLevel
    {
        get { return this.safetyStockLevelField; }
        set { this.safetyStockLevelField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool safetyStockLevelSpecified
    {
        get { return this.safetyStockLevelFieldSpecified; }
        set { this.safetyStockLevelFieldSpecified = value; }
    }

    /// <remarks/>
    public long safetyStockLevelDays
    {
        get { return this.safetyStockLevelDaysField; }
        set { this.safetyStockLevelDaysField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool safetyStockLevelDaysSpecified
    {
        get { return this.safetyStockLevelDaysFieldSpecified; }
        set { this.safetyStockLevelDaysFieldSpecified = value; }
    }

    /// <remarks/>
    public long backwardConsumptionDays
    {
        get { return this.backwardConsumptionDaysField; }
        set { this.backwardConsumptionDaysField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool backwardConsumptionDaysSpecified
    {
        get { return this.backwardConsumptionDaysFieldSpecified; }
        set { this.backwardConsumptionDaysFieldSpecified = value; }
    }

    /// <remarks/>
    public bool seasonalDemand
    {
        get { return this.seasonalDemandField; }
        set { this.seasonalDemandField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool seasonalDemandSpecified
    {
        get { return this.seasonalDemandFieldSpecified; }
        set { this.seasonalDemandFieldSpecified = value; }
    }

    /// <remarks/>
    public string safetyStockLevelUnits
    {
        get { return this.safetyStockLevelUnitsField; }
        set { this.safetyStockLevelUnitsField = value; }
    }

    /// <remarks/>
    public double demandModifier
    {
        get { return this.demandModifierField; }
        set { this.demandModifierField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool demandModifierSpecified
    {
        get { return this.demandModifierFieldSpecified; }
        set { this.demandModifierFieldSpecified = value; }
    }

    /// <remarks/>
    public RecordRef distributionNetwork
    {
        get { return this.distributionNetworkField; }
        set { this.distributionNetworkField = value; }
    }

    /// <remarks/>
    public RecordRef distributionCategory
    {
        get { return this.distributionCategoryField; }
        set { this.distributionCategoryField = value; }
    }

    /// <remarks/>
    public bool autoReorderPoint
    {
        get { return this.autoReorderPointField; }
        set { this.autoReorderPointField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool autoReorderPointSpecified
    {
        get { return this.autoReorderPointFieldSpecified; }
        set { this.autoReorderPointFieldSpecified = value; }
    }

    /// <remarks/>
    public string storeDisplayName
    {
        get { return this.storeDisplayNameField; }
        set { this.storeDisplayNameField = value; }
    }

    /// <remarks/>
    public RecordRef storeDisplayThumbnail
    {
        get { return this.storeDisplayThumbnailField; }
        set { this.storeDisplayThumbnailField = value; }
    }

    /// <remarks/>
    public RecordRef storeDisplayImage
    {
        get { return this.storeDisplayImageField; }
        set { this.storeDisplayImageField = value; }
    }

    /// <remarks/>
    public string storeDescription
    {
        get { return this.storeDescriptionField; }
        set { this.storeDescriptionField = value; }
    }

    /// <remarks/>
    public string storeDetailedDescription
    {
        get { return this.storeDetailedDescriptionField; }
        set { this.storeDetailedDescriptionField = value; }
    }

    /// <remarks/>
    public RecordRef storeItemTemplate
    {
        get { return this.storeItemTemplateField; }
        set { this.storeItemTemplateField = value; }
    }

    /// <remarks/>
    public string pageTitle
    {
        get { return this.pageTitleField; }
        set { this.pageTitleField = value; }
    }

    /// <remarks/>
    public string metaTagHtml
    {
        get { return this.metaTagHtmlField; }
        set { this.metaTagHtmlField = value; }
    }

    /// <remarks/>
    public bool excludeFromSitemap
    {
        get { return this.excludeFromSitemapField; }
        set { this.excludeFromSitemapField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool excludeFromSitemapSpecified
    {
        get { return this.excludeFromSitemapFieldSpecified; }
        set { this.excludeFromSitemapFieldSpecified = value; }
    }

    /// <remarks/>
    public SitemapPriority sitemapPriority
    {
        get { return this.sitemapPriorityField; }
        set { this.sitemapPriorityField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool sitemapPrioritySpecified
    {
        get { return this.sitemapPriorityFieldSpecified; }
        set { this.sitemapPriorityFieldSpecified = value; }
    }

    /// <remarks/>
    public string searchKeywords
    {
        get { return this.searchKeywordsField; }
        set { this.searchKeywordsField = value; }
    }

    /// <remarks/>
    public bool isDonationItem
    {
        get { return this.isDonationItemField; }
        set { this.isDonationItemField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool isDonationItemSpecified
    {
        get { return this.isDonationItemFieldSpecified; }
        set { this.isDonationItemFieldSpecified = value; }
    }

    /// <remarks/>
    public bool showDefaultDonationAmount
    {
        get { return this.showDefaultDonationAmountField; }
        set { this.showDefaultDonationAmountField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool showDefaultDonationAmountSpecified
    {
        get { return this.showDefaultDonationAmountFieldSpecified; }
        set { this.showDefaultDonationAmountFieldSpecified = value; }
    }

    /// <remarks/>
    public double maxDonationAmount
    {
        get { return this.maxDonationAmountField; }
        set { this.maxDonationAmountField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool maxDonationAmountSpecified
    {
        get { return this.maxDonationAmountFieldSpecified; }
        set { this.maxDonationAmountFieldSpecified = value; }
    }

    /// <remarks/>
    public bool dontShowPrice
    {
        get { return this.dontShowPriceField; }
        set { this.dontShowPriceField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool dontShowPriceSpecified
    {
        get { return this.dontShowPriceFieldSpecified; }
        set { this.dontShowPriceFieldSpecified = value; }
    }

    /// <remarks/>
    public string noPriceMessage
    {
        get { return this.noPriceMessageField; }
        set { this.noPriceMessageField = value; }
    }

    /// <remarks/>
    public string outOfStockMessage
    {
        get { return this.outOfStockMessageField; }
        set { this.outOfStockMessageField = value; }
    }

    /// <remarks/>
    public bool onSpecial
    {
        get { return this.onSpecialField; }
        set { this.onSpecialField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool onSpecialSpecified
    {
        get { return this.onSpecialFieldSpecified; }
        set { this.onSpecialFieldSpecified = value; }
    }

    /// <remarks/>
    public ItemOutOfStockBehavior outOfStockBehavior
    {
        get { return this.outOfStockBehaviorField; }
        set { this.outOfStockBehaviorField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool outOfStockBehaviorSpecified
    {
        get { return this.outOfStockBehaviorFieldSpecified; }
        set { this.outOfStockBehaviorFieldSpecified = value; }
    }

    /// <remarks/>
    public string relatedItemsDescription
    {
        get { return this.relatedItemsDescriptionField; }
        set { this.relatedItemsDescriptionField = value; }
    }

    /// <remarks/>
    public string specialsDescription
    {
        get { return this.specialsDescriptionField; }
        set { this.specialsDescriptionField = value; }
    }

    /// <remarks/>
    public string featuredDescription
    {
        get { return this.featuredDescriptionField; }
        set { this.featuredDescriptionField = value; }
    }

    /// <remarks/>
    public string shoppingDotComCategory
    {
        get { return this.shoppingDotComCategoryField; }
        set { this.shoppingDotComCategoryField = value; }
    }

    /// <remarks/>
    public long shopzillaCategoryId
    {
        get { return this.shopzillaCategoryIdField; }
        set { this.shopzillaCategoryIdField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool shopzillaCategoryIdSpecified
    {
        get { return this.shopzillaCategoryIdFieldSpecified; }
        set { this.shopzillaCategoryIdFieldSpecified = value; }
    }

    /// <remarks/>
    public string nexTagCategory
    {
        get { return this.nexTagCategoryField; }
        set { this.nexTagCategoryField = value; }
    }

    /// <remarks/>
    public string urlComponent
    {
        get { return this.urlComponentField; }
        set { this.urlComponentField = value; }
    }

    /// <remarks/>
    public RecordRef customForm
    {
        get { return this.customFormField; }
        set { this.customFormField = value; }
    }

    /// <remarks/>
    public string itemId
    {
        get { return this.itemIdField; }
        set { this.itemIdField = value; }
    }

    public string id
    {
        get { return this.idField; }
        set { this.idField = value; }
    }

    /// <remarks/>
    public string upcCode
    {
        get { return this.upcCodeField; }
        set { this.upcCodeField = value; }
    }

    /// <remarks/>
    public string displayName
    {
        get { return this.displayNameField; }
        set { this.displayNameField = value; }
    }

    public string fullname
    {
        get { return this.fullnameField; }
        set { this.fullnameField = value; }
    }

    /// <remarks/>
    public string vendorName
    {
        get { return this.vendorNameField; }
        set { this.vendorNameField = value; }
    }

    /// <remarks/>
    public RecordRef parent
    {
        get { return this.parentField; }
        set { this.parentField = value; }
    }

    /// <remarks/>
    public bool isOnline
    {
        get { return this.isOnlineField; }
        set { this.isOnlineField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool isOnlineSpecified
    {
        get { return this.isOnlineFieldSpecified; }
        set { this.isOnlineFieldSpecified = value; }
    }

    /// <remarks/>
    public bool isHazmatItem
    {
        get { return this.isHazmatItemField; }
        set { this.isHazmatItemField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool isHazmatItemSpecified
    {
        get { return this.isHazmatItemFieldSpecified; }
        set { this.isHazmatItemFieldSpecified = value; }
    }

    /// <remarks/>
    public string hazmatId
    {
        get { return this.hazmatIdField; }
        set { this.hazmatIdField = value; }
    }

    /// <remarks/>
    public string hazmatShippingName
    {
        get { return this.hazmatShippingNameField; }
        set { this.hazmatShippingNameField = value; }
    }

    /// <remarks/>
    public string hazmatHazardClass
    {
        get { return this.hazmatHazardClassField; }
        set { this.hazmatHazardClassField = value; }
    }

    /// <remarks/>
    public HazmatPackingGroup hazmatPackingGroup
    {
        get { return this.hazmatPackingGroupField; }
        set { this.hazmatPackingGroupField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool hazmatPackingGroupSpecified
    {
        get { return this.hazmatPackingGroupFieldSpecified; }
        set { this.hazmatPackingGroupFieldSpecified = value; }
    }

    /// <remarks/>
    public string hazmatItemUnits
    {
        get { return this.hazmatItemUnitsField; }
        set { this.hazmatItemUnitsField = value; }
    }

    /// <remarks/>
    public double hazmatItemUnitsQty
    {
        get { return this.hazmatItemUnitsQtyField; }
        set { this.hazmatItemUnitsQtyField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool hazmatItemUnitsQtySpecified
    {
        get { return this.hazmatItemUnitsQtyFieldSpecified; }
        set { this.hazmatItemUnitsQtyFieldSpecified = value; }
    }

    /// <remarks/>
    public bool isGcoCompliant
    {
        get { return this.isGcoCompliantField; }
        set { this.isGcoCompliantField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool isGcoCompliantSpecified
    {
        get { return this.isGcoCompliantFieldSpecified; }
        set { this.isGcoCompliantFieldSpecified = value; }
    }

    /// <remarks/>
    public bool offerSupport
    {
        get { return this.offerSupportField; }
        set { this.offerSupportField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool offerSupportSpecified
    {
        get { return this.offerSupportFieldSpecified; }
        set { this.offerSupportFieldSpecified = value; }
    }

    /// <remarks/>
    public bool isInactive
    {
        get { return this.isInactiveField; }
        set { this.isInactiveField = value; }
    }

    /// <remarks/>
    public bool isLotItem
    {
        get { return this.isLotItemField; }
        set { this.isLotItemField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool isInactiveSpecified
    {
        get { return this.isInactiveFieldSpecified; }
        set { this.isInactiveFieldSpecified = value; }
    }

    /// <remarks/>
    public bool availableToPartners
    {
        get { return this.availableToPartnersField; }
        set { this.availableToPartnersField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool availableToPartnersSpecified
    {
        get { return this.availableToPartnersFieldSpecified; }
        set { this.availableToPartnersFieldSpecified = value; }
    }

    /// <remarks/>
    public RecordRef department
    {
        get { return this.departmentField; }
        set { this.departmentField = value; }
    }

    /// <remarks/>
    public RecordRef @class
    {
        get { return this.classField; }
        set { this.classField = value; }
    }

    /// <remarks/>
    public RecordRef location
    {
        get { return this.locationField; }
        set { this.locationField = value; }
    }

    /// <remarks/>
    public ItemCostingMethod costingMethod
    {
        get { return this.costingMethodField; }
        set { this.costingMethodField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool costingMethodSpecified
    {
        get { return this.costingMethodFieldSpecified; }
        set { this.costingMethodFieldSpecified = value; }
    }

    /// <remarks/>
    public string currency
    {
        get { return this.currencyField; }
        set { this.currencyField = value; }
    }

    /// <remarks/>
    public double preferredStockLevel
    {
        get { return this.preferredStockLevelField; }
        set { this.preferredStockLevelField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool preferredStockLevelSpecified
    {
        get { return this.preferredStockLevelFieldSpecified; }
        set { this.preferredStockLevelFieldSpecified = value; }
    }

    /// <remarks/>
    public PricingMatrix pricingMatrix
    {
        get { return this.pricingMatrixField; }
        set { this.pricingMatrixField = value; }
    }

    /// <remarks/>
    public InventoryItemHierarchyVersionsList hierarchyVersionsList
    {
        get { return this.hierarchyVersionsListField; }
        set { this.hierarchyVersionsListField = value; }
    }

    /// <remarks/>
    public ItemAccountingBookDetailList accountingBookDetailList
    {
        get { return this.accountingBookDetailListField; }
        set { this.accountingBookDetailListField = value; }
    }

    /// <remarks/>
    public RecordRef purchaseTaxCode
    {
        get { return this.purchaseTaxCodeField; }
        set { this.purchaseTaxCodeField = value; }
    }

    /// <remarks/>
    public double defaultReturnCost
    {
        get { return this.defaultReturnCostField; }
        set { this.defaultReturnCostField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool defaultReturnCostSpecified
    {
        get { return this.defaultReturnCostFieldSpecified; }
        set { this.defaultReturnCostFieldSpecified = value; }
    }

    /// <remarks/>
    public RecordRef supplyReplenishmentMethod
    {
        get { return this.supplyReplenishmentMethodField; }
        set { this.supplyReplenishmentMethodField = value; }
    }

    /// <remarks/>
    public RecordRef alternateDemandSourceItem
    {
        get { return this.alternateDemandSourceItemField; }
        set { this.alternateDemandSourceItemField = value; }
    }

    /// <remarks/>
    public double fixedLotSize
    {
        get { return this.fixedLotSizeField; }
        set { this.fixedLotSizeField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool fixedLotSizeSpecified
    {
        get { return this.fixedLotSizeFieldSpecified; }
        set { this.fixedLotSizeFieldSpecified = value; }
    }

    /// <remarks/>
    public PeriodicLotSizeType periodicLotSizeType
    {
        get { return this.periodicLotSizeTypeField; }
        set { this.periodicLotSizeTypeField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool periodicLotSizeTypeSpecified
    {
        get { return this.periodicLotSizeTypeFieldSpecified; }
        set { this.periodicLotSizeTypeFieldSpecified = value; }
    }

    /// <remarks/>
    public RecordRef supplyType
    {
        get { return this.supplyTypeField; }
        set { this.supplyTypeField = value; }
    }

    /// <remarks/>
    public long demandTimeFence
    {
        get { return this.demandTimeFenceField; }
        set { this.demandTimeFenceField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool demandTimeFenceSpecified
    {
        get { return this.demandTimeFenceFieldSpecified; }
        set { this.demandTimeFenceFieldSpecified = value; }
    }

    /// <remarks/>
    public long supplyTimeFence
    {
        get { return this.supplyTimeFenceField; }
        set { this.supplyTimeFenceField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool supplyTimeFenceSpecified
    {
        get { return this.supplyTimeFenceFieldSpecified; }
        set { this.supplyTimeFenceFieldSpecified = value; }
    }

    /// <remarks/>
    public long rescheduleInDays
    {
        get { return this.rescheduleInDaysField; }
        set { this.rescheduleInDaysField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool rescheduleInDaysSpecified
    {
        get { return this.rescheduleInDaysFieldSpecified; }
        set { this.rescheduleInDaysFieldSpecified = value; }
    }

    /// <remarks/>
    public long rescheduleOutDays
    {
        get { return this.rescheduleOutDaysField; }
        set { this.rescheduleOutDaysField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool rescheduleOutDaysSpecified
    {
        get { return this.rescheduleOutDaysFieldSpecified; }
        set { this.rescheduleOutDaysFieldSpecified = value; }
    }

    /// <remarks/>
    public long periodicLotSizeDays
    {
        get { return this.periodicLotSizeDaysField; }
        set { this.periodicLotSizeDaysField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool periodicLotSizeDaysSpecified
    {
        get { return this.periodicLotSizeDaysFieldSpecified; }
        set { this.periodicLotSizeDaysFieldSpecified = value; }
    }

    /// <remarks/>
    public RecordRef supplyLotSizingMethod
    {
        get { return this.supplyLotSizingMethodField; }
        set { this.supplyLotSizingMethodField = value; }
    }

    /// <remarks/>
    public long forwardConsumptionDays
    {
        get { return this.forwardConsumptionDaysField; }
        set { this.forwardConsumptionDaysField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool forwardConsumptionDaysSpecified
    {
        get { return this.forwardConsumptionDaysFieldSpecified; }
        set { this.forwardConsumptionDaysFieldSpecified = value; }
    }

    /// <remarks/>
    public RecordRef demandSource
    {
        get { return this.demandSourceField; }
        set { this.demandSourceField = value; }
    }

    /// <remarks/>
    public double quantityBackOrdered
    {
        get { return this.quantityBackOrderedField; }
        set { this.quantityBackOrderedField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool quantityBackOrderedSpecified
    {
        get { return this.quantityBackOrderedFieldSpecified; }
        set { this.quantityBackOrderedFieldSpecified = value; }
    }

    /// <remarks/>
    public double quantityCommitted
    {
        get { return this.quantityCommittedField; }
        set { this.quantityCommittedField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool quantityCommittedSpecified
    {
        get { return this.quantityCommittedFieldSpecified; }
        set { this.quantityCommittedFieldSpecified = value; }
    }

    /// <remarks/>
    public double quantityAvailable
    {
        get { return this.quantityAvailableField; }
        set { this.quantityAvailableField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool quantityAvailableSpecified
    {
        get { return this.quantityAvailableFieldSpecified; }
        set { this.quantityAvailableFieldSpecified = value; }
    }

    /// <remarks/>
    public double quantityOnHand
    {
        get { return this.quantityOnHandField; }
        set { this.quantityOnHandField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool quantityOnHandSpecified
    {
        get { return this.quantityOnHandFieldSpecified; }
        set { this.quantityOnHandFieldSpecified = value; }
    }

    /// <remarks/>
    public double onHandValueMli
    {
        get { return this.onHandValueMliField; }
        set { this.onHandValueMliField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool onHandValueMliSpecified
    {
        get { return this.onHandValueMliFieldSpecified; }
        set { this.onHandValueMliFieldSpecified = value; }
    }

    /// <remarks/>
    public double quantityOnOrder
    {
        get { return this.quantityOnOrderField; }
        set { this.quantityOnOrderField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool quantityOnOrderSpecified
    {
        get { return this.quantityOnOrderFieldSpecified; }
        set { this.quantityOnOrderFieldSpecified = value; }
    }

    /// <remarks/>
    public double rate
    {
        get { return this.rateField; }
        set { this.rateField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool rateSpecified
    {
        get { return this.rateFieldSpecified; }
        set { this.rateFieldSpecified = value; }
    }

    /// <remarks/>
    public double reorderPoint
    {
        get { return this.reorderPointField; }
        set { this.reorderPointField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool reorderPointSpecified
    {
        get { return this.reorderPointFieldSpecified; }
        set { this.reorderPointFieldSpecified = value; }
    }

    /// <remarks/>
    public string quantityCommittedUnits
    {
        get { return this.quantityCommittedUnitsField; }
        set { this.quantityCommittedUnitsField = value; }
    }

    /// <remarks/>
    public RecordRef salesTaxCode
    {
        get { return this.salesTaxCodeField; }
        set { this.salesTaxCodeField = value; }
    }

    /// <remarks/>
    public string quantityAvailableUnits
    {
        get { return this.quantityAvailableUnitsField; }
        set { this.quantityAvailableUnitsField = value; }
    }

    /// <remarks/>
    public string quantityOnHandUnits
    {
        get { return this.quantityOnHandUnitsField; }
        set { this.quantityOnHandUnitsField = value; }
    }

    /// <remarks/>
    public RecordRef vendor
    {
        get { return this.vendorField; }
        set { this.vendorField = value; }
    }

    /// <remarks/>
    public string quantityOnOrderUnits
    {
        get { return this.quantityOnOrderUnitsField; }
        set { this.quantityOnOrderUnitsField = value; }
    }

    /// <remarks/>
    [XmlArrayItem("productFeed", IsNullable = false)]
    public ItemProductFeed[] productFeedList
    {
        get { return this.productFeedListField; }
        set { this.productFeedListField = value; }
    }

    /// <remarks/>
    [XmlArrayItem("recordRef", Namespace = "urn:core_2021_1.platform.webservices.netsuite.com", IsNullable = false)]
    public RecordRef[] subsidiaryList
    {
        get { return this.subsidiaryListField; }
        set { this.subsidiaryListField = value; }
    }

    /// <remarks/>
    [XmlArrayItem("itemOptions", IsNullable = false)]
    public RecordRef[] itemOptionsList
    {
        get { return this.itemOptionsListField; }
        set { this.itemOptionsListField = value; }
    }

    /// <remarks/>
    public ItemVendorList itemVendorList
    {
        get { return this.itemVendorListField; }
        set { this.itemVendorListField = value; }
    }

    /// <remarks/>
    public SiteCategoryList siteCategoryList
    {
        get { return this.siteCategoryListField; }
        set { this.siteCategoryListField = value; }
    }

    /// <remarks/>
    public TranslationList translationsList
    {
        get { return this.translationsListField; }
        set { this.translationsListField = value; }
    }

    /// <remarks/>
    public InventoryItemBinNumberList binNumberList
    {
        get { return this.binNumberListField; }
        set { this.binNumberListField = value; }
    }

    /// <remarks/>
    public InventoryItemLocationsList locationsList
    {
        get { return this.locationsListField; }
        set { this.locationsListField = value; }
    }

    /// <remarks/>
    [XmlArrayItem("matrixOption", IsNullable = false)]
    public SelectCustomFieldRef[] matrixOptionList
    {
        get { return this.matrixOptionListField; }
        set { this.matrixOptionListField = value; }
    }

    /// <remarks/>
    public PresentationItemList presentationItemList
    {
        get { return this.presentationItemListField; }
        set { this.presentationItemListField = value; }
    }

    /// <remarks/>
    public long futureHorizon
    {
        get { return this.futureHorizonField; }
        set { this.futureHorizonField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool futureHorizonSpecified
    {
        get { return this.futureHorizonFieldSpecified; }
        set { this.futureHorizonFieldSpecified = value; }
    }

    /// <remarks/>
    public RecordRef consumptionUnit
    {
        get { return this.consumptionUnitField; }
        set { this.consumptionUnitField = value; }
    }

    /// <remarks/>
    public bool enableCatchWeight
    {
        get { return this.enableCatchWeightField; }
        set { this.enableCatchWeightField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool enableCatchWeightSpecified
    {
        get { return this.enableCatchWeightFieldSpecified; }
        set { this.enableCatchWeightFieldSpecified = value; }
    }

    /// <remarks/>
    public RecordRef secondaryUnitsType
    {
        get { return this.secondaryUnitsTypeField; }
        set { this.secondaryUnitsTypeField = value; }
    }

    /// <remarks/>
    public RecordRef secondaryBaseUnit
    {
        get { return this.secondaryBaseUnitField; }
        set { this.secondaryBaseUnitField = value; }
    }

    /// <remarks/>
    public double conversionRate
    {
        get { return this.conversionRateField; }
        set { this.conversionRateField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool conversionRateSpecified
    {
        get { return this.conversionRateFieldSpecified; }
        set { this.conversionRateFieldSpecified = value; }
    }

    /// <remarks/>
    public RecordRef secondaryStockUnit
    {
        get { return this.secondaryStockUnitField; }
        set { this.secondaryStockUnitField = value; }
    }

    /// <remarks/>
    public RecordRef secondarySaleUnit
    {
        get { return this.secondarySaleUnitField; }
        set { this.secondarySaleUnitField = value; }
    }

    /// <remarks/>
    public RecordRef secondaryPurchaseUnit
    {
        get { return this.secondaryPurchaseUnitField; }
        set { this.secondaryPurchaseUnitField = value; }
    }

    /// <remarks/>
    public RecordRef secondaryConsumptionUnit
    {
        get { return this.secondaryConsumptionUnitField; }
        set { this.secondaryConsumptionUnitField = value; }
    }

    /// <remarks/>
    public double lowerWarningLimit
    {
        get { return this.lowerWarningLimitField; }
        set { this.lowerWarningLimitField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool lowerWarningLimitSpecified
    {
        get { return this.lowerWarningLimitFieldSpecified; }
        set { this.lowerWarningLimitFieldSpecified = value; }
    }

    /// <remarks/>
    public double upperWarningLimit
    {
        get { return this.upperWarningLimitField; }
        set { this.upperWarningLimitField = value; }
    }

    /// <remarks/>
    [XmlIgnore()]
    public bool upperWarningLimitSpecified
    {
        get { return this.upperWarningLimitFieldSpecified; }
        set { this.upperWarningLimitFieldSpecified = value; }
    }

    /// <remarks/>
    public RecordRef planningItemCategory
    {
        get { return this.planningItemCategoryField; }
        set { this.planningItemCategoryField = value; }
    }

    /// <remarks/>
    [XmlArrayItem("customField", Namespace = "urn:core_2021_1.platform.webservices.netsuite.com", IsNullable = false)]
    public CustomFieldRef[] customFieldList
    {
        get { return this.customFieldListField; }
        set { this.customFieldListField = value; }
    }

    /// <remarks/>
    [XmlAttribute()]
    public string internalId
    {
        get { return this.internalIdField; }
        set { this.internalIdField = value; }
    }

    /// <remarks/>
    [XmlAttribute()]
    public string externalId
    {
        get { return this.externalIdField; }
        set { this.externalIdField = value; }
    }
}
