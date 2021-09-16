namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public partial class GetSavedSearchRecord {

        private SearchRecordType searchTypeField;

        private bool searchTypeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SearchRecordType searchType {
            get {
                return this.searchTypeField;
            }
            set {
                this.searchTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool searchTypeSpecified {
            get {
                return this.searchTypeFieldSpecified;
            }
            set {
                this.searchTypeFieldSpecified = value;
            }
        }
    }
}