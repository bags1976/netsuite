namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sales_2021_1.transactions.webservices.netsuite.com")]
    public partial class TransactionSearch : SearchRecord {

        private TransactionSearchBasic basicField;

        private AccountSearchBasic accountJoinField;

        private AccountingPeriodSearchBasic accountingPeriodJoinField;

        private AccountingTransactionSearchBasic accountingTransactionJoinField;

        private AccountSearchBasic advanceToApplyAccountJoinField;

        private TransactionSearchBasic appliedToTransactionJoinField;

        private TransactionSearchBasic applyingTransactionJoinField;

        private ItemSearchBasic assemblyJoinField;

        private AddressSearchBasic billingAddressJoinField;

        private TransactionSearchBasic billingTransactionJoinField;

        private BinSearchBasic binNumberJoinField;

        private BomSearchBasic bomJoinField;

        private BomRevisionSearchBasic bomRevisionJoinField;

        private PhoneCallSearchBasic callJoinField;

        private SupportCaseSearchBasic caseJoinField;

        private ClassificationSearchBasic classJoinField;

        private TransactionSearchBasic cogsPurchaseJoinField;

        private TransactionSearchBasic cogsSaleJoinField;

        private ContactSearchBasic contactPrimaryJoinField;

        private TransactionSearchBasic createdFromJoinField;

        private CustomerSearchBasic customerJoinField;

        private CustomerSearchBasic customerMainJoinField;

        private DepartmentSearchBasic departmentJoinField;

        private TransactionSearchBasic depositTransactionJoinField;

        private EmployeeSearchBasic employeeJoinField;

        private CalendarEventSearchBasic eventJoinField;

        private ExpenseCategorySearchBasic expenseCategoryJoinField;

        private FileSearchBasic fileJoinField;

        private LocationSearchBasic fromLocationJoinField;

        private TransactionSearchBasic fulfillingTransactionJoinField;

        private BillingAccountSearchBasic headerBillingAccountJoinField;

        private InstallmentSearchBasic installmentJoinField;

        private InventoryDetailSearchBasic inventoryDetailJoinField;

        private ItemSearchBasic itemJoinField;

        private InventoryNumberSearchBasic itemNumberJoinField;

        private JobSearchBasic jobJoinField;

        private JobSearchBasic jobMainJoinField;

        private CampaignSearchBasic leadSourceJoinField;

        private BillingAccountSearchBasic lineBillingAccountJoinField;

        private FileSearchBasic lineFileJoinField;

        private LocationSearchBasic locationJoinField;

        private ManufacturingOperationTaskSearchBasic manufacturingOperationTaskJoinField;

        private MessageSearchBasic messagesJoinField;

        private EntitySearchBasic nextApproverJoinField;

        private OpportunitySearchBasic opportunityJoinField;

        private VendorSearchBasic outsourcingVendorJoinField;

        private TransactionSearchBasic paidTransactionJoinField;

        private PartnerSearchBasic partnerJoinField;

        private TransactionSearchBasic payingTransactionJoinField;

        private PaymentInstrumentSearchBasic paymentInstrumentJoinField;

        private PaymentOptionSearchBasic paymentOptionJoinField;

        private PayrollItemSearchBasic payrollItemJoinField;

        private ProjectTaskSearchBasic projectTaskJoinField;

        private TransactionSearchBasic purchaseOrderJoinField;

        private EmployeeSearchBasic requestorJoinField;

        private TransactionSearchBasic revCommittingTransactionJoinField;

        private ItemRevisionSearchBasic revisionJoinField;

        private RevRecScheduleSearchBasic revRecScheduleJoinField;

        private TransactionSearchBasic rgPostingTransactionJoinField;

        private TransactionSearchBasic salesOrderJoinField;

        private EmployeeSearchBasic salesRepJoinField;

        private AddressSearchBasic shippingAddressJoinField;

        private SubsidiarySearchBasic subsidiaryJoinField;

        private TaskSearchBasic taskJoinField;

        private SalesTaxItemSearchBasic taxCodeJoinField;

        private TaxDetailSearchBasic taxDetailJoinField;

        private SalesTaxItemSearchBasic taxItemJoinField;

        private TimeBillSearchBasic timeJoinField;

        private LocationSearchBasic toLocationJoinField;

        private EmployeeSearchBasic userJoinField;

        private NoteSearchBasic userNotesJoinField;

        private VendorSearchBasic vendorJoinField;

        private VendorSearchBasic vendorLineJoinField;

        private CustomSearchJoin[] customSearchJoinField;

        /// <remarks/>
        public TransactionSearchBasic basic {
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
        public AccountingPeriodSearchBasic accountingPeriodJoin {
            get {
                return this.accountingPeriodJoinField;
            }
            set {
                this.accountingPeriodJoinField = value;
            }
        }

        /// <remarks/>
        public AccountingTransactionSearchBasic accountingTransactionJoin {
            get {
                return this.accountingTransactionJoinField;
            }
            set {
                this.accountingTransactionJoinField = value;
            }
        }

        /// <remarks/>
        public AccountSearchBasic advanceToApplyAccountJoin {
            get {
                return this.advanceToApplyAccountJoinField;
            }
            set {
                this.advanceToApplyAccountJoinField = value;
            }
        }

        /// <remarks/>
        public TransactionSearchBasic appliedToTransactionJoin {
            get {
                return this.appliedToTransactionJoinField;
            }
            set {
                this.appliedToTransactionJoinField = value;
            }
        }

        /// <remarks/>
        public TransactionSearchBasic applyingTransactionJoin {
            get {
                return this.applyingTransactionJoinField;
            }
            set {
                this.applyingTransactionJoinField = value;
            }
        }

        /// <remarks/>
        public ItemSearchBasic assemblyJoin {
            get {
                return this.assemblyJoinField;
            }
            set {
                this.assemblyJoinField = value;
            }
        }

        /// <remarks/>
        public AddressSearchBasic billingAddressJoin {
            get {
                return this.billingAddressJoinField;
            }
            set {
                this.billingAddressJoinField = value;
            }
        }

        /// <remarks/>
        public TransactionSearchBasic billingTransactionJoin {
            get {
                return this.billingTransactionJoinField;
            }
            set {
                this.billingTransactionJoinField = value;
            }
        }

        /// <remarks/>
        public BinSearchBasic binNumberJoin {
            get {
                return this.binNumberJoinField;
            }
            set {
                this.binNumberJoinField = value;
            }
        }

        /// <remarks/>
        public BomSearchBasic bomJoin {
            get {
                return this.bomJoinField;
            }
            set {
                this.bomJoinField = value;
            }
        }

        /// <remarks/>
        public BomRevisionSearchBasic bomRevisionJoin {
            get {
                return this.bomRevisionJoinField;
            }
            set {
                this.bomRevisionJoinField = value;
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
        public SupportCaseSearchBasic caseJoin {
            get {
                return this.caseJoinField;
            }
            set {
                this.caseJoinField = value;
            }
        }

        /// <remarks/>
        public ClassificationSearchBasic classJoin {
            get {
                return this.classJoinField;
            }
            set {
                this.classJoinField = value;
            }
        }

        /// <remarks/>
        public TransactionSearchBasic cogsPurchaseJoin {
            get {
                return this.cogsPurchaseJoinField;
            }
            set {
                this.cogsPurchaseJoinField = value;
            }
        }

        /// <remarks/>
        public TransactionSearchBasic cogsSaleJoin {
            get {
                return this.cogsSaleJoinField;
            }
            set {
                this.cogsSaleJoinField = value;
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
        public TransactionSearchBasic createdFromJoin {
            get {
                return this.createdFromJoinField;
            }
            set {
                this.createdFromJoinField = value;
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
        public CustomerSearchBasic customerMainJoin {
            get {
                return this.customerMainJoinField;
            }
            set {
                this.customerMainJoinField = value;
            }
        }

        /// <remarks/>
        public DepartmentSearchBasic departmentJoin {
            get {
                return this.departmentJoinField;
            }
            set {
                this.departmentJoinField = value;
            }
        }

        /// <remarks/>
        public TransactionSearchBasic depositTransactionJoin {
            get {
                return this.depositTransactionJoinField;
            }
            set {
                this.depositTransactionJoinField = value;
            }
        }

        /// <remarks/>
        public EmployeeSearchBasic employeeJoin {
            get {
                return this.employeeJoinField;
            }
            set {
                this.employeeJoinField = value;
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
        public ExpenseCategorySearchBasic expenseCategoryJoin {
            get {
                return this.expenseCategoryJoinField;
            }
            set {
                this.expenseCategoryJoinField = value;
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
        public LocationSearchBasic fromLocationJoin {
            get {
                return this.fromLocationJoinField;
            }
            set {
                this.fromLocationJoinField = value;
            }
        }

        /// <remarks/>
        public TransactionSearchBasic fulfillingTransactionJoin {
            get {
                return this.fulfillingTransactionJoinField;
            }
            set {
                this.fulfillingTransactionJoinField = value;
            }
        }

        /// <remarks/>
        public BillingAccountSearchBasic headerBillingAccountJoin {
            get {
                return this.headerBillingAccountJoinField;
            }
            set {
                this.headerBillingAccountJoinField = value;
            }
        }

        /// <remarks/>
        public InstallmentSearchBasic installmentJoin {
            get {
                return this.installmentJoinField;
            }
            set {
                this.installmentJoinField = value;
            }
        }

        /// <remarks/>
        public InventoryDetailSearchBasic inventoryDetailJoin {
            get {
                return this.inventoryDetailJoinField;
            }
            set {
                this.inventoryDetailJoinField = value;
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
        public InventoryNumberSearchBasic itemNumberJoin {
            get {
                return this.itemNumberJoinField;
            }
            set {
                this.itemNumberJoinField = value;
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
        public JobSearchBasic jobMainJoin {
            get {
                return this.jobMainJoinField;
            }
            set {
                this.jobMainJoinField = value;
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
        public BillingAccountSearchBasic lineBillingAccountJoin {
            get {
                return this.lineBillingAccountJoinField;
            }
            set {
                this.lineBillingAccountJoinField = value;
            }
        }

        /// <remarks/>
        public FileSearchBasic lineFileJoin {
            get {
                return this.lineFileJoinField;
            }
            set {
                this.lineFileJoinField = value;
            }
        }

        /// <remarks/>
        public LocationSearchBasic locationJoin {
            get {
                return this.locationJoinField;
            }
            set {
                this.locationJoinField = value;
            }
        }

        /// <remarks/>
        public ManufacturingOperationTaskSearchBasic manufacturingOperationTaskJoin {
            get {
                return this.manufacturingOperationTaskJoinField;
            }
            set {
                this.manufacturingOperationTaskJoinField = value;
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
        public EntitySearchBasic nextApproverJoin {
            get {
                return this.nextApproverJoinField;
            }
            set {
                this.nextApproverJoinField = value;
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
        public VendorSearchBasic outsourcingVendorJoin {
            get {
                return this.outsourcingVendorJoinField;
            }
            set {
                this.outsourcingVendorJoinField = value;
            }
        }

        /// <remarks/>
        public TransactionSearchBasic paidTransactionJoin {
            get {
                return this.paidTransactionJoinField;
            }
            set {
                this.paidTransactionJoinField = value;
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
        public TransactionSearchBasic payingTransactionJoin {
            get {
                return this.payingTransactionJoinField;
            }
            set {
                this.payingTransactionJoinField = value;
            }
        }

        /// <remarks/>
        public PaymentInstrumentSearchBasic paymentInstrumentJoin {
            get {
                return this.paymentInstrumentJoinField;
            }
            set {
                this.paymentInstrumentJoinField = value;
            }
        }

        /// <remarks/>
        public PaymentOptionSearchBasic paymentOptionJoin {
            get {
                return this.paymentOptionJoinField;
            }
            set {
                this.paymentOptionJoinField = value;
            }
        }

        /// <remarks/>
        public PayrollItemSearchBasic payrollItemJoin {
            get {
                return this.payrollItemJoinField;
            }
            set {
                this.payrollItemJoinField = value;
            }
        }

        /// <remarks/>
        public ProjectTaskSearchBasic projectTaskJoin {
            get {
                return this.projectTaskJoinField;
            }
            set {
                this.projectTaskJoinField = value;
            }
        }

        /// <remarks/>
        public TransactionSearchBasic purchaseOrderJoin {
            get {
                return this.purchaseOrderJoinField;
            }
            set {
                this.purchaseOrderJoinField = value;
            }
        }

        /// <remarks/>
        public EmployeeSearchBasic requestorJoin {
            get {
                return this.requestorJoinField;
            }
            set {
                this.requestorJoinField = value;
            }
        }

        /// <remarks/>
        public TransactionSearchBasic revCommittingTransactionJoin {
            get {
                return this.revCommittingTransactionJoinField;
            }
            set {
                this.revCommittingTransactionJoinField = value;
            }
        }

        /// <remarks/>
        public ItemRevisionSearchBasic revisionJoin {
            get {
                return this.revisionJoinField;
            }
            set {
                this.revisionJoinField = value;
            }
        }

        /// <remarks/>
        public RevRecScheduleSearchBasic revRecScheduleJoin {
            get {
                return this.revRecScheduleJoinField;
            }
            set {
                this.revRecScheduleJoinField = value;
            }
        }

        /// <remarks/>
        public TransactionSearchBasic rgPostingTransactionJoin {
            get {
                return this.rgPostingTransactionJoinField;
            }
            set {
                this.rgPostingTransactionJoinField = value;
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
        public EmployeeSearchBasic salesRepJoin {
            get {
                return this.salesRepJoinField;
            }
            set {
                this.salesRepJoinField = value;
            }
        }

        /// <remarks/>
        public AddressSearchBasic shippingAddressJoin {
            get {
                return this.shippingAddressJoinField;
            }
            set {
                this.shippingAddressJoinField = value;
            }
        }

        /// <remarks/>
        public SubsidiarySearchBasic subsidiaryJoin {
            get {
                return this.subsidiaryJoinField;
            }
            set {
                this.subsidiaryJoinField = value;
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
        public SalesTaxItemSearchBasic taxCodeJoin {
            get {
                return this.taxCodeJoinField;
            }
            set {
                this.taxCodeJoinField = value;
            }
        }

        /// <remarks/>
        public TaxDetailSearchBasic taxDetailJoin {
            get {
                return this.taxDetailJoinField;
            }
            set {
                this.taxDetailJoinField = value;
            }
        }

        /// <remarks/>
        public SalesTaxItemSearchBasic taxItemJoin {
            get {
                return this.taxItemJoinField;
            }
            set {
                this.taxItemJoinField = value;
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
        public LocationSearchBasic toLocationJoin {
            get {
                return this.toLocationJoinField;
            }
            set {
                this.toLocationJoinField = value;
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
        public VendorSearchBasic vendorJoin {
            get {
                return this.vendorJoinField;
            }
            set {
                this.vendorJoinField = value;
            }
        }

        /// <remarks/>
        public VendorSearchBasic vendorLineJoin {
            get {
                return this.vendorLineJoinField;
            }
            set {
                this.vendorLineJoinField = value;
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