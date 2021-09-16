namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sales_2021_1.transactions.webservices.netsuite.com")]
    public partial class TransactionShipGroup {

        private long idField;

        private bool idFieldSpecified;

        private bool isFulfilledField;

        private bool isFulfilledFieldSpecified;

        private double weightField;

        private bool weightFieldSpecified;

        private RecordRef sourceAddressRefField;

        private string sourceAddressField;

        private RecordRef destinationAddressRefField;

        private string destinationAddressField;

        private RecordRef shippingMethodRefField;

        private string shippingMethodField;

        private bool isHandlingTaxableField;

        private bool isHandlingTaxableFieldSpecified;

        private RecordRef handlingTaxCodeField;

        private string handlingTaxRateField;

        private string handlingTax2RateField;

        private double handlingRateField;

        private bool handlingRateFieldSpecified;

        private double handlingTaxAmtField;

        private bool handlingTaxAmtFieldSpecified;

        private double handlingTax2AmtField;

        private bool handlingTax2AmtFieldSpecified;

        private bool isShippingTaxableField;

        private bool isShippingTaxableFieldSpecified;

        private RecordRef shippingTaxCodeField;

        private string shippingTaxRateField;

        private string shippingTax2RateField;

        private double shippingRateField;

        private bool shippingRateFieldSpecified;

        private double shippingTaxAmtField;

        private bool shippingTaxAmtFieldSpecified;

        private double shippingTax2AmtField;

        private bool shippingTax2AmtFieldSpecified;

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
        public bool isFulfilled {
            get {
                return this.isFulfilledField;
            }
            set {
                this.isFulfilledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isFulfilledSpecified {
            get {
                return this.isFulfilledFieldSpecified;
            }
            set {
                this.isFulfilledFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double weight {
            get {
                return this.weightField;
            }
            set {
                this.weightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool weightSpecified {
            get {
                return this.weightFieldSpecified;
            }
            set {
                this.weightFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef sourceAddressRef {
            get {
                return this.sourceAddressRefField;
            }
            set {
                this.sourceAddressRefField = value;
            }
        }

        /// <remarks/>
        public string sourceAddress {
            get {
                return this.sourceAddressField;
            }
            set {
                this.sourceAddressField = value;
            }
        }

        /// <remarks/>
        public RecordRef destinationAddressRef {
            get {
                return this.destinationAddressRefField;
            }
            set {
                this.destinationAddressRefField = value;
            }
        }

        /// <remarks/>
        public string destinationAddress {
            get {
                return this.destinationAddressField;
            }
            set {
                this.destinationAddressField = value;
            }
        }

        /// <remarks/>
        public RecordRef shippingMethodRef {
            get {
                return this.shippingMethodRefField;
            }
            set {
                this.shippingMethodRefField = value;
            }
        }

        /// <remarks/>
        public string shippingMethod {
            get {
                return this.shippingMethodField;
            }
            set {
                this.shippingMethodField = value;
            }
        }

        /// <remarks/>
        public bool isHandlingTaxable {
            get {
                return this.isHandlingTaxableField;
            }
            set {
                this.isHandlingTaxableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isHandlingTaxableSpecified {
            get {
                return this.isHandlingTaxableFieldSpecified;
            }
            set {
                this.isHandlingTaxableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef handlingTaxCode {
            get {
                return this.handlingTaxCodeField;
            }
            set {
                this.handlingTaxCodeField = value;
            }
        }

        /// <remarks/>
        public string handlingTaxRate {
            get {
                return this.handlingTaxRateField;
            }
            set {
                this.handlingTaxRateField = value;
            }
        }

        /// <remarks/>
        public string handlingTax2Rate {
            get {
                return this.handlingTax2RateField;
            }
            set {
                this.handlingTax2RateField = value;
            }
        }

        /// <remarks/>
        public double handlingRate {
            get {
                return this.handlingRateField;
            }
            set {
                this.handlingRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool handlingRateSpecified {
            get {
                return this.handlingRateFieldSpecified;
            }
            set {
                this.handlingRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double handlingTaxAmt {
            get {
                return this.handlingTaxAmtField;
            }
            set {
                this.handlingTaxAmtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool handlingTaxAmtSpecified {
            get {
                return this.handlingTaxAmtFieldSpecified;
            }
            set {
                this.handlingTaxAmtFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double handlingTax2Amt {
            get {
                return this.handlingTax2AmtField;
            }
            set {
                this.handlingTax2AmtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool handlingTax2AmtSpecified {
            get {
                return this.handlingTax2AmtFieldSpecified;
            }
            set {
                this.handlingTax2AmtFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isShippingTaxable {
            get {
                return this.isShippingTaxableField;
            }
            set {
                this.isShippingTaxableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isShippingTaxableSpecified {
            get {
                return this.isShippingTaxableFieldSpecified;
            }
            set {
                this.isShippingTaxableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef shippingTaxCode {
            get {
                return this.shippingTaxCodeField;
            }
            set {
                this.shippingTaxCodeField = value;
            }
        }

        /// <remarks/>
        public string shippingTaxRate {
            get {
                return this.shippingTaxRateField;
            }
            set {
                this.shippingTaxRateField = value;
            }
        }

        /// <remarks/>
        public string shippingTax2Rate {
            get {
                return this.shippingTax2RateField;
            }
            set {
                this.shippingTax2RateField = value;
            }
        }

        /// <remarks/>
        public double shippingRate {
            get {
                return this.shippingRateField;
            }
            set {
                this.shippingRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shippingRateSpecified {
            get {
                return this.shippingRateFieldSpecified;
            }
            set {
                this.shippingRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double shippingTaxAmt {
            get {
                return this.shippingTaxAmtField;
            }
            set {
                this.shippingTaxAmtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shippingTaxAmtSpecified {
            get {
                return this.shippingTaxAmtFieldSpecified;
            }
            set {
                this.shippingTaxAmtFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double shippingTax2Amt {
            get {
                return this.shippingTax2AmtField;
            }
            set {
                this.shippingTax2AmtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shippingTax2AmtSpecified {
            get {
                return this.shippingTax2AmtFieldSpecified;
            }
            set {
                this.shippingTax2AmtFieldSpecified = value;
            }
        }
    }
}