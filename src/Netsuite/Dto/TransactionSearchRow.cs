namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sales_2021_1.transactions.webservices.netsuite.com")]
    public partial class TransactionSearchRow : SearchRow {

        private TransactionSearchRowBasic basicField;

        private AccountSearchRowBasic accountJoinField;

        private AccountingPeriodSearchRowBasic accountingPeriodJoinField;

        private AccountingTransactionSearchRowBasic accountingTransactionJoinField;

        private AccountSearchRowBasic advanceToApplyAccountJoinField;

        private TransactionSearchRowBasic appliedToTransactionJoinField;

        private TransactionSearchRowBasic applyingTransactionJoinField;

        private ItemSearchRowBasic assemblyJoinField;

        private AddressSearchRowBasic billingAddressJoinField;

        private TransactionSearchRowBasic billingTransactionJoinField;

        private BinSearchRowBasic binNumberJoinField;

        private BomSearchRowBasic bomJoinField;

        private BomRevisionSearchRowBasic bomRevisionJoinField;

        private PhoneCallSearchRowBasic callJoinField;

        private SupportCaseSearchRowBasic caseJoinField;

        private ClassificationSearchRowBasic classJoinField;

        private TransactionSearchRowBasic cogsPurchaseJoinField;

        private TransactionSearchRowBasic cogsSaleJoinField;

        private ContactSearchRowBasic contactPrimaryJoinField;

        private TransactionSearchRowBasic createdFromJoinField;

        private CustomerSearchRowBasic customerJoinField;

        private CustomerSearchRowBasic customerMainJoinField;

        private DepartmentSearchRowBasic departmentJoinField;

        private TransactionSearchRowBasic depositTransactionJoinField;

        private EmployeeSearchRowBasic employeeJoinField;

        private CalendarEventSearchRowBasic eventJoinField;

        private ExpenseCategorySearchRowBasic expenseCategoryJoinField;

        private FileSearchRowBasic fileJoinField;

        private LocationSearchRowBasic fromLocationJoinField;

        private TransactionSearchRowBasic fulfillingTransactionJoinField;

        private BillingAccountSearchRowBasic headerBillingAccountJoinField;

        private InstallmentSearchRowBasic installmentJoinField;

        private InventoryDetailSearchRowBasic inventoryDetailJoinField;

        private ItemSearchRowBasic itemJoinField;

        private InventoryNumberSearchRowBasic itemNumberJoinField;

        private JobSearchRowBasic jobJoinField;

        private JobSearchRowBasic jobMainJoinField;

        private CampaignSearchRowBasic leadSourceJoinField;

        private BillingAccountSearchRowBasic lineBillingAccountJoinField;

        private FileSearchRowBasic lineFileJoinField;

        private LocationSearchRowBasic locationJoinField;

        private ManufacturingOperationTaskSearchRowBasic manufacturingOperationTaskJoinField;

        private MessageSearchRowBasic messagesJoinField;

        private EntitySearchRowBasic nextApproverJoinField;

        private OpportunitySearchRowBasic opportunityJoinField;

        private VendorSearchRowBasic outsourcingVendorJoinField;

        private TransactionSearchRowBasic paidTransactionJoinField;

        private PartnerSearchRowBasic partnerJoinField;

        private TransactionSearchRowBasic payingTransactionJoinField;

        private PaymentInstrumentSearchRowBasic paymentInstrumentJoinField;

        private PaymentOptionSearchRowBasic paymentOptionJoinField;

        private PayrollItemSearchRowBasic payrollItemJoinField;

        private ProjectTaskSearchRowBasic projectTaskJoinField;

        private TransactionSearchRowBasic purchaseOrderJoinField;

        private EmployeeSearchRowBasic requestorJoinField;

        private TransactionSearchRowBasic revCommittingTransactionJoinField;

        private ItemRevisionSearchRowBasic revisionJoinField;

        private RevRecScheduleSearchRowBasic revRecScheduleJoinField;

        private TransactionSearchRowBasic rgPostingTransactionJoinField;

        private TransactionSearchRowBasic salesOrderJoinField;

        private EmployeeSearchRowBasic salesRepJoinField;

        private AddressSearchRowBasic shippingAddressJoinField;

        private SubsidiarySearchRowBasic subsidiaryJoinField;

        private TaskSearchRowBasic taskJoinField;

        private SalesTaxItemSearchRowBasic taxCodeJoinField;

        private TaxDetailSearchRowBasic taxDetailJoinField;

        private SalesTaxItemSearchRowBasic taxItemJoinField;

        private TimeBillSearchRowBasic timeJoinField;

        private LocationSearchRowBasic toLocationJoinField;

        private EmployeeSearchRowBasic userJoinField;

        private NoteSearchRowBasic userNotesJoinField;

        private VendorSearchRowBasic vendorJoinField;

        private VendorSearchRowBasic vendorLineJoinField;

        private CustomSearchRowBasic[] customSearchJoinField;

        /// <remarks/>
        public TransactionSearchRowBasic basic {
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
        public AccountingPeriodSearchRowBasic accountingPeriodJoin {
            get {
                return this.accountingPeriodJoinField;
            }
            set {
                this.accountingPeriodJoinField = value;
            }
        }

        /// <remarks/>
        public AccountingTransactionSearchRowBasic accountingTransactionJoin {
            get {
                return this.accountingTransactionJoinField;
            }
            set {
                this.accountingTransactionJoinField = value;
            }
        }

        /// <remarks/>
        public AccountSearchRowBasic advanceToApplyAccountJoin {
            get {
                return this.advanceToApplyAccountJoinField;
            }
            set {
                this.advanceToApplyAccountJoinField = value;
            }
        }

        /// <remarks/>
        public TransactionSearchRowBasic appliedToTransactionJoin {
            get {
                return this.appliedToTransactionJoinField;
            }
            set {
                this.appliedToTransactionJoinField = value;
            }
        }

        /// <remarks/>
        public TransactionSearchRowBasic applyingTransactionJoin {
            get {
                return this.applyingTransactionJoinField;
            }
            set {
                this.applyingTransactionJoinField = value;
            }
        }

        /// <remarks/>
        public ItemSearchRowBasic assemblyJoin {
            get {
                return this.assemblyJoinField;
            }
            set {
                this.assemblyJoinField = value;
            }
        }

        /// <remarks/>
        public AddressSearchRowBasic billingAddressJoin {
            get {
                return this.billingAddressJoinField;
            }
            set {
                this.billingAddressJoinField = value;
            }
        }

        /// <remarks/>
        public TransactionSearchRowBasic billingTransactionJoin {
            get {
                return this.billingTransactionJoinField;
            }
            set {
                this.billingTransactionJoinField = value;
            }
        }

        /// <remarks/>
        public BinSearchRowBasic binNumberJoin {
            get {
                return this.binNumberJoinField;
            }
            set {
                this.binNumberJoinField = value;
            }
        }

        /// <remarks/>
        public BomSearchRowBasic bomJoin {
            get {
                return this.bomJoinField;
            }
            set {
                this.bomJoinField = value;
            }
        }

        /// <remarks/>
        public BomRevisionSearchRowBasic bomRevisionJoin {
            get {
                return this.bomRevisionJoinField;
            }
            set {
                this.bomRevisionJoinField = value;
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
        public SupportCaseSearchRowBasic caseJoin {
            get {
                return this.caseJoinField;
            }
            set {
                this.caseJoinField = value;
            }
        }

        /// <remarks/>
        public ClassificationSearchRowBasic classJoin {
            get {
                return this.classJoinField;
            }
            set {
                this.classJoinField = value;
            }
        }

        /// <remarks/>
        public TransactionSearchRowBasic cogsPurchaseJoin {
            get {
                return this.cogsPurchaseJoinField;
            }
            set {
                this.cogsPurchaseJoinField = value;
            }
        }

        /// <remarks/>
        public TransactionSearchRowBasic cogsSaleJoin {
            get {
                return this.cogsSaleJoinField;
            }
            set {
                this.cogsSaleJoinField = value;
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
        public TransactionSearchRowBasic createdFromJoin {
            get {
                return this.createdFromJoinField;
            }
            set {
                this.createdFromJoinField = value;
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
        public CustomerSearchRowBasic customerMainJoin {
            get {
                return this.customerMainJoinField;
            }
            set {
                this.customerMainJoinField = value;
            }
        }

        /// <remarks/>
        public DepartmentSearchRowBasic departmentJoin {
            get {
                return this.departmentJoinField;
            }
            set {
                this.departmentJoinField = value;
            }
        }

        /// <remarks/>
        public TransactionSearchRowBasic depositTransactionJoin {
            get {
                return this.depositTransactionJoinField;
            }
            set {
                this.depositTransactionJoinField = value;
            }
        }

        /// <remarks/>
        public EmployeeSearchRowBasic employeeJoin {
            get {
                return this.employeeJoinField;
            }
            set {
                this.employeeJoinField = value;
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
        public ExpenseCategorySearchRowBasic expenseCategoryJoin {
            get {
                return this.expenseCategoryJoinField;
            }
            set {
                this.expenseCategoryJoinField = value;
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
        public LocationSearchRowBasic fromLocationJoin {
            get {
                return this.fromLocationJoinField;
            }
            set {
                this.fromLocationJoinField = value;
            }
        }

        /// <remarks/>
        public TransactionSearchRowBasic fulfillingTransactionJoin {
            get {
                return this.fulfillingTransactionJoinField;
            }
            set {
                this.fulfillingTransactionJoinField = value;
            }
        }

        /// <remarks/>
        public BillingAccountSearchRowBasic headerBillingAccountJoin {
            get {
                return this.headerBillingAccountJoinField;
            }
            set {
                this.headerBillingAccountJoinField = value;
            }
        }

        /// <remarks/>
        public InstallmentSearchRowBasic installmentJoin {
            get {
                return this.installmentJoinField;
            }
            set {
                this.installmentJoinField = value;
            }
        }

        /// <remarks/>
        public InventoryDetailSearchRowBasic inventoryDetailJoin {
            get {
                return this.inventoryDetailJoinField;
            }
            set {
                this.inventoryDetailJoinField = value;
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
        public InventoryNumberSearchRowBasic itemNumberJoin {
            get {
                return this.itemNumberJoinField;
            }
            set {
                this.itemNumberJoinField = value;
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
        public JobSearchRowBasic jobMainJoin {
            get {
                return this.jobMainJoinField;
            }
            set {
                this.jobMainJoinField = value;
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
        public BillingAccountSearchRowBasic lineBillingAccountJoin {
            get {
                return this.lineBillingAccountJoinField;
            }
            set {
                this.lineBillingAccountJoinField = value;
            }
        }

        /// <remarks/>
        public FileSearchRowBasic lineFileJoin {
            get {
                return this.lineFileJoinField;
            }
            set {
                this.lineFileJoinField = value;
            }
        }

        /// <remarks/>
        public LocationSearchRowBasic locationJoin {
            get {
                return this.locationJoinField;
            }
            set {
                this.locationJoinField = value;
            }
        }

        /// <remarks/>
        public ManufacturingOperationTaskSearchRowBasic manufacturingOperationTaskJoin {
            get {
                return this.manufacturingOperationTaskJoinField;
            }
            set {
                this.manufacturingOperationTaskJoinField = value;
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
        public EntitySearchRowBasic nextApproverJoin {
            get {
                return this.nextApproverJoinField;
            }
            set {
                this.nextApproverJoinField = value;
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
        public VendorSearchRowBasic outsourcingVendorJoin {
            get {
                return this.outsourcingVendorJoinField;
            }
            set {
                this.outsourcingVendorJoinField = value;
            }
        }

        /// <remarks/>
        public TransactionSearchRowBasic paidTransactionJoin {
            get {
                return this.paidTransactionJoinField;
            }
            set {
                this.paidTransactionJoinField = value;
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
        public TransactionSearchRowBasic payingTransactionJoin {
            get {
                return this.payingTransactionJoinField;
            }
            set {
                this.payingTransactionJoinField = value;
            }
        }

        /// <remarks/>
        public PaymentInstrumentSearchRowBasic paymentInstrumentJoin {
            get {
                return this.paymentInstrumentJoinField;
            }
            set {
                this.paymentInstrumentJoinField = value;
            }
        }

        /// <remarks/>
        public PaymentOptionSearchRowBasic paymentOptionJoin {
            get {
                return this.paymentOptionJoinField;
            }
            set {
                this.paymentOptionJoinField = value;
            }
        }

        /// <remarks/>
        public PayrollItemSearchRowBasic payrollItemJoin {
            get {
                return this.payrollItemJoinField;
            }
            set {
                this.payrollItemJoinField = value;
            }
        }

        /// <remarks/>
        public ProjectTaskSearchRowBasic projectTaskJoin {
            get {
                return this.projectTaskJoinField;
            }
            set {
                this.projectTaskJoinField = value;
            }
        }

        /// <remarks/>
        public TransactionSearchRowBasic purchaseOrderJoin {
            get {
                return this.purchaseOrderJoinField;
            }
            set {
                this.purchaseOrderJoinField = value;
            }
        }

        /// <remarks/>
        public EmployeeSearchRowBasic requestorJoin {
            get {
                return this.requestorJoinField;
            }
            set {
                this.requestorJoinField = value;
            }
        }

        /// <remarks/>
        public TransactionSearchRowBasic revCommittingTransactionJoin {
            get {
                return this.revCommittingTransactionJoinField;
            }
            set {
                this.revCommittingTransactionJoinField = value;
            }
        }

        /// <remarks/>
        public ItemRevisionSearchRowBasic revisionJoin {
            get {
                return this.revisionJoinField;
            }
            set {
                this.revisionJoinField = value;
            }
        }

        /// <remarks/>
        public RevRecScheduleSearchRowBasic revRecScheduleJoin {
            get {
                return this.revRecScheduleJoinField;
            }
            set {
                this.revRecScheduleJoinField = value;
            }
        }

        /// <remarks/>
        public TransactionSearchRowBasic rgPostingTransactionJoin {
            get {
                return this.rgPostingTransactionJoinField;
            }
            set {
                this.rgPostingTransactionJoinField = value;
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
        public EmployeeSearchRowBasic salesRepJoin {
            get {
                return this.salesRepJoinField;
            }
            set {
                this.salesRepJoinField = value;
            }
        }

        /// <remarks/>
        public AddressSearchRowBasic shippingAddressJoin {
            get {
                return this.shippingAddressJoinField;
            }
            set {
                this.shippingAddressJoinField = value;
            }
        }

        /// <remarks/>
        public SubsidiarySearchRowBasic subsidiaryJoin {
            get {
                return this.subsidiaryJoinField;
            }
            set {
                this.subsidiaryJoinField = value;
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
        public SalesTaxItemSearchRowBasic taxCodeJoin {
            get {
                return this.taxCodeJoinField;
            }
            set {
                this.taxCodeJoinField = value;
            }
        }

        /// <remarks/>
        public TaxDetailSearchRowBasic taxDetailJoin {
            get {
                return this.taxDetailJoinField;
            }
            set {
                this.taxDetailJoinField = value;
            }
        }

        /// <remarks/>
        public SalesTaxItemSearchRowBasic taxItemJoin {
            get {
                return this.taxItemJoinField;
            }
            set {
                this.taxItemJoinField = value;
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
        public LocationSearchRowBasic toLocationJoin {
            get {
                return this.toLocationJoinField;
            }
            set {
                this.toLocationJoinField = value;
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
        public VendorSearchRowBasic vendorJoin {
            get {
                return this.vendorJoinField;
            }
            set {
                this.vendorJoinField = value;
            }
        }

        /// <remarks/>
        public VendorSearchRowBasic vendorLineJoin {
            get {
                return this.vendorLineJoinField;
            }
            set {
                this.vendorLineJoinField = value;
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