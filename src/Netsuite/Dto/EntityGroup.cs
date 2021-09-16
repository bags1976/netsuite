namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:relationships_2021_1.lists.webservices.netsuite.com")]
    public partial class EntityGroup : Record {

        private string groupNameField;

        private EntityGroupType groupTypeField;

        private bool groupTypeFieldSpecified;

        private string emailField;

        private RecordRef groupOwnerField;

        private bool isSavedSearchField;

        private bool isSavedSearchFieldSpecified;

        private EntityGroupType parentGroupTypeField;

        private bool parentGroupTypeFieldSpecified;

        private RecordRef savedSearchField;

        private bool isSalesTeamField;

        private bool isSalesTeamFieldSpecified;

        private string commentsField;

        private bool isPrivateField;

        private bool isPrivateFieldSpecified;

        private RecordRef restrictionGroupField;

        private bool isInactiveField;

        private bool isInactiveFieldSpecified;

        private bool isSalesRepField;

        private bool isSalesRepFieldSpecified;

        private bool isSupportRepField;

        private bool isSupportRepFieldSpecified;

        private bool isProductTeamField;

        private bool isProductTeamFieldSpecified;

        private bool isFunctionalTeamField;

        private bool isFunctionalTeamFieldSpecified;

        private RecordRef issueRoleField;

        private bool isManufacturingWorkCenterField;

        private bool isManufacturingWorkCenterFieldSpecified;

        private RecordRef subsidiaryField;

        private double machineResourcesField;

        private bool machineResourcesFieldSpecified;

        private double laborResourcesField;

        private bool laborResourcesFieldSpecified;

        private RecordRef workCalendarField;

        private CustomFieldRef[] customFieldListField;

        private string internalIdField;

        private string externalIdField;

        /// <remarks/>
        public string groupName {
            get {
                return this.groupNameField;
            }
            set {
                this.groupNameField = value;
            }
        }

        /// <remarks/>
        public EntityGroupType groupType {
            get {
                return this.groupTypeField;
            }
            set {
                this.groupTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool groupTypeSpecified {
            get {
                return this.groupTypeFieldSpecified;
            }
            set {
                this.groupTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }

        /// <remarks/>
        public RecordRef groupOwner {
            get {
                return this.groupOwnerField;
            }
            set {
                this.groupOwnerField = value;
            }
        }

        /// <remarks/>
        public bool isSavedSearch {
            get {
                return this.isSavedSearchField;
            }
            set {
                this.isSavedSearchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isSavedSearchSpecified {
            get {
                return this.isSavedSearchFieldSpecified;
            }
            set {
                this.isSavedSearchFieldSpecified = value;
            }
        }

        /// <remarks/>
        public EntityGroupType parentGroupType {
            get {
                return this.parentGroupTypeField;
            }
            set {
                this.parentGroupTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool parentGroupTypeSpecified {
            get {
                return this.parentGroupTypeFieldSpecified;
            }
            set {
                this.parentGroupTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef savedSearch {
            get {
                return this.savedSearchField;
            }
            set {
                this.savedSearchField = value;
            }
        }

        /// <remarks/>
        public bool isSalesTeam {
            get {
                return this.isSalesTeamField;
            }
            set {
                this.isSalesTeamField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isSalesTeamSpecified {
            get {
                return this.isSalesTeamFieldSpecified;
            }
            set {
                this.isSalesTeamFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string comments {
            get {
                return this.commentsField;
            }
            set {
                this.commentsField = value;
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
        public RecordRef restrictionGroup {
            get {
                return this.restrictionGroupField;
            }
            set {
                this.restrictionGroupField = value;
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
        public bool isSalesRep {
            get {
                return this.isSalesRepField;
            }
            set {
                this.isSalesRepField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isSalesRepSpecified {
            get {
                return this.isSalesRepFieldSpecified;
            }
            set {
                this.isSalesRepFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isSupportRep {
            get {
                return this.isSupportRepField;
            }
            set {
                this.isSupportRepField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isSupportRepSpecified {
            get {
                return this.isSupportRepFieldSpecified;
            }
            set {
                this.isSupportRepFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isProductTeam {
            get {
                return this.isProductTeamField;
            }
            set {
                this.isProductTeamField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isProductTeamSpecified {
            get {
                return this.isProductTeamFieldSpecified;
            }
            set {
                this.isProductTeamFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isFunctionalTeam {
            get {
                return this.isFunctionalTeamField;
            }
            set {
                this.isFunctionalTeamField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isFunctionalTeamSpecified {
            get {
                return this.isFunctionalTeamFieldSpecified;
            }
            set {
                this.isFunctionalTeamFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef issueRole {
            get {
                return this.issueRoleField;
            }
            set {
                this.issueRoleField = value;
            }
        }

        /// <remarks/>
        public bool isManufacturingWorkCenter {
            get {
                return this.isManufacturingWorkCenterField;
            }
            set {
                this.isManufacturingWorkCenterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isManufacturingWorkCenterSpecified {
            get {
                return this.isManufacturingWorkCenterFieldSpecified;
            }
            set {
                this.isManufacturingWorkCenterFieldSpecified = value;
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
        public double machineResources {
            get {
                return this.machineResourcesField;
            }
            set {
                this.machineResourcesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool machineResourcesSpecified {
            get {
                return this.machineResourcesFieldSpecified;
            }
            set {
                this.machineResourcesFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double laborResources {
            get {
                return this.laborResourcesField;
            }
            set {
                this.laborResourcesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool laborResourcesSpecified {
            get {
                return this.laborResourcesFieldSpecified;
            }
            set {
                this.laborResourcesFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef workCalendar {
            get {
                return this.workCalendarField;
            }
            set {
                this.workCalendarField = value;
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