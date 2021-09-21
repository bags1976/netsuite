using Netsuite.Enum;

namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:accounting_2021_1.lists.webservices.netsuite.com")]
    public partial class Location : Record {

        private string nameField;

        private RecordRef parentField;

        private bool includeChildrenField;

        private bool includeChildrenFieldSpecified;

        private RecordRef[] subsidiaryListField;

        private bool isInactiveField;

        private bool isInactiveFieldSpecified;

        private string tranPrefixField;

        private Address mainAddressField;

        private Address returnAddressField;

        private LocationType locationTypeField;

        private bool locationTypeFieldSpecified;

        private LocationTimeZone timeZoneField;

        private bool timeZoneFieldSpecified;

        private double latitudeField;

        private bool latitudeFieldSpecified;

        private double longitudeField;

        private bool longitudeFieldSpecified;

        private RecordRef logoField;

        private bool useBinsField;

        private bool useBinsFieldSpecified;

        private bool makeInventoryAvailableField;

        private bool makeInventoryAvailableFieldSpecified;

        private bool makeInventoryAvailableStoreField;

        private bool makeInventoryAvailableStoreFieldSpecified;

        private LocationGeolocationMethod geolocationMethodField;

        private bool geolocationMethodFieldSpecified;

        private LocationAutoAssignmentRegionSetting autoAssignmentRegionSettingField;

        private bool autoAssignmentRegionSettingFieldSpecified;

        private System.DateTime nextPickupCutOffTimeField;

        private bool nextPickupCutOffTimeFieldSpecified;

        private long bufferStockField;

        private bool bufferStockFieldSpecified;

        private bool allowStorePickupField;

        private bool allowStorePickupFieldSpecified;

        private double storePickupBufferStockField;

        private bool storePickupBufferStockFieldSpecified;

        private long dailyShippingCapacityField;

        private bool dailyShippingCapacityFieldSpecified;

        private long totalShippingCapacityField;

        private bool totalShippingCapacityFieldSpecified;

        private LocationRegionsList includeLocationRegionsListField;

        private LocationRegionsList excludeLocationRegionsListField;

        private LocationBusinessHoursList businessHoursListField;

        private ClassTranslationList classTranslationListField;

        private bool includeInControlTowerField;

        private bool includeInControlTowerFieldSpecified;

        private long soPredictedDaysField;

        private bool soPredictedDaysFieldSpecified;

        private double soPredConfidenceField;

        private bool soPredConfidenceFieldSpecified;

        private CustomFieldRef[] customFieldListField;

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
        public RecordRef parent {
            get {
                return this.parentField;
            }
            set {
                this.parentField = value;
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
        public string tranPrefix {
            get {
                return this.tranPrefixField;
            }
            set {
                this.tranPrefixField = value;
            }
        }

        /// <remarks/>
        public Address mainAddress {
            get {
                return this.mainAddressField;
            }
            set {
                this.mainAddressField = value;
            }
        }

        /// <remarks/>
        public Address returnAddress {
            get {
                return this.returnAddressField;
            }
            set {
                this.returnAddressField = value;
            }
        }

        /// <remarks/>
        public LocationType locationType {
            get {
                return this.locationTypeField;
            }
            set {
                this.locationTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool locationTypeSpecified {
            get {
                return this.locationTypeFieldSpecified;
            }
            set {
                this.locationTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public LocationTimeZone timeZone {
            get {
                return this.timeZoneField;
            }
            set {
                this.timeZoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool timeZoneSpecified {
            get {
                return this.timeZoneFieldSpecified;
            }
            set {
                this.timeZoneFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double latitude {
            get {
                return this.latitudeField;
            }
            set {
                this.latitudeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool latitudeSpecified {
            get {
                return this.latitudeFieldSpecified;
            }
            set {
                this.latitudeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double longitude {
            get {
                return this.longitudeField;
            }
            set {
                this.longitudeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool longitudeSpecified {
            get {
                return this.longitudeFieldSpecified;
            }
            set {
                this.longitudeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RecordRef logo {
            get {
                return this.logoField;
            }
            set {
                this.logoField = value;
            }
        }

        /// <remarks/>
        public bool useBins {
            get {
                return this.useBinsField;
            }
            set {
                this.useBinsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool useBinsSpecified {
            get {
                return this.useBinsFieldSpecified;
            }
            set {
                this.useBinsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool makeInventoryAvailable {
            get {
                return this.makeInventoryAvailableField;
            }
            set {
                this.makeInventoryAvailableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool makeInventoryAvailableSpecified {
            get {
                return this.makeInventoryAvailableFieldSpecified;
            }
            set {
                this.makeInventoryAvailableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool makeInventoryAvailableStore {
            get {
                return this.makeInventoryAvailableStoreField;
            }
            set {
                this.makeInventoryAvailableStoreField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool makeInventoryAvailableStoreSpecified {
            get {
                return this.makeInventoryAvailableStoreFieldSpecified;
            }
            set {
                this.makeInventoryAvailableStoreFieldSpecified = value;
            }
        }

        /// <remarks/>
        public LocationGeolocationMethod geolocationMethod {
            get {
                return this.geolocationMethodField;
            }
            set {
                this.geolocationMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool geolocationMethodSpecified {
            get {
                return this.geolocationMethodFieldSpecified;
            }
            set {
                this.geolocationMethodFieldSpecified = value;
            }
        }

        /// <remarks/>
        public LocationAutoAssignmentRegionSetting autoAssignmentRegionSetting {
            get {
                return this.autoAssignmentRegionSettingField;
            }
            set {
                this.autoAssignmentRegionSettingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool autoAssignmentRegionSettingSpecified {
            get {
                return this.autoAssignmentRegionSettingFieldSpecified;
            }
            set {
                this.autoAssignmentRegionSettingFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime nextPickupCutOffTime {
            get {
                return this.nextPickupCutOffTimeField;
            }
            set {
                this.nextPickupCutOffTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nextPickupCutOffTimeSpecified {
            get {
                return this.nextPickupCutOffTimeFieldSpecified;
            }
            set {
                this.nextPickupCutOffTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long bufferStock {
            get {
                return this.bufferStockField;
            }
            set {
                this.bufferStockField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bufferStockSpecified {
            get {
                return this.bufferStockFieldSpecified;
            }
            set {
                this.bufferStockFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool allowStorePickup {
            get {
                return this.allowStorePickupField;
            }
            set {
                this.allowStorePickupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool allowStorePickupSpecified {
            get {
                return this.allowStorePickupFieldSpecified;
            }
            set {
                this.allowStorePickupFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double storePickupBufferStock {
            get {
                return this.storePickupBufferStockField;
            }
            set {
                this.storePickupBufferStockField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool storePickupBufferStockSpecified {
            get {
                return this.storePickupBufferStockFieldSpecified;
            }
            set {
                this.storePickupBufferStockFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long dailyShippingCapacity {
            get {
                return this.dailyShippingCapacityField;
            }
            set {
                this.dailyShippingCapacityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dailyShippingCapacitySpecified {
            get {
                return this.dailyShippingCapacityFieldSpecified;
            }
            set {
                this.dailyShippingCapacityFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long totalShippingCapacity {
            get {
                return this.totalShippingCapacityField;
            }
            set {
                this.totalShippingCapacityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totalShippingCapacitySpecified {
            get {
                return this.totalShippingCapacityFieldSpecified;
            }
            set {
                this.totalShippingCapacityFieldSpecified = value;
            }
        }

        /// <remarks/>
        public LocationRegionsList includeLocationRegionsList {
            get {
                return this.includeLocationRegionsListField;
            }
            set {
                this.includeLocationRegionsListField = value;
            }
        }

        /// <remarks/>
        public LocationRegionsList excludeLocationRegionsList {
            get {
                return this.excludeLocationRegionsListField;
            }
            set {
                this.excludeLocationRegionsListField = value;
            }
        }

        /// <remarks/>
        public LocationBusinessHoursList businessHoursList {
            get {
                return this.businessHoursListField;
            }
            set {
                this.businessHoursListField = value;
            }
        }

        /// <remarks/>
        public ClassTranslationList classTranslationList {
            get {
                return this.classTranslationListField;
            }
            set {
                this.classTranslationListField = value;
            }
        }

        /// <remarks/>
        public bool includeInControlTower {
            get {
                return this.includeInControlTowerField;
            }
            set {
                this.includeInControlTowerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool includeInControlTowerSpecified {
            get {
                return this.includeInControlTowerFieldSpecified;
            }
            set {
                this.includeInControlTowerFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long soPredictedDays {
            get {
                return this.soPredictedDaysField;
            }
            set {
                this.soPredictedDaysField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool soPredictedDaysSpecified {
            get {
                return this.soPredictedDaysFieldSpecified;
            }
            set {
                this.soPredictedDaysFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double soPredConfidence {
            get {
                return this.soPredConfidenceField;
            }
            set {
                this.soPredConfidenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool soPredConfidenceSpecified {
            get {
                return this.soPredConfidenceFieldSpecified;
            }
            set {
                this.soPredConfidenceFieldSpecified = value;
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