namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:employees_2021_1.lists.webservices.netsuite.com")]
    public partial class EmployeeSearchRow : SearchRow {

        private EmployeeSearchRowBasic basicField;

        private CampaignSearchRowBasic campaignResponseJoinField;

        private ChargeSearchRowBasic chargeJoinField;

        private DepartmentSearchRowBasic departmentJoinField;

        private FileSearchRowBasic fileJoinField;

        private HcmJobSearchRowBasic hcmJobJoinField;

        private LocationSearchRowBasic locationJoinField;

        private JobSearchRowBasic managedJobJoinField;

        private MessageSearchRowBasic messagesJoinField;

        private MessageSearchRowBasic messagesFromJoinField;

        private MessageSearchRowBasic messagesToJoinField;

        private ResourceAllocationSearchRowBasic resourceAllocationJoinField;

        private SubsidiarySearchRowBasic subsidiaryJoinField;

        private TimeBillSearchRowBasic timeJoinField;

        private TransactionSearchRowBasic transactionJoinField;

        private EmployeeSearchRowBasic userJoinField;

        private NoteSearchRowBasic userNotesJoinField;

        private CustomSearchRowBasic[] customSearchJoinField;

        /// <remarks/>
        public EmployeeSearchRowBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public CampaignSearchRowBasic campaignResponseJoin {
            get {
                return this.campaignResponseJoinField;
            }
            set {
                this.campaignResponseJoinField = value;
            }
        }

        /// <remarks/>
        public ChargeSearchRowBasic chargeJoin {
            get {
                return this.chargeJoinField;
            }
            set {
                this.chargeJoinField = value;
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
        public FileSearchRowBasic fileJoin {
            get {
                return this.fileJoinField;
            }
            set {
                this.fileJoinField = value;
            }
        }

        /// <remarks/>
        public HcmJobSearchRowBasic hcmJobJoin {
            get {
                return this.hcmJobJoinField;
            }
            set {
                this.hcmJobJoinField = value;
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
        public JobSearchRowBasic managedJobJoin {
            get {
                return this.managedJobJoinField;
            }
            set {
                this.managedJobJoinField = value;
            }
        }

        /// <remarks/>
        public MessageSearchRowBasic messagesJoin {
            get {
                return this.messagesJoinField;
            }
            set {
                this.messagesJoinField = value;
            }
        }

        /// <remarks/>
        public MessageSearchRowBasic messagesFromJoin {
            get {
                return this.messagesFromJoinField;
            }
            set {
                this.messagesFromJoinField = value;
            }
        }

        /// <remarks/>
        public MessageSearchRowBasic messagesToJoin {
            get {
                return this.messagesToJoinField;
            }
            set {
                this.messagesToJoinField = value;
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
        public SubsidiarySearchRowBasic subsidiaryJoin {
            get {
                return this.subsidiaryJoinField;
            }
            set {
                this.subsidiaryJoinField = value;
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