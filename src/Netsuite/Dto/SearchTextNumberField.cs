using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public partial class SearchTextNumberField {

        private string searchValueField;

        private string searchValue2Field;

        private SearchTextNumberFieldOperator operatorField;

        private bool operatorFieldSpecified;

        /// <remarks/>
        public string searchValue {
            get {
                return this.searchValueField;
            }
            set {
                this.searchValueField = value;
            }
        }

        /// <remarks/>
        public string searchValue2 {
            get {
                return this.searchValue2Field;
            }
            set {
                this.searchValue2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SearchTextNumberFieldOperator @operator {
            get {
                return this.operatorField;
            }
            set {
                this.operatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool operatorSpecified {
            get {
                return this.operatorFieldSpecified;
            }
            set {
                this.operatorFieldSpecified = value;
            }
        }
    }
}