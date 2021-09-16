namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:customers_2021_1.transactions.webservices.netsuite.com")]
    public partial class CustomerRefund : Record {

        private System.DateTime createdDateField;

        private bool createdDateFieldSpecified;

        private System.DateTime lastModifiedDateField;

        private bool lastModifiedDateFieldSpecified;

        private string statusField;

        private string transactionNumberField;

        private RecordRef customerField;

        private RecordRef customFormField;

        private double balanceField;

        private bool balanceFieldSpecified;

        private RecordRef arAcctField;

        private string currencyNameField;

        private double exchangeRateField;

        private bool exchangeRateFieldSpecified;

        private double totalField;

        private bool totalFieldSpecified;

        private RecordRef currencyField;

        private System.DateTime tranDateField;

        private bool tranDateFieldSpecified;

        private RecordRef voidJournalField;

        private RecordRef postingPeriodField;

        private string memoField;

        private RecordRef paymentMethodField;

        private RecordRef accountField;

        private bool toBePrintedField;

        private bool toBePrintedFieldSpecified;

        private string tranIdField;

        private string debitCardIssueNoField;

        private RecordRef creditCardProcessorField;

        private bool chargeItField;

        private bool chargeItFieldSpecified;

        private string pnRefNumField;

        private System.DateTime validFromField;

        private bool validFromFieldSpecified;

        private RecordRef subsidiaryField;

        private RecordRef departmentField;

        private RecordRef classField;

        private RecordRef locationField;

        private RecordRef paymentOptionField;

        private string inputAuthCodeField;

        private string inputReferenceCodeField;

        private string checkNumberField;

        private string paymentCardCscField;

        private RecordRef paymentProcessingProfileField;

        private CustomerRefundHandlingMode handlingModeField;

        private bool handlingModeFieldSpecified;

        private string outputAuthCodeField;

        private string outputReferenceCodeField;

        private CustomerRefundPaymentOperation paymentOperationField;

        private bool paymentOperationFieldSpecified;

        private string dynamicDescriptorField;

        private RecordRef creditCardField;

        private bool ccIsPurchaseCardBinField;

        private bool ccIsPurchaseCardBinFieldSpecified;

        private string ccNumberField;

        private bool ccProcessAsPurchaseCardField;

        private bool ccProcessAsPurchaseCardFieldSpecified;

        private System.DateTime ccExpireDateField;

        private bool ccExpireDateFieldSpecified;

        private string ccNameField;

        private string ccStreetField;

        private string ccZipCodeField;

        private bool ccApprovedField;

        private bool ccApprovedFieldSpecified;

        private CustomerRefundApplyList applyListField;

        private CustomerRefundDepositList depositListField;

        private AccountingBookDetailList accountingBookDetailListField;

        private RecordRef payeeAddressListField;

        private Address payeeAddressField;

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
        public string status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
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
        public RecordRef customer {
            get {
                return this.customerField;
            }
            set {
                this.customerField = value;
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
        public double balance {
            get {
                return this.balanceField;
            }
            set {
                this.balanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool balanceSpecified {
            get {
                return this.balanceFieldSpecified;
            }
            set {
                this.balanceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef arAcct {
            get {
                return this.arAcctField;
            }
            set {
                this.arAcctField = value;
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
        public RecordRef currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
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
        public RecordRef voidJournal {
            get {
                return this.voidJournalField;
            }
            set {
                this.voidJournalField = value;
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
        public RecordRef paymentMethod {
            get {
                return this.paymentMethodField;
            }
            set {
                this.paymentMethodField = value;
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
        public bool toBePrinted {
            get {
                return this.toBePrintedField;
            }
            set {
                this.toBePrintedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool toBePrintedSpecified {
            get {
                return this.toBePrintedFieldSpecified;
            }
            set {
                this.toBePrintedFieldSpecified = value;
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
        public string debitCardIssueNo {
            get {
                return this.debitCardIssueNoField;
            }
            set {
                this.debitCardIssueNoField = value;
            }
        }

        /// <remarks/>
        public RecordRef creditCardProcessor {
            get {
                return this.creditCardProcessorField;
            }
            set {
                this.creditCardProcessorField = value;
            }
        }

        /// <remarks/>
        public bool chargeIt {
            get {
                return this.chargeItField;
            }
            set {
                this.chargeItField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool chargeItSpecified {
            get {
                return this.chargeItFieldSpecified;
            }
            set {
                this.chargeItFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string pnRefNum {
            get {
                return this.pnRefNumField;
            }
            set {
                this.pnRefNumField = value;
            }
        }

        /// <remarks/>
        public System.DateTime validFrom {
            get {
                return this.validFromField;
            }
            set {
                this.validFromField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool validFromSpecified {
            get {
                return this.validFromFieldSpecified;
            }
            set {
                this.validFromFieldSpecified = value;
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
        public RecordRef paymentOption {
            get {
                return this.paymentOptionField;
            }
            set {
                this.paymentOptionField = value;
            }
        }

        /// <remarks/>
        public string inputAuthCode {
            get {
                return this.inputAuthCodeField;
            }
            set {
                this.inputAuthCodeField = value;
            }
        }

        /// <remarks/>
        public string inputReferenceCode {
            get {
                return this.inputReferenceCodeField;
            }
            set {
                this.inputReferenceCodeField = value;
            }
        }

        /// <remarks/>
        public string checkNumber {
            get {
                return this.checkNumberField;
            }
            set {
                this.checkNumberField = value;
            }
        }

        /// <remarks/>
        public string paymentCardCsc {
            get {
                return this.paymentCardCscField;
            }
            set {
                this.paymentCardCscField = value;
            }
        }

        /// <remarks/>
        public RecordRef paymentProcessingProfile {
            get {
                return this.paymentProcessingProfileField;
            }
            set {
                this.paymentProcessingProfileField = value;
            }
        }

        /// <remarks/>
        public CustomerRefundHandlingMode handlingMode {
            get {
                return this.handlingModeField;
            }
            set {
                this.handlingModeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool handlingModeSpecified {
            get {
                return this.handlingModeFieldSpecified;
            }
            set {
                this.handlingModeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string outputAuthCode {
            get {
                return this.outputAuthCodeField;
            }
            set {
                this.outputAuthCodeField = value;
            }
        }

        /// <remarks/>
        public string outputReferenceCode {
            get {
                return this.outputReferenceCodeField;
            }
            set {
                this.outputReferenceCodeField = value;
            }
        }

        /// <remarks/>
        public CustomerRefundPaymentOperation paymentOperation {
            get {
                return this.paymentOperationField;
            }
            set {
                this.paymentOperationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool paymentOperationSpecified {
            get {
                return this.paymentOperationFieldSpecified;
            }
            set {
                this.paymentOperationFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string dynamicDescriptor {
            get {
                return this.dynamicDescriptorField;
            }
            set {
                this.dynamicDescriptorField = value;
            }
        }

        /// <remarks/>
        public RecordRef creditCard {
            get {
                return this.creditCardField;
            }
            set {
                this.creditCardField = value;
            }
        }

        /// <remarks/>
        public bool ccIsPurchaseCardBin {
            get {
                return this.ccIsPurchaseCardBinField;
            }
            set {
                this.ccIsPurchaseCardBinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ccIsPurchaseCardBinSpecified {
            get {
                return this.ccIsPurchaseCardBinFieldSpecified;
            }
            set {
                this.ccIsPurchaseCardBinFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string ccNumber {
            get {
                return this.ccNumberField;
            }
            set {
                this.ccNumberField = value;
            }
        }

        /// <remarks/>
        public bool ccProcessAsPurchaseCard {
            get {
                return this.ccProcessAsPurchaseCardField;
            }
            set {
                this.ccProcessAsPurchaseCardField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ccProcessAsPurchaseCardSpecified {
            get {
                return this.ccProcessAsPurchaseCardFieldSpecified;
            }
            set {
                this.ccProcessAsPurchaseCardFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime ccExpireDate {
            get {
                return this.ccExpireDateField;
            }
            set {
                this.ccExpireDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ccExpireDateSpecified {
            get {
                return this.ccExpireDateFieldSpecified;
            }
            set {
                this.ccExpireDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string ccName {
            get {
                return this.ccNameField;
            }
            set {
                this.ccNameField = value;
            }
        }

        /// <remarks/>
        public string ccStreet {
            get {
                return this.ccStreetField;
            }
            set {
                this.ccStreetField = value;
            }
        }

        /// <remarks/>
        public string ccZipCode {
            get {
                return this.ccZipCodeField;
            }
            set {
                this.ccZipCodeField = value;
            }
        }

        /// <remarks/>
        public bool ccApproved {
            get {
                return this.ccApprovedField;
            }
            set {
                this.ccApprovedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ccApprovedSpecified {
            get {
                return this.ccApprovedFieldSpecified;
            }
            set {
                this.ccApprovedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public CustomerRefundApplyList applyList {
            get {
                return this.applyListField;
            }
            set {
                this.applyListField = value;
            }
        }

        /// <remarks/>
        public CustomerRefundDepositList depositList {
            get {
                return this.depositListField;
            }
            set {
                this.depositListField = value;
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
        public RecordRef payeeAddressList {
            get {
                return this.payeeAddressListField;
            }
            set {
                this.payeeAddressListField = value;
            }
        }

        /// <remarks/>
        public Address payeeAddress {
            get {
                return this.payeeAddressField;
            }
            set {
                this.payeeAddressField = value;
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