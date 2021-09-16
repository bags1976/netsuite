namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:customization_2021_1.setup.webservices.netsuite.com")]
    public partial class CustomRecordTypeChildren {

        private string childDescrField;

        private RecordRef childTabField;

        /// <remarks/>
        public string childDescr {
            get {
                return this.childDescrField;
            }
            set {
                this.childDescrField = value;
            }
        }

        /// <remarks/>
        public RecordRef childTab {
            get {
                return this.childTabField;
            }
            set {
                this.childTabField = value;
            }
        }
    }
}