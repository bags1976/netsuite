namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class CustomSearchJoin {

        private CustomizationRef customizationRefField;

        private SearchRecordBasic searchRecordBasicField;

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
        public SearchRecordBasic searchRecordBasic {
            get {
                return this.searchRecordBasicField;
            }
            set {
                this.searchRecordBasicField = value;
            }
        }
    }
}