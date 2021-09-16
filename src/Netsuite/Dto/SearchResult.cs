namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public partial class SearchResult {

        private Status statusField;

        private int totalRecordsField;

        private bool totalRecordsFieldSpecified;

        private int pageSizeField;

        private bool pageSizeFieldSpecified;

        private int totalPagesField;

        private bool totalPagesFieldSpecified;

        private int pageIndexField;

        private bool pageIndexFieldSpecified;

        private string searchIdField;

        private Record[] recordListField;

        private SearchRow[] searchRowListField;

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
        public int pageSize {
            get {
                return this.pageSizeField;
            }
            set {
                this.pageSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pageSizeSpecified {
            get {
                return this.pageSizeFieldSpecified;
            }
            set {
                this.pageSizeFieldSpecified = value;
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
        public int pageIndex {
            get {
                return this.pageIndexField;
            }
            set {
                this.pageIndexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pageIndexSpecified {
            get {
                return this.pageIndexFieldSpecified;
            }
            set {
                this.pageIndexFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string searchId {
            get {
                return this.searchIdField;
            }
            set {
                this.searchIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("record", IsNullable=false)]
        public Record[] recordList {
            get {
                return this.recordListField;
            }
            set {
                this.recordListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("searchRow", IsNullable=false)]
        public SearchRow[] searchRowList {
            get {
                return this.searchRowListField;
            }
            set {
                this.searchRowListField = value;
            }
        }
    }
}