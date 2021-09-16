namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class ItemSearchBasic : SearchRecordBasic {

        private SearchMultiSelectField accBookRevRecForecastRuleField;

        private SearchMultiSelectField accountField;

        private SearchMultiSelectField accountingBookField;

        private SearchMultiSelectField accountingBookAmortizationField;

        private SearchMultiSelectField accountingBookCreatePlansOnField;

        private SearchMultiSelectField accountingBookRevRecRuleField;

        private SearchMultiSelectField accountingBookRevRecScheduleField;

        private SearchMultiSelectField allowedShippingMethodField;

        private SearchMultiSelectField alternateDemandSourceItemField;

        private SearchDoubleField atpLeadTimeField;

        private SearchEnumMultiSelectField atpMethodField;

        private SearchBooleanField autoLeadTimeField;

        private SearchBooleanField autoPreferredStockLevelField;

        private SearchBooleanField autoReorderPointField;

        private SearchBooleanField availableToPartnersField;

        private SearchDoubleField averageCostField;

        private SearchLongField backwardConsumptionDaysField;

        private SearchStringField binNumberField;

        private SearchDoubleField binOnHandAvailField;

        private SearchDoubleField binOnHandCountField;

        private SearchDoubleField bomQuantityField;

        private SearchBooleanField buildEntireAssemblyField;

        private SearchDoubleField buildTimeField;

        private SearchDoubleField buildTimeLotSizeField;

        private SearchDoubleField buyItNowPriceField;

        private SearchStringField captionField;

        private SearchMultiSelectField categoryField;

        private SearchMultiSelectField classField;

        private SearchMultiSelectField componentField;

        private SearchMultiSelectField componentOfField;

        private SearchDoubleField componentYieldField;

        private SearchMultiSelectField consumptionUnitField;

        private SearchBooleanField contingentRevenueHandlingField;

        private SearchDoubleField conversionRateField;

        private SearchBooleanField copyDescriptionField;

        private SearchMultiSelectField correlatedItemField;

        private SearchDoubleField correlatedItemCorrelationField;

        private SearchLongField correlatedItemCountField;

        private SearchDoubleField correlatedItemLiftField;

        private SearchDoubleField correlatedItemPurchaseRateField;

        private SearchDoubleField costField;

        private SearchEnumMultiSelectField costAccountingStatusField;

        private SearchMultiSelectField costCategoryField;

        private SearchDoubleField costEstimateField;

        private SearchEnumMultiSelectField costEstimateTypeField;

        private SearchEnumMultiSelectField costingMethodField;

        private SearchEnumMultiSelectField countryOfManufactureField;

        private SearchDateField createdField;

        private SearchBooleanField createJobField;

        private SearchMultiSelectField createRevenuePlansOnField;

        private SearchDateField dateViewedField;

        private SearchDoubleField daysBeforeExpirationField;

        private SearchDoubleField defaultReturnCostField;

        private SearchMultiSelectField defaultShippingMethodField;

        private SearchBooleanField deferRevRecField;

        private SearchDoubleField demandModifierField;

        private SearchEnumMultiSelectField demandSourceField;

        private SearchLongField demandTimeFenceField;

        private SearchMultiSelectField departmentField;

        private SearchBooleanField directRevenuePostingField;

        private SearchBooleanField displayIneBayStoreField;

        private SearchStringField displayNameField;

        private SearchMultiSelectField distributionCategoryField;

        private SearchMultiSelectField distributionNetworkField;

        private SearchBooleanField dontShowPriceField;

        private SearchStringField eBayItemDescriptionField;

        private SearchStringField eBayItemSubtitleField;

        private SearchStringField eBayItemTitleField;

        private SearchEnumMultiSelectField ebayRelistingOptionField;

        private SearchEnumMultiSelectField effectiveBomControlField;

        private SearchDateField effectiveDateField;

        private SearchMultiSelectField effectiveRevisionField;

        private SearchBooleanField enableCatchWeightField;

        private SearchBooleanField endAuctionsWhenOutOfStockField;

        private SearchBooleanField excludeFromSitemapField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchStringField featuredDescriptionField;

        private SearchStringField feedDescriptionField;

        private SearchStringField feedNameField;

        private SearchDoubleField fixedBuildTimeField;

        private SearchDoubleField fixedLotSizeField;

        private SearchLongField forwardConsumptionDaysField;

        private SearchEnumMultiSelectField fraudRiskField;

        private SearchBooleanField froogleProductFeedField;

        private SearchLongField futureHorizonField;

        private SearchDoubleField fxCostField;

        private SearchBooleanField generateAccrualsField;

        private SearchStringField giftCertAuthCodeField;

        private SearchStringField giftCertEmailField;

        private SearchDateField giftCertExpDateField;

        private SearchStringField giftCertFromField;

        private SearchStringField giftCertMsgField;

        private SearchStringField giftCertOrigAmtField;

        private SearchStringField giftCertRecipientField;

        private SearchMultiSelectField hierarchyNodeField;

        private SearchMultiSelectField hierarchyVersionField;

        private SearchStringField imageUrlField;

        private SearchBooleanField includeChildrenField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchMultiSelectField inventoryLocationField;

        private SearchEnumMultiSelectField invtClassificationField;

        private SearchLongField invtCountIntervalField;

        private SearchBooleanField isAvailableField;

        private SearchBooleanField isDropShipItemField;

        private SearchBooleanField isFulfillableField;

        private SearchBooleanField isGcoCompliantField;

        private SearchBooleanField isInactiveField;

        private SearchBooleanField isLotItemField;

        private SearchBooleanField isOnlineField;

        private SearchBooleanField isPreferredVendorField;

        private SearchBooleanField isSerialItemField;

        private SearchBooleanField isSpecialOrderItemField;

        private SearchBooleanField isSpecialWorkOrderItemField;

        private SearchBooleanField isStorePickupAllowedField;

        private SearchMultiSelectField issueProductField;

        private SearchBooleanField isTaxableField;

        private SearchBooleanField isVsoeBundleField;

        private SearchBooleanField isWipField;

        private SearchStringField itemIdField;

        private SearchMultiSelectField itemRevenueCategoryField;

        private SearchStringField itemUrlField;

        private SearchDateField lastInvtCountDateField;

        private SearchDateField lastModifiedDateField;

        private SearchDoubleField lastPurchasePriceField;

        private SearchDateField lastQuantityAvailableChangeField;

        private SearchLongField leadTimeField;

        private SearchEnumMultiSelectField listingDurationField;

        private SearchMultiSelectField locationField;

        private SearchBooleanField locationAllowStorePickupField;

        private SearchDoubleField locationAtpLeadTimeField;

        private SearchDoubleField locationAverageCostField;

        private SearchDoubleField locationBuildTimeField;

        private SearchDoubleField locationCostField;

        private SearchEnumMultiSelectField locationCostAccountingStatusField;

        private SearchDoubleField locationDefaultReturnCostField;

        private SearchEnumMultiSelectField locationDemandSourceField;

        private SearchLongField locationDemandTimeFenceField;

        private SearchDoubleField locationFixedLotSizeField;

        private SearchMultiSelectField locationInventoryCostTemplateField;

        private SearchEnumMultiSelectField locationInvtClassificationField;

        private SearchLongField locationInvtCountIntervalField;

        private SearchDateField locationLastInvtCountDateField;

        private SearchLongField locationLeadTimeField;

        private SearchDateField locationNextInvtCountDateField;

        private SearchLongField locationPeriodicLotSizeDaysField;

        private SearchEnumMultiSelectField locationPeriodicLotSizeTypeField;

        private SearchDoubleField locationPreferredStockLevelField;

        private SearchDoubleField locationQtyAvailForStorePickupField;

        private SearchDoubleField locationQuantityAvailableField;

        private SearchDoubleField locationQuantityBackOrderedField;

        private SearchDoubleField locationQuantityCommittedField;

        private SearchDoubleField locationQuantityInTransitField;

        private SearchDoubleField locationQuantityOnHandField;

        private SearchDoubleField locationQuantityOnOrderField;

        private SearchDoubleField locationReorderPointField;

        private SearchLongField locationRescheduleInDaysField;

        private SearchLongField locationRescheduleOutDaysField;

        private SearchDoubleField locationSafetyStockLevelField;

        private SearchDoubleField locationStorePickupBufferStockField;

        private SearchEnumMultiSelectField locationSupplyLotSizingMethodField;

        private SearchLongField locationSupplyTimeFenceField;

        private SearchEnumMultiSelectField locationSupplyTypeField;

        private SearchDoubleField locationTotalValueField;

        private SearchLongField locBackwardConsumptionDaysField;

        private SearchLongField locForwardConsumptionDaysField;

        private SearchDoubleField lowerWarningLimitField;

        private SearchStringField manufacturerField;

        private SearchStringField manufactureraddr1Field;

        private SearchStringField manufacturerCityField;

        private SearchStringField manufacturerStateField;

        private SearchStringField manufacturerTariffField;

        private SearchStringField manufacturerTaxIdField;

        private SearchStringField manufacturerZipField;

        private SearchBooleanField manufacturingChargeItemField;

        private SearchBooleanField matchBillToReceiptField;

        private SearchBooleanField matrixField;

        private SearchBooleanField matrixChildField;

        private SearchLongField maximumQuantityField;

        private SearchStringField metaTagHtmlField;

        private SearchLongField minimumQuantityField;

        private SearchBooleanField mossAppliesField;

        private SearchStringField mpnField;

        private SearchBooleanField multManufactureAddrField;

        private SearchStringField nexTagCategoryField;

        private SearchBooleanField nexTagProductFeedField;

        private SearchDateField nextInvtCountDateField;

        private SearchLongField numActiveListingsField;

        private SearchDoubleField numberAllowedDownloadsField;

        private SearchLongField numCurrentlyListedField;

        private SearchDateField obsoleteDateField;

        private SearchMultiSelectField obsoleteRevisionField;

        private SearchBooleanField offerSupportField;

        private SearchDoubleField onlineCustomerPriceField;

        private SearchBooleanField onSpecialField;

        private SearchMultiSelectField otherVendorField;

        private SearchMultiSelectField outOfStockBehaviorField;

        private SearchEnumMultiSelectField overallQuantityPricingTypeField;

        private SearchEnumMultiSelectField overheadTypeField;

        private SearchStringField pageTitleField;

        private SearchMultiSelectField parentField;

        private SearchLongField periodicLotSizeDaysField;

        private SearchEnumMultiSelectField periodicLotSizeTypeField;

        private SearchMultiSelectField planningItemCategoryField;

        private SearchStringField preferenceCriterionField;

        private SearchBooleanField preferredBinField;

        private SearchMultiSelectField preferredLocationField;

        private SearchDoubleField preferredStockLevelField;

        private SearchLongField preferredStockLevelDaysField;

        private SearchDoubleField priceField;

        private SearchBooleanField pricesIncludeTaxField;

        private SearchMultiSelectField pricingGroupField;

        private SearchLongField primaryCategoryField;

        private SearchDoubleField purchaseOrderAmountField;

        private SearchDoubleField purchaseOrderQuantityField;

        private SearchDoubleField purchaseOrderQuantityDiffField;

        private SearchMultiSelectField purchaseUnitField;

        private SearchDoubleField quantityAvailableField;

        private SearchDoubleField quantityBackOrderedField;

        private SearchDoubleField quantityCommittedField;

        private SearchDoubleField quantityOnHandField;

        private SearchDoubleField quantityOnOrderField;

        private SearchMultiSelectField quantityPricingScheduleField;

        private SearchDoubleField receiptAmountField;

        private SearchDoubleField receiptQuantityField;

        private SearchDoubleField receiptQuantityDiffField;

        private SearchLongField reorderMultipleField;

        private SearchDoubleField reorderPointField;

        private SearchLongField rescheduleInDaysField;

        private SearchLongField rescheduleOutDaysField;

        private SearchDoubleField reservePriceField;

        private SearchMultiSelectField revenueAllocationGroupField;

        private SearchMultiSelectField revenueRecognitionRuleField;

        private SearchMultiSelectField revRecForecastRuleField;

        private SearchMultiSelectField revRecScheduleField;

        private SearchBooleanField roundUpAsComponentField;

        private SearchDoubleField safetyStockLevelField;

        private SearchLongField safetyStockLevelDaysField;

        private SearchStringField salesDescriptionField;

        private SearchMultiSelectField saleUnitField;

        private SearchBooleanField sameAsPrimaryBookAmortizationField;

        private SearchBooleanField sameAsPrimaryBookRevRecField;

        private SearchEnumMultiSelectField scheduleBCodeField;

        private SearchStringField scheduleBNumberField;

        private SearchStringField scheduleBQuantityField;

        private SearchStringField searchKeywordsField;

        private SearchBooleanField seasonalDemandField;

        private SearchMultiSelectField secondaryConsumptionUnitField;

        private SearchMultiSelectField secondaryPurchaseUnitField;

        private SearchMultiSelectField secondarySaleUnitField;

        private SearchMultiSelectField secondaryStockUnitField;

        private SearchMultiSelectField secondaryUnitsTypeField;

        private SearchBooleanField sellOnEBayField;

        private SearchStringField serialNumberField;

        private SearchMultiSelectField serialNumberLocationField;

        private SearchBooleanField shipIndividuallyField;

        private SearchMultiSelectField shipPackageField;

        private SearchEnumMultiSelectField shippingCarrierField;

        private SearchDoubleField shippingRateField;

        private SearchStringField shoppingDotComCategoryField;

        private SearchBooleanField shoppingProductFeedField;

        private SearchLongField shopzillaCategoryIdField;

        private SearchBooleanField shopzillaProductFeedField;

        private SearchEnumMultiSelectField sitemapPriorityField;

        private SearchMultiSelectField softDescriptorField;

        private SearchDoubleField startingPriceField;

        private SearchStringField stockDescriptionField;

        private SearchMultiSelectField stockUnitField;

        private SearchStringField storeDescriptionField;

        private SearchMultiSelectField subsidiaryField;

        private SearchEnumMultiSelectField subTypeField;

        private SearchEnumMultiSelectField supplyLotSizingMethodField;

        private SearchEnumMultiSelectField supplyReplenishmentMethodField;

        private SearchLongField supplyTimeFenceField;

        private SearchEnumMultiSelectField supplyTypeField;

        private SearchMultiSelectField taxCodeField;

        private SearchMultiSelectField taxScheduleField;

        private SearchStringField thumbnailUrlField;

        private SearchDoubleField totalValueField;

        private SearchBooleanField trackLandedCostField;

        private SearchDoubleField transferPriceField;

        private SearchEnumMultiSelectField typeField;

        private SearchMultiSelectField unitsTypeField;

        private SearchStringField upcCodeField;

        private SearchDoubleField upperWarningLimitField;

        private SearchStringField urlComponentField;

        private SearchBooleanField useBinsField;

        private SearchBooleanField useComponentYieldField;

        private SearchBooleanField useMarginalRatesField;

        private SearchMultiSelectField vendorField;

        private SearchStringField vendorCodeField;

        private SearchDoubleField vendorCostField;

        private SearchDoubleField vendorCostEnteredField;

        private SearchStringField vendorNameField;

        private SearchMultiSelectField vendorPriceCurrencyField;

        private SearchEnumMultiSelectField vsoeDeferralField;

        private SearchBooleanField vsoeDeliveredField;

        private SearchEnumMultiSelectField vsoePermitDiscountField;

        private SearchDoubleField vsoePriceField;

        private SearchEnumMultiSelectField vsoeSopGroupField;

        private SearchMultiSelectField webSiteField;

        private SearchDoubleField weightField;

        private SearchBooleanField yahooProductFeedField;

        private SearchCustomField[] customFieldListField;

        /// <remarks/>
        public SearchMultiSelectField accBookRevRecForecastRule {
            get {
                return this.accBookRevRecForecastRuleField;
            }
            set {
                this.accBookRevRecForecastRuleField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField account {
            get {
                return this.accountField;
            }
            set {
                this.accountField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField accountingBook {
            get {
                return this.accountingBookField;
            }
            set {
                this.accountingBookField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField accountingBookAmortization {
            get {
                return this.accountingBookAmortizationField;
            }
            set {
                this.accountingBookAmortizationField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField accountingBookCreatePlansOn {
            get {
                return this.accountingBookCreatePlansOnField;
            }
            set {
                this.accountingBookCreatePlansOnField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField accountingBookRevRecRule {
            get {
                return this.accountingBookRevRecRuleField;
            }
            set {
                this.accountingBookRevRecRuleField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField accountingBookRevRecSchedule {
            get {
                return this.accountingBookRevRecScheduleField;
            }
            set {
                this.accountingBookRevRecScheduleField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField allowedShippingMethod {
            get {
                return this.allowedShippingMethodField;
            }
            set {
                this.allowedShippingMethodField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField alternateDemandSourceItem {
            get {
                return this.alternateDemandSourceItemField;
            }
            set {
                this.alternateDemandSourceItemField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField atpLeadTime {
            get {
                return this.atpLeadTimeField;
            }
            set {
                this.atpLeadTimeField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField atpMethod {
            get {
                return this.atpMethodField;
            }
            set {
                this.atpMethodField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField autoLeadTime {
            get {
                return this.autoLeadTimeField;
            }
            set {
                this.autoLeadTimeField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField autoPreferredStockLevel {
            get {
                return this.autoPreferredStockLevelField;
            }
            set {
                this.autoPreferredStockLevelField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField autoReorderPoint {
            get {
                return this.autoReorderPointField;
            }
            set {
                this.autoReorderPointField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField availableToPartners {
            get {
                return this.availableToPartnersField;
            }
            set {
                this.availableToPartnersField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField averageCost {
            get {
                return this.averageCostField;
            }
            set {
                this.averageCostField = value;
            }
        }

        /// <remarks/>
        public SearchLongField backwardConsumptionDays {
            get {
                return this.backwardConsumptionDaysField;
            }
            set {
                this.backwardConsumptionDaysField = value;
            }
        }

        /// <remarks/>
        public SearchStringField binNumber {
            get {
                return this.binNumberField;
            }
            set {
                this.binNumberField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField binOnHandAvail {
            get {
                return this.binOnHandAvailField;
            }
            set {
                this.binOnHandAvailField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField binOnHandCount {
            get {
                return this.binOnHandCountField;
            }
            set {
                this.binOnHandCountField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField bomQuantity {
            get {
                return this.bomQuantityField;
            }
            set {
                this.bomQuantityField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField buildEntireAssembly {
            get {
                return this.buildEntireAssemblyField;
            }
            set {
                this.buildEntireAssemblyField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField buildTime {
            get {
                return this.buildTimeField;
            }
            set {
                this.buildTimeField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField buildTimeLotSize {
            get {
                return this.buildTimeLotSizeField;
            }
            set {
                this.buildTimeLotSizeField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField buyItNowPrice {
            get {
                return this.buyItNowPriceField;
            }
            set {
                this.buyItNowPriceField = value;
            }
        }

        /// <remarks/>
        public SearchStringField caption {
            get {
                return this.captionField;
            }
            set {
                this.captionField = value;
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
        public SearchMultiSelectField @class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField component {
            get {
                return this.componentField;
            }
            set {
                this.componentField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField componentOf {
            get {
                return this.componentOfField;
            }
            set {
                this.componentOfField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField componentYield {
            get {
                return this.componentYieldField;
            }
            set {
                this.componentYieldField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField consumptionUnit {
            get {
                return this.consumptionUnitField;
            }
            set {
                this.consumptionUnitField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField contingentRevenueHandling {
            get {
                return this.contingentRevenueHandlingField;
            }
            set {
                this.contingentRevenueHandlingField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField conversionRate {
            get {
                return this.conversionRateField;
            }
            set {
                this.conversionRateField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField copyDescription {
            get {
                return this.copyDescriptionField;
            }
            set {
                this.copyDescriptionField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField correlatedItem {
            get {
                return this.correlatedItemField;
            }
            set {
                this.correlatedItemField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField correlatedItemCorrelation {
            get {
                return this.correlatedItemCorrelationField;
            }
            set {
                this.correlatedItemCorrelationField = value;
            }
        }

        /// <remarks/>
        public SearchLongField correlatedItemCount {
            get {
                return this.correlatedItemCountField;
            }
            set {
                this.correlatedItemCountField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField correlatedItemLift {
            get {
                return this.correlatedItemLiftField;
            }
            set {
                this.correlatedItemLiftField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField correlatedItemPurchaseRate {
            get {
                return this.correlatedItemPurchaseRateField;
            }
            set {
                this.correlatedItemPurchaseRateField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField cost {
            get {
                return this.costField;
            }
            set {
                this.costField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField costAccountingStatus {
            get {
                return this.costAccountingStatusField;
            }
            set {
                this.costAccountingStatusField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField costCategory {
            get {
                return this.costCategoryField;
            }
            set {
                this.costCategoryField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField costEstimate {
            get {
                return this.costEstimateField;
            }
            set {
                this.costEstimateField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField costEstimateType {
            get {
                return this.costEstimateTypeField;
            }
            set {
                this.costEstimateTypeField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField costingMethod {
            get {
                return this.costingMethodField;
            }
            set {
                this.costingMethodField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField countryOfManufacture {
            get {
                return this.countryOfManufactureField;
            }
            set {
                this.countryOfManufactureField = value;
            }
        }

        /// <remarks/>
        public SearchDateField created {
            get {
                return this.createdField;
            }
            set {
                this.createdField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField createJob {
            get {
                return this.createJobField;
            }
            set {
                this.createJobField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField createRevenuePlansOn {
            get {
                return this.createRevenuePlansOnField;
            }
            set {
                this.createRevenuePlansOnField = value;
            }
        }

        /// <remarks/>
        public SearchDateField dateViewed {
            get {
                return this.dateViewedField;
            }
            set {
                this.dateViewedField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField daysBeforeExpiration {
            get {
                return this.daysBeforeExpirationField;
            }
            set {
                this.daysBeforeExpirationField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField defaultReturnCost {
            get {
                return this.defaultReturnCostField;
            }
            set {
                this.defaultReturnCostField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField defaultShippingMethod {
            get {
                return this.defaultShippingMethodField;
            }
            set {
                this.defaultShippingMethodField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField deferRevRec {
            get {
                return this.deferRevRecField;
            }
            set {
                this.deferRevRecField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField demandModifier {
            get {
                return this.demandModifierField;
            }
            set {
                this.demandModifierField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField demandSource {
            get {
                return this.demandSourceField;
            }
            set {
                this.demandSourceField = value;
            }
        }

        /// <remarks/>
        public SearchLongField demandTimeFence {
            get {
                return this.demandTimeFenceField;
            }
            set {
                this.demandTimeFenceField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField department {
            get {
                return this.departmentField;
            }
            set {
                this.departmentField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField directRevenuePosting {
            get {
                return this.directRevenuePostingField;
            }
            set {
                this.directRevenuePostingField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField displayIneBayStore {
            get {
                return this.displayIneBayStoreField;
            }
            set {
                this.displayIneBayStoreField = value;
            }
        }

        /// <remarks/>
        public SearchStringField displayName {
            get {
                return this.displayNameField;
            }
            set {
                this.displayNameField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField distributionCategory {
            get {
                return this.distributionCategoryField;
            }
            set {
                this.distributionCategoryField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField distributionNetwork {
            get {
                return this.distributionNetworkField;
            }
            set {
                this.distributionNetworkField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField dontShowPrice {
            get {
                return this.dontShowPriceField;
            }
            set {
                this.dontShowPriceField = value;
            }
        }

        /// <remarks/>
        public SearchStringField eBayItemDescription {
            get {
                return this.eBayItemDescriptionField;
            }
            set {
                this.eBayItemDescriptionField = value;
            }
        }

        /// <remarks/>
        public SearchStringField eBayItemSubtitle {
            get {
                return this.eBayItemSubtitleField;
            }
            set {
                this.eBayItemSubtitleField = value;
            }
        }

        /// <remarks/>
        public SearchStringField eBayItemTitle {
            get {
                return this.eBayItemTitleField;
            }
            set {
                this.eBayItemTitleField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField ebayRelistingOption {
            get {
                return this.ebayRelistingOptionField;
            }
            set {
                this.ebayRelistingOptionField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField effectiveBomControl {
            get {
                return this.effectiveBomControlField;
            }
            set {
                this.effectiveBomControlField = value;
            }
        }

        /// <remarks/>
        public SearchDateField effectiveDate {
            get {
                return this.effectiveDateField;
            }
            set {
                this.effectiveDateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField effectiveRevision {
            get {
                return this.effectiveRevisionField;
            }
            set {
                this.effectiveRevisionField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField enableCatchWeight {
            get {
                return this.enableCatchWeightField;
            }
            set {
                this.enableCatchWeightField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField endAuctionsWhenOutOfStock {
            get {
                return this.endAuctionsWhenOutOfStockField;
            }
            set {
                this.endAuctionsWhenOutOfStockField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField excludeFromSitemap {
            get {
                return this.excludeFromSitemapField;
            }
            set {
                this.excludeFromSitemapField = value;
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
        public SearchStringField featuredDescription {
            get {
                return this.featuredDescriptionField;
            }
            set {
                this.featuredDescriptionField = value;
            }
        }

        /// <remarks/>
        public SearchStringField feedDescription {
            get {
                return this.feedDescriptionField;
            }
            set {
                this.feedDescriptionField = value;
            }
        }

        /// <remarks/>
        public SearchStringField feedName {
            get {
                return this.feedNameField;
            }
            set {
                this.feedNameField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField fixedBuildTime {
            get {
                return this.fixedBuildTimeField;
            }
            set {
                this.fixedBuildTimeField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField fixedLotSize {
            get {
                return this.fixedLotSizeField;
            }
            set {
                this.fixedLotSizeField = value;
            }
        }

        /// <remarks/>
        public SearchLongField forwardConsumptionDays {
            get {
                return this.forwardConsumptionDaysField;
            }
            set {
                this.forwardConsumptionDaysField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField fraudRisk {
            get {
                return this.fraudRiskField;
            }
            set {
                this.fraudRiskField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField froogleProductFeed {
            get {
                return this.froogleProductFeedField;
            }
            set {
                this.froogleProductFeedField = value;
            }
        }

        /// <remarks/>
        public SearchLongField futureHorizon {
            get {
                return this.futureHorizonField;
            }
            set {
                this.futureHorizonField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField fxCost {
            get {
                return this.fxCostField;
            }
            set {
                this.fxCostField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField generateAccruals {
            get {
                return this.generateAccrualsField;
            }
            set {
                this.generateAccrualsField = value;
            }
        }

        /// <remarks/>
        public SearchStringField giftCertAuthCode {
            get {
                return this.giftCertAuthCodeField;
            }
            set {
                this.giftCertAuthCodeField = value;
            }
        }

        /// <remarks/>
        public SearchStringField giftCertEmail {
            get {
                return this.giftCertEmailField;
            }
            set {
                this.giftCertEmailField = value;
            }
        }

        /// <remarks/>
        public SearchDateField giftCertExpDate {
            get {
                return this.giftCertExpDateField;
            }
            set {
                this.giftCertExpDateField = value;
            }
        }

        /// <remarks/>
        public SearchStringField giftCertFrom {
            get {
                return this.giftCertFromField;
            }
            set {
                this.giftCertFromField = value;
            }
        }

        /// <remarks/>
        public SearchStringField giftCertMsg {
            get {
                return this.giftCertMsgField;
            }
            set {
                this.giftCertMsgField = value;
            }
        }

        /// <remarks/>
        public SearchStringField giftCertOrigAmt {
            get {
                return this.giftCertOrigAmtField;
            }
            set {
                this.giftCertOrigAmtField = value;
            }
        }

        /// <remarks/>
        public SearchStringField giftCertRecipient {
            get {
                return this.giftCertRecipientField;
            }
            set {
                this.giftCertRecipientField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField hierarchyNode {
            get {
                return this.hierarchyNodeField;
            }
            set {
                this.hierarchyNodeField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField hierarchyVersion {
            get {
                return this.hierarchyVersionField;
            }
            set {
                this.hierarchyVersionField = value;
            }
        }

        /// <remarks/>
        public SearchStringField imageUrl {
            get {
                return this.imageUrlField;
            }
            set {
                this.imageUrlField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField includeChildren {
            get {
                return this.includeChildrenField;
            }
            set {
                this.includeChildrenField = value;
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
        public SearchMultiSelectField inventoryLocation {
            get {
                return this.inventoryLocationField;
            }
            set {
                this.inventoryLocationField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField invtClassification {
            get {
                return this.invtClassificationField;
            }
            set {
                this.invtClassificationField = value;
            }
        }

        /// <remarks/>
        public SearchLongField invtCountInterval {
            get {
                return this.invtCountIntervalField;
            }
            set {
                this.invtCountIntervalField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isAvailable {
            get {
                return this.isAvailableField;
            }
            set {
                this.isAvailableField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isDropShipItem {
            get {
                return this.isDropShipItemField;
            }
            set {
                this.isDropShipItemField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isFulfillable {
            get {
                return this.isFulfillableField;
            }
            set {
                this.isFulfillableField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isGcoCompliant {
            get {
                return this.isGcoCompliantField;
            }
            set {
                this.isGcoCompliantField = value;
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
        public SearchBooleanField isLotItem {
            get {
                return this.isLotItemField;
            }
            set {
                this.isLotItemField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isOnline {
            get {
                return this.isOnlineField;
            }
            set {
                this.isOnlineField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isPreferredVendor {
            get {
                return this.isPreferredVendorField;
            }
            set {
                this.isPreferredVendorField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isSerialItem {
            get {
                return this.isSerialItemField;
            }
            set {
                this.isSerialItemField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isSpecialOrderItem {
            get {
                return this.isSpecialOrderItemField;
            }
            set {
                this.isSpecialOrderItemField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isSpecialWorkOrderItem {
            get {
                return this.isSpecialWorkOrderItemField;
            }
            set {
                this.isSpecialWorkOrderItemField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isStorePickupAllowed {
            get {
                return this.isStorePickupAllowedField;
            }
            set {
                this.isStorePickupAllowedField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField issueProduct {
            get {
                return this.issueProductField;
            }
            set {
                this.issueProductField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isTaxable {
            get {
                return this.isTaxableField;
            }
            set {
                this.isTaxableField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isVsoeBundle {
            get {
                return this.isVsoeBundleField;
            }
            set {
                this.isVsoeBundleField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isWip {
            get {
                return this.isWipField;
            }
            set {
                this.isWipField = value;
            }
        }

        /// <remarks/>
        public SearchStringField itemId {
            get {
                return this.itemIdField;
            }
            set {
                this.itemIdField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField itemRevenueCategory {
            get {
                return this.itemRevenueCategoryField;
            }
            set {
                this.itemRevenueCategoryField = value;
            }
        }

        /// <remarks/>
        public SearchStringField itemUrl {
            get {
                return this.itemUrlField;
            }
            set {
                this.itemUrlField = value;
            }
        }

        /// <remarks/>
        public SearchDateField lastInvtCountDate {
            get {
                return this.lastInvtCountDateField;
            }
            set {
                this.lastInvtCountDateField = value;
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
        public SearchDoubleField lastPurchasePrice {
            get {
                return this.lastPurchasePriceField;
            }
            set {
                this.lastPurchasePriceField = value;
            }
        }

        /// <remarks/>
        public SearchDateField lastQuantityAvailableChange {
            get {
                return this.lastQuantityAvailableChangeField;
            }
            set {
                this.lastQuantityAvailableChangeField = value;
            }
        }

        /// <remarks/>
        public SearchLongField leadTime {
            get {
                return this.leadTimeField;
            }
            set {
                this.leadTimeField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField listingDuration {
            get {
                return this.listingDurationField;
            }
            set {
                this.listingDurationField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField locationAllowStorePickup {
            get {
                return this.locationAllowStorePickupField;
            }
            set {
                this.locationAllowStorePickupField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField locationAtpLeadTime {
            get {
                return this.locationAtpLeadTimeField;
            }
            set {
                this.locationAtpLeadTimeField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField locationAverageCost {
            get {
                return this.locationAverageCostField;
            }
            set {
                this.locationAverageCostField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField locationBuildTime {
            get {
                return this.locationBuildTimeField;
            }
            set {
                this.locationBuildTimeField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField locationCost {
            get {
                return this.locationCostField;
            }
            set {
                this.locationCostField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField locationCostAccountingStatus {
            get {
                return this.locationCostAccountingStatusField;
            }
            set {
                this.locationCostAccountingStatusField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField locationDefaultReturnCost {
            get {
                return this.locationDefaultReturnCostField;
            }
            set {
                this.locationDefaultReturnCostField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField locationDemandSource {
            get {
                return this.locationDemandSourceField;
            }
            set {
                this.locationDemandSourceField = value;
            }
        }

        /// <remarks/>
        public SearchLongField locationDemandTimeFence {
            get {
                return this.locationDemandTimeFenceField;
            }
            set {
                this.locationDemandTimeFenceField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField locationFixedLotSize {
            get {
                return this.locationFixedLotSizeField;
            }
            set {
                this.locationFixedLotSizeField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField locationInventoryCostTemplate {
            get {
                return this.locationInventoryCostTemplateField;
            }
            set {
                this.locationInventoryCostTemplateField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField locationInvtClassification {
            get {
                return this.locationInvtClassificationField;
            }
            set {
                this.locationInvtClassificationField = value;
            }
        }

        /// <remarks/>
        public SearchLongField locationInvtCountInterval {
            get {
                return this.locationInvtCountIntervalField;
            }
            set {
                this.locationInvtCountIntervalField = value;
            }
        }

        /// <remarks/>
        public SearchDateField locationLastInvtCountDate {
            get {
                return this.locationLastInvtCountDateField;
            }
            set {
                this.locationLastInvtCountDateField = value;
            }
        }

        /// <remarks/>
        public SearchLongField locationLeadTime {
            get {
                return this.locationLeadTimeField;
            }
            set {
                this.locationLeadTimeField = value;
            }
        }

        /// <remarks/>
        public SearchDateField locationNextInvtCountDate {
            get {
                return this.locationNextInvtCountDateField;
            }
            set {
                this.locationNextInvtCountDateField = value;
            }
        }

        /// <remarks/>
        public SearchLongField locationPeriodicLotSizeDays {
            get {
                return this.locationPeriodicLotSizeDaysField;
            }
            set {
                this.locationPeriodicLotSizeDaysField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField locationPeriodicLotSizeType {
            get {
                return this.locationPeriodicLotSizeTypeField;
            }
            set {
                this.locationPeriodicLotSizeTypeField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField locationPreferredStockLevel {
            get {
                return this.locationPreferredStockLevelField;
            }
            set {
                this.locationPreferredStockLevelField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField locationQtyAvailForStorePickup {
            get {
                return this.locationQtyAvailForStorePickupField;
            }
            set {
                this.locationQtyAvailForStorePickupField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField locationQuantityAvailable {
            get {
                return this.locationQuantityAvailableField;
            }
            set {
                this.locationQuantityAvailableField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField locationQuantityBackOrdered {
            get {
                return this.locationQuantityBackOrderedField;
            }
            set {
                this.locationQuantityBackOrderedField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField locationQuantityCommitted {
            get {
                return this.locationQuantityCommittedField;
            }
            set {
                this.locationQuantityCommittedField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField locationQuantityInTransit {
            get {
                return this.locationQuantityInTransitField;
            }
            set {
                this.locationQuantityInTransitField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField locationQuantityOnHand {
            get {
                return this.locationQuantityOnHandField;
            }
            set {
                this.locationQuantityOnHandField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField locationQuantityOnOrder {
            get {
                return this.locationQuantityOnOrderField;
            }
            set {
                this.locationQuantityOnOrderField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField locationReorderPoint {
            get {
                return this.locationReorderPointField;
            }
            set {
                this.locationReorderPointField = value;
            }
        }

        /// <remarks/>
        public SearchLongField locationRescheduleInDays {
            get {
                return this.locationRescheduleInDaysField;
            }
            set {
                this.locationRescheduleInDaysField = value;
            }
        }

        /// <remarks/>
        public SearchLongField locationRescheduleOutDays {
            get {
                return this.locationRescheduleOutDaysField;
            }
            set {
                this.locationRescheduleOutDaysField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField locationSafetyStockLevel {
            get {
                return this.locationSafetyStockLevelField;
            }
            set {
                this.locationSafetyStockLevelField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField locationStorePickupBufferStock {
            get {
                return this.locationStorePickupBufferStockField;
            }
            set {
                this.locationStorePickupBufferStockField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField locationSupplyLotSizingMethod {
            get {
                return this.locationSupplyLotSizingMethodField;
            }
            set {
                this.locationSupplyLotSizingMethodField = value;
            }
        }

        /// <remarks/>
        public SearchLongField locationSupplyTimeFence {
            get {
                return this.locationSupplyTimeFenceField;
            }
            set {
                this.locationSupplyTimeFenceField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField locationSupplyType {
            get {
                return this.locationSupplyTypeField;
            }
            set {
                this.locationSupplyTypeField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField locationTotalValue {
            get {
                return this.locationTotalValueField;
            }
            set {
                this.locationTotalValueField = value;
            }
        }

        /// <remarks/>
        public SearchLongField locBackwardConsumptionDays {
            get {
                return this.locBackwardConsumptionDaysField;
            }
            set {
                this.locBackwardConsumptionDaysField = value;
            }
        }

        /// <remarks/>
        public SearchLongField locForwardConsumptionDays {
            get {
                return this.locForwardConsumptionDaysField;
            }
            set {
                this.locForwardConsumptionDaysField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField lowerWarningLimit {
            get {
                return this.lowerWarningLimitField;
            }
            set {
                this.lowerWarningLimitField = value;
            }
        }

        /// <remarks/>
        public SearchStringField manufacturer {
            get {
                return this.manufacturerField;
            }
            set {
                this.manufacturerField = value;
            }
        }

        /// <remarks/>
        public SearchStringField manufactureraddr1 {
            get {
                return this.manufactureraddr1Field;
            }
            set {
                this.manufactureraddr1Field = value;
            }
        }

        /// <remarks/>
        public SearchStringField manufacturerCity {
            get {
                return this.manufacturerCityField;
            }
            set {
                this.manufacturerCityField = value;
            }
        }

        /// <remarks/>
        public SearchStringField manufacturerState {
            get {
                return this.manufacturerStateField;
            }
            set {
                this.manufacturerStateField = value;
            }
        }

        /// <remarks/>
        public SearchStringField manufacturerTariff {
            get {
                return this.manufacturerTariffField;
            }
            set {
                this.manufacturerTariffField = value;
            }
        }

        /// <remarks/>
        public SearchStringField manufacturerTaxId {
            get {
                return this.manufacturerTaxIdField;
            }
            set {
                this.manufacturerTaxIdField = value;
            }
        }

        /// <remarks/>
        public SearchStringField manufacturerZip {
            get {
                return this.manufacturerZipField;
            }
            set {
                this.manufacturerZipField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField manufacturingChargeItem {
            get {
                return this.manufacturingChargeItemField;
            }
            set {
                this.manufacturingChargeItemField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField matchBillToReceipt {
            get {
                return this.matchBillToReceiptField;
            }
            set {
                this.matchBillToReceiptField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField matrix {
            get {
                return this.matrixField;
            }
            set {
                this.matrixField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField matrixChild {
            get {
                return this.matrixChildField;
            }
            set {
                this.matrixChildField = value;
            }
        }

        /// <remarks/>
        public SearchLongField maximumQuantity {
            get {
                return this.maximumQuantityField;
            }
            set {
                this.maximumQuantityField = value;
            }
        }

        /// <remarks/>
        public SearchStringField metaTagHtml {
            get {
                return this.metaTagHtmlField;
            }
            set {
                this.metaTagHtmlField = value;
            }
        }

        /// <remarks/>
        public SearchLongField minimumQuantity {
            get {
                return this.minimumQuantityField;
            }
            set {
                this.minimumQuantityField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField mossApplies {
            get {
                return this.mossAppliesField;
            }
            set {
                this.mossAppliesField = value;
            }
        }

        /// <remarks/>
        public SearchStringField mpn {
            get {
                return this.mpnField;
            }
            set {
                this.mpnField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField multManufactureAddr {
            get {
                return this.multManufactureAddrField;
            }
            set {
                this.multManufactureAddrField = value;
            }
        }

        /// <remarks/>
        public SearchStringField nexTagCategory {
            get {
                return this.nexTagCategoryField;
            }
            set {
                this.nexTagCategoryField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField nexTagProductFeed {
            get {
                return this.nexTagProductFeedField;
            }
            set {
                this.nexTagProductFeedField = value;
            }
        }

        /// <remarks/>
        public SearchDateField nextInvtCountDate {
            get {
                return this.nextInvtCountDateField;
            }
            set {
                this.nextInvtCountDateField = value;
            }
        }

        /// <remarks/>
        public SearchLongField numActiveListings {
            get {
                return this.numActiveListingsField;
            }
            set {
                this.numActiveListingsField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField numberAllowedDownloads {
            get {
                return this.numberAllowedDownloadsField;
            }
            set {
                this.numberAllowedDownloadsField = value;
            }
        }

        /// <remarks/>
        public SearchLongField numCurrentlyListed {
            get {
                return this.numCurrentlyListedField;
            }
            set {
                this.numCurrentlyListedField = value;
            }
        }

        /// <remarks/>
        public SearchDateField obsoleteDate {
            get {
                return this.obsoleteDateField;
            }
            set {
                this.obsoleteDateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField obsoleteRevision {
            get {
                return this.obsoleteRevisionField;
            }
            set {
                this.obsoleteRevisionField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField offerSupport {
            get {
                return this.offerSupportField;
            }
            set {
                this.offerSupportField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField onlineCustomerPrice {
            get {
                return this.onlineCustomerPriceField;
            }
            set {
                this.onlineCustomerPriceField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField onSpecial {
            get {
                return this.onSpecialField;
            }
            set {
                this.onSpecialField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField otherVendor {
            get {
                return this.otherVendorField;
            }
            set {
                this.otherVendorField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField outOfStockBehavior {
            get {
                return this.outOfStockBehaviorField;
            }
            set {
                this.outOfStockBehaviorField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField overallQuantityPricingType {
            get {
                return this.overallQuantityPricingTypeField;
            }
            set {
                this.overallQuantityPricingTypeField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField overheadType {
            get {
                return this.overheadTypeField;
            }
            set {
                this.overheadTypeField = value;
            }
        }

        /// <remarks/>
        public SearchStringField pageTitle {
            get {
                return this.pageTitleField;
            }
            set {
                this.pageTitleField = value;
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
        public SearchLongField periodicLotSizeDays {
            get {
                return this.periodicLotSizeDaysField;
            }
            set {
                this.periodicLotSizeDaysField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField periodicLotSizeType {
            get {
                return this.periodicLotSizeTypeField;
            }
            set {
                this.periodicLotSizeTypeField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField planningItemCategory {
            get {
                return this.planningItemCategoryField;
            }
            set {
                this.planningItemCategoryField = value;
            }
        }

        /// <remarks/>
        public SearchStringField preferenceCriterion {
            get {
                return this.preferenceCriterionField;
            }
            set {
                this.preferenceCriterionField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField preferredBin {
            get {
                return this.preferredBinField;
            }
            set {
                this.preferredBinField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField preferredLocation {
            get {
                return this.preferredLocationField;
            }
            set {
                this.preferredLocationField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField preferredStockLevel {
            get {
                return this.preferredStockLevelField;
            }
            set {
                this.preferredStockLevelField = value;
            }
        }

        /// <remarks/>
        public SearchLongField preferredStockLevelDays {
            get {
                return this.preferredStockLevelDaysField;
            }
            set {
                this.preferredStockLevelDaysField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField price {
            get {
                return this.priceField;
            }
            set {
                this.priceField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField pricesIncludeTax {
            get {
                return this.pricesIncludeTaxField;
            }
            set {
                this.pricesIncludeTaxField = value;
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
        public SearchLongField primaryCategory {
            get {
                return this.primaryCategoryField;
            }
            set {
                this.primaryCategoryField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField purchaseOrderAmount {
            get {
                return this.purchaseOrderAmountField;
            }
            set {
                this.purchaseOrderAmountField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField purchaseOrderQuantity {
            get {
                return this.purchaseOrderQuantityField;
            }
            set {
                this.purchaseOrderQuantityField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField purchaseOrderQuantityDiff {
            get {
                return this.purchaseOrderQuantityDiffField;
            }
            set {
                this.purchaseOrderQuantityDiffField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField purchaseUnit {
            get {
                return this.purchaseUnitField;
            }
            set {
                this.purchaseUnitField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField quantityAvailable {
            get {
                return this.quantityAvailableField;
            }
            set {
                this.quantityAvailableField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField quantityBackOrdered {
            get {
                return this.quantityBackOrderedField;
            }
            set {
                this.quantityBackOrderedField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField quantityCommitted {
            get {
                return this.quantityCommittedField;
            }
            set {
                this.quantityCommittedField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField quantityOnHand {
            get {
                return this.quantityOnHandField;
            }
            set {
                this.quantityOnHandField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField quantityOnOrder {
            get {
                return this.quantityOnOrderField;
            }
            set {
                this.quantityOnOrderField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField quantityPricingSchedule {
            get {
                return this.quantityPricingScheduleField;
            }
            set {
                this.quantityPricingScheduleField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField receiptAmount {
            get {
                return this.receiptAmountField;
            }
            set {
                this.receiptAmountField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField receiptQuantity {
            get {
                return this.receiptQuantityField;
            }
            set {
                this.receiptQuantityField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField receiptQuantityDiff {
            get {
                return this.receiptQuantityDiffField;
            }
            set {
                this.receiptQuantityDiffField = value;
            }
        }

        /// <remarks/>
        public SearchLongField reorderMultiple {
            get {
                return this.reorderMultipleField;
            }
            set {
                this.reorderMultipleField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField reorderPoint {
            get {
                return this.reorderPointField;
            }
            set {
                this.reorderPointField = value;
            }
        }

        /// <remarks/>
        public SearchLongField rescheduleInDays {
            get {
                return this.rescheduleInDaysField;
            }
            set {
                this.rescheduleInDaysField = value;
            }
        }

        /// <remarks/>
        public SearchLongField rescheduleOutDays {
            get {
                return this.rescheduleOutDaysField;
            }
            set {
                this.rescheduleOutDaysField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField reservePrice {
            get {
                return this.reservePriceField;
            }
            set {
                this.reservePriceField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField revenueAllocationGroup {
            get {
                return this.revenueAllocationGroupField;
            }
            set {
                this.revenueAllocationGroupField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField revenueRecognitionRule {
            get {
                return this.revenueRecognitionRuleField;
            }
            set {
                this.revenueRecognitionRuleField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField revRecForecastRule {
            get {
                return this.revRecForecastRuleField;
            }
            set {
                this.revRecForecastRuleField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField revRecSchedule {
            get {
                return this.revRecScheduleField;
            }
            set {
                this.revRecScheduleField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField roundUpAsComponent {
            get {
                return this.roundUpAsComponentField;
            }
            set {
                this.roundUpAsComponentField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField safetyStockLevel {
            get {
                return this.safetyStockLevelField;
            }
            set {
                this.safetyStockLevelField = value;
            }
        }

        /// <remarks/>
        public SearchLongField safetyStockLevelDays {
            get {
                return this.safetyStockLevelDaysField;
            }
            set {
                this.safetyStockLevelDaysField = value;
            }
        }

        /// <remarks/>
        public SearchStringField salesDescription {
            get {
                return this.salesDescriptionField;
            }
            set {
                this.salesDescriptionField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField saleUnit {
            get {
                return this.saleUnitField;
            }
            set {
                this.saleUnitField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField sameAsPrimaryBookAmortization {
            get {
                return this.sameAsPrimaryBookAmortizationField;
            }
            set {
                this.sameAsPrimaryBookAmortizationField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField sameAsPrimaryBookRevRec {
            get {
                return this.sameAsPrimaryBookRevRecField;
            }
            set {
                this.sameAsPrimaryBookRevRecField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField scheduleBCode {
            get {
                return this.scheduleBCodeField;
            }
            set {
                this.scheduleBCodeField = value;
            }
        }

        /// <remarks/>
        public SearchStringField scheduleBNumber {
            get {
                return this.scheduleBNumberField;
            }
            set {
                this.scheduleBNumberField = value;
            }
        }

        /// <remarks/>
        public SearchStringField scheduleBQuantity {
            get {
                return this.scheduleBQuantityField;
            }
            set {
                this.scheduleBQuantityField = value;
            }
        }

        /// <remarks/>
        public SearchStringField searchKeywords {
            get {
                return this.searchKeywordsField;
            }
            set {
                this.searchKeywordsField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField seasonalDemand {
            get {
                return this.seasonalDemandField;
            }
            set {
                this.seasonalDemandField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField secondaryConsumptionUnit {
            get {
                return this.secondaryConsumptionUnitField;
            }
            set {
                this.secondaryConsumptionUnitField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField secondaryPurchaseUnit {
            get {
                return this.secondaryPurchaseUnitField;
            }
            set {
                this.secondaryPurchaseUnitField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField secondarySaleUnit {
            get {
                return this.secondarySaleUnitField;
            }
            set {
                this.secondarySaleUnitField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField secondaryStockUnit {
            get {
                return this.secondaryStockUnitField;
            }
            set {
                this.secondaryStockUnitField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField secondaryUnitsType {
            get {
                return this.secondaryUnitsTypeField;
            }
            set {
                this.secondaryUnitsTypeField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField sellOnEBay {
            get {
                return this.sellOnEBayField;
            }
            set {
                this.sellOnEBayField = value;
            }
        }

        /// <remarks/>
        public SearchStringField serialNumber {
            get {
                return this.serialNumberField;
            }
            set {
                this.serialNumberField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField serialNumberLocation {
            get {
                return this.serialNumberLocationField;
            }
            set {
                this.serialNumberLocationField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField shipIndividually {
            get {
                return this.shipIndividuallyField;
            }
            set {
                this.shipIndividuallyField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField shipPackage {
            get {
                return this.shipPackageField;
            }
            set {
                this.shipPackageField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField shippingCarrier {
            get {
                return this.shippingCarrierField;
            }
            set {
                this.shippingCarrierField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField shippingRate {
            get {
                return this.shippingRateField;
            }
            set {
                this.shippingRateField = value;
            }
        }

        /// <remarks/>
        public SearchStringField shoppingDotComCategory {
            get {
                return this.shoppingDotComCategoryField;
            }
            set {
                this.shoppingDotComCategoryField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField shoppingProductFeed {
            get {
                return this.shoppingProductFeedField;
            }
            set {
                this.shoppingProductFeedField = value;
            }
        }

        /// <remarks/>
        public SearchLongField shopzillaCategoryId {
            get {
                return this.shopzillaCategoryIdField;
            }
            set {
                this.shopzillaCategoryIdField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField shopzillaProductFeed {
            get {
                return this.shopzillaProductFeedField;
            }
            set {
                this.shopzillaProductFeedField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField sitemapPriority {
            get {
                return this.sitemapPriorityField;
            }
            set {
                this.sitemapPriorityField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField softDescriptor {
            get {
                return this.softDescriptorField;
            }
            set {
                this.softDescriptorField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField startingPrice {
            get {
                return this.startingPriceField;
            }
            set {
                this.startingPriceField = value;
            }
        }

        /// <remarks/>
        public SearchStringField stockDescription {
            get {
                return this.stockDescriptionField;
            }
            set {
                this.stockDescriptionField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField stockUnit {
            get {
                return this.stockUnitField;
            }
            set {
                this.stockUnitField = value;
            }
        }

        /// <remarks/>
        public SearchStringField storeDescription {
            get {
                return this.storeDescriptionField;
            }
            set {
                this.storeDescriptionField = value;
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
        public SearchEnumMultiSelectField subType {
            get {
                return this.subTypeField;
            }
            set {
                this.subTypeField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField supplyLotSizingMethod {
            get {
                return this.supplyLotSizingMethodField;
            }
            set {
                this.supplyLotSizingMethodField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField supplyReplenishmentMethod {
            get {
                return this.supplyReplenishmentMethodField;
            }
            set {
                this.supplyReplenishmentMethodField = value;
            }
        }

        /// <remarks/>
        public SearchLongField supplyTimeFence {
            get {
                return this.supplyTimeFenceField;
            }
            set {
                this.supplyTimeFenceField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField supplyType {
            get {
                return this.supplyTypeField;
            }
            set {
                this.supplyTypeField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField taxCode {
            get {
                return this.taxCodeField;
            }
            set {
                this.taxCodeField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField taxSchedule {
            get {
                return this.taxScheduleField;
            }
            set {
                this.taxScheduleField = value;
            }
        }

        /// <remarks/>
        public SearchStringField thumbnailUrl {
            get {
                return this.thumbnailUrlField;
            }
            set {
                this.thumbnailUrlField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField totalValue {
            get {
                return this.totalValueField;
            }
            set {
                this.totalValueField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField trackLandedCost {
            get {
                return this.trackLandedCostField;
            }
            set {
                this.trackLandedCostField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField transferPrice {
            get {
                return this.transferPriceField;
            }
            set {
                this.transferPriceField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField unitsType {
            get {
                return this.unitsTypeField;
            }
            set {
                this.unitsTypeField = value;
            }
        }

        /// <remarks/>
        public SearchStringField upcCode {
            get {
                return this.upcCodeField;
            }
            set {
                this.upcCodeField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField upperWarningLimit {
            get {
                return this.upperWarningLimitField;
            }
            set {
                this.upperWarningLimitField = value;
            }
        }

        /// <remarks/>
        public SearchStringField urlComponent {
            get {
                return this.urlComponentField;
            }
            set {
                this.urlComponentField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField useBins {
            get {
                return this.useBinsField;
            }
            set {
                this.useBinsField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField useComponentYield {
            get {
                return this.useComponentYieldField;
            }
            set {
                this.useComponentYieldField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField useMarginalRates {
            get {
                return this.useMarginalRatesField;
            }
            set {
                this.useMarginalRatesField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField vendor {
            get {
                return this.vendorField;
            }
            set {
                this.vendorField = value;
            }
        }

        /// <remarks/>
        public SearchStringField vendorCode {
            get {
                return this.vendorCodeField;
            }
            set {
                this.vendorCodeField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField vendorCost {
            get {
                return this.vendorCostField;
            }
            set {
                this.vendorCostField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField vendorCostEntered {
            get {
                return this.vendorCostEnteredField;
            }
            set {
                this.vendorCostEnteredField = value;
            }
        }

        /// <remarks/>
        public SearchStringField vendorName {
            get {
                return this.vendorNameField;
            }
            set {
                this.vendorNameField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField vendorPriceCurrency {
            get {
                return this.vendorPriceCurrencyField;
            }
            set {
                this.vendorPriceCurrencyField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField vsoeDeferral {
            get {
                return this.vsoeDeferralField;
            }
            set {
                this.vsoeDeferralField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField vsoeDelivered {
            get {
                return this.vsoeDeliveredField;
            }
            set {
                this.vsoeDeliveredField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField vsoePermitDiscount {
            get {
                return this.vsoePermitDiscountField;
            }
            set {
                this.vsoePermitDiscountField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField vsoePrice {
            get {
                return this.vsoePriceField;
            }
            set {
                this.vsoePriceField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField vsoeSopGroup {
            get {
                return this.vsoeSopGroupField;
            }
            set {
                this.vsoeSopGroupField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField webSite {
            get {
                return this.webSiteField;
            }
            set {
                this.webSiteField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField weight {
            get {
                return this.weightField;
            }
            set {
                this.weightField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField yahooProductFeed {
            get {
                return this.yahooProductFeedField;
            }
            set {
                this.yahooProductFeedField = value;
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