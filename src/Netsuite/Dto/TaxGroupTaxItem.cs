namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class TaxGroupTaxItem {

        private RecordRef taxNameField;

        private double rateField;

        private bool rateFieldSpecified;

        private double basisField;

        private bool basisFieldSpecified;

        private string taxTypeField;

        /// <remarks/>
        public RecordRef taxName {
            get {
                return this.taxNameField;
            }
            set {
                this.taxNameField = value;
            }
        }

        /// <remarks/>
        public double rate {
            get {
                return this.rateField;
            }
            set {
                this.rateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rateSpecified {
            get {
                return this.rateFieldSpecified;
            }
            set {
                this.rateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double basis {
            get {
                return this.basisField;
            }
            set {
                this.basisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool basisSpecified {
            get {
                return this.basisFieldSpecified;
            }
            set {
                this.basisFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string taxType {
            get {
                return this.taxTypeField;
            }
            set {
                this.taxTypeField = value;
            }
        }
    }
}