namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:purchases_2021_1.transactions.webservices.netsuite.com")]
    public partial class InboundShipmentItems {

        private long idField;

        private bool idFieldSpecified;

        private RecordRef purchaseOrderField;

        private RecordRef shipmentItemField;

        private string shipmentItemDescriptionField;

        private string poVendorField;

        private RecordRef receivingLocationField;

        private double quantityReceivedField;

        private bool quantityReceivedFieldSpecified;

        private double quantityExpectedField;

        private bool quantityExpectedFieldSpecified;

        private double quantityRemainingField;

        private bool quantityRemainingFieldSpecified;

        private RecordRef unitField;

        private double poRateField;

        private bool poRateFieldSpecified;

        private double expectedRateField;

        private bool expectedRateFieldSpecified;

        private double shipmentItemExchangeRateField;

        private bool shipmentItemExchangeRateFieldSpecified;

        private System.DateTime shipmentItemEffectiveDateField;

        private bool shipmentItemEffectiveDateFieldSpecified;

        private double unitLandedCostField;

        private bool unitLandedCostFieldSpecified;

        private double totalUnitCostField;

        private bool totalUnitCostFieldSpecified;

        private double shipmentItemAmountField;

        private bool shipmentItemAmountFieldSpecified;

        private RecordRef poCurrencyField;

        private RecordRef incotermField;

        private InventoryDetail inventoryDetailField;

        /// <remarks/>
        public long id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef purchaseOrder {
            get {
                return this.purchaseOrderField;
            }
            set {
                this.purchaseOrderField = value;
            }
        }

        /// <remarks/>
        public RecordRef shipmentItem {
            get {
                return this.shipmentItemField;
            }
            set {
                this.shipmentItemField = value;
            }
        }

        /// <remarks/>
        public string shipmentItemDescription {
            get {
                return this.shipmentItemDescriptionField;
            }
            set {
                this.shipmentItemDescriptionField = value;
            }
        }

        /// <remarks/>
        public string poVendor {
            get {
                return this.poVendorField;
            }
            set {
                this.poVendorField = value;
            }
        }

        /// <remarks/>
        public RecordRef receivingLocation {
            get {
                return this.receivingLocationField;
            }
            set {
                this.receivingLocationField = value;
            }
        }

        /// <remarks/>
        public double quantityReceived {
            get {
                return this.quantityReceivedField;
            }
            set {
                this.quantityReceivedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantityReceivedSpecified {
            get {
                return this.quantityReceivedFieldSpecified;
            }
            set {
                this.quantityReceivedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double quantityExpected {
            get {
                return this.quantityExpectedField;
            }
            set {
                this.quantityExpectedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantityExpectedSpecified {
            get {
                return this.quantityExpectedFieldSpecified;
            }
            set {
                this.quantityExpectedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double quantityRemaining {
            get {
                return this.quantityRemainingField;
            }
            set {
                this.quantityRemainingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool quantityRemainingSpecified {
            get {
                return this.quantityRemainingFieldSpecified;
            }
            set {
                this.quantityRemainingFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef unit {
            get {
                return this.unitField;
            }
            set {
                this.unitField = value;
            }
        }

        /// <remarks/>
        public double poRate {
            get {
                return this.poRateField;
            }
            set {
                this.poRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool poRateSpecified {
            get {
                return this.poRateFieldSpecified;
            }
            set {
                this.poRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double expectedRate {
            get {
                return this.expectedRateField;
            }
            set {
                this.expectedRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expectedRateSpecified {
            get {
                return this.expectedRateFieldSpecified;
            }
            set {
                this.expectedRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double shipmentItemExchangeRate {
            get {
                return this.shipmentItemExchangeRateField;
            }
            set {
                this.shipmentItemExchangeRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shipmentItemExchangeRateSpecified {
            get {
                return this.shipmentItemExchangeRateFieldSpecified;
            }
            set {
                this.shipmentItemExchangeRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime shipmentItemEffectiveDate {
            get {
                return this.shipmentItemEffectiveDateField;
            }
            set {
                this.shipmentItemEffectiveDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shipmentItemEffectiveDateSpecified {
            get {
                return this.shipmentItemEffectiveDateFieldSpecified;
            }
            set {
                this.shipmentItemEffectiveDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double unitLandedCost {
            get {
                return this.unitLandedCostField;
            }
            set {
                this.unitLandedCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unitLandedCostSpecified {
            get {
                return this.unitLandedCostFieldSpecified;
            }
            set {
                this.unitLandedCostFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double totalUnitCost {
            get {
                return this.totalUnitCostField;
            }
            set {
                this.totalUnitCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totalUnitCostSpecified {
            get {
                return this.totalUnitCostFieldSpecified;
            }
            set {
                this.totalUnitCostFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double shipmentItemAmount {
            get {
                return this.shipmentItemAmountField;
            }
            set {
                this.shipmentItemAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shipmentItemAmountSpecified {
            get {
                return this.shipmentItemAmountFieldSpecified;
            }
            set {
                this.shipmentItemAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef poCurrency {
            get {
                return this.poCurrencyField;
            }
            set {
                this.poCurrencyField = value;
            }
        }

        /// <remarks/>
        public RecordRef incoterm {
            get {
                return this.incotermField;
            }
            set {
                this.incotermField = value;
            }
        }

        /// <remarks/>
        public InventoryDetail inventoryDetail {
            get {
                return this.inventoryDetailField;
            }
            set {
                this.inventoryDetailField = value;
            }
        }
    }
}