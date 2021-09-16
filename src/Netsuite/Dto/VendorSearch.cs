namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:relationships_2021_1.lists.webservices.netsuite.com")]
    public partial class VendorSearch : SearchRecord {

        private VendorSearchBasic basicField;

        private AccountSearchBasic accountJoinField;

        private CampaignSearchBasic campaignResponseJoinField;

        private ContactSearchBasic contactJoinField;

        private ContactSearchBasic contactPrimaryJoinField;

        private AccountSearchBasic expAccountJoinField;

        private FileSearchBasic fileJoinField;

        private LocationSearchBasic manufacturingLocationsJoinField;

        private MessageSearchBasic messagesJoinField;

        private MessageSearchBasic messagesFromJoinField;

        private MessageSearchBasic messagesToJoinField;

        private MseSubsidiarySearchBasic mseSubsidiaryJoinField;

        private EntityTaxRegistrationSearchBasic taxRegistrationJoinField;

        private EmployeeSearchBasic timeApproverJoinField;

        private TransactionSearchBasic transactionJoinField;

        private EmployeeSearchBasic userJoinField;

        private NoteSearchBasic userNotesJoinField;

        private CustomSearchJoin[] customSearchJoinField;

        /// <remarks/>
        public VendorSearchBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public AccountSearchBasic accountJoin {
            get {
                return this.accountJoinField;
            }
            set {
                this.accountJoinField = value;
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
        public AccountSearchBasic expAccountJoin {
            get {
                return this.expAccountJoinField;
            }
            set {
                this.expAccountJoinField = value;
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
        public LocationSearchBasic manufacturingLocationsJoin {
            get {
                return this.manufacturingLocationsJoinField;
            }
            set {
                this.manufacturingLocationsJoinField = value;
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
        public MseSubsidiarySearchBasic mseSubsidiaryJoin {
            get {
                return this.mseSubsidiaryJoinField;
            }
            set {
                this.mseSubsidiaryJoinField = value;
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
        public EmployeeSearchBasic timeApproverJoin {
            get {
                return this.timeApproverJoinField;
            }
            set {
                this.timeApproverJoinField = value;
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