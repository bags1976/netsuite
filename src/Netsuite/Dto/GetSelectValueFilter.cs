namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public partial class GetSelectValueFilter {

        private string filterValueField;

        private GetSelectValueFilterOperator operatorField;

        /// <remarks/>
        public string filterValue {
            get {
                return this.filterValueField;
            }
            set {
                this.filterValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public GetSelectValueFilterOperator @operator {
            get {
                return this.operatorField;
            }
            set {
                this.operatorField = value;
            }
        }
    }
}