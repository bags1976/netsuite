namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:messages_2021_1.platform.webservices.netsuite.com")]
    public partial class AsyncSearchResult : AsyncResult {

        private SearchResult searchResultField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
        public SearchResult searchResult {
            get {
                return this.searchResultField;
            }
            set {
                this.searchResultField = value;
            }
        }
    }
}