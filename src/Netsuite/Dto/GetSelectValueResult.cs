namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public partial class GetSelectValueResult {

        private Status statusField;

        private int totalRecordsField;

        private bool totalRecordsFieldSpecified;

        private int totalPagesField;

        private bool totalPagesFieldSpecified;

        private BaseRef[] baseRefListField;

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
        public int totalPages {
            get {
                return this.totalPagesField;
            }
            set {
                this.totalPagesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totalPagesSpecified {
            get {
                return this.totalPagesFieldSpecified;
            }
            set {
                this.totalPagesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("baseRef", IsNullable=false)]
        public BaseRef[] baseRefList {
            get {
                return this.baseRefListField;
            }
            set {
                this.baseRefListField = value;
            }
        }
    }
}