namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:employees_2021_1.transactions.webservices.netsuite.com")]
    public partial class TimeEntrySearch : SearchRecord {

        private TimeEntrySearchBasic basicField;

        private PhoneCallSearchBasic callJoinField;

        private SupportCaseSearchBasic caseJoinField;

        private ClassificationSearchBasic classJoinField;

        private CustomerSearchBasic customerJoinField;

        private DepartmentSearchBasic departmentJoinField;

        private EmployeeSearchBasic employeeJoinField;

        private CalendarEventSearchBasic eventJoinField;

        private ItemSearchBasic itemJoinField;

        private JobSearchBasic jobJoinField;

        private LocationSearchBasic locationJoinField;

        private ProjectTaskSearchBasic projectTaskJoinField;

        private ProjectTaskAssignmentSearchBasic projectTaskAssignmentJoinField;

        private ResourceAllocationSearchBasic resourceAllocationJoinField;

        private TaskSearchBasic taskJoinField;

        private TimeSheetSearchBasic timeSheetJoinField;

        private EmployeeSearchBasic userJoinField;

        private VendorSearchBasic vendorJoinField;

        private CustomSearchJoin[] customSearchJoinField;

        /// <remarks/>
        public TimeEntrySearchBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public PhoneCallSearchBasic callJoin {
            get {
                return this.callJoinField;
            }
            set {
                this.callJoinField = value;
            }
        }

        /// <remarks/>
        public SupportCaseSearchBasic caseJoin {
            get {
                return this.caseJoinField;
            }
            set {
                this.caseJoinField = value;
            }
        }

        /// <remarks/>
        public ClassificationSearchBasic classJoin {
            get {
                return this.classJoinField;
            }
            set {
                this.classJoinField = value;
            }
        }

        /// <remarks/>
        public CustomerSearchBasic customerJoin {
            get {
                return this.customerJoinField;
            }
            set {
                this.customerJoinField = value;
            }
        }

        /// <remarks/>
        public DepartmentSearchBasic departmentJoin {
            get {
                return this.departmentJoinField;
            }
            set {
                this.departmentJoinField = value;
            }
        }

        /// <remarks/>
        public EmployeeSearchBasic employeeJoin {
            get {
                return this.employeeJoinField;
            }
            set {
                this.employeeJoinField = value;
            }
        }

        /// <remarks/>
        public CalendarEventSearchBasic eventJoin {
            get {
                return this.eventJoinField;
            }
            set {
                this.eventJoinField = value;
            }
        }

        /// <remarks/>
        public ItemSearchBasic itemJoin {
            get {
                return this.itemJoinField;
            }
            set {
                this.itemJoinField = value;
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
        public LocationSearchBasic locationJoin {
            get {
                return this.locationJoinField;
            }
            set {
                this.locationJoinField = value;
            }
        }

        /// <remarks/>
        public ProjectTaskSearchBasic projectTaskJoin {
            get {
                return this.projectTaskJoinField;
            }
            set {
                this.projectTaskJoinField = value;
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
        public TaskSearchBasic taskJoin {
            get {
                return this.taskJoinField;
            }
            set {
                this.taskJoinField = value;
            }
        }

        /// <remarks/>
        public TimeSheetSearchBasic timeSheetJoin {
            get {
                return this.timeSheetJoinField;
            }
            set {
                this.timeSheetJoinField = value;
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
        public VendorSearchBasic vendorJoin {
            get {
                return this.vendorJoinField;
            }
            set {
                this.vendorJoinField = value;
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