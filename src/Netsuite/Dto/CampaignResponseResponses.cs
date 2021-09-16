namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:marketing_2021_1.lists.webservices.netsuite.com")]
    public partial class CampaignResponseResponses {

        private string responseField;

        private string responseDateField;

        private string authorField;

        private string noteField;

        /// <remarks/>
        public string response {
            get {
                return this.responseField;
            }
            set {
                this.responseField = value;
            }
        }

        /// <remarks/>
        public string responseDate {
            get {
                return this.responseDateField;
            }
            set {
                this.responseDateField = value;
            }
        }

        /// <remarks/>
        public string author {
            get {
                return this.authorField;
            }
            set {
                this.authorField = value;
            }
        }

        /// <remarks/>
        public string note {
            get {
                return this.noteField;
            }
            set {
                this.noteField = value;
            }
        }
    }
}