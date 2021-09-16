namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:messages_2021_1.platform.webservices.netsuite.com")]
    public partial class WriteResponse {

        private Status statusField;

        private BaseRef baseRefField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
        public Status status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }

        /// <remarks/>
        public BaseRef baseRef {
            get {
                return this.baseRefField;
            }
            set {
                this.baseRefField = value;
            }
        }
    }
}