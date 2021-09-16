namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:marketing_2021_1.lists.webservices.netsuite.com")]
    public partial class CampaignDirectMailList {

        private CampaignDirectMail[] campaignDirectMailField;

        private bool replaceAllField;

        public CampaignDirectMailList() {
            this.replaceAllField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("campaignDirectMail")]
        public CampaignDirectMail[] campaignDirectMail {
            get {
                return this.campaignDirectMailField;
            }
            set {
                this.campaignDirectMailField = value;
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