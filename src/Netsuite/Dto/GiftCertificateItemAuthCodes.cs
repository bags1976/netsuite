namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class GiftCertificateItemAuthCodes {

        private string authCodeField;

        private bool usedField;

        private bool usedFieldSpecified;

        /// <remarks/>
        public string authCode {
            get {
                return this.authCodeField;
            }
            set {
                this.authCodeField = value;
            }
        }

        /// <remarks/>
        public bool used {
            get {
                return this.usedField;
            }
            set {
                this.usedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool usedSpecified {
            get {
                return this.usedFieldSpecified;
            }
            set {
                this.usedFieldSpecified = value;
            }
        }
    }
}