namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:customers_2021_1.transactions.webservices.netsuite.com")]
    public partial class ChargeSearch : SearchRecord {

        private ChargeSearchBasic basicField;

        private BillingAccountSearchBasic billingAccountJoinField;

        private BillingScheduleSearchBasic billingScheduleJoinField;

        private EmployeeSearchBasic chargeEmployeeJoinField;

        private CustomerSearchBasic customerJoinField;

        private TransactionSearchBasic invoiceJoinField;

        private ItemSearchBasic itemJoinField;

        private JobSearchBasic jobJoinField;

        private TransactionSearchBasic salesOrderJoinField;

        private TimeBillSearchBasic timeJoinField;

        private TransactionSearchBasic transactionJoinField;

        private UsageSearchBasic usageJoinField;

        private EmployeeSearchBasic userJoinField;

        private CustomSearchJoin[] customSearchJoinField;

        /// <remarks/>
        public ChargeSearchBasic basic {
            get {
                return this.basicField;
            }
            set {
                this.basicField = value;
            }
        }

        /// <remarks/>
        public BillingAccountSearchBasic billingAccountJoin {
            get {
                return this.billingAccountJoinField;
            }
            set {
                this.billingAccountJoinField = value;
            }
        }

        /// <remarks/>
        public BillingScheduleSearchBasic billingScheduleJoin {
            get {
                return this.billingScheduleJoinField;
            }
            set {
                this.billingScheduleJoinField = value;
            }
        }

        /// <remarks/>
        public EmployeeSearchBasic chargeEmployeeJoin {
            get {
                return this.chargeEmployeeJoinField;
            }
            set {
                this.chargeEmployeeJoinField = value;
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
        public TransactionSearchBasic invoiceJoin {
            get {
                return this.invoiceJoinField;
            }
            set {
                this.invoiceJoinField = value;
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
        public JobSearchBasic jobJoin {
            get {
                return this.jobJoinField;
            }
            set {
                this.jobJoinField = value;
            }
        }

        /// <remarks/>
        public TransactionSearchBasic salesOrderJoin {
            get {
                return this.salesOrderJoinField;
            }
            set {
                this.salesOrderJoinField = value;
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
        public UsageSearchBasic usageJoin {
            get {
                return this.usageJoinField;
            }
            set {
                this.usageJoinField = value;
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