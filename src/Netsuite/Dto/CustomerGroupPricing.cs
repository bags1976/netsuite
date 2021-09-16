namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:relationships_2021_1.lists.webservices.netsuite.com")]
    public partial class CustomerGroupPricing {

        private RecordRef groupField;

        private RecordRef levelField;

        /// <remarks/>
        public RecordRef group {
            get {
                return this.groupField;
            }
            set {
                this.groupField = value;
            }
        }

        /// <remarks/>
        public RecordRef level {
            get {
                return this.levelField;
            }
            set {
                this.levelField = value;
            }
        }
    }
}