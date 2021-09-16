namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:relationships_2021_1.lists.webservices.netsuite.com")]
    public partial class VendorSearchRow : SearchRow {

        private VendorSearchRowBasic basicField;

        private AccountSearchRowBasic accountJoinField;

        private CampaignSearchRowBasic campaignResponseJoinField;

        private ContactSearchRowBasic contactJoinField;

        private ContactSearchRowBasic contactPrimaryJoinField;

        private AccountSearchRowBasic expAccountJoinField;

        private FileSearchRowBasic fileJoinField;

        private LocationSearchRowBasic manufacturingLocationsJoinField;

        private MessageSearchRowBasic messagesJoinField;

        private MessageSearchRowBasic messagesFromJoinField;

        private MessageSearchRowBasic messagesToJoinField;

        private MseSubsidiarySearchRowBasic mseSubsidiaryJoinField;

        private EntityTaxRegistrationSearchRowBasic taxRegistrationJoinField;

        private EmployeeSearchRowBasic timeApproverJoinField;

        private TransactionSearchRowBasic transactionJoinField;

        private EmployeeSearchRowBasic userJoinField;

        private NoteSearchRowBasic userNotesJoinField;

        private CustomSearchRowBasic[] customSearchJoinField;

        /// <remarks/>
        public VendorSearchRowBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public AccountSearchRowBasic accountJoin {
            get {
                return this.accountJoinField;
            }
            set {
                this.accountJoinField = value;
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
        public ContactSearchRowBasic contactJoin {
            get {
                return this.contactJoinField;
            }
            set {
                this.contactJoinField = value;
            }
        }

        /// <remarks/>
        public ContactSearchRowBasic contactPrimaryJoin {
            get {
                return this.contactPrimaryJoinField;
            }
            set {
                this.contactPrimaryJoinField = value;
            }
        }

        /// <remarks/>
        public AccountSearchRowBasic expAccountJoin {
            get {
                return this.expAccountJoinField;
            }
            set {
                this.expAccountJoinField = value;
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
        public LocationSearchRowBasic manufacturingLocationsJoin {
            get {
                return this.manufacturingLocationsJoinField;
            }
            set {
                this.manufacturingLocationsJoinField = value;
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
        public MseSubsidiarySearchRowBasic mseSubsidiaryJoin {
            get {
                return this.mseSubsidiaryJoinField;
            }
            set {
                this.mseSubsidiaryJoinField = value;
            }
        }

        /// <remarks/>
        public EntityTaxRegistrationSearchRowBasic taxRegistrationJoin {
            get {
                return this.taxRegistrationJoinField;
            }
            set {
                this.taxRegistrationJoinField = value;
            }
        }

        /// <remarks/>
        public EmployeeSearchRowBasic timeApproverJoin {
            get {
                return this.timeApproverJoinField;
            }
            set {
                this.timeApproverJoinField = value;
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