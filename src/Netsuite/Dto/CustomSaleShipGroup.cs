namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:customization_2021_1.setup.webservices.netsuite.com")]
    public partial class CustomSaleShipGroup {

        private string sourceAddressField;

        private string destinationAddressField;

        private string shippingMethodField;

        private double shippingRateField;

        private bool shippingRateFieldSpecified;

        private double handlingRateField;

        private bool handlingRateFieldSpecified;

        private long idField;

        private bool idFieldSpecified;

        private string isFulfilledField;

        private double weightField;

        private bool weightFieldSpecified;

        private string sourceAddressRefField;

        private string destinationAddressRefField;

        private string shippingMethodRefField;

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
        public string destinationAddress {
            get {
                return this.destinationAddressField;
            }
            set {
                this.destinationAddressField = value;
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
        public string isFulfilled {
            get {
                return this.isFulfilledField;
            }
            set {
                this.isFulfilledField = value;
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
        public string sourceAddressRef {
            get {
                return this.sourceAddressRefField;
            }
            set {
                this.sourceAddressRefField = value;
            }
        }

        /// <remarks/>
        public string destinationAddressRef {
            get {
                return this.destinationAddressRefField;
            }
            set {
                this.destinationAddressRefField = value;
            }
        }

        /// <remarks/>
        public string shippingMethodRef {
            get {
                return this.shippingMethodRefField;
            }
            set {
                this.shippingMethodRefField = value;
            }
        }
    }
}