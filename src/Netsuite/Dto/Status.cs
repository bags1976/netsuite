namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public partial class Status {

        private StatusDetail[] statusDetailField;

        private bool isSuccessField;

        private bool isSuccessFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("statusDetail")]
        public StatusDetail[] statusDetail {
            get {
                return this.statusDetailField;
            }
            set {
                this.statusDetailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isSuccess {
            get {
                return this.isSuccessField;
            }
            set {
                this.isSuccessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isSuccessSpecified {
            get {
                return this.isSuccessFieldSpecified;
            }
            set {
                this.isSuccessFieldSpecified = value;
            }
        }
    }
}