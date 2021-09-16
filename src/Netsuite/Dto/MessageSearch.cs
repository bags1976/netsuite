namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:communication_2021_1.general.webservices.netsuite.com")]
    public partial class MessageSearch : SearchRecord {

        private MessageSearchBasic basicField;

        private FileSearchBasic attachmentsJoinField;

        private EntitySearchBasic authorJoinField;

        private CampaignSearchBasic campaignJoinField;

        private SupportCaseSearchBasic caseJoinField;

        private ContactSearchBasic contactJoinField;

        private CustomerSearchBasic customerJoinField;

        private EmployeeSearchBasic employeeJoinField;

        private EntitySearchBasic entityJoinField;

        private OpportunitySearchBasic opportunityJoinField;

        private OriginatingLeadSearchBasic originatingLeadJoinField;

        private PartnerSearchBasic partnerJoinField;

        private EntitySearchBasic recipientJoinField;

        private TransactionSearchBasic transactionJoinField;

        private EmployeeSearchBasic userJoinField;

        private VendorSearchBasic vendorJoinField;

        /// <remarks/>
        public MessageSearchBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public FileSearchBasic attachmentsJoin {
            get {
                return this.attachmentsJoinField;
            }
            set {
                this.attachmentsJoinField = value;
            }
        }

        /// <remarks/>
        public EntitySearchBasic authorJoin {
            get {
                return this.authorJoinField;
            }
            set {
                this.authorJoinField = value;
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
        public EntitySearchBasic recipientJoin {
            get {
                return this.recipientJoinField;
            }
            set {
                this.recipientJoinField = value;
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
    }
}