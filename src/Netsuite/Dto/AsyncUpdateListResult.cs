namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:messages_2021_1.platform.webservices.netsuite.com")]
    public partial class AsyncUpdateListResult : AsyncResult {

        private WriteResponseList writeResponseListField;

        /// <remarks/>
        public WriteResponseList writeResponseList {
            get {
                return this.writeResponseListField;
            }
            set {
                this.writeResponseListField = value;
            }
        }
    }
}