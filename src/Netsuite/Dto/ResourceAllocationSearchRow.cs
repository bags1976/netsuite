namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:scheduling_2021_1.activities.webservices.netsuite.com")]
    public partial class ResourceAllocationSearchRow : SearchRow {

        private ResourceAllocationSearchRowBasic basicField;

        private CustomerSearchRowBasic customerJoinField;

        private EmployeeSearchRowBasic employeeJoinField;

        private JobSearchRowBasic jobJoinField;

        private ProjectTaskSearchRowBasic projectTaskJoinField;

        private EntitySearchRowBasic requestedByJoinField;

        private EntitySearchRowBasic resourceJoinField;

        private EmployeeSearchRowBasic userJoinField;

        private VendorSearchRowBasic vendorJoinField;

        private CustomSearchRowBasic[] customSearchJoinField;

        /// <remarks/>
        public ResourceAllocationSearchRowBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
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
        public EmployeeSearchRowBasic employeeJoin {
            get {
                return this.employeeJoinField;
            }
            set {
                this.employeeJoinField = value;
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
        public ProjectTaskSearchRowBasic projectTaskJoin {
            get {
                return this.projectTaskJoinField;
            }
            set {
                this.projectTaskJoinField = value;
            }
        }

        /// <remarks/>
        public EntitySearchRowBasic requestedByJoin {
            get {
                return this.requestedByJoinField;
            }
            set {
                this.requestedByJoinField = value;
            }
        }

        /// <remarks/>
        public EntitySearchRowBasic resourceJoin {
            get {
                return this.resourceJoinField;
            }
            set {
                this.resourceJoinField = value;
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