namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class InboundShipmentSearchBasic : SearchRecordBasic {

        private SearchDateField actualDeliveryDateField;

        private SearchDateField actualShippingDateField;

        private SearchStringField billOfLadingField;

        private SearchDateField createdDateField;

        private SearchMultiSelectField currencyField;

        private SearchStringField descriptionField;

        private SearchDateField expectedDeliveryDateField;

        private SearchDoubleField expectedRateField;

        private SearchDateField expectedShippingDateField;

        private SearchMultiSelectField externalDocumentNumberField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchMultiSelectField incotermField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchMultiSelectField itemField;

        private SearchDateField itemEffectiveDateField;

        private SearchDoubleField itemExchangeRateField;

        private SearchEnumMultiSelectField landedCostAllocationMethodField;

        private SearchDoubleField landedCostAmountField;

        private SearchMultiSelectField landedCostCostCategoryField;

        private SearchMultiSelectField landedCostCurrencyField;

        private SearchDateField landedCostEffectiveDateField;

        private SearchDoubleField landedCostExchangeRateField;

        private SearchStringField memoField;

        private SearchDoubleField poAmountField;

        private SearchDoubleField poRateField;

        private SearchMultiSelectField purchaseOrderField;

        private SearchDoubleField quantityBilledField;

        private SearchDoubleField quantityExpectedField;

        private SearchDoubleField quantityReceivedField;

        private SearchDoubleField quantityRemainingField;

        private SearchMultiSelectField receivingLocationField;

        private SearchMultiSelectField shipmentBaseCurrencyField;

        private SearchMultiSelectField shipmentNumberField;

        private SearchEnumMultiSelectField statusField;

        private SearchDoubleField totalUnitCostField;

        private SearchMultiSelectField unitField;

        private SearchDoubleField unitLandedCostField;

        private SearchMultiSelectField vendorField;

        private SearchStringField vesselNumberField;

        private SearchCustomField[] customFieldListField;

        /// <remarks/>
        public SearchDateField actualDeliveryDate {
            get {
                return this.actualDeliveryDateField;
            }
            set {
                this.actualDeliveryDateField = value;
            }
        }

        /// <remarks/>
        public SearchDateField actualShippingDate {
            get {
                return this.actualShippingDateField;
            }
            set {
                this.actualShippingDateField = value;
            }
        }

        /// <remarks/>
        public SearchStringField billOfLading {
            get {
                return this.billOfLadingField;
            }
            set {
                this.billOfLadingField = value;
            }
        }

        /// <remarks/>
        public SearchDateField createdDate {
            get {
                return this.createdDateField;
            }
            set {
                this.createdDateField = value;
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
        public SearchStringField description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public SearchDateField expectedDeliveryDate {
            get {
                return this.expectedDeliveryDateField;
            }
            set {
                this.expectedDeliveryDateField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField expectedRate {
            get {
                return this.expectedRateField;
            }
            set {
                this.expectedRateField = value;
            }
        }

        /// <remarks/>
        public SearchDateField expectedShippingDate {
            get {
                return this.expectedShippingDateField;
            }
            set {
                this.expectedShippingDateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField externalDocumentNumber {
            get {
                return this.externalDocumentNumberField;
            }
            set {
                this.externalDocumentNumberField = value;
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
        public SearchMultiSelectField incoterm {
            get {
                return this.incotermField;
            }
            set {
                this.incotermField = value;
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
        public SearchMultiSelectField item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }

        /// <remarks/>
        public SearchDateField itemEffectiveDate {
            get {
                return this.itemEffectiveDateField;
            }
            set {
                this.itemEffectiveDateField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField itemExchangeRate {
            get {
                return this.itemExchangeRateField;
            }
            set {
                this.itemExchangeRateField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField landedCostAllocationMethod {
            get {
                return this.landedCostAllocationMethodField;
            }
            set {
                this.landedCostAllocationMethodField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField landedCostAmount {
            get {
                return this.landedCostAmountField;
            }
            set {
                this.landedCostAmountField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField landedCostCostCategory {
            get {
                return this.landedCostCostCategoryField;
            }
            set {
                this.landedCostCostCategoryField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField landedCostCurrency {
            get {
                return this.landedCostCurrencyField;
            }
            set {
                this.landedCostCurrencyField = value;
            }
        }

        /// <remarks/>
        public SearchDateField landedCostEffectiveDate {
            get {
                return this.landedCostEffectiveDateField;
            }
            set {
                this.landedCostEffectiveDateField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField landedCostExchangeRate {
            get {
                return this.landedCostExchangeRateField;
            }
            set {
                this.landedCostExchangeRateField = value;
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
        public SearchDoubleField poAmount {
            get {
                return this.poAmountField;
            }
            set {
                this.poAmountField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField poRate {
            get {
                return this.poRateField;
            }
            set {
                this.poRateField = value;
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
        public SearchDoubleField quantityBilled {
            get {
                return this.quantityBilledField;
            }
            set {
                this.quantityBilledField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField quantityExpected {
            get {
                return this.quantityExpectedField;
            }
            set {
                this.quantityExpectedField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField quantityReceived {
            get {
                return this.quantityReceivedField;
            }
            set {
                this.quantityReceivedField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField quantityRemaining {
            get {
                return this.quantityRemainingField;
            }
            set {
                this.quantityRemainingField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField receivingLocation {
            get {
                return this.receivingLocationField;
            }
            set {
                this.receivingLocationField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField shipmentBaseCurrency {
            get {
                return this.shipmentBaseCurrencyField;
            }
            set {
                this.shipmentBaseCurrencyField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField shipmentNumber {
            get {
                return this.shipmentNumberField;
            }
            set {
                this.shipmentNumberField = value;
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
        public SearchDoubleField totalUnitCost {
            get {
                return this.totalUnitCostField;
            }
            set {
                this.totalUnitCostField = value;
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
        public SearchDoubleField unitLandedCost {
            get {
                return this.unitLandedCostField;
            }
            set {
                this.unitLandedCostField = value;
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
        public SearchStringField vesselNumber {
            get {
                return this.vesselNumberField;
            }
            set {
                this.vesselNumberField = value;
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