namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:customization_2021_1.setup.webservices.netsuite.com")]
    public partial class TransactionBodyCustomField : CustomFieldType {

        private string labelField;

        private RecordRef ownerField;

        private string descriptionField;

        private RecordRef selectRecordTypeField;

        private bool storeValueField;

        private bool storeValueFieldSpecified;

        private bool showInListField;

        private bool showInListFieldSpecified;

        private bool globalSearchField;

        private bool globalSearchFieldSpecified;

        private bool isParentField;

        private bool isParentFieldSpecified;

        private RecordRef insertBeforeField;

        private RecordRef subtabField;

        private bool availableToSsoField;

        private bool availableToSsoFieldSpecified;

        private CustomizationDisplayType displayTypeField;

        private bool displayTypeFieldSpecified;

        private long displayWidthField;

        private bool displayWidthFieldSpecified;

        private long displayHeightField;

        private bool displayHeightFieldSpecified;

        private string helpField;

        private RecordRef parentSubtabField;

        private string linkTextField;

        private bool isMandatoryField;

        private bool isMandatoryFieldSpecified;

        private bool checkSpellingField;

        private bool checkSpellingFieldSpecified;

        private long maxLengthField;

        private bool maxLengthFieldSpecified;

        private double minValueField;

        private bool minValueFieldSpecified;

        private double maxValueField;

        private bool maxValueFieldSpecified;

        private bool defaultCheckedField;

        private bool defaultCheckedFieldSpecified;

        private string defaultValueField;

        private bool isFormulaField;

        private bool isFormulaFieldSpecified;

        private RecordRef defaultSelectionField;

        private CustomizationDynamicDefault dynamicDefaultField;

        private bool dynamicDefaultFieldSpecified;

        private RecordRef searchDefaultField;

        private RecordRef searchCompareFieldField;

        private RecordRef sourceListField;

        private RecordRef sourceFromField;

        private RecordRef sourceFilterByField;

        private RecordRef customSegmentField;

        private bool bodyPurchaseField;

        private bool bodyPurchaseFieldSpecified;

        private bool bodySaleField;

        private bool bodySaleFieldSpecified;

        private bool bodyOpportunityField;

        private bool bodyOpportunityFieldSpecified;

        private bool bodyJournalField;

        private bool bodyJournalFieldSpecified;

        private bool bodyExpenseReportField;

        private bool bodyExpenseReportFieldSpecified;

        private bool bodyStoreField;

        private bool bodyStoreFieldSpecified;

        private bool bodyTransferOrderField;

        private bool bodyTransferOrderFieldSpecified;

        private bool bodyItemReceiptField;

        private bool bodyItemReceiptFieldSpecified;

        private bool bodyItemReceiptOrderField;

        private bool bodyItemReceiptOrderFieldSpecified;

        private bool bodyItemFulfillmentField;

        private bool bodyItemFulfillmentFieldSpecified;

        private bool bodyItemFulfillmentOrderField;

        private bool bodyItemFulfillmentOrderFieldSpecified;

        private bool bodyInventoryAdjustmentField;

        private bool bodyInventoryAdjustmentFieldSpecified;

        private bool bodyBTegataField;

        private bool bodyBTegataFieldSpecified;

        private bool bodyAssemblyBuildField;

        private bool bodyAssemblyBuildFieldSpecified;

        private bool bodyPrintFlagField;

        private bool bodyPrintFlagFieldSpecified;

        private bool bodyPickingTicketField;

        private bool bodyPickingTicketFieldSpecified;

        private bool bodyOtherTransactionField;

        private bool bodyOtherTransactionFieldSpecified;

        private bool bodyPrintPackingSlipField;

        private bool bodyPrintPackingSlipFieldSpecified;

        private bool bodyCustomerPaymentField;

        private bool bodyCustomerPaymentFieldSpecified;

        private bool bodyVendorPaymentField;

        private bool bodyVendorPaymentFieldSpecified;

        private bool bodyDepositField;

        private bool bodyDepositFieldSpecified;

        private bool bodyBomField;

        private bool bodyBomFieldSpecified;

        private bool bodyPrintStatementField;

        private bool bodyPrintStatementFieldSpecified;

        private TransactionBodyCustomFieldFilterList filterListField;

        private CustomizationAccessLevel accessLevelField;

        private bool accessLevelFieldSpecified;

        private CustomizationSearchLevel searchLevelField;

        private bool searchLevelFieldSpecified;

        private CustomFieldRoleAccessList roleAccessListField;

        private CustomFieldDepartmentAccessList deptAccessListField;

        private CustomFieldSubAccessList subAccessListField;

        private CustomFieldTranslationsList translationsListField;

        private string internalIdField;

        /// <remarks/>
        public string label {
            get {
                return this.labelField;
            }
            set {
                this.labelField = value;
            }
        }

        /// <remarks/>
        public RecordRef owner {
            get {
                return this.ownerField;
            }
            set {
                this.ownerField = value;
            }
        }

        /// <remarks/>
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public RecordRef selectRecordType {
            get {
                return this.selectRecordTypeField;
            }
            set {
                this.selectRecordTypeField = value;
            }
        }

        /// <remarks/>
        public bool storeValue {
            get {
                return this.storeValueField;
            }
            set {
                this.storeValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool storeValueSpecified {
            get {
                return this.storeValueFieldSpecified;
            }
            set {
                this.storeValueFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool showInList {
            get {
                return this.showInListField;
            }
            set {
                this.showInListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool showInListSpecified {
            get {
                return this.showInListFieldSpecified;
            }
            set {
                this.showInListFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool globalSearch {
            get {
                return this.globalSearchField;
            }
            set {
                this.globalSearchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool globalSearchSpecified {
            get {
                return this.globalSearchFieldSpecified;
            }
            set {
                this.globalSearchFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isParent {
            get {
                return this.isParentField;
            }
            set {
                this.isParentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isParentSpecified {
            get {
                return this.isParentFieldSpecified;
            }
            set {
                this.isParentFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef insertBefore {
            get {
                return this.insertBeforeField;
            }
            set {
                this.insertBeforeField = value;
            }
        }

        /// <remarks/>
        public RecordRef subtab {
            get {
                return this.subtabField;
            }
            set {
                this.subtabField = value;
            }
        }

        /// <remarks/>
        public bool availableToSso {
            get {
                return this.availableToSsoField;
            }
            set {
                this.availableToSsoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool availableToSsoSpecified {
            get {
                return this.availableToSsoFieldSpecified;
            }
            set {
                this.availableToSsoFieldSpecified = value;
            }
        }

        /// <remarks/>
        public CustomizationDisplayType displayType {
            get {
                return this.displayTypeField;
            }
            set {
                this.displayTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool displayTypeSpecified {
            get {
                return this.displayTypeFieldSpecified;
            }
            set {
                this.displayTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long displayWidth {
            get {
                return this.displayWidthField;
            }
            set {
                this.displayWidthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool displayWidthSpecified {
            get {
                return this.displayWidthFieldSpecified;
            }
            set {
                this.displayWidthFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long displayHeight {
            get {
                return this.displayHeightField;
            }
            set {
                this.displayHeightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool displayHeightSpecified {
            get {
                return this.displayHeightFieldSpecified;
            }
            set {
                this.displayHeightFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string help {
            get {
                return this.helpField;
            }
            set {
                this.helpField = value;
            }
        }

        /// <remarks/>
        public RecordRef parentSubtab {
            get {
                return this.parentSubtabField;
            }
            set {
                this.parentSubtabField = value;
            }
        }

        /// <remarks/>
        public string linkText {
            get {
                return this.linkTextField;
            }
            set {
                this.linkTextField = value;
            }
        }

        /// <remarks/>
        public bool isMandatory {
            get {
                return this.isMandatoryField;
            }
            set {
                this.isMandatoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isMandatorySpecified {
            get {
                return this.isMandatoryFieldSpecified;
            }
            set {
                this.isMandatoryFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool checkSpelling {
            get {
                return this.checkSpellingField;
            }
            set {
                this.checkSpellingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool checkSpellingSpecified {
            get {
                return this.checkSpellingFieldSpecified;
            }
            set {
                this.checkSpellingFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long maxLength {
            get {
                return this.maxLengthField;
            }
            set {
                this.maxLengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maxLengthSpecified {
            get {
                return this.maxLengthFieldSpecified;
            }
            set {
                this.maxLengthFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double minValue {
            get {
                return this.minValueField;
            }
            set {
                this.minValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool minValueSpecified {
            get {
                return this.minValueFieldSpecified;
            }
            set {
                this.minValueFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double maxValue {
            get {
                return this.maxValueField;
            }
            set {
                this.maxValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maxValueSpecified {
            get {
                return this.maxValueFieldSpecified;
            }
            set {
                this.maxValueFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool defaultChecked {
            get {
                return this.defaultCheckedField;
            }
            set {
                this.defaultCheckedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool defaultCheckedSpecified {
            get {
                return this.defaultCheckedFieldSpecified;
            }
            set {
                this.defaultCheckedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string defaultValue {
            get {
                return this.defaultValueField;
            }
            set {
                this.defaultValueField = value;
            }
        }

        /// <remarks/>
        public bool isFormula {
            get {
                return this.isFormulaField;
            }
            set {
                this.isFormulaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isFormulaSpecified {
            get {
                return this.isFormulaFieldSpecified;
            }
            set {
                this.isFormulaFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef defaultSelection {
            get {
                return this.defaultSelectionField;
            }
            set {
                this.defaultSelectionField = value;
            }
        }

        /// <remarks/>
        public CustomizationDynamicDefault dynamicDefault {
            get {
                return this.dynamicDefaultField;
            }
            set {
                this.dynamicDefaultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dynamicDefaultSpecified {
            get {
                return this.dynamicDefaultFieldSpecified;
            }
            set {
                this.dynamicDefaultFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef searchDefault {
            get {
                return this.searchDefaultField;
            }
            set {
                this.searchDefaultField = value;
            }
        }

        /// <remarks/>
        public RecordRef searchCompareField {
            get {
                return this.searchCompareFieldField;
            }
            set {
                this.searchCompareFieldField = value;
            }
        }

        /// <remarks/>
        public RecordRef sourceList {
            get {
                return this.sourceListField;
            }
            set {
                this.sourceListField = value;
            }
        }

        /// <remarks/>
        public RecordRef sourceFrom {
            get {
                return this.sourceFromField;
            }
            set {
                this.sourceFromField = value;
            }
        }

        /// <remarks/>
        public RecordRef sourceFilterBy {
            get {
                return this.sourceFilterByField;
            }
            set {
                this.sourceFilterByField = value;
            }
        }

        /// <remarks/>
        public RecordRef customSegment {
            get {
                return this.customSegmentField;
            }
            set {
                this.customSegmentField = value;
            }
        }

        /// <remarks/>
        public bool bodyPurchase {
            get {
                return this.bodyPurchaseField;
            }
            set {
                this.bodyPurchaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bodyPurchaseSpecified {
            get {
                return this.bodyPurchaseFieldSpecified;
            }
            set {
                this.bodyPurchaseFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool bodySale {
            get {
                return this.bodySaleField;
            }
            set {
                this.bodySaleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bodySaleSpecified {
            get {
                return this.bodySaleFieldSpecified;
            }
            set {
                this.bodySaleFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool bodyOpportunity {
            get {
                return this.bodyOpportunityField;
            }
            set {
                this.bodyOpportunityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bodyOpportunitySpecified {
            get {
                return this.bodyOpportunityFieldSpecified;
            }
            set {
                this.bodyOpportunityFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool bodyJournal {
            get {
                return this.bodyJournalField;
            }
            set {
                this.bodyJournalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bodyJournalSpecified {
            get {
                return this.bodyJournalFieldSpecified;
            }
            set {
                this.bodyJournalFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool bodyExpenseReport {
            get {
                return this.bodyExpenseReportField;
            }
            set {
                this.bodyExpenseReportField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bodyExpenseReportSpecified {
            get {
                return this.bodyExpenseReportFieldSpecified;
            }
            set {
                this.bodyExpenseReportFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool bodyStore {
            get {
                return this.bodyStoreField;
            }
            set {
                this.bodyStoreField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bodyStoreSpecified {
            get {
                return this.bodyStoreFieldSpecified;
            }
            set {
                this.bodyStoreFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool bodyTransferOrder {
            get {
                return this.bodyTransferOrderField;
            }
            set {
                this.bodyTransferOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bodyTransferOrderSpecified {
            get {
                return this.bodyTransferOrderFieldSpecified;
            }
            set {
                this.bodyTransferOrderFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool bodyItemReceipt {
            get {
                return this.bodyItemReceiptField;
            }
            set {
                this.bodyItemReceiptField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bodyItemReceiptSpecified {
            get {
                return this.bodyItemReceiptFieldSpecified;
            }
            set {
                this.bodyItemReceiptFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool bodyItemReceiptOrder {
            get {
                return this.bodyItemReceiptOrderField;
            }
            set {
                this.bodyItemReceiptOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bodyItemReceiptOrderSpecified {
            get {
                return this.bodyItemReceiptOrderFieldSpecified;
            }
            set {
                this.bodyItemReceiptOrderFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool bodyItemFulfillment {
            get {
                return this.bodyItemFulfillmentField;
            }
            set {
                this.bodyItemFulfillmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bodyItemFulfillmentSpecified {
            get {
                return this.bodyItemFulfillmentFieldSpecified;
            }
            set {
                this.bodyItemFulfillmentFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool bodyItemFulfillmentOrder {
            get {
                return this.bodyItemFulfillmentOrderField;
            }
            set {
                this.bodyItemFulfillmentOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bodyItemFulfillmentOrderSpecified {
            get {
                return this.bodyItemFulfillmentOrderFieldSpecified;
            }
            set {
                this.bodyItemFulfillmentOrderFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool bodyInventoryAdjustment {
            get {
                return this.bodyInventoryAdjustmentField;
            }
            set {
                this.bodyInventoryAdjustmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bodyInventoryAdjustmentSpecified {
            get {
                return this.bodyInventoryAdjustmentFieldSpecified;
            }
            set {
                this.bodyInventoryAdjustmentFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool bodyBTegata {
            get {
                return this.bodyBTegataField;
            }
            set {
                this.bodyBTegataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bodyBTegataSpecified {
            get {
                return this.bodyBTegataFieldSpecified;
            }
            set {
                this.bodyBTegataFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool bodyAssemblyBuild {
            get {
                return this.bodyAssemblyBuildField;
            }
            set {
                this.bodyAssemblyBuildField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bodyAssemblyBuildSpecified {
            get {
                return this.bodyAssemblyBuildFieldSpecified;
            }
            set {
                this.bodyAssemblyBuildFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool bodyPrintFlag {
            get {
                return this.bodyPrintFlagField;
            }
            set {
                this.bodyPrintFlagField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bodyPrintFlagSpecified {
            get {
                return this.bodyPrintFlagFieldSpecified;
            }
            set {
                this.bodyPrintFlagFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool bodyPickingTicket {
            get {
                return this.bodyPickingTicketField;
            }
            set {
                this.bodyPickingTicketField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bodyPickingTicketSpecified {
            get {
                return this.bodyPickingTicketFieldSpecified;
            }
            set {
                this.bodyPickingTicketFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool bodyOtherTransaction {
            get {
                return this.bodyOtherTransactionField;
            }
            set {
                this.bodyOtherTransactionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bodyOtherTransactionSpecified {
            get {
                return this.bodyOtherTransactionFieldSpecified;
            }
            set {
                this.bodyOtherTransactionFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool bodyPrintPackingSlip {
            get {
                return this.bodyPrintPackingSlipField;
            }
            set {
                this.bodyPrintPackingSlipField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bodyPrintPackingSlipSpecified {
            get {
                return this.bodyPrintPackingSlipFieldSpecified;
            }
            set {
                this.bodyPrintPackingSlipFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool bodyCustomerPayment {
            get {
                return this.bodyCustomerPaymentField;
            }
            set {
                this.bodyCustomerPaymentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bodyCustomerPaymentSpecified {
            get {
                return this.bodyCustomerPaymentFieldSpecified;
            }
            set {
                this.bodyCustomerPaymentFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool bodyVendorPayment {
            get {
                return this.bodyVendorPaymentField;
            }
            set {
                this.bodyVendorPaymentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bodyVendorPaymentSpecified {
            get {
                return this.bodyVendorPaymentFieldSpecified;
            }
            set {
                this.bodyVendorPaymentFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool bodyDeposit {
            get {
                return this.bodyDepositField;
            }
            set {
                this.bodyDepositField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bodyDepositSpecified {
            get {
                return this.bodyDepositFieldSpecified;
            }
            set {
                this.bodyDepositFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool bodyBom {
            get {
                return this.bodyBomField;
            }
            set {
                this.bodyBomField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bodyBomSpecified {
            get {
                return this.bodyBomFieldSpecified;
            }
            set {
                this.bodyBomFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool bodyPrintStatement {
            get {
                return this.bodyPrintStatementField;
            }
            set {
                this.bodyPrintStatementField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bodyPrintStatementSpecified {
            get {
                return this.bodyPrintStatementFieldSpecified;
            }
            set {
                this.bodyPrintStatementFieldSpecified = value;
            }
        }

        /// <remarks/>
        public TransactionBodyCustomFieldFilterList filterList {
            get {
                return this.filterListField;
            }
            set {
                this.filterListField = value;
            }
        }

        /// <remarks/>
        public CustomizationAccessLevel accessLevel {
            get {
                return this.accessLevelField;
            }
            set {
                this.accessLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool accessLevelSpecified {
            get {
                return this.accessLevelFieldSpecified;
            }
            set {
                this.accessLevelFieldSpecified = value;
            }
        }

        /// <remarks/>
        public CustomizationSearchLevel searchLevel {
            get {
                return this.searchLevelField;
            }
            set {
                this.searchLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool searchLevelSpecified {
            get {
                return this.searchLevelFieldSpecified;
            }
            set {
                this.searchLevelFieldSpecified = value;
            }
        }

        /// <remarks/>
        public CustomFieldRoleAccessList roleAccessList {
            get {
                return this.roleAccessListField;
            }
            set {
                this.roleAccessListField = value;
            }
        }

        /// <remarks/>
        public CustomFieldDepartmentAccessList deptAccessList {
            get {
                return this.deptAccessListField;
            }
            set {
                this.deptAccessListField = value;
            }
        }

        /// <remarks/>
        public CustomFieldSubAccessList subAccessList {
            get {
                return this.subAccessListField;
            }
            set {
                this.subAccessListField = value;
            }
        }

        /// <remarks/>
        public CustomFieldTranslationsList translationsList {
            get {
                return this.translationsListField;
            }
            set {
                this.translationsListField = value;
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
    }
}