namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:scheduling_2021_1.activities.webservices.netsuite.com")]
    public partial class ProjectTaskSearchRow : SearchRow {

        private ProjectTaskSearchRowBasic basicField;

        private JobSearchRowBasic jobJoinField;

        private ProjectTaskSearchRowBasic predecessorJoinField;

        private ProjectTaskAssignmentSearchRowBasic projectTaskAssignmentJoinField;

        private ResourceAllocationSearchRowBasic resourceAllocationJoinField;

        private ProjectTaskSearchRowBasic successorJoinField;

        private TimeBillSearchRowBasic timeJoinField;

        private TransactionSearchRowBasic transactionJoinField;

        private EmployeeSearchRowBasic userJoinField;

        private NoteSearchRowBasic userNotesJoinField;

        private CustomSearchRowBasic[] customSearchJoinField;

        /// <remarks/>
        public ProjectTaskSearchRowBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public JobSearchRowBasic jobJoin {
            get {
                return this.jobJoinField;
            }
            set {
                this.jobJoinField = value;
            }
        }

        /// <remarks/>
        public ProjectTaskSearchRowBasic predecessorJoin {
            get {
                return this.predecessorJoinField;
            }
            set {
                this.predecessorJoinField = value;
            }
        }

        /// <remarks/>
        public ProjectTaskAssignmentSearchRowBasic projectTaskAssignmentJoin {
            get {
                return this.projectTaskAssignmentJoinField;
            }
            set {
                this.projectTaskAssignmentJoinField = value;
            }
        }

        /// <remarks/>
        public ResourceAllocationSearchRowBasic resourceAllocationJoin {
            get {
                return this.resourceAllocationJoinField;
            }
            set {
                this.resourceAllocationJoinField = value;
            }
        }

        /// <remarks/>
        public ProjectTaskSearchRowBasic successorJoin {
            get {
                return this.successorJoinField;
            }
            set {
                this.successorJoinField = value;
            }
        }

        /// <remarks/>
        public TimeBillSearchRowBasic timeJoin {
            get {
                return this.timeJoinField;
            }
            set {
                this.timeJoinField = value;
            }
        }

        /// <remarks/>
        public TransactionSearchRowBasic transactionJoin {
            get {
                return this.transactionJoinField;
            }
            set {
                this.transactionJoinField = value;
            }
        }

        /// <remarks/>
        public EmployeeSearchRowBasic userJoin {
            get {
                return this.userJoinField;
            }
            set {
                this.userJoinField = value;
            }
        }

        /// <remarks/>
        public NoteSearchRowBasic userNotesJoin {
            get {
                return this.userNotesJoinField;
            }
            set {
                this.userNotesJoinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("customSearchJoin")]
        public CustomSearchRowBasic[] customSearchJoin {
            get {
                return this.customSearchJoinField;
            }
            set {
                this.customSearchJoinField = value;
            }
        }
    }
}