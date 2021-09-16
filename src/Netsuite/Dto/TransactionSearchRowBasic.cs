namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class TransactionSearchRowBasic : SearchRowBasic {

        private SearchColumnStringField[] abbrevField;

        private SearchColumnSelectField[] accountField;

        private SearchColumnEnumSelectField[] accountTypeField;

        private SearchColumnSelectField[] acctCorpCardExpField;

        private SearchColumnDateField[] actualProductionEndDateField;

        private SearchColumnDateField[] actualProductionStartDateField;

        private SearchColumnDateField[] actualShipDateField;

        private SearchColumnDoubleField[] altSalesAmountField;

        private SearchColumnDoubleField[] altSalesNetAmountField;

        private SearchColumnDoubleField[] amountField;

        private SearchColumnDoubleField[] amountPaidField;

        private SearchColumnDoubleField[] amountRemainingField;

        private SearchColumnDoubleField[] amountUnbilledField;

        private SearchColumnDoubleField[] appliedToForeignAmountField;

        private SearchColumnBooleanField[] appliedToIsFxVarianceField;

        private SearchColumnDoubleField[] appliedToLinkAmountField;

        private SearchColumnStringField[] appliedToLinkTypeField;

        private SearchColumnSelectField[] appliedToTransactionField;

        private SearchColumnDoubleField[] applyingForeignAmountField;

        private SearchColumnBooleanField[] applyingIsFxVarianceField;

        private SearchColumnDoubleField[] applyingLinkAmountField;

        private SearchColumnStringField[] applyingLinkTypeField;

        private SearchColumnSelectField[] applyingTransactionField;

        private SearchColumnEnumSelectField[] approvalStatusField;

        private SearchColumnStringField[] authCodeField;

        private SearchColumnBooleanField[] autoCalculateLagField;

        private SearchColumnEnumSelectField[] avsStreetMatchField;

        private SearchColumnEnumSelectField[] avsZipMatchField;

        private SearchColumnBooleanField[] billableField;

        private SearchColumnStringField[] billAddressField;

        private SearchColumnStringField[] billAddress1Field;

        private SearchColumnStringField[] billAddress2Field;

        private SearchColumnStringField[] billAddress3Field;

        private SearchColumnStringField[] billAddresseeField;

        private SearchColumnStringField[] billAttentionField;

        private SearchColumnStringField[] billCityField;

        private SearchColumnEnumSelectField[] billCountryField;

        private SearchColumnStringField[] billCountryCodeField;

        private SearchColumnDateField[] billedDateField;

        private SearchColumnSelectField[] billingAccountField;

        private SearchColumnDoubleField[] billingAmountField;

        private SearchColumnSelectField[] billingScheduleField;

        private SearchColumnSelectField[] billingTransactionField;

        private SearchColumnStringField[] billPhoneField;

        private SearchColumnStringField[] billStateField;

        private SearchColumnEnumSelectField[] billVarianceStatusField;

        private SearchColumnStringField[] billZipField;

        private SearchColumnStringField[] binNumberField;

        private SearchColumnDoubleField[] binNumberQuantityField;

        private SearchColumnDoubleField[] bomQuantityField;

        private SearchColumnBooleanField[] buildEntireAssemblyField;

        private SearchColumnDoubleField[] buildVarianceField;

        private SearchColumnDoubleField[] builtField;

        private SearchColumnBooleanField[] canHaveStackablePromotionsField;

        private SearchColumnStringField[] catchUpPeriodField;

        private SearchColumnStringField[] ccCustomerCodeField;

        private SearchColumnDateField[] ccExpDateField;

        private SearchColumnStringField[] ccHolderNameField;

        private SearchColumnStringField[] ccNumberField;

        private SearchColumnStringField[] ccStreetField;

        private SearchColumnStringField[] ccZipCodeField;

        private SearchColumnSelectField[] classField;

        private SearchColumnBooleanField[] clearedField;

        private SearchColumnBooleanField[] closedField;

        private SearchColumnDateField[] closeDateField;

        private SearchColumnDoubleField[] cogsAmountField;

        private SearchColumnDateField[] commissionEffectiveDateField;

        private SearchColumnEnumSelectField[] commitField;

        private SearchColumnDoubleField[] componentYieldField;

        private SearchColumnStringField[] confirmationNumberField;

        private SearchColumnDoubleField[] contributionField;

        private SearchColumnDoubleField[] contributionPrimaryField;

        private SearchColumnDoubleField[] costComponentAmountField;

        private SearchColumnStringField[] costComponentCategoryField;

        private SearchColumnStringField[] costComponentItemField;

        private SearchColumnDoubleField[] costComponentQuantityField;

        private SearchColumnDoubleField[] costComponentStandardCostField;

        private SearchColumnDoubleField[] costEstimateField;

        private SearchColumnDoubleField[] costEstimateRateField;

        private SearchColumnEnumSelectField[] costEstimateTypeField;

        private SearchColumnSelectField[] createdByField;

        private SearchColumnSelectField[] createdFromField;

        private SearchColumnDoubleField[] creditAmountField;

        private SearchColumnEnumSelectField[] cscMatchField;

        private SearchColumnSelectField[] currencyField;

        private SearchColumnSelectField[] customFormField;

        private SearchColumnBooleanField[] customGLField;

        private SearchColumnSelectField[] custTypeField;

        private SearchColumnDateField[] dateCreatedField;

        private SearchColumnLongField[] daysOpenField;

        private SearchColumnLongField[] daysOverdueField;

        private SearchColumnDoubleField[] debitAmountField;

        private SearchColumnDoubleField[] deferredRevenueField;

        private SearchColumnBooleanField[] deferRevRecField;

        private SearchColumnSelectField[] departmentField;

        private SearchColumnDateField[] depositDateField;

        private SearchColumnSelectField[] depositTransactionField;

        private SearchColumnDoubleField[] discountAmountField;

        private SearchColumnStringField[] docUnitField;

        private SearchColumnStringField[] drAccountField;

        private SearchColumnDateField[] dueDateField;

        private SearchColumnDoubleField[] effectiveRateField;

        private SearchColumnStringField[] emailField;

        private SearchColumnDateField[] endDateField;

        private SearchColumnSelectField[] entityField;

        private SearchColumnSelectField[] entityStatusField;

        private SearchColumnDoubleField[] estGrossProfitField;

        private SearchColumnDoubleField[] estGrossProfitPctField;

        private SearchColumnDoubleField[] estGrossProfitPercentField;

        private SearchColumnDoubleField[] exchangeRateField;

        private SearchColumnBooleanField[] excludeCommissionField;

        private SearchColumnBooleanField[] excludeFromRateRequestField;

        private SearchColumnDateField[] expectedCloseDateField;

        private SearchColumnDateField[] expectedReceiptDateField;

        private SearchColumnSelectField[] expenseCategoryField;

        private SearchColumnDateField[] expenseDateField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnBooleanField[] firmedField;

        private SearchColumnEnumSelectField[] forecastTypeField;

        private SearchColumnSelectField[] fulfillingTransactionField;

        private SearchColumnStringField[] fxAccountField;

        private SearchColumnDoubleField[] fxAmountField;

        private SearchColumnDoubleField[] fxCostEstimateField;

        private SearchColumnDoubleField[] fxCostEstimateRateField;

        private SearchColumnDoubleField[] fxEstGrossProfitField;

        private SearchColumnDoubleField[] fxTranCostEstimateField;

        private SearchColumnDoubleField[] fxVsoeAllocationField;

        private SearchColumnDoubleField[] fxVsoeAmountField;

        private SearchColumnDoubleField[] fxVsoePriceField;

        private SearchColumnBooleanField[] gcoAvailabelToChargeField;

        private SearchColumnBooleanField[] gcoAvailableToRefundField;

        private SearchColumnEnumSelectField[] gcoAvsStreetMatchField;

        private SearchColumnEnumSelectField[] gcoAvsZipMatchField;

        private SearchColumnLongField[] gcoBuyerAccountAgeField;

        private SearchColumnStringField[] gcoBuyerIpField;

        private SearchColumnDoubleField[] gcoChargeAmountField;

        private SearchColumnDoubleField[] gcoChargebackAmountField;

        private SearchColumnDoubleField[] gcoConfirmedChargedTotalField;

        private SearchColumnDoubleField[] gcoConfirmedRefundedTotalField;

        private SearchColumnStringField[] gcoCreditcardNumberField;

        private SearchColumnEnumSelectField[] gcoCscMatchField;

        private SearchColumnStringField[] gcoFinancialStateField;

        private SearchColumnStringField[] gcoFulfillmentStateField;

        private SearchColumnStringField[] gcoOrderIdField;

        private SearchColumnDoubleField[] gcoOrderTotalField;

        private SearchColumnDoubleField[] gcoPromotionAmountField;

        private SearchColumnStringField[] gcoPromotionNameField;

        private SearchColumnDoubleField[] gcoRefundAmountField;

        private SearchColumnDoubleField[] gcoShippingTotalField;

        private SearchColumnStringField[] gcoStateChangedDetailField;

        private SearchColumnStringField[] giftCertField;

        private SearchColumnDoubleField[] grossAmountField;

        private SearchColumnBooleanField[] includeInForecastField;

        private SearchColumnSelectField[] incotermField;

        private SearchColumnEnumSelectField[] intercoStatusField;

        private SearchColumnStringField[] intercoTransactionField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnSelectField[] inventoryLocationField;

        private SearchColumnSelectField[] inventorySubsidiaryField;

        private SearchColumnBooleanField[] inVsoeBundleField;

        private SearchColumnBooleanField[] isAllocationField;

        private SearchColumnBooleanField[] isBackflushField;

        private SearchColumnBooleanField[] isGcoChargebackField;

        private SearchColumnBooleanField[] isGcoChargeConfirmedField;

        private SearchColumnBooleanField[] isGcoPaymentGuaranteedField;

        private SearchColumnBooleanField[] isGcoRefundConfirmedField;

        private SearchColumnBooleanField[] isInsideDeliveryField;

        private SearchColumnBooleanField[] isInsidePickupField;

        private SearchColumnBooleanField[] isIntercompanyAdjustmentField;

        private SearchColumnBooleanField[] isInTransitPaymentField;

        private SearchColumnBooleanField[] isMultiShipToField;

        private SearchColumnBooleanField[] isReversalField;

        private SearchColumnBooleanField[] isRevRecTransactionField;

        private SearchColumnBooleanField[] isScrapField;

        private SearchColumnBooleanField[] isShipAddressField;

        private SearchColumnBooleanField[] isTransferPriceCostingField;

        private SearchColumnBooleanField[] isWipField;

        private SearchColumnSelectField[] itemField;

        private SearchColumnEnumSelectField[] itemFulfillmentChoiceField;

        private SearchColumnSelectField[] itemRevisionField;

        private SearchColumnBooleanField[] landedCostPerLineField;

        private SearchColumnDateField[] lastModifiedDateField;

        private SearchColumnSelectField[] leadSourceField;

        private SearchColumnLongField[] lineField;

        private SearchColumnLongField[] lineSequenceNumberField;

        private SearchColumnLongField[] lineUniqueKeyField;

        private SearchColumnSelectField[] locationField;

        private SearchColumnBooleanField[] locationAutoAssignedField;

        private SearchColumnBooleanField[] mainLineField;

        private SearchColumnStringField[] mainNameField;

        private SearchColumnSelectField[] manufacturingRoutingField;

        private SearchColumnBooleanField[] matchBillToReceiptField;

        private SearchColumnStringField[] memoField;

        private SearchColumnStringField[] memoMainField;

        private SearchColumnBooleanField[] memorizedField;

        private SearchColumnSelectField[] merchantAccountField;

        private SearchColumnStringField[] messageField;

        private SearchColumnBooleanField[] multiSubsidiaryField;

        private SearchColumnDoubleField[] netAmountField;

        private SearchColumnDoubleField[] netAmountNoTaxField;

        private SearchColumnSelectField[] nextApproverField;

        private SearchColumnDateField[] nextBillDateField;

        private SearchColumnSelectField[] nexusField;

        private SearchColumnBooleanField[] noAutoAssignLocationField;

        private SearchColumnBooleanField[] nonReimbursableField;

        private SearchColumnDoubleField[] oneTimeTotalField;

        private SearchColumnSelectField[] opportunityField;

        private SearchColumnStringField[] optionsField;

        private SearchColumnSelectField[] orderAllocationStrategyField;

        private SearchColumnDoubleField[] orderPriorityField;

        private SearchColumnEnumSelectField[] originatorField;

        private SearchColumnTextNumberField[] otherRefNumField;

        private SearchColumnSelectField[] overheadParentItemField;

        private SearchColumnBooleanField[] overrideInstallmentsField;

        private SearchColumnLongField[] packageCountField;

        private SearchColumnDoubleField[] paidAmountField;

        private SearchColumnSelectField[] paidTransactionField;

        private SearchColumnSelectField[] partnerField;

        private SearchColumnDoubleField[] partnerContributionField;

        private SearchColumnSelectField[] partnerRoleField;

        private SearchColumnSelectField[] partnerTeamMemberField;

        private SearchColumnDoubleField[] payingAmountField;

        private SearchColumnSelectField[] payingTransactionField;

        private SearchColumnBooleanField[] paymentApprovedField;

        private SearchColumnDateField[] paymentEventDateField;

        private SearchColumnEnumSelectField[] paymentEventHoldReasonField;

        private SearchColumnBooleanField[] paymentEventPurchaseCardUsedField;

        private SearchColumnBooleanField[] paymentEventPurchaseDataSentField;

        private SearchColumnEnumSelectField[] paymentEventResultField;

        private SearchColumnEnumSelectField[] paymentEventTypeField;

        private SearchColumnBooleanField[] paymentHoldField;

        private SearchColumnSelectField[] paymentMethodField;

        private SearchColumnSelectField[] paymentOptionField;

        private SearchColumnBooleanField[] payPalPendingField;

        private SearchColumnStringField[] payPalStatusField;

        private SearchColumnStringField[] payPalTranIdField;

        private SearchColumnStringField[] payrollBatchField;

        private SearchColumnStringField[] pnRefNumField;

        private SearchColumnBooleanField[] policyViolatedField;

        private SearchColumnDoubleField[] poRateField;

        private SearchColumnBooleanField[] postingField;

        private SearchColumnSelectField[] postingPeriodField;

        private SearchColumnSelectField[] priceLevelField;

        private SearchColumnStringField[] printField;

        private SearchColumnDoubleField[] probabilityField;

        private SearchColumnDoubleField[] projectedAmountField;

        private SearchColumnSelectField[] projectTaskField;

        private SearchColumnSelectField[] promoCodeField;

        private SearchColumnSelectField[] purchaseOrderField;

        private SearchColumnDoubleField[] quantityField;

        private SearchColumnDoubleField[] quantityBilledField;

        private SearchColumnDoubleField[] quantityCommittedField;

        private SearchColumnDoubleField[] quantityPackedField;

        private SearchColumnDoubleField[] quantityPickedField;

        private SearchColumnDoubleField[] quantityRevCommittedField;

        private SearchColumnDoubleField[] quantityShipRecvField;

        private SearchColumnDoubleField[] quantityUomField;

        private SearchColumnDoubleField[] rateField;

        private SearchColumnStringField[] realizedGainPostingTransactionField;

        private SearchColumnDoubleField[] recognizedRevenueField;

        private SearchColumnStringField[] recordTypeField;

        private SearchColumnDoubleField[] recurAnnuallyTotalField;

        private SearchColumnDoubleField[] recurMonthlyTotalField;

        private SearchColumnDoubleField[] recurQuarterlyTotalField;

        private SearchColumnBooleanField[] recurringBillField;

        private SearchColumnDoubleField[] recurWeeklyTotalField;

        private SearchColumnLongField[] refNumberField;

        private SearchColumnDateField[] requestedDateField;

        private SearchColumnDoubleField[] requiredDepositAmountField;

        private SearchColumnDoubleField[] requiredDepositDueField;

        private SearchColumnDoubleField[] requiredDepositPercentageField;

        private SearchColumnEnumSelectField[] revCommitStatusField;

        private SearchColumnSelectField[] revCommittingTransactionField;

        private SearchColumnEnumSelectField[] revenueStatusField;

        private SearchColumnDateField[] reversalDateField;

        private SearchColumnStringField[] reversalNumberField;

        private SearchColumnDateField[] revRecEndDateField;

        private SearchColumnBooleanField[] revRecOnRevCommitmentField;

        private SearchColumnDateField[] revRecStartDateField;

        private SearchColumnSelectField[] rgAccountField;

        private SearchColumnDoubleField[] rgAmountField;

        private SearchColumnDateField[] salesEffectiveDateField;

        private SearchColumnSelectField[] salesOrderField;

        private SearchColumnSelectField[] salesRepField;

        private SearchColumnSelectField[] salesTeamMemberField;

        private SearchColumnSelectField[] salesTeamRoleField;

        private SearchColumnEnumSelectField[] schedulingMethodField;

        private SearchColumnStringField[] serialNumberField;

        private SearchColumnDoubleField[] serialNumberCostField;

        private SearchColumnDoubleField[] serialNumberCostAdjustmentField;

        private SearchColumnDoubleField[] serialNumberQuantityField;

        private SearchColumnStringField[] serialNumbersField;

        private SearchColumnStringField[] shipAddressField;

        private SearchColumnStringField[] shipAddress1Field;

        private SearchColumnStringField[] shipAddress2Field;

        private SearchColumnStringField[] shipAddress3Field;

        private SearchColumnStringField[] shipAddresseeField;

        private SearchColumnStringField[] shipAttentionField;

        private SearchColumnEnumSelectField[] shipCarrierField;

        private SearchColumnStringField[] shipCityField;

        private SearchColumnBooleanField[] shipCompleteField;

        private SearchColumnEnumSelectField[] shipCountryField;

        private SearchColumnStringField[] shipCountryCodeField;

        private SearchColumnDateField[] shipDateField;

        private SearchColumnLongField[] shipGroupField;

        private SearchColumnSelectField[] shipMethodField;

        private SearchColumnStringField[] shipPhoneField;

        private SearchColumnDoubleField[] shippingAmountField;

        private SearchColumnBooleanField[] shipRecvStatusLineField;

        private SearchColumnStringField[] shipStateField;

        private SearchColumnSelectField[] shipToField;

        private SearchColumnStringField[] shipZipField;

        private SearchColumnDoubleField[] signedAmountField;

        private SearchColumnStringField[] sourceField;

        private SearchColumnDateField[] startDateField;

        private SearchColumnEnumSelectField[] statusField;

        private SearchColumnSelectField[] subscriptionField;

        private SearchColumnSelectField[] subscriptionLineField;

        private SearchColumnSelectField[] subsidiaryField;

        private SearchColumnStringField[] subsidiaryTaxRegNumField;

        private SearchColumnDoubleField[] taxAmountField;

        private SearchColumnSelectField[] taxCodeField;

        private SearchColumnBooleanField[] taxLineField;

        private SearchColumnSelectField[] taxPeriodField;

        private SearchColumnDateField[] taxPointDateField;

        private SearchColumnDoubleField[] taxTotalField;

        private SearchColumnLongField[] termInMonthsField;

        private SearchColumnSelectField[] termsField;

        private SearchColumnStringField[] termsOfSaleField;

        private SearchColumnStringField[] titleField;

        private SearchColumnBooleanField[] toBeEmailedField;

        private SearchColumnBooleanField[] toBePrintedField;

        private SearchColumnSelectField[] toSubsidiaryField;

        private SearchColumnDoubleField[] totalField;

        private SearchColumnDoubleField[] totalCostEstimateField;

        private SearchColumnStringField[] trackingNumbersField;

        private SearchColumnDateField[] tranDateField;

        private SearchColumnDoubleField[] tranEstGrossProfitField;

        private SearchColumnDoubleField[] tranFxEstGrossProfitField;

        private SearchColumnStringField[] tranIdField;

        private SearchColumnBooleanField[] tranIsVsoeBundleField;

        private SearchColumnBooleanField[] transactionDiscountField;

        private SearchColumnEnumSelectField[] transactionLineTypeField;

        private SearchColumnStringField[] transactionNumberField;

        private SearchColumnSelectField[] transferLocationField;

        private SearchColumnStringField[] transferOrderItemLineField;

        private SearchColumnDoubleField[] transferOrderQuantityCommittedField;

        private SearchColumnDoubleField[] transferOrderQuantityPackedField;

        private SearchColumnDoubleField[] transferOrderQuantityPickedField;

        private SearchColumnDoubleField[] transferOrderQuantityReceivedField;

        private SearchColumnDoubleField[] transferOrderQuantityShippedField;

        private SearchColumnEnumSelectField[] typeField;

        private SearchColumnStringField[] unitField;

        private SearchColumnDoubleField[] unitCostOverrideField;

        private SearchColumnSelectField[] vendTypeField;

        private SearchColumnBooleanField[] visibleToCustomerField;

        private SearchColumnDoubleField[] vsoeAllocationField;

        private SearchColumnDoubleField[] vsoeAmountField;

        private SearchColumnEnumSelectField[] vsoeDeferralField;

        private SearchColumnBooleanField[] vsoeDeliveredField;

        private SearchColumnEnumSelectField[] vsoePermitDiscountField;

        private SearchColumnDoubleField[] vsoePriceField;

        private SearchColumnStringField[] webSiteField;

        private SearchColumnCustomField[] customFieldListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("abbrev")]
        public SearchColumnStringField[] abbrev {
            get {
                return this.abbrevField;
            }
            set {
                this.abbrevField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("account")]
        public SearchColumnSelectField[] account {
            get {
                return this.accountField;
            }
            set {
                this.accountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("accountType")]
        public SearchColumnEnumSelectField[] accountType {
            get {
                return this.accountTypeField;
            }
            set {
                this.accountTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("acctCorpCardExp")]
        public SearchColumnSelectField[] acctCorpCardExp {
            get {
                return this.acctCorpCardExpField;
            }
            set {
                this.acctCorpCardExpField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("actualProductionEndDate")]
        public SearchColumnDateField[] actualProductionEndDate {
            get {
                return this.actualProductionEndDateField;
            }
            set {
                this.actualProductionEndDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("actualProductionStartDate")]
        public SearchColumnDateField[] actualProductionStartDate {
            get {
                return this.actualProductionStartDateField;
            }
            set {
                this.actualProductionStartDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("actualShipDate")]
        public SearchColumnDateField[] actualShipDate {
            get {
                return this.actualShipDateField;
            }
            set {
                this.actualShipDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("altSalesAmount")]
        public SearchColumnDoubleField[] altSalesAmount {
            get {
                return this.altSalesAmountField;
            }
            set {
                this.altSalesAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("altSalesNetAmount")]
        public SearchColumnDoubleField[] altSalesNetAmount {
            get {
                return this.altSalesNetAmountField;
            }
            set {
                this.altSalesNetAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("amount")]
        public SearchColumnDoubleField[] amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("amountPaid")]
        public SearchColumnDoubleField[] amountPaid {
            get {
                return this.amountPaidField;
            }
            set {
                this.amountPaidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("amountRemaining")]
        public SearchColumnDoubleField[] amountRemaining {
            get {
                return this.amountRemainingField;
            }
            set {
                this.amountRemainingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("amountUnbilled")]
        public SearchColumnDoubleField[] amountUnbilled {
            get {
                return this.amountUnbilledField;
            }
            set {
                this.amountUnbilledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("appliedToForeignAmount")]
        public SearchColumnDoubleField[] appliedToForeignAmount {
            get {
                return this.appliedToForeignAmountField;
            }
            set {
                this.appliedToForeignAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("appliedToIsFxVariance")]
        public SearchColumnBooleanField[] appliedToIsFxVariance {
            get {
                return this.appliedToIsFxVarianceField;
            }
            set {
                this.appliedToIsFxVarianceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("appliedToLinkAmount")]
        public SearchColumnDoubleField[] appliedToLinkAmount {
            get {
                return this.appliedToLinkAmountField;
            }
            set {
                this.appliedToLinkAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("appliedToLinkType")]
        public SearchColumnStringField[] appliedToLinkType {
            get {
                return this.appliedToLinkTypeField;
            }
            set {
                this.appliedToLinkTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("appliedToTransaction")]
        public SearchColumnSelectField[] appliedToTransaction {
            get {
                return this.appliedToTransactionField;
            }
            set {
                this.appliedToTransactionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("applyingForeignAmount")]
        public SearchColumnDoubleField[] applyingForeignAmount {
            get {
                return this.applyingForeignAmountField;
            }
            set {
                this.applyingForeignAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("applyingIsFxVariance")]
        public SearchColumnBooleanField[] applyingIsFxVariance {
            get {
                return this.applyingIsFxVarianceField;
            }
            set {
                this.applyingIsFxVarianceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("applyingLinkAmount")]
        public SearchColumnDoubleField[] applyingLinkAmount {
            get {
                return this.applyingLinkAmountField;
            }
            set {
                this.applyingLinkAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("applyingLinkType")]
        public SearchColumnStringField[] applyingLinkType {
            get {
                return this.applyingLinkTypeField;
            }
            set {
                this.applyingLinkTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("applyingTransaction")]
        public SearchColumnSelectField[] applyingTransaction {
            get {
                return this.applyingTransactionField;
            }
            set {
                this.applyingTransactionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("approvalStatus")]
        public SearchColumnEnumSelectField[] approvalStatus {
            get {
                return this.approvalStatusField;
            }
            set {
                this.approvalStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("authCode")]
        public SearchColumnStringField[] authCode {
            get {
                return this.authCodeField;
            }
            set {
                this.authCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("autoCalculateLag")]
        public SearchColumnBooleanField[] autoCalculateLag {
            get {
                return this.autoCalculateLagField;
            }
            set {
                this.autoCalculateLagField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("avsStreetMatch")]
        public SearchColumnEnumSelectField[] avsStreetMatch {
            get {
                return this.avsStreetMatchField;
            }
            set {
                this.avsStreetMatchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("avsZipMatch")]
        public SearchColumnEnumSelectField[] avsZipMatch {
            get {
                return this.avsZipMatchField;
            }
            set {
                this.avsZipMatchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billable")]
        public SearchColumnBooleanField[] billable {
            get {
                return this.billableField;
            }
            set {
                this.billableField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("billedDate")]
        public SearchColumnDateField[] billedDate {
            get {
                return this.billedDateField;
            }
            set {
                this.billedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billingAccount")]
        public SearchColumnSelectField[] billingAccount {
            get {
                return this.billingAccountField;
            }
            set {
                this.billingAccountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billingAmount")]
        public SearchColumnDoubleField[] billingAmount {
            get {
                return this.billingAmountField;
            }
            set {
                this.billingAmountField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("billingTransaction")]
        public SearchColumnSelectField[] billingTransaction {
            get {
                return this.billingTransactionField;
            }
            set {
                this.billingTransactionField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("billVarianceStatus")]
        public SearchColumnEnumSelectField[] billVarianceStatus {
            get {
                return this.billVarianceStatusField;
            }
            set {
                this.billVarianceStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billZip")]
        public SearchColumnStringField[] billZip {
            get {
                return this.billZipField;
            }
            set {
                this.billZipField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("binNumberQuantity")]
        public SearchColumnDoubleField[] binNumberQuantity {
            get {
                return this.binNumberQuantityField;
            }
            set {
                this.binNumberQuantityField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("buildVariance")]
        public SearchColumnDoubleField[] buildVariance {
            get {
                return this.buildVarianceField;
            }
            set {
                this.buildVarianceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("built")]
        public SearchColumnDoubleField[] built {
            get {
                return this.builtField;
            }
            set {
                this.builtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("canHaveStackablePromotions")]
        public SearchColumnBooleanField[] canHaveStackablePromotions {
            get {
                return this.canHaveStackablePromotionsField;
            }
            set {
                this.canHaveStackablePromotionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("catchUpPeriod")]
        public SearchColumnStringField[] catchUpPeriod {
            get {
                return this.catchUpPeriodField;
            }
            set {
                this.catchUpPeriodField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("ccStreet")]
        public SearchColumnStringField[] ccStreet {
            get {
                return this.ccStreetField;
            }
            set {
                this.ccStreetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ccZipCode")]
        public SearchColumnStringField[] ccZipCode {
            get {
                return this.ccZipCodeField;
            }
            set {
                this.ccZipCodeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("cleared")]
        public SearchColumnBooleanField[] cleared {
            get {
                return this.clearedField;
            }
            set {
                this.clearedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("closed")]
        public SearchColumnBooleanField[] closed {
            get {
                return this.closedField;
            }
            set {
                this.closedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("closeDate")]
        public SearchColumnDateField[] closeDate {
            get {
                return this.closeDateField;
            }
            set {
                this.closeDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cogsAmount")]
        public SearchColumnDoubleField[] cogsAmount {
            get {
                return this.cogsAmountField;
            }
            set {
                this.cogsAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("commissionEffectiveDate")]
        public SearchColumnDateField[] commissionEffectiveDate {
            get {
                return this.commissionEffectiveDateField;
            }
            set {
                this.commissionEffectiveDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("commit")]
        public SearchColumnEnumSelectField[] commit {
            get {
                return this.commitField;
            }
            set {
                this.commitField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("confirmationNumber")]
        public SearchColumnStringField[] confirmationNumber {
            get {
                return this.confirmationNumberField;
            }
            set {
                this.confirmationNumberField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("costComponentAmount")]
        public SearchColumnDoubleField[] costComponentAmount {
            get {
                return this.costComponentAmountField;
            }
            set {
                this.costComponentAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("costComponentCategory")]
        public SearchColumnStringField[] costComponentCategory {
            get {
                return this.costComponentCategoryField;
            }
            set {
                this.costComponentCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("costComponentItem")]
        public SearchColumnStringField[] costComponentItem {
            get {
                return this.costComponentItemField;
            }
            set {
                this.costComponentItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("costComponentQuantity")]
        public SearchColumnDoubleField[] costComponentQuantity {
            get {
                return this.costComponentQuantityField;
            }
            set {
                this.costComponentQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("costComponentStandardCost")]
        public SearchColumnDoubleField[] costComponentStandardCost {
            get {
                return this.costComponentStandardCostField;
            }
            set {
                this.costComponentStandardCostField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("costEstimateRate")]
        public SearchColumnDoubleField[] costEstimateRate {
            get {
                return this.costEstimateRateField;
            }
            set {
                this.costEstimateRateField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("createdBy")]
        public SearchColumnSelectField[] createdBy {
            get {
                return this.createdByField;
            }
            set {
                this.createdByField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("createdFrom")]
        public SearchColumnSelectField[] createdFrom {
            get {
                return this.createdFromField;
            }
            set {
                this.createdFromField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("creditAmount")]
        public SearchColumnDoubleField[] creditAmount {
            get {
                return this.creditAmountField;
            }
            set {
                this.creditAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cscMatch")]
        public SearchColumnEnumSelectField[] cscMatch {
            get {
                return this.cscMatchField;
            }
            set {
                this.cscMatchField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("customForm")]
        public SearchColumnSelectField[] customForm {
            get {
                return this.customFormField;
            }
            set {
                this.customFormField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("customGL")]
        public SearchColumnBooleanField[] customGL {
            get {
                return this.customGLField;
            }
            set {
                this.customGLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("custType")]
        public SearchColumnSelectField[] custType {
            get {
                return this.custTypeField;
            }
            set {
                this.custTypeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("daysOpen")]
        public SearchColumnLongField[] daysOpen {
            get {
                return this.daysOpenField;
            }
            set {
                this.daysOpenField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("debitAmount")]
        public SearchColumnDoubleField[] debitAmount {
            get {
                return this.debitAmountField;
            }
            set {
                this.debitAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("deferredRevenue")]
        public SearchColumnDoubleField[] deferredRevenue {
            get {
                return this.deferredRevenueField;
            }
            set {
                this.deferredRevenueField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("depositDate")]
        public SearchColumnDateField[] depositDate {
            get {
                return this.depositDateField;
            }
            set {
                this.depositDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("depositTransaction")]
        public SearchColumnSelectField[] depositTransaction {
            get {
                return this.depositTransactionField;
            }
            set {
                this.depositTransactionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("discountAmount")]
        public SearchColumnDoubleField[] discountAmount {
            get {
                return this.discountAmountField;
            }
            set {
                this.discountAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("docUnit")]
        public SearchColumnStringField[] docUnit {
            get {
                return this.docUnitField;
            }
            set {
                this.docUnitField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("dueDate")]
        public SearchColumnDateField[] dueDate {
            get {
                return this.dueDateField;
            }
            set {
                this.dueDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("effectiveRate")]
        public SearchColumnDoubleField[] effectiveRate {
            get {
                return this.effectiveRateField;
            }
            set {
                this.effectiveRateField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("entity")]
        public SearchColumnSelectField[] entity {
            get {
                return this.entityField;
            }
            set {
                this.entityField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("estGrossProfit")]
        public SearchColumnDoubleField[] estGrossProfit {
            get {
                return this.estGrossProfitField;
            }
            set {
                this.estGrossProfitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("estGrossProfitPct")]
        public SearchColumnDoubleField[] estGrossProfitPct {
            get {
                return this.estGrossProfitPctField;
            }
            set {
                this.estGrossProfitPctField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("estGrossProfitPercent")]
        public SearchColumnDoubleField[] estGrossProfitPercent {
            get {
                return this.estGrossProfitPercentField;
            }
            set {
                this.estGrossProfitPercentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("exchangeRate")]
        public SearchColumnDoubleField[] exchangeRate {
            get {
                return this.exchangeRateField;
            }
            set {
                this.exchangeRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("excludeCommission")]
        public SearchColumnBooleanField[] excludeCommission {
            get {
                return this.excludeCommissionField;
            }
            set {
                this.excludeCommissionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("excludeFromRateRequest")]
        public SearchColumnBooleanField[] excludeFromRateRequest {
            get {
                return this.excludeFromRateRequestField;
            }
            set {
                this.excludeFromRateRequestField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("expectedCloseDate")]
        public SearchColumnDateField[] expectedCloseDate {
            get {
                return this.expectedCloseDateField;
            }
            set {
                this.expectedCloseDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("expectedReceiptDate")]
        public SearchColumnDateField[] expectedReceiptDate {
            get {
                return this.expectedReceiptDateField;
            }
            set {
                this.expectedReceiptDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("expenseCategory")]
        public SearchColumnSelectField[] expenseCategory {
            get {
                return this.expenseCategoryField;
            }
            set {
                this.expenseCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("expenseDate")]
        public SearchColumnDateField[] expenseDate {
            get {
                return this.expenseDateField;
            }
            set {
                this.expenseDateField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("firmed")]
        public SearchColumnBooleanField[] firmed {
            get {
                return this.firmedField;
            }
            set {
                this.firmedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("forecastType")]
        public SearchColumnEnumSelectField[] forecastType {
            get {
                return this.forecastTypeField;
            }
            set {
                this.forecastTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fulfillingTransaction")]
        public SearchColumnSelectField[] fulfillingTransaction {
            get {
                return this.fulfillingTransactionField;
            }
            set {
                this.fulfillingTransactionField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("fxAmount")]
        public SearchColumnDoubleField[] fxAmount {
            get {
                return this.fxAmountField;
            }
            set {
                this.fxAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fxCostEstimate")]
        public SearchColumnDoubleField[] fxCostEstimate {
            get {
                return this.fxCostEstimateField;
            }
            set {
                this.fxCostEstimateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fxCostEstimateRate")]
        public SearchColumnDoubleField[] fxCostEstimateRate {
            get {
                return this.fxCostEstimateRateField;
            }
            set {
                this.fxCostEstimateRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fxEstGrossProfit")]
        public SearchColumnDoubleField[] fxEstGrossProfit {
            get {
                return this.fxEstGrossProfitField;
            }
            set {
                this.fxEstGrossProfitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fxTranCostEstimate")]
        public SearchColumnDoubleField[] fxTranCostEstimate {
            get {
                return this.fxTranCostEstimateField;
            }
            set {
                this.fxTranCostEstimateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fxVsoeAllocation")]
        public SearchColumnDoubleField[] fxVsoeAllocation {
            get {
                return this.fxVsoeAllocationField;
            }
            set {
                this.fxVsoeAllocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fxVsoeAmount")]
        public SearchColumnDoubleField[] fxVsoeAmount {
            get {
                return this.fxVsoeAmountField;
            }
            set {
                this.fxVsoeAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fxVsoePrice")]
        public SearchColumnDoubleField[] fxVsoePrice {
            get {
                return this.fxVsoePriceField;
            }
            set {
                this.fxVsoePriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("gcoAvailabelToCharge")]
        public SearchColumnBooleanField[] gcoAvailabelToCharge {
            get {
                return this.gcoAvailabelToChargeField;
            }
            set {
                this.gcoAvailabelToChargeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("gcoAvailableToRefund")]
        public SearchColumnBooleanField[] gcoAvailableToRefund {
            get {
                return this.gcoAvailableToRefundField;
            }
            set {
                this.gcoAvailableToRefundField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("gcoAvsStreetMatch")]
        public SearchColumnEnumSelectField[] gcoAvsStreetMatch {
            get {
                return this.gcoAvsStreetMatchField;
            }
            set {
                this.gcoAvsStreetMatchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("gcoAvsZipMatch")]
        public SearchColumnEnumSelectField[] gcoAvsZipMatch {
            get {
                return this.gcoAvsZipMatchField;
            }
            set {
                this.gcoAvsZipMatchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("gcoBuyerAccountAge")]
        public SearchColumnLongField[] gcoBuyerAccountAge {
            get {
                return this.gcoBuyerAccountAgeField;
            }
            set {
                this.gcoBuyerAccountAgeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("gcoBuyerIp")]
        public SearchColumnStringField[] gcoBuyerIp {
            get {
                return this.gcoBuyerIpField;
            }
            set {
                this.gcoBuyerIpField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("gcoChargeAmount")]
        public SearchColumnDoubleField[] gcoChargeAmount {
            get {
                return this.gcoChargeAmountField;
            }
            set {
                this.gcoChargeAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("gcoChargebackAmount")]
        public SearchColumnDoubleField[] gcoChargebackAmount {
            get {
                return this.gcoChargebackAmountField;
            }
            set {
                this.gcoChargebackAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("gcoConfirmedChargedTotal")]
        public SearchColumnDoubleField[] gcoConfirmedChargedTotal {
            get {
                return this.gcoConfirmedChargedTotalField;
            }
            set {
                this.gcoConfirmedChargedTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("gcoConfirmedRefundedTotal")]
        public SearchColumnDoubleField[] gcoConfirmedRefundedTotal {
            get {
                return this.gcoConfirmedRefundedTotalField;
            }
            set {
                this.gcoConfirmedRefundedTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("gcoCreditcardNumber")]
        public SearchColumnStringField[] gcoCreditcardNumber {
            get {
                return this.gcoCreditcardNumberField;
            }
            set {
                this.gcoCreditcardNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("gcoCscMatch")]
        public SearchColumnEnumSelectField[] gcoCscMatch {
            get {
                return this.gcoCscMatchField;
            }
            set {
                this.gcoCscMatchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("gcoFinancialState")]
        public SearchColumnStringField[] gcoFinancialState {
            get {
                return this.gcoFinancialStateField;
            }
            set {
                this.gcoFinancialStateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("gcoFulfillmentState")]
        public SearchColumnStringField[] gcoFulfillmentState {
            get {
                return this.gcoFulfillmentStateField;
            }
            set {
                this.gcoFulfillmentStateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("gcoOrderId")]
        public SearchColumnStringField[] gcoOrderId {
            get {
                return this.gcoOrderIdField;
            }
            set {
                this.gcoOrderIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("gcoOrderTotal")]
        public SearchColumnDoubleField[] gcoOrderTotal {
            get {
                return this.gcoOrderTotalField;
            }
            set {
                this.gcoOrderTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("gcoPromotionAmount")]
        public SearchColumnDoubleField[] gcoPromotionAmount {
            get {
                return this.gcoPromotionAmountField;
            }
            set {
                this.gcoPromotionAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("gcoPromotionName")]
        public SearchColumnStringField[] gcoPromotionName {
            get {
                return this.gcoPromotionNameField;
            }
            set {
                this.gcoPromotionNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("gcoRefundAmount")]
        public SearchColumnDoubleField[] gcoRefundAmount {
            get {
                return this.gcoRefundAmountField;
            }
            set {
                this.gcoRefundAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("gcoShippingTotal")]
        public SearchColumnDoubleField[] gcoShippingTotal {
            get {
                return this.gcoShippingTotalField;
            }
            set {
                this.gcoShippingTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("gcoStateChangedDetail")]
        public SearchColumnStringField[] gcoStateChangedDetail {
            get {
                return this.gcoStateChangedDetailField;
            }
            set {
                this.gcoStateChangedDetailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("giftCert")]
        public SearchColumnStringField[] giftCert {
            get {
                return this.giftCertField;
            }
            set {
                this.giftCertField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("grossAmount")]
        public SearchColumnDoubleField[] grossAmount {
            get {
                return this.grossAmountField;
            }
            set {
                this.grossAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("includeInForecast")]
        public SearchColumnBooleanField[] includeInForecast {
            get {
                return this.includeInForecastField;
            }
            set {
                this.includeInForecastField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("incoterm")]
        public SearchColumnSelectField[] incoterm {
            get {
                return this.incotermField;
            }
            set {
                this.incotermField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("intercoStatus")]
        public SearchColumnEnumSelectField[] intercoStatus {
            get {
                return this.intercoStatusField;
            }
            set {
                this.intercoStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("intercoTransaction")]
        public SearchColumnStringField[] intercoTransaction {
            get {
                return this.intercoTransactionField;
            }
            set {
                this.intercoTransactionField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("inventorySubsidiary")]
        public SearchColumnSelectField[] inventorySubsidiary {
            get {
                return this.inventorySubsidiaryField;
            }
            set {
                this.inventorySubsidiaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("inVsoeBundle")]
        public SearchColumnBooleanField[] inVsoeBundle {
            get {
                return this.inVsoeBundleField;
            }
            set {
                this.inVsoeBundleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isAllocation")]
        public SearchColumnBooleanField[] isAllocation {
            get {
                return this.isAllocationField;
            }
            set {
                this.isAllocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isBackflush")]
        public SearchColumnBooleanField[] isBackflush {
            get {
                return this.isBackflushField;
            }
            set {
                this.isBackflushField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isGcoChargeback")]
        public SearchColumnBooleanField[] isGcoChargeback {
            get {
                return this.isGcoChargebackField;
            }
            set {
                this.isGcoChargebackField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isGcoChargeConfirmed")]
        public SearchColumnBooleanField[] isGcoChargeConfirmed {
            get {
                return this.isGcoChargeConfirmedField;
            }
            set {
                this.isGcoChargeConfirmedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isGcoPaymentGuaranteed")]
        public SearchColumnBooleanField[] isGcoPaymentGuaranteed {
            get {
                return this.isGcoPaymentGuaranteedField;
            }
            set {
                this.isGcoPaymentGuaranteedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isGcoRefundConfirmed")]
        public SearchColumnBooleanField[] isGcoRefundConfirmed {
            get {
                return this.isGcoRefundConfirmedField;
            }
            set {
                this.isGcoRefundConfirmedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isInsideDelivery")]
        public SearchColumnBooleanField[] isInsideDelivery {
            get {
                return this.isInsideDeliveryField;
            }
            set {
                this.isInsideDeliveryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isInsidePickup")]
        public SearchColumnBooleanField[] isInsidePickup {
            get {
                return this.isInsidePickupField;
            }
            set {
                this.isInsidePickupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isIntercompanyAdjustment")]
        public SearchColumnBooleanField[] isIntercompanyAdjustment {
            get {
                return this.isIntercompanyAdjustmentField;
            }
            set {
                this.isIntercompanyAdjustmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isInTransitPayment")]
        public SearchColumnBooleanField[] isInTransitPayment {
            get {
                return this.isInTransitPaymentField;
            }
            set {
                this.isInTransitPaymentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isMultiShipTo")]
        public SearchColumnBooleanField[] isMultiShipTo {
            get {
                return this.isMultiShipToField;
            }
            set {
                this.isMultiShipToField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isReversal")]
        public SearchColumnBooleanField[] isReversal {
            get {
                return this.isReversalField;
            }
            set {
                this.isReversalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isRevRecTransaction")]
        public SearchColumnBooleanField[] isRevRecTransaction {
            get {
                return this.isRevRecTransactionField;
            }
            set {
                this.isRevRecTransactionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isScrap")]
        public SearchColumnBooleanField[] isScrap {
            get {
                return this.isScrapField;
            }
            set {
                this.isScrapField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("isTransferPriceCosting")]
        public SearchColumnBooleanField[] isTransferPriceCosting {
            get {
                return this.isTransferPriceCostingField;
            }
            set {
                this.isTransferPriceCostingField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("item")]
        public SearchColumnSelectField[] item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("itemFulfillmentChoice")]
        public SearchColumnEnumSelectField[] itemFulfillmentChoice {
            get {
                return this.itemFulfillmentChoiceField;
            }
            set {
                this.itemFulfillmentChoiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("itemRevision")]
        public SearchColumnSelectField[] itemRevision {
            get {
                return this.itemRevisionField;
            }
            set {
                this.itemRevisionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("landedCostPerLine")]
        public SearchColumnBooleanField[] landedCostPerLine {
            get {
                return this.landedCostPerLineField;
            }
            set {
                this.landedCostPerLineField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("line")]
        public SearchColumnLongField[] line {
            get {
                return this.lineField;
            }
            set {
                this.lineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lineSequenceNumber")]
        public SearchColumnLongField[] lineSequenceNumber {
            get {
                return this.lineSequenceNumberField;
            }
            set {
                this.lineSequenceNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lineUniqueKey")]
        public SearchColumnLongField[] lineUniqueKey {
            get {
                return this.lineUniqueKeyField;
            }
            set {
                this.lineUniqueKeyField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("locationAutoAssigned")]
        public SearchColumnBooleanField[] locationAutoAssigned {
            get {
                return this.locationAutoAssignedField;
            }
            set {
                this.locationAutoAssignedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mainLine")]
        public SearchColumnBooleanField[] mainLine {
            get {
                return this.mainLineField;
            }
            set {
                this.mainLineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mainName")]
        public SearchColumnStringField[] mainName {
            get {
                return this.mainNameField;
            }
            set {
                this.mainNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("manufacturingRouting")]
        public SearchColumnSelectField[] manufacturingRouting {
            get {
                return this.manufacturingRoutingField;
            }
            set {
                this.manufacturingRoutingField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("memo")]
        public SearchColumnStringField[] memo {
            get {
                return this.memoField;
            }
            set {
                this.memoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("memoMain")]
        public SearchColumnStringField[] memoMain {
            get {
                return this.memoMainField;
            }
            set {
                this.memoMainField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("memorized")]
        public SearchColumnBooleanField[] memorized {
            get {
                return this.memorizedField;
            }
            set {
                this.memorizedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("merchantAccount")]
        public SearchColumnSelectField[] merchantAccount {
            get {
                return this.merchantAccountField;
            }
            set {
                this.merchantAccountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("message")]
        public SearchColumnStringField[] message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("multiSubsidiary")]
        public SearchColumnBooleanField[] multiSubsidiary {
            get {
                return this.multiSubsidiaryField;
            }
            set {
                this.multiSubsidiaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("netAmount")]
        public SearchColumnDoubleField[] netAmount {
            get {
                return this.netAmountField;
            }
            set {
                this.netAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("netAmountNoTax")]
        public SearchColumnDoubleField[] netAmountNoTax {
            get {
                return this.netAmountNoTaxField;
            }
            set {
                this.netAmountNoTaxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("nextApprover")]
        public SearchColumnSelectField[] nextApprover {
            get {
                return this.nextApproverField;
            }
            set {
                this.nextApproverField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("nextBillDate")]
        public SearchColumnDateField[] nextBillDate {
            get {
                return this.nextBillDateField;
            }
            set {
                this.nextBillDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("nexus")]
        public SearchColumnSelectField[] nexus {
            get {
                return this.nexusField;
            }
            set {
                this.nexusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("noAutoAssignLocation")]
        public SearchColumnBooleanField[] noAutoAssignLocation {
            get {
                return this.noAutoAssignLocationField;
            }
            set {
                this.noAutoAssignLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("nonReimbursable")]
        public SearchColumnBooleanField[] nonReimbursable {
            get {
                return this.nonReimbursableField;
            }
            set {
                this.nonReimbursableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("oneTimeTotal")]
        public SearchColumnDoubleField[] oneTimeTotal {
            get {
                return this.oneTimeTotalField;
            }
            set {
                this.oneTimeTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("opportunity")]
        public SearchColumnSelectField[] opportunity {
            get {
                return this.opportunityField;
            }
            set {
                this.opportunityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("options")]
        public SearchColumnStringField[] options {
            get {
                return this.optionsField;
            }
            set {
                this.optionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("orderAllocationStrategy")]
        public SearchColumnSelectField[] orderAllocationStrategy {
            get {
                return this.orderAllocationStrategyField;
            }
            set {
                this.orderAllocationStrategyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("orderPriority")]
        public SearchColumnDoubleField[] orderPriority {
            get {
                return this.orderPriorityField;
            }
            set {
                this.orderPriorityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("originator")]
        public SearchColumnEnumSelectField[] originator {
            get {
                return this.originatorField;
            }
            set {
                this.originatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("otherRefNum")]
        public SearchColumnTextNumberField[] otherRefNum {
            get {
                return this.otherRefNumField;
            }
            set {
                this.otherRefNumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("overheadParentItem")]
        public SearchColumnSelectField[] overheadParentItem {
            get {
                return this.overheadParentItemField;
            }
            set {
                this.overheadParentItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("overrideInstallments")]
        public SearchColumnBooleanField[] overrideInstallments {
            get {
                return this.overrideInstallmentsField;
            }
            set {
                this.overrideInstallmentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("packageCount")]
        public SearchColumnLongField[] packageCount {
            get {
                return this.packageCountField;
            }
            set {
                this.packageCountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("paidAmount")]
        public SearchColumnDoubleField[] paidAmount {
            get {
                return this.paidAmountField;
            }
            set {
                this.paidAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("paidTransaction")]
        public SearchColumnSelectField[] paidTransaction {
            get {
                return this.paidTransactionField;
            }
            set {
                this.paidTransactionField = value;
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
        public SearchColumnSelectField[] partnerRole {
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
        [System.Xml.Serialization.XmlElementAttribute("payingAmount")]
        public SearchColumnDoubleField[] payingAmount {
            get {
                return this.payingAmountField;
            }
            set {
                this.payingAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("payingTransaction")]
        public SearchColumnSelectField[] payingTransaction {
            get {
                return this.payingTransactionField;
            }
            set {
                this.payingTransactionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("paymentApproved")]
        public SearchColumnBooleanField[] paymentApproved {
            get {
                return this.paymentApprovedField;
            }
            set {
                this.paymentApprovedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("paymentEventDate")]
        public SearchColumnDateField[] paymentEventDate {
            get {
                return this.paymentEventDateField;
            }
            set {
                this.paymentEventDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("paymentEventHoldReason")]
        public SearchColumnEnumSelectField[] paymentEventHoldReason {
            get {
                return this.paymentEventHoldReasonField;
            }
            set {
                this.paymentEventHoldReasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("paymentEventPurchaseCardUsed")]
        public SearchColumnBooleanField[] paymentEventPurchaseCardUsed {
            get {
                return this.paymentEventPurchaseCardUsedField;
            }
            set {
                this.paymentEventPurchaseCardUsedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("paymentEventPurchaseDataSent")]
        public SearchColumnBooleanField[] paymentEventPurchaseDataSent {
            get {
                return this.paymentEventPurchaseDataSentField;
            }
            set {
                this.paymentEventPurchaseDataSentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("paymentEventResult")]
        public SearchColumnEnumSelectField[] paymentEventResult {
            get {
                return this.paymentEventResultField;
            }
            set {
                this.paymentEventResultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("paymentEventType")]
        public SearchColumnEnumSelectField[] paymentEventType {
            get {
                return this.paymentEventTypeField;
            }
            set {
                this.paymentEventTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("paymentHold")]
        public SearchColumnBooleanField[] paymentHold {
            get {
                return this.paymentHoldField;
            }
            set {
                this.paymentHoldField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("paymentMethod")]
        public SearchColumnSelectField[] paymentMethod {
            get {
                return this.paymentMethodField;
            }
            set {
                this.paymentMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("paymentOption")]
        public SearchColumnSelectField[] paymentOption {
            get {
                return this.paymentOptionField;
            }
            set {
                this.paymentOptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("payPalPending")]
        public SearchColumnBooleanField[] payPalPending {
            get {
                return this.payPalPendingField;
            }
            set {
                this.payPalPendingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("payPalStatus")]
        public SearchColumnStringField[] payPalStatus {
            get {
                return this.payPalStatusField;
            }
            set {
                this.payPalStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("payPalTranId")]
        public SearchColumnStringField[] payPalTranId {
            get {
                return this.payPalTranIdField;
            }
            set {
                this.payPalTranIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("payrollBatch")]
        public SearchColumnStringField[] payrollBatch {
            get {
                return this.payrollBatchField;
            }
            set {
                this.payrollBatchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pnRefNum")]
        public SearchColumnStringField[] pnRefNum {
            get {
                return this.pnRefNumField;
            }
            set {
                this.pnRefNumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("policyViolated")]
        public SearchColumnBooleanField[] policyViolated {
            get {
                return this.policyViolatedField;
            }
            set {
                this.policyViolatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("poRate")]
        public SearchColumnDoubleField[] poRate {
            get {
                return this.poRateField;
            }
            set {
                this.poRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("posting")]
        public SearchColumnBooleanField[] posting {
            get {
                return this.postingField;
            }
            set {
                this.postingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("postingPeriod")]
        public SearchColumnSelectField[] postingPeriod {
            get {
                return this.postingPeriodField;
            }
            set {
                this.postingPeriodField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("print")]
        public SearchColumnStringField[] print {
            get {
                return this.printField;
            }
            set {
                this.printField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("probability")]
        public SearchColumnDoubleField[] probability {
            get {
                return this.probabilityField;
            }
            set {
                this.probabilityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("projectedAmount")]
        public SearchColumnDoubleField[] projectedAmount {
            get {
                return this.projectedAmountField;
            }
            set {
                this.projectedAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("projectTask")]
        public SearchColumnSelectField[] projectTask {
            get {
                return this.projectTaskField;
            }
            set {
                this.projectTaskField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("promoCode")]
        public SearchColumnSelectField[] promoCode {
            get {
                return this.promoCodeField;
            }
            set {
                this.promoCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("purchaseOrder")]
        public SearchColumnSelectField[] purchaseOrder {
            get {
                return this.purchaseOrderField;
            }
            set {
                this.purchaseOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("quantity")]
        public SearchColumnDoubleField[] quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("quantityBilled")]
        public SearchColumnDoubleField[] quantityBilled {
            get {
                return this.quantityBilledField;
            }
            set {
                this.quantityBilledField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("quantityPacked")]
        public SearchColumnDoubleField[] quantityPacked {
            get {
                return this.quantityPackedField;
            }
            set {
                this.quantityPackedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("quantityPicked")]
        public SearchColumnDoubleField[] quantityPicked {
            get {
                return this.quantityPickedField;
            }
            set {
                this.quantityPickedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("quantityRevCommitted")]
        public SearchColumnDoubleField[] quantityRevCommitted {
            get {
                return this.quantityRevCommittedField;
            }
            set {
                this.quantityRevCommittedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("quantityShipRecv")]
        public SearchColumnDoubleField[] quantityShipRecv {
            get {
                return this.quantityShipRecvField;
            }
            set {
                this.quantityShipRecvField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("quantityUom")]
        public SearchColumnDoubleField[] quantityUom {
            get {
                return this.quantityUomField;
            }
            set {
                this.quantityUomField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("rate")]
        public SearchColumnDoubleField[] rate {
            get {
                return this.rateField;
            }
            set {
                this.rateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("realizedGainPostingTransaction")]
        public SearchColumnStringField[] realizedGainPostingTransaction {
            get {
                return this.realizedGainPostingTransactionField;
            }
            set {
                this.realizedGainPostingTransactionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("recognizedRevenue")]
        public SearchColumnDoubleField[] recognizedRevenue {
            get {
                return this.recognizedRevenueField;
            }
            set {
                this.recognizedRevenueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("recordType")]
        public SearchColumnStringField[] recordType {
            get {
                return this.recordTypeField;
            }
            set {
                this.recordTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("recurAnnuallyTotal")]
        public SearchColumnDoubleField[] recurAnnuallyTotal {
            get {
                return this.recurAnnuallyTotalField;
            }
            set {
                this.recurAnnuallyTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("recurMonthlyTotal")]
        public SearchColumnDoubleField[] recurMonthlyTotal {
            get {
                return this.recurMonthlyTotalField;
            }
            set {
                this.recurMonthlyTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("recurQuarterlyTotal")]
        public SearchColumnDoubleField[] recurQuarterlyTotal {
            get {
                return this.recurQuarterlyTotalField;
            }
            set {
                this.recurQuarterlyTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("recurringBill")]
        public SearchColumnBooleanField[] recurringBill {
            get {
                return this.recurringBillField;
            }
            set {
                this.recurringBillField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("recurWeeklyTotal")]
        public SearchColumnDoubleField[] recurWeeklyTotal {
            get {
                return this.recurWeeklyTotalField;
            }
            set {
                this.recurWeeklyTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("refNumber")]
        public SearchColumnLongField[] refNumber {
            get {
                return this.refNumberField;
            }
            set {
                this.refNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("requestedDate")]
        public SearchColumnDateField[] requestedDate {
            get {
                return this.requestedDateField;
            }
            set {
                this.requestedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("requiredDepositAmount")]
        public SearchColumnDoubleField[] requiredDepositAmount {
            get {
                return this.requiredDepositAmountField;
            }
            set {
                this.requiredDepositAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("requiredDepositDue")]
        public SearchColumnDoubleField[] requiredDepositDue {
            get {
                return this.requiredDepositDueField;
            }
            set {
                this.requiredDepositDueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("requiredDepositPercentage")]
        public SearchColumnDoubleField[] requiredDepositPercentage {
            get {
                return this.requiredDepositPercentageField;
            }
            set {
                this.requiredDepositPercentageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("revCommitStatus")]
        public SearchColumnEnumSelectField[] revCommitStatus {
            get {
                return this.revCommitStatusField;
            }
            set {
                this.revCommitStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("revCommittingTransaction")]
        public SearchColumnSelectField[] revCommittingTransaction {
            get {
                return this.revCommittingTransactionField;
            }
            set {
                this.revCommittingTransactionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("revenueStatus")]
        public SearchColumnEnumSelectField[] revenueStatus {
            get {
                return this.revenueStatusField;
            }
            set {
                this.revenueStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("reversalDate")]
        public SearchColumnDateField[] reversalDate {
            get {
                return this.reversalDateField;
            }
            set {
                this.reversalDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("reversalNumber")]
        public SearchColumnStringField[] reversalNumber {
            get {
                return this.reversalNumberField;
            }
            set {
                this.reversalNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("revRecEndDate")]
        public SearchColumnDateField[] revRecEndDate {
            get {
                return this.revRecEndDateField;
            }
            set {
                this.revRecEndDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("revRecOnRevCommitment")]
        public SearchColumnBooleanField[] revRecOnRevCommitment {
            get {
                return this.revRecOnRevCommitmentField;
            }
            set {
                this.revRecOnRevCommitmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("revRecStartDate")]
        public SearchColumnDateField[] revRecStartDate {
            get {
                return this.revRecStartDateField;
            }
            set {
                this.revRecStartDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("rgAccount")]
        public SearchColumnSelectField[] rgAccount {
            get {
                return this.rgAccountField;
            }
            set {
                this.rgAccountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("rgAmount")]
        public SearchColumnDoubleField[] rgAmount {
            get {
                return this.rgAmountField;
            }
            set {
                this.rgAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("salesEffectiveDate")]
        public SearchColumnDateField[] salesEffectiveDate {
            get {
                return this.salesEffectiveDateField;
            }
            set {
                this.salesEffectiveDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("salesOrder")]
        public SearchColumnSelectField[] salesOrder {
            get {
                return this.salesOrderField;
            }
            set {
                this.salesOrderField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("serialNumberCost")]
        public SearchColumnDoubleField[] serialNumberCost {
            get {
                return this.serialNumberCostField;
            }
            set {
                this.serialNumberCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("serialNumberCostAdjustment")]
        public SearchColumnDoubleField[] serialNumberCostAdjustment {
            get {
                return this.serialNumberCostAdjustmentField;
            }
            set {
                this.serialNumberCostAdjustmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("serialNumberQuantity")]
        public SearchColumnDoubleField[] serialNumberQuantity {
            get {
                return this.serialNumberQuantityField;
            }
            set {
                this.serialNumberQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("serialNumbers")]
        public SearchColumnStringField[] serialNumbers {
            get {
                return this.serialNumbersField;
            }
            set {
                this.serialNumbersField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("shipCarrier")]
        public SearchColumnEnumSelectField[] shipCarrier {
            get {
                return this.shipCarrierField;
            }
            set {
                this.shipCarrierField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("shipDate")]
        public SearchColumnDateField[] shipDate {
            get {
                return this.shipDateField;
            }
            set {
                this.shipDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("shipGroup")]
        public SearchColumnLongField[] shipGroup {
            get {
                return this.shipGroupField;
            }
            set {
                this.shipGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("shipMethod")]
        public SearchColumnSelectField[] shipMethod {
            get {
                return this.shipMethodField;
            }
            set {
                this.shipMethodField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("shippingAmount")]
        public SearchColumnDoubleField[] shippingAmount {
            get {
                return this.shippingAmountField;
            }
            set {
                this.shippingAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("shipRecvStatusLine")]
        public SearchColumnBooleanField[] shipRecvStatusLine {
            get {
                return this.shipRecvStatusLineField;
            }
            set {
                this.shipRecvStatusLineField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("shipTo")]
        public SearchColumnSelectField[] shipTo {
            get {
                return this.shipToField;
            }
            set {
                this.shipToField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("signedAmount")]
        public SearchColumnDoubleField[] signedAmount {
            get {
                return this.signedAmountField;
            }
            set {
                this.signedAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("source")]
        public SearchColumnStringField[] source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("status")]
        public SearchColumnEnumSelectField[] status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("subscriptionLine")]
        public SearchColumnSelectField[] subscriptionLine {
            get {
                return this.subscriptionLineField;
            }
            set {
                this.subscriptionLineField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("subsidiaryTaxRegNum")]
        public SearchColumnStringField[] subsidiaryTaxRegNum {
            get {
                return this.subsidiaryTaxRegNumField;
            }
            set {
                this.subsidiaryTaxRegNumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("taxAmount")]
        public SearchColumnDoubleField[] taxAmount {
            get {
                return this.taxAmountField;
            }
            set {
                this.taxAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("taxCode")]
        public SearchColumnSelectField[] taxCode {
            get {
                return this.taxCodeField;
            }
            set {
                this.taxCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("taxLine")]
        public SearchColumnBooleanField[] taxLine {
            get {
                return this.taxLineField;
            }
            set {
                this.taxLineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("taxPeriod")]
        public SearchColumnSelectField[] taxPeriod {
            get {
                return this.taxPeriodField;
            }
            set {
                this.taxPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("taxPointDate")]
        public SearchColumnDateField[] taxPointDate {
            get {
                return this.taxPointDateField;
            }
            set {
                this.taxPointDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("taxTotal")]
        public SearchColumnDoubleField[] taxTotal {
            get {
                return this.taxTotalField;
            }
            set {
                this.taxTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("termInMonths")]
        public SearchColumnLongField[] termInMonths {
            get {
                return this.termInMonthsField;
            }
            set {
                this.termInMonthsField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("termsOfSale")]
        public SearchColumnStringField[] termsOfSale {
            get {
                return this.termsOfSaleField;
            }
            set {
                this.termsOfSaleField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("toBeEmailed")]
        public SearchColumnBooleanField[] toBeEmailed {
            get {
                return this.toBeEmailedField;
            }
            set {
                this.toBeEmailedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("toBePrinted")]
        public SearchColumnBooleanField[] toBePrinted {
            get {
                return this.toBePrintedField;
            }
            set {
                this.toBePrintedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("toSubsidiary")]
        public SearchColumnSelectField[] toSubsidiary {
            get {
                return this.toSubsidiaryField;
            }
            set {
                this.toSubsidiaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("total")]
        public SearchColumnDoubleField[] total {
            get {
                return this.totalField;
            }
            set {
                this.totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("totalCostEstimate")]
        public SearchColumnDoubleField[] totalCostEstimate {
            get {
                return this.totalCostEstimateField;
            }
            set {
                this.totalCostEstimateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("trackingNumbers")]
        public SearchColumnStringField[] trackingNumbers {
            get {
                return this.trackingNumbersField;
            }
            set {
                this.trackingNumbersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tranDate")]
        public SearchColumnDateField[] tranDate {
            get {
                return this.tranDateField;
            }
            set {
                this.tranDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tranEstGrossProfit")]
        public SearchColumnDoubleField[] tranEstGrossProfit {
            get {
                return this.tranEstGrossProfitField;
            }
            set {
                this.tranEstGrossProfitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tranFxEstGrossProfit")]
        public SearchColumnDoubleField[] tranFxEstGrossProfit {
            get {
                return this.tranFxEstGrossProfitField;
            }
            set {
                this.tranFxEstGrossProfitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tranId")]
        public SearchColumnStringField[] tranId {
            get {
                return this.tranIdField;
            }
            set {
                this.tranIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tranIsVsoeBundle")]
        public SearchColumnBooleanField[] tranIsVsoeBundle {
            get {
                return this.tranIsVsoeBundleField;
            }
            set {
                this.tranIsVsoeBundleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("transactionDiscount")]
        public SearchColumnBooleanField[] transactionDiscount {
            get {
                return this.transactionDiscountField;
            }
            set {
                this.transactionDiscountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("transactionLineType")]
        public SearchColumnEnumSelectField[] transactionLineType {
            get {
                return this.transactionLineTypeField;
            }
            set {
                this.transactionLineTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("transactionNumber")]
        public SearchColumnStringField[] transactionNumber {
            get {
                return this.transactionNumberField;
            }
            set {
                this.transactionNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("transferLocation")]
        public SearchColumnSelectField[] transferLocation {
            get {
                return this.transferLocationField;
            }
            set {
                this.transferLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("transferOrderItemLine")]
        public SearchColumnStringField[] transferOrderItemLine {
            get {
                return this.transferOrderItemLineField;
            }
            set {
                this.transferOrderItemLineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("transferOrderQuantityCommitted")]
        public SearchColumnDoubleField[] transferOrderQuantityCommitted {
            get {
                return this.transferOrderQuantityCommittedField;
            }
            set {
                this.transferOrderQuantityCommittedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("transferOrderQuantityPacked")]
        public SearchColumnDoubleField[] transferOrderQuantityPacked {
            get {
                return this.transferOrderQuantityPackedField;
            }
            set {
                this.transferOrderQuantityPackedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("transferOrderQuantityPicked")]
        public SearchColumnDoubleField[] transferOrderQuantityPicked {
            get {
                return this.transferOrderQuantityPickedField;
            }
            set {
                this.transferOrderQuantityPickedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("transferOrderQuantityReceived")]
        public SearchColumnDoubleField[] transferOrderQuantityReceived {
            get {
                return this.transferOrderQuantityReceivedField;
            }
            set {
                this.transferOrderQuantityReceivedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("transferOrderQuantityShipped")]
        public SearchColumnDoubleField[] transferOrderQuantityShipped {
            get {
                return this.transferOrderQuantityShippedField;
            }
            set {
                this.transferOrderQuantityShippedField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("unit")]
        public SearchColumnStringField[] unit {
            get {
                return this.unitField;
            }
            set {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("unitCostOverride")]
        public SearchColumnDoubleField[] unitCostOverride {
            get {
                return this.unitCostOverrideField;
            }
            set {
                this.unitCostOverrideField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("vendType")]
        public SearchColumnSelectField[] vendType {
            get {
                return this.vendTypeField;
            }
            set {
                this.vendTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("visibleToCustomer")]
        public SearchColumnBooleanField[] visibleToCustomer {
            get {
                return this.visibleToCustomerField;
            }
            set {
                this.visibleToCustomerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("vsoeAllocation")]
        public SearchColumnDoubleField[] vsoeAllocation {
            get {
                return this.vsoeAllocationField;
            }
            set {
                this.vsoeAllocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("vsoeAmount")]
        public SearchColumnDoubleField[] vsoeAmount {
            get {
                return this.vsoeAmountField;
            }
            set {
                this.vsoeAmountField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("webSite")]
        public SearchColumnStringField[] webSite {
            get {
                return this.webSiteField;
            }
            set {
                this.webSiteField = value;
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