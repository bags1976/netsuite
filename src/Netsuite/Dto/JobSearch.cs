namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:relationships_2021_1.lists.webservices.netsuite.com")]
    public partial class JobSearch : SearchRecord {

        private JobSearchBasic basicField;

        private BillingAccountSearchBasic billingAccountJoinField;

        private BillingScheduleSearchBasic billingScheduleJoinField;

        private ContactSearchBasic contactPrimaryJoinField;

        private CustomerSearchBasic customerJoinField;

        private EmployeeSearchBasic projectManagerJoinField;

        private ProjectTaskSearchBasic projectTaskJoinField;

        private ResourceAllocationSearchBasic resourceAllocationJoinField;

        private TaskSearchBasic taskJoinField;

        private TimeBillSearchBasic timeJoinField;

        private CustomSearchJoin[] customSearchJoinField;

        /// <remarks/>
        public JobSearchBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public BillingAccountSearchBasic billingAccountJoin {
            get {
                return this.billingAccountJoinField;
            }
            set {
                this.billingAccountJoinField = value;
            }
        }

        /// <remarks/>
        public BillingScheduleSearchBasic billingScheduleJoin {
            get {
                return this.billingScheduleJoinField;
            }
            set {
                this.billingScheduleJoinField = value;
            }
        }

        /// <remarks/>
        public ContactSearchBasic contactPrimaryJoin {
            get {
                return this.contactPrimaryJoinField;
            }
            set {
                this.contactPrimaryJoinField = value;
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
        public EmployeeSearchBasic projectManagerJoin {
            get {
                return this.projectManagerJoinField;
            }
            set {
                this.projectManagerJoinField = value;
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
        public TimeBillSearchBasic timeJoin {
            get {
                return this.timeJoinField;
            }
            set {
                this.timeJoinField = value;
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