namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public partial class ChangePassword {

        private string currentPasswordField;

        private string newPasswordField;

        private string newPassword2Field;

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
        public string newPassword {
            get {
                return this.newPasswordField;
            }
            set {
                this.newPasswordField = value;
            }
        }

        /// <remarks/>
        public string newPassword2 {
            get {
                return this.newPassword2Field;
            }
            set {
                this.newPassword2Field = value;
            }
        }
    }
}