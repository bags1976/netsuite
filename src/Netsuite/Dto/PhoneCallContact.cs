namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:scheduling_2021_1.activities.webservices.netsuite.com")]
    public partial class PhoneCallContact {

        private RecordRef companyField;

        private RecordRef contactField;

        private string phoneField;

        private string emailField;

        /// <remarks/>
        public RecordRef company {
            get {
                return this.companyField;
            }
            set {
                this.companyField = value;
            }
        }

        /// <remarks/>
        public RecordRef contact {
            get {
                return this.contactField;
            }
            set {
                this.contactField = value;
            }
        }

        /// <remarks/>
        public string phone {
            get {
                return this.phoneField;
            }
            set {
                this.phoneField = value;
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
    }
}