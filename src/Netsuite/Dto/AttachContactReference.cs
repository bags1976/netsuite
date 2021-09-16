namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public partial class AttachContactReference : AttachReference {

        private RecordRef contactField;

        private RecordRef contactRoleField;

        /// <remarks/>
        public RecordRef contact {
            get {
                return this.contactField;
            }
            set {
                this.contactField = value;
            }
        }

        /// <remarks/>
        public RecordRef contactRole {
            get {
                return this.contactRoleField;
            }
            set {
                this.contactRoleField = value;
            }
        }
    }
}