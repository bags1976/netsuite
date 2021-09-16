namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:scheduling_2021_1.activities.webservices.netsuite.com")]
    public partial class ResourceAllocationSearch : SearchRecord {

        private ResourceAllocationSearchBasic basicField;

        private CustomerSearchBasic customerJoinField;

        private EmployeeSearchBasic employeeJoinField;

        private JobSearchBasic jobJoinField;

        private ProjectTaskSearchBasic projectTaskJoinField;

        private EntitySearchBasic requestedByJoinField;

        private EntitySearchBasic resourceJoinField;

        private EmployeeSearchBasic userJoinField;

        private VendorSearchBasic vendorJoinField;

        private CustomSearchJoin[] customSearchJoinField;

        /// <remarks/>
        public ResourceAllocationSearchBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
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
        public EmployeeSearchBasic employeeJoin {
            get {
                return this.employeeJoinField;
            }
            set {
                this.employeeJoinField = value;
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
        public ProjectTaskSearchBasic projectTaskJoin {
            get {
                return this.projectTaskJoinField;
            }
            set {
                this.projectTaskJoinField = value;
            }
        }

        /// <remarks/>
        public EntitySearchBasic requestedByJoin {
            get {
                return this.requestedByJoinField;
            }
            set {
                this.requestedByJoinField = value;
            }
        }

        /// <remarks/>
        public EntitySearchBasic resourceJoin {
            get {
                return this.resourceJoinField;
            }
            set {
                this.resourceJoinField = value;
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