namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class IssueSearchBasic : SearchRecordBasic {

        private SearchLongField ageInMonthsField;

        private SearchMultiSelectField assignedField;

        private SearchMultiSelectField buildBrokenField;

        private SearchStringField buildBrokenNameField;

        private SearchMultiSelectField buildFixedField;

        private SearchStringField buildFixedNameField;

        private SearchMultiSelectField buildTargetField;

        private SearchStringField buildTargetNameField;

        private SearchLongField caseCountField;

        private SearchStringField caseNumberField;

        private SearchDateField closedDateField;

        private SearchDateField createdDateField;

        private SearchDateField dateReleasedField;

        private SearchStringField detailsField;

        private SearchMultiSelectField duplicateOfField;

        private SearchBooleanField eFixField;

        private SearchMultiSelectField employeeOrTeamField;

        private SearchEnumMultiSelectField eventStatusField;

        private SearchStringField externalAbstractField;

        private SearchStringField externalDetailsField;

        private SearchMultiSelectField externalFixedInField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchMultiSelectField externalStatusField;

        private SearchDateField fixedField;

        private SearchMultiSelectField fixedByField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchBooleanField isOwnerField;

        private SearchBooleanField isReviewedField;

        private SearchBooleanField isShowStopperField;

        private SearchStringField issueAbstractField;

        private SearchStringField issueNumberField;

        private SearchMultiSelectField itemField;

        private SearchDateField lastModifiedDateField;

        private SearchMultiSelectField moduleField;

        private SearchLongField numberField;

        private SearchStringField originalFixedInField;

        private SearchMultiSelectField priorityField;

        private SearchMultiSelectField productField;

        private SearchMultiSelectField productTeamField;

        private SearchMultiSelectField relatedIssueField;

        private SearchEnumMultiSelectField relationshipField;

        private SearchStringField relationshipCommentField;

        private SearchMultiSelectField reportedByField;

        private SearchMultiSelectField reproduceField;

        private SearchDateField resolvedField;

        private SearchMultiSelectField resolvedByField;

        private SearchMultiSelectField reviewerField;

        private SearchMultiSelectField severityField;

        private SearchEnumMultiSelectField sourceField;

        private SearchMultiSelectField statusField;

        private SearchMultiSelectField tagsField;

        private SearchBooleanField trackingField;

        private SearchMultiSelectField typeField;

        private SearchMultiSelectField userTypeField;

        private SearchMultiSelectField versionBrokenField;

        private SearchMultiSelectField versionFixedField;

        private SearchMultiSelectField versionTargetField;

        private SearchCustomField[] customFieldListField;

        /// <remarks/>
        public SearchLongField ageInMonths {
            get {
                return this.ageInMonthsField;
            }
            set {
                this.ageInMonthsField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField assigned {
            get {
                return this.assignedField;
            }
            set {
                this.assignedField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField buildBroken {
            get {
                return this.buildBrokenField;
            }
            set {
                this.buildBrokenField = value;
            }
        }

        /// <remarks/>
        public SearchStringField buildBrokenName {
            get {
                return this.buildBrokenNameField;
            }
            set {
                this.buildBrokenNameField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField buildFixed {
            get {
                return this.buildFixedField;
            }
            set {
                this.buildFixedField = value;
            }
        }

        /// <remarks/>
        public SearchStringField buildFixedName {
            get {
                return this.buildFixedNameField;
            }
            set {
                this.buildFixedNameField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField buildTarget {
            get {
                return this.buildTargetField;
            }
            set {
                this.buildTargetField = value;
            }
        }

        /// <remarks/>
        public SearchStringField buildTargetName {
            get {
                return this.buildTargetNameField;
            }
            set {
                this.buildTargetNameField = value;
            }
        }

        /// <remarks/>
        public SearchLongField caseCount {
            get {
                return this.caseCountField;
            }
            set {
                this.caseCountField = value;
            }
        }

        /// <remarks/>
        public SearchStringField caseNumber {
            get {
                return this.caseNumberField;
            }
            set {
                this.caseNumberField = value;
            }
        }

        /// <remarks/>
        public SearchDateField closedDate {
            get {
                return this.closedDateField;
            }
            set {
                this.closedDateField = value;
            }
        }

        /// <remarks/>
        public SearchDateField createdDate {
            get {
                return this.createdDateField;
            }
            set {
                this.createdDateField = value;
            }
        }

        /// <remarks/>
        public SearchDateField dateReleased {
            get {
                return this.dateReleasedField;
            }
            set {
                this.dateReleasedField = value;
            }
        }

        /// <remarks/>
        public SearchStringField details {
            get {
                return this.detailsField;
            }
            set {
                this.detailsField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField duplicateOf {
            get {
                return this.duplicateOfField;
            }
            set {
                this.duplicateOfField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField eFix {
            get {
                return this.eFixField;
            }
            set {
                this.eFixField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField employeeOrTeam {
            get {
                return this.employeeOrTeamField;
            }
            set {
                this.employeeOrTeamField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField eventStatus {
            get {
                return this.eventStatusField;
            }
            set {
                this.eventStatusField = value;
            }
        }

        /// <remarks/>
        public SearchStringField externalAbstract {
            get {
                return this.externalAbstractField;
            }
            set {
                this.externalAbstractField = value;
            }
        }

        /// <remarks/>
        public SearchStringField externalDetails {
            get {
                return this.externalDetailsField;
            }
            set {
                this.externalDetailsField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField externalFixedIn {
            get {
                return this.externalFixedInField;
            }
            set {
                this.externalFixedInField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField externalId {
            get {
                return this.externalIdField;
            }
            set {
                this.externalIdField = value;
            }
        }

        /// <remarks/>
        public SearchStringField externalIdString {
            get {
                return this.externalIdStringField;
            }
            set {
                this.externalIdStringField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField externalStatus {
            get {
                return this.externalStatusField;
            }
            set {
                this.externalStatusField = value;
            }
        }

        /// <remarks/>
        public SearchDateField @fixed {
            get {
                return this.fixedField;
            }
            set {
                this.fixedField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField fixedBy {
            get {
                return this.fixedByField;
            }
            set {
                this.fixedByField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }

        /// <remarks/>
        public SearchLongField internalIdNumber {
            get {
                return this.internalIdNumberField;
            }
            set {
                this.internalIdNumberField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isOwner {
            get {
                return this.isOwnerField;
            }
            set {
                this.isOwnerField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isReviewed {
            get {
                return this.isReviewedField;
            }
            set {
                this.isReviewedField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isShowStopper {
            get {
                return this.isShowStopperField;
            }
            set {
                this.isShowStopperField = value;
            }
        }

        /// <remarks/>
        public SearchStringField issueAbstract {
            get {
                return this.issueAbstractField;
            }
            set {
                this.issueAbstractField = value;
            }
        }

        /// <remarks/>
        public SearchStringField issueNumber {
            get {
                return this.issueNumberField;
            }
            set {
                this.issueNumberField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }

        /// <remarks/>
        public SearchDateField lastModifiedDate {
            get {
                return this.lastModifiedDateField;
            }
            set {
                this.lastModifiedDateField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField module {
            get {
                return this.moduleField;
            }
            set {
                this.moduleField = value;
            }
        }

        /// <remarks/>
        public SearchLongField number {
            get {
                return this.numberField;
            }
            set {
                this.numberField = value;
            }
        }

        /// <remarks/>
        public SearchStringField originalFixedIn {
            get {
                return this.originalFixedInField;
            }
            set {
                this.originalFixedInField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField priority {
            get {
                return this.priorityField;
            }
            set {
                this.priorityField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField product {
            get {
                return this.productField;
            }
            set {
                this.productField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField productTeam {
            get {
                return this.productTeamField;
            }
            set {
                this.productTeamField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField relatedIssue {
            get {
                return this.relatedIssueField;
            }
            set {
                this.relatedIssueField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField relationship {
            get {
                return this.relationshipField;
            }
            set {
                this.relationshipField = value;
            }
        }

        /// <remarks/>
        public SearchStringField relationshipComment {
            get {
                return this.relationshipCommentField;
            }
            set {
                this.relationshipCommentField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField reportedBy {
            get {
                return this.reportedByField;
            }
            set {
                this.reportedByField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField reproduce {
            get {
                return this.reproduceField;
            }
            set {
                this.reproduceField = value;
            }
        }

        /// <remarks/>
        public SearchDateField resolved {
            get {
                return this.resolvedField;
            }
            set {
                this.resolvedField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField resolvedBy {
            get {
                return this.resolvedByField;
            }
            set {
                this.resolvedByField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField reviewer {
            get {
                return this.reviewerField;
            }
            set {
                this.reviewerField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField severity {
            get {
                return this.severityField;
            }
            set {
                this.severityField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField tags {
            get {
                return this.tagsField;
            }
            set {
                this.tagsField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField tracking {
            get {
                return this.trackingField;
            }
            set {
                this.trackingField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField userType {
            get {
                return this.userTypeField;
            }
            set {
                this.userTypeField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField versionBroken {
            get {
                return this.versionBrokenField;
            }
            set {
                this.versionBrokenField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField versionFixed {
            get {
                return this.versionFixedField;
            }
            set {
                this.versionFixedField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField versionTarget {
            get {
                return this.versionTargetField;
            }
            set {
                this.versionTargetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("customField", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public SearchCustomField[] customFieldList {
            get {
                return this.customFieldListField;
            }
            set {
                this.customFieldListField = value;
            }
        }
    }
}