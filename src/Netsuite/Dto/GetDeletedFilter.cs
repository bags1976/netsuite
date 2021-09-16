namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public partial class GetDeletedFilter {

        private SearchDateField deletedDateField;

        private SearchEnumMultiSelectField typeField;

        private SearchStringField scriptIdField;

        /// <remarks/>
        public SearchDateField deletedDate {
            get {
                return this.deletedDateField;
            }
            set {
                this.deletedDateField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public SearchStringField scriptId {
            get {
                return this.scriptIdField;
            }
            set {
                this.scriptIdField = value;
            }
        }
    }
}