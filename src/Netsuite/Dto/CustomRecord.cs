namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:customization_2021_1.setup.webservices.netsuite.com")]
    public partial class CustomRecord : Record {

        private string customRecordIdField;

        private RecordRef customFormField;

        private bool isInactiveField;

        private bool isInactiveFieldSpecified;

        private RecordRef parentField;

        private string disclaimerField;

        private System.DateTime createdField;

        private bool createdFieldSpecified;

        private System.DateTime lastModifiedField;

        private bool lastModifiedFieldSpecified;

        private string nameField;

        private bool autoNameField;

        private bool autoNameFieldSpecified;

        private string altNameField;

        private RecordRef ownerField;

        private RecordRef recTypeField;

        private bool enableNumberingField;

        private bool enableNumberingFieldSpecified;

        private string numberingPrefixField;

        private string numberingSuffixField;

        private long numberingMinDigitsField;

        private bool numberingMinDigitsFieldSpecified;

        private string descriptionField;

        private long numberingInitField;

        private bool numberingInitFieldSpecified;

        private long numberingCurrentNumberField;

        private bool numberingCurrentNumberFieldSpecified;

        private bool allowNumberingOverrideField;

        private bool allowNumberingOverrideFieldSpecified;

        private bool isNumberingUpdateableField;

        private bool isNumberingUpdateableFieldSpecified;

        private CustomRecordTranslationsList translationsListField;

        private bool includeNameField;

        private bool includeNameFieldSpecified;

        private bool showIdField;

        private bool showIdFieldSpecified;

        private bool showCreationDateField;

        private bool showCreationDateFieldSpecified;

        private bool showCreationDateOnListField;

        private bool showCreationDateOnListFieldSpecified;

        private bool showLastModifiedField;

        private bool showLastModifiedFieldSpecified;

        private bool showLastModifiedOnListField;

        private bool showLastModifiedOnListFieldSpecified;

        private bool showOwnerField;

        private bool showOwnerFieldSpecified;

        private bool showOwnerOnListField;

        private bool showOwnerOnListFieldSpecified;

        private bool showOwnerAllowChangeField;

        private bool showOwnerAllowChangeFieldSpecified;

        private bool usePermissionsField;

        private bool usePermissionsFieldSpecified;

        private bool allowAttachmentsField;

        private bool allowAttachmentsFieldSpecified;

        private bool showNotesField;

        private bool showNotesFieldSpecified;

        private bool enablEmailMergeField;

        private bool enablEmailMergeFieldSpecified;

        private bool isOrderedField;

        private bool isOrderedFieldSpecified;

        private bool allowInlineEditingField;

        private bool allowInlineEditingFieldSpecified;

        private bool isAvailableOfflineField;

        private bool isAvailableOfflineFieldSpecified;

        private bool allowQuickSearchField;

        private bool allowQuickSearchFieldSpecified;

        private string recordNameField;

        private string scriptIdField;

        private CustomFieldRef[] customFieldListField;

        private string internalIdField;

        private string externalIdField;

        /// <remarks/>
        public string customRecordId {
            get {
                return this.customRecordIdField;
            }
            set {
                this.customRecordIdField = value;
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
        public RecordRef parent {
            get {
                return this.parentField;
            }
            set {
                this.parentField = value;
            }
        }

        /// <remarks/>
        public string disclaimer {
            get {
                return this.disclaimerField;
            }
            set {
                this.disclaimerField = value;
            }
        }

        /// <remarks/>
        public System.DateTime created {
            get {
                return this.createdField;
            }
            set {
                this.createdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool createdSpecified {
            get {
                return this.createdFieldSpecified;
            }
            set {
                this.createdFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime lastModified {
            get {
                return this.lastModifiedField;
            }
            set {
                this.lastModifiedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lastModifiedSpecified {
            get {
                return this.lastModifiedFieldSpecified;
            }
            set {
                this.lastModifiedFieldSpecified = value;
            }
        }

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
        public bool autoName {
            get {
                return this.autoNameField;
            }
            set {
                this.autoNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool autoNameSpecified {
            get {
                return this.autoNameFieldSpecified;
            }
            set {
                this.autoNameFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string altName {
            get {
                return this.altNameField;
            }
            set {
                this.altNameField = value;
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
        public RecordRef recType {
            get {
                return this.recTypeField;
            }
            set {
                this.recTypeField = value;
            }
        }

        /// <remarks/>
        public bool enableNumbering {
            get {
                return this.enableNumberingField;
            }
            set {
                this.enableNumberingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool enableNumberingSpecified {
            get {
                return this.enableNumberingFieldSpecified;
            }
            set {
                this.enableNumberingFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string numberingPrefix {
            get {
                return this.numberingPrefixField;
            }
            set {
                this.numberingPrefixField = value;
            }
        }

        /// <remarks/>
        public string numberingSuffix {
            get {
                return this.numberingSuffixField;
            }
            set {
                this.numberingSuffixField = value;
            }
        }

        /// <remarks/>
        public long numberingMinDigits {
            get {
                return this.numberingMinDigitsField;
            }
            set {
                this.numberingMinDigitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numberingMinDigitsSpecified {
            get {
                return this.numberingMinDigitsFieldSpecified;
            }
            set {
                this.numberingMinDigitsFieldSpecified = value;
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
        public long numberingInit {
            get {
                return this.numberingInitField;
            }
            set {
                this.numberingInitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numberingInitSpecified {
            get {
                return this.numberingInitFieldSpecified;
            }
            set {
                this.numberingInitFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long numberingCurrentNumber {
            get {
                return this.numberingCurrentNumberField;
            }
            set {
                this.numberingCurrentNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numberingCurrentNumberSpecified {
            get {
                return this.numberingCurrentNumberFieldSpecified;
            }
            set {
                this.numberingCurrentNumberFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool allowNumberingOverride {
            get {
                return this.allowNumberingOverrideField;
            }
            set {
                this.allowNumberingOverrideField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool allowNumberingOverrideSpecified {
            get {
                return this.allowNumberingOverrideFieldSpecified;
            }
            set {
                this.allowNumberingOverrideFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isNumberingUpdateable {
            get {
                return this.isNumberingUpdateableField;
            }
            set {
                this.isNumberingUpdateableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isNumberingUpdateableSpecified {
            get {
                return this.isNumberingUpdateableFieldSpecified;
            }
            set {
                this.isNumberingUpdateableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public CustomRecordTranslationsList translationsList {
            get {
                return this.translationsListField;
            }
            set {
                this.translationsListField = value;
            }
        }

        /// <remarks/>
        public bool includeName {
            get {
                return this.includeNameField;
            }
            set {
                this.includeNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool includeNameSpecified {
            get {
                return this.includeNameFieldSpecified;
            }
            set {
                this.includeNameFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool showId {
            get {
                return this.showIdField;
            }
            set {
                this.showIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool showIdSpecified {
            get {
                return this.showIdFieldSpecified;
            }
            set {
                this.showIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool showCreationDate {
            get {
                return this.showCreationDateField;
            }
            set {
                this.showCreationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool showCreationDateSpecified {
            get {
                return this.showCreationDateFieldSpecified;
            }
            set {
                this.showCreationDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool showCreationDateOnList {
            get {
                return this.showCreationDateOnListField;
            }
            set {
                this.showCreationDateOnListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool showCreationDateOnListSpecified {
            get {
                return this.showCreationDateOnListFieldSpecified;
            }
            set {
                this.showCreationDateOnListFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool showLastModified {
            get {
                return this.showLastModifiedField;
            }
            set {
                this.showLastModifiedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool showLastModifiedSpecified {
            get {
                return this.showLastModifiedFieldSpecified;
            }
            set {
                this.showLastModifiedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool showLastModifiedOnList {
            get {
                return this.showLastModifiedOnListField;
            }
            set {
                this.showLastModifiedOnListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool showLastModifiedOnListSpecified {
            get {
                return this.showLastModifiedOnListFieldSpecified;
            }
            set {
                this.showLastModifiedOnListFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool showOwner {
            get {
                return this.showOwnerField;
            }
            set {
                this.showOwnerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool showOwnerSpecified {
            get {
                return this.showOwnerFieldSpecified;
            }
            set {
                this.showOwnerFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool showOwnerOnList {
            get {
                return this.showOwnerOnListField;
            }
            set {
                this.showOwnerOnListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool showOwnerOnListSpecified {
            get {
                return this.showOwnerOnListFieldSpecified;
            }
            set {
                this.showOwnerOnListFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool showOwnerAllowChange {
            get {
                return this.showOwnerAllowChangeField;
            }
            set {
                this.showOwnerAllowChangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool showOwnerAllowChangeSpecified {
            get {
                return this.showOwnerAllowChangeFieldSpecified;
            }
            set {
                this.showOwnerAllowChangeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool usePermissions {
            get {
                return this.usePermissionsField;
            }
            set {
                this.usePermissionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool usePermissionsSpecified {
            get {
                return this.usePermissionsFieldSpecified;
            }
            set {
                this.usePermissionsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool allowAttachments {
            get {
                return this.allowAttachmentsField;
            }
            set {
                this.allowAttachmentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool allowAttachmentsSpecified {
            get {
                return this.allowAttachmentsFieldSpecified;
            }
            set {
                this.allowAttachmentsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool showNotes {
            get {
                return this.showNotesField;
            }
            set {
                this.showNotesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool showNotesSpecified {
            get {
                return this.showNotesFieldSpecified;
            }
            set {
                this.showNotesFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool enablEmailMerge {
            get {
                return this.enablEmailMergeField;
            }
            set {
                this.enablEmailMergeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool enablEmailMergeSpecified {
            get {
                return this.enablEmailMergeFieldSpecified;
            }
            set {
                this.enablEmailMergeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isOrdered {
            get {
                return this.isOrderedField;
            }
            set {
                this.isOrderedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isOrderedSpecified {
            get {
                return this.isOrderedFieldSpecified;
            }
            set {
                this.isOrderedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool allowInlineEditing {
            get {
                return this.allowInlineEditingField;
            }
            set {
                this.allowInlineEditingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool allowInlineEditingSpecified {
            get {
                return this.allowInlineEditingFieldSpecified;
            }
            set {
                this.allowInlineEditingFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isAvailableOffline {
            get {
                return this.isAvailableOfflineField;
            }
            set {
                this.isAvailableOfflineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAvailableOfflineSpecified {
            get {
                return this.isAvailableOfflineFieldSpecified;
            }
            set {
                this.isAvailableOfflineFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool allowQuickSearch {
            get {
                return this.allowQuickSearchField;
            }
            set {
                this.allowQuickSearchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool allowQuickSearchSpecified {
            get {
                return this.allowQuickSearchFieldSpecified;
            }
            set {
                this.allowQuickSearchFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string recordName {
            get {
                return this.recordNameField;
            }
            set {
                this.recordNameField = value;
            }
        }

        /// <remarks/>
        public string scriptId {
            get {
                return this.scriptIdField;
            }
            set {
                this.scriptIdField = value;
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