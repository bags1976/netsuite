namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:general_2021_1.transactions.webservices.netsuite.com")]
    public partial class AdvInterCompanyJournalEntryAccountingBookDetailList {

        private AdvInterCompanyJournalEntryAccountingBookDetail[] interCompanyJournalEntryAccountingBookDetailField;

        private bool replaceAllField;

        public AdvInterCompanyJournalEntryAccountingBookDetailList() {
            this.replaceAllField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("interCompanyJournalEntryAccountingBookDetail")]
        public AdvInterCompanyJournalEntryAccountingBookDetail[] interCompanyJournalEntryAccountingBookDetail {
            get {
                return this.interCompanyJournalEntryAccountingBookDetailField;
            }
            set {
                this.interCompanyJournalEntryAccountingBookDetailField = value;
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