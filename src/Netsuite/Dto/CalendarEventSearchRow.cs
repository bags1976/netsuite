namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:scheduling_2021_1.activities.webservices.netsuite.com")]
    public partial class CalendarEventSearchRow : SearchRow {

        private CalendarEventSearchRowBasic basicField;

        private EntitySearchRowBasic attendeeJoinField;

        private ContactSearchRowBasic attendeeContactJoinField;

        private CustomerSearchRowBasic attendeeCustomerJoinField;

        private SupportCaseSearchRowBasic caseJoinField;

        private FileSearchRowBasic fileJoinField;

        private OpportunitySearchRowBasic opportunityJoinField;

        private OriginatingLeadSearchRowBasic originatingLeadJoinField;

        private TimeBillSearchRowBasic timeJoinField;

        private TransactionSearchRowBasic transactionJoinField;

        private EmployeeSearchRowBasic userJoinField;

        private NoteSearchRowBasic userNotesJoinField;

        private CustomSearchRowBasic[] customSearchJoinField;

        /// <remarks/>
        public CalendarEventSearchRowBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public EntitySearchRowBasic attendeeJoin {
            get {
                return this.attendeeJoinField;
            }
            set {
                this.attendeeJoinField = value;
            }
        }

        /// <remarks/>
        public ContactSearchRowBasic attendeeContactJoin {
            get {
                return this.attendeeContactJoinField;
            }
            set {
                this.attendeeContactJoinField = value;
            }
        }

        /// <remarks/>
        public CustomerSearchRowBasic attendeeCustomerJoin {
            get {
                return this.attendeeCustomerJoinField;
            }
            set {
                this.attendeeCustomerJoinField = value;
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
        public FileSearchRowBasic fileJoin {
            get {
                return this.fileJoinField;
            }
            set {
                this.fileJoinField = value;
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
        public TimeBillSearchRowBasic timeJoin {
            get {
                return this.timeJoinField;
            }
            set {
                this.timeJoinField = value;
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