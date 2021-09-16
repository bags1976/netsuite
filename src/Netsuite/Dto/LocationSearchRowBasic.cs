namespace Netsuite.Dto
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:common_2021_1.platform.webservices.netsuite.com")]
    public partial class LocationSearchRowBasic : SearchRowBasic {

        private SearchColumnStringField[] address1Field;

        private SearchColumnStringField[] address2Field;

        private SearchColumnStringField[] address3Field;

        private SearchColumnBooleanField[] allowStorePickupField;

        private SearchColumnEnumSelectField[] autoAssignmentRegionSettingField;

        private SearchColumnLongField[] bufferStockField;

        private SearchColumnStringField[] cityField;

        private SearchColumnEnumSelectField[] countryField;

        private SearchColumnLongField[] dailyShippingCapacityField;

        private SearchColumnDateField[] endTimeField;

        private SearchColumnSelectField[] externalIdField;

        private SearchColumnEnumSelectField[] geolocationMethodField;

        private SearchColumnSelectField[] internalIdField;

        private SearchColumnBooleanField[] isFridayField;

        private SearchColumnBooleanField[] isInactiveField;

        private SearchColumnBooleanField[] isIncludeInCtField;

        private SearchColumnBooleanField[] isMondayField;

        private SearchColumnBooleanField[] isOfficeField;

        private SearchColumnBooleanField[] isSaturdayField;

        private SearchColumnBooleanField[] isSundayField;

        private SearchColumnBooleanField[] isThursdayField;

        private SearchColumnBooleanField[] isTuesdayField;

        private SearchColumnBooleanField[] isWednesdayField;

        private SearchColumnDoubleField[] latitudeField;

        private SearchColumnEnumSelectField[] locationTypeField;

        private SearchColumnDoubleField[] longitudeField;

        private SearchColumnBooleanField[] makeInventoryAvailableField;

        private SearchColumnBooleanField[] makeInventoryAvailableStoreField;

        private SearchColumnStringField[] nameField;

        private SearchColumnStringField[] nameNoHierarchyField;

        private SearchColumnDateField[] nextPickupCutOffTimeField;

        private SearchColumnStringField[] phoneField;

        private SearchColumnDateField[] sameDayPickupCutOffTimeField;

        private SearchColumnDoubleField[] soPredConfidenceField;

        private SearchColumnLongField[] soPredictedDaysField;

        private SearchColumnDateField[] startTimeField;

        private SearchColumnStringField[] stateField;

        private SearchColumnDoubleField[] storePickupBufferStockField;

        private SearchColumnSelectField[] subsidiaryField;

        private SearchColumnEnumSelectField[] timeZoneField;

        private SearchColumnLongField[] totalShippingCapacityField;

        private SearchColumnStringField[] tranPrefixField;

        private SearchColumnBooleanField[] usesBinsField;

        private SearchColumnStringField[] zipField;

        private SearchColumnCustomField[] customFieldListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("address1")]
        public SearchColumnStringField[] address1 {
            get {
                return this.address1Field;
            }
            set {
                this.address1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("address2")]
        public SearchColumnStringField[] address2 {
            get {
                return this.address2Field;
            }
            set {
                this.address2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("address3")]
        public SearchColumnStringField[] address3 {
            get {
                return this.address3Field;
            }
            set {
                this.address3Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("allowStorePickup")]
        public SearchColumnBooleanField[] allowStorePickup {
            get {
                return this.allowStorePickupField;
            }
            set {
                this.allowStorePickupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("autoAssignmentRegionSetting")]
        public SearchColumnEnumSelectField[] autoAssignmentRegionSetting {
            get {
                return this.autoAssignmentRegionSettingField;
            }
            set {
                this.autoAssignmentRegionSettingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("bufferStock")]
        public SearchColumnLongField[] bufferStock {
            get {
                return this.bufferStockField;
            }
            set {
                this.bufferStockField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("city")]
        public SearchColumnStringField[] city {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("country")]
        public SearchColumnEnumSelectField[] country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dailyShippingCapacity")]
        public SearchColumnLongField[] dailyShippingCapacity {
            get {
                return this.dailyShippingCapacityField;
            }
            set {
                this.dailyShippingCapacityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("endTime")]
        public SearchColumnDateField[] endTime {
            get {
                return this.endTimeField;
            }
            set {
                this.endTimeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("geolocationMethod")]
        public SearchColumnEnumSelectField[] geolocationMethod {
            get {
                return this.geolocationMethodField;
            }
            set {
                this.geolocationMethodField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("isFriday")]
        public SearchColumnBooleanField[] isFriday {
            get {
                return this.isFridayField;
            }
            set {
                this.isFridayField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("isIncludeInCt")]
        public SearchColumnBooleanField[] isIncludeInCt {
            get {
                return this.isIncludeInCtField;
            }
            set {
                this.isIncludeInCtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isMonday")]
        public SearchColumnBooleanField[] isMonday {
            get {
                return this.isMondayField;
            }
            set {
                this.isMondayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isOffice")]
        public SearchColumnBooleanField[] isOffice {
            get {
                return this.isOfficeField;
            }
            set {
                this.isOfficeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isSaturday")]
        public SearchColumnBooleanField[] isSaturday {
            get {
                return this.isSaturdayField;
            }
            set {
                this.isSaturdayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isSunday")]
        public SearchColumnBooleanField[] isSunday {
            get {
                return this.isSundayField;
            }
            set {
                this.isSundayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isThursday")]
        public SearchColumnBooleanField[] isThursday {
            get {
                return this.isThursdayField;
            }
            set {
                this.isThursdayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isTuesday")]
        public SearchColumnBooleanField[] isTuesday {
            get {
                return this.isTuesdayField;
            }
            set {
                this.isTuesdayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("isWednesday")]
        public SearchColumnBooleanField[] isWednesday {
            get {
                return this.isWednesdayField;
            }
            set {
                this.isWednesdayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("latitude")]
        public SearchColumnDoubleField[] latitude {
            get {
                return this.latitudeField;
            }
            set {
                this.latitudeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locationType")]
        public SearchColumnEnumSelectField[] locationType {
            get {
                return this.locationTypeField;
            }
            set {
                this.locationTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("longitude")]
        public SearchColumnDoubleField[] longitude {
            get {
                return this.longitudeField;
            }
            set {
                this.longitudeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("makeInventoryAvailable")]
        public SearchColumnBooleanField[] makeInventoryAvailable {
            get {
                return this.makeInventoryAvailableField;
            }
            set {
                this.makeInventoryAvailableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("makeInventoryAvailableStore")]
        public SearchColumnBooleanField[] makeInventoryAvailableStore {
            get {
                return this.makeInventoryAvailableStoreField;
            }
            set {
                this.makeInventoryAvailableStoreField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("nameNoHierarchy")]
        public SearchColumnStringField[] nameNoHierarchy {
            get {
                return this.nameNoHierarchyField;
            }
            set {
                this.nameNoHierarchyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("nextPickupCutOffTime")]
        public SearchColumnDateField[] nextPickupCutOffTime {
            get {
                return this.nextPickupCutOffTimeField;
            }
            set {
                this.nextPickupCutOffTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("phone")]
        public SearchColumnStringField[] phone {
            get {
                return this.phoneField;
            }
            set {
                this.phoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("sameDayPickupCutOffTime")]
        public SearchColumnDateField[] sameDayPickupCutOffTime {
            get {
                return this.sameDayPickupCutOffTimeField;
            }
            set {
                this.sameDayPickupCutOffTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("soPredConfidence")]
        public SearchColumnDoubleField[] soPredConfidence {
            get {
                return this.soPredConfidenceField;
            }
            set {
                this.soPredConfidenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("soPredictedDays")]
        public SearchColumnLongField[] soPredictedDays {
            get {
                return this.soPredictedDaysField;
            }
            set {
                this.soPredictedDaysField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("startTime")]
        public SearchColumnDateField[] startTime {
            get {
                return this.startTimeField;
            }
            set {
                this.startTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("state")]
        public SearchColumnStringField[] state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("storePickupBufferStock")]
        public SearchColumnDoubleField[] storePickupBufferStock {
            get {
                return this.storePickupBufferStockField;
            }
            set {
                this.storePickupBufferStockField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("timeZone")]
        public SearchColumnEnumSelectField[] timeZone {
            get {
                return this.timeZoneField;
            }
            set {
                this.timeZoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("totalShippingCapacity")]
        public SearchColumnLongField[] totalShippingCapacity {
            get {
                return this.totalShippingCapacityField;
            }
            set {
                this.totalShippingCapacityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tranPrefix")]
        public SearchColumnStringField[] tranPrefix {
            get {
                return this.tranPrefixField;
            }
            set {
                this.tranPrefixField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("usesBins")]
        public SearchColumnBooleanField[] usesBins {
            get {
                return this.usesBinsField;
            }
            set {
                this.usesBinsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("zip")]
        public SearchColumnStringField[] zip {
            get {
                return this.zipField;
            }
            set {
                this.zipField = value;
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