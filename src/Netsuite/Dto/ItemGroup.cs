namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class ItemGroup : Record {

        private System.DateTime createdDateField;

        private bool createdDateFieldSpecified;

        private System.DateTime lastModifiedDateField;

        private bool lastModifiedDateFieldSpecified;

        private RecordRef customFormField;

        private bool includeStartEndLinesField;

        private bool includeStartEndLinesFieldSpecified;

        private bool isVsoeBundleField;

        private bool isVsoeBundleFieldSpecified;

        private RecordRef defaultItemShipMethodField;

        private bool availableToPartnersField;

        private bool availableToPartnersFieldSpecified;

        private bool isInactiveField;

        private bool isInactiveFieldSpecified;

        private string itemIdField;

        private string upcCodeField;

        private string displayNameField;

        private string vendorNameField;

        private RecordRef issueProductField;

        private RecordRef parentField;

        private string descriptionField;

        private RecordRef[] subsidiaryListField;

        private bool includeChildrenField;

        private bool includeChildrenFieldSpecified;

        private RecordRef departmentField;

        private RecordRef classField;

        private RecordRef locationField;

        private ShippingCarrier itemCarrierField;

        private bool itemCarrierFieldSpecified;

        private RecordRef[] itemShipMethodListField;

        private bool printItemsField;

        private bool printItemsFieldSpecified;

        private ItemMemberList memberListField;

        private TranslationList translationsListField;

        private ItemGroupHierarchyVersionsList hierarchyVersionsListField;

        private CustomFieldRef[] customFieldListField;

        private string internalIdField;

        private string externalIdField;

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
        public RecordRef customForm {
            get {
                return this.customFormField;
            }
            set {
                this.customFormField = value;
            }
        }

        /// <remarks/>
        public bool includeStartEndLines {
            get {
                return this.includeStartEndLinesField;
            }
            set {
                this.includeStartEndLinesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool includeStartEndLinesSpecified {
            get {
                return this.includeStartEndLinesFieldSpecified;
            }
            set {
                this.includeStartEndLinesFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isVsoeBundle {
            get {
                return this.isVsoeBundleField;
            }
            set {
                this.isVsoeBundleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isVsoeBundleSpecified {
            get {
                return this.isVsoeBundleFieldSpecified;
            }
            set {
                this.isVsoeBundleFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef defaultItemShipMethod {
            get {
                return this.defaultItemShipMethodField;
            }
            set {
                this.defaultItemShipMethodField = value;
            }
        }

        /// <remarks/>
        public bool availableToPartners {
            get {
                return this.availableToPartnersField;
            }
            set {
                this.availableToPartnersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool availableToPartnersSpecified {
            get {
                return this.availableToPartnersFieldSpecified;
            }
            set {
                this.availableToPartnersFieldSpecified = value;
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
        public string itemId {
            get {
                return this.itemIdField;
            }
            set {
                this.itemIdField = value;
            }
        }

        /// <remarks/>
        public string upcCode {
            get {
                return this.upcCodeField;
            }
            set {
                this.upcCodeField = value;
            }
        }

        /// <remarks/>
        public string displayName {
            get {
                return this.displayNameField;
            }
            set {
                this.displayNameField = value;
            }
        }

        /// <remarks/>
        public string vendorName {
            get {
                return this.vendorNameField;
            }
            set {
                this.vendorNameField = value;
            }
        }

        /// <remarks/>
        public RecordRef issueProduct {
            get {
                return this.issueProductField;
            }
            set {
                this.issueProductField = value;
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
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recordRef", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public RecordRef[] subsidiaryList {
            get {
                return this.subsidiaryListField;
            }
            set {
                this.subsidiaryListField = value;
            }
        }

        /// <remarks/>
        public bool includeChildren {
            get {
                return this.includeChildrenField;
            }
            set {
                this.includeChildrenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool includeChildrenSpecified {
            get {
                return this.includeChildrenFieldSpecified;
            }
            set {
                this.includeChildrenFieldSpecified = value;
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
        public ShippingCarrier itemCarrier {
            get {
                return this.itemCarrierField;
            }
            set {
                this.itemCarrierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itemCarrierSpecified {
            get {
                return this.itemCarrierFieldSpecified;
            }
            set {
                this.itemCarrierFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recordRef", Namespace="urn:core_2021_1.platform.webservices.netsuite.com", IsNullable=false)]
        public RecordRef[] itemShipMethodList {
            get {
                return this.itemShipMethodListField;
            }
            set {
                this.itemShipMethodListField = value;
            }
        }

        /// <remarks/>
        public bool printItems {
            get {
                return this.printItemsField;
            }
            set {
                this.printItemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool printItemsSpecified {
            get {
                return this.printItemsFieldSpecified;
            }
            set {
                this.printItemsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ItemMemberList memberList {
            get {
                return this.memberListField;
            }
            set {
                this.memberListField = value;
            }
        }

        /// <remarks/>
        public TranslationList translationsList {
            get {
                return this.translationsListField;
            }
            set {
                this.translationsListField = value;
            }
        }

        /// <remarks/>
        public ItemGroupHierarchyVersionsList hierarchyVersionsList {
            get {
                return this.hierarchyVersionsListField;
            }
            set {
                this.hierarchyVersionsListField = value;
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