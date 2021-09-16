namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:employees_2021_1.transactions.webservices.netsuite.com")]
    public partial class PaycheckJournalEmployeeTaxList {

        private PaycheckJournalEmployeeTax[] paycheckJournalEmployeeTaxField;

        private bool replaceAllField;

        public PaycheckJournalEmployeeTaxList() {
            this.replaceAllField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("paycheckJournalEmployeeTax")]
        public PaycheckJournalEmployeeTax[] paycheckJournalEmployeeTax {
            get {
                return this.paycheckJournalEmployeeTaxField;
            }
            set {
                this.paycheckJournalEmployeeTaxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool replaceAll {
            get {
                return this.replaceAllField;
            }
            set {
                this.replaceAllField = value;
            }
        }
    }
}