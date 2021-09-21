using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class Subsidiary : Record {

        private string nameField;

        private RecordRef parentField;

        private bool isInactiveField;

        private bool isInactiveFieldSpecified;

        private bool showSubsidiaryNameField;

        private bool showSubsidiaryNameFieldSpecified;

        private string urlField;

        private RecordRef logoField;

        private string tranPrefixField;

        private RecordRef pageLogoField;

        private string stateField;

        private Country countryField;

        private bool countryFieldSpecified;

        private Address mainAddressField;

        private Address shippingAddressField;

        private Address returnAddressField;

        private string legalNameField;

        private bool isEliminationField;

        private bool isEliminationFieldSpecified;

        private RecordRef fiscalCalendarField;

        private RecordRef taxFiscalCalendarField;

        private bool allowPayrollField;

        private bool allowPayrollFieldSpecified;

        private string emailField;

        private RecordRef currencyField;

        private double purchaseOrderQuantityField;

        private bool purchaseOrderQuantityFieldSpecified;

        private double purchaseOrderAmountField;

        private bool purchaseOrderAmountFieldSpecified;

        private double purchaseOrderQuantityDiffField;

        private bool purchaseOrderQuantityDiffFieldSpecified;

        private double receiptQuantityField;

        private bool receiptQuantityFieldSpecified;

        private double receiptAmountField;

        private bool receiptAmountFieldSpecified;

        private double receiptQuantityDiffField;

        private bool receiptQuantityDiffFieldSpecified;

        private string faxField;

        private string editionField;

        private string federalIdNumberField;

        private string addrLanguageField;

        private string state1TaxNumberField;

        private SubsidiaryTaxRegistrationList taxRegistrationListField;

        private string ssnOrTinField;

        private RecordRef interCoAccountField;

        private SubsidiaryNexusList nexusListField;

        private SubsidiaryAccountingBookDetailList accountingBookDetailListField;

        private RecordRef checkLayoutField;

        private ClassTranslationList classTranslationListField;

        private CustomFieldRef[] customFieldListField;

        private string internalIdField;

        private string externalIdField;

        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public RecordRef parent {
            get {
                return this.parentField;
            }
            set {
                this.parentField = value;
            }
        }

        /// <remarks/>
        public bool isInactive {
            get {
                return this.isInactiveField;
            }
            set {
                this.isInactiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isInactiveSpecified {
            get {
                return this.isInactiveFieldSpecified;
            }
            set {
                this.isInactiveFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool showSubsidiaryName {
            get {
                return this.showSubsidiaryNameField;
            }
            set {
                this.showSubsidiaryNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool showSubsidiaryNameSpecified {
            get {
                return this.showSubsidiaryNameFieldSpecified;
            }
            set {
                this.showSubsidiaryNameFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
            }
        }

        /// <remarks/>
        public RecordRef logo {
            get {
                return this.logoField;
            }
            set {
                this.logoField = value;
            }
        }

        /// <remarks/>
        public string tranPrefix {
            get {
                return this.tranPrefixField;
            }
            set {
                this.tranPrefixField = value;
            }
        }

        /// <remarks/>
        public RecordRef pageLogo {
            get {
                return this.pageLogoField;
            }
            set {
                this.pageLogoField = value;
            }
        }

        /// <remarks/>
        public string state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }

        /// <remarks/>
        public Country country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool countrySpecified {
            get {
                return this.countryFieldSpecified;
            }
            set {
                this.countryFieldSpecified = value;
            }
        }

        /// <remarks/>
        public Address mainAddress {
            get {
                return this.mainAddressField;
            }
            set {
                this.mainAddressField = value;
            }
        }

        /// <remarks/>
        public Address shippingAddress {
            get {
                return this.shippingAddressField;
            }
            set {
                this.shippingAddressField = value;
            }
        }

        /// <remarks/>
        public Address returnAddress {
            get {
                return this.returnAddressField;
            }
            set {
                this.returnAddressField = value;
            }
        }

        /// <remarks/>
        public string legalName {
            get {
                return this.legalNameField;
            }
            set {
                this.legalNameField = value;
            }
        }

        /// <remarks/>
        public bool isElimination {
            get {
                return this.isEliminationField;
            }
            set {
                this.isEliminationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isEliminationSpecified {
            get {
                return this.isEliminationFieldSpecified;
            }
            set {
                this.isEliminationFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef fiscalCalendar {
            get {
                return this.fiscalCalendarField;
            }
            set {
                this.fiscalCalendarField = value;
            }
        }

        /// <remarks/>
        public RecordRef taxFiscalCalendar {
            get {
                return this.taxFiscalCalendarField;
            }
            set {
                this.taxFiscalCalendarField = value;
            }
        }

        /// <remarks/>
        public bool allowPayroll {
            get {
                return this.allowPayrollField;
            }
            set {
                this.allowPayrollField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool allowPayrollSpecified {
            get {
                return this.allowPayrollFieldSpecified;
            }
            set {
                this.allowPayrollFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
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
        public double purchaseOrderQuantity {
            get {
                return this.purchaseOrderQuantityField;
            }
            set {
                this.purchaseOrderQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool purchaseOrderQuantitySpecified {
            get {
                return this.purchaseOrderQuantityFieldSpecified;
            }
            set {
                this.purchaseOrderQuantityFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double purchaseOrderAmount {
            get {
                return this.purchaseOrderAmountField;
            }
            set {
                this.purchaseOrderAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool purchaseOrderAmountSpecified {
            get {
                return this.purchaseOrderAmountFieldSpecified;
            }
            set {
                this.purchaseOrderAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double purchaseOrderQuantityDiff {
            get {
                return this.purchaseOrderQuantityDiffField;
            }
            set {
                this.purchaseOrderQuantityDiffField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool purchaseOrderQuantityDiffSpecified {
            get {
                return this.purchaseOrderQuantityDiffFieldSpecified;
            }
            set {
                this.purchaseOrderQuantityDiffFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double receiptQuantity {
            get {
                return this.receiptQuantityField;
            }
            set {
                this.receiptQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool receiptQuantitySpecified {
            get {
                return this.receiptQuantityFieldSpecified;
            }
            set {
                this.receiptQuantityFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double receiptAmount {
            get {
                return this.receiptAmountField;
            }
            set {
                this.receiptAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool receiptAmountSpecified {
            get {
                return this.receiptAmountFieldSpecified;
            }
            set {
                this.receiptAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double receiptQuantityDiff {
            get {
                return this.receiptQuantityDiffField;
            }
            set {
                this.receiptQuantityDiffField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool receiptQuantityDiffSpecified {
            get {
                return this.receiptQuantityDiffFieldSpecified;
            }
            set {
                this.receiptQuantityDiffFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string fax {
            get {
                return this.faxField;
            }
            set {
                this.faxField = value;
            }
        }

        /// <remarks/>
        public string edition {
            get {
                return this.editionField;
            }
            set {
                this.editionField = value;
            }
        }

        /// <remarks/>
        public string federalIdNumber {
            get {
                return this.federalIdNumberField;
            }
            set {
                this.federalIdNumberField = value;
            }
        }

        /// <remarks/>
        public string addrLanguage {
            get {
                return this.addrLanguageField;
            }
            set {
                this.addrLanguageField = value;
            }
        }

        /// <remarks/>
        public string state1TaxNumber {
            get {
                return this.state1TaxNumberField;
            }
            set {
                this.state1TaxNumberField = value;
            }
        }

        /// <remarks/>
        public SubsidiaryTaxRegistrationList taxRegistrationList {
            get {
                return this.taxRegistrationListField;
            }
            set {
                this.taxRegistrationListField = value;
            }
        }

        /// <remarks/>
        public string ssnOrTin {
            get {
                return this.ssnOrTinField;
            }
            set {
                this.ssnOrTinField = value;
            }
        }

        /// <remarks/>
        public RecordRef interCoAccount {
            get {
                return this.interCoAccountField;
            }
            set {
                this.interCoAccountField = value;
            }
        }

        /// <remarks/>
        public SubsidiaryNexusList nexusList {
            get {
                return this.nexusListField;
            }
            set {
                this.nexusListField = value;
            }
        }

        /// <remarks/>
        public SubsidiaryAccountingBookDetailList accountingBookDetailList {
            get {
                return this.accountingBookDetailListField;
            }
            set {
                this.accountingBookDetailListField = value;
            }
        }

        /// <remarks/>
        public RecordRef checkLayout {
            get {
                return this.checkLayoutField;
            }
            set {
                this.checkLayoutField = value;
            }
        }

        /// <remarks/>
        public ClassTranslationList classTranslationList {
            get {
                return this.classTranslationListField;
            }
            set {
                this.classTranslationListField = value;
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