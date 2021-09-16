namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:scheduling_2021_1.activities.webservices.netsuite.com")]
    public partial class CalendarEventSearch : SearchRecord {

        private CalendarEventSearchBasic basicField;

        private EntitySearchBasic attendeeJoinField;

        private ContactSearchBasic attendeeContactJoinField;

        private CustomerSearchBasic attendeeCustomerJoinField;

        private SupportCaseSearchBasic caseJoinField;

        private FileSearchBasic fileJoinField;

        private OpportunitySearchBasic opportunityJoinField;

        private OriginatingLeadSearchBasic originatingLeadJoinField;

        private TimeBillSearchBasic timeJoinField;

        private TransactionSearchBasic transactionJoinField;

        private EmployeeSearchBasic userJoinField;

        private NoteSearchBasic userNotesJoinField;

        private CustomSearchJoin[] customSearchJoinField;

        /// <remarks/>
        public CalendarEventSearchBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public EntitySearchBasic attendeeJoin {
            get {
                return this.attendeeJoinField;
            }
            set {
                this.attendeeJoinField = value;
            }
        }

        /// <remarks/>
        public ContactSearchBasic attendeeContactJoin {
            get {
                return this.attendeeContactJoinField;
            }
            set {
                this.attendeeContactJoinField = value;
            }
        }

        /// <remarks/>
        public CustomerSearchBasic attendeeCustomerJoin {
            get {
                return this.attendeeCustomerJoinField;
            }
            set {
                this.attendeeCustomerJoinField = value;
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
        public FileSearchBasic fileJoin {
            get {
                return this.fileJoinField;
            }
            set {
                this.fileJoinField = value;
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
        public TimeBillSearchBasic timeJoin {
            get {
                return this.timeJoinField;
            }
            set {
                this.timeJoinField = value;
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