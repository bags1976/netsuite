namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:employees_2021_1.transactions.webservices.netsuite.com")]
    public partial class TimeEntrySearchRow : SearchRow {

        private TimeEntrySearchRowBasic basicField;

        private PhoneCallSearchRowBasic callJoinField;

        private SupportCaseSearchRowBasic caseJoinField;

        private ClassificationSearchRowBasic classJoinField;

        private CustomerSearchRowBasic customerJoinField;

        private DepartmentSearchRowBasic departmentJoinField;

        private EmployeeSearchRowBasic employeeJoinField;

        private CalendarEventSearchRowBasic eventJoinField;

        private ItemSearchRowBasic itemJoinField;

        private JobSearchRowBasic jobJoinField;

        private LocationSearchRowBasic locationJoinField;

        private ProjectTaskSearchRowBasic projectTaskJoinField;

        private ProjectTaskAssignmentSearchRowBasic projectTaskAssignmentJoinField;

        private ResourceAllocationSearchRowBasic resourceAllocationJoinField;

        private TaskSearchRowBasic taskJoinField;

        private TimeSheetSearchRowBasic timeSheetJoinField;

        private EmployeeSearchRowBasic userJoinField;

        private VendorSearchRowBasic vendorJoinField;

        private CustomSearchRowBasic[] customSearchJoinField;

        /// <remarks/>
        public TimeEntrySearchRowBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public PhoneCallSearchRowBasic callJoin {
            get {
                return this.callJoinField;
            }
            set {
                this.callJoinField = value;
            }
        }

        /// <remarks/>
        public SupportCaseSearchRowBasic caseJoin {
            get {
                return this.caseJoinField;
            }
            set {
                this.caseJoinField = value;
            }
        }

        /// <remarks/>
        public ClassificationSearchRowBasic classJoin {
            get {
                return this.classJoinField;
            }
            set {
                this.classJoinField = value;
            }
        }

        /// <remarks/>
        public CustomerSearchRowBasic customerJoin {
            get {
                return this.customerJoinField;
            }
            set {
                this.customerJoinField = value;
            }
        }

        /// <remarks/>
        public DepartmentSearchRowBasic departmentJoin {
            get {
                return this.departmentJoinField;
            }
            set {
                this.departmentJoinField = value;
            }
        }

        /// <remarks/>
        public EmployeeSearchRowBasic employeeJoin {
            get {
                return this.employeeJoinField;
            }
            set {
                this.employeeJoinField = value;
            }
        }

        /// <remarks/>
        public CalendarEventSearchRowBasic eventJoin {
            get {
                return this.eventJoinField;
            }
            set {
                this.eventJoinField = value;
            }
        }

        /// <remarks/>
        public ItemSearchRowBasic itemJoin {
            get {
                return this.itemJoinField;
            }
            set {
                this.itemJoinField = value;
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
        public LocationSearchRowBasic locationJoin {
            get {
                return this.locationJoinField;
            }
            set {
                this.locationJoinField = value;
            }
        }

        /// <remarks/>
        public ProjectTaskSearchRowBasic projectTaskJoin {
            get {
                return this.projectTaskJoinField;
            }
            set {
                this.projectTaskJoinField = value;
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
        public TaskSearchRowBasic taskJoin {
            get {
                return this.taskJoinField;
            }
            set {
                this.taskJoinField = value;
            }
        }

        /// <remarks/>
        public TimeSheetSearchRowBasic timeSheetJoin {
            get {
                return this.timeSheetJoinField;
            }
            set {
                this.timeSheetJoinField = value;
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
        public VendorSearchRowBasic vendorJoin {
            get {
                return this.vendorJoinField;
            }
            set {
                this.vendorJoinField = value;
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