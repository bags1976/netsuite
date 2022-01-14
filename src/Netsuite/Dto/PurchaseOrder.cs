using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [GeneratedCode("wsdl", "4.8.3928.0")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace="urn:purchases_2021_1.transactions.webservices.netsuite.com")]
    public partial class PurchaseOrder : Record {

        private DateTime _createdDateField;

        private bool _createdDateFieldSpecified;

        private DateTime _lastModifiedDateField;

        private bool _lastModifiedDateFieldSpecified;

        private RecordRef _nexusField;

        private RecordRef _subsidiaryTaxRegNumField;

        private bool _taxRegOverrideField;

        private bool _taxRegOverrideFieldSpecified;

        private bool _taxDetailsOverrideField;

        private bool _taxDetailsOverrideFieldSpecified;

        private RecordRef _customFormField;

        private RecordRef _entityField;

        private RecordRef _purchaseContractField;

        private string _vatRegNumField;

        private RecordRef _employeeField;

        private bool _supervisorApprovalField;

        private bool _supervisorApprovalFieldSpecified;

        private DateTime _tranDateField;

        private bool _tranDateFieldSpecified;

        private string _tranIdField;

        private RecordRef _entityTaxRegNumField;

        private DateTime _taxPointDateField;

        private bool _taxPointDateFieldSpecified;

        private RecordRef _createdFromField;

        private RecordRef _termsField;

        private DateTime _dueDateField;

        private bool _dueDateFieldSpecified;

        private string _otherRefNumField;

        private decimal _availableVendorCreditField;

        private bool _availableVendorCreditFieldSpecified;

        private string _memoField;

        private RecordRef _approvalStatusField;

        private decimal _exchangeRateField;

        private bool _exchangeRateFieldSpecified;

        private RecordRef _nextApproverField;

        private string _sourceField;

        private string _currencyNameField;

        private bool _toBePrintedField;

        private bool _toBePrintedFieldSpecified;

        private bool _toBeEmailedField;

        private bool _toBeEmailedFieldSpecified;

        private string _emailField;

        private bool _toBeFaxedField;

        private bool _toBeFaxedFieldSpecified;

        private string _faxField;

        private string _messageField;

        private RecordRef _billingAddressField;

        private RecordRef _billAddressListField;

        private RecordRef _currencyField;

        private RecordRef _shipToField;

        private decimal _subTotalField;

        private bool _subTotalFieldSpecified;

        private decimal _taxTotalField;

        private bool _taxTotalFieldSpecified;

        private decimal _tax2TotalField;

        private bool _tax2TotalFieldSpecified;

        private RecordRef _shippingAddressField;

        private bool _shipIsResidentialField;

        private bool _shipIsResidentialFieldSpecified;

        private RecordRef _shipAddressListField;

        private string _fobField;

        private DateTime _shipDateField;

        private bool _shipDateFieldSpecified;

        private RecordRef _shipMethodField;

        private RecordRef _incotermField;

        private string _trackingNumbersField;

        private string _linkedTrackingNumbersField;

        private RecordRef _classField;

        private RecordRef _departmentField;

        private RecordRef _locationField;

        private RecordRef _subsidiaryField;

        private RecordRef _intercoTransactionField;

        private string _statusField;

        private PurchaseOrderOrderStatus _orderStatusField;

        private bool _orderStatusFieldSpecified;

        private PurchaseOrderItem[] _itemListField;

        private AccountingBookDetailList _accountingBookDetailListField;

        private PurchaseOrderExpenseList _expenseListField;

        private TaxDetailsList _taxDetailsListField;

        private CustomFieldRef[] _customFieldListField;

        private string _internalIdField;

        private string _externalIdField;
        
        public string CustBody_DN_PO_CustomField1 { get; set; }
        public string CustBody_DN_PO_CustomField2 { get; set; }
        public string CustBody_DN_PO_CustomField3 { get; set; }
        public string CustBody_DN_PO_CustomField4 { get; set; }
        public string CustBody_DN_PO_CustomField5 { get; set; }
        public string CustBody_DN_PO_CustomField6 { get; set; }
        public string CustBody_DN_PO_CustomField7 { get; set; }
        public string CustBody_DN_PO_CustomField8 { get; set; }
        public string CustBody_DN_PO_CustomField9 { get; set; }
        public string CustBody_DN_PO_CustomField10 { get; set; }

        
        public bool Void { get; set; }
        
        /// <remarks/>
        public DateTime CreatedDate {
            get => _createdDateField;
            set => _createdDateField = value;
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool CreatedDateSpecified {
            get => _createdDateFieldSpecified;
            set => _createdDateFieldSpecified = value;
        }

        /// <remarks/>
        public DateTime LastModifiedDate {
            get => _lastModifiedDateField;
            set => _lastModifiedDateField = value;
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool LastModifiedDateSpecified {
            get => _lastModifiedDateFieldSpecified;
            set => _lastModifiedDateFieldSpecified = value;
        }

        /// <remarks/>
        public RecordRef Nexus {
            get => _nexusField;
            set => _nexusField = value;
        }

        /// <remarks/>
        public RecordRef SubsidiaryTaxRegNum {
            get => _subsidiaryTaxRegNumField;
            set => _subsidiaryTaxRegNumField = value;
        }

        /// <remarks/>
        public bool TaxRegOverride {
            get => _taxRegOverrideField;
            set => _taxRegOverrideField = value;
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool TaxRegOverrideSpecified {
            get => _taxRegOverrideFieldSpecified;
            set => _taxRegOverrideFieldSpecified = value;
        }

        /// <remarks/>
        public bool TaxDetailsOverride {
            get => _taxDetailsOverrideField;
            set => _taxDetailsOverrideField = value;
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool TaxDetailsOverrideSpecified {
            get => _taxDetailsOverrideFieldSpecified;
            set => _taxDetailsOverrideFieldSpecified = value;
        }

        /// <remarks/>
        public RecordRef CustomForm {
            get => _customFormField;
            set => _customFormField = value;
        }

        /// <remarks/>
        public RecordRef Entity {
            get => _entityField;
            set => _entityField = value;
        }

        /// <remarks/>
        public RecordRef PurchaseContract {
            get => _purchaseContractField;
            set => _purchaseContractField = value;
        }

        /// <remarks/>
        public string VatRegNum {
            get => _vatRegNumField;
            set => _vatRegNumField = value;
        }

        /// <remarks/>
        public RecordRef Employee {
            get => _employeeField;
            set => _employeeField = value;
        }

        /// <remarks/>
        public bool SupervisorApproval {
            get => _supervisorApprovalField;
            set => _supervisorApprovalField = value;
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool SupervisorApprovalSpecified {
            get => _supervisorApprovalFieldSpecified;
            set => _supervisorApprovalFieldSpecified = value;
        }

        /// <remarks/>
        public DateTime TranDate {
            get => _tranDateField;
            set => _tranDateField = value;
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool TranDateSpecified {
            get => _tranDateFieldSpecified;
            set => _tranDateFieldSpecified = value;
        }

        /// <remarks/>
        public string TranId {
            get => _tranIdField;
            set => _tranIdField = value;
        }

        /// <remarks/>
        public RecordRef EntityTaxRegNum {
            get => _entityTaxRegNumField;
            set => _entityTaxRegNumField = value;
        }

        /// <remarks/>
        public DateTime TaxPointDate {
            get => _taxPointDateField;
            set => _taxPointDateField = value;
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool TaxPointDateSpecified {
            get => _taxPointDateFieldSpecified;
            set => _taxPointDateFieldSpecified = value;
        }

        /// <remarks/>
        public RecordRef CreatedFrom {
            get => _createdFromField;
            set => _createdFromField = value;
        }

        /// <remarks/>
        public RecordRef Terms {
            get => _termsField;
            set => _termsField = value;
        }

        /// <remarks/>
        public DateTime DueDate {
            get => _dueDateField;
            set => _dueDateField = value;
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool DueDateSpecified {
            get => _dueDateFieldSpecified;
            set => _dueDateFieldSpecified = value;
        }

        /// <remarks/>
        public string OtherRefNum {
            get => _otherRefNumField;
            set => _otherRefNumField = value;
        }

        /// <remarks/>
        public decimal AvailableVendorCredit {
            get => _availableVendorCreditField;
            set => _availableVendorCreditField = value;
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool AvailableVendorCreditSpecified {
            get => _availableVendorCreditFieldSpecified;
            set => _availableVendorCreditFieldSpecified = value;
        }

        /// <remarks/>
        public string Memo {
            get => _memoField;
            set => _memoField = value;
        }

        /// <remarks/>
        public RecordRef ApprovalStatus {
            get => _approvalStatusField;
            set => _approvalStatusField = value;
        }

        /// <remarks/>
        public decimal ExchangeRate {
            get => _exchangeRateField;
            set => _exchangeRateField = value;
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool ExchangeRateSpecified {
            get => _exchangeRateFieldSpecified;
            set => _exchangeRateFieldSpecified = value;
        }

        /// <remarks/>
        public RecordRef NextApprover {
            get => _nextApproverField;
            set => _nextApproverField = value;
        }

        /// <remarks/>
        public string Source {
            get => _sourceField;
            set => _sourceField = value;
        }

        /// <remarks/>
        public string CurrencyName {
            get => _currencyNameField;
            set => _currencyNameField = value;
        }

        /// <remarks/>
        public bool ToBePrinted {
            get => _toBePrintedField;
            set => _toBePrintedField = value;
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool ToBePrintedSpecified {
            get => _toBePrintedFieldSpecified;
            set => _toBePrintedFieldSpecified = value;
        }

        /// <remarks/>
        public bool ToBeEmailed {
            get => _toBeEmailedField;
            set => _toBeEmailedField = value;
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool ToBeEmailedSpecified {
            get => _toBeEmailedFieldSpecified;
            set => _toBeEmailedFieldSpecified = value;
        }

        /// <remarks/>
        public string Email {
            get => _emailField;
            set => _emailField = value;
        }

        /// <remarks/>
        public bool ToBeFaxed {
            get => _toBeFaxedField;
            set => _toBeFaxedField = value;
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool ToBeFaxedSpecified {
            get => _toBeFaxedFieldSpecified;
            set => _toBeFaxedFieldSpecified = value;
        }

        /// <remarks/>
        public string Fax {
            get => _faxField;
            set => _faxField = value;
        }

        /// <remarks/>
        public string Message {
            get => _messageField;
            set => _messageField = value;
        }

        /// <remarks/>
        public RecordRef BillingAddress {
            get => _billingAddressField;
            set => _billingAddressField = value;
        }

        /// <remarks/>
        public RecordRef BillAddressList {
            get => _billAddressListField;
            set => _billAddressListField = value;
        }

        /// <remarks/>
        public RecordRef Currency {
            get => _currencyField;
            set => _currencyField = value;
        }

        /// <remarks/>
        public RecordRef ShipTo {
            get => _shipToField;
            set => _shipToField = value;
        }

        /// <remarks/>
        public decimal SubTotal {
            get => _subTotalField;
            set => _subTotalField = value;
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool SubTotalSpecified {
            get => _subTotalFieldSpecified;
            set => _subTotalFieldSpecified = value;
        }

        /// <remarks/>
        public decimal TaxTotal {
            get => _taxTotalField;
            set => _taxTotalField = value;
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool TaxTotalSpecified {
            get => _taxTotalFieldSpecified;
            set => _taxTotalFieldSpecified = value;
        }

        /// <remarks/>
        public decimal Tax2Total {
            get => _tax2TotalField;
            set => _tax2TotalField = value;
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool Tax2TotalSpecified {
            get => _tax2TotalFieldSpecified;
            set => _tax2TotalFieldSpecified = value;
        }

        /// <remarks/>
        public RecordRef ShippingAddress {
            get => _shippingAddressField;
            set => _shippingAddressField = value;
        }

        /// <remarks/>
        public bool ShipIsResidential {
            get => _shipIsResidentialField;
            set => _shipIsResidentialField = value;
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool ShipIsResidentialSpecified {
            get => _shipIsResidentialFieldSpecified;
            set => _shipIsResidentialFieldSpecified = value;
        }

        /// <remarks/>
        public RecordRef ShipAddressList {
            get => _shipAddressListField;
            set => _shipAddressListField = value;
        }

        /// <remarks/>
        public string Fob {
            get => _fobField;
            set => _fobField = value;
        }

        /// <remarks/>
        public DateTime ShipDate {
            get => _shipDateField;
            set => _shipDateField = value;
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool ShipDateSpecified {
            get => _shipDateFieldSpecified;
            set => _shipDateFieldSpecified = value;
        }

        /// <remarks/>
        public RecordRef ShipMethod {
            get => _shipMethodField;
            set => _shipMethodField = value;
        }

        /// <remarks/>
        public RecordRef Incoterm {
            get => _incotermField;
            set => _incotermField = value;
        }

        /// <remarks/>
        public string TrackingNumbers {
            get => _trackingNumbersField;
            set => _trackingNumbersField = value;
        }

        /// <remarks/>
        public string LinkedTrackingNumbers {
            get => _linkedTrackingNumbersField;
            set => _linkedTrackingNumbersField = value;
        }

        /// <remarks/>
        public RecordRef Class {
            get => _classField;
            set => _classField = value;
        }

        /// <remarks/>
        public RecordRef Department {
            get => _departmentField;
            set => _departmentField = value;
        }

        /// <remarks/>
        public RecordRef Location {
            get => _locationField;
            set => _locationField = value;
        }

        /// <remarks/>
        public RecordRef Subsidiary {
            get => _subsidiaryField;
            set => _subsidiaryField = value;
        }

        /// <remarks/>
        public RecordRef IntercoTransaction {
            get => _intercoTransactionField;
            set => _intercoTransactionField = value;
        }

        /// <remarks/>
        public string Status {
            get => _statusField;
            set => _statusField = value;
        }

        /// <remarks/>
        public PurchaseOrderOrderStatus OrderStatus {
            get => _orderStatusField;
            set => _orderStatusField = value;
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool OrderStatusSpecified {
            get => _orderStatusFieldSpecified;
            set => _orderStatusFieldSpecified = value;
        }

        /// <remarks/>
        public PurchaseOrderItem[] Item {
            get => _itemListField;
            set => _itemListField = value;
        }

        /// <remarks/>
        public AccountingBookDetailList AccountingBookDetailList {
            get => _accountingBookDetailListField;
            set => _accountingBookDetailListField = value;
        }

        /// <remarks/>
        public PurchaseOrderExpenseList ExpenseList {
            get => _expenseListField;
            set => _expenseListField = value;
        }

        /// <remarks/>
        public TaxDetailsList TaxDetailsList {
            get => _taxDetailsListField;
            set => _taxDetailsListField = value;
        }

        /// <remarks/>
        [XmlArrayItem("customField", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public CustomFieldRef[] CustomFieldList {
            get => _customFieldListField;
            set => _customFieldListField = value;
        }

        /// <remarks/>
        [XmlAttribute()]
        public string InternalId {
            get => _internalIdField;
            set => _internalIdField = value;
        }

        /// <remarks/>
        [XmlAttribute()]
        public string ExternalId {
            get => _externalIdField;
            set => _externalIdField = value;
        }
    }
}