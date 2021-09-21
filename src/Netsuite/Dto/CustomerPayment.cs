using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:customers_2021_1.transactions.webservices.netsuite.com")]
    public partial class CustomerPayment : Record {

        private System.DateTime createdDateField;

        private bool createdDateFieldSpecified;

        private System.DateTime lastModifiedDateField;

        private bool lastModifiedDateFieldSpecified;

        private RecordRef customFormField;

        private RecordRef arAcctField;

        private RecordRef customerField;

        private double balanceField;

        private bool balanceFieldSpecified;

        private double pendingField;

        private bool pendingFieldSpecified;

        private RecordRef currencyField;

        private double paymentField;

        private bool paymentFieldSpecified;

        private bool autoApplyField;

        private bool autoApplyFieldSpecified;

        private System.DateTime tranDateField;

        private bool tranDateFieldSpecified;

        private string tranIdField;

        private RecordRef postingPeriodField;

        private RecordRef paymentMethodField;

        private bool ccIsPurchaseCardBinField;

        private bool ccIsPurchaseCardBinFieldSpecified;

        private string memoField;

        private bool ccProcessAsPurchaseCardField;

        private bool ccProcessAsPurchaseCardFieldSpecified;

        private string checkNumField;

        private string currencyNameField;

        private double exchangeRateField;

        private bool exchangeRateFieldSpecified;

        private RecordRef creditCardField;

        private bool chargeItField;

        private bool chargeItFieldSpecified;

        private string ccNumberField;

        private System.DateTime ccExpireDateField;

        private bool ccExpireDateFieldSpecified;

        private string ccNameField;

        private string ccStreetField;

        private string ccZipCodeField;

        private bool ccApprovedField;

        private bool ccApprovedFieldSpecified;

        private string authCodeField;

        private AvsMatchCode ccAvsStreetMatchField;

        private bool ccAvsStreetMatchFieldSpecified;

        private AvsMatchCode ccAvsZipMatchField;

        private bool ccAvsZipMatchFieldSpecified;

        private bool isRecurringPaymentField;

        private bool isRecurringPaymentFieldSpecified;

        private string ccSecurityCodeField;

        private bool ignoreAvsField;

        private bool ignoreAvsFieldSpecified;

        private AvsMatchCode ccSecurityCodeMatchField;

        private bool ccSecurityCodeMatchFieldSpecified;

        private string threeDStatusCodeField;

        private string pnRefNumField;

        private RecordRef creditCardProcessorField;

        private string debitCardIssueNoField;

        private System.DateTime validFromField;

        private bool validFromFieldSpecified;

        private bool undepFundsField;

        private bool undepFundsFieldSpecified;

        private RecordRef accountField;

        private double totalField;

        private bool totalFieldSpecified;

        private RecordRef subsidiaryField;

        private double appliedField;

        private bool appliedFieldSpecified;

        private double unappliedField;

        private bool unappliedFieldSpecified;

        private RecordRef classField;

        private RecordRef departmentField;

        private RecordRef locationField;

        private RecordRef paymentOptionField;

        private string inputAuthCodeField;

        private string inputReferenceCodeField;

        private string checkNumberField;

        private string paymentCardCscField;

        private RecordRef paymentProcessingProfileField;

        private CustomerPaymentHandlingMode handlingModeField;

        private bool handlingModeFieldSpecified;

        private string outputAuthCodeField;

        private string outputReferenceCodeField;

        private CustomerPaymentPaymentOperation paymentOperationField;

        private bool paymentOperationFieldSpecified;

        private string dynamicDescriptorField;

        private string statusField;

        private CustomerPaymentApplyList applyListField;

        private CustomerPaymentCreditList creditListField;

        private CustomerPaymentDepositList depositListField;

        private AccountingBookDetailList accountingBookDetailListField;

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
        public RecordRef customForm {
            get {
                return this.customFormField;
            }
            set {
                this.customFormField = value;
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
        public RecordRef customer {
            get {
                return this.customerField;
            }
            set {
                this.customerField = value;
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
        public double pending {
            get {
                return this.pendingField;
            }
            set {
                this.pendingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pendingSpecified {
            get {
                return this.pendingFieldSpecified;
            }
            set {
                this.pendingFieldSpecified = value;
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
        public double payment {
            get {
                return this.paymentField;
            }
            set {
                this.paymentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool paymentSpecified {
            get {
                return this.paymentFieldSpecified;
            }
            set {
                this.paymentFieldSpecified = value;
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
        public string tranId {
            get {
                return this.tranIdField;
            }
            set {
                this.tranIdField = value;
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
        public RecordRef paymentMethod {
            get {
                return this.paymentMethodField;
            }
            set {
                this.paymentMethodField = value;
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
        public string memo {
            get {
                return this.memoField;
            }
            set {
                this.memoField = value;
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
        public string checkNum {
            get {
                return this.checkNumField;
            }
            set {
                this.checkNumField = value;
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
        public RecordRef creditCard {
            get {
                return this.creditCardField;
            }
            set {
                this.creditCardField = value;
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
        public string ccNumber {
            get {
                return this.ccNumberField;
            }
            set {
                this.ccNumberField = value;
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
        public string authCode {
            get {
                return this.authCodeField;
            }
            set {
                this.authCodeField = value;
            }
        }

        /// <remarks/>
        public AvsMatchCode ccAvsStreetMatch {
            get {
                return this.ccAvsStreetMatchField;
            }
            set {
                this.ccAvsStreetMatchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ccAvsStreetMatchSpecified {
            get {
                return this.ccAvsStreetMatchFieldSpecified;
            }
            set {
                this.ccAvsStreetMatchFieldSpecified = value;
            }
        }

        /// <remarks/>
        public AvsMatchCode ccAvsZipMatch {
            get {
                return this.ccAvsZipMatchField;
            }
            set {
                this.ccAvsZipMatchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ccAvsZipMatchSpecified {
            get {
                return this.ccAvsZipMatchFieldSpecified;
            }
            set {
                this.ccAvsZipMatchFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isRecurringPayment {
            get {
                return this.isRecurringPaymentField;
            }
            set {
                this.isRecurringPaymentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isRecurringPaymentSpecified {
            get {
                return this.isRecurringPaymentFieldSpecified;
            }
            set {
                this.isRecurringPaymentFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string ccSecurityCode {
            get {
                return this.ccSecurityCodeField;
            }
            set {
                this.ccSecurityCodeField = value;
            }
        }

        /// <remarks/>
        public bool ignoreAvs {
            get {
                return this.ignoreAvsField;
            }
            set {
                this.ignoreAvsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ignoreAvsSpecified {
            get {
                return this.ignoreAvsFieldSpecified;
            }
            set {
                this.ignoreAvsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public AvsMatchCode ccSecurityCodeMatch {
            get {
                return this.ccSecurityCodeMatchField;
            }
            set {
                this.ccSecurityCodeMatchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ccSecurityCodeMatchSpecified {
            get {
                return this.ccSecurityCodeMatchFieldSpecified;
            }
            set {
                this.ccSecurityCodeMatchFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string threeDStatusCode {
            get {
                return this.threeDStatusCodeField;
            }
            set {
                this.threeDStatusCodeField = value;
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
        public RecordRef creditCardProcessor {
            get {
                return this.creditCardProcessorField;
            }
            set {
                this.creditCardProcessorField = value;
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
        public bool undepFunds {
            get {
                return this.undepFundsField;
            }
            set {
                this.undepFundsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool undepFundsSpecified {
            get {
                return this.undepFundsFieldSpecified;
            }
            set {
                this.undepFundsFieldSpecified = value;
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
        public RecordRef subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
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
        public double unapplied {
            get {
                return this.unappliedField;
            }
            set {
                this.unappliedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unappliedSpecified {
            get {
                return this.unappliedFieldSpecified;
            }
            set {
                this.unappliedFieldSpecified = value;
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
        public CustomerPaymentHandlingMode handlingMode {
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
        public CustomerPaymentPaymentOperation paymentOperation {
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
        public string status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }

        /// <remarks/>
        public CustomerPaymentApplyList applyList {
            get {
                return this.applyListField;
            }
            set {
                this.applyListField = value;
            }
        }

        /// <remarks/>
        public CustomerPaymentCreditList creditList {
            get {
                return this.creditListField;
            }
            set {
                this.creditListField = value;
            }
        }

        /// <remarks/>
        public CustomerPaymentDepositList depositList {
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