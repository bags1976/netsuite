using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:customization_2021_1.setup.webservices.netsuite.com")]
    public partial class TransactionColumnCustomField : CustomFieldType {

        private string labelField;

        private RecordRef ownerField;

        private string descriptionField;

        private RecordRef selectRecordTypeField;

        private bool storeValueField;

        private bool storeValueFieldSpecified;

        private RecordRef insertBeforeField;

        private bool availableToSsoField;

        private bool availableToSsoFieldSpecified;

        private CustomizationDisplayType displayTypeField;

        private bool displayTypeFieldSpecified;

        private long displayWidthField;

        private bool displayWidthFieldSpecified;

        private long displayHeightField;

        private bool displayHeightFieldSpecified;

        private string helpField;

        private string linkTextField;

        private bool isMandatoryField;

        private bool isMandatoryFieldSpecified;

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

        private RecordRef sourceListField;

        private RecordRef sourceFromField;

        private RecordRef sourceFilterByField;

        private RecordRef customSegmentField;

        private bool colExpenseField;

        private bool colExpenseFieldSpecified;

        private bool colPurchaseField;

        private bool colPurchaseFieldSpecified;

        private bool colSaleField;

        private bool colSaleFieldSpecified;

        private bool colOpportunityField;

        private bool colOpportunityFieldSpecified;

        private bool colStoreField;

        private bool colStoreFieldSpecified;

        private bool colStoreHiddenField;

        private bool colStoreHiddenFieldSpecified;

        private bool colJournalField;

        private bool colJournalFieldSpecified;

        private bool colBuildField;

        private bool colBuildFieldSpecified;

        private bool colExpenseReportField;

        private bool colExpenseReportFieldSpecified;

        private bool colTimeField;

        private bool colTimeFieldSpecified;

        private bool colTransferOrderField;

        private bool colTransferOrderFieldSpecified;

        private bool colTimeGroupField;

        private bool colTimeGroupFieldSpecified;

        private bool colItemReceiptField;

        private bool colItemReceiptFieldSpecified;

        private bool colItemReceiptOrderField;

        private bool colItemReceiptOrderFieldSpecified;

        private bool colItemFulfillmentField;

        private bool colItemFulfillmentFieldSpecified;

        private bool colItemFulfillmentOrderField;

        private bool colItemFulfillmentOrderFieldSpecified;

        private bool colPrintFlagField;

        private bool colPrintFlagFieldSpecified;

        private bool colPickingTicketField;

        private bool colPickingTicketFieldSpecified;

        private bool colPackingSlipField;

        private bool colPackingSlipFieldSpecified;

        private bool colReturnFormField;

        private bool colReturnFormFieldSpecified;

        private bool colStoreWithGroupsField;

        private bool colStoreWithGroupsFieldSpecified;

        private bool colGroupOnInvoicesField;

        private bool colGroupOnInvoicesFieldSpecified;

        private bool colKitItemField;

        private bool colKitItemFieldSpecified;

        private TransactionColumnCustomFieldFilterList filterListField;

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
        public RecordRef insertBefore {
            get {
                return this.insertBeforeField;
            }
            set {
                this.insertBeforeField = value;
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
        public bool colExpense {
            get {
                return this.colExpenseField;
            }
            set {
                this.colExpenseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool colExpenseSpecified {
            get {
                return this.colExpenseFieldSpecified;
            }
            set {
                this.colExpenseFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool colPurchase {
            get {
                return this.colPurchaseField;
            }
            set {
                this.colPurchaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool colPurchaseSpecified {
            get {
                return this.colPurchaseFieldSpecified;
            }
            set {
                this.colPurchaseFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool colSale {
            get {
                return this.colSaleField;
            }
            set {
                this.colSaleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool colSaleSpecified {
            get {
                return this.colSaleFieldSpecified;
            }
            set {
                this.colSaleFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool colOpportunity {
            get {
                return this.colOpportunityField;
            }
            set {
                this.colOpportunityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool colOpportunitySpecified {
            get {
                return this.colOpportunityFieldSpecified;
            }
            set {
                this.colOpportunityFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool colStore {
            get {
                return this.colStoreField;
            }
            set {
                this.colStoreField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool colStoreSpecified {
            get {
                return this.colStoreFieldSpecified;
            }
            set {
                this.colStoreFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool colStoreHidden {
            get {
                return this.colStoreHiddenField;
            }
            set {
                this.colStoreHiddenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool colStoreHiddenSpecified {
            get {
                return this.colStoreHiddenFieldSpecified;
            }
            set {
                this.colStoreHiddenFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool colJournal {
            get {
                return this.colJournalField;
            }
            set {
                this.colJournalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool colJournalSpecified {
            get {
                return this.colJournalFieldSpecified;
            }
            set {
                this.colJournalFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool colBuild {
            get {
                return this.colBuildField;
            }
            set {
                this.colBuildField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool colBuildSpecified {
            get {
                return this.colBuildFieldSpecified;
            }
            set {
                this.colBuildFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool colExpenseReport {
            get {
                return this.colExpenseReportField;
            }
            set {
                this.colExpenseReportField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool colExpenseReportSpecified {
            get {
                return this.colExpenseReportFieldSpecified;
            }
            set {
                this.colExpenseReportFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool colTime {
            get {
                return this.colTimeField;
            }
            set {
                this.colTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool colTimeSpecified {
            get {
                return this.colTimeFieldSpecified;
            }
            set {
                this.colTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool colTransferOrder {
            get {
                return this.colTransferOrderField;
            }
            set {
                this.colTransferOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool colTransferOrderSpecified {
            get {
                return this.colTransferOrderFieldSpecified;
            }
            set {
                this.colTransferOrderFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool colTimeGroup {
            get {
                return this.colTimeGroupField;
            }
            set {
                this.colTimeGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool colTimeGroupSpecified {
            get {
                return this.colTimeGroupFieldSpecified;
            }
            set {
                this.colTimeGroupFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool colItemReceipt {
            get {
                return this.colItemReceiptField;
            }
            set {
                this.colItemReceiptField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool colItemReceiptSpecified {
            get {
                return this.colItemReceiptFieldSpecified;
            }
            set {
                this.colItemReceiptFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool colItemReceiptOrder {
            get {
                return this.colItemReceiptOrderField;
            }
            set {
                this.colItemReceiptOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool colItemReceiptOrderSpecified {
            get {
                return this.colItemReceiptOrderFieldSpecified;
            }
            set {
                this.colItemReceiptOrderFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool colItemFulfillment {
            get {
                return this.colItemFulfillmentField;
            }
            set {
                this.colItemFulfillmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool colItemFulfillmentSpecified {
            get {
                return this.colItemFulfillmentFieldSpecified;
            }
            set {
                this.colItemFulfillmentFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool colItemFulfillmentOrder {
            get {
                return this.colItemFulfillmentOrderField;
            }
            set {
                this.colItemFulfillmentOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool colItemFulfillmentOrderSpecified {
            get {
                return this.colItemFulfillmentOrderFieldSpecified;
            }
            set {
                this.colItemFulfillmentOrderFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool colPrintFlag {
            get {
                return this.colPrintFlagField;
            }
            set {
                this.colPrintFlagField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool colPrintFlagSpecified {
            get {
                return this.colPrintFlagFieldSpecified;
            }
            set {
                this.colPrintFlagFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool colPickingTicket {
            get {
                return this.colPickingTicketField;
            }
            set {
                this.colPickingTicketField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool colPickingTicketSpecified {
            get {
                return this.colPickingTicketFieldSpecified;
            }
            set {
                this.colPickingTicketFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool colPackingSlip {
            get {
                return this.colPackingSlipField;
            }
            set {
                this.colPackingSlipField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool colPackingSlipSpecified {
            get {
                return this.colPackingSlipFieldSpecified;
            }
            set {
                this.colPackingSlipFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool colReturnForm {
            get {
                return this.colReturnFormField;
            }
            set {
                this.colReturnFormField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool colReturnFormSpecified {
            get {
                return this.colReturnFormFieldSpecified;
            }
            set {
                this.colReturnFormFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool colStoreWithGroups {
            get {
                return this.colStoreWithGroupsField;
            }
            set {
                this.colStoreWithGroupsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool colStoreWithGroupsSpecified {
            get {
                return this.colStoreWithGroupsFieldSpecified;
            }
            set {
                this.colStoreWithGroupsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool colGroupOnInvoices {
            get {
                return this.colGroupOnInvoicesField;
            }
            set {
                this.colGroupOnInvoicesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool colGroupOnInvoicesSpecified {
            get {
                return this.colGroupOnInvoicesFieldSpecified;
            }
            set {
                this.colGroupOnInvoicesFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool colKitItem {
            get {
                return this.colKitItemField;
            }
            set {
                this.colKitItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool colKitItemSpecified {
            get {
                return this.colKitItemFieldSpecified;
            }
            set {
                this.colKitItemFieldSpecified = value;
            }
        }

        /// <remarks/>
        public TransactionColumnCustomFieldFilterList filterList {
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