namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class FileSearchRowBasic : SearchRowBasic {

        private SearchColumnBooleanField[] availableWithoutLoginField;

        private SearchColumnDateField[] createdField;

        private SearchColumnDateField[] dateViewedField;

        private SearchColumnStringField[] descriptionField;

        private SearchColumnLongField[] documentSizeField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnEnumSelectField[] fileTypeField;

        private SearchColumnSelectField[] folderField;

        private SearchColumnLongField[] hitsField;

        private SearchColumnStringField[] hostedPathField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnBooleanField[] isAvailableField;

        private SearchColumnDateField[] modifiedField;

        private SearchColumnStringField[] nameField;

        private SearchColumnSelectField[] ownerField;

        private SearchColumnStringField[] urlField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("availableWithoutLogin")]
        public SearchColumnBooleanField[] availableWithoutLogin {
            get {
                return this.availableWithoutLoginField;
            }
            set {
                this.availableWithoutLoginField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("created")]
        public SearchColumnDateField[] created {
            get {
                return this.createdField;
            }
            set {
                this.createdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dateViewed")]
        public SearchColumnDateField[] dateViewed {
            get {
                return this.dateViewedField;
            }
            set {
                this.dateViewedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("description")]
        public SearchColumnStringField[] description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("documentSize")]
        public SearchColumnLongField[] documentSize {
            get {
                return this.documentSizeField;
            }
            set {
                this.documentSizeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("fileType")]
        public SearchColumnEnumSelectField[] fileType {
            get {
                return this.fileTypeField;
            }
            set {
                this.fileTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("folder")]
        public SearchColumnSelectField[] folder {
            get {
                return this.folderField;
            }
            set {
                this.folderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("hits")]
        public SearchColumnLongField[] hits {
            get {
                return this.hitsField;
            }
            set {
                this.hitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("hostedPath")]
        public SearchColumnStringField[] hostedPath {
            get {
                return this.hostedPathField;
            }
            set {
                this.hostedPathField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("isAvailable")]
        public SearchColumnBooleanField[] isAvailable {
            get {
                return this.isAvailableField;
            }
            set {
                this.isAvailableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("modified")]
        public SearchColumnDateField[] modified {
            get {
                return this.modifiedField;
            }
            set {
                this.modifiedField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("owner")]
        public SearchColumnSelectField[] owner {
            get {
                return this.ownerField;
            }
            set {
                this.ownerField = value;
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
    }
}