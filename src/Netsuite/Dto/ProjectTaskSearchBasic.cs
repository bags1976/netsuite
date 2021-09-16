namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class ProjectTaskSearchBasic : SearchRecordBasic {

        private SearchDoubleField actualWorkField;

        private SearchMultiSelectField assigneeField;

        private SearchMultiSelectField companyField;

        private SearchEnumMultiSelectField constraintTypeField;

        private SearchMultiSelectField contactField;

        private SearchDoubleField costField;

        private SearchDoubleField costBaseField;

        private SearchDoubleField costBaseBaselineField;

        private SearchDoubleField costBaselineField;

        private SearchDoubleField costBaseVarianceField;

        private SearchDoubleField costVarianceField;

        private SearchDoubleField costVariancePercentField;

        private SearchDateField createdDateField;

        private SearchDateField endDateField;

        private SearchDateField endDateBaselineField;

        private SearchDoubleField endDateVarianceField;

        private SearchDoubleField estimatedWorkField;

        private SearchDoubleField estimatedWorkBaselineField;

        private SearchDoubleField estimatedWorkVarianceField;

        private SearchDoubleField estimatedWorkVariancePercentField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchDateField finishByDateField;

        private SearchLongField idField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchBooleanField isMilestoneField;

        private SearchBooleanField isSummaryTaskField;

        private SearchDateField lastModifiedDateField;

        private SearchBooleanField nonBillableTaskField;

        private SearchMultiSelectField ownerField;

        private SearchMultiSelectField parentField;

        private SearchDoubleField percentWorkCompleteField;

        private SearchDoubleField plannedWorkField;

        private SearchDoubleField plannedWorkBaselineField;

        private SearchMultiSelectField predecessorField;

        private SearchStringField predecessorsField;

        private SearchEnumMultiSelectField priorityField;

        private SearchDoubleField remainingWorkField;

        private SearchDateField startDateField;

        private SearchDateField startDateBaselineField;

        private SearchDoubleField startDateVarianceField;

        private SearchEnumMultiSelectField statusField;

        private SearchMultiSelectField successorField;

        private SearchStringField titleField;

        private SearchCustomField[] customFieldListField;

        /// <remarks/>
        public SearchDoubleField actualWork {
            get {
                return this.actualWorkField;
            }
            set {
                this.actualWorkField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField assignee {
            get {
                return this.assigneeField;
            }
            set {
                this.assigneeField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField company {
            get {
                return this.companyField;
            }
            set {
                this.companyField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField constraintType {
            get {
                return this.constraintTypeField;
            }
            set {
                this.constraintTypeField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField contact {
            get {
                return this.contactField;
            }
            set {
                this.contactField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField cost {
            get {
                return this.costField;
            }
            set {
                this.costField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField costBase {
            get {
                return this.costBaseField;
            }
            set {
                this.costBaseField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField costBaseBaseline {
            get {
                return this.costBaseBaselineField;
            }
            set {
                this.costBaseBaselineField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField costBaseline {
            get {
                return this.costBaselineField;
            }
            set {
                this.costBaselineField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField costBaseVariance {
            get {
                return this.costBaseVarianceField;
            }
            set {
                this.costBaseVarianceField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField costVariance {
            get {
                return this.costVarianceField;
            }
            set {
                this.costVarianceField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField costVariancePercent {
            get {
                return this.costVariancePercentField;
            }
            set {
                this.costVariancePercentField = value;
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
        public SearchDateField endDate {
            get {
                return this.endDateField;
            }
            set {
                this.endDateField = value;
            }
        }

        /// <remarks/>
        public SearchDateField endDateBaseline {
            get {
                return this.endDateBaselineField;
            }
            set {
                this.endDateBaselineField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField endDateVariance {
            get {
                return this.endDateVarianceField;
            }
            set {
                this.endDateVarianceField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField estimatedWork {
            get {
                return this.estimatedWorkField;
            }
            set {
                this.estimatedWorkField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField estimatedWorkBaseline {
            get {
                return this.estimatedWorkBaselineField;
            }
            set {
                this.estimatedWorkBaselineField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField estimatedWorkVariance {
            get {
                return this.estimatedWorkVarianceField;
            }
            set {
                this.estimatedWorkVarianceField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField estimatedWorkVariancePercent {
            get {
                return this.estimatedWorkVariancePercentField;
            }
            set {
                this.estimatedWorkVariancePercentField = value;
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
        public SearchDateField finishByDate {
            get {
                return this.finishByDateField;
            }
            set {
                this.finishByDateField = value;
            }
        }

        /// <remarks/>
        public SearchLongField id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
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
        public SearchBooleanField isMilestone {
            get {
                return this.isMilestoneField;
            }
            set {
                this.isMilestoneField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isSummaryTask {
            get {
                return this.isSummaryTaskField;
            }
            set {
                this.isSummaryTaskField = value;
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
        public SearchBooleanField nonBillableTask {
            get {
                return this.nonBillableTaskField;
            }
            set {
                this.nonBillableTaskField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField owner {
            get {
                return this.ownerField;
            }
            set {
                this.ownerField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField parent {
            get {
                return this.parentField;
            }
            set {
                this.parentField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField percentWorkComplete {
            get {
                return this.percentWorkCompleteField;
            }
            set {
                this.percentWorkCompleteField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField plannedWork {
            get {
                return this.plannedWorkField;
            }
            set {
                this.plannedWorkField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField plannedWorkBaseline {
            get {
                return this.plannedWorkBaselineField;
            }
            set {
                this.plannedWorkBaselineField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField predecessor {
            get {
                return this.predecessorField;
            }
            set {
                this.predecessorField = value;
            }
        }

        /// <remarks/>
        public SearchStringField predecessors {
            get {
                return this.predecessorsField;
            }
            set {
                this.predecessorsField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField priority {
            get {
                return this.priorityField;
            }
            set {
                this.priorityField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField remainingWork {
            get {
                return this.remainingWorkField;
            }
            set {
                this.remainingWorkField = value;
            }
        }

        /// <remarks/>
        public SearchDateField startDate {
            get {
                return this.startDateField;
            }
            set {
                this.startDateField = value;
            }
        }

        /// <remarks/>
        public SearchDateField startDateBaseline {
            get {
                return this.startDateBaselineField;
            }
            set {
                this.startDateBaselineField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField startDateVariance {
            get {
                return this.startDateVarianceField;
            }
            set {
                this.startDateVarianceField = value;
            }
        }

        /// <remarks/>
        public SearchEnumMultiSelectField status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField successor {
            get {
                return this.successorField;
            }
            set {
                this.successorField = value;
            }
        }

        /// <remarks/>
        public SearchStringField title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
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