namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:communication_2021_1.general.webservices.netsuite.com")]
    public partial class NoteSearchRow : SearchRow {

        private NoteSearchRowBasic basicField;

        private EmployeeSearchRowBasic authorJoinField;

        private PhoneCallSearchRowBasic callJoinField;

        private CampaignSearchRowBasic campaignJoinField;

        private SupportCaseSearchRowBasic caseJoinField;

        private ContactSearchRowBasic contactJoinField;

        private CustomerSearchRowBasic customerJoinField;

        private EmployeeSearchRowBasic employeeJoinField;

        private EntitySearchRowBasic entityJoinField;

        private CalendarEventSearchRowBasic eventJoinField;

        private IssueSearchRowBasic issueJoinField;

        private ItemSearchRowBasic itemJoinField;

        private OpportunitySearchRowBasic opportunityJoinField;

        private OriginatingLeadSearchRowBasic originatingLeadJoinField;

        private PartnerSearchRowBasic partnerJoinField;

        private SolutionSearchRowBasic solutionJoinField;

        private TaskSearchRowBasic taskJoinField;

        private TransactionSearchRowBasic transactionJoinField;

        private EmployeeSearchRowBasic userJoinField;

        private VendorSearchRowBasic vendorJoinField;

        private CustomSearchRowBasic[] customSearchJoinField;

        /// <remarks/>
        public NoteSearchRowBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public EmployeeSearchRowBasic authorJoin {
            get {
                return this.authorJoinField;
            }
            set {
                this.authorJoinField = value;
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
        public CampaignSearchRowBasic campaignJoin {
            get {
                return this.campaignJoinField;
            }
            set {
                this.campaignJoinField = value;
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
        public ContactSearchRowBasic contactJoin {
            get {
                return this.contactJoinField;
            }
            set {
                this.contactJoinField = value;
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
        public EntitySearchRowBasic entityJoin {
            get {
                return this.entityJoinField;
            }
            set {
                this.entityJoinField = value;
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
        public IssueSearchRowBasic issueJoin {
            get {
                return this.issueJoinField;
            }
            set {
                this.issueJoinField = value;
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
        public OpportunitySearchRowBasic opportunityJoin {
            get {
                return this.opportunityJoinField;
            }
            set {
                this.opportunityJoinField = value;
            }
        }

        /// <remarks/>
        public OriginatingLeadSearchRowBasic originatingLeadJoin {
            get {
                return this.originatingLeadJoinField;
            }
            set {
                this.originatingLeadJoinField = value;
            }
        }

        /// <remarks/>
        public PartnerSearchRowBasic partnerJoin {
            get {
                return this.partnerJoinField;
            }
            set {
                this.partnerJoinField = value;
            }
        }

        /// <remarks/>
        public SolutionSearchRowBasic solutionJoin {
            get {
                return this.solutionJoinField;
            }
            set {
                this.solutionJoinField = value;
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