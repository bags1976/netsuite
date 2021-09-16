namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:support_2021_1.lists.webservices.netsuite.com")]
    public partial class IssueVersion {

        private bool primaryField;

        private bool primaryFieldSpecified;

        private RecordRef versionField;

        private RecordRef buildField;

        /// <remarks/>
        public bool primary {
            get {
                return this.primaryField;
            }
            set {
                this.primaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool primarySpecified {
            get {
                return this.primaryFieldSpecified;
            }
            set {
                this.primaryFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }

        /// <remarks/>
        public RecordRef build {
            get {
                return this.buildField;
            }
            set {
                this.buildField = value;
            }
        }
    }
}