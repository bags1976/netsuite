namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:supplychain_2021_1.lists.webservices.netsuite.com")]
    public partial class ManufacturingCostDetail {

        private RecordRef costCategoryField;

        private RecordRef itemField;

        private double fixedRateField;

        private bool fixedRateFieldSpecified;

        private double runRateField;

        private bool runRateFieldSpecified;

        /// <remarks/>
        public RecordRef costCategory {
            get {
                return this.costCategoryField;
            }
            set {
                this.costCategoryField = value;
            }
        }

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
        public double fixedRate {
            get {
                return this.fixedRateField;
            }
            set {
                this.fixedRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fixedRateSpecified {
            get {
                return this.fixedRateFieldSpecified;
            }
            set {
                this.fixedRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double runRate {
            get {
                return this.runRateField;
            }
            set {
                this.runRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool runRateSpecified {
            get {
                return this.runRateFieldSpecified;
            }
            set {
                this.runRateFieldSpecified = value;
            }
        }
    }
}