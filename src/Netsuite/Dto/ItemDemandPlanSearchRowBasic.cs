namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class ItemDemandPlanSearchRowBasic : SearchRowBasic {

        private SearchColumnSelectField[] alternateSourceItemField;

        private SearchColumnLongField[] analysisDurationField;

        private SearchColumnDateField[] demandDateField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnSelectField[] itemField;

        private SearchColumnDateField[] lastModifiedDateField;

        private SearchColumnSelectField[] locationField;

        private SearchColumnStringField[] memoField;

        private SearchColumnLongField[] projectionDurationField;

        private SearchColumnStringField[] projectionIntervalField;

        private SearchColumnStringField[] projectionMethodField;

        private SearchColumnDateField[] projectionStartDateField;

        private SearchColumnDoubleField[] quantityField;

        private SearchColumnDoubleField[] quantityUomField;

        private SearchColumnSelectField[] subsidiaryField;

        private SearchColumnSelectField[] unitsField;

        private SearchColumnCustomField[] customFieldListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("alternateSourceItem")]
        public SearchColumnSelectField[] alternateSourceItem {
            get {
                return this.alternateSourceItemField;
            }
            set {
                this.alternateSourceItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("analysisDuration")]
        public SearchColumnLongField[] analysisDuration {
            get {
                return this.analysisDurationField;
            }
            set {
                this.analysisDurationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("demandDate")]
        public SearchColumnDateField[] demandDate {
            get {
                return this.demandDateField;
            }
            set {
                this.demandDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("externalId")]
        public SearchColumnSelectField[] externalId {
            get {
                return this.externalIdField;
            }
            set {
                this.externalIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("internalId")]
        public SearchColumnSelectField[] internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("item")]
        public SearchColumnSelectField[] item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lastModifiedDate")]
        public SearchColumnDateField[] lastModifiedDate {
            get {
                return this.lastModifiedDateField;
            }
            set {
                this.lastModifiedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("location")]
        public SearchColumnSelectField[] location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("memo")]
        public SearchColumnStringField[] memo {
            get {
                return this.memoField;
            }
            set {
                this.memoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("projectionDuration")]
        public SearchColumnLongField[] projectionDuration {
            get {
                return this.projectionDurationField;
            }
            set {
                this.projectionDurationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("projectionInterval")]
        public SearchColumnStringField[] projectionInterval {
            get {
                return this.projectionIntervalField;
            }
            set {
                this.projectionIntervalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("projectionMethod")]
        public SearchColumnStringField[] projectionMethod {
            get {
                return this.projectionMethodField;
            }
            set {
                this.projectionMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("projectionStartDate")]
        public SearchColumnDateField[] projectionStartDate {
            get {
                return this.projectionStartDateField;
            }
            set {
                this.projectionStartDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("quantity")]
        public SearchColumnDoubleField[] quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("quantityUom")]
        public SearchColumnDoubleField[] quantityUom {
            get {
                return this.quantityUomField;
            }
            set {
                this.quantityUomField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("subsidiary")]
        public SearchColumnSelectField[] subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("units")]
        public SearchColumnSelectField[] units {
            get {
                return this.unitsField;
            }
            set {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("customField", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public SearchColumnCustomField[] customFieldList {
            get {
                return this.customFieldListField;
            }
            set {
                this.customFieldListField = value;
            }
        }
    }
}