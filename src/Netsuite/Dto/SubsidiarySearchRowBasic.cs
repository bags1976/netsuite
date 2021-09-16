namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class SubsidiarySearchRowBasic : SearchRowBasic {

        private SearchColumnSelectField[] accountingBookField;

        private SearchColumnSelectField[] accountingBookCurrencyField;

        private SearchColumnStringField[] address1Field;

        private SearchColumnStringField[] address2Field;

        private SearchColumnStringField[] address3Field;

        private SearchColumnStringField[] anonymousCustomerInboundEmailField;

        private SearchColumnStringField[] anonymousCustomerOnlineFormsField;

        private SearchColumnStringField[] caseAssignmentTemplateField;

        private SearchColumnStringField[] caseAutomaticClosureTemplateField;

        private SearchColumnStringField[] caseCopyEmployeeTemplateField;

        private SearchColumnStringField[] caseCreationTemplateField;

        private SearchColumnStringField[] caseEscalationTemplateField;

        private SearchColumnStringField[] caseUpdateTemplateField;

        private SearchColumnStringField[] cityField;

        private SearchColumnStringField[] companyNameForSupportMessagesField;

        private SearchColumnEnumSelectField[] countryField;

        private SearchColumnSelectField[] currencyField;

        private SearchColumnDateField[] effectiveFromField;

        private SearchColumnStringField[] emailField;

        private SearchColumnStringField[] employeeCaseUpdateTemplateField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnStringField[] faxField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnBooleanField[] isEliminationField;

        private SearchColumnBooleanField[] isInactiveField;

        private SearchColumnStringField[] legalNameField;

        private SearchColumnStringField[] mainSupportEmailAddressField;

        private SearchColumnStringField[] nameField;

        private SearchColumnStringField[] nameNoHierarchyField;

        private SearchColumnSelectField[] nexusField;

        private SearchColumnStringField[] phoneField;

        private SearchColumnDoubleField[] purchaseOrderAmountField;

        private SearchColumnDoubleField[] purchaseOrderQuantityField;

        private SearchColumnDoubleField[] purchaseOrderQuantityDiffField;

        private SearchColumnDoubleField[] receiptAmountField;

        private SearchColumnDoubleField[] receiptQuantityField;

        private SearchColumnDoubleField[] receiptQuantityDiffField;

        private SearchColumnStringField[] stateField;

        private SearchColumnSelectField[] taxEngineField;

        private SearchColumnStringField[] taxIdNumField;

        private SearchColumnStringField[] taxRegistrationNumberField;

        private SearchColumnStringField[] tranPrefixField;

        private SearchColumnStringField[] urlField;

        private SearchColumnDateField[] validUntilField;

        private SearchColumnStringField[] zipField;

        private SearchColumnCustomField[] customFieldListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("accountingBook")]
        public SearchColumnSelectField[] accountingBook {
            get {
                return this.accountingBookField;
            }
            set {
                this.accountingBookField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("accountingBookCurrency")]
        public SearchColumnSelectField[] accountingBookCurrency {
            get {
                return this.accountingBookCurrencyField;
            }
            set {
                this.accountingBookCurrencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("address1")]
        public SearchColumnStringField[] address1 {
            get {
                return this.address1Field;
            }
            set {
                this.address1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("address2")]
        public SearchColumnStringField[] address2 {
            get {
                return this.address2Field;
            }
            set {
                this.address2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("address3")]
        public SearchColumnStringField[] address3 {
            get {
                return this.address3Field;
            }
            set {
                this.address3Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("anonymousCustomerInboundEmail")]
        public SearchColumnStringField[] anonymousCustomerInboundEmail {
            get {
                return this.anonymousCustomerInboundEmailField;
            }
            set {
                this.anonymousCustomerInboundEmailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("anonymousCustomerOnlineForms")]
        public SearchColumnStringField[] anonymousCustomerOnlineForms {
            get {
                return this.anonymousCustomerOnlineFormsField;
            }
            set {
                this.anonymousCustomerOnlineFormsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("caseAssignmentTemplate")]
        public SearchColumnStringField[] caseAssignmentTemplate {
            get {
                return this.caseAssignmentTemplateField;
            }
            set {
                this.caseAssignmentTemplateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("caseAutomaticClosureTemplate")]
        public SearchColumnStringField[] caseAutomaticClosureTemplate {
            get {
                return this.caseAutomaticClosureTemplateField;
            }
            set {
                this.caseAutomaticClosureTemplateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("caseCopyEmployeeTemplate")]
        public SearchColumnStringField[] caseCopyEmployeeTemplate {
            get {
                return this.caseCopyEmployeeTemplateField;
            }
            set {
                this.caseCopyEmployeeTemplateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("caseCreationTemplate")]
        public SearchColumnStringField[] caseCreationTemplate {
            get {
                return this.caseCreationTemplateField;
            }
            set {
                this.caseCreationTemplateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("caseEscalationTemplate")]
        public SearchColumnStringField[] caseEscalationTemplate {
            get {
                return this.caseEscalationTemplateField;
            }
            set {
                this.caseEscalationTemplateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("caseUpdateTemplate")]
        public SearchColumnStringField[] caseUpdateTemplate {
            get {
                return this.caseUpdateTemplateField;
            }
            set {
                this.caseUpdateTemplateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("city")]
        public SearchColumnStringField[] city {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("companyNameForSupportMessages")]
        public SearchColumnStringField[] companyNameForSupportMessages {
            get {
                return this.companyNameForSupportMessagesField;
            }
            set {
                this.companyNameForSupportMessagesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("country")]
        public SearchColumnEnumSelectField[] country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("currency")]
        public SearchColumnSelectField[] currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("effectiveFrom")]
        public SearchColumnDateField[] effectiveFrom {
            get {
                return this.effectiveFromField;
            }
            set {
                this.effectiveFromField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("email")]
        public SearchColumnStringField[] email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("employeeCaseUpdateTemplate")]
        public SearchColumnStringField[] employeeCaseUpdateTemplate {
            get {
                return this.employeeCaseUpdateTemplateField;
            }
            set {
                this.employeeCaseUpdateTemplateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("externalId")]
        public SearchColumnSelectField[] externalId {
            get {
                return this.externalIdField;
            }
            set {
                this.externalIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fax")]
        public SearchColumnStringField[] fax {
            get {
                return this.faxField;
            }
            set {
                this.faxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("internalId")]
        public SearchColumnSelectField[] internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isElimination")]
        public SearchColumnBooleanField[] isElimination {
            get {
                return this.isEliminationField;
            }
            set {
                this.isEliminationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isInactive")]
        public SearchColumnBooleanField[] isInactive {
            get {
                return this.isInactiveField;
            }
            set {
                this.isInactiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("legalName")]
        public SearchColumnStringField[] legalName {
            get {
                return this.legalNameField;
            }
            set {
                this.legalNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mainSupportEmailAddress")]
        public SearchColumnStringField[] mainSupportEmailAddress {
            get {
                return this.mainSupportEmailAddressField;
            }
            set {
                this.mainSupportEmailAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("name")]
        public SearchColumnStringField[] name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("nameNoHierarchy")]
        public SearchColumnStringField[] nameNoHierarchy {
            get {
                return this.nameNoHierarchyField;
            }
            set {
                this.nameNoHierarchyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("nexus")]
        public SearchColumnSelectField[] nexus {
            get {
                return this.nexusField;
            }
            set {
                this.nexusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("phone")]
        public SearchColumnStringField[] phone {
            get {
                return this.phoneField;
            }
            set {
                this.phoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("purchaseOrderAmount")]
        public SearchColumnDoubleField[] purchaseOrderAmount {
            get {
                return this.purchaseOrderAmountField;
            }
            set {
                this.purchaseOrderAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("purchaseOrderQuantity")]
        public SearchColumnDoubleField[] purchaseOrderQuantity {
            get {
                return this.purchaseOrderQuantityField;
            }
            set {
                this.purchaseOrderQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("purchaseOrderQuantityDiff")]
        public SearchColumnDoubleField[] purchaseOrderQuantityDiff {
            get {
                return this.purchaseOrderQuantityDiffField;
            }
            set {
                this.purchaseOrderQuantityDiffField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("receiptAmount")]
        public SearchColumnDoubleField[] receiptAmount {
            get {
                return this.receiptAmountField;
            }
            set {
                this.receiptAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("receiptQuantity")]
        public SearchColumnDoubleField[] receiptQuantity {
            get {
                return this.receiptQuantityField;
            }
            set {
                this.receiptQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("receiptQuantityDiff")]
        public SearchColumnDoubleField[] receiptQuantityDiff {
            get {
                return this.receiptQuantityDiffField;
            }
            set {
                this.receiptQuantityDiffField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("state")]
        public SearchColumnStringField[] state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("taxEngine")]
        public SearchColumnSelectField[] taxEngine {
            get {
                return this.taxEngineField;
            }
            set {
                this.taxEngineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("taxIdNum")]
        public SearchColumnStringField[] taxIdNum {
            get {
                return this.taxIdNumField;
            }
            set {
                this.taxIdNumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("taxRegistrationNumber")]
        public SearchColumnStringField[] taxRegistrationNumber {
            get {
                return this.taxRegistrationNumberField;
            }
            set {
                this.taxRegistrationNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tranPrefix")]
        public SearchColumnStringField[] tranPrefix {
            get {
                return this.tranPrefixField;
            }
            set {
                this.tranPrefixField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("url")]
        public SearchColumnStringField[] url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("validUntil")]
        public SearchColumnDateField[] validUntil {
            get {
                return this.validUntilField;
            }
            set {
                this.validUntilField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("zip")]
        public SearchColumnStringField[] zip {
            get {
                return this.zipField;
            }
            set {
                this.zipField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("customField", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public SearchColumnCustomField[] customFieldList {
            get {
                return this.customFieldListField;
            }
            set {
                this.customFieldListField = value;
            }
        }
    }
}