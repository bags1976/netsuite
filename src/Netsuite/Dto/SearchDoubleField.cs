namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public partial class SearchDoubleField {

        private double searchValueField;

        private bool searchValueFieldSpecified;

        private double searchValue2Field;

        private bool searchValue2FieldSpecified;

        private SearchDoubleFieldOperator operatorField;

        private bool operatorFieldSpecified;

        /// <remarks/>
        public double searchValue {
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

        /// <remarks/>
        public double searchValue2 {
            get {
                return this.searchValue2Field;
            }
            set {
                this.searchValue2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool searchValue2Specified {
            get {
                return this.searchValue2FieldSpecified;
            }
            set {
                this.searchValue2FieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SearchDoubleFieldOperator @operator {
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