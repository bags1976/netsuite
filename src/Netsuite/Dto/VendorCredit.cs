namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:purchases_2021_1.transactions.webservices.netsuite.com")]
    public partial class VendorCredit : Record {

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

        private RecordRef accountField;

        private double unAppliedField;

        private bool unAppliedFieldSpecified;

        private RecordRef billAddressListField;

        private bool autoApplyField;

        private bool autoApplyFieldSpecified;

        private double appliedField;

        private bool appliedFieldSpecified;

        private string transactionNumberField;

        private string tranIdField;

        private RecordRef createdFromField;

        private RecordRef entityField;

        private double totalField;

        private bool totalFieldSpecified;

        private double userTotalField;

        private bool userTotalFieldSpecified;

        private RecordRef currencyField;

        private string currencyNameField;

        private Address billingAddressField;

        private System.DateTime tranDateField;

        private bool tranDateFieldSpecified;

        private double exchangeRateField;

        private bool exchangeRateFieldSpecified;

        private RecordRef entityTaxRegNumField;

        private System.DateTime taxPointDateField;

        private bool taxPointDateFieldSpecified;

        private double userTaxTotalField;

        private bool userTaxTotalFieldSpecified;

        private RecordRef postingPeriodField;

        private string memoField;

        private RecordRef departmentField;

        private RecordRef classField;

        private RecordRef locationField;

        private RecordRef subsidiaryField;

        private VendorCreditExpenseList expenseListField;

        private VendorCreditItemList itemListField;

        private AccountingBookDetailList accountingBookDetailListField;

        private VendorCreditApplyList applyListField;

        private TaxDetailsList taxDetailsListField;

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
        public RecordRef account {
            get {
                return this.accountField;
            }
            set {
                this.accountField = value;
            }
        }

        /// <remarks/>
        public double unApplied {
            get {
                return this.unAppliedField;
            }
            set {
                this.unAppliedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unAppliedSpecified {
            get {
                return this.unAppliedFieldSpecified;
            }
            set {
                this.unAppliedFieldSpecified = value;
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
        public bool autoApply {
            get {
                return this.autoApplyField;
            }
            set {
                this.autoApplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool autoApplySpecified {
            get {
                return this.autoApplyFieldSpecified;
            }
            set {
                this.autoApplyFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double applied {
            get {
                return this.appliedField;
            }
            set {
                this.appliedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool appliedSpecified {
            get {
                return this.appliedFieldSpecified;
            }
            set {
                this.appliedFieldSpecified = value;
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
        public string tranId {
            get {
                return this.tranIdField;
            }
            set {
                this.tranIdField = value;
            }
        }

        /// <remarks/>
        public RecordRef createdFrom {
            get {
                return this.createdFromField;
            }
            set {
                this.createdFromField = value;
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
        public double total {
            get {
                return this.totalField;
            }
            set {
                this.totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totalSpecified {
            get {
                return this.totalFieldSpecified;
            }
            set {
                this.totalFieldSpecified = value;
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
        public RecordRef currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
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
        public double userTaxTotal {
            get {
                return this.userTaxTotalField;
            }
            set {
                this.userTaxTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool userTaxTotalSpecified {
            get {
                return this.userTaxTotalFieldSpecified;
            }
            set {
                this.userTaxTotalFieldSpecified = value;
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
        public string memo {
            get {
                return this.memoField;
            }
            set {
                this.memoField = value;
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
        public RecordRef @class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
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
        public RecordRef subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
            }
        }

        /// <remarks/>
        public VendorCreditExpenseList expenseList {
            get {
                return this.expenseListField;
            }
            set {
                this.expenseListField = value;
            }
        }

        /// <remarks/>
        public VendorCreditItemList itemList {
            get {
                return this.itemListField;
            }
            set {
                this.itemListField = value;
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
        public VendorCreditApplyList applyList {
            get {
                return this.applyListField;
            }
            set {
                this.applyListField = value;
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