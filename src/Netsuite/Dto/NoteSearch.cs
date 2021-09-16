namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:communication_2021_1.general.webservices.netsuite.com")]
    public partial class NoteSearch : SearchRecord {

        private NoteSearchBasic basicField;

        private EmployeeSearchBasic authorJoinField;

        private PhoneCallSearchBasic callJoinField;

        private CampaignSearchBasic campaignJoinField;

        private SupportCaseSearchBasic caseJoinField;

        private ContactSearchBasic contactJoinField;

        private CustomerSearchBasic customerJoinField;

        private EmployeeSearchBasic employeeJoinField;

        private EntitySearchBasic entityJoinField;

        private CalendarEventSearchBasic eventJoinField;

        private IssueSearchBasic issueJoinField;

        private ItemSearchBasic itemJoinField;

        private OpportunitySearchBasic opportunityJoinField;

        private OriginatingLeadSearchBasic originatingLeadJoinField;

        private PartnerSearchBasic partnerJoinField;

        private SolutionSearchBasic solutionJoinField;

        private TaskSearchBasic taskJoinField;

        private TransactionSearchBasic transactionJoinField;

        private EmployeeSearchBasic userJoinField;

        private VendorSearchBasic vendorJoinField;

        private CustomSearchJoin[] customSearchJoinField;

        /// <remarks/>
        public NoteSearchBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public EmployeeSearchBasic authorJoin {
            get {
                return this.authorJoinField;
            }
            set {
                this.authorJoinField = value;
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
        public CampaignSearchBasic campaignJoin {
            get {
                return this.campaignJoinField;
            }
            set {
                this.campaignJoinField = value;
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
        public ContactSearchBasic contactJoin {
            get {
                return this.contactJoinField;
            }
            set {
                this.contactJoinField = value;
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
        public EntitySearchBasic entityJoin {
            get {
                return this.entityJoinField;
            }
            set {
                this.entityJoinField = value;
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
        public IssueSearchBasic issueJoin {
            get {
                return this.issueJoinField;
            }
            set {
                this.issueJoinField = value;
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
        public OpportunitySearchBasic opportunityJoin {
            get {
                return this.opportunityJoinField;
            }
            set {
                this.opportunityJoinField = value;
            }
        }

        /// <remarks/>
        public OriginatingLeadSearchBasic originatingLeadJoin {
            get {
                return this.originatingLeadJoinField;
            }
            set {
                this.originatingLeadJoinField = value;
            }
        }

        /// <remarks/>
        public PartnerSearchBasic partnerJoin {
            get {
                return this.partnerJoinField;
            }
            set {
                this.partnerJoinField = value;
            }
        }

        /// <remarks/>
        public SolutionSearchBasic solutionJoin {
            get {
                return this.solutionJoinField;
            }
            set {
                this.solutionJoinField = value;
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