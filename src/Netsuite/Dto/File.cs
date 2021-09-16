namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:filecabinet_2021_1.documents.webservices.netsuite.com")]
    public partial class File : Record {

        private string nameField;

        private FileAttachFrom attachFromField;

        private bool attachFromFieldSpecified;

        private string mediaTypeNameField;

        private MediaType fileTypeField;

        private bool fileTypeFieldSpecified;

        private byte[] contentField;

        private RecordRef folderField;

        private double fileSizeField;

        private bool fileSizeFieldSpecified;

        private string urlField;

        private string urlComponentField;

        private RecordRef mediaFileField;

        private TextFileEncoding textFileEncodingField;

        private bool textFileEncodingFieldSpecified;

        private string descriptionField;

        private FileEncoding encodingField;

        private bool encodingFieldSpecified;

        private string altTagCaptionField;

        private bool isOnlineField;

        private bool isOnlineFieldSpecified;

        private bool isInactiveField;

        private bool isInactiveFieldSpecified;

        private string classField;

        private bool bundleableField;

        private bool bundleableFieldSpecified;

        private string departmentField;

        private bool hideInBundleField;

        private bool hideInBundleFieldSpecified;

        private bool isPrivateField;

        private bool isPrivateFieldSpecified;

        private RecordRef ownerField;

        private string captionField;

        private RecordRef storeDisplayThumbnailField;

        private string siteDescriptionField;

        private string featuredDescriptionField;

        private System.DateTime lastModifiedDateField;

        private bool lastModifiedDateFieldSpecified;

        private System.DateTime createdDateField;

        private bool createdDateFieldSpecified;

        private FileSiteCategoryList siteCategoryListField;

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
        public FileAttachFrom attachFrom {
            get {
                return this.attachFromField;
            }
            set {
                this.attachFromField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool attachFromSpecified {
            get {
                return this.attachFromFieldSpecified;
            }
            set {
                this.attachFromFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string mediaTypeName {
            get {
                return this.mediaTypeNameField;
            }
            set {
                this.mediaTypeNameField = value;
            }
        }

        /// <remarks/>
        public MediaType fileType {
            get {
                return this.fileTypeField;
            }
            set {
                this.fileTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fileTypeSpecified {
            get {
                return this.fileTypeFieldSpecified;
            }
            set {
                this.fileTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] content {
            get {
                return this.contentField;
            }
            set {
                this.contentField = value;
            }
        }

        /// <remarks/>
        public RecordRef folder {
            get {
                return this.folderField;
            }
            set {
                this.folderField = value;
            }
        }

        /// <remarks/>
        public double fileSize {
            get {
                return this.fileSizeField;
            }
            set {
                this.fileSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fileSizeSpecified {
            get {
                return this.fileSizeFieldSpecified;
            }
            set {
                this.fileSizeFieldSpecified = value;
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
        public string urlComponent {
            get {
                return this.urlComponentField;
            }
            set {
                this.urlComponentField = value;
            }
        }

        /// <remarks/>
        public RecordRef mediaFile {
            get {
                return this.mediaFileField;
            }
            set {
                this.mediaFileField = value;
            }
        }

        /// <remarks/>
        public TextFileEncoding textFileEncoding {
            get {
                return this.textFileEncodingField;
            }
            set {
                this.textFileEncodingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool textFileEncodingSpecified {
            get {
                return this.textFileEncodingFieldSpecified;
            }
            set {
                this.textFileEncodingFieldSpecified = value;
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
        public FileEncoding encoding {
            get {
                return this.encodingField;
            }
            set {
                this.encodingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool encodingSpecified {
            get {
                return this.encodingFieldSpecified;
            }
            set {
                this.encodingFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string altTagCaption {
            get {
                return this.altTagCaptionField;
            }
            set {
                this.altTagCaptionField = value;
            }
        }

        /// <remarks/>
        public bool isOnline {
            get {
                return this.isOnlineField;
            }
            set {
                this.isOnlineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isOnlineSpecified {
            get {
                return this.isOnlineFieldSpecified;
            }
            set {
                this.isOnlineFieldSpecified = value;
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
        public string @class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
            }
        }

        /// <remarks/>
        public bool bundleable {
            get {
                return this.bundleableField;
            }
            set {
                this.bundleableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bundleableSpecified {
            get {
                return this.bundleableFieldSpecified;
            }
            set {
                this.bundleableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string department {
            get {
                return this.departmentField;
            }
            set {
                this.departmentField = value;
            }
        }

        /// <remarks/>
        public bool hideInBundle {
            get {
                return this.hideInBundleField;
            }
            set {
                this.hideInBundleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hideInBundleSpecified {
            get {
                return this.hideInBundleFieldSpecified;
            }
            set {
                this.hideInBundleFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isPrivate {
            get {
                return this.isPrivateField;
            }
            set {
                this.isPrivateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPrivateSpecified {
            get {
                return this.isPrivateFieldSpecified;
            }
            set {
                this.isPrivateFieldSpecified = value;
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
        public string caption {
            get {
                return this.captionField;
            }
            set {
                this.captionField = value;
            }
        }

        /// <remarks/>
        public RecordRef storeDisplayThumbnail {
            get {
                return this.storeDisplayThumbnailField;
            }
            set {
                this.storeDisplayThumbnailField = value;
            }
        }

        /// <remarks/>
        public string siteDescription {
            get {
                return this.siteDescriptionField;
            }
            set {
                this.siteDescriptionField = value;
            }
        }

        /// <remarks/>
        public string featuredDescription {
            get {
                return this.featuredDescriptionField;
            }
            set {
                this.featuredDescriptionField = value;
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
        public FileSiteCategoryList siteCategoryList {
            get {
                return this.siteCategoryListField;
            }
            set {
                this.siteCategoryListField = value;
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