namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:customers_2021_1.transactions.webservices.netsuite.com")]
    public partial class ReturnAuthorizationSalesTeamList {

        private ReturnAuthorizationSalesTeam[] salesTeamField;

        private bool replaceAllField;

        public ReturnAuthorizationSalesTeamList() {
            this.replaceAllField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("salesTeam")]
        public ReturnAuthorizationSalesTeam[] salesTeam {
            get {
                return this.salesTeamField;
            }
            set {
                this.salesTeamField = value;
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