namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class Pricing {

        private RecordRef currencyField;

        private RecordRef priceLevelField;

        private double discountField;

        private bool discountFieldSpecified;

        private Price[] priceListField;

        /// <remarks/>
        public RecordRef currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        public RecordRef priceLevel {
            get {
                return this.priceLevelField;
            }
            set {
                this.priceLevelField = value;
            }
        }

        /// <remarks/>
        public double discount {
            get {
                return this.discountField;
            }
            set {
                this.discountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool discountSpecified {
            get {
                return this.discountFieldSpecified;
            }
            set {
                this.discountFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("price", IsNullable=false)]
        public Price[] priceList {
            get {
                return this.priceListField;
            }
            set {
                this.priceListField = value;
            }
        }
    }
}