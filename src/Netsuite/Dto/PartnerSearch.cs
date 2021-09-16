namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:relationships_2021_1.lists.webservices.netsuite.com")]
    public partial class PartnerSearch : SearchRecord {

        private PartnerSearchBasic basicField;

        private CampaignSearchBasic campaignResponseJoinField;

        private ContactSearchBasic contactJoinField;

        private ContactSearchBasic contactPrimaryJoinField;

        private CustomerSearchBasic customerJoinField;

        private FileSearchBasic fileJoinField;

        private MessageSearchBasic messagesJoinField;

        private MessageSearchBasic messagesFromJoinField;

        private MessageSearchBasic messagesToJoinField;

        private OpportunitySearchBasic opportunityJoinField;

        private EntityTaxRegistrationSearchBasic taxRegistrationJoinField;

        private TransactionSearchBasic transactionJoinField;

        private EmployeeSearchBasic userJoinField;

        private NoteSearchBasic userNotesJoinField;

        private CustomSearchJoin[] customSearchJoinField;

        /// <remarks/>
        public PartnerSearchBasic basic {
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
        public ContactSearchBasic contactJoin {
            get {
                return this.contactJoinField;
            }
            set {
                this.contactJoinField = value;
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
        public FileSearchBasic fileJoin {
            get {
                return this.fileJoinField;
            }
            set {
                this.fileJoinField = value;
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
        public OpportunitySearchBasic opportunityJoin {
            get {
                return this.opportunityJoinField;
            }
            set {
                this.opportunityJoinField = value;
            }
        }

        /// <remarks/>
        public EntityTaxRegistrationSearchBasic taxRegistrationJoin {
            get {
                return this.taxRegistrationJoinField;
            }
            set {
                this.taxRegistrationJoinField = value;
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