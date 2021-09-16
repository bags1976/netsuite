namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public partial class GetCustomizationIdResult {

        private Status statusField;

        private int totalRecordsField;

        private bool totalRecordsFieldSpecified;

        private CustomizationRef[] customizationRefListField;

        /// <remarks/>
        public Status status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }

        /// <remarks/>
        public int totalRecords {
            get {
                return this.totalRecordsField;
            }
            set {
                this.totalRecordsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totalRecordsSpecified {
            get {
                return this.totalRecordsFieldSpecified;
            }
            set {
                this.totalRecordsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("customizationRef", IsNullable=false)]
        public CustomizationRef[] customizationRefList {
            get {
                return this.customizationRefListField;
            }
            set {
                this.customizationRefListField = value;
            }
        }
    }
}