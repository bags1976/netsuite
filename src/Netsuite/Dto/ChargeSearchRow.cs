namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:customers_2021_1.transactions.webservices.netsuite.com")]
    public partial class ChargeSearchRow : SearchRow {

        private ChargeSearchRowBasic basicField;

        private BillingAccountSearchRowBasic billingAccountJoinField;

        private BillingScheduleSearchRowBasic billingScheduleJoinField;

        private EmployeeSearchRowBasic chargeEmployeeJoinField;

        private CustomerSearchRowBasic customerJoinField;

        private TransactionSearchRowBasic invoiceJoinField;

        private ItemSearchRowBasic itemJoinField;

        private JobSearchRowBasic jobJoinField;

        private TransactionSearchRowBasic salesOrderJoinField;

        private TimeBillSearchRowBasic timeJoinField;

        private TransactionSearchRowBasic transactionJoinField;

        private UsageSearchRowBasic usageJoinField;

        private EmployeeSearchRowBasic userJoinField;

        private CustomSearchRowBasic[] customSearchJoinField;

        /// <remarks/>
        public ChargeSearchRowBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public BillingAccountSearchRowBasic billingAccountJoin {
            get {
                return this.billingAccountJoinField;
            }
            set {
                this.billingAccountJoinField = value;
            }
        }

        /// <remarks/>
        public BillingScheduleSearchRowBasic billingScheduleJoin {
            get {
                return this.billingScheduleJoinField;
            }
            set {
                this.billingScheduleJoinField = value;
            }
        }

        /// <remarks/>
        public EmployeeSearchRowBasic chargeEmployeeJoin {
            get {
                return this.chargeEmployeeJoinField;
            }
            set {
                this.chargeEmployeeJoinField = value;
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
        public TransactionSearchRowBasic invoiceJoin {
            get {
                return this.invoiceJoinField;
            }
            set {
                this.invoiceJoinField = value;
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
        public JobSearchRowBasic jobJoin {
            get {
                return this.jobJoinField;
            }
            set {
                this.jobJoinField = value;
            }
        }

        /// <remarks/>
        public TransactionSearchRowBasic salesOrderJoin {
            get {
                return this.salesOrderJoinField;
            }
            set {
                this.salesOrderJoinField = value;
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
        public UsageSearchRowBasic usageJoin {
            get {
                return this.usageJoinField;
            }
            set {
                this.usageJoinField = value;
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