namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:inventory_2021_1.transactions.webservices.netsuite.com")]
    public partial class InventoryAdjustmentInventory {

        private RecordRef itemField;

        private long lineField;

        private bool lineFieldSpecified;

        private InventoryDetail inventoryDetailField;

        private string descriptionField;

        private RecordRef departmentField;

        private RecordRef classField;

        private RecordRef locationField;

        private RecordRef unitsField;

        private double quantityOnHandField;

        private bool quantityOnHandFieldSpecified;

        private double currentValueField;

        private bool currentValueFieldSpecified;

        private double adjustQtyByField;

        private bool adjustQtyByFieldSpecified;

        private string binNumbersField;

        private string serialNumbersField;

        private double newQuantityField;

        private bool newQuantityFieldSpecified;

        private double unitCostField;

        private bool unitCostFieldSpecified;

        private double foreignCurrencyUnitCostField;

        private bool foreignCurrencyUnitCostFieldSpecified;

        private string memoField;

        private string currencyField;

        private System.DateTime expirationDateField;

        private bool expirationDateFieldSpecified;

        private double exchangeRateField;

        private bool exchangeRateFieldSpecified;

        /// <remarks/>
        public RecordRef item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }

        /// <remarks/>
        public long line {
            get {
                return this.lineField;
            }
            set {
                this.lineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lineSpecified {
            get {
                return this.lineFieldSpecified;
            }
            set {
                this.lineFieldSpecified = value;
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
        public RecordRef department {
            get {
                return this.departmentField;
            }
            set {
                this.departmentField = value;
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
        public RecordRef units {
            get {
                return this.unitsField;
            }
            set {
                this.unitsField = value;
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
        public double currentValue {
            get {
                return this.currentValueField;
            }
            set {
                this.currentValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool currentValueSpecified {
            get {
                return this.currentValueFieldSpecified;
            }
            set {
                this.currentValueFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double adjustQtyBy {
            get {
                return this.adjustQtyByField;
            }
            set {
                this.adjustQtyByField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool adjustQtyBySpecified {
            get {
                return this.adjustQtyByFieldSpecified;
            }
            set {
                this.adjustQtyByFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string binNumbers {
            get {
                return this.binNumbersField;
            }
            set {
                this.binNumbersField = value;
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
        public double newQuantity {
            get {
                return this.newQuantityField;
            }
            set {
                this.newQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool newQuantitySpecified {
            get {
                return this.newQuantityFieldSpecified;
            }
            set {
                this.newQuantityFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double unitCost {
            get {
                return this.unitCostField;
            }
            set {
                this.unitCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unitCostSpecified {
            get {
                return this.unitCostFieldSpecified;
            }
            set {
                this.unitCostFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double foreignCurrencyUnitCost {
            get {
                return this.foreignCurrencyUnitCostField;
            }
            set {
                this.foreignCurrencyUnitCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool foreignCurrencyUnitCostSpecified {
            get {
                return this.foreignCurrencyUnitCostFieldSpecified;
            }
            set {
                this.foreignCurrencyUnitCostFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string memo {
            get {
                return this.memoField;
            }
            set {
                this.memoField = value;
            }
        }

        /// <remarks/>
        public string currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
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
        public double exchangeRate {
            get {
                return this.exchangeRateField;
            }
            set {
                this.exchangeRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool exchangeRateSpecified {
            get {
                return this.exchangeRateFieldSpecified;
            }
            set {
                this.exchangeRateFieldSpecified = value;
            }
        }
    }
}