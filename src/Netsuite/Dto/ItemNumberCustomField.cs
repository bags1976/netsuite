namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:customization_2021_1.setup.webservices.netsuite.com")]
    public partial class ItemNumberCustomField : CustomFieldType {

        private string labelField;

        private RecordRef ownerField;

        private string descriptionField;

        private RecordRef selectRecordTypeField;

        private bool storeValueField;

        private bool storeValueFieldSpecified;

        private bool showInListField;

        private bool showInListFieldSpecified;

        private RecordRef insertBeforeField;

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

        private CustomizationAccessLevel accessLevelField;

        private bool accessLevelFieldSpecified;

        private CustomizationSearchLevel searchLevelField;

        private bool searchLevelFieldSpecified;

        private ItemNumberCustomFieldFilterList filterListField;

        private CustomFieldRoleAccessList roleAccessListField;

        private CustomFieldDepartmentAccessList deptAccessListField;

        private bool appliesToAllItemsField;

        private bool appliesToAllItemsFieldSpecified;

        private bool appliesToSerializedField;

        private bool appliesToSerializedFieldSpecified;

        private bool appliesToLotsField;

        private bool appliesToLotsFieldSpecified;

        private bool appliesToGiftCertsField;

        private bool appliesToGiftCertsFieldSpecified;

        private RecordRef[] itemsListField;

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
        public RecordRef insertBefore {
            get {
                return this.insertBeforeField;
            }
            set {
                this.insertBeforeField = value;
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
        public ItemNumberCustomFieldFilterList filterList {
            get {
                return this.filterListField;
            }
            set {
                this.filterListField = value;
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
        public bool appliesToAllItems {
            get {
                return this.appliesToAllItemsField;
            }
            set {
                this.appliesToAllItemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool appliesToAllItemsSpecified {
            get {
                return this.appliesToAllItemsFieldSpecified;
            }
            set {
                this.appliesToAllItemsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool appliesToSerialized {
            get {
                return this.appliesToSerializedField;
            }
            set {
                this.appliesToSerializedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool appliesToSerializedSpecified {
            get {
                return this.appliesToSerializedFieldSpecified;
            }
            set {
                this.appliesToSerializedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool appliesToLots {
            get {
                return this.appliesToLotsField;
            }
            set {
                this.appliesToLotsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool appliesToLotsSpecified {
            get {
                return this.appliesToLotsFieldSpecified;
            }
            set {
                this.appliesToLotsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool appliesToGiftCerts {
            get {
                return this.appliesToGiftCertsField;
            }
            set {
                this.appliesToGiftCertsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool appliesToGiftCertsSpecified {
            get {
                return this.appliesToGiftCertsFieldSpecified;
            }
            set {
                this.appliesToGiftCertsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recordRef", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public RecordRef[] itemsList {
            get {
                return this.itemsListField;
            }
            set {
                this.itemsListField = value;
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