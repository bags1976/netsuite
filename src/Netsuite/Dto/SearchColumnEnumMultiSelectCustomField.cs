namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public partial class SearchColumnEnumMultiSelectCustomField : SearchColumnCustomField {

        private string[] searchValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("searchValue")]
        public string[] searchValue {
            get {
                return this.searchValueField;
            }
            set {
                this.searchValueField = value;
            }
        }
    }
}