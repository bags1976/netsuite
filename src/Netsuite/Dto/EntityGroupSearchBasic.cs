namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class EntityGroupSearchBasic : SearchRecordBasic {

        private SearchStringField emailField;

        private SearchMultiSelectField externalIdField;

        private SearchStringField externalIdStringField;

        private SearchStringField groupNameField;

        private SearchMultiSelectField groupOwnerField;

        private SearchMultiSelectField groupTypeField;

        private SearchMultiSelectField internalIdField;

        private SearchLongField internalIdNumberField;

        private SearchBooleanField isDynamicField;

        private SearchBooleanField isInactiveField;

        private SearchBooleanField isManufacturingWorkCenterField;

        private SearchBooleanField isPrivateField;

        private SearchDoubleField laborResourcesField;

        private SearchDateField lastModifiedDateField;

        private SearchDoubleField machineResourcesField;

        private SearchMultiSelectField subsidiaryField;

        private SearchMultiSelectField workCalendarField;

        private SearchCustomField[] customFieldListField;

        /// <remarks/>
        public SearchStringField email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField externalId {
            get {
                return this.externalIdField;
            }
            set {
                this.externalIdField = value;
            }
        }

        /// <remarks/>
        public SearchStringField externalIdString {
            get {
                return this.externalIdStringField;
            }
            set {
                this.externalIdStringField = value;
            }
        }

        /// <remarks/>
        public SearchStringField groupName {
            get {
                return this.groupNameField;
            }
            set {
                this.groupNameField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField groupOwner {
            get {
                return this.groupOwnerField;
            }
            set {
                this.groupOwnerField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField groupType {
            get {
                return this.groupTypeField;
            }
            set {
                this.groupTypeField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField internalId {
            get {
                return this.internalIdField;
            }
            set {
                this.internalIdField = value;
            }
        }

        /// <remarks/>
        public SearchLongField internalIdNumber {
            get {
                return this.internalIdNumberField;
            }
            set {
                this.internalIdNumberField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isDynamic {
            get {
                return this.isDynamicField;
            }
            set {
                this.isDynamicField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isInactive {
            get {
                return this.isInactiveField;
            }
            set {
                this.isInactiveField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isManufacturingWorkCenter {
            get {
                return this.isManufacturingWorkCenterField;
            }
            set {
                this.isManufacturingWorkCenterField = value;
            }
        }

        /// <remarks/>
        public SearchBooleanField isPrivate {
            get {
                return this.isPrivateField;
            }
            set {
                this.isPrivateField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField laborResources {
            get {
                return this.laborResourcesField;
            }
            set {
                this.laborResourcesField = value;
            }
        }

        /// <remarks/>
        public SearchDateField lastModifiedDate {
            get {
                return this.lastModifiedDateField;
            }
            set {
                this.lastModifiedDateField = value;
            }
        }

        /// <remarks/>
        public SearchDoubleField machineResources {
            get {
                return this.machineResourcesField;
            }
            set {
                this.machineResourcesField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField subsidiary {
            get {
                return this.subsidiaryField;
            }
            set {
                this.subsidiaryField = value;
            }
        }

        /// <remarks/>
        public SearchMultiSelectField workCalendar {
            get {
                return this.workCalendarField;
            }
            set {
                this.workCalendarField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("customField", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public SearchCustomField[] customFieldList {
            get {
                return this.customFieldListField;
            }
            set {
                this.customFieldListField = value;
            }
        }
    }
}