namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class LocationRegions {

        private RecordRef regionField;

        /// <remarks/>
        public RecordRef region {
            get {
                return this.regionField;
            }
            set {
                this.regionField = value;
            }
        }
    }
}