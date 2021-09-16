namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class TaxTypeNexusesTax {

        private RecordRef nexusField;

        private string descriptionField;

        private RecordRef saleTaxAcctField;

        private RecordRef purchTaxAcctField;

        /// <remarks/>
        public RecordRef nexus {
            get {
                return this.nexusField;
            }
            set {
                this.nexusField = value;
            }
        }

        /// <remarks/>
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public RecordRef saleTaxAcct {
            get {
                return this.saleTaxAcctField;
            }
            set {
                this.saleTaxAcctField = value;
            }
        }

        /// <remarks/>
        public RecordRef purchTaxAcct {
            get {
                return this.purchTaxAcctField;
            }
            set {
                this.purchTaxAcctField = value;
            }
        }
    }
}