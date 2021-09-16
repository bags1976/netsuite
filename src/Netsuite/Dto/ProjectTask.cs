namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:scheduling_2021_1.activities.webservices.netsuite.com")]
    public partial class ProjectTask : Record {

        private RecordRef customFormField;

        private RecordRef eventIdField;

        private double percentTimeCompleteField;

        private bool percentTimeCompleteFieldSpecified;

        private string titleField;

        private RecordRef companyField;

        private RecordRef contactField;

        private RecordRef orderField;

        private RecordRef ownerField;

        private RecordRef parentField;

        private RecordRef priorityField;

        private double estimatedWorkField;

        private bool estimatedWorkFieldSpecified;

        private double estimatedWorkBaselineField;

        private bool estimatedWorkBaselineFieldSpecified;

        private ProjectTaskConstraintType constraintTypeField;

        private bool constraintTypeFieldSpecified;

        private System.DateTime startDateField;

        private bool startDateFieldSpecified;

        private System.DateTime startDateBaselineField;

        private bool startDateBaselineFieldSpecified;

        private System.DateTime endDateField;

        private bool endDateFieldSpecified;

        private System.DateTime finishByDateField;

        private bool finishByDateFieldSpecified;

        private System.DateTime endDateBaselineField;

        private bool endDateBaselineFieldSpecified;

        private Duration actualWorkField;

        private Duration remainingWorkField;

        private string messageField;

        private bool isMilestoneField;

        private bool isMilestoneFieldSpecified;

        private string isOnCriticalPathField;

        private double slackMinutesField;

        private bool slackMinutesFieldSpecified;

        private System.DateTime lateEndField;

        private bool lateEndFieldSpecified;

        private System.DateTime lateStartField;

        private bool lateStartFieldSpecified;

        private ProjectTaskStatus statusField;

        private bool statusFieldSpecified;

        private bool nonBillableTaskField;

        private bool nonBillableTaskFieldSpecified;

        private ProjectTaskAssigneeList assigneeListField;

        private ProjectTaskPredecessorList predecessorListField;

        private ProjectTaskTimeItemList timeItemListField;

        private double plannedWorkField;

        private bool plannedWorkFieldSpecified;

        private double plannedWorkBaselineField;

        private bool plannedWorkBaselineFieldSpecified;

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
        public RecordRef eventId {
            get {
                return this.eventIdField;
            }
            set {
                this.eventIdField = value;
            }
        }

        /// <remarks/>
        public double percentTimeComplete {
            get {
                return this.percentTimeCompleteField;
            }
            set {
                this.percentTimeCompleteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool percentTimeCompleteSpecified {
            get {
                return this.percentTimeCompleteFieldSpecified;
            }
            set {
                this.percentTimeCompleteFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }

        /// <remarks/>
        public RecordRef company {
            get {
                return this.companyField;
            }
            set {
                this.companyField = value;
            }
        }

        /// <remarks/>
        public RecordRef contact {
            get {
                return this.contactField;
            }
            set {
                this.contactField = value;
            }
        }

        /// <remarks/>
        public RecordRef order {
            get {
                return this.orderField;
            }
            set {
                this.orderField = value;
            }
        }

        /// <remarks/>
        public RecordRef owner {
            get {
                return this.ownerField;
            }
            set {
                this.ownerField = value;
            }
        }

        /// <remarks/>
        public RecordRef parent {
            get {
                return this.parentField;
            }
            set {
                this.parentField = value;
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
        public double estimatedWork {
            get {
                return this.estimatedWorkField;
            }
            set {
                this.estimatedWorkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool estimatedWorkSpecified {
            get {
                return this.estimatedWorkFieldSpecified;
            }
            set {
                this.estimatedWorkFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double estimatedWorkBaseline {
            get {
                return this.estimatedWorkBaselineField;
            }
            set {
                this.estimatedWorkBaselineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool estimatedWorkBaselineSpecified {
            get {
                return this.estimatedWorkBaselineFieldSpecified;
            }
            set {
                this.estimatedWorkBaselineFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ProjectTaskConstraintType constraintType {
            get {
                return this.constraintTypeField;
            }
            set {
                this.constraintTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool constraintTypeSpecified {
            get {
                return this.constraintTypeFieldSpecified;
            }
            set {
                this.constraintTypeFieldSpecified = value;
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
        public System.DateTime startDateBaseline {
            get {
                return this.startDateBaselineField;
            }
            set {
                this.startDateBaselineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool startDateBaselineSpecified {
            get {
                return this.startDateBaselineFieldSpecified;
            }
            set {
                this.startDateBaselineFieldSpecified = value;
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
        public System.DateTime finishByDate {
            get {
                return this.finishByDateField;
            }
            set {
                this.finishByDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool finishByDateSpecified {
            get {
                return this.finishByDateFieldSpecified;
            }
            set {
                this.finishByDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime endDateBaseline {
            get {
                return this.endDateBaselineField;
            }
            set {
                this.endDateBaselineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool endDateBaselineSpecified {
            get {
                return this.endDateBaselineFieldSpecified;
            }
            set {
                this.endDateBaselineFieldSpecified = value;
            }
        }

        /// <remarks/>
        public Duration actualWork {
            get {
                return this.actualWorkField;
            }
            set {
                this.actualWorkField = value;
            }
        }

        /// <remarks/>
        public Duration remainingWork {
            get {
                return this.remainingWorkField;
            }
            set {
                this.remainingWorkField = value;
            }
        }

        /// <remarks/>
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }

        /// <remarks/>
        public bool isMilestone {
            get {
                return this.isMilestoneField;
            }
            set {
                this.isMilestoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isMilestoneSpecified {
            get {
                return this.isMilestoneFieldSpecified;
            }
            set {
                this.isMilestoneFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string isOnCriticalPath {
            get {
                return this.isOnCriticalPathField;
            }
            set {
                this.isOnCriticalPathField = value;
            }
        }

        /// <remarks/>
        public double slackMinutes {
            get {
                return this.slackMinutesField;
            }
            set {
                this.slackMinutesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool slackMinutesSpecified {
            get {
                return this.slackMinutesFieldSpecified;
            }
            set {
                this.slackMinutesFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime lateEnd {
            get {
                return this.lateEndField;
            }
            set {
                this.lateEndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lateEndSpecified {
            get {
                return this.lateEndFieldSpecified;
            }
            set {
                this.lateEndFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime lateStart {
            get {
                return this.lateStartField;
            }
            set {
                this.lateStartField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lateStartSpecified {
            get {
                return this.lateStartFieldSpecified;
            }
            set {
                this.lateStartFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ProjectTaskStatus status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool statusSpecified {
            get {
                return this.statusFieldSpecified;
            }
            set {
                this.statusFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool nonBillableTask {
            get {
                return this.nonBillableTaskField;
            }
            set {
                this.nonBillableTaskField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nonBillableTaskSpecified {
            get {
                return this.nonBillableTaskFieldSpecified;
            }
            set {
                this.nonBillableTaskFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ProjectTaskAssigneeList assigneeList {
            get {
                return this.assigneeListField;
            }
            set {
                this.assigneeListField = value;
            }
        }

        /// <remarks/>
        public ProjectTaskPredecessorList predecessorList {
            get {
                return this.predecessorListField;
            }
            set {
                this.predecessorListField = value;
            }
        }

        /// <remarks/>
        public ProjectTaskTimeItemList timeItemList {
            get {
                return this.timeItemListField;
            }
            set {
                this.timeItemListField = value;
            }
        }

        /// <remarks/>
        public double plannedWork {
            get {
                return this.plannedWorkField;
            }
            set {
                this.plannedWorkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool plannedWorkSpecified {
            get {
                return this.plannedWorkFieldSpecified;
            }
            set {
                this.plannedWorkFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double plannedWorkBaseline {
            get {
                return this.plannedWorkBaselineField;
            }
            set {
                this.plannedWorkBaselineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool plannedWorkBaselineSpecified {
            get {
                return this.plannedWorkBaselineFieldSpecified;
            }
            set {
                this.plannedWorkBaselineFieldSpecified = value;
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