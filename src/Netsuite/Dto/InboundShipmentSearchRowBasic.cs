namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class InboundShipmentSearchRowBasic : SearchRowBasic {

        private SearchColumnDateField[] actualDeliveryDateField;

        private SearchColumnDateField[] actualShippingDateField;

        private SearchColumnStringField[] billOfLadingField;

        private SearchColumnDateField[] createdDateField;

        private SearchColumnSelectField[] currencyField;

        private SearchColumnStringField[] descriptionField;

        private SearchColumnDateField[] expectedDeliveryDateField;

        private SearchColumnDoubleField[] expectedRateField;

        private SearchColumnDateField[] expectedShippingDateField;

        private SearchColumnStringField[] externalDocumentNumberField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnSelectField[] incotermField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnSelectField[] itemField;

        private SearchColumnDateField[] itemEffectiveDateField;

        private SearchColumnDoubleField[] itemExchangeRateField;

        private SearchColumnEnumSelectField[] landedCostAllocationMethodField;

        private SearchColumnDoubleField[] landedCostAmountField;

        private SearchColumnSelectField[] landedCostCostCategoryField;

        private SearchColumnSelectField[] landedCostCurrencyField;

        private SearchColumnDateField[] landedCostEffectiveDateField;

        private SearchColumnDoubleField[] landedCostExchangeRateField;

        private SearchColumnStringField[] memoField;

        private SearchColumnDoubleField[] poAmountField;

        private SearchColumnDoubleField[] poRateField;

        private SearchColumnSelectField[] purchaseOrderField;

        private SearchColumnDoubleField[] quantityBilledField;

        private SearchColumnDoubleField[] quantityExpectedField;

        private SearchColumnDoubleField[] quantityReceivedField;

        private SearchColumnDoubleField[] quantityRemainingField;

        private SearchColumnSelectField[] receivingLocationField;

        private SearchColumnSelectField[] shipmentBaseCurrencyField;

        private SearchColumnStringField[] shipmentNumberField;

        private SearchColumnStringField[] statusField;

        private SearchColumnDoubleField[] totalUnitCostField;

        private SearchColumnSelectField[] unitField;

        private SearchColumnDoubleField[] unitLandedCostField;

        private SearchColumnSelectField[] vendorField;

        private SearchColumnStringField[] vesselNumberField;

        private SearchColumnCustomField[] customFieldListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("actualDeliveryDate")]
        public SearchColumnDateField[] actualDeliveryDate {
            get {
                return this.actualDeliveryDateField;
            }
            set {
                this.actualDeliveryDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("actualShippingDate")]
        public SearchColumnDateField[] actualShippingDate {
            get {
                return this.actualShippingDateField;
            }
            set {
                this.actualShippingDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billOfLading")]
        public SearchColumnStringField[] billOfLading {
            get {
                return this.billOfLadingField;
            }
            set {
                this.billOfLadingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("createdDate")]
        public SearchColumnDateField[] createdDate {
            get {
                return this.createdDateField;
            }
            set {
                this.createdDateField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("description")]
        public SearchColumnStringField[] description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("expectedDeliveryDate")]
        public SearchColumnDateField[] expectedDeliveryDate {
            get {
                return this.expectedDeliveryDateField;
            }
            set {
                this.expectedDeliveryDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("expectedRate")]
        public SearchColumnDoubleField[] expectedRate {
            get {
                return this.expectedRateField;
            }
            set {
                this.expectedRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("expectedShippingDate")]
        public SearchColumnDateField[] expectedShippingDate {
            get {
                return this.expectedShippingDateField;
            }
            set {
                this.expectedShippingDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("externalDocumentNumber")]
        public SearchColumnStringField[] externalDocumentNumber {
            get {
                return this.externalDocumentNumberField;
            }
            set {
                this.externalDocumentNumberField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("itemEffectiveDate")]
        public SearchColumnDateField[] itemEffectiveDate {
            get {
                return this.itemEffectiveDateField;
            }
            set {
                this.itemEffectiveDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("itemExchangeRate")]
        public SearchColumnDoubleField[] itemExchangeRate {
            get {
                return this.itemExchangeRateField;
            }
            set {
                this.itemExchangeRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("landedCostAllocationMethod")]
        public SearchColumnEnumSelectField[] landedCostAllocationMethod {
            get {
                return this.landedCostAllocationMethodField;
            }
            set {
                this.landedCostAllocationMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("landedCostAmount")]
        public SearchColumnDoubleField[] landedCostAmount {
            get {
                return this.landedCostAmountField;
            }
            set {
                this.landedCostAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("landedCostCostCategory")]
        public SearchColumnSelectField[] landedCostCostCategory {
            get {
                return this.landedCostCostCategoryField;
            }
            set {
                this.landedCostCostCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("landedCostCurrency")]
        public SearchColumnSelectField[] landedCostCurrency {
            get {
                return this.landedCostCurrencyField;
            }
            set {
                this.landedCostCurrencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("landedCostEffectiveDate")]
        public SearchColumnDateField[] landedCostEffectiveDate {
            get {
                return this.landedCostEffectiveDateField;
            }
            set {
                this.landedCostEffectiveDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("landedCostExchangeRate")]
        public SearchColumnDoubleField[] landedCostExchangeRate {
            get {
                return this.landedCostExchangeRateField;
            }
            set {
                this.landedCostExchangeRateField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("poAmount")]
        public SearchColumnDoubleField[] poAmount {
            get {
                return this.poAmountField;
            }
            set {
                this.poAmountField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("quantityExpected")]
        public SearchColumnDoubleField[] quantityExpected {
            get {
                return this.quantityExpectedField;
            }
            set {
                this.quantityExpectedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("quantityReceived")]
        public SearchColumnDoubleField[] quantityReceived {
            get {
                return this.quantityReceivedField;
            }
            set {
                this.quantityReceivedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("quantityRemaining")]
        public SearchColumnDoubleField[] quantityRemaining {
            get {
                return this.quantityRemainingField;
            }
            set {
                this.quantityRemainingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("receivingLocation")]
        public SearchColumnSelectField[] receivingLocation {
            get {
                return this.receivingLocationField;
            }
            set {
                this.receivingLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("shipmentBaseCurrency")]
        public SearchColumnSelectField[] shipmentBaseCurrency {
            get {
                return this.shipmentBaseCurrencyField;
            }
            set {
                this.shipmentBaseCurrencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("shipmentNumber")]
        public SearchColumnStringField[] shipmentNumber {
            get {
                return this.shipmentNumberField;
            }
            set {
                this.shipmentNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("status")]
        public SearchColumnStringField[] status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("totalUnitCost")]
        public SearchColumnDoubleField[] totalUnitCost {
            get {
                return this.totalUnitCostField;
            }
            set {
                this.totalUnitCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("unit")]
        public SearchColumnSelectField[] unit {
            get {
                return this.unitField;
            }
            set {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("unitLandedCost")]
        public SearchColumnDoubleField[] unitLandedCost {
            get {
                return this.unitLandedCostField;
            }
            set {
                this.unitLandedCostField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("vesselNumber")]
        public SearchColumnStringField[] vesselNumber {
            get {
                return this.vesselNumberField;
            }
            set {
                this.vesselNumberField = value;
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