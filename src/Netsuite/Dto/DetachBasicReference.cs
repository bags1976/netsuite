namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public partial class DetachBasicReference : DetachReference {

        private BaseRef detachedRecordField;

        /// <remarks/>
        public BaseRef detachedRecord {
            get {
                return this.detachedRecordField;
            }
            set {
                this.detachedRecordField = value;
            }
        }
    }
}