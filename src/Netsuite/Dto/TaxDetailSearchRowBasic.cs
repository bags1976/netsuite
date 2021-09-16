namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class TaxDetailSearchRowBasic : SearchRowBasic {

        private SearchColumnStringField[] accountField;

        private SearchColumnStringField[] detailsField;

        private SearchColumnLongField[] lineNumberField;

        private SearchColumnDoubleField[] taxAmountField;

        private SearchColumnDoubleField[] taxBasisField;

        private SearchColumnSelectField[] taxCodeField;

        private SearchColumnDoubleField[] taxRateField;

        private SearchColumnSelectField[] taxTypeField;

        private SearchColumnLongField[] tranIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("account")]
        public SearchColumnStringField[] account {
            get {
                return this.accountField;
            }
            set {
                this.accountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("details")]
        public SearchColumnStringField[] details {
            get {
                return this.detailsField;
            }
            set {
                this.detailsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lineNumber")]
        public SearchColumnLongField[] lineNumber {
            get {
                return this.lineNumberField;
            }
            set {
                this.lineNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("taxAmount")]
        public SearchColumnDoubleField[] taxAmount {
            get {
                return this.taxAmountField;
            }
            set {
                this.taxAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("taxBasis")]
        public SearchColumnDoubleField[] taxBasis {
            get {
                return this.taxBasisField;
            }
            set {
                this.taxBasisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("taxCode")]
        public SearchColumnSelectField[] taxCode {
            get {
                return this.taxCodeField;
            }
            set {
                this.taxCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("taxRate")]
        public SearchColumnDoubleField[] taxRate {
            get {
                return this.taxRateField;
            }
            set {
                this.taxRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("taxType")]
        public SearchColumnSelectField[] taxType {
            get {
                return this.taxTypeField;
            }
            set {
                this.taxTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tranId")]
        public SearchColumnLongField[] tranId {
            get {
                return this.tranIdField;
            }
            set {
                this.tranIdField = value;
            }
        }
    }
}