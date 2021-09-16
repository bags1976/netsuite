namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public partial class AttachBasicReference : AttachReference {

        private BaseRef attachedRecordField;

        /// <remarks/>
        public BaseRef attachedRecord {
            get {
                return this.attachedRecordField;
            }
            set {
                this.attachedRecordField = value;
            }
        }
    }
}