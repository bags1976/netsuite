namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:scheduling_2021_1.activities.webservices.netsuite.com")]
    public partial class ResourceAllocation : Record {

        private RecordRef requestedbyField;

        private ResourceAllocationApprovalStatus approvalStatusField;

        private bool approvalStatusFieldSpecified;

        private RecordRef nextApproverField;

        private RecordRef allocationResourceField;

        private RecordRef projectField;

        private string notesField;

        private System.DateTime startDateField;

        private bool startDateFieldSpecified;

        private System.DateTime endDateField;

        private bool endDateFieldSpecified;

        private double allocationAmountField;

        private bool allocationAmountFieldSpecified;

        private ResourceAllocationAllocationUnit allocationUnitField;

        private bool allocationUnitFieldSpecified;

        private double numberHoursField;

        private bool numberHoursFieldSpecified;

        private double percentOfTimeField;

        private bool percentOfTimeFieldSpecified;

        private RecordRef allocationTypeField;

        private RecordRef customFormField;

        private CustomFieldRef[] customFieldListField;

        private string internalIdField;

        private string externalIdField;

        /// <remarks/>
        public RecordRef requestedby {
            get {
                return this.requestedbyField;
            }
            set {
                this.requestedbyField = value;
            }
        }

        /// <remarks/>
        public ResourceAllocationApprovalStatus approvalStatus {
            get {
                return this.approvalStatusField;
            }
            set {
                this.approvalStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool approvalStatusSpecified {
            get {
                return this.approvalStatusFieldSpecified;
            }
            set {
                this.approvalStatusFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef nextApprover {
            get {
                return this.nextApproverField;
            }
            set {
                this.nextApproverField = value;
            }
        }

        /// <remarks/>
        public RecordRef allocationResource {
            get {
                return this.allocationResourceField;
            }
            set {
                this.allocationResourceField = value;
            }
        }

        /// <remarks/>
        public RecordRef project {
            get {
                return this.projectField;
            }
            set {
                this.projectField = value;
            }
        }

        /// <remarks/>
        public string notes {
            get {
                return this.notesField;
            }
            set {
                this.notesField = value;
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
        public double allocationAmount {
            get {
                return this.allocationAmountField;
            }
            set {
                this.allocationAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool allocationAmountSpecified {
            get {
                return this.allocationAmountFieldSpecified;
            }
            set {
                this.allocationAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ResourceAllocationAllocationUnit allocationUnit {
            get {
                return this.allocationUnitField;
            }
            set {
                this.allocationUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool allocationUnitSpecified {
            get {
                return this.allocationUnitFieldSpecified;
            }
            set {
                this.allocationUnitFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double numberHours {
            get {
                return this.numberHoursField;
            }
            set {
                this.numberHoursField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numberHoursSpecified {
            get {
                return this.numberHoursFieldSpecified;
            }
            set {
                this.numberHoursFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double percentOfTime {
            get {
                return this.percentOfTimeField;
            }
            set {
                this.percentOfTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool percentOfTimeSpecified {
            get {
                return this.percentOfTimeFieldSpecified;
            }
            set {
                this.percentOfTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef allocationType {
            get {
                return this.allocationTypeField;
            }
            set {
                this.allocationTypeField = value;
            }
        }

        /// <remarks/>
        public RecordRef customForm {
            get {
                return this.customFormField;
            }
            set {
                this.customFormField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("customField", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public CustomFieldRef[] customFieldList {
            get {
                return this.customFieldListField;
            }
            set {
                this.customFieldListField = value;
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