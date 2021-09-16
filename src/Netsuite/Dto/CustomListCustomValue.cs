namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:customization_2021_1.setup.webservices.netsuite.com")]
    public partial class CustomListCustomValue {

        private string valueField;

        private string abbreviationField;

        private bool isInactiveField;

        private bool isInactiveFieldSpecified;

        private long valueIdField;

        private bool valueIdFieldSpecified;

        private LanguageValueList valueLanguageValueListField;

        /// <remarks/>
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }

        /// <remarks/>
        public string abbreviation {
            get {
                return this.abbreviationField;
            }
            set {
                this.abbreviationField = value;
            }
        }

        /// <remarks/>
        public bool isInactive {
            get {
                return this.isInactiveField;
            }
            set {
                this.isInactiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isInactiveSpecified {
            get {
                return this.isInactiveFieldSpecified;
            }
            set {
                this.isInactiveFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long valueId {
            get {
                return this.valueIdField;
            }
            set {
                this.valueIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valueIdSpecified {
            get {
                return this.valueIdFieldSpecified;
            }
            set {
                this.valueIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        public LanguageValueList valueLanguageValueList {
            get {
                return this.valueLanguageValueListField;
            }
            set {
                this.valueLanguageValueListField = value;
            }
        }
    }
}