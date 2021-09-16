namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:messages_2021_1.platform.webservices.netsuite.com")]
    public partial class SessionResponse {

        private Status statusField;

        private RecordRef userIdField;

        private WsRole[] wsRoleListField;

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
        public RecordRef userId {
            get {
                return this.userIdField;
            }
            set {
                this.userIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
        [System.Xml.Serialization.XmlArrayItemAttribute("wsRole", IsNullable=false)]
        public WsRole[] wsRoleList {
            get {
                return this.wsRoleListField;
            }
            set {
                this.wsRoleListField = value;
            }
        }
    }
}