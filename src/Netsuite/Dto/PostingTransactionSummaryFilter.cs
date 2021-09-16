namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:core_2021_1.platform.webservices.netsuite.com")]
    public partial class PostingTransactionSummaryFilter {

        private RecordRef[] periodField;

        private RecordRef[] accountField;

        private RecordRef[] parentItemField;

        private RecordRef[] itemField;

        private RecordRef[] entityField;

        private RecordRef[] departmentField;

        private RecordRef[] classField;

        private RecordRef[] locationField;

        private RecordRef[] subsidiaryField;

        private RecordRef[] bookField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recordRef", IsNullable=false)]
        public RecordRef[] period {
            get {
                return this.periodField;
            }
            set {
                this.periodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recordRef", IsNullable=false)]
        public RecordRef[] account {
            get {
                return this.accountField;
            }
            set {
                this.accountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recordRef", IsNullable=false)]
        public RecordRef[] parentItem {
            get {
                return this.parentItemField;
            }
            set {
                this.parentItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recordRef", IsNullable=false)]
        public RecordRef[] item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recordRef", IsNullable=false)]
        public RecordRef[] entity {
            get {
                return this.entityField;
            }
            set {
                this.entityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recordRef", IsNullable=false)]
        public RecordRef[] department {
            get {
                return this.departmentField;
            }
            set {
                this.departmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recordRef", IsNullable=false)]
        public RecordRef[] @class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recordRef", IsNullable=false)]
        public RecordRef[] location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recordRef", IsNullable=false)]
        public RecordRef[] subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recordRef", IsNullable=false)]
        public RecordRef[] book {
            get {
                return this.bookField;
            }
            set {
                this.bookField = value;
            }
        }
    }
}