namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:purchases_2021_1.transactions.webservices.netsuite.com")]
    public partial class InboundShipmentLandedCost {

        private RecordRef landedCostCostCategoryField;

        private double landedCostAmountField;

        private bool landedCostAmountFieldSpecified;

        private RecordRef landedCostCurrencyField;

        private double landedCostExchangeRateField;

        private bool landedCostExchangeRateFieldSpecified;

        private System.DateTime landedCostEffectiveDateField;

        private bool landedCostEffectiveDateFieldSpecified;

        private InboundShipmentLandedCostAllocationMethod landedCostAllocationMethodField;

        private bool landedCostAllocationMethodFieldSpecified;

        private RecordRef[] landedCostShipmentItemsListField;

        /// <remarks/>
        public RecordRef landedCostCostCategory {
            get {
                return this.landedCostCostCategoryField;
            }
            set {
                this.landedCostCostCategoryField = value;
            }
        }

        /// <remarks/>
        public double landedCostAmount {
            get {
                return this.landedCostAmountField;
            }
            set {
                this.landedCostAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool landedCostAmountSpecified {
            get {
                return this.landedCostAmountFieldSpecified;
            }
            set {
                this.landedCostAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef landedCostCurrency {
            get {
                return this.landedCostCurrencyField;
            }
            set {
                this.landedCostCurrencyField = value;
            }
        }

        /// <remarks/>
        public double landedCostExchangeRate {
            get {
                return this.landedCostExchangeRateField;
            }
            set {
                this.landedCostExchangeRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool landedCostExchangeRateSpecified {
            get {
                return this.landedCostExchangeRateFieldSpecified;
            }
            set {
                this.landedCostExchangeRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime landedCostEffectiveDate {
            get {
                return this.landedCostEffectiveDateField;
            }
            set {
                this.landedCostEffectiveDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool landedCostEffectiveDateSpecified {
            get {
                return this.landedCostEffectiveDateFieldSpecified;
            }
            set {
                this.landedCostEffectiveDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public InboundShipmentLandedCostAllocationMethod landedCostAllocationMethod {
            get {
                return this.landedCostAllocationMethodField;
            }
            set {
                this.landedCostAllocationMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool landedCostAllocationMethodSpecified {
            get {
                return this.landedCostAllocationMethodFieldSpecified;
            }
            set {
                this.landedCostAllocationMethodFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recordRef", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public RecordRef[] landedCostShipmentItemsList {
            get {
                return this.landedCostShipmentItemsListField;
            }
            set {
                this.landedCostShipmentItemsListField = value;
            }
        }
    }
}