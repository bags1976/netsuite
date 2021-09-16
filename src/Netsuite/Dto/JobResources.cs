namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:relationships_2021_1.lists.webservices.netsuite.com")]
    public partial class JobResources {

        private RecordRef jobResourceField;

        private string emailField;

        private RecordRef roleField;

        /// <remarks/>
        public RecordRef jobResource {
            get {
                return this.jobResourceField;
            }
            set {
                this.jobResourceField = value;
            }
        }

        /// <remarks/>
        public string email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }

        /// <remarks/>
        public RecordRef role {
            get {
                return this.roleField;
            }
            set {
                this.roleField = value;
            }
        }
    }
}