namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:customization_2021_1.setup.webservices.netsuite.com")]
    public partial class EntityCustomField : CustomFieldType {

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

        private bool availableToSsoField;

        private bool availableToSsoFieldSpecified;

        private RecordRef subtabField;

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

        private bool appliesToCustomerField;

        private bool appliesToCustomerFieldSpecified;

        private bool appliesToProjectField;

        private bool appliesToProjectFieldSpecified;

        private bool appliesToVendorField;

        private bool appliesToVendorFieldSpecified;

        private bool appliesToEmployeeField;

        private bool appliesToEmployeeFieldSpecified;

        private bool appliesToOtherNameField;

        private bool appliesToOtherNameFieldSpecified;

        private bool appliesToContactField;

        private bool appliesToContactFieldSpecified;

        private bool appliesToPartnerField;

        private bool appliesToPartnerFieldSpecified;

        private bool appliesToWebSiteField;

        private bool appliesToWebSiteFieldSpecified;

        private bool appliesToGroupField;

        private bool appliesToGroupFieldSpecified;

        private bool availableExternallyField;

        private bool availableExternallyFieldSpecified;

        private EntityCustomFieldFilterList filterListField;

        private CustomizationAccessLevel accessLevelField;

        private bool accessLevelFieldSpecified;

        private bool appliesToStatementField;

        private bool appliesToStatementFieldSpecified;

        private CustomizationSearchLevel searchLevelField;

        private bool searchLevelFieldSpecified;

        private bool appliesToPriceListField;

        private bool appliesToPriceListFieldSpecified;

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
        public RecordRef subtab {
            get {
                return this.subtabField;
            }
            set {
                this.subtabField = value;
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
        public bool appliesToCustomer {
            get {
                return this.appliesToCustomerField;
            }
            set {
                this.appliesToCustomerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool appliesToCustomerSpecified {
            get {
                return this.appliesToCustomerFieldSpecified;
            }
            set {
                this.appliesToCustomerFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool appliesToProject {
            get {
                return this.appliesToProjectField;
            }
            set {
                this.appliesToProjectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool appliesToProjectSpecified {
            get {
                return this.appliesToProjectFieldSpecified;
            }
            set {
                this.appliesToProjectFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool appliesToVendor {
            get {
                return this.appliesToVendorField;
            }
            set {
                this.appliesToVendorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool appliesToVendorSpecified {
            get {
                return this.appliesToVendorFieldSpecified;
            }
            set {
                this.appliesToVendorFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool appliesToEmployee {
            get {
                return this.appliesToEmployeeField;
            }
            set {
                this.appliesToEmployeeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool appliesToEmployeeSpecified {
            get {
                return this.appliesToEmployeeFieldSpecified;
            }
            set {
                this.appliesToEmployeeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool appliesToOtherName {
            get {
                return this.appliesToOtherNameField;
            }
            set {
                this.appliesToOtherNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool appliesToOtherNameSpecified {
            get {
                return this.appliesToOtherNameFieldSpecified;
            }
            set {
                this.appliesToOtherNameFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool appliesToContact {
            get {
                return this.appliesToContactField;
            }
            set {
                this.appliesToContactField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool appliesToContactSpecified {
            get {
                return this.appliesToContactFieldSpecified;
            }
            set {
                this.appliesToContactFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool appliesToPartner {
            get {
                return this.appliesToPartnerField;
            }
            set {
                this.appliesToPartnerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool appliesToPartnerSpecified {
            get {
                return this.appliesToPartnerFieldSpecified;
            }
            set {
                this.appliesToPartnerFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool appliesToWebSite {
            get {
                return this.appliesToWebSiteField;
            }
            set {
                this.appliesToWebSiteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool appliesToWebSiteSpecified {
            get {
                return this.appliesToWebSiteFieldSpecified;
            }
            set {
                this.appliesToWebSiteFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool appliesToGroup {
            get {
                return this.appliesToGroupField;
            }
            set {
                this.appliesToGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool appliesToGroupSpecified {
            get {
                return this.appliesToGroupFieldSpecified;
            }
            set {
                this.appliesToGroupFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool availableExternally {
            get {
                return this.availableExternallyField;
            }
            set {
                this.availableExternallyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool availableExternallySpecified {
            get {
                return this.availableExternallyFieldSpecified;
            }
            set {
                this.availableExternallyFieldSpecified = value;
            }
        }

        /// <remarks/>
        public EntityCustomFieldFilterList filterList {
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
        public bool appliesToStatement {
            get {
                return this.appliesToStatementField;
            }
            set {
                this.appliesToStatementField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool appliesToStatementSpecified {
            get {
                return this.appliesToStatementFieldSpecified;
            }
            set {
                this.appliesToStatementFieldSpecified = value;
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
        public bool appliesToPriceList {
            get {
                return this.appliesToPriceListField;
            }
            set {
                this.appliesToPriceListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool appliesToPriceListSpecified {
            get {
                return this.appliesToPriceListFieldSpecified;
            }
            set {
                this.appliesToPriceListFieldSpecified = value;
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