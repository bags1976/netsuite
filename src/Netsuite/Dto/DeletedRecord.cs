namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public partial class DeletedRecord {

        private System.DateTime deletedDateField;

        private bool deletedDateFieldSpecified;

        private BaseRef recordField;

        /// <remarks/>
        public System.DateTime deletedDate {
            get {
                return this.deletedDateField;
            }
            set {
                this.deletedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool deletedDateSpecified {
            get {
                return this.deletedDateFieldSpecified;
            }
            set {
                this.deletedDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public BaseRef record {
            get {
                return this.recordField;
            }
            set {
                this.recordField = value;
            }
        }
    }
}