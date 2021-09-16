namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public partial class DeletionReason {

        private RecordRef deletionReasonCodeField;

        private string deletionReasonMemoField;

        /// <remarks/>
        public RecordRef deletionReasonCode {
            get {
                return this.deletionReasonCodeField;
            }
            set {
                this.deletionReasonCodeField = value;
            }
        }

        /// <remarks/>
        public string deletionReasonMemo {
            get {
                return this.deletionReasonMemoField;
            }
            set {
                this.deletionReasonMemoField = value;
            }
        }
    }
}