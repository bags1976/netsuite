namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public partial class SelectDimensionRef : DimensionRef {

        private ListOrRecordRef valueField;

        /// <remarks/>
        public ListOrRecordRef value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
}