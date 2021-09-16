namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public partial class ChangeEmail {

        private string currentPasswordField;

        private string newEmailField;

        private string newEmail2Field;

        private bool justThisAccountField;

        private bool justThisAccountFieldSpecified;

        /// <remarks/>
        public string currentPassword {
            get {
                return this.currentPasswordField;
            }
            set {
                this.currentPasswordField = value;
            }
        }

        /// <remarks/>
        public string newEmail {
            get {
                return this.newEmailField;
            }
            set {
                this.newEmailField = value;
            }
        }

        /// <remarks/>
        public string newEmail2 {
            get {
                return this.newEmail2Field;
            }
            set {
                this.newEmail2Field = value;
            }
        }

        /// <remarks/>
        public bool justThisAccount {
            get {
                return this.justThisAccountField;
            }
            set {
                this.justThisAccountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool justThisAccountSpecified {
            get {
                return this.justThisAccountFieldSpecified;
            }
            set {
                this.justThisAccountFieldSpecified = value;
            }
        }
    }
}