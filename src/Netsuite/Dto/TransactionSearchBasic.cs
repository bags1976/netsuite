using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class TransactionSearchBasic : SearchRecordBasic {

        private SearchMultiSelectField accountField;

        private SearchEnumMultiSelectField accountTypeField;

        private SearchMultiSelectField acctCorpCardExpField;

        private SearchDateField actualProductionEndDateField;

        private SearchDateField actualProductionStartDateField;

        private SearchDateField actualShipDateField;

        private SearchDoubleField altSalesAmountField;

        private SearchDoubleField altSalesNetAmountField;

        private SearchDoubleField amountField;

        private SearchDoubleField amountPaidField;

        private SearchDoubleField amountRemainingField;

        private SearchDoubleField amountUnbilledField;

        private SearchMultiSelectField anyLineItemField;

        private SearchDoubleField appliedToForeignAmountField;

        private SearchBooleanField appliedToIsFxVarianceField;

        private SearchDoubleField appliedToLinkAmountField;

        private SearchEnumMultiSelectField appliedToLinkTypeField;

        private SearchMultiSelectField appliedToTransactionField;

        private SearchDoubleField applyingForeignAmountField;

        private SearchBooleanField applyingIsFxVarianceField;

        private SearchDoubleField applyingLinkAmountField;

        private SearchEnumMultiSelectField applyingLinkTypeField;

        private SearchMultiSelectField applyingTransactionField;

        private SearchEnumMultiSelectField approvalStatusField;

        private SearchStringField authCodeField;

        private SearchBooleanField autoCalculateLagField;

        private SearchEnumMultiSelectField avsStreetMatchField;

        private SearchEnumMultiSelectField avsZipMatchField;

        private SearchBooleanField billableField;

        private SearchStringField billAddressField;

        private SearchStringField billAddresseeField;

        private SearchStringField billAttentionField;

        private SearchStringField billCityField;

        private SearchEnumMultiSelectField billCountryField;

        private SearchStringField billCountyField;

        private SearchDateField billedDateField;

        private SearchMultiSelectField billingAccountField;

        private SearchMultiSelectField billingScheduleField;

        private SearchBooleanField billingStatusField;

        private SearchMultiSelectField billingTransactionField;

        private SearchStringField billPhoneField;

        private SearchStringField billStateField;

        private SearchEnumMultiSelectField billVarianceStatusField;

        private SearchStringField billZipField;

        private SearchStringField binNumberField;

        private SearchDoubleField binNumberQuantityField;

        private SearchDoubleField bomQuantityField;

        private SearchBooleanField bookSpecificTransactionField;

        private SearchBooleanField buildEntireAssemblyField;

        private SearchDoubleField buildVarianceField;

        private SearchDoubleField builtField;

        private SearchBooleanField canHaveStackablePromotionsField;

        private SearchMultiSelectField catchUpPeriodField;

        private SearchStringField ccCustomerCodeField;

        private SearchDateField ccExpireDateField;

        private SearchStringField ccNameField;

        private SearchStringField ccNumberField;

        private SearchEnumMultiSelectField chargeTypeField;

        private SearchMultiSelectField classField;

        private SearchBooleanField clearedField;

        private SearchBooleanField closedField;

        private SearchDateField closeDateField;

        private SearchBooleanField cogsField;

        private SearchDateField commissionEffectiveDateField;

        private SearchEnumMultiSelectField commitField;

        private SearchDoubleField componentYieldField;

        private SearchStringField confirmationNumberField;

        private SearchLongField contributionField;

        private SearchDoubleField costComponentAmountField;

        private SearchMultiSelectField costComponentCategoryField;

        private SearchMultiSelectField costComponentItemField;

        private SearchDoubleField costComponentQuantityField;

        private SearchDoubleField costComponentStandardCostField;

        private SearchDoubleField costEstimateField;

        private SearchDoubleField costEstimateRateField;

        private SearchEnumMultiSelectField costEstimateTypeField;

        private SearchMultiSelectField createdByField;

        private SearchMultiSelectField createdFromField;

        private SearchDoubleField creditAmountField;

        private SearchEnumMultiSelectField cscMatchField;

        private SearchMultiSelectField currencyField;

        private SearchMultiSelectField customerSubOfField;

        private SearchMultiSelectField customFormField;

        private SearchBooleanField customGLField;

        private SearchMultiSelectField custTypeField;

        private SearchDateField dateCreatedField;

        private SearchLongField daysOpenField;

        private SearchLongField daysOverdueField;

        private SearchDoubleField debitAmountField;

        private SearchDoubleField deferredRevenueField;

        private SearchBooleanField deferRevRecField;

        private SearchMultiSelectField departmentField;

        private SearchDateField depositDateField;

        private SearchMultiSelectField depositTransactionField;

        private SearchMultiSelectField drAccountField;

        private SearchDateField dueDateField;

        private SearchStringField emailField;

        private SearchMultiSelectField employeeField;

        private SearchDateField endDateField;

        private SearchMultiSelectField entityField;

        private SearchMultiSelectField entityStatusField;

        private SearchDoubleField estGrossProfitField;

        private SearchDoubleField estGrossProfitPctField;

        private SearchDoubleField exchangeRateField;

        private SearchBooleanField excludeCommissionField;

        private SearchBooleanField excludeFromRateRequestField;

        private SearchDateField expectedCloseDateField;

        private SearchDateField expectedReceiptDateField;

        private SearchMultiSelectField expenseCategoryField;

        private SearchDateField expenseDateField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchBooleanField finChrgField;

        private SearchBooleanField firmedField;

        private SearchEnumMultiSelectField forecastTypeField;

        private SearchMultiSelectField fulfillingTransactionField;

        private SearchMultiSelectField fxAccountField;

        private SearchDoubleField fxAmountField;

        private SearchDoubleField fxCostEstimateField;

        private SearchDoubleField fxCostEstimateRateField;

        private SearchDoubleField fxEstGrossProfitField;

        private SearchDoubleField fxTranCostEstimateField;

        private SearchDoubleField fxVsoeAllocationField;

        private SearchDoubleField fxVsoeAmountField;

        private SearchDoubleField fxVsoePriceField;

        private SearchBooleanField gcoAvailabelToChargeField;

        private SearchBooleanField gcoAvailableToRefundField;

        private SearchEnumMultiSelectField gcoAvsStreetMatchField;

        private SearchEnumMultiSelectField gcoAvsZipMatchField;

        private SearchLongField gcoBuyerAccountAgeField;

        private SearchStringField gcoBuyerIpField;

        private SearchDoubleField gcoChargeAmountField;

        private SearchDoubleField gcoChargebackAmountField;

        private SearchDoubleField gcoConfirmedChargedTotalField;

        private SearchDoubleField gcoConfirmedRefundedTotalField;

        private SearchStringField gcoCreditcardNumberField;

        private SearchEnumMultiSelectField gcoCscMatchField;

        private SearchStringField gcoFinancialStateField;

        private SearchStringField gcoFulfillmentStateField;

        private SearchStringField gcoOrderIdField;

        private SearchDoubleField gcoOrderTotalField;

        private SearchDoubleField gcoPromotionAmountField;

        private SearchStringField gcoPromotionNameField;

        private SearchDoubleField gcoRefundAmountField;

        private SearchDoubleField gcoShippingTotalField;

        private SearchStringField gcoStateChangedDetailField;

        private SearchStringField giftCertificateField;

        private SearchDoubleField grossAmountField;

        private SearchBooleanField includeInForecastField;

        private SearchMultiSelectField incotermField;

        private SearchEnumMultiSelectField intercoStatusField;

        private SearchMultiSelectField intercoTransactionField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchMultiSelectField inventoryLocationField;

        private SearchMultiSelectField inventorySubsidiaryField;

        private SearchBooleanField inVsoeBundleField;

        private SearchBooleanField isAllocationField;

        private SearchBooleanField isBackflushField;

        private SearchBooleanField isGcoChargebackField;

        private SearchBooleanField isGcoChargeConfirmedField;

        private SearchBooleanField isGcoPaymentGuaranteedField;

        private SearchBooleanField isGcoRefundConfirmedField;

        private SearchBooleanField isInsideDeliveryField;

        private SearchBooleanField isInsidePickupField;

        private SearchBooleanField isIntercompanyAdjustmentField;

        private SearchBooleanField isInTransitPaymentField;

        private SearchBooleanField isMultiShipToField;

        private SearchBooleanField isPayPalMethField;

        private SearchBooleanField isReversalField;

        private SearchBooleanField isRevRecTransactionField;

        private SearchBooleanField isScrapField;

        private SearchBooleanField isShipAddressField;

        private SearchBooleanField isTransferPriceCostingField;

        private SearchBooleanField isVsoeAllocField;

        private SearchBooleanField isWipField;

        private SearchMultiSelectField itemField;

        private SearchEnumMultiSelectField itemFulfillmentChoiceField;

        private SearchMultiSelectField itemRevisionField;

        private SearchMultiSelectField itemSubOfField;

        private SearchBooleanField landedCostPerLineField;

        private SearchDateField lastModifiedDateField;

        private SearchMultiSelectField leadSourceField;

        private SearchLongField lineUniqueKeyField;

        private SearchMultiSelectField locationField;

        private SearchBooleanField locationAutoAssignedField;

        private SearchBooleanField mainLineField;

        private SearchMultiSelectField mainNameField;

        private SearchMultiSelectField manufacturingRoutingField;

        private SearchBooleanField matchBillToReceiptField;

        private SearchStringField memoField;

        private SearchStringField memoMainField;

        private SearchBooleanField memorizedField;

        private SearchStringField merchantAccountField;

        private SearchStringField messageField;

        private SearchBooleanField multiSubsidiaryField;

        private SearchStringField nameTextField;

        private SearchDoubleField netAmountField;

        private SearchMultiSelectField nextApproverField;

        private SearchDateField nextBillDateField;

        private SearchMultiSelectField nexusField;

        private SearchBooleanField noAutoAssignLocationField;

        private SearchBooleanField nonReimbursableField;

        private SearchLongField numberField;

        private SearchDoubleField oneTimeTotalField;

        private SearchMultiSelectField opportunityField;

        private SearchMultiSelectField orderAllocationStrategyField;

        private SearchDoubleField orderPriorityField;

        private SearchTextNumberField otherRefNumField;

        private SearchTextNumberField otherRefNumNonDepositField;

        private SearchMultiSelectField overheadParentItemField;

        private SearchBooleanField overrideInstallmentsField;

        private SearchLongField packageCountField;

        private SearchMultiSelectField paidTransactionField;

        private SearchLongField parentField;

        private SearchMultiSelectField partnerField;

        private SearchLongField partnerContributionField;

        private SearchMultiSelectField partnerRoleField;

        private SearchMultiSelectField partnerTeamMemberField;

        private SearchMultiSelectField payingTransactionField;

        private SearchBooleanField paymentApprovedField;

        private SearchDateField paymentEventDateField;

        private SearchEnumMultiSelectField paymentEventHoldReasonField;

        private SearchBooleanField paymentEventPurchaseCardUsedField;

        private SearchBooleanField paymentEventPurchaseDataSentField;

        private SearchEnumMultiSelectField paymentEventResultField;

        private SearchEnumMultiSelectField paymentEventTypeField;

        private SearchBooleanField paymentHoldField;

        private SearchMultiSelectField paymentMethodField;

        private SearchStringField paymentOptionField;

        private SearchBooleanField payPalPendingField;

        private SearchStringField payPalStatusField;

        private SearchStringField payPalTranIdField;

        private SearchStringField pnRefNumField;

        private SearchStringField poAsTextField;

        private SearchBooleanField policyViolatedField;

        private SearchBooleanField postingField;

        private RecordRef postingPeriodField;

        private PostingPeriodDate postingPeriodRelativeField;

        private bool postingPeriodRelativeFieldSpecified;

        private SearchMultiSelectField priceLevelField;

        private SearchBooleanField printedPickingTicketField;

        private SearchLongField probabilityField;

        private SearchDoubleField projectedAmountField;

        private SearchMultiSelectField projectTaskField;

        private SearchMultiSelectField promoCodeField;

        private SearchMultiSelectField purchaseOrderField;

        private SearchDoubleField quantityField;

        private SearchDoubleField quantityBilledField;

        private SearchDoubleField quantityCommittedField;

        private SearchDoubleField quantityPackedField;

        private SearchDoubleField quantityPickedField;

        private SearchDoubleField quantityRevCommittedField;

        private SearchDoubleField quantityShipRecvField;

        private SearchDoubleField recognizedRevenueField;

        private SearchStringField recordTypeField;

        private SearchDoubleField recurAnnuallyTotalField;

        private SearchDoubleField recurMonthlyTotalField;

        private SearchDoubleField recurQuarterlyTotalField;

        private SearchBooleanField recurringBillField;

        private SearchDoubleField recurWeeklyTotalField;

        private SearchLongField refNumberField;

        private SearchDateField requestedDateField;

        private SearchEnumMultiSelectField revCommitStatusField;

        private SearchBooleanField revCommittingStatusField;

        private SearchMultiSelectField revCommittingTransactionField;

        private SearchEnumMultiSelectField revenueStatusField;

        private SearchDateField reversalDateField;

        private SearchStringField reversalNumberField;

        private SearchDateField revRecEndDateField;

        private SearchBooleanField revRecOnRevCommitmentField;

        private SearchDateField revRecStartDateField;

        private SearchLongField revRecTermInMonthsField;

        private SearchDateField salesEffectiveDateField;

        private SearchMultiSelectField salesOrderField;

        private SearchMultiSelectField salesRepField;

        private SearchMultiSelectField salesTeamMemberField;

        private SearchMultiSelectField salesTeamRoleField;

        private SearchEnumMultiSelectField schedulingMethodField;

        private SearchStringField serialNumberField;

        private SearchDoubleField serialNumberCostField;

        private SearchDoubleField serialNumberCostAdjustmentField;

        private SearchDoubleField serialNumberQuantityField;

        private SearchStringField serialNumbersField;

        private SearchStringField shipAddressField;

        private SearchStringField shipAddresseeField;

        private SearchStringField shipAttentionField;

        private SearchEnumMultiSelectField shipCarrierField;

        private SearchStringField shipCityField;

        private SearchBooleanField shipCompleteField;

        private SearchEnumMultiSelectField shipCountryField;

        private SearchStringField shipCountyField;

        private SearchDateField shipDateField;

        private SearchLongField shipGroupField;

        private SearchMultiSelectField shipMethodField;

        private SearchStringField shipPhoneField;

        private SearchBooleanField shippingField;

        private SearchBooleanField shipRecvStatusField;

        private SearchBooleanField shipRecvStatusLineField;

        private SearchMultiSelectField shipStateField;

        private SearchMultiSelectField shipToField;

        private SearchStringField shipZipField;

        private SearchEnumMultiSelectField sourceField;

        private SearchDateField startDateField;

        private SearchBooleanField statisticalField;

        private SearchEnumMultiSelectField statusField;

        private SearchMultiSelectField subscriptionField;

        private SearchMultiSelectField subscriptionLineField;

        private SearchMultiSelectField subsidiaryField;

        private SearchMultiSelectField subsidiaryTaxRegNumField;

        private SearchMultiSelectField taxItemField;

        private SearchBooleanField taxLineField;

        private RecordRef taxPeriodField;

        private PostingPeriodDate taxPeriodRelativeField;

        private bool taxPeriodRelativeFieldSpecified;

        private SearchDateField taxPointDateField;

        private SearchDoubleField taxRateField;

        private SearchMultiSelectField termsField;

        private SearchEnumMultiSelectField termsOfSaleField;

        private SearchStringField titleField;

        private SearchBooleanField toBeEmailedField;

        private SearchBooleanField toBePrintedField;

        private SearchMultiSelectField toSubsidiaryField;

        private SearchDoubleField totalAmountField;

        private SearchStringField trackingNumbersField;

        private SearchDoubleField tranCostEstimateField;

        private SearchDateField tranDateField;

        private SearchDoubleField tranEstGrossProfitField;

        private SearchDoubleField tranEstGrossProfitPctField;

        private SearchDoubleField tranFxEstGrossProfitField;

        private SearchStringField tranIdField;

        private SearchBooleanField tranIsVsoeBundleField;

        private SearchBooleanField transactionDiscountField;

        private SearchEnumMultiSelectField transactionLineTypeField;

        private SearchStringField transactionNumberField;

        private SearchMultiSelectField transferLocationField;

        private SearchDoubleField transferOrderQuantityCommittedField;

        private SearchDoubleField transferOrderQuantityPackedField;

        private SearchDoubleField transferOrderQuantityPickedField;

        private SearchDoubleField transferOrderQuantityReceivedField;

        private SearchDoubleField transferOrderQuantityShippedField;

        private SearchEnumMultiSelectField typeField;

        private SearchMultiSelectField unitField;

        private SearchDoubleField unitCostOverrideField;

        private SearchMultiSelectField unitsTypeField;

        private SearchMultiSelectField vendTypeField;

        private SearchBooleanField visibleToCustomerField;

        private SearchBooleanField voidedField;

        private SearchDoubleField vsoeAllocationField;

        private SearchDoubleField vsoeAmountField;

        private SearchEnumMultiSelectField vsoeDeferralField;

        private SearchBooleanField vsoeDeliveredField;

        private SearchEnumMultiSelectField vsoePermitDiscountField;

        private SearchDoubleField vsoePriceField;

        private SearchMultiSelectField webSiteField;

        private SearchCustomField[] customFieldListField;

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
        public SearchEnumMultiSelectField accountType {
            get {
                return this.accountTypeField;
            }
            set {
                this.accountTypeField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField acctCorpCardExp {
            get {
                return this.acctCorpCardExpField;
            }
            set {
                this.acctCorpCardExpField = value;
            }
        }

        /// <remarks/>
        public SearchDateField actualProductionEndDate {
            get {
                return this.actualProductionEndDateField;
            }
            set {
                this.actualProductionEndDateField = value;
            }
        }

        /// <remarks/>
        public SearchDateField actualProductionStartDate {
            get {
                return this.actualProductionStartDateField;
            }
            set {
                this.actualProductionStartDateField = value;
            }
        }

        /// <remarks/>
        public SearchDateField actualShipDate {
            get {
                return this.actualShipDateField;
            }
            set {
                this.actualShipDateField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField altSalesAmount {
            get {
                return this.altSalesAmountField;
            }
            set {
                this.altSalesAmountField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField altSalesNetAmount {
            get {
                return this.altSalesNetAmountField;
            }
            set {
                this.altSalesNetAmountField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField amountPaid {
            get {
                return this.amountPaidField;
            }
            set {
                this.amountPaidField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField amountRemaining {
            get {
                return this.amountRemainingField;
            }
            set {
                this.amountRemainingField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField amountUnbilled {
            get {
                return this.amountUnbilledField;
            }
            set {
                this.amountUnbilledField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField anyLineItem {
            get {
                return this.anyLineItemField;
            }
            set {
                this.anyLineItemField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField appliedToForeignAmount {
            get {
                return this.appliedToForeignAmountField;
            }
            set {
                this.appliedToForeignAmountField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField appliedToIsFxVariance {
            get {
                return this.appliedToIsFxVarianceField;
            }
            set {
                this.appliedToIsFxVarianceField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField appliedToLinkAmount {
            get {
                return this.appliedToLinkAmountField;
            }
            set {
                this.appliedToLinkAmountField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField appliedToLinkType {
            get {
                return this.appliedToLinkTypeField;
            }
            set {
                this.appliedToLinkTypeField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField appliedToTransaction {
            get {
                return this.appliedToTransactionField;
            }
            set {
                this.appliedToTransactionField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField applyingForeignAmount {
            get {
                return this.applyingForeignAmountField;
            }
            set {
                this.applyingForeignAmountField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField applyingIsFxVariance {
            get {
                return this.applyingIsFxVarianceField;
            }
            set {
                this.applyingIsFxVarianceField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField applyingLinkAmount {
            get {
                return this.applyingLinkAmountField;
            }
            set {
                this.applyingLinkAmountField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField applyingLinkType {
            get {
                return this.applyingLinkTypeField;
            }
            set {
                this.applyingLinkTypeField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField applyingTransaction {
            get {
                return this.applyingTransactionField;
            }
            set {
                this.applyingTransactionField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField approvalStatus {
            get {
                return this.approvalStatusField;
            }
            set {
                this.approvalStatusField = value;
            }
        }

        /// <remarks/>
        public SearchStringField authCode {
            get {
                return this.authCodeField;
            }
            set {
                this.authCodeField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField autoCalculateLag {
            get {
                return this.autoCalculateLagField;
            }
            set {
                this.autoCalculateLagField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField avsStreetMatch {
            get {
                return this.avsStreetMatchField;
            }
            set {
                this.avsStreetMatchField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField avsZipMatch {
            get {
                return this.avsZipMatchField;
            }
            set {
                this.avsZipMatchField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField billable {
            get {
                return this.billableField;
            }
            set {
                this.billableField = value;
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
        public SearchStringField billAddressee {
            get {
                return this.billAddresseeField;
            }
            set {
                this.billAddresseeField = value;
            }
        }

        /// <remarks/>
        public SearchStringField billAttention {
            get {
                return this.billAttentionField;
            }
            set {
                this.billAttentionField = value;
            }
        }

        /// <remarks/>
        public SearchStringField billCity {
            get {
                return this.billCityField;
            }
            set {
                this.billCityField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField billCountry {
            get {
                return this.billCountryField;
            }
            set {
                this.billCountryField = value;
            }
        }

        /// <remarks/>
        public SearchStringField billCounty {
            get {
                return this.billCountyField;
            }
            set {
                this.billCountyField = value;
            }
        }

        /// <remarks/>
        public SearchDateField billedDate {
            get {
                return this.billedDateField;
            }
            set {
                this.billedDateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField billingAccount {
            get {
                return this.billingAccountField;
            }
            set {
                this.billingAccountField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField billingSchedule {
            get {
                return this.billingScheduleField;
            }
            set {
                this.billingScheduleField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField billingStatus {
            get {
                return this.billingStatusField;
            }
            set {
                this.billingStatusField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField billingTransaction {
            get {
                return this.billingTransactionField;
            }
            set {
                this.billingTransactionField = value;
            }
        }

        /// <remarks/>
        public SearchStringField billPhone {
            get {
                return this.billPhoneField;
            }
            set {
                this.billPhoneField = value;
            }
        }

        /// <remarks/>
        public SearchStringField billState {
            get {
                return this.billStateField;
            }
            set {
                this.billStateField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField billVarianceStatus {
            get {
                return this.billVarianceStatusField;
            }
            set {
                this.billVarianceStatusField = value;
            }
        }

        /// <remarks/>
        public SearchStringField billZip {
            get {
                return this.billZipField;
            }
            set {
                this.billZipField = value;
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
        public SearchDoubleField binNumberQuantity {
            get {
                return this.binNumberQuantityField;
            }
            set {
                this.binNumberQuantityField = value;
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
        public SearchBooleanField bookSpecificTransaction {
            get {
                return this.bookSpecificTransactionField;
            }
            set {
                this.bookSpecificTransactionField = value;
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
        public SearchDoubleField buildVariance {
            get {
                return this.buildVarianceField;
            }
            set {
                this.buildVarianceField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField built {
            get {
                return this.builtField;
            }
            set {
                this.builtField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField canHaveStackablePromotions {
            get {
                return this.canHaveStackablePromotionsField;
            }
            set {
                this.canHaveStackablePromotionsField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField catchUpPeriod {
            get {
                return this.catchUpPeriodField;
            }
            set {
                this.catchUpPeriodField = value;
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
        public SearchDateField ccExpireDate {
            get {
                return this.ccExpireDateField;
            }
            set {
                this.ccExpireDateField = value;
            }
        }

        /// <remarks/>
        public SearchStringField ccName {
            get {
                return this.ccNameField;
            }
            set {
                this.ccNameField = value;
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
        public SearchEnumMultiSelectField chargeType {
            get {
                return this.chargeTypeField;
            }
            set {
                this.chargeTypeField = value;
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
        public SearchBooleanField cleared {
            get {
                return this.clearedField;
            }
            set {
                this.clearedField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField closed {
            get {
                return this.closedField;
            }
            set {
                this.closedField = value;
            }
        }

        /// <remarks/>
        public SearchDateField closeDate {
            get {
                return this.closeDateField;
            }
            set {
                this.closeDateField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField cogs {
            get {
                return this.cogsField;
            }
            set {
                this.cogsField = value;
            }
        }

        /// <remarks/>
        public SearchDateField commissionEffectiveDate {
            get {
                return this.commissionEffectiveDateField;
            }
            set {
                this.commissionEffectiveDateField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField commit {
            get {
                return this.commitField;
            }
            set {
                this.commitField = value;
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
        public SearchStringField confirmationNumber {
            get {
                return this.confirmationNumberField;
            }
            set {
                this.confirmationNumberField = value;
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
        public SearchDoubleField costComponentAmount {
            get {
                return this.costComponentAmountField;
            }
            set {
                this.costComponentAmountField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField costComponentCategory {
            get {
                return this.costComponentCategoryField;
            }
            set {
                this.costComponentCategoryField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField costComponentItem {
            get {
                return this.costComponentItemField;
            }
            set {
                this.costComponentItemField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField costComponentQuantity {
            get {
                return this.costComponentQuantityField;
            }
            set {
                this.costComponentQuantityField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField costComponentStandardCost {
            get {
                return this.costComponentStandardCostField;
            }
            set {
                this.costComponentStandardCostField = value;
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
        public SearchDoubleField costEstimateRate {
            get {
                return this.costEstimateRateField;
            }
            set {
                this.costEstimateRateField = value;
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
        public SearchMultiSelectField createdBy {
            get {
                return this.createdByField;
            }
            set {
                this.createdByField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField createdFrom {
            get {
                return this.createdFromField;
            }
            set {
                this.createdFromField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField creditAmount {
            get {
                return this.creditAmountField;
            }
            set {
                this.creditAmountField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField cscMatch {
            get {
                return this.cscMatchField;
            }
            set {
                this.cscMatchField = value;
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
        public SearchMultiSelectField customerSubOf {
            get {
                return this.customerSubOfField;
            }
            set {
                this.customerSubOfField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField customForm {
            get {
                return this.customFormField;
            }
            set {
                this.customFormField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField customGL {
            get {
                return this.customGLField;
            }
            set {
                this.customGLField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField custType {
            get {
                return this.custTypeField;
            }
            set {
                this.custTypeField = value;
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
        public SearchLongField daysOpen {
            get {
                return this.daysOpenField;
            }
            set {
                this.daysOpenField = value;
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
        public SearchDoubleField debitAmount {
            get {
                return this.debitAmountField;
            }
            set {
                this.debitAmountField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField deferredRevenue {
            get {
                return this.deferredRevenueField;
            }
            set {
                this.deferredRevenueField = value;
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
        public SearchMultiSelectField department {
            get {
                return this.departmentField;
            }
            set {
                this.departmentField = value;
            }
        }

        /// <remarks/>
        public SearchDateField depositDate {
            get {
                return this.depositDateField;
            }
            set {
                this.depositDateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField depositTransaction {
            get {
                return this.depositTransactionField;
            }
            set {
                this.depositTransactionField = value;
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
        public SearchDateField dueDate {
            get {
                return this.dueDateField;
            }
            set {
                this.dueDateField = value;
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
        public SearchMultiSelectField employee {
            get {
                return this.employeeField;
            }
            set {
                this.employeeField = value;
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
        public SearchMultiSelectField entity {
            get {
                return this.entityField;
            }
            set {
                this.entityField = value;
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
        public SearchDoubleField estGrossProfit {
            get {
                return this.estGrossProfitField;
            }
            set {
                this.estGrossProfitField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField estGrossProfitPct {
            get {
                return this.estGrossProfitPctField;
            }
            set {
                this.estGrossProfitPctField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField exchangeRate {
            get {
                return this.exchangeRateField;
            }
            set {
                this.exchangeRateField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField excludeCommission {
            get {
                return this.excludeCommissionField;
            }
            set {
                this.excludeCommissionField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField excludeFromRateRequest {
            get {
                return this.excludeFromRateRequestField;
            }
            set {
                this.excludeFromRateRequestField = value;
            }
        }

        /// <remarks/>
        public SearchDateField expectedCloseDate {
            get {
                return this.expectedCloseDateField;
            }
            set {
                this.expectedCloseDateField = value;
            }
        }

        /// <remarks/>
        public SearchDateField expectedReceiptDate {
            get {
                return this.expectedReceiptDateField;
            }
            set {
                this.expectedReceiptDateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField expenseCategory {
            get {
                return this.expenseCategoryField;
            }
            set {
                this.expenseCategoryField = value;
            }
        }

        /// <remarks/>
        public SearchDateField expenseDate {
            get {
                return this.expenseDateField;
            }
            set {
                this.expenseDateField = value;
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
        public SearchBooleanField finChrg {
            get {
                return this.finChrgField;
            }
            set {
                this.finChrgField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField firmed {
            get {
                return this.firmedField;
            }
            set {
                this.firmedField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField forecastType {
            get {
                return this.forecastTypeField;
            }
            set {
                this.forecastTypeField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField fulfillingTransaction {
            get {
                return this.fulfillingTransactionField;
            }
            set {
                this.fulfillingTransactionField = value;
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
        public SearchDoubleField fxAmount {
            get {
                return this.fxAmountField;
            }
            set {
                this.fxAmountField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField fxCostEstimate {
            get {
                return this.fxCostEstimateField;
            }
            set {
                this.fxCostEstimateField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField fxCostEstimateRate {
            get {
                return this.fxCostEstimateRateField;
            }
            set {
                this.fxCostEstimateRateField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField fxEstGrossProfit {
            get {
                return this.fxEstGrossProfitField;
            }
            set {
                this.fxEstGrossProfitField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField fxTranCostEstimate {
            get {
                return this.fxTranCostEstimateField;
            }
            set {
                this.fxTranCostEstimateField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField fxVsoeAllocation {
            get {
                return this.fxVsoeAllocationField;
            }
            set {
                this.fxVsoeAllocationField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField fxVsoeAmount {
            get {
                return this.fxVsoeAmountField;
            }
            set {
                this.fxVsoeAmountField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField fxVsoePrice {
            get {
                return this.fxVsoePriceField;
            }
            set {
                this.fxVsoePriceField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField gcoAvailabelToCharge {
            get {
                return this.gcoAvailabelToChargeField;
            }
            set {
                this.gcoAvailabelToChargeField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField gcoAvailableToRefund {
            get {
                return this.gcoAvailableToRefundField;
            }
            set {
                this.gcoAvailableToRefundField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField gcoAvsStreetMatch {
            get {
                return this.gcoAvsStreetMatchField;
            }
            set {
                this.gcoAvsStreetMatchField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField gcoAvsZipMatch {
            get {
                return this.gcoAvsZipMatchField;
            }
            set {
                this.gcoAvsZipMatchField = value;
            }
        }

        /// <remarks/>
        public SearchLongField gcoBuyerAccountAge {
            get {
                return this.gcoBuyerAccountAgeField;
            }
            set {
                this.gcoBuyerAccountAgeField = value;
            }
        }

        /// <remarks/>
        public SearchStringField gcoBuyerIp {
            get {
                return this.gcoBuyerIpField;
            }
            set {
                this.gcoBuyerIpField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField gcoChargeAmount {
            get {
                return this.gcoChargeAmountField;
            }
            set {
                this.gcoChargeAmountField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField gcoChargebackAmount {
            get {
                return this.gcoChargebackAmountField;
            }
            set {
                this.gcoChargebackAmountField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField gcoConfirmedChargedTotal {
            get {
                return this.gcoConfirmedChargedTotalField;
            }
            set {
                this.gcoConfirmedChargedTotalField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField gcoConfirmedRefundedTotal {
            get {
                return this.gcoConfirmedRefundedTotalField;
            }
            set {
                this.gcoConfirmedRefundedTotalField = value;
            }
        }

        /// <remarks/>
        public SearchStringField gcoCreditcardNumber {
            get {
                return this.gcoCreditcardNumberField;
            }
            set {
                this.gcoCreditcardNumberField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField gcoCscMatch {
            get {
                return this.gcoCscMatchField;
            }
            set {
                this.gcoCscMatchField = value;
            }
        }

        /// <remarks/>
        public SearchStringField gcoFinancialState {
            get {
                return this.gcoFinancialStateField;
            }
            set {
                this.gcoFinancialStateField = value;
            }
        }

        /// <remarks/>
        public SearchStringField gcoFulfillmentState {
            get {
                return this.gcoFulfillmentStateField;
            }
            set {
                this.gcoFulfillmentStateField = value;
            }
        }

        /// <remarks/>
        public SearchStringField gcoOrderId {
            get {
                return this.gcoOrderIdField;
            }
            set {
                this.gcoOrderIdField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField gcoOrderTotal {
            get {
                return this.gcoOrderTotalField;
            }
            set {
                this.gcoOrderTotalField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField gcoPromotionAmount {
            get {
                return this.gcoPromotionAmountField;
            }
            set {
                this.gcoPromotionAmountField = value;
            }
        }

        /// <remarks/>
        public SearchStringField gcoPromotionName {
            get {
                return this.gcoPromotionNameField;
            }
            set {
                this.gcoPromotionNameField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField gcoRefundAmount {
            get {
                return this.gcoRefundAmountField;
            }
            set {
                this.gcoRefundAmountField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField gcoShippingTotal {
            get {
                return this.gcoShippingTotalField;
            }
            set {
                this.gcoShippingTotalField = value;
            }
        }

        /// <remarks/>
        public SearchStringField gcoStateChangedDetail {
            get {
                return this.gcoStateChangedDetailField;
            }
            set {
                this.gcoStateChangedDetailField = value;
            }
        }

        /// <remarks/>
        public SearchStringField giftCertificate {
            get {
                return this.giftCertificateField;
            }
            set {
                this.giftCertificateField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField grossAmount {
            get {
                return this.grossAmountField;
            }
            set {
                this.grossAmountField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField includeInForecast {
            get {
                return this.includeInForecastField;
            }
            set {
                this.includeInForecastField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField incoterm {
            get {
                return this.incotermField;
            }
            set {
                this.incotermField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField intercoStatus {
            get {
                return this.intercoStatusField;
            }
            set {
                this.intercoStatusField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField intercoTransaction {
            get {
                return this.intercoTransactionField;
            }
            set {
                this.intercoTransactionField = value;
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
        public SearchMultiSelectField inventorySubsidiary {
            get {
                return this.inventorySubsidiaryField;
            }
            set {
                this.inventorySubsidiaryField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField inVsoeBundle {
            get {
                return this.inVsoeBundleField;
            }
            set {
                this.inVsoeBundleField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isAllocation {
            get {
                return this.isAllocationField;
            }
            set {
                this.isAllocationField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isBackflush {
            get {
                return this.isBackflushField;
            }
            set {
                this.isBackflushField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isGcoChargeback {
            get {
                return this.isGcoChargebackField;
            }
            set {
                this.isGcoChargebackField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isGcoChargeConfirmed {
            get {
                return this.isGcoChargeConfirmedField;
            }
            set {
                this.isGcoChargeConfirmedField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isGcoPaymentGuaranteed {
            get {
                return this.isGcoPaymentGuaranteedField;
            }
            set {
                this.isGcoPaymentGuaranteedField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isGcoRefundConfirmed {
            get {
                return this.isGcoRefundConfirmedField;
            }
            set {
                this.isGcoRefundConfirmedField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isInsideDelivery {
            get {
                return this.isInsideDeliveryField;
            }
            set {
                this.isInsideDeliveryField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isInsidePickup {
            get {
                return this.isInsidePickupField;
            }
            set {
                this.isInsidePickupField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isIntercompanyAdjustment {
            get {
                return this.isIntercompanyAdjustmentField;
            }
            set {
                this.isIntercompanyAdjustmentField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isInTransitPayment {
            get {
                return this.isInTransitPaymentField;
            }
            set {
                this.isInTransitPaymentField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isMultiShipTo {
            get {
                return this.isMultiShipToField;
            }
            set {
                this.isMultiShipToField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isPayPalMeth {
            get {
                return this.isPayPalMethField;
            }
            set {
                this.isPayPalMethField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isReversal {
            get {
                return this.isReversalField;
            }
            set {
                this.isReversalField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isRevRecTransaction {
            get {
                return this.isRevRecTransactionField;
            }
            set {
                this.isRevRecTransactionField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isScrap {
            get {
                return this.isScrapField;
            }
            set {
                this.isScrapField = value;
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
        public SearchBooleanField isTransferPriceCosting {
            get {
                return this.isTransferPriceCostingField;
            }
            set {
                this.isTransferPriceCostingField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isVsoeAlloc {
            get {
                return this.isVsoeAllocField;
            }
            set {
                this.isVsoeAllocField = value;
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
        public SearchMultiSelectField item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField itemFulfillmentChoice {
            get {
                return this.itemFulfillmentChoiceField;
            }
            set {
                this.itemFulfillmentChoiceField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField itemRevision {
            get {
                return this.itemRevisionField;
            }
            set {
                this.itemRevisionField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField itemSubOf {
            get {
                return this.itemSubOfField;
            }
            set {
                this.itemSubOfField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField landedCostPerLine {
            get {
                return this.landedCostPerLineField;
            }
            set {
                this.landedCostPerLineField = value;
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
        public SearchMultiSelectField leadSource {
            get {
                return this.leadSourceField;
            }
            set {
                this.leadSourceField = value;
            }
        }

        /// <remarks/>
        public SearchLongField lineUniqueKey {
            get {
                return this.lineUniqueKeyField;
            }
            set {
                this.lineUniqueKeyField = value;
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
        public SearchBooleanField locationAutoAssigned {
            get {
                return this.locationAutoAssignedField;
            }
            set {
                this.locationAutoAssignedField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField mainLine {
            get {
                return this.mainLineField;
            }
            set {
                this.mainLineField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField mainName {
            get {
                return this.mainNameField;
            }
            set {
                this.mainNameField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField manufacturingRouting {
            get {
                return this.manufacturingRoutingField;
            }
            set {
                this.manufacturingRoutingField = value;
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
        public SearchStringField memo {
            get {
                return this.memoField;
            }
            set {
                this.memoField = value;
            }
        }

        /// <remarks/>
        public SearchStringField memoMain {
            get {
                return this.memoMainField;
            }
            set {
                this.memoMainField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField memorized {
            get {
                return this.memorizedField;
            }
            set {
                this.memorizedField = value;
            }
        }

        /// <remarks/>
        public SearchStringField merchantAccount {
            get {
                return this.merchantAccountField;
            }
            set {
                this.merchantAccountField = value;
            }
        }

        /// <remarks/>
        public SearchStringField message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField multiSubsidiary {
            get {
                return this.multiSubsidiaryField;
            }
            set {
                this.multiSubsidiaryField = value;
            }
        }

        /// <remarks/>
        public SearchStringField nameText {
            get {
                return this.nameTextField;
            }
            set {
                this.nameTextField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField netAmount {
            get {
                return this.netAmountField;
            }
            set {
                this.netAmountField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField nextApprover {
            get {
                return this.nextApproverField;
            }
            set {
                this.nextApproverField = value;
            }
        }

        /// <remarks/>
        public SearchDateField nextBillDate {
            get {
                return this.nextBillDateField;
            }
            set {
                this.nextBillDateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField nexus {
            get {
                return this.nexusField;
            }
            set {
                this.nexusField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField noAutoAssignLocation {
            get {
                return this.noAutoAssignLocationField;
            }
            set {
                this.noAutoAssignLocationField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField nonReimbursable {
            get {
                return this.nonReimbursableField;
            }
            set {
                this.nonReimbursableField = value;
            }
        }

        /// <remarks/>
        public SearchLongField number {
            get {
                return this.numberField;
            }
            set {
                this.numberField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField oneTimeTotal {
            get {
                return this.oneTimeTotalField;
            }
            set {
                this.oneTimeTotalField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField opportunity {
            get {
                return this.opportunityField;
            }
            set {
                this.opportunityField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField orderAllocationStrategy {
            get {
                return this.orderAllocationStrategyField;
            }
            set {
                this.orderAllocationStrategyField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField orderPriority {
            get {
                return this.orderPriorityField;
            }
            set {
                this.orderPriorityField = value;
            }
        }

        /// <remarks/>
        public SearchTextNumberField otherRefNum {
            get {
                return this.otherRefNumField;
            }
            set {
                this.otherRefNumField = value;
            }
        }

        /// <remarks/>
        public SearchTextNumberField otherRefNumNonDeposit {
            get {
                return this.otherRefNumNonDepositField;
            }
            set {
                this.otherRefNumNonDepositField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField overheadParentItem {
            get {
                return this.overheadParentItemField;
            }
            set {
                this.overheadParentItemField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField overrideInstallments {
            get {
                return this.overrideInstallmentsField;
            }
            set {
                this.overrideInstallmentsField = value;
            }
        }

        /// <remarks/>
        public SearchLongField packageCount {
            get {
                return this.packageCountField;
            }
            set {
                this.packageCountField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField paidTransaction {
            get {
                return this.paidTransactionField;
            }
            set {
                this.paidTransactionField = value;
            }
        }

        /// <remarks/>
        public SearchLongField parent {
            get {
                return this.parentField;
            }
            set {
                this.parentField = value;
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
        public SearchMultiSelectField payingTransaction {
            get {
                return this.payingTransactionField;
            }
            set {
                this.payingTransactionField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField paymentApproved {
            get {
                return this.paymentApprovedField;
            }
            set {
                this.paymentApprovedField = value;
            }
        }

        /// <remarks/>
        public SearchDateField paymentEventDate {
            get {
                return this.paymentEventDateField;
            }
            set {
                this.paymentEventDateField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField paymentEventHoldReason {
            get {
                return this.paymentEventHoldReasonField;
            }
            set {
                this.paymentEventHoldReasonField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField paymentEventPurchaseCardUsed {
            get {
                return this.paymentEventPurchaseCardUsedField;
            }
            set {
                this.paymentEventPurchaseCardUsedField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField paymentEventPurchaseDataSent {
            get {
                return this.paymentEventPurchaseDataSentField;
            }
            set {
                this.paymentEventPurchaseDataSentField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField paymentEventResult {
            get {
                return this.paymentEventResultField;
            }
            set {
                this.paymentEventResultField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField paymentEventType {
            get {
                return this.paymentEventTypeField;
            }
            set {
                this.paymentEventTypeField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField paymentHold {
            get {
                return this.paymentHoldField;
            }
            set {
                this.paymentHoldField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField paymentMethod {
            get {
                return this.paymentMethodField;
            }
            set {
                this.paymentMethodField = value;
            }
        }

        /// <remarks/>
        public SearchStringField paymentOption {
            get {
                return this.paymentOptionField;
            }
            set {
                this.paymentOptionField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField payPalPending {
            get {
                return this.payPalPendingField;
            }
            set {
                this.payPalPendingField = value;
            }
        }

        /// <remarks/>
        public SearchStringField payPalStatus {
            get {
                return this.payPalStatusField;
            }
            set {
                this.payPalStatusField = value;
            }
        }

        /// <remarks/>
        public SearchStringField payPalTranId {
            get {
                return this.payPalTranIdField;
            }
            set {
                this.payPalTranIdField = value;
            }
        }

        /// <remarks/>
        public SearchStringField pnRefNum {
            get {
                return this.pnRefNumField;
            }
            set {
                this.pnRefNumField = value;
            }
        }

        /// <remarks/>
        public SearchStringField poAsText {
            get {
                return this.poAsTextField;
            }
            set {
                this.poAsTextField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField policyViolated {
            get {
                return this.policyViolatedField;
            }
            set {
                this.policyViolatedField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField posting {
            get {
                return this.postingField;
            }
            set {
                this.postingField = value;
            }
        }

        /// <remarks/>
        public RecordRef postingPeriod {
            get {
                return this.postingPeriodField;
            }
            set {
                this.postingPeriodField = value;
            }
        }

        /// <remarks/>
        public PostingPeriodDate postingPeriodRelative {
            get {
                return this.postingPeriodRelativeField;
            }
            set {
                this.postingPeriodRelativeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool postingPeriodRelativeSpecified {
            get {
                return this.postingPeriodRelativeFieldSpecified;
            }
            set {
                this.postingPeriodRelativeFieldSpecified = value;
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
        public SearchBooleanField printedPickingTicket {
            get {
                return this.printedPickingTicketField;
            }
            set {
                this.printedPickingTicketField = value;
            }
        }

        /// <remarks/>
        public SearchLongField probability {
            get {
                return this.probabilityField;
            }
            set {
                this.probabilityField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField projectedAmount {
            get {
                return this.projectedAmountField;
            }
            set {
                this.projectedAmountField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField projectTask {
            get {
                return this.projectTaskField;
            }
            set {
                this.projectTaskField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField promoCode {
            get {
                return this.promoCodeField;
            }
            set {
                this.promoCodeField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField purchaseOrder {
            get {
                return this.purchaseOrderField;
            }
            set {
                this.purchaseOrderField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField quantityBilled {
            get {
                return this.quantityBilledField;
            }
            set {
                this.quantityBilledField = value;
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
        public SearchDoubleField quantityPacked {
            get {
                return this.quantityPackedField;
            }
            set {
                this.quantityPackedField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField quantityPicked {
            get {
                return this.quantityPickedField;
            }
            set {
                this.quantityPickedField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField quantityRevCommitted {
            get {
                return this.quantityRevCommittedField;
            }
            set {
                this.quantityRevCommittedField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField quantityShipRecv {
            get {
                return this.quantityShipRecvField;
            }
            set {
                this.quantityShipRecvField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField recognizedRevenue {
            get {
                return this.recognizedRevenueField;
            }
            set {
                this.recognizedRevenueField = value;
            }
        }

        /// <remarks/>
        public SearchStringField recordType {
            get {
                return this.recordTypeField;
            }
            set {
                this.recordTypeField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField recurAnnuallyTotal {
            get {
                return this.recurAnnuallyTotalField;
            }
            set {
                this.recurAnnuallyTotalField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField recurMonthlyTotal {
            get {
                return this.recurMonthlyTotalField;
            }
            set {
                this.recurMonthlyTotalField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField recurQuarterlyTotal {
            get {
                return this.recurQuarterlyTotalField;
            }
            set {
                this.recurQuarterlyTotalField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField recurringBill {
            get {
                return this.recurringBillField;
            }
            set {
                this.recurringBillField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField recurWeeklyTotal {
            get {
                return this.recurWeeklyTotalField;
            }
            set {
                this.recurWeeklyTotalField = value;
            }
        }

        /// <remarks/>
        public SearchLongField refNumber {
            get {
                return this.refNumberField;
            }
            set {
                this.refNumberField = value;
            }
        }

        /// <remarks/>
        public SearchDateField requestedDate {
            get {
                return this.requestedDateField;
            }
            set {
                this.requestedDateField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField revCommitStatus {
            get {
                return this.revCommitStatusField;
            }
            set {
                this.revCommitStatusField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField revCommittingStatus {
            get {
                return this.revCommittingStatusField;
            }
            set {
                this.revCommittingStatusField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField revCommittingTransaction {
            get {
                return this.revCommittingTransactionField;
            }
            set {
                this.revCommittingTransactionField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField revenueStatus {
            get {
                return this.revenueStatusField;
            }
            set {
                this.revenueStatusField = value;
            }
        }

        /// <remarks/>
        public SearchDateField reversalDate {
            get {
                return this.reversalDateField;
            }
            set {
                this.reversalDateField = value;
            }
        }

        /// <remarks/>
        public SearchStringField reversalNumber {
            get {
                return this.reversalNumberField;
            }
            set {
                this.reversalNumberField = value;
            }
        }

        /// <remarks/>
        public SearchDateField revRecEndDate {
            get {
                return this.revRecEndDateField;
            }
            set {
                this.revRecEndDateField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField revRecOnRevCommitment {
            get {
                return this.revRecOnRevCommitmentField;
            }
            set {
                this.revRecOnRevCommitmentField = value;
            }
        }

        /// <remarks/>
        public SearchDateField revRecStartDate {
            get {
                return this.revRecStartDateField;
            }
            set {
                this.revRecStartDateField = value;
            }
        }

        /// <remarks/>
        public SearchLongField revRecTermInMonths {
            get {
                return this.revRecTermInMonthsField;
            }
            set {
                this.revRecTermInMonthsField = value;
            }
        }

        /// <remarks/>
        public SearchDateField salesEffectiveDate {
            get {
                return this.salesEffectiveDateField;
            }
            set {
                this.salesEffectiveDateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField salesOrder {
            get {
                return this.salesOrderField;
            }
            set {
                this.salesOrderField = value;
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
        public SearchEnumMultiSelectField schedulingMethod {
            get {
                return this.schedulingMethodField;
            }
            set {
                this.schedulingMethodField = value;
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
        public SearchDoubleField serialNumberCost {
            get {
                return this.serialNumberCostField;
            }
            set {
                this.serialNumberCostField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField serialNumberCostAdjustment {
            get {
                return this.serialNumberCostAdjustmentField;
            }
            set {
                this.serialNumberCostAdjustmentField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField serialNumberQuantity {
            get {
                return this.serialNumberQuantityField;
            }
            set {
                this.serialNumberQuantityField = value;
            }
        }

        /// <remarks/>
        public SearchStringField serialNumbers {
            get {
                return this.serialNumbersField;
            }
            set {
                this.serialNumbersField = value;
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
        public SearchStringField shipAddressee {
            get {
                return this.shipAddresseeField;
            }
            set {
                this.shipAddresseeField = value;
            }
        }

        /// <remarks/>
        public SearchStringField shipAttention {
            get {
                return this.shipAttentionField;
            }
            set {
                this.shipAttentionField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField shipCarrier {
            get {
                return this.shipCarrierField;
            }
            set {
                this.shipCarrierField = value;
            }
        }

        /// <remarks/>
        public SearchStringField shipCity {
            get {
                return this.shipCityField;
            }
            set {
                this.shipCityField = value;
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
        public SearchEnumMultiSelectField shipCountry {
            get {
                return this.shipCountryField;
            }
            set {
                this.shipCountryField = value;
            }
        }

        /// <remarks/>
        public SearchStringField shipCounty {
            get {
                return this.shipCountyField;
            }
            set {
                this.shipCountyField = value;
            }
        }

        /// <remarks/>
        public SearchDateField shipDate {
            get {
                return this.shipDateField;
            }
            set {
                this.shipDateField = value;
            }
        }

        /// <remarks/>
        public SearchLongField shipGroup {
            get {
                return this.shipGroupField;
            }
            set {
                this.shipGroupField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField shipMethod {
            get {
                return this.shipMethodField;
            }
            set {
                this.shipMethodField = value;
            }
        }

        /// <remarks/>
        public SearchStringField shipPhone {
            get {
                return this.shipPhoneField;
            }
            set {
                this.shipPhoneField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField shipping {
            get {
                return this.shippingField;
            }
            set {
                this.shippingField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField shipRecvStatus {
            get {
                return this.shipRecvStatusField;
            }
            set {
                this.shipRecvStatusField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField shipRecvStatusLine {
            get {
                return this.shipRecvStatusLineField;
            }
            set {
                this.shipRecvStatusLineField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField shipState {
            get {
                return this.shipStateField;
            }
            set {
                this.shipStateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField shipTo {
            get {
                return this.shipToField;
            }
            set {
                this.shipToField = value;
            }
        }

        /// <remarks/>
        public SearchStringField shipZip {
            get {
                return this.shipZipField;
            }
            set {
                this.shipZipField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
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
        public SearchBooleanField statistical {
            get {
                return this.statisticalField;
            }
            set {
                this.statisticalField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField subscription {
            get {
                return this.subscriptionField;
            }
            set {
                this.subscriptionField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField subscriptionLine {
            get {
                return this.subscriptionLineField;
            }
            set {
                this.subscriptionLineField = value;
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
        public SearchMultiSelectField subsidiaryTaxRegNum {
            get {
                return this.subsidiaryTaxRegNumField;
            }
            set {
                this.subsidiaryTaxRegNumField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField taxItem {
            get {
                return this.taxItemField;
            }
            set {
                this.taxItemField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField taxLine {
            get {
                return this.taxLineField;
            }
            set {
                this.taxLineField = value;
            }
        }

        /// <remarks/>
        public RecordRef taxPeriod {
            get {
                return this.taxPeriodField;
            }
            set {
                this.taxPeriodField = value;
            }
        }

        /// <remarks/>
        public PostingPeriodDate taxPeriodRelative {
            get {
                return this.taxPeriodRelativeField;
            }
            set {
                this.taxPeriodRelativeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxPeriodRelativeSpecified {
            get {
                return this.taxPeriodRelativeFieldSpecified;
            }
            set {
                this.taxPeriodRelativeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public SearchDateField taxPointDate {
            get {
                return this.taxPointDateField;
            }
            set {
                this.taxPointDateField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField taxRate {
            get {
                return this.taxRateField;
            }
            set {
                this.taxRateField = value;
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
        public SearchEnumMultiSelectField termsOfSale {
            get {
                return this.termsOfSaleField;
            }
            set {
                this.termsOfSaleField = value;
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
        public SearchBooleanField toBeEmailed {
            get {
                return this.toBeEmailedField;
            }
            set {
                this.toBeEmailedField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField toBePrinted {
            get {
                return this.toBePrintedField;
            }
            set {
                this.toBePrintedField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField toSubsidiary {
            get {
                return this.toSubsidiaryField;
            }
            set {
                this.toSubsidiaryField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField totalAmount {
            get {
                return this.totalAmountField;
            }
            set {
                this.totalAmountField = value;
            }
        }

        /// <remarks/>
        public SearchStringField trackingNumbers {
            get {
                return this.trackingNumbersField;
            }
            set {
                this.trackingNumbersField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField tranCostEstimate {
            get {
                return this.tranCostEstimateField;
            }
            set {
                this.tranCostEstimateField = value;
            }
        }

        /// <remarks/>
        public SearchDateField tranDate {
            get {
                return this.tranDateField;
            }
            set {
                this.tranDateField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField tranEstGrossProfit {
            get {
                return this.tranEstGrossProfitField;
            }
            set {
                this.tranEstGrossProfitField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField tranEstGrossProfitPct {
            get {
                return this.tranEstGrossProfitPctField;
            }
            set {
                this.tranEstGrossProfitPctField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField tranFxEstGrossProfit {
            get {
                return this.tranFxEstGrossProfitField;
            }
            set {
                this.tranFxEstGrossProfitField = value;
            }
        }

        /// <remarks/>
        public SearchStringField tranId {
            get {
                return this.tranIdField;
            }
            set {
                this.tranIdField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField tranIsVsoeBundle {
            get {
                return this.tranIsVsoeBundleField;
            }
            set {
                this.tranIsVsoeBundleField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField transactionDiscount {
            get {
                return this.transactionDiscountField;
            }
            set {
                this.transactionDiscountField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField transactionLineType {
            get {
                return this.transactionLineTypeField;
            }
            set {
                this.transactionLineTypeField = value;
            }
        }

        /// <remarks/>
        public SearchStringField transactionNumber {
            get {
                return this.transactionNumberField;
            }
            set {
                this.transactionNumberField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField transferLocation {
            get {
                return this.transferLocationField;
            }
            set {
                this.transferLocationField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField transferOrderQuantityCommitted {
            get {
                return this.transferOrderQuantityCommittedField;
            }
            set {
                this.transferOrderQuantityCommittedField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField transferOrderQuantityPacked {
            get {
                return this.transferOrderQuantityPackedField;
            }
            set {
                this.transferOrderQuantityPackedField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField transferOrderQuantityPicked {
            get {
                return this.transferOrderQuantityPickedField;
            }
            set {
                this.transferOrderQuantityPickedField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField transferOrderQuantityReceived {
            get {
                return this.transferOrderQuantityReceivedField;
            }
            set {
                this.transferOrderQuantityReceivedField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField transferOrderQuantityShipped {
            get {
                return this.transferOrderQuantityShippedField;
            }
            set {
                this.transferOrderQuantityShippedField = value;
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
        public SearchMultiSelectField unit {
            get {
                return this.unitField;
            }
            set {
                this.unitField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField unitCostOverride {
            get {
                return this.unitCostOverrideField;
            }
            set {
                this.unitCostOverrideField = value;
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
        public SearchMultiSelectField vendType {
            get {
                return this.vendTypeField;
            }
            set {
                this.vendTypeField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField visibleToCustomer {
            get {
                return this.visibleToCustomerField;
            }
            set {
                this.visibleToCustomerField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField voided {
            get {
                return this.voidedField;
            }
            set {
                this.voidedField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField vsoeAllocation {
            get {
                return this.vsoeAllocationField;
            }
            set {
                this.vsoeAllocationField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField vsoeAmount {
            get {
                return this.vsoeAmountField;
            }
            set {
                this.vsoeAmountField = value;
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
        public SearchMultiSelectField webSite {
            get {
                return this.webSiteField;
            }
            set {
                this.webSiteField = value;
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