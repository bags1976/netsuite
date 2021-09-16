namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class TaxDetails {

        private string taxDetailsReferenceField;

        private string lineTypeField;

        private string lineNameField;

        private double netAmountField;

        private bool netAmountFieldSpecified;

        private double grossAmountField;

        private bool grossAmountFieldSpecified;

        private RecordRef taxTypeField;

        private RecordRef taxCodeField;

        private double taxBasisField;

        private bool taxBasisFieldSpecified;

        private double taxRateField;

        private bool taxRateFieldSpecified;

        private double taxAmountField;

        private bool taxAmountFieldSpecified;

        private string calcDetailField;

        /// <remarks/>
        public string taxDetailsReference {
            get {
                return this.taxDetailsReferenceField;
            }
            set {
                this.taxDetailsReferenceField = value;
            }
        }

        /// <remarks/>
        public string lineType {
            get {
                return this.lineTypeField;
            }
            set {
                this.lineTypeField = value;
            }
        }

        /// <remarks/>
        public string lineName {
            get {
                return this.lineNameField;
            }
            set {
                this.lineNameField = value;
            }
        }

        /// <remarks/>
        public double netAmount {
            get {
                return this.netAmountField;
            }
            set {
                this.netAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool netAmountSpecified {
            get {
                return this.netAmountFieldSpecified;
            }
            set {
                this.netAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double grossAmount {
            get {
                return this.grossAmountField;
            }
            set {
                this.grossAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool grossAmountSpecified {
            get {
                return this.grossAmountFieldSpecified;
            }
            set {
                this.grossAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef taxType {
            get {
                return this.taxTypeField;
            }
            set {
                this.taxTypeField = value;
            }
        }

        /// <remarks/>
        public RecordRef taxCode {
            get {
                return this.taxCodeField;
            }
            set {
                this.taxCodeField = value;
            }
        }

        /// <remarks/>
        public double taxBasis {
            get {
                return this.taxBasisField;
            }
            set {
                this.taxBasisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxBasisSpecified {
            get {
                return this.taxBasisFieldSpecified;
            }
            set {
                this.taxBasisFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double taxRate {
            get {
                return this.taxRateField;
            }
            set {
                this.taxRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxRateSpecified {
            get {
                return this.taxRateFieldSpecified;
            }
            set {
                this.taxRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double taxAmount {
            get {
                return this.taxAmountField;
            }
            set {
                this.taxAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxAmountSpecified {
            get {
                return this.taxAmountFieldSpecified;
            }
            set {
                this.taxAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string calcDetail {
            get {
                return this.calcDetailField;
            }
            set {
                this.calcDetailField = value;
            }
        }
    }
}