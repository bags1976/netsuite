namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:relationships_2021_1.lists.webservices.netsuite.com")]
    public partial class JobSearchRow : SearchRow {

        private JobSearchRowBasic basicField;

        private BillingAccountSearchRowBasic billingAccountJoinField;

        private BillingScheduleSearchRowBasic billingScheduleJoinField;

        private ContactSearchRowBasic contactPrimaryJoinField;

        private CustomerSearchRowBasic customerJoinField;

        private EmployeeSearchRowBasic projectManagerJoinField;

        private ProjectTaskSearchRowBasic projectTaskJoinField;

        private ResourceAllocationSearchRowBasic resourceAllocationJoinField;

        private TaskSearchRowBasic taskJoinField;

        private TimeBillSearchRowBasic timeJoinField;

        private CustomSearchRowBasic[] customSearchJoinField;

        /// <remarks/>
        public JobSearchRowBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public BillingAccountSearchRowBasic billingAccountJoin {
            get {
                return this.billingAccountJoinField;
            }
            set {
                this.billingAccountJoinField = value;
            }
        }

        /// <remarks/>
        public BillingScheduleSearchRowBasic billingScheduleJoin {
            get {
                return this.billingScheduleJoinField;
            }
            set {
                this.billingScheduleJoinField = value;
            }
        }

        /// <remarks/>
        public ContactSearchRowBasic contactPrimaryJoin {
            get {
                return this.contactPrimaryJoinField;
            }
            set {
                this.contactPrimaryJoinField = value;
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
        public EmployeeSearchRowBasic projectManagerJoin {
            get {
                return this.projectManagerJoinField;
            }
            set {
                this.projectManagerJoinField = value;
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
        public TimeBillSearchRowBasic timeJoin {
            get {
                return this.timeJoinField;
            }
            set {
                this.timeJoinField = value;
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