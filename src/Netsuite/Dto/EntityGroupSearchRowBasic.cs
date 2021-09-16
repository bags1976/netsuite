namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class EntityGroupSearchRowBasic : SearchRowBasic {

        private SearchColumnStringField[] emailField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnStringField[] groupNameField;

        private SearchColumnStringField[] groupTypeField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnBooleanField[] isDynamicField;

        private SearchColumnBooleanField[] isInactiveField;

        private SearchColumnBooleanField[] isManufacturingWorkCenterField;

        private SearchColumnBooleanField[] isPrivateField;

        private SearchColumnDoubleField[] laborResourcesField;

        private SearchColumnDateField[] lastModifiedDateField;

        private SearchColumnDoubleField[] machineResourcesField;

        private SearchColumnSelectField[] ownerField;

        private SearchColumnStringField[] savedSearchField;

        private SearchColumnLongField[] sizeField;

        private SearchColumnSelectField[] subsidiaryField;

        private SearchColumnSelectField[] workCalendarField;

        private SearchColumnCustomField[] customFieldListField;

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
        [System.Xml.Serialization.XmlElementAttribute("groupName")]
        public SearchColumnStringField[] groupName {
            get {
                return this.groupNameField;
            }
            set {
                this.groupNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("groupType")]
        public SearchColumnStringField[] groupType {
            get {
                return this.groupTypeField;
            }
            set {
                this.groupTypeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("isDynamic")]
        public SearchColumnBooleanField[] isDynamic {
            get {
                return this.isDynamicField;
            }
            set {
                this.isDynamicField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("isManufacturingWorkCenter")]
        public SearchColumnBooleanField[] isManufacturingWorkCenter {
            get {
                return this.isManufacturingWorkCenterField;
            }
            set {
                this.isManufacturingWorkCenterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isPrivate")]
        public SearchColumnBooleanField[] isPrivate {
            get {
                return this.isPrivateField;
            }
            set {
                this.isPrivateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("laborResources")]
        public SearchColumnDoubleField[] laborResources {
            get {
                return this.laborResourcesField;
            }
            set {
                this.laborResourcesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lastModifiedDate")]
        public SearchColumnDateField[] lastModifiedDate {
            get {
                return this.lastModifiedDateField;
            }
            set {
                this.lastModifiedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("machineResources")]
        public SearchColumnDoubleField[] machineResources {
            get {
                return this.machineResourcesField;
            }
            set {
                this.machineResourcesField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("savedSearch")]
        public SearchColumnStringField[] savedSearch {
            get {
                return this.savedSearchField;
            }
            set {
                this.savedSearchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("size")]
        public SearchColumnLongField[] size {
            get {
                return this.sizeField;
            }
            set {
                this.sizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("subsidiary")]
        public SearchColumnSelectField[] subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("workCalendar")]
        public SearchColumnSelectField[] workCalendar {
            get {
                return this.workCalendarField;
            }
            set {
                this.workCalendarField = value;
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