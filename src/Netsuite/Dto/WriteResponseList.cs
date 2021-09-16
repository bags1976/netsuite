namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:messages_2021_1.platform.webservices.netsuite.com")]
    public partial class WriteResponseList {

        private Status statusField;

        private WriteResponse[] writeResponseField;

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
        [System.Xml.Serialization.XmlElementAttribute("writeResponse")]
        public WriteResponse[] writeResponse {
            get {
                return this.writeResponseField;
            }
            set {
                this.writeResponseField = value;
            }
        }
    }
}