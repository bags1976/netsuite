namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class CustomSearchRowBasic {

        private CustomizationRef customizationRefField;

        private SearchRowBasic searchRowBasicField;

        /// <remarks/>
        public CustomizationRef customizationRef {
            get {
                return this.customizationRefField;
            }
            set {
                this.customizationRefField = value;
            }
        }

        /// <remarks/>
        public SearchRowBasic searchRowBasic {
            get {
                return this.searchRowBasicField;
            }
            set {
                this.searchRowBasicField = value;
            }
        }
    }
}