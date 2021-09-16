namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class IssueSearchRowBasic : SearchRowBasic {

        private SearchColumnLongField[] ageInMonthsField;

        private SearchColumnSelectField[] assignedField;

        private SearchColumnSelectField[] buildBrokenField;

        private SearchColumnSelectField[] buildFixedField;

        private SearchColumnSelectField[] buildTargetField;

        private SearchColumnLongField[] caseCountField;

        private SearchColumnStringField[] caseNumberField;

        private SearchColumnDateField[] closedDateField;

        private SearchColumnDateField[] createdDateField;

        private SearchColumnDateField[] dateReleasedField;

        private SearchColumnSelectField[] duplicateOfField;

        private SearchColumnSelectField[] employeeOrTeamField;

        private SearchColumnEnumSelectField[] eventStatusField;

        private SearchColumnStringField[] externalAbstractField;

        private SearchColumnStringField[] externalDetailsField;

        private SearchColumnStringField[] externalFixedInField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnSelectField[] externalStatusField;

        private SearchColumnDateField[] fixedField;

        private SearchColumnSelectField[] fixedByField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnBooleanField[] isOwnerField;

        private SearchColumnBooleanField[] isReviewedField;

        private SearchColumnBooleanField[] isShowStopperField;

        private SearchColumnStringField[] issueAbstractField;

        private SearchColumnSelectField[] issueStatusField;

        private SearchColumnSelectField[] itemField;

        private SearchColumnDateField[] lastModifiedDateField;

        private SearchColumnStringField[] moduleField;

        private SearchColumnStringField[] numberField;

        private SearchColumnStringField[] originalFixedInField;

        private SearchColumnSelectField[] priorityField;

        private SearchColumnSelectField[] productField;

        private SearchColumnSelectField[] productTeamField;

        private SearchColumnSelectField[] relatedIssueField;

        private SearchColumnEnumSelectField[] relationshipField;

        private SearchColumnStringField[] relationshipCommentField;

        private SearchColumnSelectField[] reportedByField;

        private SearchColumnSelectField[] reproduceField;

        private SearchColumnDateField[] resolvedField;

        private SearchColumnSelectField[] resolvedByField;

        private SearchColumnSelectField[] reviewerField;

        private SearchColumnSelectField[] severityField;

        private SearchColumnEnumSelectField[] sourceField;

        private SearchColumnSelectField[] tagsField;

        private SearchColumnStringField[] typeField;

        private SearchColumnSelectField[] userTypeField;

        private SearchColumnSelectField[] versionBrokenField;

        private SearchColumnSelectField[] versionFixedField;

        private SearchColumnSelectField[] versionTargetField;

        private SearchColumnCustomField[] customFieldListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ageInMonths")]
        public SearchColumnLongField[] ageInMonths {
            get {
                return this.ageInMonthsField;
            }
            set {
                this.ageInMonthsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("assigned")]
        public SearchColumnSelectField[] assigned {
            get {
                return this.assignedField;
            }
            set {
                this.assignedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("buildBroken")]
        public SearchColumnSelectField[] buildBroken {
            get {
                return this.buildBrokenField;
            }
            set {
                this.buildBrokenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("buildFixed")]
        public SearchColumnSelectField[] buildFixed {
            get {
                return this.buildFixedField;
            }
            set {
                this.buildFixedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("buildTarget")]
        public SearchColumnSelectField[] buildTarget {
            get {
                return this.buildTargetField;
            }
            set {
                this.buildTargetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("caseCount")]
        public SearchColumnLongField[] caseCount {
            get {
                return this.caseCountField;
            }
            set {
                this.caseCountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("caseNumber")]
        public SearchColumnStringField[] caseNumber {
            get {
                return this.caseNumberField;
            }
            set {
                this.caseNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("closedDate")]
        public SearchColumnDateField[] closedDate {
            get {
                return this.closedDateField;
            }
            set {
                this.closedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("createdDate")]
        public SearchColumnDateField[] createdDate {
            get {
                return this.createdDateField;
            }
            set {
                this.createdDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dateReleased")]
        public SearchColumnDateField[] dateReleased {
            get {
                return this.dateReleasedField;
            }
            set {
                this.dateReleasedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("duplicateOf")]
        public SearchColumnSelectField[] duplicateOf {
            get {
                return this.duplicateOfField;
            }
            set {
                this.duplicateOfField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("employeeOrTeam")]
        public SearchColumnSelectField[] employeeOrTeam {
            get {
                return this.employeeOrTeamField;
            }
            set {
                this.employeeOrTeamField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("eventStatus")]
        public SearchColumnEnumSelectField[] eventStatus {
            get {
                return this.eventStatusField;
            }
            set {
                this.eventStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("externalAbstract")]
        public SearchColumnStringField[] externalAbstract {
            get {
                return this.externalAbstractField;
            }
            set {
                this.externalAbstractField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("externalDetails")]
        public SearchColumnStringField[] externalDetails {
            get {
                return this.externalDetailsField;
            }
            set {
                this.externalDetailsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("externalFixedIn")]
        public SearchColumnStringField[] externalFixedIn {
            get {
                return this.externalFixedInField;
            }
            set {
                this.externalFixedInField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("externalStatus")]
        public SearchColumnSelectField[] externalStatus {
            get {
                return this.externalStatusField;
            }
            set {
                this.externalStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fixed")]
        public SearchColumnDateField[] @fixed {
            get {
                return this.fixedField;
            }
            set {
                this.fixedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fixedBy")]
        public SearchColumnSelectField[] fixedBy {
            get {
                return this.fixedByField;
            }
            set {
                this.fixedByField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("isOwner")]
        public SearchColumnBooleanField[] isOwner {
            get {
                return this.isOwnerField;
            }
            set {
                this.isOwnerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isReviewed")]
        public SearchColumnBooleanField[] isReviewed {
            get {
                return this.isReviewedField;
            }
            set {
                this.isReviewedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isShowStopper")]
        public SearchColumnBooleanField[] isShowStopper {
            get {
                return this.isShowStopperField;
            }
            set {
                this.isShowStopperField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("issueAbstract")]
        public SearchColumnStringField[] issueAbstract {
            get {
                return this.issueAbstractField;
            }
            set {
                this.issueAbstractField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("issueStatus")]
        public SearchColumnSelectField[] issueStatus {
            get {
                return this.issueStatusField;
            }
            set {
                this.issueStatusField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("module")]
        public SearchColumnStringField[] module {
            get {
                return this.moduleField;
            }
            set {
                this.moduleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("number")]
        public SearchColumnStringField[] number {
            get {
                return this.numberField;
            }
            set {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("originalFixedIn")]
        public SearchColumnStringField[] originalFixedIn {
            get {
                return this.originalFixedInField;
            }
            set {
                this.originalFixedInField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("priority")]
        public SearchColumnSelectField[] priority {
            get {
                return this.priorityField;
            }
            set {
                this.priorityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("product")]
        public SearchColumnSelectField[] product {
            get {
                return this.productField;
            }
            set {
                this.productField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("productTeam")]
        public SearchColumnSelectField[] productTeam {
            get {
                return this.productTeamField;
            }
            set {
                this.productTeamField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("relatedIssue")]
        public SearchColumnSelectField[] relatedIssue {
            get {
                return this.relatedIssueField;
            }
            set {
                this.relatedIssueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("relationship")]
        public SearchColumnEnumSelectField[] relationship {
            get {
                return this.relationshipField;
            }
            set {
                this.relationshipField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("relationshipComment")]
        public SearchColumnStringField[] relationshipComment {
            get {
                return this.relationshipCommentField;
            }
            set {
                this.relationshipCommentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("reportedBy")]
        public SearchColumnSelectField[] reportedBy {
            get {
                return this.reportedByField;
            }
            set {
                this.reportedByField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("reproduce")]
        public SearchColumnSelectField[] reproduce {
            get {
                return this.reproduceField;
            }
            set {
                this.reproduceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("resolved")]
        public SearchColumnDateField[] resolved {
            get {
                return this.resolvedField;
            }
            set {
                this.resolvedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("resolvedBy")]
        public SearchColumnSelectField[] resolvedBy {
            get {
                return this.resolvedByField;
            }
            set {
                this.resolvedByField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("reviewer")]
        public SearchColumnSelectField[] reviewer {
            get {
                return this.reviewerField;
            }
            set {
                this.reviewerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("severity")]
        public SearchColumnSelectField[] severity {
            get {
                return this.severityField;
            }
            set {
                this.severityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("source")]
        public SearchColumnEnumSelectField[] source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tags")]
        public SearchColumnSelectField[] tags {
            get {
                return this.tagsField;
            }
            set {
                this.tagsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("type")]
        public SearchColumnStringField[] type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("userType")]
        public SearchColumnSelectField[] userType {
            get {
                return this.userTypeField;
            }
            set {
                this.userTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("versionBroken")]
        public SearchColumnSelectField[] versionBroken {
            get {
                return this.versionBrokenField;
            }
            set {
                this.versionBrokenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("versionFixed")]
        public SearchColumnSelectField[] versionFixed {
            get {
                return this.versionFixedField;
            }
            set {
                this.versionFixedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("versionTarget")]
        public SearchColumnSelectField[] versionTarget {
            get {
                return this.versionTargetField;
            }
            set {
                this.versionTargetField = value;
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