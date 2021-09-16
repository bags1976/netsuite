namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public partial class GetSelectFilterByFieldValue {

        private string sublistField;

        private string fieldField;

        private string internalIdField;

        /// <remarks/>
        public string sublist {
            get {
                return this.sublistField;
            }
            set {
                this.sublistField = value;
            }
        }

        /// <remarks/>
        public string field {
            get {
                return this.fieldField;
            }
            set {
                this.fieldField = value;
            }
        }

        /// <remarks/>
        public string internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }
    }
}