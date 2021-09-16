namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class ItemRevision : Record {

        private RecordRef itemField;

        private string nameField;

        private System.DateTime effectiveDateField;

        private bool effectiveDateFieldSpecified;

        private System.DateTime obsoleteDateField;

        private bool obsoleteDateFieldSpecified;

        private string memoField;

        private bool inactiveField;

        private bool inactiveFieldSpecified;

        private string internalIdField;

        private string externalIdField;

        /// <remarks/>
        public RecordRef item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }

        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public System.DateTime effectiveDate {
            get {
                return this.effectiveDateField;
            }
            set {
                this.effectiveDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool effectiveDateSpecified {
            get {
                return this.effectiveDateFieldSpecified;
            }
            set {
                this.effectiveDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime obsoleteDate {
            get {
                return this.obsoleteDateField;
            }
            set {
                this.obsoleteDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool obsoleteDateSpecified {
            get {
                return this.obsoleteDateFieldSpecified;
            }
            set {
                this.obsoleteDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string memo {
            get {
                return this.memoField;
            }
            set {
                this.memoField = value;
            }
        }

        /// <remarks/>
        public bool inactive {
            get {
                return this.inactiveField;
            }
            set {
                this.inactiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool inactiveSpecified {
            get {
                return this.inactiveFieldSpecified;
            }
            set {
                this.inactiveFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string externalId {
            get {
                return this.externalIdField;
            }
            set {
                this.externalIdField = value;
            }
        }
    }
}