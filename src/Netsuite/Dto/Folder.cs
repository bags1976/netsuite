using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:filecabinet_2021_1.documents.webservices.netsuite.com")]
    public partial class Folder : Record {

        private string nameField;

        private RecordRef departmentField;

        private string descriptionField;

        private bool isInactiveField;

        private bool isInactiveFieldSpecified;

        private bool isPrivateField;

        private bool isPrivateFieldSpecified;

        private bool bundleableField;

        private bool bundleableFieldSpecified;

        private bool hideInBundleField;

        private bool hideInBundleFieldSpecified;

        private bool isOnlineField;

        private bool isOnlineFieldSpecified;

        private RecordRef groupField;

        private RecordRef parentField;

        private FolderFolderType folderTypeField;

        private bool folderTypeFieldSpecified;

        private RecordRef classField;

        private RecordRef locationField;

        private RecordRef subsidiaryField;

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
        public RecordRef department {
            get {
                return this.departmentField;
            }
            set {
                this.departmentField = value;
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
        public RecordRef group {
            get {
                return this.groupField;
            }
            set {
                this.groupField = value;
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
        public FolderFolderType folderType {
            get {
                return this.folderTypeField;
            }
            set {
                this.folderTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool folderTypeSpecified {
            get {
                return this.folderTypeFieldSpecified;
            }
            set {
                this.folderTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef @class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
            }
        }

        /// <remarks/>
        public RecordRef location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }

        /// <remarks/>
        public RecordRef subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
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