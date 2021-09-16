namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public partial class SearchColumnBooleanField : SearchColumnField {

        private bool searchValueField;

        private bool searchValueFieldSpecified;

        /// <remarks/>
        public bool searchValue {
            get {
                return this.searchValueField;
            }
            set {
                this.searchValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool searchValueSpecified {
            get {
                return this.searchValueFieldSpecified;
            }
            set {
                this.searchValueFieldSpecified = value;
            }
        }
    }
}