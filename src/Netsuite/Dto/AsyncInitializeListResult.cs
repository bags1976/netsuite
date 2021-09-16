namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:messages_2021_1.platform.webservices.netsuite.com")]
    public partial class AsyncInitializeListResult : AsyncResult {

        private ReadResponseList readResponseListField;

        /// <remarks/>
        public ReadResponseList readResponseList {
            get {
                return this.readResponseListField;
            }
            set {
                this.readResponseListField = value;
            }
        }
    }
}