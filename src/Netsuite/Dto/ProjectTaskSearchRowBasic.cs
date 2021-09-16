namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class ProjectTaskSearchRowBasic : SearchRowBasic {

        private SearchColumnDoubleField[] actualWorkField;

        private SearchColumnSelectField[] companyField;

        private SearchColumnEnumSelectField[] constraintTypeField;

        private SearchColumnSelectField[] contactField;

        private SearchColumnDoubleField[] costField;

        private SearchColumnDoubleField[] costBaseField;

        private SearchColumnDoubleField[] costBaseBaselineField;

        private SearchColumnDoubleField[] costBaselineField;

        private SearchColumnDoubleField[] costBaseVarianceField;

        private SearchColumnDoubleField[] costVarianceField;

        private SearchColumnDoubleField[] costVariancePercentField;

        private SearchColumnDateField[] createdDateField;

        private SearchColumnDateField[] endDateField;

        private SearchColumnDateField[] endDateBaselineField;

        private SearchColumnDoubleField[] endDateVarianceField;

        private SearchColumnDoubleField[] estimatedWorkField;

        private SearchColumnDoubleField[] estimatedWorkBaselineField;

        private SearchColumnDoubleField[] estimatedWorkVarianceField;

        private SearchColumnDoubleField[] estimatedWorkVariancePercentField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnDateField[] finishByDateField;

        private SearchColumnLongField[] idField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnBooleanField[] isMilestoneField;

        private SearchColumnBooleanField[] isSummaryTaskField;

        private SearchColumnDateField[] lastModifiedDateField;

        private SearchColumnStringField[] messageField;

        private SearchColumnBooleanField[] nonBillableTaskField;

        private SearchColumnSelectField[] ownerField;

        private SearchColumnSelectField[] parentField;

        private SearchColumnDoubleField[] percentWorkCompleteField;

        private SearchColumnDoubleField[] plannedWorkField;

        private SearchColumnDoubleField[] plannedWorkBaselineField;

        private SearchColumnSelectField[] predecessorField;

        private SearchColumnDoubleField[] predecessorLagDaysField;

        private SearchColumnStringField[] predecessorsField;

        private SearchColumnStringField[] predecessorTypeField;

        private SearchColumnEnumSelectField[] priorityField;

        private SearchColumnDoubleField[] remainingWorkField;

        private SearchColumnDateField[] startDateField;

        private SearchColumnDateField[] startDateBaselineField;

        private SearchColumnDoubleField[] startDateVarianceField;

        private SearchColumnEnumSelectField[] statusField;

        private SearchColumnSelectField[] successorField;

        private SearchColumnStringField[] successorTypeField;

        private SearchColumnStringField[] titleField;

        private SearchColumnCustomField[] customFieldListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("actualWork")]
        public SearchColumnDoubleField[] actualWork {
            get {
                return this.actualWorkField;
            }
            set {
                this.actualWorkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("company")]
        public SearchColumnSelectField[] company {
            get {
                return this.companyField;
            }
            set {
                this.companyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("constraintType")]
        public SearchColumnEnumSelectField[] constraintType {
            get {
                return this.constraintTypeField;
            }
            set {
                this.constraintTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("contact")]
        public SearchColumnSelectField[] contact {
            get {
                return this.contactField;
            }
            set {
                this.contactField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cost")]
        public SearchColumnDoubleField[] cost {
            get {
                return this.costField;
            }
            set {
                this.costField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("costBase")]
        public SearchColumnDoubleField[] costBase {
            get {
                return this.costBaseField;
            }
            set {
                this.costBaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("costBaseBaseline")]
        public SearchColumnDoubleField[] costBaseBaseline {
            get {
                return this.costBaseBaselineField;
            }
            set {
                this.costBaseBaselineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("costBaseline")]
        public SearchColumnDoubleField[] costBaseline {
            get {
                return this.costBaselineField;
            }
            set {
                this.costBaselineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("costBaseVariance")]
        public SearchColumnDoubleField[] costBaseVariance {
            get {
                return this.costBaseVarianceField;
            }
            set {
                this.costBaseVarianceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("costVariance")]
        public SearchColumnDoubleField[] costVariance {
            get {
                return this.costVarianceField;
            }
            set {
                this.costVarianceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("costVariancePercent")]
        public SearchColumnDoubleField[] costVariancePercent {
            get {
                return this.costVariancePercentField;
            }
            set {
                this.costVariancePercentField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("endDateBaseline")]
        public SearchColumnDateField[] endDateBaseline {
            get {
                return this.endDateBaselineField;
            }
            set {
                this.endDateBaselineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("endDateVariance")]
        public SearchColumnDoubleField[] endDateVariance {
            get {
                return this.endDateVarianceField;
            }
            set {
                this.endDateVarianceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("estimatedWork")]
        public SearchColumnDoubleField[] estimatedWork {
            get {
                return this.estimatedWorkField;
            }
            set {
                this.estimatedWorkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("estimatedWorkBaseline")]
        public SearchColumnDoubleField[] estimatedWorkBaseline {
            get {
                return this.estimatedWorkBaselineField;
            }
            set {
                this.estimatedWorkBaselineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("estimatedWorkVariance")]
        public SearchColumnDoubleField[] estimatedWorkVariance {
            get {
                return this.estimatedWorkVarianceField;
            }
            set {
                this.estimatedWorkVarianceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("estimatedWorkVariancePercent")]
        public SearchColumnDoubleField[] estimatedWorkVariancePercent {
            get {
                return this.estimatedWorkVariancePercentField;
            }
            set {
                this.estimatedWorkVariancePercentField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("finishByDate")]
        public SearchColumnDateField[] finishByDate {
            get {
                return this.finishByDateField;
            }
            set {
                this.finishByDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("id")]
        public SearchColumnLongField[] id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("isMilestone")]
        public SearchColumnBooleanField[] isMilestone {
            get {
                return this.isMilestoneField;
            }
            set {
                this.isMilestoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isSummaryTask")]
        public SearchColumnBooleanField[] isSummaryTask {
            get {
                return this.isSummaryTaskField;
            }
            set {
                this.isSummaryTaskField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("message")]
        public SearchColumnStringField[] message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("nonBillableTask")]
        public SearchColumnBooleanField[] nonBillableTask {
            get {
                return this.nonBillableTaskField;
            }
            set {
                this.nonBillableTaskField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("owner")]
        public SearchColumnSelectField[] owner {
            get {
                return this.ownerField;
            }
            set {
                this.ownerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("parent")]
        public SearchColumnSelectField[] parent {
            get {
                return this.parentField;
            }
            set {
                this.parentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("percentWorkComplete")]
        public SearchColumnDoubleField[] percentWorkComplete {
            get {
                return this.percentWorkCompleteField;
            }
            set {
                this.percentWorkCompleteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("plannedWork")]
        public SearchColumnDoubleField[] plannedWork {
            get {
                return this.plannedWorkField;
            }
            set {
                this.plannedWorkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("plannedWorkBaseline")]
        public SearchColumnDoubleField[] plannedWorkBaseline {
            get {
                return this.plannedWorkBaselineField;
            }
            set {
                this.plannedWorkBaselineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("predecessor")]
        public SearchColumnSelectField[] predecessor {
            get {
                return this.predecessorField;
            }
            set {
                this.predecessorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("predecessorLagDays")]
        public SearchColumnDoubleField[] predecessorLagDays {
            get {
                return this.predecessorLagDaysField;
            }
            set {
                this.predecessorLagDaysField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("predecessors")]
        public SearchColumnStringField[] predecessors {
            get {
                return this.predecessorsField;
            }
            set {
                this.predecessorsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("predecessorType")]
        public SearchColumnStringField[] predecessorType {
            get {
                return this.predecessorTypeField;
            }
            set {
                this.predecessorTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("priority")]
        public SearchColumnEnumSelectField[] priority {
            get {
                return this.priorityField;
            }
            set {
                this.priorityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("remainingWork")]
        public SearchColumnDoubleField[] remainingWork {
            get {
                return this.remainingWorkField;
            }
            set {
                this.remainingWorkField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("startDateBaseline")]
        public SearchColumnDateField[] startDateBaseline {
            get {
                return this.startDateBaselineField;
            }
            set {
                this.startDateBaselineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("startDateVariance")]
        public SearchColumnDoubleField[] startDateVariance {
            get {
                return this.startDateVarianceField;
            }
            set {
                this.startDateVarianceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("status")]
        public SearchColumnEnumSelectField[] status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("successor")]
        public SearchColumnSelectField[] successor {
            get {
                return this.successorField;
            }
            set {
                this.successorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("successorType")]
        public SearchColumnStringField[] successorType {
            get {
                return this.successorTypeField;
            }
            set {
                this.successorTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("title")]
        public SearchColumnStringField[] title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
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