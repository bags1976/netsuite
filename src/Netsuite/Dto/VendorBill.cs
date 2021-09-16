namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:purchases_2021_1.transactions.webservices.netsuite.com")]
    public partial class VendorBill : Record {

        private System.DateTime createdDateField;

        private bool createdDateFieldSpecified;

        private System.DateTime lastModifiedDateField;

        private bool lastModifiedDateFieldSpecified;

        private RecordRef nexusField;

        private RecordRef subsidiaryTaxRegNumField;

        private bool taxRegOverrideField;

        private bool taxRegOverrideFieldSpecified;

        private bool taxDetailsOverrideField;

        private bool taxDetailsOverrideFieldSpecified;

        private RecordRef customFormField;

        private RecordRef billAddressListField;

        private RecordRef accountField;

        private RecordRef entityField;

        private RecordRef subsidiaryField;

        private RecordRef approvalStatusField;

        private RecordRef nextApproverField;

        private string vatRegNumField;

        private RecordRef postingPeriodField;

        private System.DateTime tranDateField;

        private bool tranDateFieldSpecified;

        private string currencyNameField;

        private Address billingAddressField;

        private double exchangeRateField;

        private bool exchangeRateFieldSpecified;

        private RecordRef entityTaxRegNumField;

        private System.DateTime taxPointDateField;

        private bool taxPointDateFieldSpecified;

        private RecordRef termsField;

        private System.DateTime dueDateField;

        private bool dueDateFieldSpecified;

        private System.DateTime discountDateField;

        private bool discountDateFieldSpecified;

        private string tranIdField;

        private double userTotalField;

        private bool userTotalFieldSpecified;

        private double discountAmountField;

        private bool discountAmountFieldSpecified;

        private double taxTotalField;

        private bool taxTotalFieldSpecified;

        private bool paymentHoldField;

        private bool paymentHoldFieldSpecified;

        private string memoField;

        private double tax2TotalField;

        private bool tax2TotalFieldSpecified;

        private double creditLimitField;

        private bool creditLimitFieldSpecified;

        private double availableVendorCreditField;

        private bool availableVendorCreditFieldSpecified;

        private RecordRef currencyField;

        private RecordRef classField;

        private RecordRef departmentField;

        private RecordRef locationField;

        private string statusField;

        private LandedCostMethod landedCostMethodField;

        private bool landedCostMethodFieldSpecified;

        private bool landedCostPerLineField;

        private bool landedCostPerLineFieldSpecified;

        private string transactionNumberField;

        private VendorBillExpenseList expenseListField;

        private AccountingBookDetailList accountingBookDetailListField;

        private VendorBillItemList itemListField;

        private InstallmentList installmentListField;

        private PurchLandedCostList landedCostsListField;

        private RecordRef[] purchaseOrderListField;

        private TaxDetailsList taxDetailsListField;

        private bool overrideInstallmentsField;

        private bool overrideInstallmentsFieldSpecified;

        private CustomFieldRef[] customFieldListField;

        private string internalIdField;

        private string externalIdField;

        /// <remarks/>
        public System.DateTime createdDate {
            get {
                return this.createdDateField;
            }
            set {
                this.createdDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool createdDateSpecified {
            get {
                return this.createdDateFieldSpecified;
            }
            set {
                this.createdDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime lastModifiedDate {
            get {
                return this.lastModifiedDateField;
            }
            set {
                this.lastModifiedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lastModifiedDateSpecified {
            get {
                return this.lastModifiedDateFieldSpecified;
            }
            set {
                this.lastModifiedDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef nexus {
            get {
                return this.nexusField;
            }
            set {
                this.nexusField = value;
            }
        }

        /// <remarks/>
        public RecordRef subsidiaryTaxRegNum {
            get {
                return this.subsidiaryTaxRegNumField;
            }
            set {
                this.subsidiaryTaxRegNumField = value;
            }
        }

        /// <remarks/>
        public bool taxRegOverride {
            get {
                return this.taxRegOverrideField;
            }
            set {
                this.taxRegOverrideField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxRegOverrideSpecified {
            get {
                return this.taxRegOverrideFieldSpecified;
            }
            set {
                this.taxRegOverrideFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool taxDetailsOverride {
            get {
                return this.taxDetailsOverrideField;
            }
            set {
                this.taxDetailsOverrideField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxDetailsOverrideSpecified {
            get {
                return this.taxDetailsOverrideFieldSpecified;
            }
            set {
                this.taxDetailsOverrideFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef customForm {
            get {
                return this.customFormField;
            }
            set {
                this.customFormField = value;
            }
        }

        /// <remarks/>
        public RecordRef billAddressList {
            get {
                return this.billAddressListField;
            }
            set {
                this.billAddressListField = value;
            }
        }

        /// <remarks/>
        public RecordRef account {
            get {
                return this.accountField;
            }
            set {
                this.accountField = value;
            }
        }

        /// <remarks/>
        public RecordRef entity {
            get {
                return this.entityField;
            }
            set {
                this.entityField = value;
            }
        }

        /// <remarks/>
        public RecordRef subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
            }
        }

        /// <remarks/>
        public RecordRef approvalStatus {
            get {
                return this.approvalStatusField;
            }
            set {
                this.approvalStatusField = value;
            }
        }

        /// <remarks/>
        public RecordRef nextApprover {
            get {
                return this.nextApproverField;
            }
            set {
                this.nextApproverField = value;
            }
        }

        /// <remarks/>
        public string vatRegNum {
            get {
                return this.vatRegNumField;
            }
            set {
                this.vatRegNumField = value;
            }
        }

        /// <remarks/>
        public RecordRef postingPeriod {
            get {
                return this.postingPeriodField;
            }
            set {
                this.postingPeriodField = value;
            }
        }

        /// <remarks/>
        public System.DateTime tranDate {
            get {
                return this.tranDateField;
            }
            set {
                this.tranDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tranDateSpecified {
            get {
                return this.tranDateFieldSpecified;
            }
            set {
                this.tranDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string currencyName {
            get {
                return this.currencyNameField;
            }
            set {
                this.currencyNameField = value;
            }
        }

        /// <remarks/>
        public Address billingAddress {
            get {
                return this.billingAddressField;
            }
            set {
                this.billingAddressField = value;
            }
        }

        /// <remarks/>
        public double exchangeRate {
            get {
                return this.exchangeRateField;
            }
            set {
                this.exchangeRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool exchangeRateSpecified {
            get {
                return this.exchangeRateFieldSpecified;
            }
            set {
                this.exchangeRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef entityTaxRegNum {
            get {
                return this.entityTaxRegNumField;
            }
            set {
                this.entityTaxRegNumField = value;
            }
        }

        /// <remarks/>
        public System.DateTime taxPointDate {
            get {
                return this.taxPointDateField;
            }
            set {
                this.taxPointDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxPointDateSpecified {
            get {
                return this.taxPointDateFieldSpecified;
            }
            set {
                this.taxPointDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef terms {
            get {
                return this.termsField;
            }
            set {
                this.termsField = value;
            }
        }

        /// <remarks/>
        public System.DateTime dueDate {
            get {
                return this.dueDateField;
            }
            set {
                this.dueDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dueDateSpecified {
            get {
                return this.dueDateFieldSpecified;
            }
            set {
                this.dueDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime discountDate {
            get {
                return this.discountDateField;
            }
            set {
                this.discountDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool discountDateSpecified {
            get {
                return this.discountDateFieldSpecified;
            }
            set {
                this.discountDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string tranId {
            get {
                return this.tranIdField;
            }
            set {
                this.tranIdField = value;
            }
        }

        /// <remarks/>
        public double userTotal {
            get {
                return this.userTotalField;
            }
            set {
                this.userTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool userTotalSpecified {
            get {
                return this.userTotalFieldSpecified;
            }
            set {
                this.userTotalFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double discountAmount {
            get {
                return this.discountAmountField;
            }
            set {
                this.discountAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool discountAmountSpecified {
            get {
                return this.discountAmountFieldSpecified;
            }
            set {
                this.discountAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double taxTotal {
            get {
                return this.taxTotalField;
            }
            set {
                this.taxTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool taxTotalSpecified {
            get {
                return this.taxTotalFieldSpecified;
            }
            set {
                this.taxTotalFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool paymentHold {
            get {
                return this.paymentHoldField;
            }
            set {
                this.paymentHoldField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool paymentHoldSpecified {
            get {
                return this.paymentHoldFieldSpecified;
            }
            set {
                this.paymentHoldFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string memo {
            get {
                return this.memoField;
            }
            set {
                this.memoField = value;
            }
        }

        /// <remarks/>
        public double tax2Total {
            get {
                return this.tax2TotalField;
            }
            set {
                this.tax2TotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tax2TotalSpecified {
            get {
                return this.tax2TotalFieldSpecified;
            }
            set {
                this.tax2TotalFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double creditLimit {
            get {
                return this.creditLimitField;
            }
            set {
                this.creditLimitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool creditLimitSpecified {
            get {
                return this.creditLimitFieldSpecified;
            }
            set {
                this.creditLimitFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double availableVendorCredit {
            get {
                return this.availableVendorCreditField;
            }
            set {
                this.availableVendorCreditField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool availableVendorCreditSpecified {
            get {
                return this.availableVendorCreditFieldSpecified;
            }
            set {
                this.availableVendorCreditFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        public RecordRef @class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
            }
        }

        /// <remarks/>
        public RecordRef department {
            get {
                return this.departmentField;
            }
            set {
                this.departmentField = value;
            }
        }

        /// <remarks/>
        public RecordRef location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }

        /// <remarks/>
        public string status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }

        /// <remarks/>
        public LandedCostMethod landedCostMethod {
            get {
                return this.landedCostMethodField;
            }
            set {
                this.landedCostMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool landedCostMethodSpecified {
            get {
                return this.landedCostMethodFieldSpecified;
            }
            set {
                this.landedCostMethodFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool landedCostPerLine {
            get {
                return this.landedCostPerLineField;
            }
            set {
                this.landedCostPerLineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool landedCostPerLineSpecified {
            get {
                return this.landedCostPerLineFieldSpecified;
            }
            set {
                this.landedCostPerLineFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string transactionNumber {
            get {
                return this.transactionNumberField;
            }
            set {
                this.transactionNumberField = value;
            }
        }

        /// <remarks/>
        public VendorBillExpenseList expenseList {
            get {
                return this.expenseListField;
            }
            set {
                this.expenseListField = value;
            }
        }

        /// <remarks/>
        public AccountingBookDetailList accountingBookDetailList {
            get {
                return this.accountingBookDetailListField;
            }
            set {
                this.accountingBookDetailListField = value;
            }
        }

        /// <remarks/>
        public VendorBillItemList itemList {
            get {
                return this.itemListField;
            }
            set {
                this.itemListField = value;
            }
        }

        /// <remarks/>
        public InstallmentList installmentList {
            get {
                return this.installmentListField;
            }
            set {
                this.installmentListField = value;
            }
        }

        /// <remarks/>
        public PurchLandedCostList landedCostsList {
            get {
                return this.landedCostsListField;
            }
            set {
                this.landedCostsListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recordRef", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public RecordRef[] purchaseOrderList {
            get {
                return this.purchaseOrderListField;
            }
            set {
                this.purchaseOrderListField = value;
            }
        }

        /// <remarks/>
        public TaxDetailsList taxDetailsList {
            get {
                return this.taxDetailsListField;
            }
            set {
                this.taxDetailsListField = value;
            }
        }

        /// <remarks/>
        public bool overrideInstallments {
            get {
                return this.overrideInstallmentsField;
            }
            set {
                this.overrideInstallmentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool overrideInstallmentsSpecified {
            get {
                return this.overrideInstallmentsFieldSpecified;
            }
            set {
                this.overrideInstallmentsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("customField", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public CustomFieldRef[] customFieldList {
            get {
                return this.customFieldListField;
            }
            set {
                this.customFieldListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string externalId {
            get {
                return this.externalIdField;
            }
            set {
                this.externalIdField = value;
            }
        }
    }
}