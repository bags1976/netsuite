namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:employees_2021_1.lists.webservices.netsuite.com")]
    public partial class EmployeeSearch : SearchRecord {

        private EmployeeSearchBasic basicField;

        private CampaignSearchBasic campaignResponseJoinField;

        private ChargeSearchBasic chargeJoinField;

        private DepartmentSearchBasic departmentJoinField;

        private FileSearchBasic fileJoinField;

        private HcmJobSearchBasic hcmJobJoinField;

        private LocationSearchBasic locationJoinField;

        private JobSearchBasic managedJobJoinField;

        private MessageSearchBasic messagesJoinField;

        private MessageSearchBasic messagesFromJoinField;

        private MessageSearchBasic messagesToJoinField;

        private ResourceAllocationSearchBasic resourceAllocationJoinField;

        private SubsidiarySearchBasic subsidiaryJoinField;

        private TimeBillSearchBasic timeJoinField;

        private TransactionSearchBasic transactionJoinField;

        private EmployeeSearchBasic userJoinField;

        private NoteSearchBasic userNotesJoinField;

        private CustomSearchJoin[] customSearchJoinField;

        /// <remarks/>
        public EmployeeSearchBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public CampaignSearchBasic campaignResponseJoin {
            get {
                return this.campaignResponseJoinField;
            }
            set {
                this.campaignResponseJoinField = value;
            }
        }

        /// <remarks/>
        public ChargeSearchBasic chargeJoin {
            get {
                return this.chargeJoinField;
            }
            set {
                this.chargeJoinField = value;
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
        public FileSearchBasic fileJoin {
            get {
                return this.fileJoinField;
            }
            set {
                this.fileJoinField = value;
            }
        }

        /// <remarks/>
        public HcmJobSearchBasic hcmJobJoin {
            get {
                return this.hcmJobJoinField;
            }
            set {
                this.hcmJobJoinField = value;
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
        public JobSearchBasic managedJobJoin {
            get {
                return this.managedJobJoinField;
            }
            set {
                this.managedJobJoinField = value;
            }
        }

        /// <remarks/>
        public MessageSearchBasic messagesJoin {
            get {
                return this.messagesJoinField;
            }
            set {
                this.messagesJoinField = value;
            }
        }

        /// <remarks/>
        public MessageSearchBasic messagesFromJoin {
            get {
                return this.messagesFromJoinField;
            }
            set {
                this.messagesFromJoinField = value;
            }
        }

        /// <remarks/>
        public MessageSearchBasic messagesToJoin {
            get {
                return this.messagesToJoinField;
            }
            set {
                this.messagesToJoinField = value;
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
        public SubsidiarySearchBasic subsidiaryJoin {
            get {
                return this.subsidiaryJoinField;
            }
            set {
                this.subsidiaryJoinField = value;
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