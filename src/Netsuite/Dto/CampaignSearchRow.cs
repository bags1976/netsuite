namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:marketing_2021_1.lists.webservices.netsuite.com")]
    public partial class CampaignSearchRow : SearchRow {

        private CampaignSearchRowBasic basicField;

        private EntitySearchRowBasic campaignRecipientJoinField;

        private FileSearchRowBasic fileJoinField;

        private MessageSearchRowBasic messagesJoinField;

        private OriginatingLeadSearchRowBasic originatingLeadJoinField;

        private PromotionCodeSearchRowBasic promotionCodeJoinField;

        private TransactionSearchRowBasic transactionJoinField;

        private EmployeeSearchRowBasic userJoinField;

        private NoteSearchRowBasic userNotesJoinField;

        private CustomSearchRowBasic[] customSearchJoinField;

        /// <remarks/>
        public CampaignSearchRowBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public EntitySearchRowBasic campaignRecipientJoin {
            get {
                return this.campaignRecipientJoinField;
            }
            set {
                this.campaignRecipientJoinField = value;
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
        public MessageSearchRowBasic messagesJoin {
            get {
                return this.messagesJoinField;
            }
            set {
                this.messagesJoinField = value;
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
        public PromotionCodeSearchRowBasic promotionCodeJoin {
            get {
                return this.promotionCodeJoinField;
            }
            set {
                this.promotionCodeJoinField = value;
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