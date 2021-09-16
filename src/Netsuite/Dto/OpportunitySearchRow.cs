namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sales_2021_1.transactions.webservices.netsuite.com")]
    public partial class OpportunitySearchRow : SearchRow {

        private OpportunitySearchRowBasic basicField;

        private TransactionSearchRowBasic actualJoinField;

        private PhoneCallSearchRowBasic callJoinField;

        private CustomerSearchRowBasic customerJoinField;

        private ContactSearchRowBasic decisionMakerJoinField;

        private TransactionSearchRowBasic estimateJoinField;

        private CalendarEventSearchRowBasic eventJoinField;

        private FileSearchRowBasic fileJoinField;

        private ItemSearchRowBasic itemJoinField;

        private CampaignSearchRowBasic leadSourceJoinField;

        private MessageSearchRowBasic messagesJoinField;

        private TransactionSearchRowBasic orderJoinField;

        private OriginatingLeadSearchRowBasic originatingLeadJoinField;

        private PartnerSearchRowBasic partnerJoinField;

        private EmployeeSearchRowBasic salesRepJoinField;

        private TaskSearchRowBasic taskJoinField;

        private NoteSearchRowBasic userNotesJoinField;

        private CustomSearchRowBasic[] customSearchJoinField;

        /// <remarks/>
        public OpportunitySearchRowBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public TransactionSearchRowBasic actualJoin {
            get {
                return this.actualJoinField;
            }
            set {
                this.actualJoinField = value;
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
        public CustomerSearchRowBasic customerJoin {
            get {
                return this.customerJoinField;
            }
            set {
                this.customerJoinField = value;
            }
        }

        /// <remarks/>
        public ContactSearchRowBasic decisionMakerJoin {
            get {
                return this.decisionMakerJoinField;
            }
            set {
                this.decisionMakerJoinField = value;
            }
        }

        /// <remarks/>
        public TransactionSearchRowBasic estimateJoin {
            get {
                return this.estimateJoinField;
            }
            set {
                this.estimateJoinField = value;
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
        public FileSearchRowBasic fileJoin {
            get {
                return this.fileJoinField;
            }
            set {
                this.fileJoinField = value;
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
        public CampaignSearchRowBasic leadSourceJoin {
            get {
                return this.leadSourceJoinField;
            }
            set {
                this.leadSourceJoinField = value;
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
        public TransactionSearchRowBasic orderJoin {
            get {
                return this.orderJoinField;
            }
            set {
                this.orderJoinField = value;
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
        public EmployeeSearchRowBasic salesRepJoin {
            get {
                return this.salesRepJoinField;
            }
            set {
                this.salesRepJoinField = value;
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