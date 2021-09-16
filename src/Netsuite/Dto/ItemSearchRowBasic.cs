namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class ItemSearchRowBasic : SearchRowBasic {

        private SearchColumnSelectField[] accBookRevRecForecastRuleField;

        private SearchColumnSelectField[] accountingBookField;

        private SearchColumnSelectField[] accountingBookAmortizationField;

        private SearchColumnSelectField[] accountingBookCreatePlansOnField;

        private SearchColumnSelectField[] accountingBookRevRecRuleField;

        private SearchColumnSelectField[] accountingBookRevRecScheduleField;

        private SearchColumnSelectField[] allowedShippingMethodField;

        private SearchColumnStringField[] alternateDemandSourceItemField;

        private SearchColumnSelectField[] assetAccountField;

        private SearchColumnDoubleField[] atpLeadTimeField;

        private SearchColumnEnumSelectField[] atpMethodField;

        private SearchColumnBooleanField[] autoLeadTimeField;

        private SearchColumnBooleanField[] autoPreferredStockLevelField;

        private SearchColumnBooleanField[] autoReorderPointField;

        private SearchColumnBooleanField[] availableToPartnersField;

        private SearchColumnDoubleField[] averageCostField;

        private SearchColumnLongField[] backwardConsumptionDaysField;

        private SearchColumnDoubleField[] basePriceField;

        private SearchColumnSelectField[] billExchRateVarianceAcctField;

        private SearchColumnSelectField[] billPriceVarianceAcctField;

        private SearchColumnSelectField[] billQtyVarianceAcctField;

        private SearchColumnStringField[] binNumberField;

        private SearchColumnDoubleField[] binOnHandAvailField;

        private SearchColumnDoubleField[] binOnHandCountField;

        private SearchColumnDoubleField[] bomQuantityField;

        private SearchColumnBooleanField[] buildEntireAssemblyField;

        private SearchColumnDoubleField[] buildTimeField;

        private SearchColumnDoubleField[] buildTimeLotSizeField;

        private SearchColumnDoubleField[] buyItNowPriceField;

        private SearchColumnStringField[] categoryField;

        private SearchColumnStringField[] categoryPreferredField;

        private SearchColumnSelectField[] classField;

        private SearchColumnDoubleField[] componentYieldField;

        private SearchColumnSelectField[] consumptionUnitField;

        private SearchColumnBooleanField[] contingentRevenueHandlingField;

        private SearchColumnDoubleField[] conversionRateField;

        private SearchColumnBooleanField[] copyDescriptionField;

        private SearchColumnSelectField[] correlatedItemField;

        private SearchColumnDoubleField[] correlatedItemCorrelationField;

        private SearchColumnLongField[] correlatedItemCountField;

        private SearchColumnDoubleField[] correlatedItemLiftField;

        private SearchColumnDoubleField[] correlatedItemPurchaseRateField;

        private SearchColumnDoubleField[] costField;

        private SearchColumnEnumSelectField[] costAccountingStatusField;

        private SearchColumnStringField[] costCategoryField;

        private SearchColumnDoubleField[] costEstimateField;

        private SearchColumnEnumSelectField[] costEstimateTypeField;

        private SearchColumnEnumSelectField[] costingMethodField;

        private SearchColumnEnumSelectField[] countryOfManufactureField;

        private SearchColumnDateField[] createdField;

        private SearchColumnBooleanField[] createJobField;

        private SearchColumnSelectField[] createRevenuePlansOnField;

        private SearchColumnSelectField[] custReturnVarianceAccountField;

        private SearchColumnDateField[] dateViewedField;

        private SearchColumnStringField[] daysBeforeExpirationField;

        private SearchColumnDoubleField[] defaultReturnCostField;

        private SearchColumnStringField[] defaultShippingMethodField;

        private SearchColumnSelectField[] deferredExpenseAccountField;

        private SearchColumnSelectField[] deferredRevenueAccountField;

        private SearchColumnBooleanField[] deferRevRecField;

        private SearchColumnDoubleField[] demandModifierField;

        private SearchColumnEnumSelectField[] demandSourceField;

        private SearchColumnLongField[] demandTimeFenceField;

        private SearchColumnSelectField[] departmentField;

        private SearchColumnSelectField[] departmentnohierarchyField;

        private SearchColumnBooleanField[] directRevenuePostingField;

        private SearchColumnBooleanField[] displayIneBayStoreField;

        private SearchColumnStringField[] displayNameField;

        private SearchColumnSelectField[] distributionCategoryField;

        private SearchColumnSelectField[] distributionNetworkField;

        private SearchColumnBooleanField[] dontShowPriceField;

        private SearchColumnStringField[] eBayItemDescriptionField;

        private SearchColumnStringField[] eBayItemSubtitleField;

        private SearchColumnStringField[] eBayItemTitleField;

        private SearchColumnEnumSelectField[] ebayRelistingOptionField;

        private SearchColumnEnumSelectField[] effectiveBomControlField;

        private SearchColumnDateField[] effectiveDateField;

        private SearchColumnSelectField[] effectiveRevisionField;

        private SearchColumnBooleanField[] enableCatchWeightField;

        private SearchColumnBooleanField[] endAuctionsWhenOutOfStockField;

        private SearchColumnBooleanField[] excludeFromSitemapField;

        private SearchColumnSelectField[] expenseAccountField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnStringField[] featuredDescriptionField;

        private SearchColumnStringField[] feedDescriptionField;

        private SearchColumnStringField[] feedNameField;

        private SearchColumnDoubleField[] fixedBuildTimeField;

        private SearchColumnDoubleField[] fixedLotSizeField;

        private SearchColumnLongField[] forwardConsumptionDaysField;

        private SearchColumnEnumSelectField[] fraudRiskField;

        private SearchColumnBooleanField[] froogleProductFeedField;

        private SearchColumnLongField[] futureHorizonField;

        private SearchColumnDoubleField[] fxCostField;

        private SearchColumnSelectField[] gainLossAccountField;

        private SearchColumnBooleanField[] generateAccrualsField;

        private SearchColumnStringField[] giftCertAuthCodeField;

        private SearchColumnStringField[] giftCertEmailField;

        private SearchColumnStringField[] giftCertExpirationDateField;

        private SearchColumnStringField[] giftCertFromField;

        private SearchColumnStringField[] giftCertMessageField;

        private SearchColumnStringField[] giftCertOriginalAmountField;

        private SearchColumnStringField[] giftCertRecipientField;

        private SearchColumnStringField[] hierarchyNodeField;

        private SearchColumnStringField[] hierarchyVersionField;

        private SearchColumnLongField[] hitsField;

        private SearchColumnStringField[] imageUrlField;

        private SearchColumnBooleanField[] includeChildrenField;

        private SearchColumnSelectField[] incomeAccountField;

        private SearchColumnSelectField[] intercoDefRevAccountField;

        private SearchColumnSelectField[] intercoExpenseAccountField;

        private SearchColumnSelectField[] intercoIncomeAccountField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnSelectField[] inventoryLocationField;

        private SearchColumnEnumSelectField[] invtClassificationField;

        private SearchColumnLongField[] invtCountIntervalField;

        private SearchColumnBooleanField[] isAvailableField;

        private SearchColumnBooleanField[] isDropShipItemField;

        private SearchColumnBooleanField[] isFulfillableField;

        private SearchColumnBooleanField[] isGcoCompliantField;

        private SearchColumnBooleanField[] isInactiveField;

        private SearchColumnBooleanField[] isLotItemField;

        private SearchColumnBooleanField[] isOnlineField;

        private SearchColumnBooleanField[] isSerialItemField;

        private SearchColumnBooleanField[] isSpecialOrderItemField;

        private SearchColumnBooleanField[] isSpecialWorkOrderItemField;

        private SearchColumnBooleanField[] isStorePickupAllowedField;

        private SearchColumnSelectField[] issueProductField;

        private SearchColumnBooleanField[] isTaxableField;

        private SearchColumnBooleanField[] isVsoeBundleField;

        private SearchColumnBooleanField[] isWipField;

        private SearchColumnStringField[] itemIdField;

        private SearchColumnSelectField[] itemRevenueCategoryField;

        private SearchColumnStringField[] itemUrlField;

        private SearchColumnDateField[] lastInvtCountDateField;

        private SearchColumnDoubleField[] lastPurchasePriceField;

        private SearchColumnDateField[] lastQuantityAvailableChangeField;

        private SearchColumnLongField[] leadTimeField;

        private SearchColumnSelectField[] liabilityAccountField;

        private SearchColumnEnumSelectField[] listingDurationField;

        private SearchColumnSelectField[] locationField;

        private SearchColumnBooleanField[] locationAllowStorePickupField;

        private SearchColumnDoubleField[] locationAtpLeadTimeField;

        private SearchColumnDoubleField[] locationAverageCostField;

        private SearchColumnStringField[] locationBinQuantityAvailableField;

        private SearchColumnDoubleField[] locationBuildTimeField;

        private SearchColumnDoubleField[] locationCostField;

        private SearchColumnEnumSelectField[] locationCostAccountingStatusField;

        private SearchColumnDoubleField[] locationDefaultReturnCostField;

        private SearchColumnEnumSelectField[] locationDemandSourceField;

        private SearchColumnLongField[] locationDemandTimeFenceField;

        private SearchColumnDoubleField[] locationFixedLotSizeField;

        private SearchColumnStringField[] locationInventoryCostTemplateField;

        private SearchColumnEnumSelectField[] locationInvtClassificationField;

        private SearchColumnLongField[] locationInvtCountIntervalField;

        private SearchColumnDateField[] locationLastInvtCountDateField;

        private SearchColumnLongField[] locationLeadTimeField;

        private SearchColumnDateField[] locationNextInvtCountDateField;

        private SearchColumnLongField[] locationPeriodicLotSizeDaysField;

        private SearchColumnEnumSelectField[] locationPeriodicLotSizeTypeField;

        private SearchColumnDoubleField[] locationPreferredStockLevelField;

        private SearchColumnDoubleField[] locationQtyAvailForStorePickupField;

        private SearchColumnDoubleField[] locationQuantityAvailableField;

        private SearchColumnDoubleField[] locationQuantityBackOrderedField;

        private SearchColumnDoubleField[] locationQuantityCommittedField;

        private SearchColumnDoubleField[] locationQuantityInTransitField;

        private SearchColumnDoubleField[] locationQuantityOnHandField;

        private SearchColumnDoubleField[] locationQuantityOnOrderField;

        private SearchColumnDoubleField[] locationReOrderPointField;

        private SearchColumnLongField[] locationRescheduleInDaysField;

        private SearchColumnLongField[] locationRescheduleOutDaysField;

        private SearchColumnDoubleField[] locationSafetyStockLevelField;

        private SearchColumnDoubleField[] locationStorePickupBufferStockField;

        private SearchColumnEnumSelectField[] locationSupplyLotSizingMethodField;

        private SearchColumnLongField[] locationSupplyTimeFenceField;

        private SearchColumnEnumSelectField[] locationSupplyTypeField;

        private SearchColumnDoubleField[] locationTotalValueField;

        private SearchColumnLongField[] locBackwardConsumptionDaysField;

        private SearchColumnLongField[] locForwardConsumptionDaysField;

        private SearchColumnDoubleField[] lowerWarningLimitField;

        private SearchColumnStringField[] manufacturerField;

        private SearchColumnStringField[] manufacturerAddr1Field;

        private SearchColumnStringField[] manufacturerCityField;

        private SearchColumnStringField[] manufacturerStateField;

        private SearchColumnStringField[] manufacturerTariffField;

        private SearchColumnStringField[] manufacturerTaxIdField;

        private SearchColumnStringField[] manufacturerZipField;

        private SearchColumnBooleanField[] manufacturingChargeItemField;

        private SearchColumnBooleanField[] matchBillToReceiptField;

        private SearchColumnStringField[] maximumQuantityField;

        private SearchColumnSelectField[] memberItemField;

        private SearchColumnDoubleField[] memberQuantityField;

        private SearchColumnStringField[] metaTagHtmlField;

        private SearchColumnStringField[] minimumQuantityField;

        private SearchColumnDateField[] modifiedField;

        private SearchColumnBooleanField[] mossAppliesField;

        private SearchColumnStringField[] mpnField;

        private SearchColumnBooleanField[] multManufactureAddrField;

        private SearchColumnStringField[] nextagCategoryField;

        private SearchColumnBooleanField[] nextagProductFeedField;

        private SearchColumnDateField[] nextInvtCountDateField;

        private SearchColumnStringField[] noPriceMessageField;

        private SearchColumnLongField[] numActiveListingsField;

        private SearchColumnStringField[] numberAllowedDownloadsField;

        private SearchColumnLongField[] numCurrentlyListedField;

        private SearchColumnDateField[] obsoleteDateField;

        private SearchColumnSelectField[] obsoleteRevisionField;

        private SearchColumnBooleanField[] offerSupportField;

        private SearchColumnDoubleField[] onlineCustomerPriceField;

        private SearchColumnDoubleField[] onlinePriceField;

        private SearchColumnBooleanField[] onSpecialField;

        private SearchColumnDoubleField[] otherPricesField;

        private SearchColumnSelectField[] otherVendorField;

        private SearchColumnStringField[] outOfStockBehaviorField;

        private SearchColumnStringField[] outOfStockMessageField;

        private SearchColumnEnumSelectField[] overallQuantityPricingTypeField;

        private SearchColumnEnumSelectField[] overheadTypeField;

        private SearchColumnStringField[] pageTitleField;

        private SearchColumnSelectField[] parentField;

        private SearchColumnLongField[] periodicLotSizeDaysField;

        private SearchColumnEnumSelectField[] periodicLotSizeTypeField;

        private SearchColumnSelectField[] planningItemCategoryField;

        private SearchColumnStringField[] preferenceCriterionField;

        private SearchColumnBooleanField[] preferredBinField;

        private SearchColumnSelectField[] preferredLocationField;

        private SearchColumnDoubleField[] preferredStockLevelField;

        private SearchColumnLongField[] preferredStockLevelDaysField;

        private SearchColumnBooleanField[] pricesIncludeTaxField;

        private SearchColumnSelectField[] pricingGroupField;

        private SearchColumnStringField[] primaryCategoryField;

        private SearchColumnSelectField[] prodPriceVarianceAcctField;

        private SearchColumnSelectField[] prodQtyVarianceAcctField;

        private SearchColumnStringField[] purchaseDescriptionField;

        private SearchColumnDoubleField[] purchaseOrderAmountField;

        private SearchColumnDoubleField[] purchaseOrderQuantityField;

        private SearchColumnDoubleField[] purchaseOrderQuantityDiffField;

        private SearchColumnSelectField[] purchasePriceVarianceAcctField;

        private SearchColumnSelectField[] purchaseUnitField;

        private SearchColumnDoubleField[] quantityAvailableField;

        private SearchColumnDoubleField[] quantityBackOrderedField;

        private SearchColumnDoubleField[] quantityCommittedField;

        private SearchColumnDoubleField[] quantityOnHandField;

        private SearchColumnDoubleField[] quantityOnOrderField;

        private SearchColumnSelectField[] quantityPricingScheduleField;

        private SearchColumnDoubleField[] receiptAmountField;

        private SearchColumnDoubleField[] receiptQuantityField;

        private SearchColumnDoubleField[] receiptQuantityDiffField;

        private SearchColumnLongField[] reorderMultipleField;

        private SearchColumnDoubleField[] reOrderPointField;

        private SearchColumnLongField[] rescheduleInDaysField;

        private SearchColumnLongField[] rescheduleOutDaysField;

        private SearchColumnDoubleField[] reservePriceField;

        private SearchColumnSelectField[] revenueAllocationGroupField;

        private SearchColumnSelectField[] revenueRecognitionRuleField;

        private SearchColumnSelectField[] revRecForecastRuleField;

        private SearchColumnSelectField[] revReclassFXAccountField;

        private SearchColumnSelectField[] revRecScheduleField;

        private SearchColumnBooleanField[] roundUpAsComponentField;

        private SearchColumnDoubleField[] safetyStockLevelField;

        private SearchColumnLongField[] safetyStockLevelDaysField;

        private SearchColumnStringField[] salesDescriptionField;

        private SearchColumnSelectField[] salesTaxCodeField;

        private SearchColumnSelectField[] saleUnitField;

        private SearchColumnBooleanField[] sameAsPrimaryBookAmortizationField;

        private SearchColumnBooleanField[] sameAsPrimaryBookRevRecField;

        private SearchColumnEnumSelectField[] scheduleBCodeField;

        private SearchColumnStringField[] scheduleBNumberField;

        private SearchColumnStringField[] scheduleBQuantityField;

        private SearchColumnSelectField[] scrapAcctField;

        private SearchColumnStringField[] searchKeywordsField;

        private SearchColumnBooleanField[] seasonalDemandField;

        private SearchColumnSelectField[] secondaryConsumptionUnitField;

        private SearchColumnSelectField[] secondaryPurchaseUnitField;

        private SearchColumnSelectField[] secondarySaleUnitField;

        private SearchColumnSelectField[] secondaryStockUnitField;

        private SearchColumnSelectField[] secondaryUnitsTypeField;

        private SearchColumnBooleanField[] sellOnEBayField;

        private SearchColumnStringField[] serialNumberField;

        private SearchColumnStringField[] serialNumberLocationField;

        private SearchColumnBooleanField[] shipIndividuallyField;

        private SearchColumnSelectField[] shipPackageField;

        private SearchColumnEnumSelectField[] shippingCarrierField;

        private SearchColumnDoubleField[] shippingRateField;

        private SearchColumnStringField[] shoppingDotComCategoryField;

        private SearchColumnBooleanField[] shoppingProductFeedField;

        private SearchColumnLongField[] shopzillaCategoryIdField;

        private SearchColumnBooleanField[] shopzillaProductFeedField;

        private SearchColumnEnumSelectField[] sitemapPriorityField;

        private SearchColumnSelectField[] softDescriptorField;

        private SearchColumnDoubleField[] startingPriceField;

        private SearchColumnStringField[] stockDescriptionField;

        private SearchColumnSelectField[] stockUnitField;

        private SearchColumnStringField[] storeDescriptionField;

        private SearchColumnStringField[] storeDetailedDescriptionField;

        private SearchColumnSelectField[] storeDisplayImageField;

        private SearchColumnStringField[] storeDisplayNameField;

        private SearchColumnSelectField[] storeDisplayThumbnailField;

        private SearchColumnSelectField[] subsidiaryField;

        private SearchColumnEnumSelectField[] subTypeField;

        private SearchColumnEnumSelectField[] supplyLotSizingMethodField;

        private SearchColumnEnumSelectField[] supplyReplenishmentMethodField;

        private SearchColumnLongField[] supplyTimeFenceField;

        private SearchColumnEnumSelectField[] supplyTypeField;

        private SearchColumnSelectField[] taxScheduleField;

        private SearchColumnStringField[] thumbNailUrlField;

        private SearchColumnDoubleField[] totalValueField;

        private SearchColumnBooleanField[] trackLandedCostField;

        private SearchColumnDoubleField[] transferPriceField;

        private SearchColumnEnumSelectField[] typeField;

        private SearchColumnSelectField[] unbuildVarianceAccountField;

        private SearchColumnSelectField[] unitsTypeField;

        private SearchColumnStringField[] upcCodeField;

        private SearchColumnDoubleField[] upperWarningLimitField;

        private SearchColumnStringField[] urlComponentField;

        private SearchColumnBooleanField[] useBinsField;

        private SearchColumnBooleanField[] useComponentYieldField;

        private SearchColumnBooleanField[] useMarginalRatesField;

        private SearchColumnSelectField[] vendorField;

        private SearchColumnStringField[] vendorCodeField;

        private SearchColumnDoubleField[] vendorCostField;

        private SearchColumnDoubleField[] vendorCostEnteredField;

        private SearchColumnStringField[] vendorNameField;

        private SearchColumnStringField[] vendorPriceCurrencyField;

        private SearchColumnSelectField[] vendorScheduleField;

        private SearchColumnSelectField[] vendReturnVarianceAccountField;

        private SearchColumnEnumSelectField[] vsoeDeferralField;

        private SearchColumnBooleanField[] vsoeDeliveredField;

        private SearchColumnEnumSelectField[] vsoePermitDiscountField;

        private SearchColumnDoubleField[] vsoePriceField;

        private SearchColumnEnumSelectField[] vsoeSopGroupField;

        private SearchColumnSelectField[] webSiteField;

        private SearchColumnDoubleField[] weightField;

        private SearchColumnEnumSelectField[] weightUnitField;

        private SearchColumnSelectField[] wipAcctField;

        private SearchColumnSelectField[] wipVarianceAcctField;

        private SearchColumnBooleanField[] yahooProductFeedField;

        private SearchColumnCustomField[] customFieldListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("accBookRevRecForecastRule")]
        public SearchColumnSelectField[] accBookRevRecForecastRule {
            get {
                return this.accBookRevRecForecastRuleField;
            }
            set {
                this.accBookRevRecForecastRuleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("accountingBook")]
        public SearchColumnSelectField[] accountingBook {
            get {
                return this.accountingBookField;
            }
            set {
                this.accountingBookField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("accountingBookAmortization")]
        public SearchColumnSelectField[] accountingBookAmortization {
            get {
                return this.accountingBookAmortizationField;
            }
            set {
                this.accountingBookAmortizationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("accountingBookCreatePlansOn")]
        public SearchColumnSelectField[] accountingBookCreatePlansOn {
            get {
                return this.accountingBookCreatePlansOnField;
            }
            set {
                this.accountingBookCreatePlansOnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("accountingBookRevRecRule")]
        public SearchColumnSelectField[] accountingBookRevRecRule {
            get {
                return this.accountingBookRevRecRuleField;
            }
            set {
                this.accountingBookRevRecRuleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("accountingBookRevRecSchedule")]
        public SearchColumnSelectField[] accountingBookRevRecSchedule {
            get {
                return this.accountingBookRevRecScheduleField;
            }
            set {
                this.accountingBookRevRecScheduleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("allowedShippingMethod")]
        public SearchColumnSelectField[] allowedShippingMethod {
            get {
                return this.allowedShippingMethodField;
            }
            set {
                this.allowedShippingMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("alternateDemandSourceItem")]
        public SearchColumnStringField[] alternateDemandSourceItem {
            get {
                return this.alternateDemandSourceItemField;
            }
            set {
                this.alternateDemandSourceItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("assetAccount")]
        public SearchColumnSelectField[] assetAccount {
            get {
                return this.assetAccountField;
            }
            set {
                this.assetAccountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("atpLeadTime")]
        public SearchColumnDoubleField[] atpLeadTime {
            get {
                return this.atpLeadTimeField;
            }
            set {
                this.atpLeadTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("atpMethod")]
        public SearchColumnEnumSelectField[] atpMethod {
            get {
                return this.atpMethodField;
            }
            set {
                this.atpMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("autoLeadTime")]
        public SearchColumnBooleanField[] autoLeadTime {
            get {
                return this.autoLeadTimeField;
            }
            set {
                this.autoLeadTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("autoPreferredStockLevel")]
        public SearchColumnBooleanField[] autoPreferredStockLevel {
            get {
                return this.autoPreferredStockLevelField;
            }
            set {
                this.autoPreferredStockLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("autoReorderPoint")]
        public SearchColumnBooleanField[] autoReorderPoint {
            get {
                return this.autoReorderPointField;
            }
            set {
                this.autoReorderPointField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("availableToPartners")]
        public SearchColumnBooleanField[] availableToPartners {
            get {
                return this.availableToPartnersField;
            }
            set {
                this.availableToPartnersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("averageCost")]
        public SearchColumnDoubleField[] averageCost {
            get {
                return this.averageCostField;
            }
            set {
                this.averageCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("backwardConsumptionDays")]
        public SearchColumnLongField[] backwardConsumptionDays {
            get {
                return this.backwardConsumptionDaysField;
            }
            set {
                this.backwardConsumptionDaysField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("basePrice")]
        public SearchColumnDoubleField[] basePrice {
            get {
                return this.basePriceField;
            }
            set {
                this.basePriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billExchRateVarianceAcct")]
        public SearchColumnSelectField[] billExchRateVarianceAcct {
            get {
                return this.billExchRateVarianceAcctField;
            }
            set {
                this.billExchRateVarianceAcctField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billPriceVarianceAcct")]
        public SearchColumnSelectField[] billPriceVarianceAcct {
            get {
                return this.billPriceVarianceAcctField;
            }
            set {
                this.billPriceVarianceAcctField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billQtyVarianceAcct")]
        public SearchColumnSelectField[] billQtyVarianceAcct {
            get {
                return this.billQtyVarianceAcctField;
            }
            set {
                this.billQtyVarianceAcctField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("binNumber")]
        public SearchColumnStringField[] binNumber {
            get {
                return this.binNumberField;
            }
            set {
                this.binNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("binOnHandAvail")]
        public SearchColumnDoubleField[] binOnHandAvail {
            get {
                return this.binOnHandAvailField;
            }
            set {
                this.binOnHandAvailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("binOnHandCount")]
        public SearchColumnDoubleField[] binOnHandCount {
            get {
                return this.binOnHandCountField;
            }
            set {
                this.binOnHandCountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("bomQuantity")]
        public SearchColumnDoubleField[] bomQuantity {
            get {
                return this.bomQuantityField;
            }
            set {
                this.bomQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("buildEntireAssembly")]
        public SearchColumnBooleanField[] buildEntireAssembly {
            get {
                return this.buildEntireAssemblyField;
            }
            set {
                this.buildEntireAssemblyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("buildTime")]
        public SearchColumnDoubleField[] buildTime {
            get {
                return this.buildTimeField;
            }
            set {
                this.buildTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("buildTimeLotSize")]
        public SearchColumnDoubleField[] buildTimeLotSize {
            get {
                return this.buildTimeLotSizeField;
            }
            set {
                this.buildTimeLotSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("buyItNowPrice")]
        public SearchColumnDoubleField[] buyItNowPrice {
            get {
                return this.buyItNowPriceField;
            }
            set {
                this.buyItNowPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("category")]
        public SearchColumnStringField[] category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("categoryPreferred")]
        public SearchColumnStringField[] categoryPreferred {
            get {
                return this.categoryPreferredField;
            }
            set {
                this.categoryPreferredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("class")]
        public SearchColumnSelectField[] @class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("componentYield")]
        public SearchColumnDoubleField[] componentYield {
            get {
                return this.componentYieldField;
            }
            set {
                this.componentYieldField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("consumptionUnit")]
        public SearchColumnSelectField[] consumptionUnit {
            get {
                return this.consumptionUnitField;
            }
            set {
                this.consumptionUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("contingentRevenueHandling")]
        public SearchColumnBooleanField[] contingentRevenueHandling {
            get {
                return this.contingentRevenueHandlingField;
            }
            set {
                this.contingentRevenueHandlingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("conversionRate")]
        public SearchColumnDoubleField[] conversionRate {
            get {
                return this.conversionRateField;
            }
            set {
                this.conversionRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("copyDescription")]
        public SearchColumnBooleanField[] copyDescription {
            get {
                return this.copyDescriptionField;
            }
            set {
                this.copyDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("correlatedItem")]
        public SearchColumnSelectField[] correlatedItem {
            get {
                return this.correlatedItemField;
            }
            set {
                this.correlatedItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("correlatedItemCorrelation")]
        public SearchColumnDoubleField[] correlatedItemCorrelation {
            get {
                return this.correlatedItemCorrelationField;
            }
            set {
                this.correlatedItemCorrelationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("correlatedItemCount")]
        public SearchColumnLongField[] correlatedItemCount {
            get {
                return this.correlatedItemCountField;
            }
            set {
                this.correlatedItemCountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("correlatedItemLift")]
        public SearchColumnDoubleField[] correlatedItemLift {
            get {
                return this.correlatedItemLiftField;
            }
            set {
                this.correlatedItemLiftField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("correlatedItemPurchaseRate")]
        public SearchColumnDoubleField[] correlatedItemPurchaseRate {
            get {
                return this.correlatedItemPurchaseRateField;
            }
            set {
                this.correlatedItemPurchaseRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cost")]
        public SearchColumnDoubleField[] cost {
            get {
                return this.costField;
            }
            set {
                this.costField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("costAccountingStatus")]
        public SearchColumnEnumSelectField[] costAccountingStatus {
            get {
                return this.costAccountingStatusField;
            }
            set {
                this.costAccountingStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("costCategory")]
        public SearchColumnStringField[] costCategory {
            get {
                return this.costCategoryField;
            }
            set {
                this.costCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("costEstimate")]
        public SearchColumnDoubleField[] costEstimate {
            get {
                return this.costEstimateField;
            }
            set {
                this.costEstimateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("costEstimateType")]
        public SearchColumnEnumSelectField[] costEstimateType {
            get {
                return this.costEstimateTypeField;
            }
            set {
                this.costEstimateTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("costingMethod")]
        public SearchColumnEnumSelectField[] costingMethod {
            get {
                return this.costingMethodField;
            }
            set {
                this.costingMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("countryOfManufacture")]
        public SearchColumnEnumSelectField[] countryOfManufacture {
            get {
                return this.countryOfManufactureField;
            }
            set {
                this.countryOfManufactureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("created")]
        public SearchColumnDateField[] created {
            get {
                return this.createdField;
            }
            set {
                this.createdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("createJob")]
        public SearchColumnBooleanField[] createJob {
            get {
                return this.createJobField;
            }
            set {
                this.createJobField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("createRevenuePlansOn")]
        public SearchColumnSelectField[] createRevenuePlansOn {
            get {
                return this.createRevenuePlansOnField;
            }
            set {
                this.createRevenuePlansOnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("custReturnVarianceAccount")]
        public SearchColumnSelectField[] custReturnVarianceAccount {
            get {
                return this.custReturnVarianceAccountField;
            }
            set {
                this.custReturnVarianceAccountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dateViewed")]
        public SearchColumnDateField[] dateViewed {
            get {
                return this.dateViewedField;
            }
            set {
                this.dateViewedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("daysBeforeExpiration")]
        public SearchColumnStringField[] daysBeforeExpiration {
            get {
                return this.daysBeforeExpirationField;
            }
            set {
                this.daysBeforeExpirationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("defaultReturnCost")]
        public SearchColumnDoubleField[] defaultReturnCost {
            get {
                return this.defaultReturnCostField;
            }
            set {
                this.defaultReturnCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("defaultShippingMethod")]
        public SearchColumnStringField[] defaultShippingMethod {
            get {
                return this.defaultShippingMethodField;
            }
            set {
                this.defaultShippingMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("deferredExpenseAccount")]
        public SearchColumnSelectField[] deferredExpenseAccount {
            get {
                return this.deferredExpenseAccountField;
            }
            set {
                this.deferredExpenseAccountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("deferredRevenueAccount")]
        public SearchColumnSelectField[] deferredRevenueAccount {
            get {
                return this.deferredRevenueAccountField;
            }
            set {
                this.deferredRevenueAccountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("deferRevRec")]
        public SearchColumnBooleanField[] deferRevRec {
            get {
                return this.deferRevRecField;
            }
            set {
                this.deferRevRecField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("demandModifier")]
        public SearchColumnDoubleField[] demandModifier {
            get {
                return this.demandModifierField;
            }
            set {
                this.demandModifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("demandSource")]
        public SearchColumnEnumSelectField[] demandSource {
            get {
                return this.demandSourceField;
            }
            set {
                this.demandSourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("demandTimeFence")]
        public SearchColumnLongField[] demandTimeFence {
            get {
                return this.demandTimeFenceField;
            }
            set {
                this.demandTimeFenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("department")]
        public SearchColumnSelectField[] department {
            get {
                return this.departmentField;
            }
            set {
                this.departmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("departmentnohierarchy")]
        public SearchColumnSelectField[] departmentnohierarchy {
            get {
                return this.departmentnohierarchyField;
            }
            set {
                this.departmentnohierarchyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("directRevenuePosting")]
        public SearchColumnBooleanField[] directRevenuePosting {
            get {
                return this.directRevenuePostingField;
            }
            set {
                this.directRevenuePostingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("displayIneBayStore")]
        public SearchColumnBooleanField[] displayIneBayStore {
            get {
                return this.displayIneBayStoreField;
            }
            set {
                this.displayIneBayStoreField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("displayName")]
        public SearchColumnStringField[] displayName {
            get {
                return this.displayNameField;
            }
            set {
                this.displayNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("distributionCategory")]
        public SearchColumnSelectField[] distributionCategory {
            get {
                return this.distributionCategoryField;
            }
            set {
                this.distributionCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("distributionNetwork")]
        public SearchColumnSelectField[] distributionNetwork {
            get {
                return this.distributionNetworkField;
            }
            set {
                this.distributionNetworkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dontShowPrice")]
        public SearchColumnBooleanField[] dontShowPrice {
            get {
                return this.dontShowPriceField;
            }
            set {
                this.dontShowPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("eBayItemDescription")]
        public SearchColumnStringField[] eBayItemDescription {
            get {
                return this.eBayItemDescriptionField;
            }
            set {
                this.eBayItemDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("eBayItemSubtitle")]
        public SearchColumnStringField[] eBayItemSubtitle {
            get {
                return this.eBayItemSubtitleField;
            }
            set {
                this.eBayItemSubtitleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("eBayItemTitle")]
        public SearchColumnStringField[] eBayItemTitle {
            get {
                return this.eBayItemTitleField;
            }
            set {
                this.eBayItemTitleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ebayRelistingOption")]
        public SearchColumnEnumSelectField[] ebayRelistingOption {
            get {
                return this.ebayRelistingOptionField;
            }
            set {
                this.ebayRelistingOptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("effectiveBomControl")]
        public SearchColumnEnumSelectField[] effectiveBomControl {
            get {
                return this.effectiveBomControlField;
            }
            set {
                this.effectiveBomControlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("effectiveDate")]
        public SearchColumnDateField[] effectiveDate {
            get {
                return this.effectiveDateField;
            }
            set {
                this.effectiveDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("effectiveRevision")]
        public SearchColumnSelectField[] effectiveRevision {
            get {
                return this.effectiveRevisionField;
            }
            set {
                this.effectiveRevisionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("enableCatchWeight")]
        public SearchColumnBooleanField[] enableCatchWeight {
            get {
                return this.enableCatchWeightField;
            }
            set {
                this.enableCatchWeightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("endAuctionsWhenOutOfStock")]
        public SearchColumnBooleanField[] endAuctionsWhenOutOfStock {
            get {
                return this.endAuctionsWhenOutOfStockField;
            }
            set {
                this.endAuctionsWhenOutOfStockField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("excludeFromSitemap")]
        public SearchColumnBooleanField[] excludeFromSitemap {
            get {
                return this.excludeFromSitemapField;
            }
            set {
                this.excludeFromSitemapField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("expenseAccount")]
        public SearchColumnSelectField[] expenseAccount {
            get {
                return this.expenseAccountField;
            }
            set {
                this.expenseAccountField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("featuredDescription")]
        public SearchColumnStringField[] featuredDescription {
            get {
                return this.featuredDescriptionField;
            }
            set {
                this.featuredDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("feedDescription")]
        public SearchColumnStringField[] feedDescription {
            get {
                return this.feedDescriptionField;
            }
            set {
                this.feedDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("feedName")]
        public SearchColumnStringField[] feedName {
            get {
                return this.feedNameField;
            }
            set {
                this.feedNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fixedBuildTime")]
        public SearchColumnDoubleField[] fixedBuildTime {
            get {
                return this.fixedBuildTimeField;
            }
            set {
                this.fixedBuildTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fixedLotSize")]
        public SearchColumnDoubleField[] fixedLotSize {
            get {
                return this.fixedLotSizeField;
            }
            set {
                this.fixedLotSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("forwardConsumptionDays")]
        public SearchColumnLongField[] forwardConsumptionDays {
            get {
                return this.forwardConsumptionDaysField;
            }
            set {
                this.forwardConsumptionDaysField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fraudRisk")]
        public SearchColumnEnumSelectField[] fraudRisk {
            get {
                return this.fraudRiskField;
            }
            set {
                this.fraudRiskField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("froogleProductFeed")]
        public SearchColumnBooleanField[] froogleProductFeed {
            get {
                return this.froogleProductFeedField;
            }
            set {
                this.froogleProductFeedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("futureHorizon")]
        public SearchColumnLongField[] futureHorizon {
            get {
                return this.futureHorizonField;
            }
            set {
                this.futureHorizonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fxCost")]
        public SearchColumnDoubleField[] fxCost {
            get {
                return this.fxCostField;
            }
            set {
                this.fxCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("gainLossAccount")]
        public SearchColumnSelectField[] gainLossAccount {
            get {
                return this.gainLossAccountField;
            }
            set {
                this.gainLossAccountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("generateAccruals")]
        public SearchColumnBooleanField[] generateAccruals {
            get {
                return this.generateAccrualsField;
            }
            set {
                this.generateAccrualsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("giftCertAuthCode")]
        public SearchColumnStringField[] giftCertAuthCode {
            get {
                return this.giftCertAuthCodeField;
            }
            set {
                this.giftCertAuthCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("giftCertEmail")]
        public SearchColumnStringField[] giftCertEmail {
            get {
                return this.giftCertEmailField;
            }
            set {
                this.giftCertEmailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("giftCertExpirationDate")]
        public SearchColumnStringField[] giftCertExpirationDate {
            get {
                return this.giftCertExpirationDateField;
            }
            set {
                this.giftCertExpirationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("giftCertFrom")]
        public SearchColumnStringField[] giftCertFrom {
            get {
                return this.giftCertFromField;
            }
            set {
                this.giftCertFromField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("giftCertMessage")]
        public SearchColumnStringField[] giftCertMessage {
            get {
                return this.giftCertMessageField;
            }
            set {
                this.giftCertMessageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("giftCertOriginalAmount")]
        public SearchColumnStringField[] giftCertOriginalAmount {
            get {
                return this.giftCertOriginalAmountField;
            }
            set {
                this.giftCertOriginalAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("giftCertRecipient")]
        public SearchColumnStringField[] giftCertRecipient {
            get {
                return this.giftCertRecipientField;
            }
            set {
                this.giftCertRecipientField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("hierarchyNode")]
        public SearchColumnStringField[] hierarchyNode {
            get {
                return this.hierarchyNodeField;
            }
            set {
                this.hierarchyNodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("hierarchyVersion")]
        public SearchColumnStringField[] hierarchyVersion {
            get {
                return this.hierarchyVersionField;
            }
            set {
                this.hierarchyVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("hits")]
        public SearchColumnLongField[] hits {
            get {
                return this.hitsField;
            }
            set {
                this.hitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("imageUrl")]
        public SearchColumnStringField[] imageUrl {
            get {
                return this.imageUrlField;
            }
            set {
                this.imageUrlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("includeChildren")]
        public SearchColumnBooleanField[] includeChildren {
            get {
                return this.includeChildrenField;
            }
            set {
                this.includeChildrenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("incomeAccount")]
        public SearchColumnSelectField[] incomeAccount {
            get {
                return this.incomeAccountField;
            }
            set {
                this.incomeAccountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("intercoDefRevAccount")]
        public SearchColumnSelectField[] intercoDefRevAccount {
            get {
                return this.intercoDefRevAccountField;
            }
            set {
                this.intercoDefRevAccountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("intercoExpenseAccount")]
        public SearchColumnSelectField[] intercoExpenseAccount {
            get {
                return this.intercoExpenseAccountField;
            }
            set {
                this.intercoExpenseAccountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("intercoIncomeAccount")]
        public SearchColumnSelectField[] intercoIncomeAccount {
            get {
                return this.intercoIncomeAccountField;
            }
            set {
                this.intercoIncomeAccountField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("inventoryLocation")]
        public SearchColumnSelectField[] inventoryLocation {
            get {
                return this.inventoryLocationField;
            }
            set {
                this.inventoryLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("invtClassification")]
        public SearchColumnEnumSelectField[] invtClassification {
            get {
                return this.invtClassificationField;
            }
            set {
                this.invtClassificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("invtCountInterval")]
        public SearchColumnLongField[] invtCountInterval {
            get {
                return this.invtCountIntervalField;
            }
            set {
                this.invtCountIntervalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isAvailable")]
        public SearchColumnBooleanField[] isAvailable {
            get {
                return this.isAvailableField;
            }
            set {
                this.isAvailableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isDropShipItem")]
        public SearchColumnBooleanField[] isDropShipItem {
            get {
                return this.isDropShipItemField;
            }
            set {
                this.isDropShipItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isFulfillable")]
        public SearchColumnBooleanField[] isFulfillable {
            get {
                return this.isFulfillableField;
            }
            set {
                this.isFulfillableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isGcoCompliant")]
        public SearchColumnBooleanField[] isGcoCompliant {
            get {
                return this.isGcoCompliantField;
            }
            set {
                this.isGcoCompliantField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("isLotItem")]
        public SearchColumnBooleanField[] isLotItem {
            get {
                return this.isLotItemField;
            }
            set {
                this.isLotItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isOnline")]
        public SearchColumnBooleanField[] isOnline {
            get {
                return this.isOnlineField;
            }
            set {
                this.isOnlineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isSerialItem")]
        public SearchColumnBooleanField[] isSerialItem {
            get {
                return this.isSerialItemField;
            }
            set {
                this.isSerialItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isSpecialOrderItem")]
        public SearchColumnBooleanField[] isSpecialOrderItem {
            get {
                return this.isSpecialOrderItemField;
            }
            set {
                this.isSpecialOrderItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isSpecialWorkOrderItem")]
        public SearchColumnBooleanField[] isSpecialWorkOrderItem {
            get {
                return this.isSpecialWorkOrderItemField;
            }
            set {
                this.isSpecialWorkOrderItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isStorePickupAllowed")]
        public SearchColumnBooleanField[] isStorePickupAllowed {
            get {
                return this.isStorePickupAllowedField;
            }
            set {
                this.isStorePickupAllowedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("issueProduct")]
        public SearchColumnSelectField[] issueProduct {
            get {
                return this.issueProductField;
            }
            set {
                this.issueProductField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isTaxable")]
        public SearchColumnBooleanField[] isTaxable {
            get {
                return this.isTaxableField;
            }
            set {
                this.isTaxableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isVsoeBundle")]
        public SearchColumnBooleanField[] isVsoeBundle {
            get {
                return this.isVsoeBundleField;
            }
            set {
                this.isVsoeBundleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isWip")]
        public SearchColumnBooleanField[] isWip {
            get {
                return this.isWipField;
            }
            set {
                this.isWipField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("itemId")]
        public SearchColumnStringField[] itemId {
            get {
                return this.itemIdField;
            }
            set {
                this.itemIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("itemRevenueCategory")]
        public SearchColumnSelectField[] itemRevenueCategory {
            get {
                return this.itemRevenueCategoryField;
            }
            set {
                this.itemRevenueCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("itemUrl")]
        public SearchColumnStringField[] itemUrl {
            get {
                return this.itemUrlField;
            }
            set {
                this.itemUrlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lastInvtCountDate")]
        public SearchColumnDateField[] lastInvtCountDate {
            get {
                return this.lastInvtCountDateField;
            }
            set {
                this.lastInvtCountDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lastPurchasePrice")]
        public SearchColumnDoubleField[] lastPurchasePrice {
            get {
                return this.lastPurchasePriceField;
            }
            set {
                this.lastPurchasePriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lastQuantityAvailableChange")]
        public SearchColumnDateField[] lastQuantityAvailableChange {
            get {
                return this.lastQuantityAvailableChangeField;
            }
            set {
                this.lastQuantityAvailableChangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("leadTime")]
        public SearchColumnLongField[] leadTime {
            get {
                return this.leadTimeField;
            }
            set {
                this.leadTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("liabilityAccount")]
        public SearchColumnSelectField[] liabilityAccount {
            get {
                return this.liabilityAccountField;
            }
            set {
                this.liabilityAccountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("listingDuration")]
        public SearchColumnEnumSelectField[] listingDuration {
            get {
                return this.listingDurationField;
            }
            set {
                this.listingDurationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("location")]
        public SearchColumnSelectField[] location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locationAllowStorePickup")]
        public SearchColumnBooleanField[] locationAllowStorePickup {
            get {
                return this.locationAllowStorePickupField;
            }
            set {
                this.locationAllowStorePickupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locationAtpLeadTime")]
        public SearchColumnDoubleField[] locationAtpLeadTime {
            get {
                return this.locationAtpLeadTimeField;
            }
            set {
                this.locationAtpLeadTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locationAverageCost")]
        public SearchColumnDoubleField[] locationAverageCost {
            get {
                return this.locationAverageCostField;
            }
            set {
                this.locationAverageCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locationBinQuantityAvailable")]
        public SearchColumnStringField[] locationBinQuantityAvailable {
            get {
                return this.locationBinQuantityAvailableField;
            }
            set {
                this.locationBinQuantityAvailableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locationBuildTime")]
        public SearchColumnDoubleField[] locationBuildTime {
            get {
                return this.locationBuildTimeField;
            }
            set {
                this.locationBuildTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locationCost")]
        public SearchColumnDoubleField[] locationCost {
            get {
                return this.locationCostField;
            }
            set {
                this.locationCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locationCostAccountingStatus")]
        public SearchColumnEnumSelectField[] locationCostAccountingStatus {
            get {
                return this.locationCostAccountingStatusField;
            }
            set {
                this.locationCostAccountingStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locationDefaultReturnCost")]
        public SearchColumnDoubleField[] locationDefaultReturnCost {
            get {
                return this.locationDefaultReturnCostField;
            }
            set {
                this.locationDefaultReturnCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locationDemandSource")]
        public SearchColumnEnumSelectField[] locationDemandSource {
            get {
                return this.locationDemandSourceField;
            }
            set {
                this.locationDemandSourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locationDemandTimeFence")]
        public SearchColumnLongField[] locationDemandTimeFence {
            get {
                return this.locationDemandTimeFenceField;
            }
            set {
                this.locationDemandTimeFenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locationFixedLotSize")]
        public SearchColumnDoubleField[] locationFixedLotSize {
            get {
                return this.locationFixedLotSizeField;
            }
            set {
                this.locationFixedLotSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locationInventoryCostTemplate")]
        public SearchColumnStringField[] locationInventoryCostTemplate {
            get {
                return this.locationInventoryCostTemplateField;
            }
            set {
                this.locationInventoryCostTemplateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locationInvtClassification")]
        public SearchColumnEnumSelectField[] locationInvtClassification {
            get {
                return this.locationInvtClassificationField;
            }
            set {
                this.locationInvtClassificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locationInvtCountInterval")]
        public SearchColumnLongField[] locationInvtCountInterval {
            get {
                return this.locationInvtCountIntervalField;
            }
            set {
                this.locationInvtCountIntervalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locationLastInvtCountDate")]
        public SearchColumnDateField[] locationLastInvtCountDate {
            get {
                return this.locationLastInvtCountDateField;
            }
            set {
                this.locationLastInvtCountDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locationLeadTime")]
        public SearchColumnLongField[] locationLeadTime {
            get {
                return this.locationLeadTimeField;
            }
            set {
                this.locationLeadTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locationNextInvtCountDate")]
        public SearchColumnDateField[] locationNextInvtCountDate {
            get {
                return this.locationNextInvtCountDateField;
            }
            set {
                this.locationNextInvtCountDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locationPeriodicLotSizeDays")]
        public SearchColumnLongField[] locationPeriodicLotSizeDays {
            get {
                return this.locationPeriodicLotSizeDaysField;
            }
            set {
                this.locationPeriodicLotSizeDaysField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locationPeriodicLotSizeType")]
        public SearchColumnEnumSelectField[] locationPeriodicLotSizeType {
            get {
                return this.locationPeriodicLotSizeTypeField;
            }
            set {
                this.locationPeriodicLotSizeTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locationPreferredStockLevel")]
        public SearchColumnDoubleField[] locationPreferredStockLevel {
            get {
                return this.locationPreferredStockLevelField;
            }
            set {
                this.locationPreferredStockLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locationQtyAvailForStorePickup")]
        public SearchColumnDoubleField[] locationQtyAvailForStorePickup {
            get {
                return this.locationQtyAvailForStorePickupField;
            }
            set {
                this.locationQtyAvailForStorePickupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locationQuantityAvailable")]
        public SearchColumnDoubleField[] locationQuantityAvailable {
            get {
                return this.locationQuantityAvailableField;
            }
            set {
                this.locationQuantityAvailableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locationQuantityBackOrdered")]
        public SearchColumnDoubleField[] locationQuantityBackOrdered {
            get {
                return this.locationQuantityBackOrderedField;
            }
            set {
                this.locationQuantityBackOrderedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locationQuantityCommitted")]
        public SearchColumnDoubleField[] locationQuantityCommitted {
            get {
                return this.locationQuantityCommittedField;
            }
            set {
                this.locationQuantityCommittedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locationQuantityInTransit")]
        public SearchColumnDoubleField[] locationQuantityInTransit {
            get {
                return this.locationQuantityInTransitField;
            }
            set {
                this.locationQuantityInTransitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locationQuantityOnHand")]
        public SearchColumnDoubleField[] locationQuantityOnHand {
            get {
                return this.locationQuantityOnHandField;
            }
            set {
                this.locationQuantityOnHandField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locationQuantityOnOrder")]
        public SearchColumnDoubleField[] locationQuantityOnOrder {
            get {
                return this.locationQuantityOnOrderField;
            }
            set {
                this.locationQuantityOnOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locationReOrderPoint")]
        public SearchColumnDoubleField[] locationReOrderPoint {
            get {
                return this.locationReOrderPointField;
            }
            set {
                this.locationReOrderPointField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locationRescheduleInDays")]
        public SearchColumnLongField[] locationRescheduleInDays {
            get {
                return this.locationRescheduleInDaysField;
            }
            set {
                this.locationRescheduleInDaysField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locationRescheduleOutDays")]
        public SearchColumnLongField[] locationRescheduleOutDays {
            get {
                return this.locationRescheduleOutDaysField;
            }
            set {
                this.locationRescheduleOutDaysField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locationSafetyStockLevel")]
        public SearchColumnDoubleField[] locationSafetyStockLevel {
            get {
                return this.locationSafetyStockLevelField;
            }
            set {
                this.locationSafetyStockLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locationStorePickupBufferStock")]
        public SearchColumnDoubleField[] locationStorePickupBufferStock {
            get {
                return this.locationStorePickupBufferStockField;
            }
            set {
                this.locationStorePickupBufferStockField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locationSupplyLotSizingMethod")]
        public SearchColumnEnumSelectField[] locationSupplyLotSizingMethod {
            get {
                return this.locationSupplyLotSizingMethodField;
            }
            set {
                this.locationSupplyLotSizingMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locationSupplyTimeFence")]
        public SearchColumnLongField[] locationSupplyTimeFence {
            get {
                return this.locationSupplyTimeFenceField;
            }
            set {
                this.locationSupplyTimeFenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locationSupplyType")]
        public SearchColumnEnumSelectField[] locationSupplyType {
            get {
                return this.locationSupplyTypeField;
            }
            set {
                this.locationSupplyTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locationTotalValue")]
        public SearchColumnDoubleField[] locationTotalValue {
            get {
                return this.locationTotalValueField;
            }
            set {
                this.locationTotalValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locBackwardConsumptionDays")]
        public SearchColumnLongField[] locBackwardConsumptionDays {
            get {
                return this.locBackwardConsumptionDaysField;
            }
            set {
                this.locBackwardConsumptionDaysField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locForwardConsumptionDays")]
        public SearchColumnLongField[] locForwardConsumptionDays {
            get {
                return this.locForwardConsumptionDaysField;
            }
            set {
                this.locForwardConsumptionDaysField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lowerWarningLimit")]
        public SearchColumnDoubleField[] lowerWarningLimit {
            get {
                return this.lowerWarningLimitField;
            }
            set {
                this.lowerWarningLimitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("manufacturer")]
        public SearchColumnStringField[] manufacturer {
            get {
                return this.manufacturerField;
            }
            set {
                this.manufacturerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("manufacturerAddr1")]
        public SearchColumnStringField[] manufacturerAddr1 {
            get {
                return this.manufacturerAddr1Field;
            }
            set {
                this.manufacturerAddr1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("manufacturerCity")]
        public SearchColumnStringField[] manufacturerCity {
            get {
                return this.manufacturerCityField;
            }
            set {
                this.manufacturerCityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("manufacturerState")]
        public SearchColumnStringField[] manufacturerState {
            get {
                return this.manufacturerStateField;
            }
            set {
                this.manufacturerStateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("manufacturerTariff")]
        public SearchColumnStringField[] manufacturerTariff {
            get {
                return this.manufacturerTariffField;
            }
            set {
                this.manufacturerTariffField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("manufacturerTaxId")]
        public SearchColumnStringField[] manufacturerTaxId {
            get {
                return this.manufacturerTaxIdField;
            }
            set {
                this.manufacturerTaxIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("manufacturerZip")]
        public SearchColumnStringField[] manufacturerZip {
            get {
                return this.manufacturerZipField;
            }
            set {
                this.manufacturerZipField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("manufacturingChargeItem")]
        public SearchColumnBooleanField[] manufacturingChargeItem {
            get {
                return this.manufacturingChargeItemField;
            }
            set {
                this.manufacturingChargeItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("matchBillToReceipt")]
        public SearchColumnBooleanField[] matchBillToReceipt {
            get {
                return this.matchBillToReceiptField;
            }
            set {
                this.matchBillToReceiptField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("maximumQuantity")]
        public SearchColumnStringField[] maximumQuantity {
            get {
                return this.maximumQuantityField;
            }
            set {
                this.maximumQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("memberItem")]
        public SearchColumnSelectField[] memberItem {
            get {
                return this.memberItemField;
            }
            set {
                this.memberItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("memberQuantity")]
        public SearchColumnDoubleField[] memberQuantity {
            get {
                return this.memberQuantityField;
            }
            set {
                this.memberQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("metaTagHtml")]
        public SearchColumnStringField[] metaTagHtml {
            get {
                return this.metaTagHtmlField;
            }
            set {
                this.metaTagHtmlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("minimumQuantity")]
        public SearchColumnStringField[] minimumQuantity {
            get {
                return this.minimumQuantityField;
            }
            set {
                this.minimumQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("modified")]
        public SearchColumnDateField[] modified {
            get {
                return this.modifiedField;
            }
            set {
                this.modifiedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mossApplies")]
        public SearchColumnBooleanField[] mossApplies {
            get {
                return this.mossAppliesField;
            }
            set {
                this.mossAppliesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mpn")]
        public SearchColumnStringField[] mpn {
            get {
                return this.mpnField;
            }
            set {
                this.mpnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("multManufactureAddr")]
        public SearchColumnBooleanField[] multManufactureAddr {
            get {
                return this.multManufactureAddrField;
            }
            set {
                this.multManufactureAddrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("nextagCategory")]
        public SearchColumnStringField[] nextagCategory {
            get {
                return this.nextagCategoryField;
            }
            set {
                this.nextagCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("nextagProductFeed")]
        public SearchColumnBooleanField[] nextagProductFeed {
            get {
                return this.nextagProductFeedField;
            }
            set {
                this.nextagProductFeedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("nextInvtCountDate")]
        public SearchColumnDateField[] nextInvtCountDate {
            get {
                return this.nextInvtCountDateField;
            }
            set {
                this.nextInvtCountDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("noPriceMessage")]
        public SearchColumnStringField[] noPriceMessage {
            get {
                return this.noPriceMessageField;
            }
            set {
                this.noPriceMessageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("numActiveListings")]
        public SearchColumnLongField[] numActiveListings {
            get {
                return this.numActiveListingsField;
            }
            set {
                this.numActiveListingsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("numberAllowedDownloads")]
        public SearchColumnStringField[] numberAllowedDownloads {
            get {
                return this.numberAllowedDownloadsField;
            }
            set {
                this.numberAllowedDownloadsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("numCurrentlyListed")]
        public SearchColumnLongField[] numCurrentlyListed {
            get {
                return this.numCurrentlyListedField;
            }
            set {
                this.numCurrentlyListedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("obsoleteDate")]
        public SearchColumnDateField[] obsoleteDate {
            get {
                return this.obsoleteDateField;
            }
            set {
                this.obsoleteDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("obsoleteRevision")]
        public SearchColumnSelectField[] obsoleteRevision {
            get {
                return this.obsoleteRevisionField;
            }
            set {
                this.obsoleteRevisionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("offerSupport")]
        public SearchColumnBooleanField[] offerSupport {
            get {
                return this.offerSupportField;
            }
            set {
                this.offerSupportField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("onlineCustomerPrice")]
        public SearchColumnDoubleField[] onlineCustomerPrice {
            get {
                return this.onlineCustomerPriceField;
            }
            set {
                this.onlineCustomerPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("onlinePrice")]
        public SearchColumnDoubleField[] onlinePrice {
            get {
                return this.onlinePriceField;
            }
            set {
                this.onlinePriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("onSpecial")]
        public SearchColumnBooleanField[] onSpecial {
            get {
                return this.onSpecialField;
            }
            set {
                this.onSpecialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("otherPrices")]
        public SearchColumnDoubleField[] otherPrices {
            get {
                return this.otherPricesField;
            }
            set {
                this.otherPricesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("otherVendor")]
        public SearchColumnSelectField[] otherVendor {
            get {
                return this.otherVendorField;
            }
            set {
                this.otherVendorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("outOfStockBehavior")]
        public SearchColumnStringField[] outOfStockBehavior {
            get {
                return this.outOfStockBehaviorField;
            }
            set {
                this.outOfStockBehaviorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("outOfStockMessage")]
        public SearchColumnStringField[] outOfStockMessage {
            get {
                return this.outOfStockMessageField;
            }
            set {
                this.outOfStockMessageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("overallQuantityPricingType")]
        public SearchColumnEnumSelectField[] overallQuantityPricingType {
            get {
                return this.overallQuantityPricingTypeField;
            }
            set {
                this.overallQuantityPricingTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("overheadType")]
        public SearchColumnEnumSelectField[] overheadType {
            get {
                return this.overheadTypeField;
            }
            set {
                this.overheadTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pageTitle")]
        public SearchColumnStringField[] pageTitle {
            get {
                return this.pageTitleField;
            }
            set {
                this.pageTitleField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("periodicLotSizeDays")]
        public SearchColumnLongField[] periodicLotSizeDays {
            get {
                return this.periodicLotSizeDaysField;
            }
            set {
                this.periodicLotSizeDaysField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("periodicLotSizeType")]
        public SearchColumnEnumSelectField[] periodicLotSizeType {
            get {
                return this.periodicLotSizeTypeField;
            }
            set {
                this.periodicLotSizeTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("planningItemCategory")]
        public SearchColumnSelectField[] planningItemCategory {
            get {
                return this.planningItemCategoryField;
            }
            set {
                this.planningItemCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("preferenceCriterion")]
        public SearchColumnStringField[] preferenceCriterion {
            get {
                return this.preferenceCriterionField;
            }
            set {
                this.preferenceCriterionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("preferredBin")]
        public SearchColumnBooleanField[] preferredBin {
            get {
                return this.preferredBinField;
            }
            set {
                this.preferredBinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("preferredLocation")]
        public SearchColumnSelectField[] preferredLocation {
            get {
                return this.preferredLocationField;
            }
            set {
                this.preferredLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("preferredStockLevel")]
        public SearchColumnDoubleField[] preferredStockLevel {
            get {
                return this.preferredStockLevelField;
            }
            set {
                this.preferredStockLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("preferredStockLevelDays")]
        public SearchColumnLongField[] preferredStockLevelDays {
            get {
                return this.preferredStockLevelDaysField;
            }
            set {
                this.preferredStockLevelDaysField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pricesIncludeTax")]
        public SearchColumnBooleanField[] pricesIncludeTax {
            get {
                return this.pricesIncludeTaxField;
            }
            set {
                this.pricesIncludeTaxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pricingGroup")]
        public SearchColumnSelectField[] pricingGroup {
            get {
                return this.pricingGroupField;
            }
            set {
                this.pricingGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("primaryCategory")]
        public SearchColumnStringField[] primaryCategory {
            get {
                return this.primaryCategoryField;
            }
            set {
                this.primaryCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("prodPriceVarianceAcct")]
        public SearchColumnSelectField[] prodPriceVarianceAcct {
            get {
                return this.prodPriceVarianceAcctField;
            }
            set {
                this.prodPriceVarianceAcctField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("prodQtyVarianceAcct")]
        public SearchColumnSelectField[] prodQtyVarianceAcct {
            get {
                return this.prodQtyVarianceAcctField;
            }
            set {
                this.prodQtyVarianceAcctField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("purchaseDescription")]
        public SearchColumnStringField[] purchaseDescription {
            get {
                return this.purchaseDescriptionField;
            }
            set {
                this.purchaseDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("purchaseOrderAmount")]
        public SearchColumnDoubleField[] purchaseOrderAmount {
            get {
                return this.purchaseOrderAmountField;
            }
            set {
                this.purchaseOrderAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("purchaseOrderQuantity")]
        public SearchColumnDoubleField[] purchaseOrderQuantity {
            get {
                return this.purchaseOrderQuantityField;
            }
            set {
                this.purchaseOrderQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("purchaseOrderQuantityDiff")]
        public SearchColumnDoubleField[] purchaseOrderQuantityDiff {
            get {
                return this.purchaseOrderQuantityDiffField;
            }
            set {
                this.purchaseOrderQuantityDiffField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("purchasePriceVarianceAcct")]
        public SearchColumnSelectField[] purchasePriceVarianceAcct {
            get {
                return this.purchasePriceVarianceAcctField;
            }
            set {
                this.purchasePriceVarianceAcctField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("purchaseUnit")]
        public SearchColumnSelectField[] purchaseUnit {
            get {
                return this.purchaseUnitField;
            }
            set {
                this.purchaseUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("quantityAvailable")]
        public SearchColumnDoubleField[] quantityAvailable {
            get {
                return this.quantityAvailableField;
            }
            set {
                this.quantityAvailableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("quantityBackOrdered")]
        public SearchColumnDoubleField[] quantityBackOrdered {
            get {
                return this.quantityBackOrderedField;
            }
            set {
                this.quantityBackOrderedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("quantityCommitted")]
        public SearchColumnDoubleField[] quantityCommitted {
            get {
                return this.quantityCommittedField;
            }
            set {
                this.quantityCommittedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("quantityOnHand")]
        public SearchColumnDoubleField[] quantityOnHand {
            get {
                return this.quantityOnHandField;
            }
            set {
                this.quantityOnHandField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("quantityOnOrder")]
        public SearchColumnDoubleField[] quantityOnOrder {
            get {
                return this.quantityOnOrderField;
            }
            set {
                this.quantityOnOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("quantityPricingSchedule")]
        public SearchColumnSelectField[] quantityPricingSchedule {
            get {
                return this.quantityPricingScheduleField;
            }
            set {
                this.quantityPricingScheduleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("receiptAmount")]
        public SearchColumnDoubleField[] receiptAmount {
            get {
                return this.receiptAmountField;
            }
            set {
                this.receiptAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("receiptQuantity")]
        public SearchColumnDoubleField[] receiptQuantity {
            get {
                return this.receiptQuantityField;
            }
            set {
                this.receiptQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("receiptQuantityDiff")]
        public SearchColumnDoubleField[] receiptQuantityDiff {
            get {
                return this.receiptQuantityDiffField;
            }
            set {
                this.receiptQuantityDiffField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("reorderMultiple")]
        public SearchColumnLongField[] reorderMultiple {
            get {
                return this.reorderMultipleField;
            }
            set {
                this.reorderMultipleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("reOrderPoint")]
        public SearchColumnDoubleField[] reOrderPoint {
            get {
                return this.reOrderPointField;
            }
            set {
                this.reOrderPointField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("rescheduleInDays")]
        public SearchColumnLongField[] rescheduleInDays {
            get {
                return this.rescheduleInDaysField;
            }
            set {
                this.rescheduleInDaysField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("rescheduleOutDays")]
        public SearchColumnLongField[] rescheduleOutDays {
            get {
                return this.rescheduleOutDaysField;
            }
            set {
                this.rescheduleOutDaysField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("reservePrice")]
        public SearchColumnDoubleField[] reservePrice {
            get {
                return this.reservePriceField;
            }
            set {
                this.reservePriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("revenueAllocationGroup")]
        public SearchColumnSelectField[] revenueAllocationGroup {
            get {
                return this.revenueAllocationGroupField;
            }
            set {
                this.revenueAllocationGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("revenueRecognitionRule")]
        public SearchColumnSelectField[] revenueRecognitionRule {
            get {
                return this.revenueRecognitionRuleField;
            }
            set {
                this.revenueRecognitionRuleField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("revReclassFXAccount")]
        public SearchColumnSelectField[] revReclassFXAccount {
            get {
                return this.revReclassFXAccountField;
            }
            set {
                this.revReclassFXAccountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("revRecSchedule")]
        public SearchColumnSelectField[] revRecSchedule {
            get {
                return this.revRecScheduleField;
            }
            set {
                this.revRecScheduleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("roundUpAsComponent")]
        public SearchColumnBooleanField[] roundUpAsComponent {
            get {
                return this.roundUpAsComponentField;
            }
            set {
                this.roundUpAsComponentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("safetyStockLevel")]
        public SearchColumnDoubleField[] safetyStockLevel {
            get {
                return this.safetyStockLevelField;
            }
            set {
                this.safetyStockLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("safetyStockLevelDays")]
        public SearchColumnLongField[] safetyStockLevelDays {
            get {
                return this.safetyStockLevelDaysField;
            }
            set {
                this.safetyStockLevelDaysField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("salesDescription")]
        public SearchColumnStringField[] salesDescription {
            get {
                return this.salesDescriptionField;
            }
            set {
                this.salesDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("salesTaxCode")]
        public SearchColumnSelectField[] salesTaxCode {
            get {
                return this.salesTaxCodeField;
            }
            set {
                this.salesTaxCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("saleUnit")]
        public SearchColumnSelectField[] saleUnit {
            get {
                return this.saleUnitField;
            }
            set {
                this.saleUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("sameAsPrimaryBookAmortization")]
        public SearchColumnBooleanField[] sameAsPrimaryBookAmortization {
            get {
                return this.sameAsPrimaryBookAmortizationField;
            }
            set {
                this.sameAsPrimaryBookAmortizationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("sameAsPrimaryBookRevRec")]
        public SearchColumnBooleanField[] sameAsPrimaryBookRevRec {
            get {
                return this.sameAsPrimaryBookRevRecField;
            }
            set {
                this.sameAsPrimaryBookRevRecField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("scheduleBCode")]
        public SearchColumnEnumSelectField[] scheduleBCode {
            get {
                return this.scheduleBCodeField;
            }
            set {
                this.scheduleBCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("scheduleBNumber")]
        public SearchColumnStringField[] scheduleBNumber {
            get {
                return this.scheduleBNumberField;
            }
            set {
                this.scheduleBNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("scheduleBQuantity")]
        public SearchColumnStringField[] scheduleBQuantity {
            get {
                return this.scheduleBQuantityField;
            }
            set {
                this.scheduleBQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("scrapAcct")]
        public SearchColumnSelectField[] scrapAcct {
            get {
                return this.scrapAcctField;
            }
            set {
                this.scrapAcctField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("searchKeywords")]
        public SearchColumnStringField[] searchKeywords {
            get {
                return this.searchKeywordsField;
            }
            set {
                this.searchKeywordsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("seasonalDemand")]
        public SearchColumnBooleanField[] seasonalDemand {
            get {
                return this.seasonalDemandField;
            }
            set {
                this.seasonalDemandField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("secondaryConsumptionUnit")]
        public SearchColumnSelectField[] secondaryConsumptionUnit {
            get {
                return this.secondaryConsumptionUnitField;
            }
            set {
                this.secondaryConsumptionUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("secondaryPurchaseUnit")]
        public SearchColumnSelectField[] secondaryPurchaseUnit {
            get {
                return this.secondaryPurchaseUnitField;
            }
            set {
                this.secondaryPurchaseUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("secondarySaleUnit")]
        public SearchColumnSelectField[] secondarySaleUnit {
            get {
                return this.secondarySaleUnitField;
            }
            set {
                this.secondarySaleUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("secondaryStockUnit")]
        public SearchColumnSelectField[] secondaryStockUnit {
            get {
                return this.secondaryStockUnitField;
            }
            set {
                this.secondaryStockUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("secondaryUnitsType")]
        public SearchColumnSelectField[] secondaryUnitsType {
            get {
                return this.secondaryUnitsTypeField;
            }
            set {
                this.secondaryUnitsTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("sellOnEBay")]
        public SearchColumnBooleanField[] sellOnEBay {
            get {
                return this.sellOnEBayField;
            }
            set {
                this.sellOnEBayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("serialNumber")]
        public SearchColumnStringField[] serialNumber {
            get {
                return this.serialNumberField;
            }
            set {
                this.serialNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("serialNumberLocation")]
        public SearchColumnStringField[] serialNumberLocation {
            get {
                return this.serialNumberLocationField;
            }
            set {
                this.serialNumberLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("shipIndividually")]
        public SearchColumnBooleanField[] shipIndividually {
            get {
                return this.shipIndividuallyField;
            }
            set {
                this.shipIndividuallyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("shipPackage")]
        public SearchColumnSelectField[] shipPackage {
            get {
                return this.shipPackageField;
            }
            set {
                this.shipPackageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("shippingCarrier")]
        public SearchColumnEnumSelectField[] shippingCarrier {
            get {
                return this.shippingCarrierField;
            }
            set {
                this.shippingCarrierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("shippingRate")]
        public SearchColumnDoubleField[] shippingRate {
            get {
                return this.shippingRateField;
            }
            set {
                this.shippingRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("shoppingDotComCategory")]
        public SearchColumnStringField[] shoppingDotComCategory {
            get {
                return this.shoppingDotComCategoryField;
            }
            set {
                this.shoppingDotComCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("shoppingProductFeed")]
        public SearchColumnBooleanField[] shoppingProductFeed {
            get {
                return this.shoppingProductFeedField;
            }
            set {
                this.shoppingProductFeedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("shopzillaCategoryId")]
        public SearchColumnLongField[] shopzillaCategoryId {
            get {
                return this.shopzillaCategoryIdField;
            }
            set {
                this.shopzillaCategoryIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("shopzillaProductFeed")]
        public SearchColumnBooleanField[] shopzillaProductFeed {
            get {
                return this.shopzillaProductFeedField;
            }
            set {
                this.shopzillaProductFeedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("sitemapPriority")]
        public SearchColumnEnumSelectField[] sitemapPriority {
            get {
                return this.sitemapPriorityField;
            }
            set {
                this.sitemapPriorityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("softDescriptor")]
        public SearchColumnSelectField[] softDescriptor {
            get {
                return this.softDescriptorField;
            }
            set {
                this.softDescriptorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("startingPrice")]
        public SearchColumnDoubleField[] startingPrice {
            get {
                return this.startingPriceField;
            }
            set {
                this.startingPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("stockDescription")]
        public SearchColumnStringField[] stockDescription {
            get {
                return this.stockDescriptionField;
            }
            set {
                this.stockDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("stockUnit")]
        public SearchColumnSelectField[] stockUnit {
            get {
                return this.stockUnitField;
            }
            set {
                this.stockUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("storeDescription")]
        public SearchColumnStringField[] storeDescription {
            get {
                return this.storeDescriptionField;
            }
            set {
                this.storeDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("storeDetailedDescription")]
        public SearchColumnStringField[] storeDetailedDescription {
            get {
                return this.storeDetailedDescriptionField;
            }
            set {
                this.storeDetailedDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("storeDisplayImage")]
        public SearchColumnSelectField[] storeDisplayImage {
            get {
                return this.storeDisplayImageField;
            }
            set {
                this.storeDisplayImageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("storeDisplayName")]
        public SearchColumnStringField[] storeDisplayName {
            get {
                return this.storeDisplayNameField;
            }
            set {
                this.storeDisplayNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("storeDisplayThumbnail")]
        public SearchColumnSelectField[] storeDisplayThumbnail {
            get {
                return this.storeDisplayThumbnailField;
            }
            set {
                this.storeDisplayThumbnailField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("subType")]
        public SearchColumnEnumSelectField[] subType {
            get {
                return this.subTypeField;
            }
            set {
                this.subTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("supplyLotSizingMethod")]
        public SearchColumnEnumSelectField[] supplyLotSizingMethod {
            get {
                return this.supplyLotSizingMethodField;
            }
            set {
                this.supplyLotSizingMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("supplyReplenishmentMethod")]
        public SearchColumnEnumSelectField[] supplyReplenishmentMethod {
            get {
                return this.supplyReplenishmentMethodField;
            }
            set {
                this.supplyReplenishmentMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("supplyTimeFence")]
        public SearchColumnLongField[] supplyTimeFence {
            get {
                return this.supplyTimeFenceField;
            }
            set {
                this.supplyTimeFenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("supplyType")]
        public SearchColumnEnumSelectField[] supplyType {
            get {
                return this.supplyTypeField;
            }
            set {
                this.supplyTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("taxSchedule")]
        public SearchColumnSelectField[] taxSchedule {
            get {
                return this.taxScheduleField;
            }
            set {
                this.taxScheduleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("thumbNailUrl")]
        public SearchColumnStringField[] thumbNailUrl {
            get {
                return this.thumbNailUrlField;
            }
            set {
                this.thumbNailUrlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("totalValue")]
        public SearchColumnDoubleField[] totalValue {
            get {
                return this.totalValueField;
            }
            set {
                this.totalValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("trackLandedCost")]
        public SearchColumnBooleanField[] trackLandedCost {
            get {
                return this.trackLandedCostField;
            }
            set {
                this.trackLandedCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("transferPrice")]
        public SearchColumnDoubleField[] transferPrice {
            get {
                return this.transferPriceField;
            }
            set {
                this.transferPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("type")]
        public SearchColumnEnumSelectField[] type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("unbuildVarianceAccount")]
        public SearchColumnSelectField[] unbuildVarianceAccount {
            get {
                return this.unbuildVarianceAccountField;
            }
            set {
                this.unbuildVarianceAccountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("unitsType")]
        public SearchColumnSelectField[] unitsType {
            get {
                return this.unitsTypeField;
            }
            set {
                this.unitsTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("upcCode")]
        public SearchColumnStringField[] upcCode {
            get {
                return this.upcCodeField;
            }
            set {
                this.upcCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("upperWarningLimit")]
        public SearchColumnDoubleField[] upperWarningLimit {
            get {
                return this.upperWarningLimitField;
            }
            set {
                this.upperWarningLimitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("urlComponent")]
        public SearchColumnStringField[] urlComponent {
            get {
                return this.urlComponentField;
            }
            set {
                this.urlComponentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("useBins")]
        public SearchColumnBooleanField[] useBins {
            get {
                return this.useBinsField;
            }
            set {
                this.useBinsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("useComponentYield")]
        public SearchColumnBooleanField[] useComponentYield {
            get {
                return this.useComponentYieldField;
            }
            set {
                this.useComponentYieldField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("useMarginalRates")]
        public SearchColumnBooleanField[] useMarginalRates {
            get {
                return this.useMarginalRatesField;
            }
            set {
                this.useMarginalRatesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("vendor")]
        public SearchColumnSelectField[] vendor {
            get {
                return this.vendorField;
            }
            set {
                this.vendorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("vendorCode")]
        public SearchColumnStringField[] vendorCode {
            get {
                return this.vendorCodeField;
            }
            set {
                this.vendorCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("vendorCost")]
        public SearchColumnDoubleField[] vendorCost {
            get {
                return this.vendorCostField;
            }
            set {
                this.vendorCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("vendorCostEntered")]
        public SearchColumnDoubleField[] vendorCostEntered {
            get {
                return this.vendorCostEnteredField;
            }
            set {
                this.vendorCostEnteredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("vendorName")]
        public SearchColumnStringField[] vendorName {
            get {
                return this.vendorNameField;
            }
            set {
                this.vendorNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("vendorPriceCurrency")]
        public SearchColumnStringField[] vendorPriceCurrency {
            get {
                return this.vendorPriceCurrencyField;
            }
            set {
                this.vendorPriceCurrencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("vendorSchedule")]
        public SearchColumnSelectField[] vendorSchedule {
            get {
                return this.vendorScheduleField;
            }
            set {
                this.vendorScheduleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("vendReturnVarianceAccount")]
        public SearchColumnSelectField[] vendReturnVarianceAccount {
            get {
                return this.vendReturnVarianceAccountField;
            }
            set {
                this.vendReturnVarianceAccountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("vsoeDeferral")]
        public SearchColumnEnumSelectField[] vsoeDeferral {
            get {
                return this.vsoeDeferralField;
            }
            set {
                this.vsoeDeferralField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("vsoeDelivered")]
        public SearchColumnBooleanField[] vsoeDelivered {
            get {
                return this.vsoeDeliveredField;
            }
            set {
                this.vsoeDeliveredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("vsoePermitDiscount")]
        public SearchColumnEnumSelectField[] vsoePermitDiscount {
            get {
                return this.vsoePermitDiscountField;
            }
            set {
                this.vsoePermitDiscountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("vsoePrice")]
        public SearchColumnDoubleField[] vsoePrice {
            get {
                return this.vsoePriceField;
            }
            set {
                this.vsoePriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("vsoeSopGroup")]
        public SearchColumnEnumSelectField[] vsoeSopGroup {
            get {
                return this.vsoeSopGroupField;
            }
            set {
                this.vsoeSopGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("webSite")]
        public SearchColumnSelectField[] webSite {
            get {
                return this.webSiteField;
            }
            set {
                this.webSiteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("weight")]
        public SearchColumnDoubleField[] weight {
            get {
                return this.weightField;
            }
            set {
                this.weightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("weightUnit")]
        public SearchColumnEnumSelectField[] weightUnit {
            get {
                return this.weightUnitField;
            }
            set {
                this.weightUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("wipAcct")]
        public SearchColumnSelectField[] wipAcct {
            get {
                return this.wipAcctField;
            }
            set {
                this.wipAcctField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("wipVarianceAcct")]
        public SearchColumnSelectField[] wipVarianceAcct {
            get {
                return this.wipVarianceAcctField;
            }
            set {
                this.wipVarianceAcctField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("yahooProductFeed")]
        public SearchColumnBooleanField[] yahooProductFeed {
            get {
                return this.yahooProductFeedField;
            }
            set {
                this.yahooProductFeedField = value;
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