namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class PricingSearchBasic : SearchRecordBasic {

        private SearchBooleanField assignedPriceLevelField;

        private SearchMultiSelectField currencyField;

        private SearchMultiSelectField customerField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchMultiSelectField itemField;

        private SearchDoubleField maximumQuantityField;

        private SearchDoubleField minimumQuantityField;

        private SearchMultiSelectField priceLevelField;

        private SearchDoubleField rateField;

        /// <remarks/>
        public SearchBooleanField assignedPriceLevel {
            get {
                return this.assignedPriceLevelField;
            }
            set {
                this.assignedPriceLevelField = value;
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
        public SearchMultiSelectField customer {
            get {
                return this.customerField;
            }
            set {
                this.customerField = value;
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
        public SearchDoubleField maximumQuantity {
            get {
                return this.maximumQuantityField;
            }
            set {
                this.maximumQuantityField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField minimumQuantity {
            get {
                return this.minimumQuantityField;
            }
            set {
                this.minimumQuantityField = value;
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
        public SearchDoubleField rate {
            get {
                return this.rateField;
            }
            set {
                this.rateField = value;
            }
        }
    }
}