namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:customization_2021_1.setup.webservices.netsuite.com")]
    public partial class CustomRecordTypeLinks {

        private RecordRef linkCenterField;

        private RecordRef linkSectionField;

        private string linkLabelField;

        /// <remarks/>
        public RecordRef linkCenter {
            get {
                return this.linkCenterField;
            }
            set {
                this.linkCenterField = value;
            }
        }

        /// <remarks/>
        public RecordRef linkSection {
            get {
                return this.linkSectionField;
            }
            set {
                this.linkSectionField = value;
            }
        }

        /// <remarks/>
        public string linkLabel {
            get {
                return this.linkLabelField;
            }
            set {
                this.linkLabelField = value;
            }
        }
    }
}