namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:employees_2021_1.transactions.webservices.netsuite.com")]
    public partial class PaycheckJournalCompanyContributionList {

        private PaycheckJournalCompanyContribution[] paycheckJournalCompanyContributionField;

        private bool replaceAllField;

        public PaycheckJournalCompanyContributionList() {
            this.replaceAllField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("paycheckJournalCompanyContribution")]
        public PaycheckJournalCompanyContribution[] paycheckJournalCompanyContribution {
            get {
                return this.paycheckJournalCompanyContributionField;
            }
            set {
                this.paycheckJournalCompanyContributionField = value;
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