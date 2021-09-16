namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class ItemVendor {

        private RecordRef vendorField;

        private string vendorCodeField;

        private string vendorCurrencyNameField;

        private RecordRef vendorCurrencyField;

        private double purchasePriceField;

        private bool purchasePriceFieldSpecified;

        private bool preferredVendorField;

        private bool preferredVendorFieldSpecified;

        private RecordRef scheduleField;

        private RecordRef subsidiaryField;

        /// <remarks/>
        public RecordRef vendor {
            get {
                return this.vendorField;
            }
            set {
                this.vendorField = value;
            }
        }

        /// <remarks/>
        public string vendorCode {
            get {
                return this.vendorCodeField;
            }
            set {
                this.vendorCodeField = value;
            }
        }

        /// <remarks/>
        public string vendorCurrencyName {
            get {
                return this.vendorCurrencyNameField;
            }
            set {
                this.vendorCurrencyNameField = value;
            }
        }

        /// <remarks/>
        public RecordRef vendorCurrency {
            get {
                return this.vendorCurrencyField;
            }
            set {
                this.vendorCurrencyField = value;
            }
        }

        /// <remarks/>
        public double purchasePrice {
            get {
                return this.purchasePriceField;
            }
            set {
                this.purchasePriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool purchasePriceSpecified {
            get {
                return this.purchasePriceFieldSpecified;
            }
            set {
                this.purchasePriceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool preferredVendor {
            get {
                return this.preferredVendorField;
            }
            set {
                this.preferredVendorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool preferredVendorSpecified {
            get {
                return this.preferredVendorFieldSpecified;
            }
            set {
                this.preferredVendorFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef schedule {
            get {
                return this.scheduleField;
            }
            set {
                this.scheduleField = value;
            }
        }

        /// <remarks/>
        public RecordRef subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
            }
        }
    }
}