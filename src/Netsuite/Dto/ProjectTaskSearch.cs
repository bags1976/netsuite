namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:scheduling_2021_1.activities.webservices.netsuite.com")]
    public partial class ProjectTaskSearch : SearchRecord {

        private ProjectTaskSearchBasic basicField;

        private JobSearchBasic jobJoinField;

        private ProjectTaskSearchBasic predecessorJoinField;

        private ProjectTaskAssignmentSearchBasic projectTaskAssignmentJoinField;

        private ResourceAllocationSearchBasic resourceAllocationJoinField;

        private ProjectTaskSearchBasic successorJoinField;

        private TimeBillSearchBasic timeJoinField;

        private TransactionSearchBasic transactionJoinField;

        private EmployeeSearchBasic userJoinField;

        private NoteSearchBasic userNotesJoinField;

        private CustomSearchJoin[] customSearchJoinField;

        /// <remarks/>
        public ProjectTaskSearchBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public JobSearchBasic jobJoin {
            get {
                return this.jobJoinField;
            }
            set {
                this.jobJoinField = value;
            }
        }

        /// <remarks/>
        public ProjectTaskSearchBasic predecessorJoin {
            get {
                return this.predecessorJoinField;
            }
            set {
                this.predecessorJoinField = value;
            }
        }

        /// <remarks/>
        public ProjectTaskAssignmentSearchBasic projectTaskAssignmentJoin {
            get {
                return this.projectTaskAssignmentJoinField;
            }
            set {
                this.projectTaskAssignmentJoinField = value;
            }
        }

        /// <remarks/>
        public ResourceAllocationSearchBasic resourceAllocationJoin {
            get {
                return this.resourceAllocationJoinField;
            }
            set {
                this.resourceAllocationJoinField = value;
            }
        }

        /// <remarks/>
        public ProjectTaskSearchBasic successorJoin {
            get {
                return this.successorJoinField;
            }
            set {
                this.successorJoinField = value;
            }
        }

        /// <remarks/>
        public TimeBillSearchBasic timeJoin {
            get {
                return this.timeJoinField;
            }
            set {
                this.timeJoinField = value;
            }
        }

        /// <remarks/>
        public TransactionSearchBasic transactionJoin {
            get {
                return this.transactionJoinField;
            }
            set {
                this.transactionJoinField = value;
            }
        }

        /// <remarks/>
        public EmployeeSearchBasic userJoin {
            get {
                return this.userJoinField;
            }
            set {
                this.userJoinField = value;
            }
        }

        /// <remarks/>
        public NoteSearchBasic userNotesJoin {
            get {
                return this.userNotesJoinField;
            }
            set {
                this.userNotesJoinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("customSearchJoin")]
        public CustomSearchJoin[] customSearchJoin {
            get {
                return this.customSearchJoinField;
            }
            set {
                this.customSearchJoinField = value;
            }
        }
    }
}