namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sales_2021_1.transactions.webservices.netsuite.com")]
    public partial class OpportunitySearch : SearchRecord {

        private OpportunitySearchBasic basicField;

        private TransactionSearchBasic actualJoinField;

        private PhoneCallSearchBasic callJoinField;

        private CustomerSearchBasic customerJoinField;

        private ContactSearchBasic decisionMakerJoinField;

        private TransactionSearchBasic estimateJoinField;

        private CalendarEventSearchBasic eventJoinField;

        private FileSearchBasic fileJoinField;

        private ItemSearchBasic itemJoinField;

        private CampaignSearchBasic leadSourceJoinField;

        private MessageSearchBasic messagesJoinField;

        private TransactionSearchBasic orderJoinField;

        private OriginatingLeadSearchBasic originatingLeadJoinField;

        private PartnerSearchBasic partnerJoinField;

        private EmployeeSearchBasic salesRepJoinField;

        private TaskSearchBasic taskJoinField;

        private NoteSearchBasic userNotesJoinField;

        private CustomSearchJoin[] customSearchJoinField;

        /// <remarks/>
        public OpportunitySearchBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public TransactionSearchBasic actualJoin {
            get {
                return this.actualJoinField;
            }
            set {
                this.actualJoinField = value;
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
        public CustomerSearchBasic customerJoin {
            get {
                return this.customerJoinField;
            }
            set {
                this.customerJoinField = value;
            }
        }

        /// <remarks/>
        public ContactSearchBasic decisionMakerJoin {
            get {
                return this.decisionMakerJoinField;
            }
            set {
                this.decisionMakerJoinField = value;
            }
        }

        /// <remarks/>
        public TransactionSearchBasic estimateJoin {
            get {
                return this.estimateJoinField;
            }
            set {
                this.estimateJoinField = value;
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
        public FileSearchBasic fileJoin {
            get {
                return this.fileJoinField;
            }
            set {
                this.fileJoinField = value;
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
        public CampaignSearchBasic leadSourceJoin {
            get {
                return this.leadSourceJoinField;
            }
            set {
                this.leadSourceJoinField = value;
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
        public TransactionSearchBasic orderJoin {
            get {
                return this.orderJoinField;
            }
            set {
                this.orderJoinField = value;
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
        public EmployeeSearchBasic salesRepJoin {
            get {
                return this.salesRepJoinField;
            }
            set {
                this.salesRepJoinField = value;
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