namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:relationships_2021_1.lists.webservices.netsuite.com")]
    public partial class ContactAccessRoles {

        private bool giveAccessField;

        private bool giveAccessFieldSpecified;

        private RecordRef contactField;

        private string emailField;

        private RecordRef roleField;

        private string passwordField;

        private string password2Field;

        private bool sendEmailField;

        private bool sendEmailFieldSpecified;

        /// <remarks/>
        public bool giveAccess {
            get {
                return this.giveAccessField;
            }
            set {
                this.giveAccessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool giveAccessSpecified {
            get {
                return this.giveAccessFieldSpecified;
            }
            set {
                this.giveAccessFieldSpecified = value;
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

        /// <remarks/>
        public string password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }

        /// <remarks/>
        public string password2 {
            get {
                return this.password2Field;
            }
            set {
                this.password2Field = value;
            }
        }

        /// <remarks/>
        public bool sendEmail {
            get {
                return this.sendEmailField;
            }
            set {
                this.sendEmailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sendEmailSpecified {
            get {
                return this.sendEmailFieldSpecified;
            }
            set {
                this.sendEmailFieldSpecified = value;
            }
        }
    }
}