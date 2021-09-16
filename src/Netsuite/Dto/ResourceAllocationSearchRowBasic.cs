namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class ResourceAllocationSearchRowBasic : SearchRowBasic {

        private SearchColumnSelectField[] allocationTypeField;

        private SearchColumnEnumSelectField[] allocationUnitField;

        private SearchColumnEnumSelectField[] approvalStatusField;

        private SearchColumnSelectField[] customerField;

        private SearchColumnDateField[] endDateField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnSelectField[] nextApproverField;

        private SearchColumnStringField[] notesField;

        private SearchColumnDoubleField[] numberHoursField;

        private SearchColumnDoubleField[] percentOfTimeField;

        private SearchColumnSelectField[] projectField;

        private SearchColumnSelectField[] requestedByField;

        private SearchColumnSelectField[] resourceField;

        private SearchColumnDateField[] startDateField;

        private SearchColumnCustomField[] customFieldListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("allocationType")]
        public SearchColumnSelectField[] allocationType {
            get {
                return this.allocationTypeField;
            }
            set {
                this.allocationTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("allocationUnit")]
        public SearchColumnEnumSelectField[] allocationUnit {
            get {
                return this.allocationUnitField;
            }
            set {
                this.allocationUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("approvalStatus")]
        public SearchColumnEnumSelectField[] approvalStatus {
            get {
                return this.approvalStatusField;
            }
            set {
                this.approvalStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("customer")]
        public SearchColumnSelectField[] customer {
            get {
                return this.customerField;
            }
            set {
                this.customerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("endDate")]
        public SearchColumnDateField[] endDate {
            get {
                return this.endDateField;
            }
            set {
                this.endDateField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("nextApprover")]
        public SearchColumnSelectField[] nextApprover {
            get {
                return this.nextApproverField;
            }
            set {
                this.nextApproverField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("notes")]
        public SearchColumnStringField[] notes {
            get {
                return this.notesField;
            }
            set {
                this.notesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("numberHours")]
        public SearchColumnDoubleField[] numberHours {
            get {
                return this.numberHoursField;
            }
            set {
                this.numberHoursField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("percentOfTime")]
        public SearchColumnDoubleField[] percentOfTime {
            get {
                return this.percentOfTimeField;
            }
            set {
                this.percentOfTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("project")]
        public SearchColumnSelectField[] project {
            get {
                return this.projectField;
            }
            set {
                this.projectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("requestedBy")]
        public SearchColumnSelectField[] requestedBy {
            get {
                return this.requestedByField;
            }
            set {
                this.requestedByField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("resource")]
        public SearchColumnSelectField[] resource {
            get {
                return this.resourceField;
            }
            set {
                this.resourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("startDate")]
        public SearchColumnDateField[] startDate {
            get {
                return this.startDateField;
            }
            set {
                this.startDateField = value;
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