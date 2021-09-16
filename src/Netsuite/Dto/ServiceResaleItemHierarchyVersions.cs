namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class ServiceResaleItemHierarchyVersions {

        private bool isIncludedField;

        private bool isIncludedFieldSpecified;

        private RecordRef hierarchyVersionField;

        private System.DateTime startDateField;

        private bool startDateFieldSpecified;

        private System.DateTime endDateField;

        private bool endDateFieldSpecified;

        private RecordRef hierarchyNodeField;

        /// <remarks/>
        public bool isIncluded {
            get {
                return this.isIncludedField;
            }
            set {
                this.isIncludedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isIncludedSpecified {
            get {
                return this.isIncludedFieldSpecified;
            }
            set {
                this.isIncludedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef hierarchyVersion {
            get {
                return this.hierarchyVersionField;
            }
            set {
                this.hierarchyVersionField = value;
            }
        }

        /// <remarks/>
        public System.DateTime startDate {
            get {
                return this.startDateField;
            }
            set {
                this.startDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool startDateSpecified {
            get {
                return this.startDateFieldSpecified;
            }
            set {
                this.startDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime endDate {
            get {
                return this.endDateField;
            }
            set {
                this.endDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool endDateSpecified {
            get {
                return this.endDateFieldSpecified;
            }
            set {
                this.endDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef hierarchyNode {
            get {
                return this.hierarchyNodeField;
            }
            set {
                this.hierarchyNodeField = value;
            }
        }
    }
}