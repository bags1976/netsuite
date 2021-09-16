namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:relationships_2021_1.lists.webservices.netsuite.com")]
    public partial class VendorCurrency {

        private RecordRef currencyField;

        private double balanceField;

        private bool balanceFieldSpecified;

        private double unbilledOrdersField;

        private bool unbilledOrdersFieldSpecified;

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
        public double balance {
            get {
                return this.balanceField;
            }
            set {
                this.balanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool balanceSpecified {
            get {
                return this.balanceFieldSpecified;
            }
            set {
                this.balanceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double unbilledOrders {
            get {
                return this.unbilledOrdersField;
            }
            set {
                this.unbilledOrdersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unbilledOrdersSpecified {
            get {
                return this.unbilledOrdersFieldSpecified;
            }
            set {
                this.unbilledOrdersFieldSpecified = value;
            }
        }
    }
}