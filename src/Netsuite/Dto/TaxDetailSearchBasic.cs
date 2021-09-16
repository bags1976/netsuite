namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class TaxDetailSearchBasic : SearchRecordBasic {

        private SearchMultiSelectField accountField;

        private SearchLongField lineNumberField;

        private SearchDoubleField taxAmountField;

        private SearchDoubleField taxBasisField;

        private SearchMultiSelectField taxCodeField;

        private SearchDoubleField taxRateField;

        private SearchMultiSelectField taxTypeField;

        private SearchMultiSelectField tranIdField;

        /// <remarks/>
        public SearchMultiSelectField account {
            get {
                return this.accountField;
            }
            set {
                this.accountField = value;
            }
        }

        /// <remarks/>
        public SearchLongField lineNumber {
            get {
                return this.lineNumberField;
            }
            set {
                this.lineNumberField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField taxAmount {
            get {
                return this.taxAmountField;
            }
            set {
                this.taxAmountField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField taxBasis {
            get {
                return this.taxBasisField;
            }
            set {
                this.taxBasisField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField taxCode {
            get {
                return this.taxCodeField;
            }
            set {
                this.taxCodeField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField taxRate {
            get {
                return this.taxRateField;
            }
            set {
                this.taxRateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField taxType {
            get {
                return this.taxTypeField;
            }
            set {
                this.taxTypeField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField tranId {
            get {
                return this.tranIdField;
            }
            set {
                this.tranIdField = value;
            }
        }
    }
}