namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class PricingSearchRowBasic : SearchRowBasic {

        private SearchColumnSelectField[] currencyField;

        private SearchColumnSelectField[] customerField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnSelectField[] itemField;

        private SearchColumnDoubleField[] maximumQuantityField;

        private SearchColumnDoubleField[] minimumQuantityField;

        private SearchColumnSelectField[] priceLevelField;

        private SearchColumnStringField[] quantityRangeField;

        private SearchColumnSelectField[] saleUnitField;

        private SearchColumnDoubleField[] unitPriceField;

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
        [System.Xml.Serialization.XmlElementAttribute("customer")]
        public SearchColumnSelectField[] customer {
            get {
                return this.customerField;
            }
            set {
                this.customerField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("maximumQuantity")]
        public SearchColumnDoubleField[] maximumQuantity {
            get {
                return this.maximumQuantityField;
            }
            set {
                this.maximumQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("minimumQuantity")]
        public SearchColumnDoubleField[] minimumQuantity {
            get {
                return this.minimumQuantityField;
            }
            set {
                this.minimumQuantityField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("quantityRange")]
        public SearchColumnStringField[] quantityRange {
            get {
                return this.quantityRangeField;
            }
            set {
                this.quantityRangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("saleUnit")]
        public SearchColumnSelectField[] saleUnit {
            get {
                return this.saleUnitField;
            }
            set {
                this.saleUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("unitPrice")]
        public SearchColumnDoubleField[] unitPrice {
            get {
                return this.unitPriceField;
            }
            set {
                this.unitPriceField = value;
            }
        }
    }
}