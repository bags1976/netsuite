namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:support_2021_1.lists.webservices.netsuite.com")]
    public partial class Issue : Record {

        private RecordRef customFormField;

        private string issueNumberField;

        private System.DateTime createdDateField;

        private bool createdDateFieldSpecified;

        private RecordRef issueTypeField;

        private RecordRef productField;

        private RecordRef moduleField;

        private RecordRef itemField;

        private RecordRef productTeamField;

        private RecordRef sourceField;

        private RecordRef reportedByField;

        private RecordRef reproduceField;

        private RecordRef versionBrokenField;

        private RecordRef buildBrokenField;

        private RecordRef versionTargetField;

        private RecordRef buildTargetField;

        private RecordRef versionFixedField;

        private RecordRef buildFixedField;

        private RecordRef severityField;

        private RecordRef priorityField;

        private bool isShowStopperField;

        private bool isShowStopperFieldSpecified;

        private RecordRef assignedField;

        private RecordRef reviewerField;

        private bool isReviewedField;

        private bool isReviewedFieldSpecified;

        private RecordRef issueStatusField;

        private System.DateTime lastModifiedDateField;

        private bool lastModifiedDateFieldSpecified;

        private RecordRef[] issueTagsListField;

        private string issueAbstractField;

        private string newDetailsField;

        private bool isOwnerField;

        private bool isOwnerFieldSpecified;

        private IssueTrackCode trackCodeField;

        private bool trackCodeFieldSpecified;

        private bool emailAssigneeField;

        private bool emailAssigneeFieldSpecified;

        private RecordRef[] emailEmployeesListField;

        private RecordRef[] emailCellsListField;

        private string externalAbstractField;

        private string externalDetailsField;

        private IssueVersionList brokenInVersionListField;

        private IssueVersionList targetVersionListField;

        private IssueVersionList fixedInVersionListField;

        private IssueRelatedIssuesList relatedIssuesListField;

        private CustomFieldRef[] customFieldListField;

        private string internalIdField;

        private string externalIdField;

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
        public string issueNumber {
            get {
                return this.issueNumberField;
            }
            set {
                this.issueNumberField = value;
            }
        }

        /// <remarks/>
        public System.DateTime createdDate {
            get {
                return this.createdDateField;
            }
            set {
                this.createdDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool createdDateSpecified {
            get {
                return this.createdDateFieldSpecified;
            }
            set {
                this.createdDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef issueType {
            get {
                return this.issueTypeField;
            }
            set {
                this.issueTypeField = value;
            }
        }

        /// <remarks/>
        public RecordRef product {
            get {
                return this.productField;
            }
            set {
                this.productField = value;
            }
        }

        /// <remarks/>
        public RecordRef module {
            get {
                return this.moduleField;
            }
            set {
                this.moduleField = value;
            }
        }

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
        public RecordRef productTeam {
            get {
                return this.productTeamField;
            }
            set {
                this.productTeamField = value;
            }
        }

        /// <remarks/>
        public RecordRef source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }

        /// <remarks/>
        public RecordRef reportedBy {
            get {
                return this.reportedByField;
            }
            set {
                this.reportedByField = value;
            }
        }

        /// <remarks/>
        public RecordRef reproduce {
            get {
                return this.reproduceField;
            }
            set {
                this.reproduceField = value;
            }
        }

        /// <remarks/>
        public RecordRef versionBroken {
            get {
                return this.versionBrokenField;
            }
            set {
                this.versionBrokenField = value;
            }
        }

        /// <remarks/>
        public RecordRef buildBroken {
            get {
                return this.buildBrokenField;
            }
            set {
                this.buildBrokenField = value;
            }
        }

        /// <remarks/>
        public RecordRef versionTarget {
            get {
                return this.versionTargetField;
            }
            set {
                this.versionTargetField = value;
            }
        }

        /// <remarks/>
        public RecordRef buildTarget {
            get {
                return this.buildTargetField;
            }
            set {
                this.buildTargetField = value;
            }
        }

        /// <remarks/>
        public RecordRef versionFixed {
            get {
                return this.versionFixedField;
            }
            set {
                this.versionFixedField = value;
            }
        }

        /// <remarks/>
        public RecordRef buildFixed {
            get {
                return this.buildFixedField;
            }
            set {
                this.buildFixedField = value;
            }
        }

        /// <remarks/>
        public RecordRef severity {
            get {
                return this.severityField;
            }
            set {
                this.severityField = value;
            }
        }

        /// <remarks/>
        public RecordRef priority {
            get {
                return this.priorityField;
            }
            set {
                this.priorityField = value;
            }
        }

        /// <remarks/>
        public bool isShowStopper {
            get {
                return this.isShowStopperField;
            }
            set {
                this.isShowStopperField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isShowStopperSpecified {
            get {
                return this.isShowStopperFieldSpecified;
            }
            set {
                this.isShowStopperFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef assigned {
            get {
                return this.assignedField;
            }
            set {
                this.assignedField = value;
            }
        }

        /// <remarks/>
        public RecordRef reviewer {
            get {
                return this.reviewerField;
            }
            set {
                this.reviewerField = value;
            }
        }

        /// <remarks/>
        public bool isReviewed {
            get {
                return this.isReviewedField;
            }
            set {
                this.isReviewedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isReviewedSpecified {
            get {
                return this.isReviewedFieldSpecified;
            }
            set {
                this.isReviewedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef issueStatus {
            get {
                return this.issueStatusField;
            }
            set {
                this.issueStatusField = value;
            }
        }

        /// <remarks/>
        public System.DateTime lastModifiedDate {
            get {
                return this.lastModifiedDateField;
            }
            set {
                this.lastModifiedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lastModifiedDateSpecified {
            get {
                return this.lastModifiedDateFieldSpecified;
            }
            set {
                this.lastModifiedDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recordRef", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public RecordRef[] issueTagsList {
            get {
                return this.issueTagsListField;
            }
            set {
                this.issueTagsListField = value;
            }
        }

        /// <remarks/>
        public string issueAbstract {
            get {
                return this.issueAbstractField;
            }
            set {
                this.issueAbstractField = value;
            }
        }

        /// <remarks/>
        public string newDetails {
            get {
                return this.newDetailsField;
            }
            set {
                this.newDetailsField = value;
            }
        }

        /// <remarks/>
        public bool isOwner {
            get {
                return this.isOwnerField;
            }
            set {
                this.isOwnerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isOwnerSpecified {
            get {
                return this.isOwnerFieldSpecified;
            }
            set {
                this.isOwnerFieldSpecified = value;
            }
        }

        /// <remarks/>
        public IssueTrackCode trackCode {
            get {
                return this.trackCodeField;
            }
            set {
                this.trackCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool trackCodeSpecified {
            get {
                return this.trackCodeFieldSpecified;
            }
            set {
                this.trackCodeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool emailAssignee {
            get {
                return this.emailAssigneeField;
            }
            set {
                this.emailAssigneeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool emailAssigneeSpecified {
            get {
                return this.emailAssigneeFieldSpecified;
            }
            set {
                this.emailAssigneeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("emailEmployees", IsNullable=false)]
        public RecordRef[] emailEmployeesList {
            get {
                return this.emailEmployeesListField;
            }
            set {
                this.emailEmployeesListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recordRef", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public RecordRef[] emailCellsList {
            get {
                return this.emailCellsListField;
            }
            set {
                this.emailCellsListField = value;
            }
        }

        /// <remarks/>
        public string externalAbstract {
            get {
                return this.externalAbstractField;
            }
            set {
                this.externalAbstractField = value;
            }
        }

        /// <remarks/>
        public string externalDetails {
            get {
                return this.externalDetailsField;
            }
            set {
                this.externalDetailsField = value;
            }
        }

        /// <remarks/>
        public IssueVersionList brokenInVersionList {
            get {
                return this.brokenInVersionListField;
            }
            set {
                this.brokenInVersionListField = value;
            }
        }

        /// <remarks/>
        public IssueVersionList targetVersionList {
            get {
                return this.targetVersionListField;
            }
            set {
                this.targetVersionListField = value;
            }
        }

        /// <remarks/>
        public IssueVersionList fixedInVersionList {
            get {
                return this.fixedInVersionListField;
            }
            set {
                this.fixedInVersionListField = value;
            }
        }

        /// <remarks/>
        public IssueRelatedIssuesList relatedIssuesList {
            get {
                return this.relatedIssuesListField;
            }
            set {
                this.relatedIssuesListField = value;
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